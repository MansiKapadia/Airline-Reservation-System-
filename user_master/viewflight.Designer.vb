<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewflight
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
        Me.lblVwFLIGHT = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFROM = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.comboTo = New System.Windows.Forms.ComboBox()
        Me.combofrom = New System.Windows.Forms.ComboBox()
        Me.btnview = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVwFLIGHT
        '
        Me.lblVwFLIGHT.AutoSize = True
        Me.lblVwFLIGHT.BackColor = System.Drawing.Color.Transparent
        Me.lblVwFLIGHT.Font = New System.Drawing.Font("RomanT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVwFLIGHT.Location = New System.Drawing.Point(158, 9)
        Me.lblVwFLIGHT.Name = "lblVwFLIGHT"
        Me.lblVwFLIGHT.Size = New System.Drawing.Size(300, 50)
        Me.lblVwFLIGHT.TabIndex = 0
        Me.lblVwFLIGHT.Text = "VIEW FLIGHT"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.ForeColor = System.Drawing.Color.White
        Me.lblTo.Location = New System.Drawing.Point(32, 88)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(44, 30)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "TO"
        '
        'lblFROM
        '
        Me.lblFROM.AutoSize = True
        Me.lblFROM.BackColor = System.Drawing.Color.Transparent
        Me.lblFROM.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFROM.ForeColor = System.Drawing.Color.Transparent
        Me.lblFROM.Location = New System.Drawing.Point(32, 133)
        Me.lblFROM.Name = "lblFROM"
        Me.lblFROM.Size = New System.Drawing.Size(79, 30)
        Me.lblFROM.TabIndex = 2
        Me.lblFROM.Text = "FROM"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Transparent
        Me.lblDate.Location = New System.Drawing.Point(36, 176)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(75, 30)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "DATE"
        '
        'comboTo
        '
        Me.comboTo.Font = New System.Drawing.Font("RomanT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTo.FormattingEnabled = True
        Me.comboTo.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Amaravati", "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Assam" & Global.Microsoft.VisualBasic.ChrW(9), "Dispur", "Bihar" & Global.Microsoft.VisualBasic.ChrW(9), "Patna", "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9), "Raipur", "Goa" & Global.Microsoft.VisualBasic.ChrW(9), "Panaji", "Gandhinagar", "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Shimla", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9), "Ranchi", "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9), "Bengaluru", "Kerala" & Global.Microsoft.VisualBasic.ChrW(9), "Thiruvananthapuram", "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Bhopal", "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9), "Manipur" & Global.Microsoft.VisualBasic.ChrW(9) & "Imphal", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9), "Shillong", "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9) & "Aizawl", "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9), "Kohima", "Odisha" & Global.Microsoft.VisualBasic.ChrW(9), "Bhubaneswar", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Rajasthan", "Jaipur", "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Gangtok", "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Chennai", "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Hyderabad", "Tripura" & Global.Microsoft.VisualBasic.ChrW(9) & "Agartala", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Lucknow", "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Dehradun ", "Gairsain ", "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9), "Kolkata", "Andaman and Nicobar Islands" & Global.Microsoft.VisualBasic.ChrW(9), "Port Blair", "Dadra & Nagar Haveli and Daman & DiuDaman", "Delhi", "New Delhi", "Jammu and Kashmir" & Global.Microsoft.VisualBasic.ChrW(9), "Srinagar", "Jammu ", "Lakshadweep" & Global.Microsoft.VisualBasic.ChrW(9), "Kavaratti", "Puducherry" & Global.Microsoft.VisualBasic.ChrW(9), "Ladakh" & Global.Microsoft.VisualBasic.ChrW(9) & "Leh"})
        Me.comboTo.Location = New System.Drawing.Point(131, 80)
        Me.comboTo.Name = "comboTo"
        Me.comboTo.Size = New System.Drawing.Size(121, 25)
        Me.comboTo.TabIndex = 4
        Me.comboTo.Text = "SELECT TO"
        '
        'combofrom
        '
        Me.combofrom.Font = New System.Drawing.Font("RomanT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combofrom.FormattingEnabled = True
        Me.combofrom.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Amaravati", "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Assam" & Global.Microsoft.VisualBasic.ChrW(9), "Dispur", "Bihar" & Global.Microsoft.VisualBasic.ChrW(9), "Patna", "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9), "Raipur", "Goa" & Global.Microsoft.VisualBasic.ChrW(9), "Panaji", "Gandhinagar", "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Shimla", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9), "Ranchi", "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9), "Bengaluru", "Kerala" & Global.Microsoft.VisualBasic.ChrW(9), "Thiruvananthapuram", "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Bhopal", "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9), "Manipur" & Global.Microsoft.VisualBasic.ChrW(9) & "Imphal", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9), "Shillong", "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9) & "Aizawl", "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9), "Kohima", "Odisha" & Global.Microsoft.VisualBasic.ChrW(9), "Bhubaneswar", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Rajasthan", "Jaipur", "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Gangtok", "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Chennai", "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Hyderabad", "Tripura" & Global.Microsoft.VisualBasic.ChrW(9) & "Agartala", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Lucknow", "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Dehradun ", "Gairsain ", "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9), "Kolkata", "Andaman and Nicobar Islands" & Global.Microsoft.VisualBasic.ChrW(9), "Port Blair", "Dadra & Nagar Haveli and Daman & DiuDaman", "Delhi", "New Delhi", "Jammu and Kashmir" & Global.Microsoft.VisualBasic.ChrW(9), "Srinagar", "Jammu ", "Lakshadweep" & Global.Microsoft.VisualBasic.ChrW(9), "Kavaratti", "Puducherry" & Global.Microsoft.VisualBasic.ChrW(9), "Ladakh Leh"})
        Me.combofrom.Location = New System.Drawing.Point(131, 125)
        Me.combofrom.Name = "combofrom"
        Me.combofrom.Size = New System.Drawing.Size(121, 25)
        Me.combofrom.TabIndex = 5
        Me.combofrom.Text = "SELECT FROM"
        '
        'btnview
        '
        Me.btnview.Font = New System.Drawing.Font("RomanT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(41, 251)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(129, 41)
        Me.btnview.TabIndex = 8
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(341, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 204)
        Me.DataGridView1.TabIndex = 9
        '
        'DateTimePickerdate
        '
        Me.DateTimePickerdate.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerdate.Location = New System.Drawing.Point(135, 181)
        Me.DateTimePickerdate.Name = "DateTimePickerdate"
        Me.DateTimePickerdate.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePickerdate.TabIndex = 10
        '
        'viewflight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.user_master.My.Resources.Resources.viewflight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(833, 431)
        Me.Controls.Add(Me.DateTimePickerdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.combofrom)
        Me.Controls.Add(Me.comboTo)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblFROM)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblVwFLIGHT)
        Me.Name = "viewflight"
        Me.Text = "viewflight"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVwFLIGHT As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFROM As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents comboTo As System.Windows.Forms.ComboBox
    Friend WithEvents combofrom As System.Windows.Forms.ComboBox
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePickerdate As System.Windows.Forms.DateTimePicker
End Class
