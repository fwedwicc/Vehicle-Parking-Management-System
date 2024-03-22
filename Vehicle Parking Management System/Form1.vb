Public Class Form1
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If Username.Text = "ADMIN" And Password.Text = "admin" Then
            Timer1.Start()
        Else
            MsgBox("Your Input is Invalid! Try again.")
        End If
    End Sub
    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 1
        If ProgressBar.Value = ProgressBar.Maximum Then
            Timer1.Enabled = False
            Hide()
            MsgBox("Success! Welcome to Vehicle Parking Management System!")
            ' Form2.Show()
        End If
    End Sub
End Class
