<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Page
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Page))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Esci = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.apri_word = New System.Windows.Forms.Button()
        Me.messaggio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.includi_la_data = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Forte", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(519, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 68)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BlueFound"
        '
        'Esci
        '
        Me.Esci.BackColor = System.Drawing.SystemColors.Window
        Me.Esci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Esci.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Esci.Location = New System.Drawing.Point(53, 70)
        Me.Esci.Margin = New System.Windows.Forms.Padding(4)
        Me.Esci.Name = "Esci"
        Me.Esci.Size = New System.Drawing.Size(100, 28)
        Me.Esci.TabIndex = 2
        Me.Esci.Text = "Esci"
        Me.Esci.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1130, 70)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 22)
        Me.DateTimePicker1.TabIndex = 3
        '
        'apri_word
        '
        Me.apri_word.Location = New System.Drawing.Point(445, 704)
        Me.apri_word.Margin = New System.Windows.Forms.Padding(4)
        Me.apri_word.Name = "apri_word"
        Me.apri_word.Size = New System.Drawing.Size(171, 36)
        Me.apri_word.TabIndex = 4
        Me.apri_word.Text = "Apri in Microsoft Word"
        Me.apri_word.UseVisualStyleBackColor = True
        '
        'messaggio
        '
        Me.messaggio.Location = New System.Drawing.Point(334, 392)
        Me.messaggio.Multiline = True
        Me.messaggio.Name = "messaggio"
        Me.messaggio.Size = New System.Drawing.Size(712, 260)
        Me.messaggio.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(331, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Scrivi qui il tuo testo"
        '
        'includi_la_data
        '
        Me.includi_la_data.AutoSize = True
        Me.includi_la_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.includi_la_data.Location = New System.Drawing.Point(537, 352)
        Me.includi_la_data.Name = "includi_la_data"
        Me.includi_la_data.Size = New System.Drawing.Size(134, 24)
        Me.includi_la_data.TabIndex = 7
        Me.includi_la_data.Text = "Includi la data"
        Me.includi_la_data.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(731, 704)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mostra Messaggio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1419, 838)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.includi_la_data)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.messaggio)
        Me.Controls.Add(Me.apri_word)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Esci)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main_Page"
        Me.Text = "Main_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Esci As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents apri_word As Button
    Friend WithEvents messaggio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents includi_la_data As CheckBox
    Friend WithEvents Button1 As Button
End Class
