Imports System.IO

Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace(Application.ProductVersion, "")
    Shared SurahsNamesList As New List(Of String())
    Dim idx As Integer
    Dim fmt As String
    Dim frt As String
    Dim execOrUndo As Integer
    Dim fname As String
    Private editingTextBox As New TextBox()

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
        AddHandler editingTextBox.Leave, AddressOf TextBox_Leave
        Controls.Add(editingTextBox)

        If My.Computer.FileSystem.FileExists(hm + "lang") Then
            Lg2(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If CB7.Checked = True Or CB3.Checked = True Or CB4.Checked = True Then
            If CB7.Checked = True Then
                CB3.Checked = True : CB4.Checked = True
            End If
            If Folder.ShowDialog = DialogResult.OK Then
                Link.Text = Folder.SelectedPath
                List.Items.Clear() : List2.Items.Clear()
                ExecuteBtn.Enabled = False
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Folder.SelectedPath)
                    fname = My.Computer.FileSystem.GetName(foundFile)
                    Dim fi As New IO.FileInfo(fname)
                    fmt = fi.Extension.ToLower
                    If fmt = "" Then
                        fmt = "*"
                    End If
                    If CB7.Checked = True Or (CB3.Checked = True And ".mp3.wma.m4a.flac.aac.ape.wav.wv.dts.ac3.mmf.amr.m4r.oog.mp2.dat".Contains(fmt)) Or (CB4.Checked = True And ".mp4.kmv.avi.flv.mov.wmv.3gp.3g2.mpg.vob.ogg.webm".Contains(fmt)) Then
                        List.Items.Add(fname)
                    End If
                Next
                execOrUndo = 0
                If List.Items.Count > 0 Then
                    CheckBtn.Enabled = True
                Else
                    If CB7.Checked = True Then
                        List.Items.Add("المجلد فارغ")
                        List.Items.Add("The folder is empty")
                    Else
                        List.Items.Add("الصيغ المطلوبة غير موجودة")
                        List.Items.Add("Required formats do not exist")
                    End If
                End If
            End If
        Else
            CB3.Checked = True : CB4.Checked = True
        End If
    End Sub

    Private Sub CB5_ChCh() Handles TurnOn1.CheckedChanged
        If TurnOn1.Checked = True Then
            Lang1.Enabled = True
        Else
            Lang1.Enabled = False : TurnOn2.Checked = False
        End If
    End Sub

    Private Sub Surah(num As Integer)
        If num > 0 Then
            frt = num.ToString.PadLeft(3, "0")
            If TurnOn1.Checked = True Then
                frt += concat1.Text + SurahsNamesList(Lang1.SelectedIndex)(num) + concat2.Text
            End If
            If TurnOn2.Checked = True Then
                frt += SurahsNamesList(Lang2.SelectedIndex)(num) + concat3.Text
            End If
            If TurnOn3.Checked = True Then
                frt += SurahsNamesList(Lang2.SelectedIndex)(num) + concat4.Text
            End If
            frt += fmt
        Else
            frt = List.Items.Item(idx)
        End If
    End Sub

    Private Function CheckANumberInFileName(s As String, n As Integer) As Integer
        If s.Length < n Then Return 0

        Dim num As Integer
        For i = 0 To s.Length - n
            If Integer.TryParse(s.Substring(i, n), num) AndAlso num >= 1 AndAlso num <= 114 Then Return num
        Next

        Return 0
    End Function

    Private Sub Bu1()
        fname = List.Items.Item(idx).ToLower.replace("َ", "").replace("ِ", "").replace("ُ", "").replace("ً", "").replace("ٍ", "").replace("ٌ", "").replace("ْ", "").replace("ّ", "").replace("'", "").replace("-", "").Replace(fmt, "")
        Dim num As Integer = CheckANumberInFileName(fname, 3)
        If num > 0 Then
            Surah(num)
            Exit Sub
        End If

        num = CheckANumberInFileName(fname, 2)
        If num > 0 Then
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

    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        List.SelectedIndex = -1
        List2.Items.Clear()
        For idx = 0 To List.Items.Count - 1
            Dim fi As New IO.FileInfo(List.Items.Item(idx))
            fmt = fi.Extension
            If fmt = "" Then fmt = "*"
            Bu1()
            List2.Items.Add(frt)
        Next
        ExecuteBtn.Enabled = True
    End Sub

    Private Sub ExecuteBtn_Click(sender As Object, e As EventArgs) Handles ExecuteBtn.Click
        ExecuteBtn.Enabled = False
        If execOrUndo = 0 Then
            fname = List.Items.Count
            fname += "
"
            For idx = 0 To List.Items.Count - 1
                Dim fi As New IO.FileInfo(List.Items.Item(idx))
                fmt = fi.Extension
                If fmt = "" Then fmt = "*"
                If List.Items.Item(idx) = List2.Items.Item(idx) Then
                Else
                    If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(idx)) Then
                        If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(idx).Replace(fmt, "") + "_2" + fmt) Then
                            List2.Items.Item(idx) = List.Items.Item(idx)
                        Else
                            My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(idx), List2.Items.Item(idx).Replace(fmt, "") + "_2" + fmt)
                            List2.Items.Item(idx) = List2.Items.Item(idx).Replace(fmt, "") + "_2" + fmt
                        End If
                    Else
                        My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(idx), List2.Items.Item(idx))
                    End If
                End If
                fname += List.Items.Item(idx) + "
