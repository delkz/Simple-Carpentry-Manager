<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizarPedidos
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
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DetalhesLabel As System.Windows.Forms.Label
        Dim DataPedidoLabel As System.Windows.Forms.Label
        Dim EstimativaEntregaLabel As System.Windows.Forms.Label
        Dim FormaPagamentoLabel As System.Windows.Forms.Label
        Dim EnderecoEntregaLabel As System.Windows.Forms.Label
        Dim SituaçãoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizarPedidos))
        Dim EntregueLabel As System.Windows.Forms.Label
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.PedidoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidoTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.PedidoTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DetalhesTextBox = New System.Windows.Forms.TextBox()
        Me.FormaPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ClienteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ClienteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByCodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CódigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CódigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PedidoTabelaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet1 = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EnderecoEntregaTextBox = New System.Windows.Forms.TextBox()
        Me.SituaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.EntregueCheckBox = New System.Windows.Forms.CheckBox()
        CódigoLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DetalhesLabel = New System.Windows.Forms.Label()
        DataPedidoLabel = New System.Windows.Forms.Label()
        EstimativaEntregaLabel = New System.Windows.Forms.Label()
        FormaPagamentoLabel = New System.Windows.Forms.Label()
        EnderecoEntregaLabel = New System.Windows.Forms.Label()
        SituaçãoLabel = New System.Windows.Forms.Label()
        EntregueLabel = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidoTabelaBindingNavigator.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillByCodigoToolStrip.SuspendLayout()
        CType(Me.PedidoTabelaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(12, 69)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(96, 13)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código Do Pedido:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(12, 95)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 3
        ClienteLabel.Text = "Cliente:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(12, 148)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(51, 13)
        ValorLabel.TabIndex = 5
        ValorLabel.Text = "Valor R$:"
        '
        'DetalhesLabel
        '
        DetalhesLabel.AutoSize = True
        DetalhesLabel.Location = New System.Drawing.Point(12, 202)
        DetalhesLabel.Name = "DetalhesLabel"
        DetalhesLabel.Size = New System.Drawing.Size(52, 13)
        DetalhesLabel.TabIndex = 7
        DetalhesLabel.Text = "Detalhes:"
        '
        'DataPedidoLabel
        '
        DataPedidoLabel.AutoSize = True
        DataPedidoLabel.Location = New System.Drawing.Point(12, 336)
        DataPedidoLabel.Name = "DataPedidoLabel"
        DataPedidoLabel.Size = New System.Drawing.Size(69, 13)
        DataPedidoLabel.TabIndex = 9
        DataPedidoLabel.Text = "Data Pedido:"
        '
        'EstimativaEntregaLabel
        '
        EstimativaEntregaLabel.AutoSize = True
        EstimativaEntregaLabel.Location = New System.Drawing.Point(12, 362)
        EstimativaEntregaLabel.Name = "EstimativaEntregaLabel"
        EstimativaEntregaLabel.Size = New System.Drawing.Size(98, 13)
        EstimativaEntregaLabel.TabIndex = 13
        EstimativaEntregaLabel.Text = "Estimativa Entrega:"
        '
        'FormaPagamentoLabel
        '
        FormaPagamentoLabel.AutoSize = True
        FormaPagamentoLabel.Location = New System.Drawing.Point(12, 174)
        FormaPagamentoLabel.Name = "FormaPagamentoLabel"
        FormaPagamentoLabel.Size = New System.Drawing.Size(96, 13)
        FormaPagamentoLabel.TabIndex = 15
        FormaPagamentoLabel.Text = "Forma Pagamento:"
        '
        'EnderecoEntregaLabel
        '
        EnderecoEntregaLabel.AutoSize = True
        EnderecoEntregaLabel.Location = New System.Drawing.Point(12, 121)
        EnderecoEntregaLabel.Name = "EnderecoEntregaLabel"
        EnderecoEntregaLabel.Size = New System.Drawing.Size(96, 13)
        EnderecoEntregaLabel.TabIndex = 21
        EnderecoEntregaLabel.Text = "Endereço Entrega:"
        '
        'SituaçãoLabel
        '
        SituaçãoLabel.AutoSize = True
        SituaçãoLabel.Location = New System.Drawing.Point(12, 388)
        SituaçãoLabel.Name = "SituaçãoLabel"
        SituaçãoLabel.Size = New System.Drawing.Size(52, 13)
        SituaçãoLabel.TabIndex = 29
        SituaçãoLabel.Text = "Situação:"
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidoTabelaBindingSource
        '
        Me.PedidoTabelaBindingSource.DataMember = "PedidoTabela"
        Me.PedidoTabelaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'PedidoTabelaTableAdapter
        '
        Me.PedidoTabelaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Me.PedidoTabelaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'PedidoTabelaBindingNavigator
        '
        Me.PedidoTabelaBindingNavigator.AddNewItem = Nothing
        Me.PedidoTabelaBindingNavigator.BindingSource = Me.PedidoTabelaBindingSource
        Me.PedidoTabelaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidoTabelaBindingNavigator.DeleteItem = Nothing
        Me.PedidoTabelaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PedidoTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ImprimirToolStripButton, Me.toolStripSeparator})
        Me.PedidoTabelaBindingNavigator.Location = New System.Drawing.Point(0, 556)
        Me.PedidoTabelaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidoTabelaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidoTabelaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidoTabelaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidoTabelaBindingNavigator.Name = "PedidoTabelaBindingNavigator"
        Me.PedidoTabelaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidoTabelaBindingNavigator.Size = New System.Drawing.Size(511, 25)
        Me.PedidoTabelaBindingNavigator.TabIndex = 0
        Me.PedidoTabelaBindingNavigator.Text = "BindingNavigator1"
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
        Me.ImprimirToolStripButton.Enabled = False
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
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Código", True))
        Me.CódigoTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CódigoTextBox.Location = New System.Drawing.Point(116, 66)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.ReadOnly = True
        Me.CódigoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.CódigoTextBox.TabIndex = 1
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.BackColor = System.Drawing.Color.White
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(116, 92)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.ReadOnly = True
        Me.ClienteTextBox.Size = New System.Drawing.Size(315, 20)
        Me.ClienteTextBox.TabIndex = 2
        '
        'ValorTextBox
        '
        Me.ValorTextBox.BackColor = System.Drawing.Color.White
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(116, 145)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.ReadOnly = True
        Me.ValorTextBox.Size = New System.Drawing.Size(315, 20)
        Me.ValorTextBox.TabIndex = 3
        '
        'DetalhesTextBox
        '
        Me.DetalhesTextBox.BackColor = System.Drawing.Color.White
        Me.DetalhesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Detalhes", True))
        Me.DetalhesTextBox.Location = New System.Drawing.Point(116, 199)
        Me.DetalhesTextBox.Multiline = True
        Me.DetalhesTextBox.Name = "DetalhesTextBox"
        Me.DetalhesTextBox.ReadOnly = True
        Me.DetalhesTextBox.Size = New System.Drawing.Size(315, 124)
        Me.DetalhesTextBox.TabIndex = 5
        '
        'FormaPagamentoTextBox
        '
        Me.FormaPagamentoTextBox.BackColor = System.Drawing.Color.White
        Me.FormaPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "FormaPagamento", True))
        Me.FormaPagamentoTextBox.Location = New System.Drawing.Point(116, 171)
        Me.FormaPagamentoTextBox.Name = "FormaPagamentoTextBox"
        Me.FormaPagamentoTextBox.ReadOnly = True
        Me.FormaPagamentoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.FormaPagamentoTextBox.TabIndex = 4
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripLabel, Me.ClienteToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(511, 25)
        Me.FillByToolStrip.TabIndex = 18
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'ClienteToolStripLabel
        '
        Me.ClienteToolStripLabel.Name = "ClienteToolStripLabel"
        Me.ClienteToolStripLabel.Size = New System.Drawing.Size(47, 22)
        Me.ClienteToolStripLabel.Text = "Cliente:"
        '
        'ClienteToolStripTextBox
        '
        Me.ClienteToolStripTextBox.Name = "ClienteToolStripTextBox"
        Me.ClienteToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillByToolStripButton.Text = "Filtrar"
        '
        'FillByCodigoToolStrip
        '
        Me.FillByCodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigoToolStripLabel, Me.CódigoToolStripTextBox, Me.FillByCodigoToolStripButton})
        Me.FillByCodigoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByCodigoToolStrip.Name = "FillByCodigoToolStrip"
        Me.FillByCodigoToolStrip.Size = New System.Drawing.Size(511, 25)
        Me.FillByCodigoToolStrip.TabIndex = 19
        Me.FillByCodigoToolStrip.Text = "FillByCodigoToolStrip"
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
        'FillByCodigoToolStripButton
        '
        Me.FillByCodigoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByCodigoToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByCodigoToolStripButton.Name = "FillByCodigoToolStripButton"
        Me.FillByCodigoToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillByCodigoToolStripButton.Text = "Filtrar"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "DataPedido", True))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(116, 333)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(315, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "EstimativaEntrega", True))
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.Location = New System.Drawing.Point(116, 358)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(315, 20)
        Me.TextBox2.TabIndex = 7
        '
        'PedidoTabelaBindingSource1
        '
        Me.PedidoTabelaBindingSource1.DataMember = "PedidoTabela"
        Me.PedidoTabelaBindingSource1.DataSource = Me.MarcenariaDataSet1
        '
        'MarcenariaDataSet1
        '
        Me.MarcenariaDataSet1.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 531)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(511, 25)
        Me.FillBy1ToolStrip.TabIndex = 23
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(82, 22)
        Me.FillBy1ToolStripButton.Text = "Mostrar todos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(383, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Calcular Desconto"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(112, 488)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(66, 20)
        Me.TextBox4.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "%"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EnderecoEntregaTextBox
        '
        Me.EnderecoEntregaTextBox.BackColor = System.Drawing.Color.White
        Me.EnderecoEntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "EnderecoEntrega", True))
        Me.EnderecoEntregaTextBox.Location = New System.Drawing.Point(116, 118)
        Me.EnderecoEntregaTextBox.Name = "EnderecoEntregaTextBox"
        Me.EnderecoEntregaTextBox.ReadOnly = True
        Me.EnderecoEntregaTextBox.Size = New System.Drawing.Size(315, 20)
        Me.EnderecoEntregaTextBox.TabIndex = 29
        '
        'SituaçãoTextBox
        '
        Me.SituaçãoTextBox.BackColor = System.Drawing.Color.White
        Me.SituaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Situação", True))
        Me.SituaçãoTextBox.Location = New System.Drawing.Point(116, 388)
        Me.SituaçãoTextBox.Name = "SituaçãoTextBox"
        Me.SituaçãoTextBox.ReadOnly = True
        Me.SituaçãoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.SituaçãoTextBox.TabIndex = 30
        '
        'EntregueLabel
        '
        EntregueLabel.AutoSize = True
        EntregueLabel.Location = New System.Drawing.Point(12, 425)
        EntregueLabel.Name = "EntregueLabel"
        EntregueLabel.Size = New System.Drawing.Size(53, 13)
        EntregueLabel.TabIndex = 30
        EntregueLabel.Text = "Entregue:"
        '
        'EntregueCheckBox
        '
        Me.EntregueCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PedidoTabelaBindingSource, "Entregue", True))
        Me.EntregueCheckBox.Location = New System.Drawing.Point(116, 420)
        Me.EntregueCheckBox.Name = "EntregueCheckBox"
        Me.EntregueCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EntregueCheckBox.TabIndex = 31
        Me.EntregueCheckBox.UseVisualStyleBackColor = True
        '
        'VisualizarPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(511, 581)
        Me.Controls.Add(EntregueLabel)
        Me.Controls.Add(Me.EntregueCheckBox)
        Me.Controls.Add(SituaçãoLabel)
        Me.Controls.Add(Me.SituaçãoTextBox)
        Me.Controls.Add(Me.EnderecoEntregaTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(EnderecoEntregaLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FillByCodigoToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(DetalhesLabel)
        Me.Controls.Add(Me.DetalhesTextBox)
        Me.Controls.Add(DataPedidoLabel)
        Me.Controls.Add(EstimativaEntregaLabel)
        Me.Controls.Add(FormaPagamentoLabel)
        Me.Controls.Add(Me.FormaPagamentoTextBox)
        Me.Controls.Add(Me.PedidoTabelaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VisualizarPedidos"
        Me.Text = "Visualizar Pedidos"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidoTabelaBindingNavigator.ResumeLayout(False)
        Me.PedidoTabelaBindingNavigator.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillByCodigoToolStrip.ResumeLayout(False)
        Me.FillByCodigoToolStrip.PerformLayout()
        CType(Me.PedidoTabelaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents PedidoTabelaBindingSource As BindingSource
    Friend WithEvents PedidoTabelaTableAdapter As MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidoTabelaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents DetalhesTextBox As TextBox
    Friend WithEvents FormaPagamentoTextBox As TextBox
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents ClienteToolStripLabel As ToolStripLabel
    Friend WithEvents ClienteToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents FillByCodigoToolStrip As ToolStrip
    Friend WithEvents CódigoToolStripLabel As ToolStripLabel
    Friend WithEvents CódigoToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByCodigoToolStripButton As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MarcenariaDataSet1 As MarcenariaDataSet
    Friend WithEvents PedidoTabelaBindingSource1 As BindingSource
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EnderecoEntregaTextBox As TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SituaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EntregueCheckBox As System.Windows.Forms.CheckBox
End Class
