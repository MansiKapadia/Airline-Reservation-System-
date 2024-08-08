Imports System.Data.OleDb

Public Class admin_master
    'admin_master object
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dap As New OleDbDataAdapter
    Dim ds As DataSet

    'insert ofadmin admin_id,adminname,DOB,Adharcard,contact,email_id,password
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        cn.Open()
        qry = "insert into admin_master values(" & txtadmin_id.Text & ",'" & txtadmin_name.Text & "','" & datetimepickerdob.Text & "'," & txtadadharcard.Text & "," & txtadcontact.Text & ",'" & txtademail.Text & "'," & txtadmin_password.Text & ")"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD INSERTED SUCCESSFULLY.......", MsgBoxStyle.Information)
        Dim x As New admin_log
        x.Show()
        Me.Close()
    End Sub
End Class