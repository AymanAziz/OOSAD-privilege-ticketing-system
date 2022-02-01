Imports MySql.Data.MySqlClient
Public Class comfirm
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub lbldeparturedate_Click(sender As Object, e As EventArgs) Handles lbldeparturedate.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from osadd.ticket where tarikh ='" & Buy.CbDate.Text & "' "

            Command = New MySqlCommand(Query, conn)
            read = Command.ExecuteReader
            While read.Read
                lbldeparturedate.Text = read.GetString("tarikh")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lbldeparturetime_Click(sender As Object, e As EventArgs) Handles lbldeparturetime.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select* from osadd.ticket where  id = '" & Buy.Label6.Text & "' and nosiri  = '" & Buy.nosiri1.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            While read.Read
                lbldeparturetime.Text = read.GetString("masa")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    
    Private Sub lblseatno_Click(sender As Object, e As EventArgs) Handles lblseatno.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from osadd.ticket where seat ='" & Selectseat.numseat.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            While read.Read
                lblseatno.Text = read.GetString("seat")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblprice_Click(sender As Object, e As EventArgs) Handles lblprice.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select* from osadd.ticket where  id = '" & Buy.Label6.Text & "' and nosiri  = '" & Buy.nosiri1.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            While read.Read
                lblprice.Text = read.GetString("price")

            End While


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblroute_Click(sender As Object, e As EventArgs) Handles lblroute.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
       
        Try
            conn.Open()
            Dim Query As String
            Query = "select* from osadd.ticket where  dari = '" & Buy.cbFrom.Text & "' and kepada  = '" & Buy.cbTo.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            lblroute.Text = Buy.cbFrom.Text & "-" & Buy.cbTo.Text


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btncomfirm_Click(sender As Object, e As EventArgs) Handles btncomfirm.Click
        Me.Hide()
        payment.Show()

    End Sub

    
    
End Class