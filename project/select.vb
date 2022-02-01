Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim a As Integer


    Private Sub btnselect8am_Click(sender As Object, e As EventArgs) Handles btnselect8am.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim READER As MySqlDataReader

        Try


            Mysqlconn.Open()
            Dim Query As String
            Query = "Insert into osadd.ticket(masa,id) values ( '" & "00:00:00" & "','" & Buy.Label6.Text & "') on duplicate key update masa='" & lbl8am.Text & "'"

            Command = New MySqlCommand(Query, Mysqlconn)
            READER = Command.ExecuteReader

            MessageBox.Show("Data is Saved")

            Mysqlconn.Close()

            Selectseat.Show()
            Me.Hide()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    
    Private Sub btnselect12pm_Click(sender As Object, e As EventArgs) Handles btnselect12pm.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim READER As MySqlDataReader

        Try


            Mysqlconn.Open()
            Dim Query As String
            Query = "Insert into osadd.ticket(masa,id) values ( '" & "00:00:00" & "','" & Buy.Label6.Text & "') on duplicate key update masa='" & lbl12pm.Text & "'"

            Command = New MySqlCommand(Query, Mysqlconn)
            READER = Command.ExecuteReader

            MessageBox.Show("Data is Saved")

            Mysqlconn.Close()

            Selectseat.Show()
            Me.Hide()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub btnselect3pm_Click(sender As Object, e As EventArgs) Handles btnselect3pm.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim READER As MySqlDataReader

        Try


            Mysqlconn.Open()
            Dim Query As String
            Query = "Insert into osadd.ticket(masa,id) values ( '" & "00:00:00" & "','" & Buy.Label6.Text & "') on duplicate key update masa='" & lbl3pm.Text & "'"

            Command = New MySqlCommand(Query, Mysqlconn)
            READER = Command.ExecuteReader

            MessageBox.Show("Data is Saved")

            Mysqlconn.Close()

            Selectseat.Show()
            Me.Hide()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mysqlconn = New MySqlConnection
        Mysqlconn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim READER As MySqlDataReader

        Try


            Mysqlconn.Open()
            Dim Query As String
            Query = "Delete  from osadd.ticket where id = '" & Buy.Label6.Text & "' and tarikh = '" & Buy.CbDate.Text & "'"

            Command = New MySqlCommand(Query, Mysqlconn)
            READER = Command.ExecuteReader

           
            Mysqlconn.Close()

            Buy.Show()
            Me.Hide()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub
End Class