Public Class Form1
    Dim hm As String = My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData.Replace("1.0.0.0", "")
    Dim a As Integer
    Dim b As Integer
    Dim fmt As String
    Dim frt As String
    Dim q As Integer
    Dim s As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(hm + "lang") Then
            lg2(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If CB7.Checked = True Or CB3.Checked = True Or CB4.Checked = True Then
            If CB7.Checked = True Then
                CB3.Checked = True : CB4.Checked = True
            End If
            If Folder.ShowDialog = DialogResult.OK Then
                a = -1
                Link.Text = Folder.SelectedPath
                List.Items.Clear() : List2.Items.Clear()
                Btn3.Enabled = False : Btn6.Enabled = False
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(Folder.SelectedPath)
                    s = My.Computer.FileSystem.GetName(foundFile)
                    Dim fi As New IO.FileInfo(s)
                    fmt = fi.Extension.ToLower
                    If fmt = "" Then
                        fmt = "*"
                    End If
                    If CB7.Checked = True Or (CB3.Checked = True And ".mp3.wma.m4a.flac.aac.ape.wav.wv.dts.ac3.mmf.amr.m4r.oog.mp2.dat".Contains(fmt)) Or (CB4.Checked = True And ".mp4.kmv.avi.flv.mov.wmv.3gp.3g2.mpg.vob.ogg.webm".Contains(fmt)) Then
                        List.Items.Add(s)
                    End If
                Next
                a = List.Items.Count - 1 : q = 0
                If a > -1 Then
                    Btn1.Enabled = True
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

    Private Sub CB5_ChCh() Handles CB5.CheckedChanged
        If CB5.Checked = True Then
            CB1.Enabled = True
        Else
            CB1.Enabled = False : CB6.Checked = False
        End If
    End Sub

    Private Sub S001()
        frt = "001"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفاتحة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Fatihah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفاتحة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Fatihah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S002()
        frt = "002"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "البقرة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Baqarah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "البقرة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Baqarah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S003()
        frt = "003"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "آل عمران"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ali 'Imran"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "آل عمران"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ali 'Imran"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S004()
        frt = "004"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النساء"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Nisa"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النساء"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Nisa"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S005()
        frt = "005"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المائدة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ma'idah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المائدة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ma'idah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S006()
        frt = "006"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأنعام"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-An'am"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأنعام"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-An'am"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S007()
        frt = "007"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأعراف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-A'raf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأعراف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-A'raf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S008()
        frt = "008"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأنفال"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Anfal"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأنفال"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Anfal"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S009()
        frt = "009"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التوبة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Tawbah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التوبة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Tawbah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S010()
        frt = "010"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "يونس"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Yunus"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "يونس"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Yunus"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S011()
        frt = "011"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "هود"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Hud"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "هود"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Hood"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S012()
        frt = "012"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "يوسف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Yusuf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "يوسف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Yusuf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S013()
        frt = "013"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الرعد"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ar-Ra'd"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الرعد"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ar-Ra'd"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S014()
        frt = "014"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "إبراهيم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ibrahim"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "إبراهيم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ibrahim"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S015()
        frt = "015"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحجر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Hijr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحجر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Hijr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S016()
        frt = "016"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النحل"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Nahl"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النحل"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Nahl"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S017()
        frt = "017"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الإسراء"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Isra"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الإسراء"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Isra"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S018()
        frt = "018"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الكهف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Kahf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الكهف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Kahf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S019()
        frt = "019"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "مريم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Maryam"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "مريم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Maryam"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S020()
        frt = "020"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "طه"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ta-Ha"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "طه"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ta-Ha"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S021()
        frt = "021"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأنبياء"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Anbiya"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأنبياء"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Anbiya"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S022()
        frt = "022"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحج"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Hajj"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحج"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Hajj"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S023()
        frt = "023"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المؤمنون"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mu'minun"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المؤمنون"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mu'minun"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S024()
        frt = "024"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النور"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Nur"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النور"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Nur"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S025()
        frt = "025"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفرقان"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Furqan"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفرقان"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Furqan"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S026()
        frt = "026"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الشعراء"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ash-Shu'ara"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الشعراء"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ash-Shu'ara"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S027()
        frt = "027"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النمل"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Naml"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النمل"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Naml"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S028()
        frt = "028"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القصص"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qasas"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القصص"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qasas"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S029()
        frt = "029"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "العنكبوت"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ankabut"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "العنكبوت"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ankabut"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S030()
        frt = "030"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الروم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ar-Rum"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الروم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ar-Rum"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S031()
        frt = "031"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "لقمان"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Luqman"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "لقمان"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Luqman"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S032()
        frt = "032"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "السجدة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "As-Sajdah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "السجدة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "As-Sajdah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S033()
        frt = "033"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأحزاب"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ahzab"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأحزاب"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ahzab"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S034()
        frt = "034"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "سبأ"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Saba"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "سبأ"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Saba"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S035()
        frt = "035"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "فاطر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Fatir"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "فاطر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Fatir"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S036()
        frt = "036"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "يس"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ya-Sin"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "يس"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ya-Sin"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S037()
        frt = "037"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الصافات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "As-Saffat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الصافات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "As-Saffat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S038()
        frt = "038"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "ص"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Sad"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "ص"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Sad"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S039()
        frt = "039"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الزمر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Az-Zumar"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الزمر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Az-Zumar"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S040()
        frt = "040"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "غافر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ghafir"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "غافر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ghafir"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S041()
        frt = "041"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "فصلت"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Fussilat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "فصلت"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Fussilat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S042()
        frt = "042"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الشورى"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ash-Shuraa"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الشورى"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ash-Shuraa"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S043()
        frt = "043"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الزخرف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Az-Zukhruf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الزخرف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Az-Zukhruf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S044()
        frt = "044"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الدخان"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ad-Dukhan"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الدخان"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ad-Dukhan"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S045()
        frt = "045"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الجاثية"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Jathiyah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الجاثية"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Jathiyah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S046()
        frt = "046"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأحقاف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ahqaf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأحقاف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ahqaf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S047()
        frt = "047"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "محمد"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Muhammad"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "محمد"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Muhammad"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S048()
        frt = "048"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفتح"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Fath"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفتح"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Fath"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S049()
        frt = "049"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحجرات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Hujurat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحجرات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Hujurat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S050()
        frt = "050"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "ق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Qaf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "ق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Qaf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S051()
        frt = "051"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الذاريات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Adh-Dhariyat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الذاريات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Adh-Dhariyat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S052()
        frt = "052"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الطور"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Tur"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الطور"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Tur"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S053()
        frt = "053"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النجم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Najm"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النجم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Najm"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S054()
        frt = "054"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القمر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qamar"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القمر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qamar"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S055()
        frt = "055"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الرحمن"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ar-Rahman"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الرحمن"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ar-Rahman"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S056()
        frt = "056"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الواقعة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Waqi'ah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الواقعة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Waqi'ah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S057()
        frt = "057"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحديد"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Hadid"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحديد"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Hadid"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S058()
        frt = "058"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المجادلة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mujadila"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المجادلة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mujadila"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S059()
        frt = "059"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحشر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Hashr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحشر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Hashr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S060()
        frt = "060"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الممتحنة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mumtahanah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الممتحنة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mumtahanah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S061()
        frt = "061"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الصف"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "As-Saf"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الصف"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "As-Saf"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S062()
        frt = "062"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الجمعة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Jumu'ah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الجمعة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Jumu'ah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S063()
        frt = "063"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المنافقون"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Munafiqun"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المنافقون"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Munafiqun"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S064()
        frt = "064"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التغابن"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Taghabun"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التغابن"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Taghabun"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S065()
        frt = "065"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الطلاق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Talaq"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الطلاق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Talaq"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S066()
        frt = "066"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التحريم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Tahrim"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التحريم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Tahrim"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S067()
        frt = "067"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الملك"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mulk"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الملك"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mulk"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S068()
        frt = "068"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القلم"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qalam"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القلم"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qalam"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S069()
        frt = "069"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الحاقة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Haqqah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الحاقة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Haqqah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S070()
        frt = "070"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المعارج"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ma'arij"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المعارج"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ma'arij"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S071()
        frt = "071"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "نوح"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Nuh"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "نوح"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Nuh"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S072()
        frt = "072"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الجن"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Jinn"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الجن"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Jinn"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S073()
        frt = "073"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المزمل"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Muzzammil"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المزمل"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Muzzammil"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S074()
        frt = "074"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المدثر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Muddaththir"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المدثر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Muddaththir"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S075()
        frt = "075"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القيامة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qiyamah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القيامة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qiyamah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S076()
        frt = "076"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الإنسان"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Insan"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الإنسان"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Insan"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S077()
        frt = "077"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المرسلات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mursalat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المرسلات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mursalat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S078()
        frt = "078"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النبأ"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Naba"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النبأ"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Naba"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S079()
        frt = "079"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النازعات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Nazi'at"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النازعات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Nazi'at"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S080()
        frt = "080"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "عبس"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "'Abasa"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "عبس"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "'Abasa"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S081()
        frt = "081"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التكوير"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Takwir"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التكوير"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Takwir"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S082()
        frt = "082"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الإنفطار"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Infitar"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الإنفطار"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Infitar"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S083()
        frt = "083"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المطففين"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Mutaffifin"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المطففين"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Mutaffifin"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S084()
        frt = "084"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الإنشقاق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Inshiqaq"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الإنشقاق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Inshiqaq"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S085()
        frt = "085"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "البروج"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Buruj"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "البروج"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Buruj"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S086()
        frt = "086"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الطارق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Tariq"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الطارق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Tariq"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S087()
        frt = "087"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الأعلى"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-A'la"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الأعلى"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-A'la"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S088()
        frt = "088"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الغاشية"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ghashiyah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الغاشية"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ghashiyah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S089()
        frt = "089"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفجر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Fajr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفجر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Fajr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S090()
        frt = "090"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "البلد"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Balad"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "البلد"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Balad"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S091()
        frt = "091"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الشمس"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ash-Shams"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الشمس"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ash-Shams"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S092()
        frt = "092"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الليل"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Layl"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الليل"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Layl"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S093()
        frt = "093"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الضحى"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ad-Duhaa"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الضحى"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ad-Duhaa"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S094()
        frt = "094"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الشرح"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Ash-Sharh"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الشرح"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Ash-Sharh"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S095()
        frt = "095"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التين"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Tin"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التين"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Tin"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S096()
        frt = "096"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "العلق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-'Alaq"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "العلق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-'Alaq"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S097()
        frt = "097"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القدر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qadr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القدر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qadr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S098()
        frt = "098"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "البينة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Bayyinah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "البينة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Bayyinah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S099()
        frt = "099"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الزلزلة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Az-Zalzalah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الزلزلة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Az-Zalzalah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S100()
        frt = "100"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "العاديات"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-'Adiyat"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "العاديات"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-'Adiyat"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S101()
        frt = "101"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "القارعة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Qari'ah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "القارعة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Qari'ah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S102()
        frt = "102"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "التكاثر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "At-Takathur"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "التكاثر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "At-Takathur"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S103()
        frt = "103"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "العصر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-'Asr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "العصر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-'Asr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S104()
        frt = "104"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الهمزة"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Humazah"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الهمزة"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Humazah"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S105()
        frt = "105"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفيل"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Fil"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفيل"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Fil"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S106()
        frt = "106"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "قريش"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Quraysh"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "قريش"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Quraysh"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S107()
        frt = "107"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الماعون"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ma'un"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الماعون"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ma'un"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S108()
        frt = "108"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الكوثر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Kawthar"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الكوثر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Kawthar"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S109()
        frt = "109"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الكافرون"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Kafirun"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الكافرون"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Kafirun"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S110()
        frt = "110"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "النصر"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Nasr"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "النصر"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Nasr"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S111()
        frt = "111"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "المسد"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Masad"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "المسد"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Masad"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S112()
        frt = "112"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الإخلاص"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Ikhlas"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الإخلاص"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Ikhlas"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S113()
        frt = "113"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الفلق"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "Al-Falaq"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الفلق"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "Al-Falaq"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub S114()
        frt = "114"
        If CB5.Checked = True Then
            If CB1.SelectedIndex = 0 Then
                frt += " - " + "الناس"
            ElseIf CB1.SelectedIndex = 1 Then
                frt += " - " + "An-Nas"
            End If
        End If
        If CB6.Checked = True Then
            If CB1.SelectedIndex = 1 Then
                frt += " - " + "الناس"
            ElseIf CB1.SelectedIndex = 0 Then
                frt += " - " + "An-Nas"
            End If
        End If
        frt += fmt
    End Sub

    Private Sub Bu1()
        s = List.Items.Item(b).ToLower.replace("َ", "").replace("ِ", "").replace("ُ", "").replace("ً", "").replace("ٍ", "").replace("ٌ", "").replace("ْ", "").replace("ّ", "").replace("'", "").replace("-", "").Replace(fmt, "")
        If s.Contains("15") Then
            S015()
        ElseIf s.Contains("16") Then
            S016()
        ElseIf s.Contains("17") Then
            S017()
        ElseIf s.Contains("18") Then
            S018()
        ElseIf s.Contains("19") Then
            S019()
        ElseIf s.Contains("20") Then
            S020()
        ElseIf s.Contains("21") Then
            S021()
        ElseIf s.Contains("22") Then
            S022()
        ElseIf s.Contains("23") Then
            S023()
        ElseIf s.Contains("24") Then
            S024()
        ElseIf s.Contains("25") Then
            S025()
        ElseIf s.Contains("26") Then
            S026()
        ElseIf s.Contains("27") Then
            S027()
        ElseIf s.Contains("28") Then
            S028()
        ElseIf s.Contains("29") Then
            S029()
        ElseIf s.Contains("30") Then
            S030()
        ElseIf s.Contains("31") Then
            S031()
        ElseIf s.Contains("32") Then
            S032()
        ElseIf s.Contains("33") Then
            S033()
        ElseIf s.Contains("34") Then
            S034()
        ElseIf s.Contains("35") Then
            S035()
        ElseIf s.Contains("36") Then
            S036()
        ElseIf s.Contains("37") Then
            S037()
        ElseIf s.Contains("38") Then
            S038()
        ElseIf s.Contains("39") Then
            S039()
        ElseIf s.Contains("40") Then
            S040()
        ElseIf s.Contains("41") Then
            S041()
        ElseIf s.Contains("42") Then
            S042()
        ElseIf s.Contains("43") Then
            S043()
        ElseIf s.Contains("44") Then
            S044()
        ElseIf s.Contains("45") Then
            S045()
        ElseIf s.Contains("46") Then
            S046()
        ElseIf s.Contains("47") Then
            S047()
        ElseIf s.Contains("48") Then
            S048()
        ElseIf s.Contains("49") Then
            S049()
        ElseIf s.Contains("50") Then
            S050()
        ElseIf s.Contains("51") Then
            S051()
        ElseIf s.Contains("52") Then
            S052()
        ElseIf s.Contains("53") Then
            S053()
        ElseIf s.Contains("54") Then
            S054()
        ElseIf s.Contains("55") Then
            S055()
        ElseIf s.Contains("56") Then
            S056()
        ElseIf s.Contains("57") Then
            S057()
        ElseIf s.Contains("58") Then
            S058()
        ElseIf s.Contains("59") Then
            S059()
        ElseIf s.Contains("60") Then
            S060()
        ElseIf s.Contains("61") Then
            S061()
        ElseIf s.Contains("62") Then
            S062()
        ElseIf s.Contains("63") Then
            S063()
        ElseIf s.Contains("64") Then
            S064()
        ElseIf s.Contains("65") Then
            S065()
        ElseIf s.Contains("66") Then
            S066()
        ElseIf s.Contains("67") Then
            S067()
        ElseIf s.Contains("68") Then
            S068()
        ElseIf s.Contains("69") Then
            S069()
        ElseIf s.Contains("70") Then
            S070()
        ElseIf s.Contains("71") Then
            S071()
        ElseIf s.Contains("72") Then
            S072()
        ElseIf s.Contains("73") Then
            S073()
        ElseIf s.Contains("74") Then
            S074()
        ElseIf s.Contains("75") Then
            S075()
        ElseIf s.Contains("76") Then
            S076()
        ElseIf s.Contains("77") Then
            S077()
        ElseIf s.Contains("78") Then
            S078()
        ElseIf s.Contains("79") Then
            S079()
        ElseIf s.Contains("80") Then
            S080()
        ElseIf s.Contains("81") Then
            S081()
        ElseIf s.Contains("82") Then
            S082()
        ElseIf s.Contains("83") Then
            S083()
        ElseIf s.Contains("84") Then
            S084()
        ElseIf s.Contains("85") Then
            S085()
        ElseIf s.Contains("86") Then
            S086()
        ElseIf s.Contains("87") Then
            S087()
        ElseIf s.Contains("88") Then
            S088()
        ElseIf s.Contains("89") Then
            S089()
        ElseIf s.Contains("90") Then
            S090()
        ElseIf s.Contains("91") Then
            S091()
        ElseIf s.Contains("92") Then
            S092()
        ElseIf s.Contains("93") Then
            S093()
        ElseIf s.Contains("94") Then
            S094()
        ElseIf s.Contains("95") Then
            S095()
        ElseIf s.Contains("96") Then
            S096()
        ElseIf s.Contains("97") Then
            S097()
        ElseIf s.Contains("98") Then
            S098()
        ElseIf s.Contains("99") Then
            S099()
        ElseIf s.Contains("100") Then
            S100()
        ElseIf s.Contains("101") Then
            S101()
        ElseIf s.Contains("102") Then
            S102()
        ElseIf s.Contains("103") Then
            S103()
        ElseIf s.Contains("104") Then
            S104()
        ElseIf s.Contains("105") Then
            S105()
        ElseIf s.Contains("106") Then
            S106()
        ElseIf s.Contains("107") Then
            S107()
        ElseIf s.Contains("108") Then
            S108()
        ElseIf s.Contains("109") Then
            S109()
        ElseIf s.Contains("110") Then
            S110()
        ElseIf s.Contains("111") Then
            S111()
        ElseIf s.Contains("112") Then
            S112()
        ElseIf s.Contains("113") Then
            S113()
        ElseIf s.Contains("114") Then
            S114()
        ElseIf s.Contains("10") Then
            S010()
        ElseIf s.Contains("11") Then
            S011()
        ElseIf s.Contains("12") Then
            S012()
        ElseIf s.Contains("13") Then
            S013()
        ElseIf s.Contains("14") Then
            S014()
        ElseIf s.Contains("01") Then
            S001()
        ElseIf s.Contains("02") Then
            S002()
        ElseIf s.Contains("03") Then
            S003()
        ElseIf s.Contains("04") Then
            S004()
        ElseIf s.Contains("05") Then
            S005()
        ElseIf s.Contains("06") Then
            S006()
        ElseIf s.Contains("07") Then
            S007()
        ElseIf s.Contains("08") Then
            S008()
        ElseIf s.Contains("09") Then
            S009()
        ElseIf s.Contains("فاتح") Then
            S001()
        ElseIf s.Contains("فتح") Then
            S048()
        ElseIf s.Contains("بقر") Then
            S002()
        ElseIf s.Contains("نسان") Then
            S076()
        ElseIf s.Contains("نسا") Then
            S004()
        ElseIf s.Contains("عمران") Then
            S003()
        ElseIf s.Contains("مائد") Then
            S005()
        ElseIf s.Contains("نعام") Then
            S006()
        ElseIf s.Contains("عراف") Then
            S007()
        ElseIf s.Contains("نفال") Then
            S008()
        ElseIf s.Contains("توب") Then
            S009()
        ElseIf s.Contains("يونس") Then
            S010()
        ElseIf s.Contains("هود") Then
            S011()
        ElseIf s.Contains("يوسف") Then
            S012()
        ElseIf s.Contains("رعد") Then
            S013()
        ElseIf s.Contains("براهيم") Then
            S014()
        ElseIf s.Contains("حجرات") Then
            S049()
        ElseIf s.Contains("حجر") Then
            S015()
        ElseIf s.Contains("نحل") Then
            S016()
        ElseIf s.Contains("سراء") Then
            S017()
        ElseIf s.Contains("كهف") Then
            S018()
        ElseIf s.Contains("مريم") Then
            S019()
        ElseIf s.Contains("نبياء") Then
            S021()
        ElseIf s.Contains("منون") Then
            S023()
        ElseIf s.Contains("نور") Then
            S024()
        ElseIf s.Contains("فرقان") Then
            S025()
        ElseIf s.Contains("شعرا") Then
            S026()
        ElseIf s.Contains("نمل") Then
            S027()
        ElseIf s.Contains("قصص") Then
            S028()
        ElseIf s.Contains("عنكب") Then
            S029()
        ElseIf s.Contains("روم") Then
            S030()
        ElseIf s.Contains("لقمان") Then
            S031()
        ElseIf s.Contains("سجد") Then
            S032()
        ElseIf s.Contains("حزاب") Then
            S033()
        ElseIf s.Contains("فاطر") Then
            S035()
        ElseIf s.Contains("صافات") Then
            S037()
        ElseIf s.Contains("فصلت") Then
            S041()
        ElseIf s.Contains("زمر") Then
            S039()
        ElseIf s.Contains("غافر") Then
            S040()
        ElseIf s.Contains("شور") Then
            S042()
        ElseIf s.Contains("زخرف") Then
            S043()
        ElseIf s.Contains("دخان") Then
            S044()
        ElseIf s.Contains("جاثي") Then
            S045()
        ElseIf s.Contains("حقاف") Then
            S046()
        ElseIf s.Contains("محمد") Then
            S047()
        ElseIf s.Contains("ذاري") Then
            S051()
        ElseIf s.Contains("طور") Then
            S052()
        ElseIf s.Contains("نجم") Then
            S053()
        ElseIf s.Contains("قمر") Then
            S054()
        ElseIf s.Contains("رحم") Then
            S055()
        ElseIf s.Contains("واقع") Then
            S056()
        ElseIf s.Contains("حديد") Then
            S057()
        ElseIf s.Contains("مجادل") Then
            S058()
        ElseIf s.Contains("حشر") Then
            S059()
        ElseIf s.Contains("ممتحن") Then
            S060()
        ElseIf s.Contains("جمع") Then
            S062()
        ElseIf s.Contains("منافقون") Then
            S063()
        ElseIf s.Contains("تغابن") Then
            S064()
        ElseIf s.Contains("طلاق") Then
            S065()
        ElseIf s.Contains("تحريم") Then
            S066()
        ElseIf s.Contains("ملك") Then
            S067()
        ElseIf s.Contains("قلم") Then
            S068()
        ElseIf s.Contains("حاق") Then
            S069()
        ElseIf s.Contains("حآق") Then
            S069()
        ElseIf s.Contains("معارج") Then
            S070()
        ElseIf s.Contains("نوح") Then
            S071()
        ElseIf s.Contains("مزمل") Then
            S073()
        ElseIf s.Contains("مدثر") Then
            S074()
        ElseIf s.Contains("قيام") Then
            S075()
        ElseIf s.Contains("مرسل") Then
            S077()
        ElseIf s.Contains("نازع") Then
            S079()
        ElseIf s.Contains("عبس") Then
            S080()
        ElseIf s.Contains("تكوير") Then
            S081()
        ElseIf s.Contains("نفطار") Then
            S082()
        ElseIf s.Contains("مطففين") Then
            S083()
        ElseIf s.Contains("نشقاق") Then
            S084()
        ElseIf s.Contains("بروج") Then
            S085()
        ElseIf s.Contains("طارق") Then
            S086()
        ElseIf s.Contains("على") Then
            S087()
        ElseIf s.Contains("غاشي") Then
            S088()
        ElseIf s.Contains("فجر") Then
            S089()
        ElseIf s.Contains("بلد") Then
            S090()
        ElseIf s.Contains("شمس") Then
            S091()
        ElseIf s.Contains("ليل") Then
            S092()
        ElseIf s.Contains("ضحى") Then
            S093()
        ElseIf s.Contains("شرح") Then
            S094()
        ElseIf s.Contains("تين") Then
            S095()
        ElseIf s.Contains("علق") Then
            S096()
        ElseIf s.Contains("قدر") Then
            S097()
        ElseIf s.Contains("بين") Then
            S098()
        ElseIf s.Contains("زلزل") Then
            S099()
        ElseIf s.Contains("عادي") Then
            S100()
        ElseIf s.Contains("قارع") Then
            S101()
        ElseIf s.Contains("تكاثر") Then
            S102()
        ElseIf s.Contains("عصر") Then
            S103()
        ElseIf s.Contains("همز") Then
            S104()
        ElseIf s.Contains("فيل") Then
            S105()
        ElseIf s.Contains("قريش") Then
            S106()
        ElseIf s.Contains("ماعون") Then
            S107()
        ElseIf s.Contains("كوثر") Then
            S108()
        ElseIf s.Contains("كافر") Then
            S109()
        ElseIf s.Contains("نصر") Then
            S110()
        ElseIf s.Contains("مسد") Then
            S111()
        ElseIf s.Contains("خلاص") Then
            S112()
        ElseIf s.Contains("فلق") Then
            S113()
        ElseIf s.Contains("ناس") Then
            S114()
        ElseIf s.Contains("حج") Then
            S022()
        ElseIf s.Contains("طه") Then
            S020()
        ElseIf s.Contains("سب") Then
            S034()
        ElseIf s.Contains("يس") Then
            S036()
        ElseIf s.Contains("صف") Then
            S061()
        ElseIf s.Contains("جن") Then
            S072()
        ElseIf s.Contains("نب") Then
            S078()
        ElseIf s.Contains("ق") Then
            S050()
        ElseIf s.Contains("صباح") Then
            frt = List.Items.Item(b)
        ElseIf s.Contains("ص") Then
            S038()
        ElseIf s.Contains("replacement process") Then
            frt = List.Items.Item(b)
        ElseIf s.Contains("fatiha") Or s.Contains("fatha") Or s.Contains("fateha") Then
            S001()
        ElseIf s.Contains("baqarah") Then
            S002()
        ElseIf s.Contains("mran") Then
            S003()
        ElseIf s.Contains("nisa") Or s.Contains("nesa") Then
            S004()
        ElseIf s.Contains("maidah") Then
            S005()
        ElseIf s.Contains("anam") Then
            S006()
        ElseIf s.Contains("araf") Then
            S007()
        ElseIf s.Contains("anfal") Then
            S008()
        ElseIf s.Contains("tawbah") Or s.Contains("taubah") Then
            S009()
        ElseIf s.Contains("yunus") Or s.Contains("younus") Then
            S010()
        ElseIf s.Contains("yusuf") Or s.Contains("yousuf") Then
            S012()
        ElseIf s.Contains("ibrahim") Then
            S014()
        ElseIf s.Contains("hijr") Then
            S015()
        ElseIf s.Contains("nahl") Then
            S016()
        ElseIf s.Contains("kahf") Then
            S018()
        ElseIf s.Contains("maryam") Then
            S019()
        ElseIf s.Contains("taha") Then
            S020()
        ElseIf s.Contains("anbya") Then
            S021()
        ElseIf s.Contains("hajj") Then
            S022()
        ElseIf s.Contains("muminun") Or s.Contains("muminoon") Then
            S023()
        ElseIf s.Contains("furqan") Then
            S025()
        ElseIf s.Contains("shuara") Then
            S026()
        ElseIf s.Contains("naml") Then
            S027()
        ElseIf s.Contains("qasas") Then
            S028()
        ElseIf s.Contains("ankabut") Or s.Contains("ankaboot") Then
            S029()
        ElseIf s.Contains("luqman") Then
            S031()
        ElseIf s.Contains("sajdah") Then
            S032()
        ElseIf s.Contains("ahzab") Then
            S033()
        ElseIf s.Contains("saba") Then
            S034()
        ElseIf s.Contains("fatir") Or s.Contains("fater") Then
            S035()
        ElseIf s.Contains("yasin") Or s.Contains("yasen") Or s.Contains("yaseen") Then
            S036()
        ElseIf s.Contains("saffat") Or s.Contains("saaffat") Then
            S037()
        ElseIf s.Contains("zumar") Or s.Contains("zomar") Then
            S039()
        ElseIf s.Contains("ghafir") Or s.Contains("ghafer") Then
            S040()
        ElseIf s.Contains("fussilat") Then
            S041()
        ElseIf s.Contains("shura") Or s.Contains("shora") Then
            S042()
        ElseIf s.Contains("zukhruf") Or s.Contains("zukhrof") Then
            S043()
        ElseIf s.Contains("dukhan") Or s.Contains("dokhan") Then
            S044()
        ElseIf s.Contains("jathiya") Or s.Contains("gatheya") Or s.Contains("jatheya") Or s.Contains("gathiya") Then
            S045()
        ElseIf s.Contains("ahqaf") Then
            S046()
        ElseIf s.Contains("muhammad") Or s.Contains("muhamad") Or s.Contains("muhammed") Or s.Contains("muhamed") Or s.Contains("mohamed") Or s.Contains("mohammed") Or s.Contains("mohamad") Or s.Contains("mohammad") Then
            S047()
        ElseIf s.Contains("fath") Then
            S048()
        ElseIf s.Contains("hujurat") Or s.Contains("hojrat") Then
            S049()
        ElseIf s.Contains("dhariyat") Or s.Contains("dharyat") Or s.Contains("zariyat") Or s.Contains("zaryat") Then
            S051()
        ElseIf s.Contains("najm") Then
            S053()
        ElseIf s.Contains("qamar") Then
            S054()
        ElseIf s.Contains("rahman") Then
            S055()
        ElseIf s.Contains("hashr") Then
            S059()
        ElseIf s.Contains("jumua") Or s.Contains("jomoa") Then
            S062()
        ElseIf s.Contains("nafiq") Or s.Contains("nafeq") Then
            S063()
        ElseIf s.Contains("taghab") Then
            S064()
        ElseIf s.Contains("talaq") Then
            S065()
        ElseIf s.Contains("tahr") Then
            S066()
        ElseIf s.Contains("mulk") Or s.Contains("molk") Then
            S067()
        ElseIf s.Contains("qalam") Then
            S068()
        ElseIf s.Contains("haqqa") Or s.Contains("haaqqa") Then
            S069()
        ElseIf s.Contains("maarij") Or s.Contains("maarej") Then
            S070()
        ElseIf s.Contains("zzamm") Then
            S073()
        ElseIf s.Contains("dath") Then
            S074()
        ElseIf s.Contains("qiyama") Or s.Contains("qeyama") Then
            S075()
        ElseIf s.Contains("nsan") Then
            S076()
        ElseIf s.Contains("naba") Then
            S078()
        ElseIf s.Contains("naziat") Then
            S079()
        ElseIf s.Contains("abasa") Then
            S080()
        ElseIf s.Contains("takwir") Then
            S081()
        ElseIf s.Contains("infitar") Then
            S082()
        ElseIf s.Contains("mutaffifin") Then
            S083()
        ElseIf s.Contains("inshiqaq") Then
            S084()
        ElseIf s.Contains("buruj") Or s.Contains("burooj") Then
            S085()
        ElseIf s.Contains("tariq") Then
            S086()
        ElseIf s.Contains("ghashiya") Then
            S088()
        ElseIf s.Contains("fajr") Then
            S089()
        ElseIf s.Contains("balad") Then
            S090()
        ElseIf s.Contains("shams") Then
            S091()
        ElseIf s.Contains("layl") Then
            S092()
        ElseIf s.Contains("duha") Or s.Contains("dhuha") Then
            S093()
        ElseIf s.Contains("sharh") Then
            S094()
        ElseIf s.Contains("alaq") Then
            S096()
        ElseIf s.Contains("qadr") Then
            S097()
        ElseIf s.Contains("bayyinah") Then
            S098()
        ElseIf s.Contains("zalzalah") Then
            S099()
        ElseIf s.Contains("adiyat") Then
            S100()
        ElseIf s.Contains("qari") Then
            S101()
        ElseIf s.Contains("takathur") Then
            S102()
        ElseIf s.Contains("humazah") Then
            S104()
        ElseIf s.Contains("quraysh") Or s.Contains("quraish") Then
            S106()
        ElseIf s.Contains("maun") Then
            S107()
        ElseIf s.Contains("kawthar") Or s.Contains("kauther") Or s.Contains("kawther") Or s.Contains("kauthar") Then
            S108()
        ElseIf s.Contains("kafir") Then
            S109()
        ElseIf s.Contains("nasr") Then
            S110()
        ElseIf s.Contains("masad") Then
            S111()
        ElseIf s.Contains("ikhlas") Then
            S112()
        ElseIf s.Contains("falaq") Then
            S113()
        ElseIf s.Contains("mtah") Then
            S060()
        ElseIf s.Contains("sra") Then
            S017()
        ElseIf s.Contains("hud") Or s.Contains("hood") Then
            S011()
        ElseIf s.Contains("rad") Then
            S013()
        ElseIf s.Contains("nur") Or s.Contains("noor") Then
            S024()
        ElseIf s.Contains("rum") Or s.Contains("room") Then
            S030()
        ElseIf s.Contains("sad") Then
            S038()
        ElseIf s.Contains("qaf") Then
            S050()
        ElseIf s.Contains("tur") Or s.Contains("toor") Or s.Contains("tour") Then
            S052()
        ElseIf s.Contains("waq") Then
            S056()
        ElseIf s.Contains("had") Then
            S057()
        ElseIf s.Contains("jad") Then
            S058()
        ElseIf s.Contains("saf") Then
            S061()
        ElseIf s.Contains("nuh") Or s.Contains("nooh") Or s.Contains("noah") Then
            S071()
        ElseIf s.Contains("jin") Or s.Contains("jen") Then
            S072()
        ElseIf s.Contains("ala") Then
            S087()
        ElseIf s.Contains("tin") Then
            S095()
        ElseIf s.Contains("asr") Then
            S103()
        ElseIf s.Contains("fil") Then
            S105()
        ElseIf s.Contains("nas") Then
            S114()
        ElseIf s.Contains("rs") Then
            S077()

        ElseIf s.Contains("1") Then
            S001()
        ElseIf s.Contains("2") Then
            S002()
        ElseIf s.Contains("3") Then
            S003()
        ElseIf s.Contains("4") Then
            S004()
        ElseIf s.Contains("5") Then
            S005()
        ElseIf s.Contains("6") Then
            S006()
        ElseIf s.Contains("7") Then
            S007()
        ElseIf s.Contains("8") Then
            S008()
        ElseIf s.Contains("9") Then
            S009()
        Else
            frt = List.Items.Item(b)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        List2.Items.Clear()
        For b = 0 To a
            Dim fi As New IO.FileInfo(List.Items.Item(b))
            fmt = fi.Extension
            If fmt = "" Then
                fmt = "*"
            End If
            Bu1()
            List2.Items.Add(frt)
        Next
        Btn3.Enabled = True
        If CB5.Checked = True Then
            Btn6.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Btn3.Enabled = False
        If q = 0 Then
            s = a
            s += "
"
            For b = 0 To a
                Dim fi As New IO.FileInfo(List.Items.Item(b))
                fmt = fi.Extension
                If fmt = "" Then
                    fmt = "*"
                End If
                If List.Items.Item(b) = List2.Items.Item(b) Then
                Else
                    If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(b)) Then
                        If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(b).Replace(fmt, "") + "_2" + fmt) Then
                            List2.Items.Item(b) = List.Items.Item(b)
                        Else
                            My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(b), List2.Items.Item(b).Replace(fmt, "") + "_2" + fmt)
                            List2.Items.Item(b) = List2.Items.Item(b).Replace(fmt, "") + "_2" + fmt
                        End If
                    Else
                        My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(b), List2.Items.Item(b))
                    End If
                End If
                s += List.Items.Item(b) + "
