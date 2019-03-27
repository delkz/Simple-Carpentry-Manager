<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarMaterialIndividual
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
        Dim CodChapaLabel As System.Windows.Forms.Label
        Dim NomeChapaLabel As System.Windows.Forms.Label
        Dim ExpressuraLabel As System.Windows.Forms.Label
        Dim CorLabel As System.Windows.Forms.Label
        Dim FornecedorLabel As System.Windows.Forms.Label
        Dim Valor_porchapa_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarMaterialIndividual))
        Me.MateriaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CodChapaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeChapaTextBox = New System.Windows.Forms.TextBox()
        Me.ExpressuraTextBox = New System.Windows.Forms.TextBox()
        Me.CorTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_porchapa_TextBox = New System.Windows.Forms.TextBox()
        Me.FillByCodigoChapaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodChapaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodChapaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCodigoChapaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomeChapaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeChapaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByCorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCorToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MateriaisTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.FillByAllToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CodChapaLabel = New System.Windows.Forms.Label()
        NomeChapaLabel = New System.Windows.Forms.Label()
        ExpressuraLabel = New System.Windows.Forms.Label()
        CorLabel = New System.Windows.Forms.Label()
        FornecedorLabel = New System.Windows.Forms.Label()
        Valor_porchapa_Label = New System.Windows.Forms.Label()
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MateriaisBindingNavigator.SuspendLayout()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCodigoChapaToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.FillByCorToolStrip.SuspendLayout()
        Me.FillByAllToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodChapaLabel
        '
        CodChapaLabel.AutoSize = True
        CodChapaLabel.Location = New System.Drawing.Point(12, 135)
        CodChapaLabel.Name = "CodChapaLabel"
        CodChapaLabel.Size = New System.Drawing.Size(76, 13)
        CodChapaLabel.TabIndex = 3
        CodChapaLabel.Text = "Codigo chapa:"
        '
        'NomeChapaLabel
        '
        NomeChapaLabel.AutoSize = True
        NomeChapaLabel.Location = New System.Drawing.Point(12, 161)
        NomeChapaLabel.Name = "NomeChapaLabel"
        NomeChapaLabel.Size = New System.Drawing.Size(72, 13)
        NomeChapaLabel.TabIndex = 5
        NomeChapaLabel.Text = "Nome Chapa:"
        '
        'ExpressuraLabel
        '
        ExpressuraLabel.AutoSize = True
        ExpressuraLabel.Location = New System.Drawing.Point(12, 187)
        ExpressuraLabel.Name = "ExpressuraLabel"
        ExpressuraLabel.Size = New System.Drawing.Size(62, 13)
        ExpressuraLabel.TabIndex = 7
        ExpressuraLabel.Text = "Expressura:"
        '
        'CorLabel
        '
        CorLabel.AutoSize = True
        CorLabel.Location = New System.Drawing.Point(12, 213)
        CorLabel.Name = "CorLabel"
        CorLabel.Size = New System.Drawing.Size(26, 13)
        CorLabel.TabIndex = 9
        CorLabel.Text = "Cor:"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Location = New System.Drawing.Point(12, 239)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(64, 13)
        FornecedorLabel.TabIndex = 11
        FornecedorLabel.Text = "Fornecedor:"
        '
        'Valor_porchapa_Label
        '
        Valor_porchapa_Label.AutoSize = True
        Valor_porchapa_Label.Location = New System.Drawing.Point(12, 265)
        Valor_porchapa_Label.Name = "Valor_porchapa_Label"
        Valor_porchapa_Label.Size = New System.Drawing.Size(92, 13)
        Valor_porchapa_Label.TabIndex = 13
        Valor_porchapa_Label.Text = "Valor (Por chapa):"
        '
        'MateriaisBindingNavigator
        '
        Me.MateriaisBindingNavigator.AddNewItem = Nothing
        Me.MateriaisBindingNavigator.BindingSource = Me.MateriaisBindingSource
        Me.MateriaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MateriaisBindingNavigator.DeleteItem = Nothing
        Me.MateriaisBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MateriaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.MateriaisBindingNavigator.Location = New System.Drawing.Point(0, 449)
        Me.MateriaisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MateriaisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MateriaisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MateriaisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MateriaisBindingNavigator.Name = "MateriaisBindingNavigator"
        Me.MateriaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MateriaisBindingNavigator.Size = New System.Drawing.Size(468, 25)
        Me.MateriaisBindingNavigator.TabIndex = 0
        Me.MateriaisBindingNavigator.Text = "BindingNavigator1"
        '
        'MateriaisBindingSource
        '
        Me.MateriaisBindingSource.DataMember = "Materiais"
        Me.MateriaisBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'CodChapaTextBox
        '
        Me.CodChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "CodChapa", True))
        Me.CodChapaTextBox.Location = New System.Drawing.Point(111, 132)
        Me.CodChapaTextBox.Name = "CodChapaTextBox"
        Me.CodChapaTextBox.Size = New System.Drawing.Size(337, 20)
        Me.CodChapaTextBox.TabIndex = 4
        '
        'NomeChapaTextBox
        '
        Me.NomeChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "NomeChapa", True))
        Me.NomeChapaTextBox.Location = New System.Drawing.Point(111, 158)
        Me.NomeChapaTextBox.Name = "NomeChapaTextBox"
        Me.NomeChapaTextBox.Size = New System.Drawing.Size(337, 20)
        Me.NomeChapaTextBox.TabIndex = 6
        '
        'ExpressuraTextBox
        '
        Me.ExpressuraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Expressura", True))
        Me.ExpressuraTextBox.Location = New System.Drawing.Point(111, 184)
        Me.ExpressuraTextBox.Name = "ExpressuraTextBox"
        Me.ExpressuraTextBox.Size = New System.Drawing.Size(337, 20)
        Me.ExpressuraTextBox.TabIndex = 8
        '
        'CorTextBox
        '
        Me.CorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Cor", True))
        Me.CorTextBox.Location = New System.Drawing.Point(111, 210)
        Me.CorTextBox.Name = "CorTextBox"
        Me.CorTextBox.Size = New System.Drawing.Size(337, 20)
        Me.CorTextBox.TabIndex = 10
        '
        'FornecedorTextBox
        '
        Me.FornecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Fornecedor", True))
        Me.FornecedorTextBox.Location = New System.Drawing.Point(111, 236)
        Me.FornecedorTextBox.Name = "FornecedorTextBox"
        Me.FornecedorTextBox.Size = New System.Drawing.Size(337, 20)
        Me.FornecedorTextBox.TabIndex = 12
        '
        'Valor_porchapa_TextBox
        '
        Me.Valor_porchapa_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Valor(porchapa)", True))
        Me.Valor_porchapa_TextBox.Location = New System.Drawing.Point(111, 262)
        Me.Valor_porchapa_TextBox.Name = "Valor_porchapa_TextBox"
        Me.Valor_porchapa_TextBox.Size = New System.Drawing.Size(337, 20)
        Me.Valor_porchapa_TextBox.TabIndex = 14
        '
        'FillByCodigoChapaToolStrip
        '
        Me.FillByCodigoChapaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodChapaToolStripLabel, Me.CodChapaToolStripTextBox, Me.FillByCodigoChapaToolStripButton})
        Me.FillByCodigoChapaToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByCodigoChapaToolStrip.Name = "FillByCodigoChapaToolStrip"
        Me.FillByCodigoChapaToolStrip.Size = New System.Drawing.Size(468, 25)
        Me.FillByCodigoChapaToolStrip.TabIndex = 15
        Me.FillByCodigoChapaToolStrip.Text = "FillByCodigoChapaToolStrip"
        '
        'CodChapaToolStripLabel
        '
        Me.CodChapaToolStripLabel.Name = "CodChapaToolStripLabel"
        Me.CodChapaToolStripLabel.Size = New System.Drawing.Size(102, 22)
        Me.CodChapaToolStripLabel.Text = "Codigo da Chapa:"
        '
        'CodChapaToolStripTextBox
        '
        Me.CodChapaToolStripTextBox.Name = "CodChapaToolStripTextBox"
        Me.CodChapaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByCodigoChapaToolStripButton
        '
        Me.FillByCodigoChapaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByCodigoChapaToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByCodigoChapaToolStripButton.Name = "FillByCodigoChapaToolStripButton"
        Me.FillByCodigoChapaToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillByCodigoChapaToolStripButton.Text = "Filtrar"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeChapaToolStripLabel, Me.NomeChapaToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(468, 25)
        Me.FillBy1ToolStrip.TabIndex = 16
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'NomeChapaToolStripLabel
        '
        Me.NomeChapaToolStripLabel.Name = "NomeChapaToolStripLabel"
        Me.NomeChapaToolStripLabel.Size = New System.Drawing.Size(96, 22)
        Me.NomeChapaToolStripLabel.Text = "Nome da Chapa:"
        '
        'NomeChapaToolStripTextBox
        '
        Me.NomeChapaToolStripTextBox.Name = "NomeChapaToolStripTextBox"
        Me.NomeChapaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillBy1ToolStripButton.Text = "Filtrar"
        '
        'FillByCorToolStrip
        '
        Me.FillByCorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CorToolStripLabel, Me.CorToolStripTextBox, Me.FillByCorToolStripButton})
        Me.FillByCorToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillByCorToolStrip.Name = "FillByCorToolStrip"
        Me.FillByCorToolStrip.Size = New System.Drawing.Size(468, 25)
        Me.FillByCorToolStrip.TabIndex = 17
        Me.FillByCorToolStrip.Text = "FillByCorToolStrip"
        '
        'CorToolStripLabel
        '
        Me.CorToolStripLabel.Name = "CorToolStripLabel"
        Me.CorToolStripLabel.Size = New System.Drawing.Size(29, 22)
        Me.CorToolStripLabel.Text = "Cor:"
        '
        'CorToolStripTextBox
        '
        Me.CorToolStripTextBox.Name = "CorToolStripTextBox"
        Me.CorToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByCorToolStripButton
        '
        Me.FillByCorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByCorToolStripButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FillByCorToolStripButton.Name = "FillByCorToolStripButton"
        Me.FillByCorToolStripButton.Size = New System.Drawing.Size(42, 22)
        Me.FillByCorToolStripButton.Text = "Filtrar"
        '
        'MateriaisTableAdapter
        '
        Me.MateriaisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Me.MateriaisTableAdapter
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'FillByAllToolStrip
        '
        Me.FillByAllToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FillByAllToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByAllToolStripButton})
        Me.FillByAllToolStrip.Location = New System.Drawing.Point(0, 424)
        Me.FillByAllToolStrip.Name = "FillByAllToolStrip"
        Me.FillByAllToolStrip.Size = New System.Drawing.Size(468, 25)
        Me.FillByAllToolStrip.TabIndex = 18
        Me.FillByAllToolStrip.Text = "FillByAllToolStrip"
        '
        'FillByAllToolStripButton
        '
        Me.FillByAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByAllToolStripButton.Name = "FillByAllToolStripButton"
        Me.FillByAllToolStripButton.Size = New System.Drawing.Size(88, 22)
        Me.FillByAllToolStripButton.Text = "Mostrar Todos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(236, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'EditarMaterialIndividual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 474)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FillByAllToolStrip)
        Me.Controls.Add(Me.FillByCorToolStrip)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillByCodigoChapaToolStrip)
        Me.Controls.Add(CodChapaLabel)
        Me.Controls.Add(Me.CodChapaTextBox)
        Me.Controls.Add(NomeChapaLabel)
        Me.Controls.Add(Me.NomeChapaTextBox)
        Me.Controls.Add(ExpressuraLabel)
        Me.Controls.Add(Me.ExpressuraTextBox)
        Me.Controls.Add(CorLabel)
        Me.Controls.Add(Me.CorTextBox)
        Me.Controls.Add(FornecedorLabel)
        Me.Controls.Add(Me.FornecedorTextBox)
        Me.Controls.Add(Valor_porchapa_Label)
        Me.Controls.Add(Me.Valor_porchapa_TextBox)
        Me.Controls.Add(Me.MateriaisBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarMaterialIndividual"
        Me.Text = "Consulta de Materiais"
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MateriaisBindingNavigator.ResumeLayout(False)
        Me.MateriaisBindingNavigator.PerformLayout()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCodigoChapaToolStrip.ResumeLayout(False)
        Me.FillByCodigoChapaToolStrip.PerformLayout()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.FillByCorToolStrip.ResumeLayout(False)
        Me.FillByCorToolStrip.PerformLayout()
        Me.FillByAllToolStrip.ResumeLayout(False)
        Me.FillByAllToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents MateriaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriaisTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MateriaisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpressuraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornecedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valor_porchapa_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillByCodigoChapaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CodChapaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodChapaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByCodigoChapaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NomeChapaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeChapaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByCorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CorToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByCorToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByAllToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByAllToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
