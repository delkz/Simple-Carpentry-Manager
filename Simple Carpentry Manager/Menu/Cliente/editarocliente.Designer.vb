<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarocliente
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
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Celular1Label As System.Windows.Forms.Label
        Dim Celular2Label As System.Windows.Forms.Label
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim ObservacoesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editarocliente))
        Me.ClienteTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ClienteTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteTabelaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.FillBynomesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBynomesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBycodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CódigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CódigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBycodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByTodosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByTodosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Celular2TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Celular1TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClienteTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.ObservacoesTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        Celular1Label = New System.Windows.Forms.Label()
        Celular2Label = New System.Windows.Forms.Label()
        CódigoLabel = New System.Windows.Forms.Label()
        ObservacoesLabel = New System.Windows.Forms.Label()
        CType(Me.ClienteTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteTabelaBindingNavigator.SuspendLayout()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBynomesToolStrip.SuspendLayout()
        Me.FillBycodigoToolStrip.SuspendLayout()
        Me.FillByTodosToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(12, 113)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 139)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(12, 165)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 7
        EnderecoLabel.Text = "Endereco:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Location = New System.Drawing.Point(12, 199)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(52, 13)
        TelefoneLabel.TabIndex = 9
        TelefoneLabel.Text = "Telefone:"
        '
        'Celular1Label
        '
        Celular1Label.AutoSize = True
        Celular1Label.Location = New System.Drawing.Point(13, 229)
        Celular1Label.Name = "Celular1Label"
        Celular1Label.Size = New System.Drawing.Size(42, 13)
        Celular1Label.TabIndex = 11
        Celular1Label.Text = "Celular:"
        '
        'Celular2Label
        '
        Celular2Label.AutoSize = True
        Celular2Label.Location = New System.Drawing.Point(12, 256)
        Celular2Label.Name = "Celular2Label"
        Celular2Label.Size = New System.Drawing.Size(27, 13)
        Celular2Label.TabIndex = 13
        Celular2Label.Text = "CPF"
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(12, 87)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(43, 13)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código:"
        '
        'ObservacoesLabel
        '
        ObservacoesLabel.AutoSize = True
        ObservacoesLabel.Location = New System.Drawing.Point(12, 286)
        ObservacoesLabel.Name = "ObservacoesLabel"
        ObservacoesLabel.Size = New System.Drawing.Size(73, 13)
        ObservacoesLabel.TabIndex = 30
        ObservacoesLabel.Text = "Observaçoes:"
        '
        'ClienteTabelaBindingNavigator
        '
        Me.ClienteTabelaBindingNavigator.AddNewItem = Nothing
        Me.ClienteTabelaBindingNavigator.BindingSource = Me.ClienteTabelaBindingSource
        Me.ClienteTabelaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteTabelaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteTabelaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ClienteTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ClienteTabelaBindingNavigatorSaveItem, Me.toolStripSeparator})
        Me.ClienteTabelaBindingNavigator.Location = New System.Drawing.Point(0, 487)
        Me.ClienteTabelaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteTabelaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteTabelaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteTabelaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteTabelaBindingNavigator.Name = "ClienteTabelaBindingNavigator"
        Me.ClienteTabelaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteTabelaBindingNavigator.Size = New System.Drawing.Size(481, 25)
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
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClienteTabelaBindingNavigatorSaveItem
        '
        Me.ClienteTabelaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteTabelaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteTabelaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteTabelaBindingNavigatorSaveItem.Name = "ClienteTabelaBindingNavigatorSaveItem"
        Me.ClienteTabelaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteTabelaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(82, 110)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(349, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(82, 136)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(349, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(82, 162)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(348, 20)
        Me.EnderecoTextBox.TabIndex = 8
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.BackColor = System.Drawing.Color.White
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Código", True))
        Me.CódigoTextBox.Location = New System.Drawing.Point(82, 84)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.ReadOnly = True
        Me.CódigoTextBox.Size = New System.Drawing.Size(349, 20)
        Me.CódigoTextBox.TabIndex = 2
        '
        'FillBynomesToolStrip
        '
        Me.FillBynomesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.FillBynomesToolStripButton})
        Me.FillBynomesToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBynomesToolStrip.Name = "FillBynomesToolStrip"
        Me.FillBynomesToolStrip.Size = New System.Drawing.Size(481, 25)
        Me.FillBynomesToolStrip.TabIndex = 17
        Me.FillBynomesToolStrip.Text = "FillBynomesToolStrip"
        '
        'NomeToolStripLabel
        '
        Me.NomeToolStripLabel.Name = "NomeToolStripLabel"
        Me.NomeToolStripLabel.Size = New System.Drawing.Size(43, 22)
        Me.NomeToolStripLabel.Text = "Nome:"
        '
        'NomeToolStripTextBox
        '
        Me.NomeToolStripTextBox.Name = "NomeToolStripTextBox"
        Me.NomeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBynomesToolStripButton
        '
        Me.FillBynomesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBynomesToolStripButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic)
        Me.FillBynomesToolStripButton.Name = "FillBynomesToolStripButton"
        Me.FillBynomesToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.FillBynomesToolStripButton.Text = "Filtrar"
        '
        'FillBycodigoToolStrip
        '
        Me.FillBycodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigoToolStripLabel, Me.CódigoToolStripTextBox, Me.FillBycodigoToolStripButton})
        Me.FillBycodigoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBycodigoToolStrip.Name = "FillBycodigoToolStrip"
        Me.FillBycodigoToolStrip.Size = New System.Drawing.Size(481, 25)
        Me.FillBycodigoToolStrip.TabIndex = 18
        Me.FillBycodigoToolStrip.Text = "FillBycodigoToolStrip"
        '
        'CódigoToolStripLabel
        '
        Me.CódigoToolStripLabel.Name = "CódigoToolStripLabel"
        Me.CódigoToolStripLabel.Size = New System.Drawing.Size(49, 22)
        Me.CódigoToolStripLabel.Text = "Código:"
        '
        'CódigoToolStripTextBox
        '
        Me.CódigoToolStripTextBox.Name = "CódigoToolStripTextBox"
        Me.CódigoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBycodigoToolStripButton
        '
        Me.FillBycodigoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBycodigoToolStripButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic)
        Me.FillBycodigoToolStripButton.Name = "FillBycodigoToolStripButton"
        Me.FillBycodigoToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.FillBycodigoToolStripButton.Text = "Filtrar"
        '
        'FillByTodosToolStrip
        '
        Me.FillByTodosToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FillByTodosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByTodosToolStripButton})
        Me.FillByTodosToolStrip.Location = New System.Drawing.Point(0, 462)
        Me.FillByTodosToolStrip.Name = "FillByTodosToolStrip"
        Me.FillByTodosToolStrip.Size = New System.Drawing.Size(481, 25)
        Me.FillByTodosToolStrip.TabIndex = 19
        Me.FillByTodosToolStrip.Text = "FillByTodosToolStrip"
        '
        'FillByTodosToolStripButton
        '
        Me.FillByTodosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByTodosToolStripButton.Name = "FillByTodosToolStripButton"
        Me.FillByTodosToolStripButton.Size = New System.Drawing.Size(87, 22)
        Me.FillByTodosToolStripButton.Text = "Mostrar Todos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(318, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Celular2TextBox
        '
        Me.Celular2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular2", True))
        Me.Celular2TextBox.Location = New System.Drawing.Point(82, 253)
        Me.Celular2TextBox.Name = "Celular2TextBox"
        Me.Celular2TextBox.Size = New System.Drawing.Size(348, 20)
        Me.Celular2TextBox.TabIndex = 29
        '
        'Celular1TextBox
        '
        Me.Celular1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Celular1", True))
        Me.Celular1TextBox.Location = New System.Drawing.Point(82, 222)
        Me.Celular1TextBox.Mask = "(00) 00000-0000"
        Me.Celular1TextBox.Name = "Celular1TextBox"
        Me.Celular1TextBox.Size = New System.Drawing.Size(348, 20)
        Me.Celular1TextBox.TabIndex = 28
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Telefone", True))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(82, 192)
        Me.TelefoneTextBox.Mask = "(00) 0000-0000"
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(348, 20)
        Me.TelefoneTextBox.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Os dados nessa tela podem ser editados ou apagados permanentemente, Cuidado"
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
        'ObservacoesTextBox
        '
        Me.ObservacoesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteTabelaBindingSource, "Observacoes", True))
        Me.ObservacoesTextBox.Location = New System.Drawing.Point(91, 283)
        Me.ObservacoesTextBox.Multiline = True
        Me.ObservacoesTextBox.Name = "ObservacoesTextBox"
        Me.ObservacoesTextBox.Size = New System.Drawing.Size(339, 143)
        Me.ObservacoesTextBox.TabIndex = 31
        '
        'editarocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 512)
        Me.Controls.Add(ObservacoesLabel)
        Me.Controls.Add(Me.ObservacoesTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Celular2TextBox)
        Me.Controls.Add(Me.Celular1TextBox)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillByTodosToolStrip)
        Me.Controls.Add(Me.FillBycodigoToolStrip)
        Me.Controls.Add(Me.FillBynomesToolStrip)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
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
        Me.Name = "editarocliente"
        Me.Text = "Editar Cliente"
        CType(Me.ClienteTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteTabelaBindingNavigator.ResumeLayout(False)
        Me.ClienteTabelaBindingNavigator.PerformLayout()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBynomesToolStrip.ResumeLayout(False)
        Me.FillBynomesToolStrip.PerformLayout()
        Me.FillBycodigoToolStrip.ResumeLayout(False)
        Me.FillBycodigoToolStrip.PerformLayout()
        Me.FillByTodosToolStrip.ResumeLayout(False)
        Me.FillByTodosToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents ClienteTabelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTabelaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTabelaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClienteTabelaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CódigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillBynomesToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBynomesToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillBycodigoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CódigoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CódigoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBycodigoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FillByTodosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByTodosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Celular2TextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Celular1TextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ObservacoesTextBox As System.Windows.Forms.TextBox
End Class
