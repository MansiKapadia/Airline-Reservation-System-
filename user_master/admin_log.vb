Imports System.Data.OleDb
Public Class admin_log
    'admin_login objects
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader

    'admin_master login
    Private Sub btncreaccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreaccount.Click
        Dim x As New admin_master
        x.Show()
        Me.Hide()

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        'insert of admin_name and password
        cn.Open()
        qry = "select * from admin_master where Admin_Name='" & txtadmin_name.Text & "' and Admin_password=" & txtadmin_pass.Text

        cmd = New OleDbCommand(qry, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Dim x As New admin_MDI
            x.Show()
            Me.Hide()
        Else
            MsgBox("U HAVE NOT SIGN UP THEN U CAN LOGIN..... ", MsgBoxStyle.Critical, "NOT FOUND ....")
        End If
        cn.Close()
    End Sub

    Private Sub admin_log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class