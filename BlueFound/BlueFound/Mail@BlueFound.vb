Imports System.Net.Mail

Public Class Mail_BlueFound
    Dim Mail As New MailMessage
    Dim Smtp As New SmtpClient("smtp.gmail.com")

    'funzione che mi permette di chiudere la finestra presente ed aprire la finestra di login
    Private Sub Chiudi_Click(sender As Object, e As EventArgs) Handles Chiudi.Click
        Me.Hide()
        Schermata_di_Login.Show()
    End Sub

    'Funzione che mi permette di definire, mittente, destinatario e oggetto di una mail
    Private Sub Invia_Click(sender As Object, e As EventArgs) Handles Invia.Click
        If oggetto.Text = "" Then
            If MessageBox.Show("La mail non ha un Oggetto" & vbNewLine & "Inviarla comunque?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            If miamail.Text.Contains("@") And Not miamail.Text.Contains(" ") And Not messaggio_di_posta.Text = "" Then

                Mail = New MailMessage
                Mail.From = New MailAddress(miamail.Text)
                Mail.To.Add("maicol.moretti11@gmail.com")
                Mail.Subject = oggetto.Text
                Mail.Body = messaggio_di_posta.Text
                Smtp.EnableSsl = True
                Smtp.Port = 25
                Smtp.Credentials = New Net.NetworkCredential("maicol.moretti@alice.it", "maik1996_96")
                Smtp.Send(Mail)
                MsgBox("La mail è stata inviata correttamente", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Impossibile inviare la mail!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    'Funzione utile per cancellare tutto
    Private Sub Resetta_Click(sender As Object, e As EventArgs) Handles Resetta.Click
        miamail.Clear()
        messaggio_di_posta.Clear()
        oggetto.Clear()
    End Sub


End Class