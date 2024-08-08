Imports System.Data.OleDb

Public Class user_master
    'object of user_master
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dap As New OleDbDataAdapter
    Dim ds As DataSet
    Private Sub user_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim gender As String
    'insert of user_master of id,name,lastname,address,gender,DOB,age,emailid,contact,pancard,passport,adharcard,password
    Private Sub btn_sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sub.Click
        If radM.Checked Then
            gender = radM.Text
        Else
            gender = radF.Text
        End If
        cn.Open()
        qry = "insert into user_master values(" & txtid.Text & ",'" & txtfname.Text & "','" & txtname.Text & "','" & txtlname.Text & "','" & txtadd.Text & "','" & gender & "','" & DateTimePickerdob.Text & "'," & txtage.Text & ",'" & txtmail.Text & "'," & txtcont.Text & "," & txtpan.Text & "," & txtpassnum.Text & "," & txtadar.Text & "," & txtpass.Text & ")"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        Dim x As New user_login
        x.Show()
        cn.Close()
        MsgBox("RECORD INSERTED SUCCESSFULLY...", MsgBoxStyle.Information)
    End Sub
    'clear
    Sub clear()
        Dim x As Control

        For Each x In Me.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next
    End Sub

    Private Sub DateTimePickerdob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerdob.ValueChanged
        'age
        Dim d1 = DateTimePickerdob.Value
        Dim y1 = d1.Year

        Dim d2 = Date.Now
        Dim y2 = d2.Year

        txtage.Text = y2 - y1

    End Sub
End Class
