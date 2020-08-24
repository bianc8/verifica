Public Class FineTest
    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles RedoButton.Click
        timeleft = 120
        username = ""
        domanda01 = False
        domanda02 = False
        domanda03 = False
        domanda04 = False
        domanda05 = False
        risultato = 0
        Test.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        timeleft = 120
        username = ""
        domanda01 = False
        domanda02 = False
        domanda03 = False
        domanda04 = False
        domanda05 = False
        risultato = 0
        LoginStudent.Show()
        Me.Close()
    End Sub

    Private Sub AdminButton_Click_1(sender As Object, e As EventArgs) Handles AdminButton.Click
        LoginAdmin.Show()
    End Sub

    Private Sub FineTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If domanda01 Then
            Dom1Label.Text = "Corretta"
            Dom1Label.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Dom1Label.Text = "Errata"
            Dom1Label.ForeColor = Color.FromArgb(255, 0, 0)
        End If
        If domanda02 Then
            Dom2Label.Text = "Corretta"
            Dom2Label.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Dom2Label.Text = "Errata"
            Dom2Label.ForeColor = Color.FromArgb(255, 0, 0)
        End If
        If domanda03 Then
            Dom3Label.Text = "Corretta"
            Dom3Label.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Dom3Label.Text = "Errata"
            Dom3Label.ForeColor = Color.FromArgb(255, 0, 0)
        End If
        If domanda04 Then
            Dom4Label.Text = "Corretta"
            Dom4Label.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Dom4Label.Text = "Errata"
            Dom4Label.ForeColor = Color.FromArgb(255, 0, 0)
        End If
        If domanda05 Then
            Dom5Label.Text = "Corretta"
            Dom5Label.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            Dom5Label.Text = "Errata"
            Dom5Label.ForeColor = Color.FromArgb(255, 0, 0)
        End If
        TotLabel.Text = risultato & "/10 pt."
        StudenteLabel.Text = username
        TimeLabel.Text = 120 - timeleft & "s."
        If risultato > 5 Then
            TotLabel.ForeColor = Color.FromArgb(0, 255, 0)
        Else
            TotLabel.ForeColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub

End Class