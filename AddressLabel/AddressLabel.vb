Public Class AddressLabel


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        Me.DisplayLabel.Text = FirstNameTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub
End Class
