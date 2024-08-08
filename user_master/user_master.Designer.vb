<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.Label()
        Me.DateTimePickerdob = New System.Windows.Forms.DateTimePicker()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.txtcont = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtpan = New System.Windows.Forms.TextBox()
        Me.txtadar = New System.Windows.Forms.TextBox()
        Me.txtpassnum = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtgen = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label1.Font = New System.Drawing.Font("RomanT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIGN-UP FOR NEW USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USER ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FIRST NAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.PASSWORD)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdob)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.btn_sub)
        Me.GroupBox1.Controls.Add(Me.radF)
        Me.GroupBox1.Controls.Add(Me.radM)
        Me.GroupBox1.Controls.Add(Me.txtcont)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtpan)
        Me.GroupBox1.Controls.Add(Me.txtadar)
        Me.GroupBox1.Controls.Add(Me.txtpassnum)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtgen)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER INFO"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(170, 167)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(209, 27)
        Me.txtpass.TabIndex = 34
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PASSWORD
        '
        Me.PASSWORD.AutoSize = True
        Me.PASSWORD.BackColor = System.Drawing.Color.Transparent
        Me.PASSWORD.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORD.Location = New System.Drawing.Point(8, 167)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.Size = New System.Drawing.Size(127, 28)
        Me.PASSWORD.TabIndex = 33
        Me.PASSWORD.Text = "PASSWORD"
        '
        'DateTimePickerdob
        '
        Me.DateTimePickerdob.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerdob.Location = New System.Drawing.Point(789, 21)
        Me.DateTimePickerdob.Name = "DateTimePickerdob"
        Me.DateTimePickerdob.Size = New System.Drawing.Size(149, 27)
        Me.DateTimePickerdob.TabIndex = 32
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(170, 212)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(209, 104)
        Me.txtadd.TabIndex = 28
        Me.txtadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_sub
        '
        Me.btn_sub.Image = Global.user_master.My.Resources.Resources.btnsubmit1
        Me.btn_sub.Location = New System.Drawing.Point(791, 342)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(147, 50)
        Me.btn_sub.TabIndex = 27
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radF.Location = New System.Drawing.Point(266, 353)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(113, 32)
        Me.radF.TabIndex = 26
        Me.radF.TabStop = True
        Me.radF.Text = "FEMALE"
        Me.radF.UseVisualStyleBackColor = True
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radM.Location = New System.Drawing.Point(151, 351)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(86, 32)
        Me.radM.TabIndex = 25
        Me.radM.TabStop = True
        Me.radM.Text = "MALE"
        Me.radM.UseVisualStyleBackColor = True
        '
        'txtcont
        '
        Me.txtcont.Location = New System.Drawing.Point(789, 135)
        Me.txtcont.Name = "txtcont"
        Me.txtcont.Size = New System.Drawing.Size(149, 27)
        Me.txtcont.TabIndex = 24
        Me.txtcont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(789, 100)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(149, 27)
        Me.txtmail.TabIndex = 23
        Me.txtmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpan
        '
        Me.txtpan.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtpan.Location = New System.Drawing.Point(789, 168)
        Me.txtpan.Name = "txtpan"
        Me.txtpan.Size = New System.Drawing.Size(149, 27)
        Me.txtpan.TabIndex = 21
        Me.txtpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadar
        '
        Me.txtadar.Location = New System.Drawing.Point(789, 239)
        Me.txtadar.Name = "txtadar"
        Me.txtadar.Size = New System.Drawing.Size(149, 27)
        Me.txtadar.TabIndex = 20
        Me.txtadar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpassnum
        '
        Me.txtpassnum.Location = New System.Drawing.Point(789, 206)
        Me.txtpassnum.Name = "txtpassnum"
        Me.txtpassnum.Size = New System.Drawing.Size(149, 27)
        Me.txtpassnum.TabIndex = 19
        Me.txtpassnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(789, 61)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(149, 27)
        Me.txtage.TabIndex = 18
        Me.txtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(170, 128)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(209, 27)
        Me.txtlname.TabIndex = 17
        Me.txtlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(170, 94)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(209, 27)
        Me.txtname.TabIndex = 16
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(170, 61)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(209, 27)
        Me.txtfname.TabIndex = 15
        Me.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(170, 23)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(209, 27)
        Me.txtid.TabIndex = 14
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtgen
        '
        Me.txtgen.AutoSize = True
        Me.txtgen.BackColor = System.Drawing.Color.Transparent
        Me.txtgen.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgen.Location = New System.Drawing.Point(17, 353)
        Me.txtgen.Name = "txtgen"
        Me.txtgen.Size = New System.Drawing.Size(101, 28)
        Me.txtgen.TabIndex = 13
        Me.txtgen.Text = "GENDER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(565, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 28)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "EMAIL ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(565, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(217, 28)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "CONTACT NUMBER"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(565, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(231, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "PASSPORT NUMBER"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(565, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PANCARD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(565, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 28)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ADHARCARD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(565, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "DOB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(565, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "AGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "USER NAME"
        '
        'user_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.airline
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "user_master"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtgen As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtpassnum As System.Windows.Forms.TextBox
    Friend WithEvents txtpan As System.Windows.Forms.TextBox
    Friend WithEvents txtadar As System.Windows.Forms.TextBox
    Friend WithEvents radM As System.Windows.Forms.RadioButton
    Friend WithEvents txtcont As System.Windows.Forms.TextBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents btn_sub As System.Windows.Forms.Button
    Friend WithEvents radF As System.Windows.Forms.RadioButton
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents PASSWORD As System.Windows.Forms.Label

End Class
