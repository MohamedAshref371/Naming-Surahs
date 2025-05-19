<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TurnOn2 = New System.Windows.Forms.CheckBox()
        Me.Lang1 = New System.Windows.Forms.ComboBox()
        Me.TurnOn1 = New System.Windows.Forms.CheckBox()
        Me.L9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openFolderBtn = New System.Windows.Forms.Button()
        Me.checkFilesNameBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Folder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Link = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.executeBtn = New System.Windows.Forms.Button()
        Me.L8 = New System.Windows.Forms.Label()
        Me.regretBtn = New System.Windows.Forms.Button()
        Me.aboutBtn = New System.Windows.Forms.Button()
        Me.audioFilesCheckBox = New System.Windows.Forms.CheckBox()
        Me.videoFilesCheckBox = New System.Windows.Forms.CheckBox()
        Me.allFilesCheckBox = New System.Windows.Forms.CheckBox()
        Me.languageBtn = New System.Windows.Forms.Button()
        Me.concat1 = New System.Windows.Forms.TextBox()
        Me.concat2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lang2 = New System.Windows.Forms.ComboBox()
        Me.concat3 = New System.Windows.Forms.TextBox()
        Me.Lang3 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TurnOn3 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.concat4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.color1desc = New System.Windows.Forms.Label()
        Me.color2desc = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.color3desc = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.color4desc = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TurnOn2
        '
        Me.TurnOn2.AutoSize = True
        Me.TurnOn2.Enabled = False
        Me.TurnOn2.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TurnOn2.Location = New System.Drawing.Point(50, 165)
        Me.TurnOn2.Name = "TurnOn2"
        Me.TurnOn2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TurnOn2.Size = New System.Drawing.Size(94, 27)
        Me.TurnOn2.TabIndex = 10
        Me.TurnOn2.Text = "الإسم بـ"
        Me.TurnOn2.UseVisualStyleBackColor = True
        '
        'Lang1
        '
        Me.Lang1.BackColor = System.Drawing.Color.White
        Me.Lang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Lang1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lang1.FormattingEnabled = True
        Me.Lang1.Location = New System.Drawing.Point(162, 112)
        Me.Lang1.Name = "Lang1"
        Me.Lang1.Size = New System.Drawing.Size(120, 27)
        Me.Lang1.TabIndex = 9
        '
        'TurnOn1
        '
        Me.TurnOn1.AutoSize = True
        Me.TurnOn1.Checked = True
        Me.TurnOn1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TurnOn1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TurnOn1.Location = New System.Drawing.Point(174, 80)
        Me.TurnOn1.Name = "TurnOn1"
        Me.TurnOn1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TurnOn1.Size = New System.Drawing.Size(94, 27)
        Me.TurnOn1.TabIndex = 8
        Me.TurnOn1.Text = "الإسم بـ"
        Me.TurnOn1.UseVisualStyleBackColor = True
        '
        'L9
        '
        Me.L9.AutoSize = True
        Me.L9.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.L9.Location = New System.Drawing.Point(5, 64)
        Me.L9.Name = "L9"
        Me.L9.Size = New System.Drawing.Size(67, 48)
        Me.L9.TabIndex = 29
        Me.L9.Text = "رقم" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "السورة"
        Me.L9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(236, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(5, 5)
        Me.Label7.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(236, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(5, 5)
        Me.Label6.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(241, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(5, 5)
        Me.Label5.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(241, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(5, 5)
        Me.Label4.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(246, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(5, 5)
        Me.Label3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(246, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(5, 5)
        Me.Label2.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(62, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 5)
        Me.Label1.TabIndex = 21
        '
        'openFolderBtn
        '
        Me.openFolderBtn.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.openFolderBtn.Location = New System.Drawing.Point(12, 476)
        Me.openFolderBtn.Name = "openFolderBtn"
        Me.openFolderBtn.Size = New System.Drawing.Size(116, 81)
        Me.openFolderBtn.TabIndex = 0
        Me.openFolderBtn.Text = "فتح المجلد"
        Me.openFolderBtn.UseVisualStyleBackColor = True
        '
        'checkFilesNameBtn
        '
        Me.checkFilesNameBtn.Enabled = False
        Me.checkFilesNameBtn.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.checkFilesNameBtn.Location = New System.Drawing.Point(235, 392)
        Me.checkFilesNameBtn.Name = "checkFilesNameBtn"
        Me.checkFilesNameBtn.Size = New System.Drawing.Size(126, 79)
        Me.checkFilesNameBtn.TabIndex = 4
        Me.checkFilesNameBtn.Text = "فحص"
        Me.checkFilesNameBtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(381, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(205, 563)
        Me.ListBox1.TabIndex = 36
        '
        'Link
        '
        Me.Link.AutoSize = True
        Me.Link.Location = New System.Drawing.Point(0, 0)
        Me.Link.Name = "Link"
        Me.Link.Size = New System.Drawing.Size(25, 13)
        Me.Link.TabIndex = 38
        Me.Link.Text = "Link"
        Me.Link.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(592, 5)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(205, 563)
        Me.ListBox2.TabIndex = 39
        '
        'executeBtn
        '
        Me.executeBtn.Enabled = False
        Me.executeBtn.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.executeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.executeBtn.Location = New System.Drawing.Point(235, 476)
        Me.executeBtn.Name = "executeBtn"
        Me.executeBtn.Size = New System.Drawing.Size(126, 81)
        Me.executeBtn.TabIndex = 6
        Me.executeBtn.Text = "تنفيذ"
        Me.executeBtn.UseVisualStyleBackColor = True
        '
        'L8
        '
        Me.L8.AutoSize = True
        Me.L8.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.L8.Location = New System.Drawing.Point(15, 115)
        Me.L8.Name = "L8"
        Me.L8.Size = New System.Drawing.Size(43, 24)
        Me.L8.TabIndex = 28
        Me.L8.Text = "001"
        '
        'regretBtn
        '
        Me.regretBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.regretBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.regretBtn.Location = New System.Drawing.Point(12, 392)
        Me.regretBtn.Name = "regretBtn"
        Me.regretBtn.Size = New System.Drawing.Size(116, 79)
        Me.regretBtn.TabIndex = 11
        Me.regretBtn.Text = "أنا نادم على ما فعلت"
        Me.regretBtn.UseVisualStyleBackColor = True
        '
        'aboutBtn
        '
        Me.aboutBtn.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.aboutBtn.Location = New System.Drawing.Point(235, 356)
        Me.aboutBtn.Name = "aboutBtn"
        Me.aboutBtn.Size = New System.Drawing.Size(126, 31)
        Me.aboutBtn.TabIndex = 44
        Me.aboutBtn.Text = "هذا البرنامج"
        Me.aboutBtn.UseVisualStyleBackColor = True
        '
        'audioFilesCheckBox
        '
        Me.audioFilesCheckBox.AutoSize = True
        Me.audioFilesCheckBox.Checked = True
        Me.audioFilesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.audioFilesCheckBox.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.audioFilesCheckBox.Location = New System.Drawing.Point(128, 510)
        Me.audioFilesCheckBox.Name = "audioFilesCheckBox"
        Me.audioFilesCheckBox.Size = New System.Drawing.Size(49, 17)
        Me.audioFilesCheckBox.TabIndex = 2
        Me.audioFilesCheckBox.Text = "صوت"
        Me.audioFilesCheckBox.UseVisualStyleBackColor = True
        '
        'videoFilesCheckBox
        '
        Me.videoFilesCheckBox.AutoSize = True
        Me.videoFilesCheckBox.Checked = True
        Me.videoFilesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.videoFilesCheckBox.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.videoFilesCheckBox.Location = New System.Drawing.Point(128, 533)
        Me.videoFilesCheckBox.Name = "videoFilesCheckBox"
        Me.videoFilesCheckBox.Size = New System.Drawing.Size(49, 17)
        Me.videoFilesCheckBox.TabIndex = 3
        Me.videoFilesCheckBox.Text = "فيديو"
        Me.videoFilesCheckBox.UseVisualStyleBackColor = True
        '
        'allFilesCheckBox
        '
        Me.allFilesCheckBox.AutoSize = True
        Me.allFilesCheckBox.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.allFilesCheckBox.Location = New System.Drawing.Point(128, 487)
        Me.allFilesCheckBox.Name = "allFilesCheckBox"
        Me.allFilesCheckBox.Size = New System.Drawing.Size(77, 17)
        Me.allFilesCheckBox.TabIndex = 1
        Me.allFilesCheckBox.Text = "كل الملفات"
        Me.allFilesCheckBox.UseVisualStyleBackColor = True
        '
        'languageBtn
        '
        Me.languageBtn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.languageBtn.ForeColor = System.Drawing.Color.Purple
        Me.languageBtn.Location = New System.Drawing.Point(12, 356)
        Me.languageBtn.Name = "languageBtn"
        Me.languageBtn.Size = New System.Drawing.Size(116, 31)
        Me.languageBtn.TabIndex = 7
        Me.languageBtn.Text = "English"
        Me.languageBtn.UseVisualStyleBackColor = True
        '
        'concat1
        '
        Me.concat1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.concat1.Location = New System.Drawing.Point(103, 112)
        Me.concat1.MaxLength = 9
        Me.concat1.Name = "concat1"
        Me.concat1.Size = New System.Drawing.Size(48, 27)
        Me.concat1.TabIndex = 46
        Me.concat1.Text = " - "
        '
        'concat2
        '
        Me.concat2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.concat2.Location = New System.Drawing.Point(317, 112)
        Me.concat2.MaxLength = 9
        Me.concat2.Name = "concat2"
        Me.concat2.Size = New System.Drawing.Size(48, 27)
        Me.concat2.TabIndex = 47
        Me.concat2.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(288, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 23)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(74, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 23)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "+"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(10, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 23)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "+"
        '
        'Lang2
        '
        Me.Lang2.BackColor = System.Drawing.Color.White
        Me.Lang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Lang2.Enabled = False
        Me.Lang2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lang2.FormattingEnabled = True
        Me.Lang2.Location = New System.Drawing.Point(34, 197)
        Me.Lang2.Name = "Lang2"
        Me.Lang2.Size = New System.Drawing.Size(120, 27)
        Me.Lang2.TabIndex = 51
        '
        'concat3
        '
        Me.concat3.Enabled = False
        Me.concat3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.concat3.Location = New System.Drawing.Point(180, 197)
        Me.concat3.MaxLength = 9
        Me.concat3.Name = "concat3"
        Me.concat3.Size = New System.Drawing.Size(48, 27)
        Me.concat3.TabIndex = 52
        Me.concat3.Text = " "
        '
        'Lang3
        '
        Me.Lang3.BackColor = System.Drawing.Color.White
        Me.Lang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Lang3.Enabled = False
        Me.Lang3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lang3.FormattingEnabled = True
        Me.Lang3.Location = New System.Drawing.Point(257, 197)
        Me.Lang3.Name = "Lang3"
        Me.Lang3.Size = New System.Drawing.Size(120, 27)
        Me.Lang3.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(234, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 23)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "+"
        '
        'TurnOn3
        '
        Me.TurnOn3.AutoSize = True
        Me.TurnOn3.Enabled = False
        Me.TurnOn3.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TurnOn3.Location = New System.Drawing.Point(271, 165)
        Me.TurnOn3.Name = "TurnOn3"
        Me.TurnOn3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TurnOn3.Size = New System.Drawing.Size(94, 27)
        Me.TurnOn3.TabIndex = 53
        Me.TurnOn3.Text = "الإسم بـ"
        Me.TurnOn3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(156, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 23)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "+"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label13.Location = New System.Drawing.Point(288, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 23)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "+"
        '
        'concat4
        '
        Me.concat4.Enabled = False
        Me.concat4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.concat4.Location = New System.Drawing.Point(318, 238)
        Me.concat4.MaxLength = 9
        Me.concat4.Name = "concat4"
        Me.concat4.Size = New System.Drawing.Size(48, 27)
        Me.concat4.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(8, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 33)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "*"
        '
        'color1desc
        '
        Me.color1desc.AutoSize = True
        Me.color1desc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.color1desc.Location = New System.Drawing.Point(36, 271)
        Me.color1desc.Name = "color1desc"
        Me.color1desc.Size = New System.Drawing.Size(202, 13)
        Me.color1desc.TabIndex = 60
        Me.color1desc.Text = "لم يتم التعرف على السورة من إسم الملف"
        '
        'color2desc
        '
        Me.color2desc.AutoSize = True
        Me.color2desc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.color2desc.Location = New System.Drawing.Point(36, 293)
        Me.color2desc.Name = "color2desc"
        Me.color2desc.Size = New System.Drawing.Size(263, 13)
        Me.color2desc.TabIndex = 62
        Me.color2desc.Text = "لم يتم التمكن من إيجاد إسم مناسب للملف داخل المجلد"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(8, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 33)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "*"
        '
        'color3desc
        '
        Me.color3desc.AutoSize = True
        Me.color3desc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.color3desc.Location = New System.Drawing.Point(36, 314)
        Me.color3desc.Name = "color3desc"
        Me.color3desc.Size = New System.Drawing.Size(183, 13)
        Me.color3desc.TabIndex = 64
        Me.color3desc.Text = "لم يتم إيجاد الملف أثناء عملية التسمية"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Orange
        Me.Label18.Location = New System.Drawing.Point(8, 309)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 33)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "*"
        '
        'color4desc
        '
        Me.color4desc.AutoSize = True
        Me.color4desc.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.color4desc.Location = New System.Drawing.Point(36, 336)
        Me.color4desc.Name = "color4desc"
        Me.color4desc.Size = New System.Drawing.Size(143, 13)
        Me.color4desc.TabIndex = 66
        Me.color4desc.Text = "حدث خطأ أثناء عملية التسمية"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(8, 331)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 33)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 569)
        Me.Controls.Add(Me.color4desc)
        Me.Controls.Add(Me.color3desc)
        Me.Controls.Add(Me.color2desc)
        Me.Controls.Add(Me.color1desc)
        Me.Controls.Add(Me.concat4)
        Me.Controls.Add(Me.Lang3)
        Me.Controls.Add(Me.TurnOn3)
        Me.Controls.Add(Me.concat3)
        Me.Controls.Add(Me.Lang2)
        Me.Controls.Add(Me.concat2)
        Me.Controls.Add(Me.concat1)
        Me.Controls.Add(Me.languageBtn)
        Me.Controls.Add(Me.allFilesCheckBox)
        Me.Controls.Add(Me.videoFilesCheckBox)
        Me.Controls.Add(Me.audioFilesCheckBox)
        Me.Controls.Add(Me.aboutBtn)
        Me.Controls.Add(Me.regretBtn)
        Me.Controls.Add(Me.executeBtn)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Link)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TurnOn2)
        Me.Controls.Add(Me.Lang1)
        Me.Controls.Add(Me.TurnOn1)
        Me.Controls.Add(Me.L9)
        Me.Controls.Add(Me.L8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.openFolderBtn)
        Me.Controls.Add(Me.checkFilesNameBtn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Naming and arranging the surahs of the Quran - تسمية وترتيب سور القرآن v2.4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TurnOn2 As CheckBox
    Friend WithEvents Lang1 As ComboBox
    Friend WithEvents TurnOn1 As CheckBox
    Friend WithEvents L9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents openFolderBtn As Button
    Friend WithEvents checkFilesNameBtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Folder As FolderBrowserDialog
    Friend WithEvents Link As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents executeBtn As Button
    Friend WithEvents L8 As Label
    Friend WithEvents regretBtn As Button
    Friend WithEvents aboutBtn As Button
    Friend WithEvents audioFilesCheckBox As CheckBox
    Friend WithEvents videoFilesCheckBox As CheckBox
    Friend WithEvents allFilesCheckBox As CheckBox
    Friend WithEvents languageBtn As Button
    Friend WithEvents concat1 As TextBox
    Friend WithEvents concat2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lang2 As ComboBox
    Friend WithEvents concat3 As TextBox
    Friend WithEvents Lang3 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TurnOn3 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents concat4 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents color1desc As Label
    Friend WithEvents color2desc As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents color3desc As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents color4desc As Label
    Friend WithEvents Label20 As Label
End Class
