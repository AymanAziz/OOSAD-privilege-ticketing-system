Imports MySql.Data.MySqlClient
Public Class Buy
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim ab As Integer
    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim READER As MySqlDataReader
        Try
            Label6.Text = cbFrom.Text & Form1.txtUserName.Text & CbDate.Text


            Select Case cbFrom.Text
                Case "TBS"
                    Select Case cbTo.Text
                        Case "TBS"
                            MessageBox.Show("Please enter the correct value.", "Invalid Input", MessageBoxButtons.OK)

                        Case "LARKIN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1101" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1101" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1101" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1101" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()




                        Case "IPOH"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1102" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1102" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1102" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1102" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()

                        Case "KUANTAN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1103" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1103" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1103" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1103" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                    End Select

                Case "LARKIN"
                    Select Case cbTo.Text
                        Case "TBS"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1201" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1201" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1201" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1201" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()

                        Case "LARKIN"
                            MessageBox.Show("Please enter the correct value.", "Invalid Input", MessageBoxButtons.OK)

                        Case "IPOH"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1202" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1202" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1202" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1202" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()

                        Case "KUANTAN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1203" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1203" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1203" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1203" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                    End Select

                Case "IPOH"
                    Select Case cbTo.Text
                        Case "TBS"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1301" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1301" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1301" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1301" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()

                        Case "LARKIN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1302" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1302" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1302" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1302" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                        Case "IPOH"
                            MessageBox.Show("Please enter the correct value.", "Invalid Input", MessageBoxButtons.OK)

                        Case "KUANTAN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1303" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1303" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1303" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1303" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                    End Select

                Case "KUANTAN"
                    Select Case cbTo.Text
                        Case "TBS"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1401" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1401" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1401" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1401" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                        Case "LARKIN"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1402" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1402" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1402" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1402" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                        Case "IPOH"
                            conn.Open()
                            Dim Query As String
                            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "
                            command = New MySqlCommand(Query, conn)
                            READER = command.ExecuteReader
                            While READER.Read
                                ab = READER.GetString("Pass_age")
                            End While
                            If ab < "19" Then
                                conn.Close()
                                conn.Open()

                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "19" & "','" & Label6.Text & "','" & "1403" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1403" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            Else
                                conn.Close()
                                conn.Open()
                                Query = "Insert into osadd.ticket(dari,kepada,tarikh,masa,price,id,nosiri) values ( '" & cbFrom.Text & "','" & cbTo.Text & "','" & CbDate.Text & "','" & "00:00:00" & "','" & "27" & "','" & Label6.Text & "','" & "1403" & "')"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                conn.Close()
                                conn.Open()
                                Query = "select * from osadd.ticket where nosiri ='" & "1403" & "'"
                                command = New MySqlCommand(Query, conn)
                                READER = command.ExecuteReader
                                While READER.Read
                                    nosiri1.Text = READER.GetInt32("nosiri")
                                End While
                                conn.Close()
                                Form2.Show()
                                Me.Hide()
                            End If
                            conn.Close()
                        Case "KUANTAN"
                            MessageBox.Show("Please enter the correct value.", "Invalid Input", MessageBoxButtons.OK)
                    End Select
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

   
    
    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.VisibleChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server = localhost;userid=root;password=980329;database=osadd"
        Dim read As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from osadd.Passenger where Pass_Username ='" & Form1.txtUserName.Text & "' "

            command = New MySqlCommand(Query, conn)
            read = command.ExecuteReader
            While read.Read
                txtName.Text = read.GetString("Pass_Name")

            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()
        End Try

    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        tutorialBuy.Show()

    End Sub
End Class