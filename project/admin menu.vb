Imports MySql.Data.MySqlClient
Public Class admin_menu
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub btnloadtblePassenger_Click(sender As Object, e As EventArgs) Handles btnloadtblePassenger.Click
        DataGridView1.ClearSelection()



        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "select * from osadd.Passenger"
            command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataset)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub btnloadtbleTicket_Click(sender As Object, e As EventArgs) Handles btnloadtbleTicket.Click
        DataGridView1.ClearSelection()


        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "select * from osadd.ticket"
            command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataset)
            bsource.DataSource = dbDataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbDataset)

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class