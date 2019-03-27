<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recibo1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recibo1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncriar = New System.Windows.Forms.Button()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.CaminhoTxtbox = New System.Windows.Forms.TextBox()
        Me.fbd1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ClienteTxtbox = New System.Windows.Forms.TextBox()
        Me.Quantiatxtbox = New System.Windows.Forms.TextBox()
        Me.CorrespondenTxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 400)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Informações do arquivo:"
        '
        'btncriar
        '
        Me.btncriar.Location = New System.Drawing.Point(12, 466)
        Me.btncriar.Name = "btncriar"
        Me.btncriar.Size = New System.Drawing.Size(673, 23)
        Me.btncriar.TabIndex = 6
        Me.btncriar.Text = "Gerar PDF"
        Me.btncriar.UseVisualStyleBackColor = True
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(259, 440)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(75, 23)
        Me.browseButton.TabIndex = 7
        Me.browseButton.Text = "Procurar"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'CaminhoTxtbox
        '
        Me.CaminhoTxtbox.Location = New System.Drawing.Point(69, 442)
        Me.CaminhoTxtbox.Name = "CaminhoTxtbox"
        Me.CaminhoTxtbox.Size = New System.Drawing.Size(185, 20)
        Me.CaminhoTxtbox.TabIndex = 8
        '
        'fbd1
        '
        Me.fbd1.SelectedPath = "Desktop"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 416)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(230, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Recibo.pdf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nome do arquivo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Caminho:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 138)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(670, 246)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'ClienteTxtbox
        '
        Me.ClienteTxtbox.Location = New System.Drawing.Point(69, 60)
        Me.ClienteTxtbox.Name = "ClienteTxtbox"
        Me.ClienteTxtbox.Size = New System.Drawing.Size(364, 20)
        Me.ClienteTxtbox.TabIndex = 13
        '
        'Quantiatxtbox
        '
        Me.Quantiatxtbox.Location = New System.Drawing.Point(77, 86)
        Me.Quantiatxtbox.Name = "Quantiatxtbox"
        Me.Quantiatxtbox.Size = New System.Drawing.Size(356, 20)
        Me.Quantiatxtbox.TabIndex = 14
        '
        'CorrespondenTxtbox
        '
        Me.CorrespondenTxtbox.Location = New System.Drawing.Point(121, 112)
        Me.CorrespondenTxtbox.Name = "CorrespondenTxtbox"
        Me.CorrespondenTxtbox.Size = New System.Drawing.Size(312, 20)
        Me.CorrespondenTxtbox.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Quantia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Correspondente a:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Gerador de Recibos V1.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(462, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(342, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Obrigatorio (Não remova o .pdf)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Obrigatorio"
        '
        'recibo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(697, 501)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CorrespondenTxtbox)
        Me.Controls.Add(Me.Quantiatxtbox)
        Me.Controls.Add(Me.ClienteTxtbox)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CaminhoTxtbox)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.btncriar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "recibo1"
        Me.Text = "Gerador de Recibos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btncriar As Button
    Friend WithEvents browseButton As Button
    Friend WithEvents CaminhoTxtbox As TextBox
    Friend WithEvents fbd1 As FolderBrowserDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ClienteTxtbox As TextBox
    Friend WithEvents Quantiatxtbox As TextBox
    Friend WithEvents CorrespondenTxtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
