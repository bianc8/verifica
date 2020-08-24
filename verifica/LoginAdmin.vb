Public Class LoginAdmin
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If (TextBox1.Text = "") Then
            ErrorLabelUser.Visible = True
        ElseIf (TextBox2.Text = "") Then
            ErrorLabelPwd.Visible = True
        ElseIf (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
            'controllo se credenziali sono corrette in db'
            'save student table with:
            'ID = uniqueid, 
            'username = TextBox1.Text, 
            'Compito = default compito of default prof with default exercises and panels
            ErrorLabelPwd.Visible = False
            ErrorLabelUser.Visible = False
            AdminForm.Show()
            Me.Close()
        Else
            ErrorLabelPwd.Visible = True
            ErrorLabelUser.Visible = True
        End If
    End Sub
End Class