" + List2.Items.Item(b) + "
"
            Next
            If a > 0 Then
                My.Computer.FileSystem.WriteAllText(Link.Text + "\Name replacement process.txt", s, False)
            End If
            Btn1.Enabled = False : Btn6.Enabled = False
        Else
            For b = 0 To a
                If My.Computer.FileSystem.FileExists(Link.Text + "\" + List.Items.Item(b)) Then
                    If My.Computer.FileSystem.FileExists(Link.Text + "\" + List2.Items.Item(b)) Then
                    Else
                        My.Computer.FileSystem.RenameFile(Link.Text + "\" + List.Items.Item(b), List2.Items.Item(b))
                    End If
                End If
            Next
            My.Computer.FileSystem.DeleteFile(Link.Text + "\Name replacement process.txt")
        End If
    End Sub

    Private Sub CB1_SIC(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged
        If CB1.SelectedIndex = 0 Then
            CB2.Text = "English"
        ElseIf CB1.SelectedIndex = 1 Then
            CB2.Text = "العربية"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        On Error Resume Next
        If Folder.ShowDialog = DialogResult.OK Then
            a = -1
            Link.Text = Folder.SelectedPath
            List.Items.Clear() : List2.Items.Clear()
            Btn1.Enabled = False : Btn3.Enabled = False : Btn6.Enabled = False
            If My.Computer.FileSystem.FileExists(Link.Text + "\Name replacement process.txt") Then
                RTB.Text = My.Computer.FileSystem.ReadAllText(Link.Text + "\Name replacement process.txt")
                a = RTB.Lines(0)
                If a > 0 Then
                    For b = 1 To a + 1
                        List.Items.Add(RTB.Lines(2 * b))
                        List2.Items.Add(RTB.Lines(2 * b - 1))
                    Next
                    Btn3.Enabled = True : q = 1
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
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Btn6.Enabled = False
        For b = 0 To a
            List2.Items.Item(b) = List2.Items.Item(b).Replace(" - ", " ")
        Next
    End Sub

    Private Sub lg2(sender As Object, e As EventArgs) Handles lg.Click
        If lg.Text = "English" Then
            lg.Text = "عربي"
            My.Computer.FileSystem.WriteAllText(hm + "lang", "1", False)
            Btn2.Text = "Open folder"
            Btn1.Text = "Scan"
            Btn6.Text = "without (-)" : Btn6.RightToLeft = RightToLeft.No
            Btn3.Text = "Start"
            Btn4.Text = "About designer"
            L9.Text = "Surah
number"
            CB5.Text = "Name in" : CB6.Text = "Name in" : CB5.RightToLeft = RightToLeft.No : CB6.RightToLeft = RightToLeft.No
            CB7.Text = "All files" : CB3.Text = "Audio" : CB4.Text = "Video"
            Btn5.Text = "I regret what I did"
        Else
            lg.Text = "English"
            Kill(hm + "lang")
            Btn2.Text = "فتح المجلد"
            Btn1.Text = "فحص"
            Btn6.Text = "بدون (-)" : Btn6.RightToLeft = RightToLeft.Yes
            Btn3.Text = "بدأ"
            Btn4.Text = "عن المصمم"
            L9.Text = "رقم
السورة"
            CB5.Text = "الإسم بـ" : CB6.Text = "الإسم بـ" : CB5.RightToLeft = RightToLeft.Yes : CB6.RightToLeft = RightToLeft.Yes
            CB7.Text = "كل الملفات" : CB3.Text = "صوت" : CB4.Text = "فيديو"
            Btn5.Text = "أنا نادم على ما فعلت"
        End If
    End Sub
End Class
