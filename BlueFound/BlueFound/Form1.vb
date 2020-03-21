Public Class Schermata_di_Login

    'Funzione che permette di modificare l'intera finestra di LOGIN
    Private Sub interaFinestra(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Funzione che permette di modificare il pulsante di LOGIN 
    Private Sub accedi(sender As Object, e As EventArgs) Handles Login.Click
        If Username.Text = "Maicol" And Password.Text = "12345" Then
            Main_Page.Show()
            Me.Hide()
        Else
            Label4.Text = "Username o Password non corretti!"
            Label4.BackColor = Color.Red
        End If


    End Sub


End Class