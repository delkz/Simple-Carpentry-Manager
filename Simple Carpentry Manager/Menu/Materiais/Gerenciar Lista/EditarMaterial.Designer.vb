<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarMaterial))
        Me.MateriaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.MateriaisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodChapaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeChapaTextBox = New System.Windows.Forms.TextBox()
        Me.ExpressuraTextBox = New System.Windows.Forms.TextBox()
        Me.CorTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_porchapa_TextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.MateriaisTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodChapaLabel
        '
        CodChapaLabel.AutoSize = True
        CodChapaLabel.Location = New System.Drawing.Point(12, 107)
        CodChapaLabel.Name = "CodChapaLabel"
        CodChapaLabel.Size = New System.Drawing.Size(92, 13)
        CodChapaLabel.TabIndex = 3
        CodChapaLabel.Text = "Codigo da Chapa:"
        '
        'NomeChapaLabel
        '
        NomeChapaLabel.AutoSize = True
        NomeChapaLabel.Location = New System.Drawing.Point(12, 133)
        NomeChapaLabel.Name = "NomeChapaLabel"
        NomeChapaLabel.Size = New System.Drawing.Size(72, 13)
        NomeChapaLabel.TabIndex = 5
        NomeChapaLabel.Text = "Nome Chapa:"
        '
        'ExpressuraLabel
        '
        ExpressuraLabel.AutoSize = True
        ExpressuraLabel.Location = New System.Drawing.Point(12, 159)
        ExpressuraLabel.Name = "ExpressuraLabel"
        ExpressuraLabel.Size = New System.Drawing.Size(62, 13)
        ExpressuraLabel.TabIndex = 7
        ExpressuraLabel.Text = "Dimensões:"
        '
        'CorLabel
        '
        CorLabel.AutoSize = True
        CorLabel.Location = New System.Drawing.Point(12, 187)
        CorLabel.Name = "CorLabel"
        CorLabel.Size = New System.Drawing.Size(26, 13)
        CorLabel.TabIndex = 9
        CorLabel.Text = "Cor:"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Location = New System.Drawing.Point(12, 213)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(64, 13)
        FornecedorLabel.TabIndex = 11
        FornecedorLabel.Text = "Fornecedor:"
        '
        'Valor_porchapa_Label
        '
        Valor_porchapa_Label.AutoSize = True
        Valor_porchapa_Label.Location = New System.Drawing.Point(12, 237)
        Valor_porchapa_Label.Name = "Valor_porchapa_Label"
        Valor_porchapa_Label.Size = New System.Drawing.Size(91, 13)
        Valor_porchapa_Label.TabIndex = 13
        Valor_porchapa_Label.Text = "Valor (por chapa):"
        '
        'MateriaisBindingNavigator
        '
        Me.MateriaisBindingNavigator.AddNewItem = Nothing
        Me.MateriaisBindingNavigator.BindingSource = Me.MateriaisBindingSource
        Me.MateriaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MateriaisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MateriaisBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MateriaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.MateriaisBindingNavigatorSaveItem})
        Me.MateriaisBindingNavigator.Location = New System.Drawing.Point(0, 449)
        Me.MateriaisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MateriaisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MateriaisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MateriaisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MateriaisBindingNavigator.Name = "MateriaisBindingNavigator"
        Me.MateriaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MateriaisBindingNavigator.Size = New System.Drawing.Size(460, 25)
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
        'MateriaisBindingNavigatorSaveItem
        '
        Me.MateriaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MateriaisBindingNavigatorSaveItem.Image = CType(resources.GetObject("MateriaisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MateriaisBindingNavigatorSaveItem.Name = "MateriaisBindingNavigatorSaveItem"
        Me.MateriaisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MateriaisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodChapaTextBox
        '
        Me.CodChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "CodChapa", True))
        Me.CodChapaTextBox.Location = New System.Drawing.Point(112, 102)
        Me.CodChapaTextBox.Name = "CodChapaTextBox"
        Me.CodChapaTextBox.Size = New System.Drawing.Size(330, 20)
        Me.CodChapaTextBox.TabIndex = 4
        '
        'NomeChapaTextBox
        '
        Me.NomeChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "NomeChapa", True))
        Me.NomeChapaTextBox.Location = New System.Drawing.Point(112, 131)
        Me.NomeChapaTextBox.Name = "NomeChapaTextBox"
        Me.NomeChapaTextBox.Size = New System.Drawing.Size(330, 20)
        Me.NomeChapaTextBox.TabIndex = 6
        '
        'ExpressuraTextBox
        '
        Me.ExpressuraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Expressura", True))
        Me.ExpressuraTextBox.Location = New System.Drawing.Point(112, 157)
        Me.ExpressuraTextBox.Name = "ExpressuraTextBox"
        Me.ExpressuraTextBox.Size = New System.Drawing.Size(330, 20)
        Me.ExpressuraTextBox.TabIndex = 8
        '
        'CorTextBox
        '
        Me.CorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Cor", True))
        Me.CorTextBox.Location = New System.Drawing.Point(112, 183)
        Me.CorTextBox.Name = "CorTextBox"
        Me.CorTextBox.Size = New System.Drawing.Size(330, 20)
        Me.CorTextBox.TabIndex = 10
        '
        'FornecedorTextBox
        '
        Me.FornecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Fornecedor", True))
        Me.FornecedorTextBox.Location = New System.Drawing.Point(112, 209)
        Me.FornecedorTextBox.Name = "FornecedorTextBox"
        Me.FornecedorTextBox.Size = New System.Drawing.Size(330, 20)
        Me.FornecedorTextBox.TabIndex = 12
        '
        'Valor_porchapa_TextBox
        '
        Me.Valor_porchapa_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Valor(porchapa)", True))
        Me.Valor_porchapa_TextBox.Location = New System.Drawing.Point(112, 235)
        Me.Valor_porchapa_TextBox.Name = "Valor_porchapa_TextBox"
        Me.Valor_porchapa_TextBox.Size = New System.Drawing.Size(330, 20)
        Me.Valor_porchapa_TextBox.TabIndex = 14
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.ToolStripTextBox2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(460, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(97, 22)
        Me.ToolStripLabel1.Text = "Codigo da chapa"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel2.Text = "Nome da Chapa"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.ToolStripTextBox3, Me.ToolStripSeparator2, Me.ToolStripLabel4, Me.ToolStripTextBox4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(460, 25)
        Me.ToolStrip2.TabIndex = 16
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(26, 22)
        Me.ToolStripLabel3.Text = "Cor"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel4.Text = "Dimensões"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 25)
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(287, 367)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Os dados nessa tela podem ser editados ou apagados permanentemente, Cuidado"
        '
        'EditarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 474)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
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
        Me.Name = "EditarMaterial"
        Me.Text = "Editar Materiais"
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MateriaisBindingNavigator.ResumeLayout(False)
        Me.MateriaisBindingNavigator.PerformLayout()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MateriaisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpressuraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornecedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valor_porchapa_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
