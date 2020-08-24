Public Class LoginStudent
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (TextBox1.Text = "") Then
            ErrorLabel.Visible = True
        Else
            username = TextBox1.Text
            'save student table with:
            'ID = uniqueid, 
            'username = TextBox1.Text, 
            'Compito = default compito of default prof with default exercises and panels
            Test.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        LoginAdmin.Show()
    End Sub
End Class