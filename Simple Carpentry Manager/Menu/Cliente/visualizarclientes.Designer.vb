<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visualizarclientes
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
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Celular1Label As System.Windows.Forms.Label
        Dim Celular2Label As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(visualizarclientes))
        Me.ClienteTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ClienteTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.Celular1TextBox = New System.Windows.Forms.TextBox()
        Me.Celular2TextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.FillBycodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CódigoToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CódigoToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBycodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBynomesToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NomeToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBynomesToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.FillByTodosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByTodosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        CódigoLabel = New System.Windows.Forms.Label()
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
        Me.FillBycodigoToolStrip.SuspendLayout()
        Me.FillBynomesToolStrip1.SuspendLayout()
        Me.FillByTodosToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(12, 91)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(43, 13)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(12, 117)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 143)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(12, 169)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 7
        EnderecoLabel.Text = "Endereço:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(12, 195)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 9
        TelefoneLabel.Text = "Telefone:"
        '
        'Celular1Label
        '
        Celular1Label.AutoSize = True
        Celular1Label.Location = New System.Drawing.Point(12, 221)
        Celular1Label.Name = "Celular1Label"
        Celular1Label.Size = New System.Drawing.Size(42, 13)
        Celular1Label.TabIndex = 11
        Celular1Label.Text = "Celular:"
        '
        'Celular2Label
        '
        Celular2Label.AutoSize = True
        Celular2Label.Location = New System.Drawing.Point(12, 247)
        Celular2Label.Name = "Celular2Label"
        Celular2Label.Size = New System.Drawing.Size(30, 13)
        Celular2Label.TabIndex = 13
        Celular2Label.Text = "CPF:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(15, 273)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 22
        ObservacoesLabel.Text = "Observaçoes:"
        '
        'ClienteTabelaBindingNavigator
        '
        Me.ClienteTabelaBindingNavigator.AddNewItem = Nothing
        Me.ClienteTabelaBindingNavigator.BindingSource = Me.ClienteTabelaBindingSource
        Me.ClienteTabelaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteTabelaBindingNavigator.DeleteItem = Nothing
        Me.ClienteTabelaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClienteTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ImprimirToolStripButton, Me.toolStripSeparator})
        Me.ClienteTabelaBindingNavigator.Location = New System.Drawing.Point(0, 465)
        Me.ClienteTabelaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteTabelaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteTabelaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteTabelaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteTabelaBindingNavigator.Name = "ClienteTabelaBindingNavigator"
        Me.ClienteTabelaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteTabelaBindingNavigator.Size = New System.Drawing.Size(472, 25)
        Me.ClienteTabelaBindingNavigator.TabIndex = 0
        Me.ClienteTabelaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.BackColor = System.Drawing.Color.White
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Código", True))
        Me.CódigoTextBox.Location = New System.Drawing.Point(82, 88)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.ReadOnly = True
        Me.CódigoTextBox.Size = New System.Drawing.Size(354, 20)
        Me.CódigoTextBox.TabIndex = 1
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.White
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(82, 114)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(354, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.White
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(82, 140)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(354, 20)
        Me.EmailTextBox.TabIndex = 3
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.BackColor = System.Drawing.Color.White
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(82, 166)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.ReadOnly = True
        Me.EnderecoTextBox.Size = New System.Drawing.Size(354, 20)
        Me.EnderecoTextBox.TabIndex = 4
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.BackColor = System.Drawing.Color.White
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(82, 192)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.ReadOnly = True
        Me.TelefoneTextBox.Size = New System.Drawing.Size(354, 20)
        Me.TelefoneTextBox.TabIndex = 6
        '
        'Celular1TextBox
        '
        Me.Celular1TextBox.BackColor = System.Drawing.Color.White
        Me.Celular1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular1", True))
        Me.Celular1TextBox.Location = New System.Drawing.Point(82, 218)
        Me.Celular1TextBox.Name = "Celular1TextBox"
        Me.Celular1TextBox.ReadOnly = True
        Me.Celular1TextBox.Size = New System.Drawing.Size(354, 20)
        Me.Celular1TextBox.TabIndex = 7
        '
        'Celular2TextBox
        '
        Me.Celular2TextBox.BackColor = System.Drawing.Color.White
        Me.Celular2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular2", True))
        Me.Celular2TextBox.Location = New System.Drawing.Point(82, 244)
        Me.Celular2TextBox.Name = "Celular2TextBox"
        Me.Celular2TextBox.ReadOnly = True
        Me.Celular2TextBox.Size = New System.Drawing.Size(354, 20)
        Me.Celular2TextBox.TabIndex = 8
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
        'FillBycodigoToolStrip
        '
        Me.FillBycodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigoToolStripLabel1, Me.CódigoToolStripTextBox1, Me.FillBycodigoToolStripButton})
        Me.FillBycodigoToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBycodigoToolStrip.Name = "FillBycodigoToolStrip"
        Me.FillBycodigoToolStrip.Size = New System.Drawing.Size(472, 25)
        Me.FillBycodigoToolStrip.TabIndex = 19
        Me.FillBycodigoToolStrip.Text = "FillBycodigoToolStrip"
        '
        'CódigoToolStripLabel1
        '
        Me.CódigoToolStripLabel1.Name = "CódigoToolStripLabel1"
        Me.CódigoToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.CódigoToolStripLabel1.Text = "Código:"
        '
        'CódigoToolStripTextBox1
        '
        Me.CódigoToolStripTextBox1.Name = "CódigoToolStripTextBox1"
        Me.CódigoToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillBycodigoToolStripButton
        '
        Me.FillBycodigoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBycodigoToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillBycodigoToolStripButton.Name = "FillBycodigoToolStripButton"
        Me.FillBycodigoToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillBycodigoToolStripButton.Text = "Filtrar"
        '
        'FillBynomesToolStrip1
        '
        Me.FillBynomesToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel1, Me.NomeToolStripTextBox1, Me.FillBynomesToolStripButton1})
        Me.FillBynomesToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.FillBynomesToolStrip1.Name = "FillBynomesToolStrip1"
        Me.FillBynomesToolStrip1.Size = New System.Drawing.Size(472, 25)
        Me.FillBynomesToolStrip1.TabIndex = 20
        Me.FillBynomesToolStrip1.Text = "FillBynomesToolStrip1"
        '
        'NomeToolStripLabel1
        '
        Me.NomeToolStripLabel1.Name = "NomeToolStripLabel1"
        Me.NomeToolStripLabel1.Size = New System.Drawing.Size(43, 22)
        Me.NomeToolStripLabel1.Text = "Nome:"
        '
        'NomeToolStripTextBox1
        '
        Me.NomeToolStripTextBox1.Name = "NomeToolStripTextBox1"
        Me.NomeToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillBynomesToolStripButton1
        '
        Me.FillBynomesToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBynomesToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillBynomesToolStripButton1.Name = "FillBynomesToolStripButton1"
        Me.FillBynomesToolStripButton1.Size = New System.Drawing.Size(42, 22)
        Me.FillBynomesToolStripButton1.Text = "Filtrar"
        '
        'FillByTodosToolStrip
        '
        Me.FillByTodosToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FillByTodosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByTodosToolStripButton})
        Me.FillByTodosToolStrip.Location = New System.Drawing.Point(0, 440)
        Me.FillByTodosToolStrip.Name = "FillByTodosToolStrip"
        Me.FillByTodosToolStrip.Size = New System.Drawing.Size(472, 25)
        Me.FillByTodosToolStrip.TabIndex = 21
        Me.FillByTodosToolStrip.Text = "FillByTodosToolStrip"
        '
        'FillByTodosToolStripButton
        '
        Me.FillByTodosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByTodosToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByTodosToolStripButton.Name = "FillByTodosToolStripButton"
        Me.FillByTodosToolStripButton.Size = New System.Drawing.Size(82, 22)
        Me.FillByTodosToolStripButton.Text = "Mostrar todos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(309, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(113, 270)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(323, 149)
        Me.ObservacoesTextBox.TabIndex = 23
        '
        'visualizarclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 490)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillByTodosToolStrip)
        Me.Controls.Add(Me.FillBynomesToolStrip1)
        Me.Controls.Add(Me.FillBycodigoToolStrip)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(Celular1Label)
        Me.Controls.Add(Me.Celular1TextBox)
        Me.Controls.Add(Celular2Label)
        Me.Controls.Add(Me.Celular2TextBox)
        Me.Controls.Add(Me.ClienteTabelaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "visualizarclientes"
        Me.Text = "Visualizar Cliente"
        CType(Me.ClienteTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteTabelaBindingNavigator.ResumeLayout(False)
        Me.ClienteTabelaBindingNavigator.PerformLayout()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBycodigoToolStrip.ResumeLayout(False)
        Me.FillBycodigoToolStrip.PerformLayout()
        Me.FillBynomesToolStrip1.ResumeLayout(False)
        Me.FillBynomesToolStrip1.PerformLayout()
        Me.FillByTodosToolStrip.ResumeLayout(False)
        Me.FillByTodosToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents ClienteTabelaBindingSource As BindingSource
    Friend WithEvents ClienteTabelaTableAdapter As MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTabelaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents TelefoneTextBox As TextBox
    Friend WithEvents Celular1TextBox As TextBox
    Friend WithEvents Celular2TextBox As TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents FillBycodigoToolStrip As ToolStrip
    Friend WithEvents CódigoToolStripLabel1 As ToolStripLabel
    Friend WithEvents CódigoToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBycodigoToolStripButton As ToolStripButton
    Friend WithEvents FillBynomesToolStrip1 As ToolStrip
    Friend WithEvents NomeToolStripLabel1 As ToolStripLabel
    Friend WithEvents NomeToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents FillBynomesToolStripButton1 As ToolStripButton
    Friend WithEvents FillByTodosToolStrip As ToolStrip
    Friend WithEvents FillByTodosToolStripButton As ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
End Class
