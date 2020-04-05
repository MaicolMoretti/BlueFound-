<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail_BlueFound
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mia_mail = New System.Windows.Forms.Label()
        Me.miamail = New System.Windows.Forms.TextBox()
        Me.mail_to = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.oggetto = New System.Windows.Forms.TextBox()
        Me.label_3 = New System.Windows.Forms.Label()
        Me.Invia = New System.Windows.Forms.Button()
        Me.Resetta = New System.Windows.Forms.Button()
        Me.Chiudi = New System.Windows.Forms.Button()
        Me.messaggio_di_posta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'mia_mail
        '
        Me.mia_mail.AutoSize = True
        Me.mia_mail.Location = New System.Drawing.Point(51, 87)
        Me.mia_mail.Name = "mia_mail"
        Me.mia_mail.Size = New System.Drawing.Size(169, 13)
        Me.mia_mail.TabIndex = 0
        Me.mia_mail.Text = "Mia email: esempio@esempio.com"
        '
        'miamail
        '
        Me.miamail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.miamail.Location = New System.Drawing.Point(54, 103)
        Me.miamail.Name = "miamail"
        Me.miamail.Size = New System.Drawing.Size(473, 20)
        Me.miamail.TabIndex = 1
        '
        'mail_to
        '
        Me.mail_to.AutoSize = True
        Me.mail_to.Location = New System.Drawing.Point(51, 47)
        Me.mail_to.Name = "mail_to"
        Me.mail_to.Size = New System.Drawing.Size(180, 13)
        Me.mail_to.TabIndex = 2
        Me.mail_to.Text = "email a: maicol.moretti11@gmail.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Oggetto"
        '
        'oggetto
        '
        Me.oggetto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.oggetto.Location = New System.Drawing.Point(54, 178)
        Me.oggetto.Name = "oggetto"
        Me.oggetto.Size = New System.Drawing.Size(473, 20)
        Me.oggetto.TabIndex = 4
        '
        'label_3
        '
        Me.label_3.AutoSize = True
        Me.label_3.Location = New System.Drawing.Point(51, 229)
        Me.label_3.Name = "label_3"
        Me.label_3.Size = New System.Drawing.Size(61, 13)
        Me.label_3.TabIndex = 5
        Me.label_3.Text = "Messaggio:"
        '
        'Invia
        '
        Me.Invia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Invia.Location = New System.Drawing.Point(54, 464)
        Me.Invia.Name = "Invia"
        Me.Invia.Size = New System.Drawing.Size(75, 23)
        Me.Invia.TabIndex = 7
        Me.Invia.Text = "Invia"
        Me.Invia.UseVisualStyleBackColor = True
        '
        'Resetta
        '
        Me.Resetta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Resetta.Location = New System.Drawing.Point(145, 464)
        Me.Resetta.Name = "Resetta"
        Me.Resetta.Size = New System.Drawing.Size(75, 23)
        Me.Resetta.TabIndex = 8
        Me.Resetta.Text = "Resetta"
        Me.Resetta.UseVisualStyleBackColor = True
        '
        'Chiudi
        '
        Me.Chiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Chiudi.Location = New System.Drawing.Point(237, 464)
        Me.Chiudi.Name = "Chiudi"
        Me.Chiudi.Size = New System.Drawing.Size(75, 23)
        Me.Chiudi.TabIndex = 9
        Me.Chiudi.Text = "Chiudi"
        Me.Chiudi.UseVisualStyleBackColor = True
        '
        'messaggio_di_posta
        '
        Me.messaggio_di_posta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.messaggio_di_posta.Location = New System.Drawing.Point(54, 259)
        Me.messaggio_di_posta.Multiline = True
        Me.messaggio_di_posta.Name = "messaggio_di_posta"
        Me.messaggio_di_posta.Size = New System.Drawing.Size(473, 158)
        Me.messaggio_di_posta.TabIndex = 10
        '
        'Mail_BlueFound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 526)
        Me.Controls.Add(Me.messaggio_di_posta)
        Me.Controls.Add(Me.Chiudi)
        Me.Controls.Add(Me.Resetta)
        Me.Controls.Add(Me.Invia)
        Me.Controls.Add(Me.label_3)
        Me.Controls.Add(Me.oggetto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mail_to)
        Me.Controls.Add(Me.miamail)
        Me.Controls.Add(Me.mia_mail)
        Me.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Name = "Mail_BlueFound"
        Me.Text = "Mail_BlueFound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mia_mail As Label
    Friend WithEvents miamail As TextBox
    Friend WithEvents mail_to As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents oggetto As TextBox
    Friend WithEvents label_3 As Label
    Friend WithEvents Invia As Button
    Friend WithEvents Resetta As Button
    Friend WithEvents Chiudi As Button
    Friend WithEvents messaggio_di_posta As TextBox
End Class
