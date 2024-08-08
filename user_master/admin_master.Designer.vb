<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_master
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.datetimepickerdob = New System.Windows.Forms.DateTimePicker()
        Me.txtademail = New System.Windows.Forms.TextBox()
        Me.txtadcontact = New System.Windows.Forms.TextBox()
        Me.txtadadharcard = New System.Windows.Forms.TextBox()
        Me.txtadmin_password = New System.Windows.Forms.TextBox()
        Me.txtadmin_name = New System.Windows.Forms.TextBox()
        Me.txtadmin_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("RomanT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnsubmit)
        Me.GroupBox1.Controls.Add(Me.datetimepickerdob)
        Me.GroupBox1.Controls.Add(Me.txtademail)
        Me.GroupBox1.Controls.Add(Me.txtadcontact)
        Me.GroupBox1.Controls.Add(Me.txtadadharcard)
        Me.GroupBox1.Controls.Add(Me.txtadmin_password)
        Me.GroupBox1.Controls.Add(Me.txtadmin_name)
        Me.GroupBox1.Controls.Add(Me.txtadmin_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 388)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADMIN_DETAILS"
        '
        'btnsubmit
        '
        Me.btnsubmit.BackgroundImage = Global.user_master.My.Resources.Resources.admin_but4
        Me.btnsubmit.Font = New System.Drawing.Font("RomanT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(741, 339)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(113, 32)
        Me.btnsubmit.TabIndex = 14
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'datetimepickerdob
        '
        Me.datetimepickerdob.Location = New System.Drawing.Point(216, 167)
        Me.datetimepickerdob.Name = "datetimepickerdob"
        Me.datetimepickerdob.Size = New System.Drawing.Size(200, 26)
        Me.datetimepickerdob.TabIndex = 13
        '
        'txtademail
        '
        Me.txtademail.Location = New System.Drawing.Point(646, 126)
        Me.txtademail.Name = "txtademail"
        Me.txtademail.Size = New System.Drawing.Size(180, 26)
        Me.txtademail.TabIndex = 11
        Me.txtademail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadcontact
        '
        Me.txtadcontact.Location = New System.Drawing.Point(646, 78)
        Me.txtadcontact.Name = "txtadcontact"
        Me.txtadcontact.Size = New System.Drawing.Size(180, 26)
        Me.txtadcontact.TabIndex = 10
        Me.txtadcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadadharcard
        '
        Me.txtadadharcard.Location = New System.Drawing.Point(646, 25)
        Me.txtadadharcard.Name = "txtadadharcard"
        Me.txtadadharcard.Size = New System.Drawing.Size(180, 26)
        Me.txtadadharcard.TabIndex = 9
        Me.txtadadharcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadmin_password
        '
        Me.txtadmin_password.Location = New System.Drawing.Point(216, 125)
        Me.txtadmin_password.Name = "txtadmin_password"
        Me.txtadmin_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtadmin_password.Size = New System.Drawing.Size(200, 26)
        Me.txtadmin_password.TabIndex = 8
        Me.txtadmin_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadmin_name
        '
        Me.txtadmin_name.Location = New System.Drawing.Point(216, 75)
        Me.txtadmin_name.Name = "txtadmin_name"
        Me.txtadmin_name.Size = New System.Drawing.Size(200, 26)
        Me.txtadmin_name.TabIndex = 7
        Me.txtadmin_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadmin_id
        '
        Me.txtadmin_id.Location = New System.Drawing.Point(216, 33)
        Me.txtadmin_id.Name = "txtadmin_id"
        Me.txtadmin_id.Size = New System.Drawing.Size(200, 26)
        Me.txtadmin_id.TabIndex = 2
        Me.txtadmin_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(460, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "EMAIL-ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(460, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "CONTACT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(460, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ADHARCARD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 56)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ADMIN_DOB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ADMIN_PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ADMIN_NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ADMIN_ID"
        '
        'admin_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.admin_master
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 481)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "admin_master"
        Me.Text = "admin_master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents datetimepickerdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtademail As System.Windows.Forms.TextBox
    Friend WithEvents txtadcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtadadharcard As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin_password As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin_name As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin_id As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
End Class
