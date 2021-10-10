'Elliot Heiner
'RCET 0265
'Fall 2021
'Address Label Program
'https://github.com/heinelli/AddressLabel.git

Option Strict On
Option Explicit On
Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Concatenate all input textboxes when the user clicks DisplayLabelButton.
    Private Sub DisplayLabelButton_Click(sender As Object, e As EventArgs) Handles DisplayLabelButton.Click
        Me.DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine &
        StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text & vbNewLine &
        ZipTextBox.Text
    End Sub

    'Reset all textboxes by setting the value equal to an empty string.
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
