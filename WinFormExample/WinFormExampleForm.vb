Public Class WinFormExampleForm
    Private Sub HelloButton_Click(sender As Object, e As EventArgs) Handles HelloButton.Click
        'MsgBox("Hello User.")
        'Me.Text = "Super Duper"
        HelloButton.Text = "Fish"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
