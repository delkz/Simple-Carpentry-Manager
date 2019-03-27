<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarpedido
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
        Dim EntregueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editarpedido))
        Me.PedidoTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PedidoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PedidoTabelaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DetalhesTextBox = New System.Windows.Forms.TextBox()
        Me.DataPedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EstimativaEntregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FormaPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoEntregaTextBox = New System.Windows.Forms.TextBox()
        Me.FillByCodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CódigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CódigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ClienteToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ClienteToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PedidoTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
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
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidoTabelaBindingNavigator.SuspendLayout()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCodigoToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Location = New System.Drawing.Point(12, 59)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(43, 13)
        CódigoLabel.TabIndex = 1
        CódigoLabel.Text = "Código:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(12, 85)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 3
        ClienteLabel.Text = "Cliente:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(12, 111)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 5
        ValorLabel.Text = "Valor:"
        '
        'DetalhesLabel
        '
        DetalhesLabel.AutoSize = True
        DetalhesLabel.Location = New System.Drawing.Point(10, 137)
        DetalhesLabel.Name = "DetalhesLabel"
        DetalhesLabel.Size = New System.Drawing.Size(52, 13)
        DetalhesLabel.TabIndex = 7
        DetalhesLabel.Text = "Detalhes:"
        '
        'DataPedidoLabel
        '
        DataPedidoLabel.AutoSize = True
        DataPedidoLabel.Location = New System.Drawing.Point(10, 250)
        DataPedidoLabel.Name = "DataPedidoLabel"
        DataPedidoLabel.Size = New System.Drawing.Size(69, 13)
        DataPedidoLabel.TabIndex = 9
        DataPedidoLabel.Text = "Data Pedido:"
        '
        'EstimativaEntregaLabel
        '
        EstimativaEntregaLabel.AutoSize = True
        EstimativaEntregaLabel.Location = New System.Drawing.Point(10, 278)
        EstimativaEntregaLabel.Name = "EstimativaEntregaLabel"
        EstimativaEntregaLabel.Size = New System.Drawing.Size(98, 13)
        EstimativaEntregaLabel.TabIndex = 13
        EstimativaEntregaLabel.Text = "Estimativa Entrega:"
        '
        'FormaPagamentoLabel
        '
        FormaPagamentoLabel.AutoSize = True
        FormaPagamentoLabel.Location = New System.Drawing.Point(10, 371)
        FormaPagamentoLabel.Name = "FormaPagamentoLabel"
        FormaPagamentoLabel.Size = New System.Drawing.Size(96, 13)
        FormaPagamentoLabel.TabIndex = 15
        FormaPagamentoLabel.Text = "Forma Pagamento:"
        '
        'EnderecoEntregaLabel
        '
        EnderecoEntregaLabel.AutoSize = True
        EnderecoEntregaLabel.Location = New System.Drawing.Point(10, 340)
        EnderecoEntregaLabel.Name = "EnderecoEntregaLabel"
        EnderecoEntregaLabel.Size = New System.Drawing.Size(96, 13)
        EnderecoEntregaLabel.TabIndex = 17
        EnderecoEntregaLabel.Text = "Endereço Entrega:"
        '
        'SituaçãoLabel
        '
        SituaçãoLabel.AutoSize = True
        SituaçãoLabel.Location = New System.Drawing.Point(10, 311)
        SituaçãoLabel.Name = "SituaçãoLabel"
        SituaçãoLabel.Size = New System.Drawing.Size(52, 13)
        SituaçãoLabel.TabIndex = 26
        SituaçãoLabel.Text = "Situação:"
        '
        'EntregueLabel
        '
        EntregueLabel.AutoSize = True
        EntregueLabel.Location = New System.Drawing.Point(12, 408)
        EntregueLabel.Name = "EntregueLabel"
        EntregueLabel.Size = New System.Drawing.Size(53, 13)
        EntregueLabel.TabIndex = 27
        EntregueLabel.Text = "Entregue:"
        '
        'PedidoTabelaBindingNavigator
        '
        Me.PedidoTabelaBindingNavigator.AddNewItem = Nothing
        Me.PedidoTabelaBindingNavigator.BindingSource = Me.PedidoTabelaBindingSource
        Me.PedidoTabelaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidoTabelaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PedidoTabelaBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PedidoTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.PedidoTabelaBindingNavigatorSaveItem, Me.toolStripSeparator})
        Me.PedidoTabelaBindingNavigator.Location = New System.Drawing.Point(0, 520)
        Me.PedidoTabelaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidoTabelaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidoTabelaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidoTabelaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidoTabelaBindingNavigator.Name = "PedidoTabelaBindingNavigator"
        Me.PedidoTabelaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidoTabelaBindingNavigator.Size = New System.Drawing.Size(491, 25)
        Me.PedidoTabelaBindingNavigator.TabIndex = 0
        Me.PedidoTabelaBindingNavigator.Text = "BindingNavigator1"
        '
        'PedidoTabelaBindingSource
        '
        Me.PedidoTabelaBindingSource.DataMember = "PedidoTabela"
        Me.PedidoTabelaBindingSource.DataSource = Me.MarcenariaDataSet
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
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
        'PedidoTabelaBindingNavigatorSaveItem
        '
        Me.PedidoTabelaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PedidoTabelaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidoTabelaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidoTabelaBindingNavigatorSaveItem.Name = "PedidoTabelaBindingNavigatorSaveItem"
        Me.PedidoTabelaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PedidoTabelaBindingNavigatorSaveItem.Text = "Salvar Dados"
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
        Me.CódigoTextBox.Location = New System.Drawing.Point(116, 56)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.ReadOnly = True
        Me.CódigoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CódigoTextBox.TabIndex = 1
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(116, 82)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClienteTextBox.TabIndex = 2
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(114, 108)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ValorTextBox.TabIndex = 3
        '
        'DetalhesTextBox
        '
        Me.DetalhesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Detalhes", True))
        Me.DetalhesTextBox.Location = New System.Drawing.Point(114, 134)
        Me.DetalhesTextBox.Multiline = True
        Me.DetalhesTextBox.Name = "DetalhesTextBox"
        Me.DetalhesTextBox.Size = New System.Drawing.Size(200, 106)
        Me.DetalhesTextBox.TabIndex = 4
        '
        'DataPedidoDateTimePicker
        '
        Me.DataPedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoTabelaBindingSource, "DataPedido", True))
        Me.DataPedidoDateTimePicker.Location = New System.Drawing.Point(114, 246)
        Me.DataPedidoDateTimePicker.Name = "DataPedidoDateTimePicker"
        Me.DataPedidoDateTimePicker.Size = New System.Drawing.Size(365, 20)
        Me.DataPedidoDateTimePicker.TabIndex = 5
        '
        'EstimativaEntregaDateTimePicker
        '
        Me.EstimativaEntregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoTabelaBindingSource, "EstimativaEntrega", True))
        Me.EstimativaEntregaDateTimePicker.Location = New System.Drawing.Point(114, 274)
        Me.EstimativaEntregaDateTimePicker.Name = "EstimativaEntregaDateTimePicker"
        Me.EstimativaEntregaDateTimePicker.Size = New System.Drawing.Size(365, 20)
        Me.EstimativaEntregaDateTimePicker.TabIndex = 6
        '
        'FormaPagamentoTextBox
        '
        Me.FormaPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "FormaPagamento", True))
        Me.FormaPagamentoTextBox.Location = New System.Drawing.Point(114, 368)
        Me.FormaPagamentoTextBox.Name = "FormaPagamentoTextBox"
        Me.FormaPagamentoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FormaPagamentoTextBox.TabIndex = 9
        '
        'EnderecoEntregaTextBox
        '
        Me.EnderecoEntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "EnderecoEntrega", True))
        Me.EnderecoEntregaTextBox.Location = New System.Drawing.Point(114, 337)
        Me.EnderecoEntregaTextBox.Name = "EnderecoEntregaTextBox"
        Me.EnderecoEntregaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EnderecoEntregaTextBox.TabIndex = 8
        '
        'FillByCodigoToolStrip
        '
        Me.FillByCodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CódigoToolStripLabel, Me.CódigoToolStripTextBox, Me.FillByCodigoToolStripButton})
        Me.FillByCodigoToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByCodigoToolStrip.Name = "FillByCodigoToolStrip"
        Me.FillByCodigoToolStrip.Size = New System.Drawing.Size(491, 25)
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
        Me.FillByCodigoToolStripButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic)
        Me.FillByCodigoToolStripButton.Name = "FillByCodigoToolStripButton"
        Me.FillByCodigoToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.FillByCodigoToolStripButton.Text = "Filtrar"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripLabel, Me.ClienteToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(491, 25)
        Me.FillByToolStrip.TabIndex = 20
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
        Me.FillByToolStripButton.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic)
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(40, 22)
        Me.FillByToolStripButton.Text = "Filtrar"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 495)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(491, 25)
        Me.FillBy1ToolStrip.TabIndex = 21
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(87, 22)
        Me.FillBy1ToolStripButton.Text = "Mostrar Todos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(363, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 462)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Os dados nessa tela podem ser editados ou apagados permanentemente, Cuidado"
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
        'SituaçãoTextBox
        '
        Me.SituaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Situação", True))
        Me.SituaçãoTextBox.Location = New System.Drawing.Point(114, 308)
        Me.SituaçãoTextBox.Name = "SituaçãoTextBox"
        Me.SituaçãoTextBox.Size = New System.Drawing.Size(202, 20)
        Me.SituaçãoTextBox.TabIndex = 27
        '
        'EntregueCheckBox
        '
        Me.EntregueCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PedidoTabelaBindingSource, "Entregue", True))
        Me.EntregueCheckBox.Location = New System.Drawing.Point(114, 403)
        Me.EntregueCheckBox.Name = "EntregueCheckBox"
        Me.EntregueCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EntregueCheckBox.TabIndex = 28
        Me.EntregueCheckBox.UseVisualStyleBackColor = True
        '
        'editarpedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 545)
        Me.Controls.Add(EntregueLabel)
        Me.Controls.Add(Me.EntregueCheckBox)
        Me.Controls.Add(SituaçãoLabel)
        Me.Controls.Add(Me.SituaçãoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.FillByCodigoToolStrip)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(Me.ClienteTextBox)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(DetalhesLabel)
        Me.Controls.Add(Me.DetalhesTextBox)
        Me.Controls.Add(DataPedidoLabel)
        Me.Controls.Add(Me.DataPedidoDateTimePicker)
        Me.Controls.Add(EstimativaEntregaLabel)
        Me.Controls.Add(Me.EstimativaEntregaDateTimePicker)
        Me.Controls.Add(FormaPagamentoLabel)
        Me.Controls.Add(Me.FormaPagamentoTextBox)
        Me.Controls.Add(EnderecoEntregaLabel)
        Me.Controls.Add(Me.EnderecoEntregaTextBox)
        Me.Controls.Add(Me.PedidoTabelaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editarpedido"
        Me.Text = "Editar Pedido"
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidoTabelaBindingNavigator.ResumeLayout(False)
        Me.PedidoTabelaBindingNavigator.PerformLayout()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCodigoToolStrip.ResumeLayout(False)
        Me.FillByCodigoToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
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
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PedidoTabelaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents DetalhesTextBox As TextBox
    Friend WithEvents DataPedidoDateTimePicker As DateTimePicker
    Friend WithEvents EstimativaEntregaDateTimePicker As DateTimePicker
    Friend WithEvents FormaPagamentoTextBox As TextBox
    Friend WithEvents EnderecoEntregaTextBox As TextBox
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents FillByCodigoToolStrip As ToolStrip
    Friend WithEvents CódigoToolStripLabel As ToolStripLabel
    Friend WithEvents CódigoToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByCodigoToolStripButton As ToolStripButton
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents ClienteToolStripLabel As ToolStripLabel
    Friend WithEvents ClienteToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SituaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EntregueCheckBox As System.Windows.Forms.CheckBox
End Class
