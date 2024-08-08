<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_seat = New System.Windows.Forms.TextBox()
        Me.ComboBox_from = New System.Windows.Forms.TextBox()
        Me.ComboBox_to = New System.Windows.Forms.TextBox()
        Me.DateTimePickerdate = New System.Windows.Forms.TextBox()
        Me.btn_disp = New System.Windows.Forms.Button()
        Me.txtfid = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtf_amt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpassnum = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RomanT", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK NOW"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_seat)
        Me.GroupBox1.Controls.Add(Me.ComboBox_from)
        Me.GroupBox1.Controls.Add(Me.ComboBox_to)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerdate)
        Me.GroupBox1.Controls.Add(Me.btn_disp)
        Me.GroupBox1.Controls.Add(Me.txtfid)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txttotal)
        Me.GroupBox1.Controls.Add(Me.txtf_amt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtuserid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 243)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESERVATION DETAILS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "BOOK_ID"
        '
        'txt_seat
        '
        Me.txt_seat.Location = New System.Drawing.Point(656, 113)
        Me.txt_seat.Name = "txt_seat"
        Me.txt_seat.Size = New System.Drawing.Size(178, 20)
        Me.txt_seat.TabIndex = 30
        '
        'ComboBox_from
        '
        Me.ComboBox_from.Location = New System.Drawing.Point(656, 26)
        Me.ComboBox_from.Name = "ComboBox_from"
        Me.ComboBox_from.Size = New System.Drawing.Size(200, 20)
        Me.ComboBox_from.TabIndex = 29
        '
        'ComboBox_to
        '
        Me.ComboBox_to.Location = New System.Drawing.Point(191, 168)
        Me.ComboBox_to.Name = "ComboBox_to"
        Me.ComboBox_to.Size = New System.Drawing.Size(200, 20)
        Me.ComboBox_to.TabIndex = 28
        '
        'DateTimePickerdate
        '
        Me.DateTimePickerdate.Location = New System.Drawing.Point(191, 132)
        Me.DateTimePickerdate.Name = "DateTimePickerdate"
        Me.DateTimePickerdate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerdate.TabIndex = 27
        '
        'btn_disp
        '
        Me.btn_disp.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_disp.Location = New System.Drawing.Point(483, 197)
        Me.btn_disp.Name = "btn_disp"
        Me.btn_disp.Size = New System.Drawing.Size(222, 40)
        Me.btn_disp.TabIndex = 26
        Me.btn_disp.Text = "FLIGHT_DETAILS"
        Me.btn_disp.UseVisualStyleBackColor = True
        '
        'txtfid
        '
        Me.txtfid.Location = New System.Drawing.Point(191, 92)
        Me.txtfid.Name = "txtfid"
        Me.txtfid.Size = New System.Drawing.Size(200, 20)
        Me.txtfid.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(480, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(165, 28)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "FLIGHT_FROM"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(656, 152)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(178, 20)
        Me.txttotal.TabIndex = 21
        '
        'txtf_amt
        '
        Me.txtf_amt.Location = New System.Drawing.Point(656, 62)
        Me.txtf_amt.Name = "txtf_amt"
        Me.txtf_amt.Size = New System.Drawing.Size(178, 20)
        Me.txtf_amt.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(478, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 28)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "TOTAL_FARE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(480, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "TICKET FARE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(480, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "TOTAL_SEAT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ORIGIN DEST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "FLIGHT DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FLIGHT_ID"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(191, 54)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(200, 20)
        Me.txtuserid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USER_ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtpassnum)
        Me.GroupBox2.Controls.Add(Me.btnsearch)
        Me.GroupBox2.Controls.Add(Me.submit)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.txtadd)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(932, 164)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASSENGER DEATILS"
        '
        'txtpassnum
        '
        Me.txtpassnum.Location = New System.Drawing.Point(302, 116)
        Me.txtpassnum.Name = "txtpassnum"
        Me.txtpassnum.Size = New System.Drawing.Size(187, 20)
        Me.txtpassnum.TabIndex = 30
        '
        'btnsearch
        '
        Me.btnsearch.BackgroundImage = Global.user_master.My.Resources.Resources.search1
        Me.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsearch.Location = New System.Drawing.Point(607, 35)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 33)
        Me.btnsearch.TabIndex = 27
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Image = Global.user_master.My.Resources.Resources.admin_but5
        Me.submit.Location = New System.Drawing.Point(495, 36)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(106, 30)
        Me.submit.TabIndex = 26
        Me.submit.UseVisualStyleBackColor = True
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(302, 64)
        Me.txtfname.Multiline = True
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(187, 20)
        Me.txtfname.TabIndex = 25
        '
        'txtadd
        '
        Me.txtadd.Location = New System.Drawing.Point(302, 90)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(187, 20)
        Me.txtadd.TabIndex = 23
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(302, 33)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(187, 20)
        Me.txtid.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 28)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "PASSENGER ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 28)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "PASSPORT NO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(252, 28)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "PASSENGER ADDRESS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(214, 28)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "PASSENGER NAME"
        '
        'book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.book
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 518)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "book"
        Me.Text = "book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtf_amt As System.Windows.Forms.TextBox
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtpassnum As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtfid As System.Windows.Forms.TextBox
    Friend WithEvents btn_disp As System.Windows.Forms.Button
    Friend WithEvents ComboBox_from As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_to As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerdate As System.Windows.Forms.TextBox
    Friend WithEvents txt_seat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
