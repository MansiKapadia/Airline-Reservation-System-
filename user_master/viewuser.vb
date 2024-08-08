Imports System.Data.OleDb
Public Class viewuser
    'object of viewuser
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")

    Dim qry As String

    Dim dap As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub viewuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'data adapter of all data
        ds.Clear()
        qry = "select * from user_master"
        dap = New OleDbDataAdapter(qry, cn)
        dap.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub


    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        ds.Clear()
        qry = "select * from user_master where user_id=" & txt_uid.Text
        dap = New OleDbDataAdapter(qry, cn)
        dap.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_dispall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds.Clear()
        qry = "select * from user_master"
        dap = New OleDbDataAdapter(qry, cn)
        dap.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub


End Class