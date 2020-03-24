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
            MsgBox("Username o Password non corretti!")

            'Label4.Text = "Username o Password non corretti!"
            'Label4.BackColor = Color.Red
        End If


    End Sub

    Private Sub LinkDiRegistrazione_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDiRegistrazione.LinkClicked
        Mail_BlueFound.Show()
        Me.Hide()

    End Sub


End Class