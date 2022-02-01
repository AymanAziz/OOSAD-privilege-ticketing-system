Imports MySql.Data.MySqlClient
Public Class signup
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd " 'nak guna database ygn ne'
        Dim reader As IDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into osadd.Passenger (Pass_Username,Pass_Password,Pass_Name,Pass_ICNum,Pass_age,Pass_address) values ('" & txtusername.Text & "','" & txtpass.Text & "','" & txtnama.Text & "','" & txtnumber.Text & "',' " & txtage.Text & " ','" & txtadress.Text & "') "
            command = New MySqlCommand(Query, conn)
            reader = command.ExecuteReader

            MessageBox.Show("Data is Saved")

            conn.Close()
            Me.Hide()
            Form1.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        Form1.Show()

    End Sub

End Class