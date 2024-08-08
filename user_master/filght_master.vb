Imports System.Data.OleDb
Public Class filght_master
    'object of flight_master
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub filght_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillgrid()
        clear()

    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click
        'insert of flight id,name,form,to,date,hour,amount
        cn.Open()
        qry = "insert into flight_master values(" & txtid.Text & ",'" & txtname.Text & "','" & ComboBox_from.Text & "','" & ComboBox_to.Text & "','" & DateTimePickerdate.Text & "'," & txtf_hour.Text & "," & txtf_amt.Text & ")"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD INSETED SUCCCESSFULLY...")
        fillgrid()
        clear()

    End Sub
    Sub fillgrid()
        'data adapter
        ds.Clear()
        qry = "select * from flight_master"
        adp = New OleDbDataAdapter(qry, cn)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Sub clear()
        'clear
        Dim x As Control
        For Each x In Me.Controls
            If TypeOf x Is TextBox Then
                x.Text = ""
            End If
        Next

    End Sub
    Dim dr As OleDbDataReader
    Dim fid As Integer

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        'search of flight id,name,form,to,date,hour,amount
        fid = InputBox("Enter Flight ID : ")
        cn.Open()
        qry = "select * from flight_master where Flight_Id=" & fid
        cmd = New OleDbCommand(qry, cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            txtid.Text = dr("Flight_Id")
            txtname.Text = dr("Flight_Name")
            ComboBox_from.Text = dr("Flight_From")
            ComboBox_to.Text = dr("Flight_To")
            DateTimePickerdate.Text = dr("Flight_Date")
            txtf_hour.Text = dr("Flight_Hour")
            txtf_amt.Text = dr("Flight_Amount")
        End If
        cn.Close()
    End Sub
    Dim ans As String

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        'delete of flight id,name,form,to,date,hour,amount
        ans = MsgBox("Are U sure U Want To Delete", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "My Delete Message...")
        If ans = vbYes Then

            cn.Open()
            qry = "delete from flight_master where Flight_Id=" & txtid.Text
            cmd = New OleDbCommand(qry, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            fillgrid()
            clear()

        Else
            MsgBox("Thank U...")
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        'update of flight id,name,form,to,date,hour,amount
        cn.Open()
        qry = "update flight_master set Flight_id=" & txtid.Text & ",Flight_name='" & txtname.Text & "',Flight_From='" & ComboBox_from.Text & "',Flight_To='" & ComboBox_to.Text & "',Flight_Date='" & DateTimePickerdate.Text & "',Flight_Hour=" & txtf_hour.Text & ",Flight_Amount=" & txtf_amt.Text & " where Flight_Id=" & txtid.Text
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("RECORD UPDATED SUCCESSFULLY....")
        fillgrid()
    End Sub
End Class