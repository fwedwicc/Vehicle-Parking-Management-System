Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default state of password text to hidden
        Password.UseSystemPasswordChar = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Value += 1
        If ProgressBar.Value = ProgressBar.Maximum Then
            Timer1.Enabled = False
            Hide()
            MsgBox("Success! Welcome to Vehicle Parking Management System!")
            Form2.Show()
        End If
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        ' Toggle between showing and hiding the password text
        Password.UseSystemPasswordChar = Not ShowPassword.Checked
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If Username.Text = "ADMIN" And Password.Text = "admin" Then
            Timer1.Start()
        Else
            MsgBox("Your Input is Invalid! Try again.")
        End If
    End Sub
End Class
