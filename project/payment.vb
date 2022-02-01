Public Class payment
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer

        If (Integer.TryParse(TextBox1.Text, a)) Then
            MessageBox.Show("Payment is successful")
            Me.Hide()
            print.Show()

        Else
            MessageBox.Show("this is not card number")
        End If


    End Sub
End Class