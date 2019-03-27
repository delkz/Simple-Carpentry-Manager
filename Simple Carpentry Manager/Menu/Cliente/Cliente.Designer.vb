<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Celular1Label As System.Windows.Forms.Label
        Dim Celular2Label As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.ClienteTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ClienteTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteTabelaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TelefoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Celular1TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Celular2TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        Celular1Label = New System.Windows.Forms.Label()
        Celular2Label = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        CType(Me.ClienteTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteTabelaBindingNavigator.SuspendLayout()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(12, 103)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(42, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome*:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 129)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(12, 155)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 7
        EnderecoLabel.Text = "Endereço:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(12, 185)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 9
        TelefoneLabel.Text = "Telefone:"
        '
        'Celular1Label
        '
        Celular1Label.AutoSize = True
        Celular1Label.Location = New System.Drawing.Point(12, 215)
        Celular1Label.Name = "Celular1Label"
        Celular1Label.Size = New System.Drawing.Size(42, 13)
        Celular1Label.TabIndex = 11
        Celular1Label.Text = "Celular:"
        '
        'Celular2Label
        '
        Celular2Label.AutoSize = True
        Celular2Label.Location = New System.Drawing.Point(12, 246)
        Celular2Label.Name = "Celular2Label"
        Celular2Label.Size = New System.Drawing.Size(27, 13)
        Celular2Label.TabIndex = 13
        Celular2Label.Text = "CPF"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(12, 273)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 26
        ObservacoesLabel.Text = "Observaçoes:"
        '
        'ClienteTabelaBindingNavigator
        '
        Me.ClienteTabelaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteTabelaBindingNavigator.BindingSource = Me.ClienteTabelaBindingSource
        Me.ClienteTabelaBindingNavigator.CountItem = Nothing
        Me.ClienteTabelaBindingNavigator.DeleteItem = Nothing
        Me.ClienteTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.ClienteTabelaBindingNavigatorSaveItem})
        Me.ClienteTabelaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteTabelaBindingNavigator.MoveFirstItem = Nothing
        Me.ClienteTabelaBindingNavigator.MoveLastItem = Nothing
        Me.ClienteTabelaBindingNavigator.MoveNextItem = Nothing
        Me.ClienteTabelaBindingNavigator.MovePreviousItem = Nothing
        Me.ClienteTabelaBindingNavigator.Name = "ClienteTabelaBindingNavigator"
        Me.ClienteTabelaBindingNavigator.PositionItem = Nothing
        Me.ClienteTabelaBindingNavigator.Size = New System.Drawing.Size(570, 25)
        Me.ClienteTabelaBindingNavigator.TabIndex = 0
        Me.ClienteTabelaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(108, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'ClienteTabelaBindingSource
        '
        Me.ClienteTabelaBindingSource.DataMember = "ClienteTabela"
        Me.ClienteTabelaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ClienteTabelaBindingNavigatorSaveItem
        '
        Me.ClienteTabelaBindingNavigatorSaveItem.Enabled = False
        Me.ClienteTabelaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteTabelaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteTabelaBindingNavigatorSaveItem.Name = "ClienteTabelaBindingNavigatorSaveItem"
        Me.ClienteTabelaBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 22)
        Me.ClienteTabelaBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(74, 98)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(484, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(74, 150)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(484, 20)
        Me.EnderecoTextBox.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "*Campos Obrigatorios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(407, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(74, 182)
        Me.TelefoneTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(484, 20)
        Me.TelefoneTextBox.TabIndex = 24
        '
        'Celular1TextBox
        '
        Me.Celular1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular1", True))
        Me.Celular1TextBox.Location = New System.Drawing.Point(74, 212)
        Me.Celular1TextBox.Mask = "(00) 00000-0000"
        Me.Celular1TextBox.Name = "Celular1TextBox"
        Me.Celular1TextBox.Size = New System.Drawing.Size(485, 20)
        Me.Celular1TextBox.TabIndex = 25
        '
        'Celular2TextBox
        '
        Me.Celular2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular2", True))
        Me.Celular2TextBox.Location = New System.Drawing.Point(74, 243)
        Me.Celular2TextBox.Name = "Celular2TextBox"
        Me.Celular2TextBox.Size = New System.Drawing.Size(484, 20)
        Me.Celular2TextBox.TabIndex = 26
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(74, 124)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(484, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(91, 270)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(467, 163)
        Me.ObservacoesTextBox.TabIndex = 27
        '
        'ClienteTabelaTableAdapter
        '
        Me.ClienteTabelaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Me.ClienteTabelaTableAdapter
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 485)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(Me.Celular2TextBox)
        Me.Controls.Add(Me.Celular1TextBox)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Celular1Label)
        Me.Controls.Add(Celular2Label)
        Me.Controls.Add(Me.ClienteTabelaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cliente"
        Me.Text = "Novo Cliente"
        CType(Me.ClienteTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteTabelaBindingNavigator.ResumeLayout(False)
        Me.ClienteTabelaBindingNavigator.PerformLayout()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents ClienteTabelaBindingSource As BindingSource
    Friend WithEvents ClienteTabelaTableAdapter As MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTabelaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ClienteTabelaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular1TextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular2TextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
