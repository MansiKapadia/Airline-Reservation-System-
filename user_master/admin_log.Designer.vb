<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_log
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
        Me.txtadmin_name = New System.Windows.Forms.TextBox()
        Me.txtadmin_pass = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btncreaccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtadmin_name
        '
        Me.txtadmin_name.Location = New System.Drawing.Point(178, 117)
        Me.txtadmin_name.Name = "txtadmin_name"
        Me.txtadmin_name.Size = New System.Drawing.Size(233, 20)
        Me.txtadmin_name.TabIndex = 0
        Me.txtadmin_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadmin_pass
        '
        Me.txtadmin_pass.Location = New System.Drawing.Point(178, 190)
        Me.txtadmin_pass.Name = "txtadmin_pass"
        Me.txtadmin_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtadmin_pass.Size = New System.Drawing.Size(233, 20)
        Me.txtadmin_pass.TabIndex = 1
        Me.txtadmin_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(142, 234)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(103, 50)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btncreaccount
        '
        Me.btncreaccount.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreaccount.Location = New System.Drawing.Point(251, 234)
        Me.btncreaccount.Name = "btncreaccount"
        Me.btncreaccount.Size = New System.Drawing.Size(264, 50)
        Me.btncreaccount.TabIndex = 3
        Me.btncreaccount.Text = "CREATE ACCOUNT"
        Me.btncreaccount.UseVisualStyleBackColor = True
        '
        'admin_log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.admin_login
        Me.ClientSize = New System.Drawing.Size(527, 355)
        Me.Controls.Add(Me.btncreaccount)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtadmin_pass)
        Me.Controls.Add(Me.txtadmin_name)
        Me.Name = "admin_log"
        Me.Text = "admin_log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtadmin_name As System.Windows.Forms.TextBox
    Friend WithEvents txtadmin_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btncreaccount As System.Windows.Forms.Button
End Class
