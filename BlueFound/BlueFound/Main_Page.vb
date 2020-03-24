Imports Microsoft.Office.Interop

Public Class Main_Page

    'Funzione che mi permette di uscire dal mio programma
    '*
    '*
    'inserire una funzione di controllo con MsgBox per la conferma
    Private Sub Esci_Click(sender As Object, e As EventArgs) Handles Esci.Click
        Me.Hide()
        Schermata_di_Login.Show()
    End Sub

    Private Sub apri_word_Click(sender As Object, e As EventArgs) Handles apri_word.Click
        Dim variabileWord As Word.Application
        variabileWord = CreateObject("WORD.APPLICATION")
        variabileWord.Visible = True
        variabileWord.Documents.Add()
        variabileWord.Selection.PasteSpecial(Link:=2)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mioMessaggio As String = messaggio.Text
        MessageBox.Show(messaggio.Text)
    End Sub
End Class