<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schermata_di_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkDiRegistrazione = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(280, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BlueFound"
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.Color.DodgerBlue
        Me.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.SystemColors.Control
        Me.Login.Location = New System.Drawing.Point(383, 348)
        Me.Login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 28)
        Me.Login.TabIndex = 1
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(311, 175)
        Me.Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(261, 22)
        Me.Username.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(311, 245)
        Me.Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(261, 22)
        Me.Password.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'LinkDiRegistrazione
        '
        Me.LinkDiRegistrazione.AutoSize = True
        Me.LinkDiRegistrazione.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkDiRegistrazione.Location = New System.Drawing.Point(263, 405)
        Me.LinkDiRegistrazione.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkDiRegistrazione.Name = "LinkDiRegistrazione"
        Me.LinkDiRegistrazione.Size = New System.Drawing.Size(363, 17)
        Me.LinkDiRegistrazione.TabIndex = 7
        Me.LinkDiRegistrazione.TabStop = True
        Me.LinkDiRegistrazione.Text = "Non hai un account registrato? Contatta l'amministratore"
        '
        'Schermata_di_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 554)
        Me.Controls.Add(Me.LinkDiRegistrazione)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Schermata_di_Login"
        Me.Text = "Login BlueFound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Login As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkDiRegistrazione As LinkLabel
End Class
