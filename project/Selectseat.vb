Imports MySql.Data.MySqlClient
Public Class Selectseat
    Dim con As MySqlConnection
    Dim command As MySqlCommand


   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        If Button1.BackColor = Color.White Then
            Button1.BackColor = Color.Red
            numseat.Text = Button1.Text

        ElseIf Button1.BackColor = Color.Red Then
            Button1.BackColor = Color.White
            numseat.Text = String.Empty
        End If
        c()


    End Sub

    Private Sub Button1_VisibleChanged(sender As Object, e As EventArgs) Handles Button1.VisibleChanged
         con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button1.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While
            If count = 1 Then
                Button1.BackColor = Color.Red
                Button1.Enabled = False
            ElseIf count > 1 Then
            Else
                If Button1.BackColor = Color.White Then
                    Button1.BackColor = Color.Red
                    numseat.Text = Button1.Text
                End If
                If Button1.BackColor = Color.Red Then
                    Button1.BackColor = Color.White
                    numseat.Text = String.Empty
                End If
                End If
                con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try


    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.BackColor = Color.White Then
            Button9.BackColor = Color.Red
            numseat.Text = Button9.Text

        ElseIf Button9.BackColor = Color.Red Then
            Button9.BackColor = Color.White
            numseat.Text = String.Empty
        End If

    End Sub

    Private Sub Button9_VisibleChanged(sender As Object, e As EventArgs) Handles Button9.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button9.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader


            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button9.BackColor = Color.Red
                Button9.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button9.BackColor = Color.White Then
                    Button9.BackColor = Color.Red
                    numseat.Text = Button1.Text
                End If
                If Button9.BackColor = Color.Red Then
                    Button9.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Button28.BackColor = Color.White Then
            Button28.BackColor = Color.Red
            numseat.Text = Button28.Text

        ElseIf Button28.BackColor = Color.Red Then
            Button28.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    
    Private Sub Button28_VisibleChanged(sender As Object, e As EventArgs) Handles Button28.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button28.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button28.BackColor = Color.Red
                Button28.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button28.BackColor = Color.White Then
                    Button28.BackColor = Color.Red
                    numseat.Text = Button28.Text
                End If
                If Button28.BackColor = Color.Red Then
                    Button28.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.White Then
            Button2.BackColor = Color.Red
            numseat.Text = Button2.Text

        ElseIf Button2.BackColor = Color.Red Then
            Button2.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button2_VisibleChanged(sender As Object, e As EventArgs) Handles Button2.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button2.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button2.BackColor = Color.Red
                Button2.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button2.BackColor = Color.White Then
                    Button2.BackColor = Color.Red
                    numseat.Text = Button1.Text
                End If
                If Button2.BackColor = Color.Red Then
                    Button2.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.BackColor = Color.White Then
            Button10.BackColor = Color.Red
            numseat.Text = Button10.Text

        ElseIf Button10.BackColor = Color.Red Then
            Button10.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button10_Resize(sender As Object, e As EventArgs) Handles Button10.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and   seat  ='" & Button10.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button10.BackColor = Color.Red
                Button10.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button10.BackColor = Color.White Then
                    Button10.BackColor = Color.Red
                    numseat.Text = Button10.Text
                End If
                If Button10.BackColor = Color.Red Then
                    Button10.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub


    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If Button27.BackColor = Color.White Then
            Button27.BackColor = Color.Red
            numseat.Text = Button27.Text

        ElseIf Button27.BackColor = Color.Red Then
            Button27.BackColor = Color.White
            numseat.Text = String.Empty
        End If

    End Sub

    Private Sub Button27_VisibleChanged(sender As Object, e As EventArgs) Handles Button27.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button27.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button27.BackColor = Color.Red
                Button27.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button27.BackColor = Color.White Then
                    Button27.BackColor = Color.Red
                    numseat.Text = Button27.Text
                End If
                If Button27.BackColor = Color.Red Then
                    Button27.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Button22.BackColor = Color.White Then
            Button22.BackColor = Color.Red
            numseat.Text = Button22.Text

        ElseIf Button22.BackColor = Color.Red Then
            Button22.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button22_VisibleChanged(sender As Object, e As EventArgs) Handles Button22.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button22.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button22.BackColor = Color.Red
                Button22.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button22.BackColor = Color.White Then
                    Button22.BackColor = Color.Red
                    numseat.Text = Button27.Text
                End If
                If Button22.BackColor = Color.Red Then
                    Button22.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.BackColor = Color.White Then
            Button11.BackColor = Color.Red
            numseat.Text = Button11.Text

        ElseIf Button11.BackColor = Color.Red Then
            Button11.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button11_VisibleChanged(sender As Object, e As EventArgs) Handles Button11.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and   seat  ='" & Button11.Text & "'"

            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button11.BackColor = Color.Red
                Button11.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button11.BackColor = Color.White Then
                    Button11.BackColor = Color.Red
                    numseat.Text = Button11.Text
                End If
                If Button11.BackColor = Color.Red Then
                    Button11.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.White Then
            Button3.BackColor = Color.Red
            numseat.Text = Button3.Text

        ElseIf Button3.BackColor = Color.Red Then
            Button3.BackColor = Color.White

            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button3_VisibleChanged(sender As Object, e As EventArgs) Handles Button3.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button3.Text & "'"


            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button3.BackColor = Color.Red
                Button3.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button3.BackColor = Color.White Then
                    Button3.BackColor = Color.Red
                    numseat.Text = Button3.Text
                End If
                If Button3.BackColor = Color.Red Then
                    Button3.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Button23.BackColor = Color.White Then
            Button23.BackColor = Color.Red
            numseat.Text = Button23.Text

        ElseIf Button23.BackColor = Color.Red Then
            Button23.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button23_VisibleChanged(sender As Object, e As EventArgs) Handles Button23.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button23.Text & "'"


            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button23.BackColor = Color.Red
                Button23.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button23.BackColor = Color.White Then
                    Button23.BackColor = Color.Red
                    numseat.Text = Button23.Text
                End If
                If Button23.BackColor = Color.Red Then
                    Button23.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Button12.BackColor = Color.White Then

            Button12.BackColor = Color.Red
            numseat.Text = Button12.Text

        ElseIf Button12.BackColor = Color.Red Then
            Button12.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button12_VisibleChanged(sender As Object, e As EventArgs) Handles Button12.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button12.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button12.BackColor = Color.Red
                Button12.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button12.BackColor = Color.White Then
                    Button12.BackColor = Color.Red
                    numseat.Text = Button12.Text
                End If
                If Button12.BackColor = Color.Red Then
                    Button12.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.White Then

            Button4.BackColor = Color.Red
            numseat.Text = Button4.Text

        ElseIf Button4.BackColor = Color.Red Then
            Button4.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button4_VisibleChanged(sender As Object, e As EventArgs) Handles Button4.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button4.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button4.BackColor = Color.Red
                Button4.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button4.BackColor = Color.White Then

                    Button4.BackColor = Color.Red
                    numseat.Text = Button4.Text
                End If
                If Button4.BackColor = Color.Red Then
                    Button4.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

                End If
                con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If Button24.BackColor = Color.White Then

            Button24.BackColor = Color.Red
            numseat.Text = Button24.Text

        ElseIf Button24.BackColor = Color.Red Then
            Button24.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button24_VisibleChanged(sender As Object, e As EventArgs) Handles Button24.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button24.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button24.BackColor = Color.Red
                Button24.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button24.BackColor = Color.White Then

                    Button24.BackColor = Color.Red
                    numseat.Text = Button24.Text
                End If
                If Button24.BackColor = Color.Red Then
                    Button24.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Button13.BackColor = Color.White Then

            Button13.BackColor = Color.Red
            numseat.Text = Button13.Text

        ElseIf Button13.BackColor = Color.Red Then
            Button13.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button13_VisibleChanged(sender As Object, e As EventArgs) Handles Button13.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button13.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button13.BackColor = Color.Red
                Button13.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button13.BackColor = Color.White Then

                    Button13.BackColor = Color.Red
                    numseat.Text = Button13.Text
                End If
                If Button13.BackColor = Color.Red Then
                    Button13.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.White Then

            Button5.BackColor = Color.Red
            numseat.Text = Button5.Text

        ElseIf Button5.BackColor = Color.Red Then
            Button5.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button5_VisibleChanged(sender As Object, e As EventArgs) Handles Button5.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button5.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button5.BackColor = Color.Red
                Button5.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button5.BackColor = Color.White Then

                    Button5.BackColor = Color.Red
                    numseat.Text = Button5.Text
                End If
                If Button5.BackColor = Color.Red Then
                    Button5.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Button25.BackColor = Color.White Then

            Button25.BackColor = Color.Red
            numseat.Text = Button25.Text

        ElseIf Button25.BackColor = Color.Red Then
            Button25.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button25_VisibleChanged(sender As Object, e As EventArgs) Handles Button25.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button25.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button25.BackColor = Color.Red
                Button25.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button25.BackColor = Color.White Then

                    Button25.BackColor = Color.Red
                    numseat.Text = Button25.Text
                End If
                If Button25.BackColor = Color.Red Then
                    Button25.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Button14.BackColor = Color.White Then

            Button14.BackColor = Color.Red
            numseat.Text = Button14.Text

        ElseIf Button14.BackColor = Color.Red Then
            Button14.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button14_VisibleChanged(sender As Object, e As EventArgs) Handles Button14.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button14.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button14.BackColor = Color.Red
                Button14.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button14.BackColor = Color.White Then

                    Button14.BackColor = Color.Red
                    numseat.Text = Button14.Text
                End If
                If Button14.BackColor = Color.Red Then
                    Button14.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.White Then

            Button6.BackColor = Color.Red
            numseat.Text = Button6.Text

        ElseIf Button6.BackColor = Color.Red Then
            Button6.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button6_VisibleChanged(sender As Object, e As EventArgs) Handles Button6.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button6.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button6.BackColor = Color.Red
                Button6.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button6.BackColor = Color.White Then

                    Button6.BackColor = Color.Red
                    numseat.Text = Button6.Text
                End If
                If Button6.BackColor = Color.Red Then
                    Button6.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button16.BackColor = Color.White Then

            Button16.BackColor = Color.Red
            numseat.Text = Button16.Text

        ElseIf Button16.BackColor = Color.Red Then
            Button16.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button16_VisibleChanged(sender As Object, e As EventArgs) Handles Button16.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button16.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button16.BackColor = Color.Red
                Button16.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button16.BackColor = Color.White Then

                    Button16.BackColor = Color.Red
                    numseat.Text = Button16.Text
                End If
                If Button16.BackColor = Color.Red Then
                    Button16.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Button15.BackColor = Color.White Then

            Button15.BackColor = Color.Red
            numseat.Text = Button15.Text

        ElseIf Button15.BackColor = Color.Red Then
            Button15.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button15_VisibleChanged(sender As Object, e As EventArgs) Handles Button15.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button15.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button15.BackColor = Color.Red
                Button15.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button15.BackColor = Color.White Then

                    Button15.BackColor = Color.Red
                    numseat.Text = Button15.Text
                End If
                If Button15.BackColor = Color.Red Then
                    Button15.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.BackColor = Color.White Then

            Button7.BackColor = Color.Red
            numseat.Text = Button7.Text

        ElseIf Button7.BackColor = Color.Red Then
            Button7.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button7_VisibleChanged(sender As Object, e As EventArgs) Handles Button7.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button7.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button7.BackColor = Color.Red
                Button7.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button7.BackColor = Color.White Then

                    Button7.BackColor = Color.Red
                    numseat.Text = Button7.Text
                End If
                If Button7.BackColor = Color.Red Then
                    Button7.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Button18.BackColor = Color.White Then

            Button18.BackColor = Color.Red
            numseat.Text = Button18.Text

        ElseIf Button18.BackColor = Color.Red Then
            Button18.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button18_VisibleChanged(sender As Object, e As EventArgs) Handles Button18.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button18.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button18.BackColor = Color.Red
                Button18.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button18.BackColor = Color.White Then

                    Button18.BackColor = Color.Red
                    numseat.Text = Button18.Text
                End If
                If Button18.BackColor = Color.Red Then
                    Button18.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Button20.BackColor = Color.White Then

            Button20.BackColor = Color.Red
            numseat.Text = Button20.Text

        ElseIf Button20.BackColor = Color.Red Then
            Button20.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button20_VisibleChanged(sender As Object, e As EventArgs) Handles Button20.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button20.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button20.BackColor = Color.Red
                Button20.Enabled = False

            ElseIf count > 1 Then
            Else
                If Button20.BackColor = Color.White Then

                    Button20.BackColor = Color.Red
                    numseat.Text = Button20.Text
                End If
                If Button20.BackColor = Color.Red Then
                    Button20.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If Button21.BackColor = Color.White Then
            Button21.BackColor = Color.Red

            numseat.Text = Button21.Text

        ElseIf Button21.BackColor = Color.Red Then
            Button21.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button21_VisibleChanged(sender As Object, e As EventArgs) Handles Button21.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button21.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button21.BackColor = Color.Red
                Button21.Enabled = False


            ElseIf count > 1 Then
            Else
                If Button21.BackColor = Color.White Then

                    Button21.BackColor = Color.Red
                    numseat.Text = Button21.Text
                End If
                If Button21.BackColor = Color.Red Then
                    Button21.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.BackColor = Color.White Then
            Button8.BackColor = Color.Red

            numseat.Text = Button8.Text

        ElseIf Button8.BackColor = Color.Red Then
            Button8.BackColor = Color.White
            numseat.Text = String.Empty
        End If
    End Sub

    Private Sub Button8_VisibleChanged(sender As Object, e As EventArgs) Handles Button8.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd "
        Dim reader As MySqlDataReader
        Try

            con.Open()
            Dim Query As String
            Query = "select*from osadd.ticket where  nosiri  = '" & Buy.nosiri1.Text & "'and  seat  ='" & Button8.Text & "'"



            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader
            Dim count As Integer
            'wakilkan count sbagai integer'
            count = 0

            While reader.Read 'loop data dlm mysqlreader 
                count = count + 1
            End While

            If count = 1 Then

                Button8.BackColor = Color.Red
                Button8.Enabled = False


            ElseIf count > 1 Then
            Else
                If Button8.BackColor = Color.White Then

                    Button8.BackColor = Color.Red
                    numseat.Text = Button8.Text
                End If
                If Button8.BackColor = Color.Red Then
                    Button8.BackColor = Color.White
                    numseat.Text = String.Empty
                End If

            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btncomfirm_Click(sender As Object, e As EventArgs) Handles btncomfirm.Click
        con = New MySqlConnection
        con.ConnectionString = "server = localhost; userid= root; password=980329; database=osadd " 'nak guna database ygn ne'
        Dim reader As IDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "Insert into osadd.ticket(id,seat) values ('" & Buy.Label6.Text & "','" & numseat.Text & "') on duplicate key update seat='" & numseat.Text & "'"
            command = New MySqlCommand(Query, con)
            reader = command.ExecuteReader



            
           
            MessageBox.Show("Data is Saved")
            con.Close()
            Me.Hide()
            comfirm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    
    
    Private Sub lbldeparture_Click(sender As Object, e As EventArgs) Handles lbldeparture.VisibleChanged
        con = New MySqlConnection
        con.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            con.Open()
            Dim Query As String
            Query = "select* from osadd.ticket where  id = '" & Buy.Label6.Text & "' and nosiri  = '" & Buy.nosiri1.Text & "' "

            command = New MySqlCommand(Query, con)
            read = command.ExecuteReader
            While read.Read
                lbldeparture.Text = read.GetString("masa")

            End While
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()
        End Try

    End Sub
   
    
    

End Class