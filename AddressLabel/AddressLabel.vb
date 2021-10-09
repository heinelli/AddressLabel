Public Class AddressLabel


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        Me.DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine &
        StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text & vbNewLine &
        ZipTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub
End Class
