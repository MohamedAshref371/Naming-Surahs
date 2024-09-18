Imports System.IO

Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace(Application.ProductVersion, "")
    Shared SurahsNamesList As New List(Of String())
    Dim idx As Integer
    Dim fmt As String
    Dim frt As String
    Dim execOrUndo As Integer
    Dim fname As String
    Private editingTextBox As New TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As String() = My.Resources.translations.Split("*")
        If temp.Length < 3 Then End

        For i = 0 To temp.Length - 1
            SurahsNamesList.Add(temp(i).Split("|"))
            Lang1.Items.Add(SurahsNamesList(i)(0))
            Lang2.Items.Add(SurahsNamesList(i)(0))
            Lang3.Items.Add(SurahsNamesList(i)(0))
        Next

        Lang1.SelectedIndex = 0
        Lang2.SelectedIndex = 1
        Lang3.SelectedIndex = 2

        editingTextBox.Visible = False
        editingTextBox.BorderStyle = BorderStyle.FixedSingle
        AddHandler editingTextBox.Leave, AddressOf EditingTextBox_Leave
        AddHandler editingTextBox.KeyDown, AddressOf EditingTextBox_KeyDown
        AddHandler editingTextBox.KeyPress, AddressOf TextBoxes_KeyPress
        Controls.Add(editingTextBox)

        If File.Exists(hm + "lang") Then Lg2(sender, e)
    End Sub

    Private Sub OpenFolderBtn_Click(sender As Object, e As EventArgs) Handles openFolderBtn.Click
        If allFilesCheckBox.Checked Or audioFilesCheckBox.Checked Or videoFilesCheckBox.Checked Then
            If allFilesCheckBox.Checked Then
                audioFilesCheckBox.Checked = True : videoFilesCheckBox.Checked = True
            End If
            If Folder.ShowDialog = DialogResult.OK Then
                Link.Text = Folder.SelectedPath
                unknownItemsList.Clear() : namingFailedItemsList.Clear() : notExistItemsList.Clear() : errorItemsList.Clear()
                List.Items.Clear() : List2.Items.Clear()
                executeBtn.Enabled = False

                If File.Exists(Link.Text + "\Name replacement process.txt") AndAlso
                    MessageBox.Show("ملف إعادة الأسماء القديمة موجود بالفعل، إذا أردت استعادتها استعمل زر الندم
The 'Return Old Names' File already exists, if you want to restore them, use the regret button.", "😢😢😢", MessageBoxButtons.RetryCancel) = DialogResult.Cancel Then
                    Exit Sub
                End If

                For Each foundFile As String In Directory.GetFiles(Folder.SelectedPath)
                    fname = Path.GetFileName(foundFile)
                    fmt = Path.GetExtension(fname).ToLower
                    If fmt = "" Then fmt = "*"
                    If allFilesCheckBox.Checked OrElse
                        audioFilesCheckBox.Checked AndAlso ".mp3.wma.m4a.flac.aac.ape.wav.wv.dts.ac3.mmf.amr.m4r.oog.mp2.dat".Contains(fmt) OrElse
                        videoFilesCheckBox.Checked AndAlso ".mp4.kmv.avi.flv.mov.wmv.3gp.3g2.mpg.vob.ogg.webm".Contains(fmt) Then
                        List.Items.Add(fname)
                    End If
                Next
                execOrUndo = 0
                If List.Items.Count > 0 Then
                    checkFilesNameBtn.Enabled = True
                Else
                    If allFilesCheckBox.Checked Then
                        List.Items.Add("المجلد فارغ")
                        List.Items.Add("The folder is empty")
                    Else
                        List.Items.Add("الصيغ المطلوبة غير موجودة")
                        List.Items.Add("Required formats do not exist")
                    End If
                End If
            End If
        Else
            audioFilesCheckBox.Checked = True : videoFilesCheckBox.Checked = True
        End If
    End Sub

    Private Sub Surah(num As Integer)
        If num > 0 Then
            frt = num.ToString.PadLeft(3, "0")

            If TurnOn1.Checked Then frt += concat1.Text + SurahsNamesList(Lang1.SelectedIndex)(num) + concat2.Text
            If TurnOn2.Checked Then frt += SurahsNamesList(Lang2.SelectedIndex)(num) + concat3.Text
            If TurnOn3.Checked Then frt += SurahsNamesList(Lang3.SelectedIndex)(num) + concat4.Text

            frt += fmt
        Else
            frt = List.Items.Item(idx)
            unknownItemsList.Add(idx)
        End If
    End Sub

    Private Function CheckANumberInFileName(s As String, n As Integer) As Integer
        If s.Length < n Then Return 0

        Dim text As String = ""
        For i = 0 To s.Length - 1
            If Char.IsDigit(s(i)) Then
                text += s(i)
            ElseIf text.Length >= 1 AndAlso Char.IsDigit(text(text.Length - 1)) Then
                text += ","
            End If
        Next

        Dim arr As String() = text.Split(",")
        For i = 0 To arr.Length - 1
            If arr.Length = n AndAlso arr(i) >= 1 AndAlso arr(i) <= 114 Then Return arr(i)
        Next

        Return 0
    End Function

    Private Sub CheckSurahNumber()
        fname = List.Items.Item(idx).ToLower.replace("َ", "").replace("ِ", "").replace("ُ", "").replace("ً", "").replace("ٍ", "").replace("ٌ", "").replace("ْ", "").replace("ّ", "").replace("'", "").replace("-", "").Replace(fmt, "")
        Dim num As Integer = CheckANumberInFileName(fname, 3)
        If num >= 1 Then
            Surah(num)
            Exit Sub
        End If

        num = CheckANumberInFileName(fname, 2)
        If num >= 1 Then
            Surah(num)
            Exit Sub
        End If

        Dim temp As String() = My.Resources.codes.Split("*")
        Dim pair As String()
        For i = 0 To temp.Length - 1
            pair = temp(i).Split("|")
            If fname.Contains(pair(0)) Then
                If pair(1) = "?" Then
                    Surah(0)
                Else
                    Surah(pair(1))
                End If
                Exit Sub
            End If
        Next

        Surah(CheckANumberInFileName(fname, 1))
    End Sub

    Private Sub CheckFilesNameBtn_Click(sender As Object, e As EventArgs) Handles checkFilesNameBtn.Click
        List.SelectedIndex = -1
        List2.Items.Clear()
        For idx = 0 To List.Items.Count - 1
            fmt = Path.GetExtension(List.Items.Item(idx))
            If fmt = "" Then fmt = "*"
            CheckSurahNumber()
            List2.Items.Add(frt)
        Next
        executeBtn.Enabled = True
        List.Invalidate()
    End Sub

    Private Sub ExecuteBtn_Click(sender As Object, e As EventArgs) Handles executeBtn.Click
        executeBtn.Enabled = False
        If execOrUndo = 0 Then
            fname = ""
            For idx = 0 To List.Items.Count - 1
                fmt = Path.GetExtension(List.Items.Item(idx))
                If fmt = "" Then fmt = "*"
                If RenameFile() Then
                    fname += List.Items.Item(idx) + "|" + List2.Items.Item(idx) + "*"
                End If
            Next
            If fname <> "" Then File.WriteAllText(Link.Text + "\Name replacement process.txt", fname)
            checkFilesNameBtn.Enabled = False
        Else
            For idx = 0 To List.Items.Count - 1
                RenameFile()
            Next
            File.Delete(Link.Text + "\Name replacement process.txt")
        End If
        List.Invalidate() : List2.Invalidate()
    End Sub

    Shared unknownItemsList As New List(Of Integer)
    Shared namingFailedItemsList As New List(Of Integer)
    Shared notExistItemsList As New List(Of Integer)
    Shared errorItemsList As New List(Of Integer)
    Private Function RenameFile() As Boolean
        Try
            If List2.Items.Item(idx) <> List.Items.Item(idx) Then
                If File.Exists(Link.Text + "\" + List.Items.Item(idx)) Then
                    If File.Exists(Link.Text + "\" + List2.Items.Item(idx)) Then
                        List2.Items.Item(idx) = List.Items.Item(idx)
                        For i = 0 To 9
                            If Not File.Exists($"{Link.Text}\{List2.Items.Item(idx).Replace(fmt, "")}_{i}{fmt}") Then
                                List2.Items.Item(idx) = $"{List2.Items.Item(idx).Replace(fmt, "")}_{i}{fmt}"
                                Exit For
                            End If
                        Next
                    End If
                    If List2.Items.Item(idx) = List.Items.Item(idx) Then
                        namingFailedItemsList.Add(idx)
                    Else
                        File.Move(Link.Text + "\" + List.Items.Item(idx), Link.Text + "\" + List2.Items.Item(idx))
                        Return True
                    End If
                Else
                    notExistItemsList.Add(idx)
                End If
            End If
        Catch ex As Exception
            errorItemsList.Add(idx)
        End Try
        Return False
    End Function

    Private Sub ListBox_DrawItem(sender As Object, e As DrawItemEventArgs) Handles List.DrawItem, List2.DrawItem
        If e.Index < 0 Then Return

        Dim backgroundColor As Color
        If namingFailedItemsList.Contains(e.Index) Then
            backgroundColor = Color.Yellow
        ElseIf notExistItemsList.Contains(e.Index) Then
            backgroundColor = Color.Orange
        ElseIf errorItemsList.Contains(e.Index) Then
            backgroundColor = Color.Red
        ElseIf unknownItemsList.Contains(e.Index) Then
            backgroundColor = Color.LightGray
        Else
            backgroundColor = e.BackColor
        End If

        e.Graphics.FillRectangle(New SolidBrush(backgroundColor), e.Bounds)

        e.Graphics.DrawString(sender.Items(e.Index).ToString(), e.Font, Brushes.Black, e.Bounds)

        e.DrawFocusRectangle()
    End Sub

    Private Sub RegretBtn_Click(sender As Object, e As EventArgs) Handles regretBtn.Click
        On Error Resume Next
        If Folder.ShowDialog = DialogResult.OK Then
            Link.Text = Folder.SelectedPath
            unknownItemsList.Clear() : namingFailedItemsList.Clear() : notExistItemsList.Clear() : errorItemsList.Clear()
            List.Items.Clear() : List2.Items.Clear()
            checkFilesNameBtn.Enabled = False : executeBtn.Enabled = False
            If File.Exists(Link.Text + "\Name replacement process.txt") Then
                Dim arr As String() = File.ReadAllText(Link.Text + "\Name replacement process.txt").Split("*")
                Dim arr2 As String()
                For idx = 0 To arr.Length - 1
                    arr2 = arr(idx).Split("|")
                    If arr2.Length = 2 Then
                        List.Items.Add(arr2(1))
                        List2.Items.Add(arr2(0))
                    End If
                Next
                executeBtn.Enabled = True : execOrUndo = 1
            Else
                MsgBox("لم تفعل شيئاً تندم عليه أو ربما عليك أن تندم أيضاً على قيامك بحذف ملف الندم هههههههه
You haven't done anything you regret, or maybe you should regret deleting the regret file hahahaha", vbInformation, "😢😢😢")
            End If
        End If
    End Sub

    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        Process.Start("https://github.com/mohamedashref371/Naming-Surahs")
    End Sub

    Private Sub Lg2(sender As Object, e As EventArgs) Handles languageBtn.Click
        If languageBtn.Text = "English" Then
            languageBtn.Text = "عربي"
            File.WriteAllText(hm + "lang", "1")
            openFolderBtn.Text = "Open folder"
            checkFilesNameBtn.Text = "Scan"
            executeBtn.Text = "Execute"
            aboutBtn.Text = "This Program"
            L9.Text = "Surah
number"
            TurnOn1.Text = "Name in" : TurnOn2.Text = "Name in" : TurnOn3.Text = "Name in"
            TurnOn1.RightToLeft = RightToLeft.No : TurnOn2.RightToLeft = RightToLeft.No : TurnOn3.RightToLeft = RightToLeft.No
            allFilesCheckBox.Text = "All files" : audioFilesCheckBox.Text = "Audio" : videoFilesCheckBox.Text = "Video"
            regretBtn.Text = "I regret what I did"
            color1desc.Text = "The Surah name could not be identified from the file name"
            color2desc.Text = "Could not find a suitable file name in the folder"
            color3desc.Text = "The file was not found during the renaming process"
            color4desc.Text = "An error occurred during the renaming process"

        Else
            languageBtn.Text = "English"
            Kill(hm + "lang")
            openFolderBtn.Text = "فتح المجلد"
            checkFilesNameBtn.Text = "فحص"
            executeBtn.Text = "تنفيذ"
            aboutBtn.Text = "هذا البرنامج"
            L9.Text = "رقم
السورة"
            TurnOn1.Text = "الإسم بـ" : TurnOn2.Text = "الإسم بـ" : TurnOn3.Text = "الإسم بـ"
            TurnOn1.RightToLeft = RightToLeft.Yes : TurnOn2.RightToLeft = RightToLeft.Yes : TurnOn3.RightToLeft = RightToLeft.Yes
            allFilesCheckBox.Text = "كل الملفات" : audioFilesCheckBox.Text = "صوت" : videoFilesCheckBox.Text = "فيديو"
            regretBtn.Text = "أنا نادم على ما فعلت"
            color1desc.Text = "لم يتم التعرف على السورة من إسم الملف"
            color2desc.Text = "لم يتم التمكن من إيجاد إسم مناسب للملف داخل المجلد"
            color3desc.Text = "لم يتم إيجاد الملف أثناء عملية التسمية"
            color4desc.Text = "حدث خطأ أثناء عملية التسمية"
        End If
    End Sub

    Private Sub TurnOn1_CheckedChanged(sender As Object, e As EventArgs) Handles TurnOn1.CheckedChanged
        If Not TurnOn1.Checked Then
            TurnOn2.Checked = False
            TurnOn2.Enabled = False
            concat1.Enabled = False
            concat2.Enabled = False
            Lang1.Enabled = False
        Else
            TurnOn2.Enabled = True
            concat1.Enabled = True
            concat2.Enabled = True
            Lang1.Enabled = True
        End If
    End Sub

    Private Sub TurnOn2_CheckedChanged(sender As Object, e As EventArgs) Handles TurnOn2.CheckedChanged
        If Not TurnOn2.Checked Then
            TurnOn3.Checked = False
            TurnOn3.Enabled = False
            concat3.Enabled = False
            Lang2.Enabled = False
        Else
            TurnOn3.Enabled = True
            concat3.Enabled = True
            Lang2.Enabled = True
        End If
    End Sub

    Private Sub TurnOn3_CheckedChanged(sender As Object, e As EventArgs) Handles TurnOn3.CheckedChanged
        If Not TurnOn3.Checked Then
            concat4.Enabled = False
            Lang3.Enabled = False
        Else
            concat4.Enabled = True
            Lang3.Enabled = True
        End If
    End Sub

    Private Sub Langs(langI As ComboBox, langJ As ComboBox, langK As ComboBox)
        Dim list As New List(Of Integer)
        list.AddRange({0, 1, 2})
        list.Remove(langI.SelectedIndex)

        If langJ.SelectedIndex = langI.SelectedIndex Then
            list.Remove(langK.SelectedIndex)
            langJ.SelectedIndex = list(0)
        ElseIf langK.SelectedIndex = langI.SelectedIndex Then
            list.Remove(langJ.SelectedIndex)
            langK.SelectedIndex = list(0)
        End If
    End Sub

    Private Sub Lang1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lang1.SelectedIndexChanged
        Langs(Lang1, Lang2, Lang3)
    End Sub

    Private Sub Lang2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lang2.SelectedIndexChanged
        Langs(Lang2, Lang1, Lang3)
    End Sub

    Private Sub Lang3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lang3.SelectedIndexChanged
        Langs(Lang3, Lang1, Lang2)
    End Sub

    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        If List2.Items.Count = List.Items.Count Then
            List2.SelectedIndex = List.SelectedIndex
        End If
    End Sub

    Private Sub List2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List2.SelectedIndexChanged
        List.SelectedIndex = List2.SelectedIndex
    End Sub

    Private Sub List_KeyDown(sender As Object, e As KeyEventArgs) Handles List.KeyDown
        If e.KeyCode = Keys.Delete AndAlso List.SelectedIndex >= 0 Then
            Dim index As Integer = List.SelectedIndex
            If List2.Items.Count = List.Items.Count Then
                List2.Items.RemoveAt(index)
                List2.SelectedIndex = -1
            End If
            List.Items.RemoveAt(index)
            List.SelectedIndex = -1
        End If
    End Sub

    Private Sub List2_KeyDown(sender As Object, e As KeyEventArgs) Handles List2.KeyDown
        If e.KeyCode = Keys.Delete AndAlso List2.SelectedIndex >= 0 Then
            Dim index As Integer = List2.SelectedIndex
            List.Items.RemoveAt(index)
            List2.Items.RemoveAt(index)
            List.SelectedIndex = -1
            List2.SelectedIndex = -1
        End If
    End Sub

    Private Sub List2_DoubleClick(sender As Object, e As EventArgs) Handles List2.DoubleClick
        If executeBtn.Enabled And List2.SelectedIndex <> -1 Then
            editingTextBox.Text = List2.SelectedItem.ToString()

            editingTextBox.SetBounds(List2.Left, List2.GetItemRectangle(List2.SelectedIndex).Top + List2.Top, List2.Width, List2.ItemHeight)

            editingTextBox.Visible = True
            editingTextBox.BringToFront()
            editingTextBox.Focus()
        End If
    End Sub

    Private Sub List_TopIndexChanged(sender As Object, e As EventArgs) Handles List.MouseCaptureChanged, List.MouseWheel
        List2.TopIndex = List.TopIndex
    End Sub

    Private Sub List2_TopIndexChanged(sender As Object, e As EventArgs) Handles List2.MouseCaptureChanged, List2.MouseWheel
        List.TopIndex = List2.TopIndex
    End Sub

    Private Sub EditingTextBox_Leave(sender As Object, e As EventArgs)
        If List2.SelectedIndex <> -1 And editingTextBox.Text.Trim <> "" Then
            List2.Items(List2.SelectedIndex) = editingTextBox.Text
            unknownItemsList.Remove(List2.SelectedIndex)
        End If
        editingTextBox.Visible = False
    End Sub

    Private Sub EditingTextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            EditingTextBox_Leave(Nothing, Nothing)
        End If
    End Sub

    Private Sub TextBoxes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles concat1.KeyPress, concat2.KeyPress, concat3.KeyPress, concat4.KeyPress
        If "\/:*?""<>|".Contains(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class
