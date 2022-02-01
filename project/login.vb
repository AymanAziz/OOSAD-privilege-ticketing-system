Imports MySql.Data.MySqlClient
Public Class Form1
    Dim Mysqlconn As MySqlConnection
    Dim commad As MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "1234" Then
            Me.Hide()
            admin_menu.Show()
        Else
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd " 'nak guna database ygn ne'
            Dim reader As IDataReader  'wakil utk baca data
            Try
                Mysqlconn.Open()  'on mysql connection
                Dim Query As String 'wakilkan query as string 
                Query = "select*from osadd.Passenger where Pass_Username ='" & txtUserName.Text & "' and Pass_Password ='" & txtPassword.Text & "'"

                commad = New MySqlCommand(Query, Mysqlconn)
                reader = commad.ExecuteReader
                Dim count As Integer
                'wakilkan count sbagai integer'
                count = 0

                While reader.Read 'loop data dlm mysqlreader 
                    count = count + 1
                End While

                If count = 1 Then
                    MessageBox.Show("Username and Password are correct")
                    Me.Hide()
                    Buy.Show()

                ElseIf count > 1 Then
                    MessageBox.Show("Username and Password are Duplicate")
                Else
                    MessageBox.Show("Username and Password are not correct")
                End If

                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                Mysqlconn.Dispose()

            End Try
        End If


    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Me.Hide()
        signup.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

End Class
