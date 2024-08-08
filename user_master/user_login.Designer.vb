<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_login
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
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btncreaccuser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(501, 239)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(233, 20)
        Me.txtfname.TabIndex = 0
        Me.txtfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(566, 299)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(155, 20)
        Me.txtpass.TabIndex = 1
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_login.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(463, 362)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(271, 46)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btncreaccuser
        '
        Me.btncreaccuser.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncreaccuser.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreaccuser.Location = New System.Drawing.Point(463, 414)
        Me.btncreaccuser.Name = "btncreaccuser"
        Me.btncreaccuser.Size = New System.Drawing.Size(271, 46)
        Me.btncreaccuser.TabIndex = 3
        Me.btncreaccuser.Text = "CREATE ACCOUNT"
        Me.btncreaccuser.UseVisualStyleBackColor = False
        '
        'user_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.login_page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncreaccuser)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtfname)
        Me.Name = "user_login"
        Me.Text = "user_login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btncreaccuser As System.Windows.Forms.Button
End Class
