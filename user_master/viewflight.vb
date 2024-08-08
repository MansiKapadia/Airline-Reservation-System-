Imports System.Data.OleDb

Public Class viewflight
    'object of viewflight
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim dap As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub viewflight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim dr As OleDbDataReader

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        ' flight_to,flight_from,flight_date
        ds.Clear()
        qry = "select * from flight_master where flight_to='" & combofrom.Text & "' and flight_from='" & comboTo.Text & "' and flight_date='" & DateTimePickerdate.Value.Date & "'"
        dap = New OleDbDataAdapter(qry, cn)
        dap.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

  
End Class