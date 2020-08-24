Public Class Test
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles Domanda1Button.Click, Domanda2Button.Click, Domanda3Button.Click, Domanda4Button.Click, Domanda5Button.Click
        Select Case CType(sender, System.Windows.Forms.Button).Name


            Case "Domanda1Button"
                Domanda1Button.BackColor = Color.FromArgb(0, 173, 181)
                Domanda2Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda3Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda4Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda5Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda1Panel.Visible = True
                Domanda2Panel.Visible = False
                Domanda3Panel.Visible = False
                Domanda4Panel.Visible = False
                Domanda5Panel.Visible = False

            Case "Domanda2Button"
                Domanda1Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda2Button.BackColor = Color.FromArgb(0, 173, 181)
                Domanda3Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda4Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda5Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda1Panel.Visible = False
                Domanda2Panel.Visible = True
                Domanda3Panel.Visible = False
                Domanda4Panel.Visible = False
                Domanda5Panel.Visible = False

            Case "Domanda3Button"
                Domanda1Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda2Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda3Button.BackColor = Color.FromArgb(0, 173, 181)
                Domanda4Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda5Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda1Panel.Visible = False
                Domanda2Panel.Visible = False
                Domanda3Panel.Visible = True
                Domanda4Panel.Visible = False
                Domanda5Panel.Visible = False

            Case "Domanda4Button"
                Domanda1Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda2Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda3Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda4Button.BackColor = Color.FromArgb(0, 173, 181)
                Domanda5Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda1Panel.Visible = False
                Domanda2Panel.Visible = False
                Domanda3Panel.Visible = False
                Domanda4Panel.Visible = True
                Domanda5Panel.Visible = False

            Case "Domanda5Button"
                Domanda1Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda2Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda3Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda4Button.BackColor = Color.FromArgb(57, 62, 70)
                Domanda5Button.BackColor = Color.FromArgb(0, 173, 181)
                Domanda1Panel.Visible = False
                Domanda2Panel.Visible = False
                Domanda3Panel.Visible = False
                Domanda4Panel.Visible = False
                Domanda5Panel.Visible = True

        End Select
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Domanda1Panel.Visible = True
        Domanda2Panel.Visible = False
        Domanda3Panel.Visible = False
        Domanda4Panel.Visible = False
        Domanda5Panel.Visible = False

        TimerLabel.Text = timeleft
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (timeleft > 0) Then
            timeleft -= 1
            TimerLabel.Text = timeleft

        Else
            salva_dati()
            FineTest.Show()
    Me.Close()
    End If
    End Sub
    Private Sub salva_dati()
        If RispDom1.Text = "1861" Then
            domanda01 = True
            risultato += 2
        Else domanda01 = False
        End If
        If Risp3Dom2Radio.Checked = True Then
            domanda02 = True
            risultato += 2
        Else domanda02 = False
        End If
        If Risp3Dom3Radio.Checked = True Then
            domanda03 = True
            risultato += 2
        Else domanda03 = False
        End If
        If RispDom4.Text = "Conte" Then
            domanda04 = True
            risultato += 2
        Else domanda04 = False
        End If
        If RispDom5.Text = "18" Then
            domanda05 = True
            risultato += 2
        Else domanda05 = False
        End If
        If System.IO.File.Exists(path_file) = True Then RichTextBox1.LoadFile(path_file)
        RichTextBox1.AppendText(username & " Punteggio " & risultato & " Tempo " & 120 - timeleft & "s." & vbNewLine)
        RichTextBox1.SaveFile(path_file)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False
        salva_dati()
        FineTest.Show()
        Me.Close()
    End Sub

End Class