<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stk_EditarProdutos
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim FornecedorLabel As System.Windows.Forms.Label
        Dim ValorUnitarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stk_EditarProdutos))
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoqueTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.EstoqueTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.EstoqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EstoqueBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.ValorUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Btn_Remover = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstoqueConsultapornomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstoqueConsultapornomeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EstoquePesquisaPorCodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstoquePesquisaPorCodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ESTOQUESelecionartodosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ESTOQUESelecionartodosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        FornecedorLabel = New System.Windows.Forms.Label()
        ValorUnitarioLabel = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoqueBindingNavigator.SuspendLayout()
        Me.EstoqueConsultapornomeToolStrip.SuspendLayout()
        Me.EstoquePesquisaPorCodigoToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ESTOQUESelecionartodosToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(16, 140)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(16, 166)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(16, 192)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(65, 13)
        QuantidadeLabel.TabIndex = 5
        QuantidadeLabel.Text = "Quantidade:"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Location = New System.Drawing.Point(16, 223)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(64, 13)
        FornecedorLabel.TabIndex = 7
        FornecedorLabel.Text = "Fornecedor:"
        '
        'ValorUnitarioLabel
        '
        ValorUnitarioLabel.AutoSize = True
        ValorUnitarioLabel.Location = New System.Drawing.Point(16, 249)
        ValorUnitarioLabel.Name = "ValorUnitarioLabel"
        ValorUnitarioLabel.Size = New System.Drawing.Size(73, 13)
        ValorUnitarioLabel.TabIndex = 9
        ValorUnitarioLabel.Text = "Valor Unitario:"
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstoqueBindingSource
        '
        Me.EstoqueBindingSource.DataMember = "Estoque"
        Me.EstoqueBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'EstoqueTableAdapter
        '
        Me.EstoqueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.EstoqueTableAdapter = Me.EstoqueTableAdapter
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'EstoqueBindingNavigator
        '
        Me.EstoqueBindingNavigator.AddNewItem = Nothing
        Me.EstoqueBindingNavigator.BindingSource = Me.EstoqueBindingSource
        Me.EstoqueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstoqueBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstoqueBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EstoqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.EstoqueBindingNavigatorSaveItem})
        Me.EstoqueBindingNavigator.Location = New System.Drawing.Point(0, 345)
        Me.EstoqueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstoqueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstoqueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstoqueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstoqueBindingNavigator.Name = "EstoqueBindingNavigator"
        Me.EstoqueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstoqueBindingNavigator.Size = New System.Drawing.Size(590, 25)
        Me.EstoqueBindingNavigator.TabIndex = 0
        Me.EstoqueBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
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
        'EstoqueBindingNavigatorSaveItem
        '
        Me.EstoqueBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstoqueBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstoqueBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstoqueBindingNavigatorSaveItem.Name = "EstoqueBindingNavigatorSaveItem"
        Me.EstoqueBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EstoqueBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(95, 137)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(302, 20)
        Me.CodigoTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(95, 163)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(452, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Quantidade", True))
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(95, 189)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(321, 20)
        Me.QuantidadeTextBox.TabIndex = 6
        '
        'FornecedorTextBox
        '
        Me.FornecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Fornecedor", True))
        Me.FornecedorTextBox.Location = New System.Drawing.Point(95, 220)
        Me.FornecedorTextBox.Name = "FornecedorTextBox"
        Me.FornecedorTextBox.Size = New System.Drawing.Size(452, 20)
        Me.FornecedorTextBox.TabIndex = 8
        '
        'ValorUnitarioTextBox
        '
        Me.ValorUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "ValorUnitario", True))
        Me.ValorUnitarioTextBox.Location = New System.Drawing.Point(95, 246)
        Me.ValorUnitarioTextBox.Name = "ValorUnitarioTextBox"
        Me.ValorUnitarioTextBox.Size = New System.Drawing.Size(452, 20)
        Me.ValorUnitarioTextBox.TabIndex = 10
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Location = New System.Drawing.Point(516, 183)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(31, 30)
        Me.Btn_Adicionar.TabIndex = 11
        Me.Btn_Adicionar.Text = "+"
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Btn_Remover
        '
        Me.Btn_Remover.Location = New System.Drawing.Point(422, 183)
        Me.Btn_Remover.Name = "Btn_Remover"
        Me.Btn_Remover.Size = New System.Drawing.Size(31, 30)
        Me.Btn_Remover.TabIndex = 12
        Me.Btn_Remover.Text = "-"
        Me.Btn_Remover.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(459, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Os dados nessa tela podem ser editados ou apagados permanentemente, Cuidado"
        '
        'EstoqueConsultapornomeToolStrip
        '
        Me.EstoqueConsultapornomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.EstoqueConsultapornomeToolStripButton})
        Me.EstoqueConsultapornomeToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.EstoqueConsultapornomeToolStrip.Name = "EstoqueConsultapornomeToolStrip"
        Me.EstoqueConsultapornomeToolStrip.Size = New System.Drawing.Size(590, 25)
        Me.EstoqueConsultapornomeToolStrip.TabIndex = 32
        Me.EstoqueConsultapornomeToolStrip.Text = "EstoqueConsultapornomeToolStrip"
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
        'EstoqueConsultapornomeToolStripButton
        '
        Me.EstoqueConsultapornomeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EstoqueConsultapornomeToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstoqueConsultapornomeToolStripButton.Name = "EstoqueConsultapornomeToolStripButton"
        Me.EstoqueConsultapornomeToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.EstoqueConsultapornomeToolStripButton.Text = "Filtrar"
        '
        'EstoquePesquisaPorCodigoToolStrip
        '
        Me.EstoquePesquisaPorCodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodigoToolStripLabel, Me.CodigoToolStripTextBox, Me.EstoquePesquisaPorCodigoToolStripButton})
        Me.EstoquePesquisaPorCodigoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.EstoquePesquisaPorCodigoToolStrip.Name = "EstoquePesquisaPorCodigoToolStrip"
        Me.EstoquePesquisaPorCodigoToolStrip.Size = New System.Drawing.Size(590, 25)
        Me.EstoquePesquisaPorCodigoToolStrip.TabIndex = 33
        Me.EstoquePesquisaPorCodigoToolStrip.Text = "EstoquePesquisaPorCodigoToolStrip"
        '
        'CodigoToolStripLabel
        '
        Me.CodigoToolStripLabel.Name = "CodigoToolStripLabel"
        Me.CodigoToolStripLabel.Size = New System.Drawing.Size(49, 22)
        Me.CodigoToolStripLabel.Text = "Codigo:"
        '
        'CodigoToolStripTextBox
        '
        Me.CodigoToolStripTextBox.Name = "CodigoToolStripTextBox"
        Me.CodigoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'EstoquePesquisaPorCodigoToolStripButton
        '
        Me.EstoquePesquisaPorCodigoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EstoquePesquisaPorCodigoToolStripButton.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstoquePesquisaPorCodigoToolStripButton.Name = "EstoquePesquisaPorCodigoToolStripButton"
        Me.EstoquePesquisaPorCodigoToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.EstoquePesquisaPorCodigoToolStripButton.Text = "Filtrar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.StockManagerLogo
        Me.PictureBox1.Location = New System.Drawing.Point(442, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'ESTOQUESelecionartodosToolStrip
        '
        Me.ESTOQUESelecionartodosToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ESTOQUESelecionartodosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTOQUESelecionartodosToolStripButton})
        Me.ESTOQUESelecionartodosToolStrip.Location = New System.Drawing.Point(0, 320)
        Me.ESTOQUESelecionartodosToolStrip.Name = "ESTOQUESelecionartodosToolStrip"
        Me.ESTOQUESelecionartodosToolStrip.Size = New System.Drawing.Size(590, 25)
        Me.ESTOQUESelecionartodosToolStrip.TabIndex = 35
        Me.ESTOQUESelecionartodosToolStrip.Text = "ESTOQUESelecionartodosToolStrip"
        '
        'ESTOQUESelecionartodosToolStripButton
        '
        Me.ESTOQUESelecionartodosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ESTOQUESelecionartodosToolStripButton.Name = "ESTOQUESelecionartodosToolStripButton"
        Me.ESTOQUESelecionartodosToolStripButton.Size = New System.Drawing.Size(91, 22)
        Me.ESTOQUESelecionartodosToolStripButton.Text = "Reiniciar Filtros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Edição de Produto"
        '
        'Stk_EditarProdutos
        '
        Me.ClientSize = New System.Drawing.Size(590, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ESTOQUESelecionartodosToolStrip)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EstoquePesquisaPorCodigoToolStrip)
        Me.Controls.Add(Me.EstoqueConsultapornomeToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Remover)
        Me.Controls.Add(Me.Btn_Adicionar)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.QuantidadeTextBox)
        Me.Controls.Add(FornecedorLabel)
        Me.Controls.Add(Me.FornecedorTextBox)
        Me.Controls.Add(ValorUnitarioLabel)
        Me.Controls.Add(Me.ValorUnitarioTextBox)
        Me.Controls.Add(Me.EstoqueBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stk_EditarProdutos"
        Me.Text = "Editar Produtos"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoqueBindingNavigator.ResumeLayout(False)
        Me.EstoqueBindingNavigator.PerformLayout()
        Me.EstoqueConsultapornomeToolStrip.ResumeLayout(False)
        Me.EstoqueConsultapornomeToolStrip.PerformLayout()
        Me.EstoquePesquisaPorCodigoToolStrip.ResumeLayout(False)
        Me.EstoquePesquisaPorCodigoToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ESTOQUESelecionartodosToolStrip.ResumeLayout(False)
        Me.ESTOQUESelecionartodosToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents EstoqueBindingSource As BindingSource
    Friend WithEvents EstoqueTableAdapter As MarcenariaDataSetTableAdapters.EstoqueTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstoqueBindingNavigator As BindingNavigator
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
    Friend WithEvents EstoqueBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents FornecedorTextBox As TextBox
    Friend WithEvents ValorUnitarioTextBox As TextBox
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Btn_Remover As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EstoqueConsultapornomeToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NomeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EstoqueConsultapornomeToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EstoquePesquisaPorCodigoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CodigoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EstoquePesquisaPorCodigoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ESTOQUESelecionartodosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ESTOQUESelecionartodosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As Label
End Class
