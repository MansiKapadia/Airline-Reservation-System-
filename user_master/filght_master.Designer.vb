<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filght_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(filght_master))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FLIGHT_DETAILS = New System.Windows.Forms.GroupBox()
        Me.ComboBox_to = New System.Windows.Forms.ComboBox()
        Me.ComboBox_from = New System.Windows.Forms.ComboBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.DateTimePickerdate = New System.Windows.Forms.DateTimePicker()
        Me.txtf_hour = New System.Windows.Forms.TextBox()
        Me.txtf_amt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtflname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FLIGHT_DETAILS.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("RomanT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FLIGHT DETAILS"
        '
        'FLIGHT_DETAILS
        '
        Me.FLIGHT_DETAILS.BackColor = System.Drawing.Color.Transparent
        Me.FLIGHT_DETAILS.Controls.Add(Me.ComboBox_to)
        Me.FLIGHT_DETAILS.Controls.Add(Me.ComboBox_from)
        Me.FLIGHT_DETAILS.Controls.Add(Me.txtid)
        Me.FLIGHT_DETAILS.Controls.Add(Me.txtname)
        Me.FLIGHT_DETAILS.Controls.Add(Me.DateTimePickerdate)
        Me.FLIGHT_DETAILS.Controls.Add(Me.txtf_hour)
        Me.FLIGHT_DETAILS.Controls.Add(Me.txtf_amt)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label8)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label7)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label6)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label5)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label4)
        Me.FLIGHT_DETAILS.Controls.Add(Me.txtflname)
        Me.FLIGHT_DETAILS.Controls.Add(Me.Label3)
        Me.FLIGHT_DETAILS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FLIGHT_DETAILS.Location = New System.Drawing.Point(12, 68)
        Me.FLIGHT_DETAILS.Name = "FLIGHT_DETAILS"
        Me.FLIGHT_DETAILS.Size = New System.Drawing.Size(455, 274)
        Me.FLIGHT_DETAILS.TabIndex = 2
        Me.FLIGHT_DETAILS.TabStop = False
        Me.FLIGHT_DETAILS.Text = "FLIGHT_DETAILS"
        '
        'ComboBox_to
        '
        Me.ComboBox_to.FormattingEnabled = True
        Me.ComboBox_to.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Amaravati", "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Itanagar", "Assam" & Global.Microsoft.VisualBasic.ChrW(9) & "Dispur", "Bihar" & Global.Microsoft.VisualBasic.ChrW(9) & "Patna", "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9) & "Raipur", "Goa" & Global.Microsoft.VisualBasic.ChrW(9) & "Panaji", "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9) & "Gandhinagar", "Haryana" & Global.Microsoft.VisualBasic.ChrW(9) & "Chandigarh", "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Shimla", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9) & "Ranchi", "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9) & "Bengaluru", "Kerala" & Global.Microsoft.VisualBasic.ChrW(9) & "Thiruvananthapuram", "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Bhopal", "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9) & "Mumbai", "Manipur" & Global.Microsoft.VisualBasic.ChrW(9) & "Imphal", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9) & "Shillong", "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9) & "Aizawl", "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9) & "Kohima", "Odisha" & Global.Microsoft.VisualBasic.ChrW(9) & "Bhubaneswar", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Rajasthan", "Jaipur", "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Gangtok", "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Chennai", "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Hyderabad", "Tripura" & Global.Microsoft.VisualBasic.ChrW(9) & "Agartala", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Lucknow", "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Dehradun ", "Gairsain ", "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9), "Kolkata", "Andaman and Nicobar Islands" & Global.Microsoft.VisualBasic.ChrW(9), "Port Blair", "Dadra & Nagar Haveli and Daman & DiuDaman", "Delhi", "New Delhi", "Jammu and Kashmir" & Global.Microsoft.VisualBasic.ChrW(9), "Srinagar", "Jammu ", "Lakshadweep" & Global.Microsoft.VisualBasic.ChrW(9), "Kavaratti", "Puducherry" & Global.Microsoft.VisualBasic.ChrW(9), "Ladakh Leh"})
        Me.ComboBox_to.Location = New System.Drawing.Point(218, 119)
        Me.ComboBox_to.Name = "ComboBox_to"
        Me.ComboBox_to.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox_to.TabIndex = 24
        Me.ComboBox_to.Text = "SELECT STATE"
        '
        'ComboBox_from
        '
        Me.ComboBox_from.FormattingEnabled = True
        Me.ComboBox_from.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Amaravati", "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Itanagar", "Assam" & Global.Microsoft.VisualBasic.ChrW(9) & "Dispur", "Bihar" & Global.Microsoft.VisualBasic.ChrW(9) & "Patna", "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9) & "Raipur", "Goa" & Global.Microsoft.VisualBasic.ChrW(9) & "Panaji", "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9) & "Gandhinagar", "Haryana" & Global.Microsoft.VisualBasic.ChrW(9) & "Chandigarh", "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Shimla", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9) & "Ranchi", "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9) & "Bengaluru", "Kerala" & Global.Microsoft.VisualBasic.ChrW(9) & "Thiruvananthapuram", "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9) & "Bhopal", "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9) & "Mumbai", "Manipur" & Global.Microsoft.VisualBasic.ChrW(9) & "Imphal", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9) & "Shillong", "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9) & "Aizawl", "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9) & "Kohima", "Odisha" & Global.Microsoft.VisualBasic.ChrW(9) & "Bhubaneswar", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Chandigarh", "Rajasthan", "Jaipur", "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Gangtok", "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Chennai", "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Hyderabad", "Tripura" & Global.Microsoft.VisualBasic.ChrW(9) & "Agartala", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Lucknow", "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Dehradun ", "Gairsain ", "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9), "Kolkata", "Andaman and Nicobar Islands" & Global.Microsoft.VisualBasic.ChrW(9), "Port Blair", "Dadra & Nagar Haveli and Daman & DiuDaman", "Delhi", "New Delhi", "Jammu and Kashmir" & Global.Microsoft.VisualBasic.ChrW(9), "Srinagar", "Jammu ", "Lakshadweep" & Global.Microsoft.VisualBasic.ChrW(9), "Kavaratti", "Puducherry" & Global.Microsoft.VisualBasic.ChrW(9), "Ladakh Leh"})
        Me.ComboBox_from.Location = New System.Drawing.Point(218, 89)
        Me.ComboBox_from.Name = "ComboBox_from"
        Me.ComboBox_from.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox_from.TabIndex = 23
        Me.ComboBox_from.Text = "SELECT STATE"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(218, 27)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(200, 22)
        Me.txtid.TabIndex = 22
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(218, 55)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(200, 22)
        Me.txtname.TabIndex = 19
        '
        'DateTimePickerdate
        '
        Me.DateTimePickerdate.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerdate.Location = New System.Drawing.Point(218, 156)
        Me.DateTimePickerdate.Name = "DateTimePickerdate"
        Me.DateTimePickerdate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerdate.TabIndex = 13
        '
        'txtf_hour
        '
        Me.txtf_hour.Location = New System.Drawing.Point(218, 190)
        Me.txtf_hour.Name = "txtf_hour"
        Me.txtf_hour.Size = New System.Drawing.Size(200, 22)
        Me.txtf_hour.TabIndex = 7
        '
        'txtf_amt
        '
        Me.txtf_amt.Location = New System.Drawing.Point(218, 224)
        Me.txtf_amt.Name = "txtf_amt"
        Me.txtf_amt.Size = New System.Drawing.Size(200, 22)
        Me.txtf_amt.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 28)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "FLIGHT_AMOUNT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "FLIGHT_HOURS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 28)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "FLIGHT_DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "FLIGHT_TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 28)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FLIGHT_FROM"
        '
        'txtflname
        '
        Me.txtflname.AutoSize = True
        Me.txtflname.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtflname.Location = New System.Drawing.Point(6, 60)
        Me.txtflname.Name = "txtflname"
        Me.txtflname.Size = New System.Drawing.Size(165, 28)
        Me.txtflname.TabIndex = 1
        Me.txtflname.Text = "FLIGHT_NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("RomanT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "FLIGHT_ID"
        '
        'btn_insert
        '
        Me.btn_insert.Image = Global.user_master.My.Resources.Resources.admin_but5
        Me.btn_insert.Location = New System.Drawing.Point(12, 360)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(106, 30)
        Me.btn_insert.TabIndex = 27
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.BackgroundImage = Global.user_master.My.Resources.Resources.search1
        Me.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsearch.Location = New System.Drawing.Point(124, 360)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 33)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImage = Global.user_master.My.Resources.Resources.update
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdate.Location = New System.Drawing.Point(238, 359)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(99, 33)
        Me.btnupdate.TabIndex = 29
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.BackgroundImage = Global.user_master.My.Resources.Resources.del
        Me.btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndel.Location = New System.Drawing.Point(343, 360)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(87, 33)
        Me.btndel.TabIndex = 30
        Me.btndel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(492, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(497, 212)
        Me.DataGridView1.TabIndex = 31
        '
        'filght_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 459)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.FLIGHT_DETAILS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "filght_master"
        Me.Text = "filght_master"
        Me.FLIGHT_DETAILS.ResumeLayout(False)
        Me.FLIGHT_DETAILS.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FLIGHT_DETAILS As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtflname As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtf_hour As System.Windows.Forms.TextBox
    Friend WithEvents txtf_amt As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePickerdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents btn_insert As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents ComboBox_to As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_from As System.Windows.Forms.ComboBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
