'importo la libreria che mi serve per lavorare con Word
Imports videoscrittura = Microsoft.Office.Interop.Word


Public Class Main_Page

    'Funzione che mi permette di uscire dal mio programma

    Private Sub Esci_Click(sender As Object, e As EventArgs) Handles Esci.Click
        Me.Hide()
        Schermata_di_Login.Show()
    End Sub


    'Creo una unzione per l'apertura di un nuovo file Microdoft Word
    Private Sub apri_word_Click(sender As Object, e As EventArgs) Handles apri_word.Click
        Dim programma As videoscrittura.Application
        Dim documento As videoscrittura.Document
        programma = CreateObject("Word.Application")
        programma.Visible = True
        programma.Documents.Add()
        documento = programma.Documents.Add

        documento.Range.Text = messaggio.Text

    End Sub

    'Questa funzione mi serve per vedere se il programma riesce a leggere la stringa che scrivo nel "messaggio" 
    ' --> fa comparire un "Avvertimento" che contiene la stringa inserita
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mioMessaggio As String = messaggio.Text
        MessageBox.Show(messaggio.Text)
    End Sub
End Class