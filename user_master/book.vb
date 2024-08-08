Imports System.Data.OleDb
Public Class book
    'objects of book
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HP\Documents\Visual Studio 2010\Projects\airline_management\Airline.mdb")
    Dim cmd As New OleDbCommand
    Dim qry As String
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        'insert of book id,userid,flightid,flightdate,flight_to,flightform,ticket_fare,ticket_seat,total_fare
        cn.Open()
        qry = "insert into book (user_id,flight_id,flight_date,flight_to,flight_from,ticket_fare,ticket_seat,total_fare) values(" & txtuserid.Text & "," & txtfid.Text & ",'" & DateTimePickerdate.Text & "','" & ComboBox_to.Text & "','" & ComboBox_from.Text & "'," & txtf_amt.Text & "," & txt_seat.Text & "," & txttotal.Text & ")"
        cmd = New OleDbCommand(qry, cn)
        cmd.ExecuteNonQuery()
        MsgBox("RECORD INSERTED SUCCESSFULLY", MsgBoxStyle.Information)
        cn.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        'search of book id,username,user_firstname,user_address,user_passport
        If txtid.Text <> "" Then
            cn.Open()
            qry = "select * from user_master where user_id=" & txtid.Text
            cmd = New OleDbCommand(qry, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()

                txtid.Text = dr("user_id")
                txtuserid.Text = dr("user_id")
                txtfname.Text = dr("user_firstname")
                txtadd.Text = dr("user_address")
                txtpassnum.Text = dr("user_passport")
            End If
            cn.Close()
        Else

        End If

    End Sub

    Private Sub book_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_disp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_disp.Click
        'display of ,flightid,flightdate,flight_to,flightform
        If txtfid.Text <> "" Then
            cn.Open()
            qry = "select * from flight_master where flight_id=" & txtfid.Text
            cmd = New OleDbCommand(qry, cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txtfid.Text = dr("flight_id")
                DateTimePickerdate.Text = dr("flight_date")
                ComboBox_to.Text = dr("flight_to")
                ComboBox_from.Text = dr("flight_from")
                txtf_amt.Text = dr("flight_amount")

            End If
            cn.Close()
        Else
            MsgBox("Please Enter FLight Id")
        End If

    End Sub



    Private Sub txt_seat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_seat.TextChanged
        'total amount
        txttotal.Text = Val(txtf_amt.Text) * Val(txt_seat.Text)

    End Sub
End Class