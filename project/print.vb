Imports MySql.Data.MySqlClient
Public Class print
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub lblPassgername_Click(sender As Object, e As EventArgs) Handles lblPassgername.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select* from osadd.Passenger where  Pass_Username = '" & Form1.txtUserName.Text & "' and Pass_Password  = '" & Form1.txtPassword.Text & "' "

            Command = New MySqlCommand(Query, conn)
            read = Command.ExecuteReader
            While read.Read
                lblPassgername.Text = read.GetString("Pass_Name")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblPassgername_Click_1(sender As Object, e As EventArgs) Handles lblPassgername.Click

    End Sub

    Private Sub lbldeparturedate_Click(sender As Object, e As EventArgs) Handles lbldeparturedate.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from osadd.ticket where tarikh ='" & Buy.CbDate.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
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

    Private Sub lbldepartureTime_Click(sender As Object, e As EventArgs) Handles lbldepartureTime.VisibleChanged
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
                lbldepartureTime.Text = read.GetString("masa")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblseat_Click(sender As Object, e As EventArgs) Handles lblseat.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from osadd.ticket where seat ='" & Selectseat.numseat.Text & "' and id = '" & Buy.Label6.Text & "'"

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            While read.Read
                lblseat.Text = read.GetString("seat")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("your ticket is printing")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
      
            Me.Hide()
        Buy.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim a As String
        a = MessageBox.Show("Do you want to exit?", "comfirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If a = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        ElseIf a = Windows.Forms.DialogResult.No Then

        End If

    End Sub

    
    
End Class