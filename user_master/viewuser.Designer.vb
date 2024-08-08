<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewuser
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
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_uid = New System.Windows.Forms.TextBox()
        Me.btn_display = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("RomanT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER ID"
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("RomanT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_submit.Location = New System.Drawing.Point(19, 122)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(160, 45)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "SUBMIT"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(268, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(403, 176)
        Me.DataGridView1.TabIndex = 3
        '
        'txt_uid
        '
        Me.txt_uid.Location = New System.Drawing.Point(178, 49)
        Me.txt_uid.Name = "txt_uid"
        Me.txt_uid.Size = New System.Drawing.Size(122, 20)
        Me.txt_uid.TabIndex = 1
        '
        'btn_display
        '
        Me.btn_display.Font = New System.Drawing.Font("RomanT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_display.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_display.Location = New System.Drawing.Point(19, 188)
        Me.btn_display.Name = "btn_display"
        Me.btn_display.Size = New System.Drawing.Size(181, 45)
        Me.btn_display.TabIndex = 4
        Me.btn_display.Text = "DISPLAY ALL"
        Me.btn_display.UseVisualStyleBackColor = True
        '
        'viewuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(683, 356)
        Me.Controls.Add(Me.btn_display)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_uid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewuser"
        Me.Text = "viewuser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_uid As System.Windows.Forms.TextBox
    Friend WithEvents btn_display As System.Windows.Forms.Button
End Class
