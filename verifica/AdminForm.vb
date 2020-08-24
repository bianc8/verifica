Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(path_file) = True Then
            RichTextBox1.LoadFile(path_file)
        Else
            RichTextBox1.BackColor = Color.Red
            Label3.Text = "File RTF NON TROVATO"
            RichTextBox1.Text = ""
        End If
    End Sub
End Class