" + List2.Items.Item(idx) + "
"
            Next
            If List.Items.Count > 1 Then
                My.Computer.FileSystem.WriteAllText(Link.Text + "\Name replacement process.txt", fname, False)
            End If
            CheckBtn.Enabled = False
        Else
            For idx = 0 To List.Items.Count - 1
                If My.Computer.FileSystem.FileExists(Link.Text + "\" + List.Items.Item(idx)) Then
                    If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(idx)) Then
                    Else
                        My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(idx), List2.Items.Item(idx))
                    End If
                End If
            Next
            My.Computer.FileSystem.DeleteFile(Link.Text + "\Name replacement process.txt")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        On Error Resume Next
        If Folder.ShowDialog = DialogResult.OK Then
            Dim num As Integer = -1
            Link.Text = Folder.SelectedPath
            List.Items.Clear() : List2.Items.Clear()
            CheckBtn.Enabled = False : ExecuteBtn.Enabled = False
            If My.Computer.FileSystem.FileExists(Link.Text + "\Name replacement process.txt") Then
                RTB.Text = My.Computer.FileSystem.ReadAllText(Link.Text + "\Name replacement process.txt")
                num = RTB.Lines(0)
                If num > 0 Then
                    For idx = 1 To num + 1
                        List.Items.Add(RTB.Lines(2 * idx))
                        List2.Items.Add(RTB.Lines(2 * idx - 1))
                    Next
                    ExecuteBtn.Enabled = True : execOrUndo = 1
                Else
                    MsgBox("هناك شيء غير صحيح
There is something not right", vbCritical, ":(")
                End If
            Else
                MsgBox("لم تفعل شيئاً تندم عليه أو ربما عليك أن تندم أيضاً على قيامك حذف ملف الندم هههههههه
You haven't done anything you regret, or maybe you should regret deleting the regret file hahahaha", vbInformation, "😢😢😢")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Process.Start("https://github.com/mohamedashref371/naming-Surahs")
    End Sub

    Private Sub Lg2(sender As Object, e As EventArgs) Handles lg.Click
        If lg.Text = "English" Then
            lg.Text = "عربي"
            My.Computer.FileSystem.WriteAllText(hm + "lang", "1", False)
            Btn2.Text = "Open folder"
            CheckBtn.Text = "Scan"
            ExecuteBtn.Text = "Execute"
            Btn4.Text = "About designer"
            L9.Text = "Surah
number"
            TurnOn1.Text = "Name in" : TurnOn2.Text = "Name in" : TurnOn3.Text = "Name in"
            TurnOn1.RightToLeft = RightToLeft.No : TurnOn2.RightToLeft = RightToLeft.No : TurnOn3.RightToLeft = RightToLeft.No
            CB7.Text = "All files" : CB3.Text = "Audio" : CB4.Text = "Video"
            Btn5.Text = "I regret what I did"
        Else
            lg.Text = "English"
            Kill(hm + "lang")
            Btn2.Text = "فتح المجلد"
            CheckBtn.Text = "فحص"
            ExecuteBtn.Text = "تنفيذ"
            Btn4.Text = "عن المصمم"
            L9.Text = "رقم
السورة"
            TurnOn1.Text = "الإسم بـ" : TurnOn2.Text = "الإسم بـ" : TurnOn3.Text = "الإسم بـ"
            TurnOn1.RightToLeft = RightToLeft.Yes : TurnOn2.RightToLeft = RightToLeft.Yes : TurnOn3.RightToLeft = RightToLeft.Yes
            CB7.Text = "كل الملفات" : CB3.Text = "صوت" : CB4.Text = "فيديو"
            Btn5.Text = "أنا نادم على ما فعلت"
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
        If ExecuteBtn.Enabled Then
            List2.SelectedIndex = List.SelectedIndex
        End If
    End Sub

    Private Sub List2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List2.SelectedIndexChanged
        List.SelectedIndex = List2.SelectedIndex
    End Sub

    Private Sub List_KeyDown(sender As Object, e As KeyEventArgs) Handles List.KeyDown
        If e.KeyCode = Keys.Delete AndAlso List.SelectedIndex >= 0 Then
            Dim index As Integer = List.SelectedIndex
            If ExecuteBtn.Enabled Then
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
        If List2.SelectedIndex <> -1 Then
            editingTextBox.Text = List2.SelectedItem.ToString()

            editingTextBox.SetBounds(List2.Left, List2.GetItemRectangle(List2.SelectedIndex).Top + List2.Top, List2.Width, List2.ItemHeight)

            editingTextBox.Visible = True
            editingTextBox.BringToFront()
            editingTextBox.Focus()
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs)
        If List2.SelectedIndex <> -1 Then
            List2.Items(List2.SelectedIndex) = editingTextBox.Text
            editingTextBox.Visible = False
        End If
    End Sub
End Class
