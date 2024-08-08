Imports System.Data.OleDb
Public Class viewbook
    'object of viewbook
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub viewbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'clear
        ds.Clear()
        qry = "select * from book where book_id=" & txtbookid.Text
        adp = New OleDbDataAdapter(qry, cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Sub fillgrid()
        'fillgrid
        ds.Clear()
        qry = "select * from book"
        adp = New OleDbDataAdapter(qry, cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)


    End Sub
End Class