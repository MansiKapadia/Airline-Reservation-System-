Imports System.Data.OleDb
Public Class user_login
    'object of user_login
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader

    Private Sub btncreaccuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreaccuser.Click
        'show user_master
        Dim x As New user_master
        x.Show()

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        'insert of first_name n password
        cn.Open()
        qry = "select * from user_master where User_FirstName='" & txtfname.Text & "' and User_password=" & txtpass.Text

        cmd = New OleDbCommand(qry, cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Dim x As New userMID
            x.Show()
            Me.Hide()
        Else
            MsgBox("U HAVE TO SIGN UP THEN U CAN LOGIN...", MsgBoxStyle.Critical, "NOT FOUND.....")

        End If
        cn.Close()
    End Sub

    Private Sub user_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class