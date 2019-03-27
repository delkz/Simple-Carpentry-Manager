<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarMateriaisGeral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarMateriaisGeral))
        Me.MateriaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.MateriaisDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByCodigoChapaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodChapaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodChapaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeChapaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeChapaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FillByCorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DimensoesToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CorToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CorToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MateriaisTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MateriaisBindingNavigator.SuspendLayout()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaisDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCodigoChapaToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FillByCorToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MateriaisBindingNavigator
        '
        Me.MateriaisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MateriaisBindingNavigator.BindingSource = Me.MateriaisBindingSource
        Me.MateriaisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MateriaisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MateriaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MateriaisBindingNavigatorSaveItem})
        Me.MateriaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MateriaisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MateriaisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MateriaisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MateriaisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MateriaisBindingNavigator.Name = "MateriaisBindingNavigator"
        Me.MateriaisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MateriaisBindingNavigator.Size = New System.Drawing.Size(567, 25)
        Me.MateriaisBindingNavigator.TabIndex = 0
        Me.MateriaisBindingNavigator.Text = "BindingNavigator1"
        Me.MateriaisBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'MateriaisDataGridView
        '
        Me.MateriaisDataGridView.AllowUserToAddRows = False
        Me.MateriaisDataGridView.AllowUserToDeleteRows = False
        Me.MateriaisDataGridView.AutoGenerateColumns = False
        Me.MateriaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MateriaisDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.MateriaisDataGridView.DataSource = Me.MateriaisBindingSource
        Me.MateriaisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MateriaisDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MateriaisDataGridView.Name = "MateriaisDataGridView"
        Me.MateriaisDataGridView.ReadOnly = True
        Me.MateriaisDataGridView.Size = New System.Drawing.Size(804, 546)
        Me.MateriaisDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CodigoInterno"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoInterno"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodChapa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomeChapa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome Chapa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Expressura"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dimensões"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fornecedor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fornecedor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Valor(porchapa)"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Valor (Por Chapa)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'FillByCodigoChapaToolStrip
        '
        Me.FillByCodigoChapaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodChapaToolStripLabel, Me.CodChapaToolStripTextBox, Me.ToolStripSeparator1, Me.NomeChapaToolStripLabel, Me.NomeChapaToolStripTextBox, Me.ToolStripSeparator3})
        Me.FillByCodigoChapaToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByCodigoChapaToolStrip.Name = "FillByCodigoChapaToolStrip"
        Me.FillByCodigoChapaToolStrip.Size = New System.Drawing.Size(804, 25)
        Me.FillByCodigoChapaToolStrip.TabIndex = 2
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
        Me.CodChapaToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodChapaToolStripTextBox.Name = "CodChapaToolStripTextBox"
        Me.CodChapaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NomeChapaToolStripLabel
        '
        Me.NomeChapaToolStripLabel.Name = "NomeChapaToolStripLabel"
        Me.NomeChapaToolStripLabel.Size = New System.Drawing.Size(96, 22)
        Me.NomeChapaToolStripLabel.Text = "Nome da Chapa:"
        '
        'NomeChapaToolStripTextBox
        '
        Me.NomeChapaToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeChapaToolStripTextBox.Name = "NomeChapaToolStripTextBox"
        Me.NomeChapaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MateriaisDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 546)
        Me.Panel1.TabIndex = 6
        '
        'FillByCorToolStrip
        '
        Me.FillByCorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.DimensoesToolStripTextBox1, Me.ToolStripSeparator4, Me.CorToolStripLabel, Me.CorToolStripTextBox, Me.ToolStripSeparator2})
        Me.FillByCorToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByCorToolStrip.Name = "FillByCorToolStrip"
        Me.FillByCorToolStrip.Size = New System.Drawing.Size(804, 25)
        Me.FillByCorToolStrip.TabIndex = 3
        Me.FillByCorToolStrip.Text = "FillByCorToolStrip"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel1.Text = "Dimensões: "
        '
        'DimensoesToolStripTextBox1
        '
        Me.DimensoesToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DimensoesToolStripTextBox1.Name = "DimensoesToolStripTextBox1"
        Me.DimensoesToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'CorToolStripLabel
        '
        Me.CorToolStripLabel.Name = "CorToolStripLabel"
        Me.CorToolStripLabel.Size = New System.Drawing.Size(29, 22)
        Me.CorToolStripLabel.Text = "Cor:"
        '
        'CorToolStripTextBox
        '
        Me.CorToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CorToolStripTextBox.Name = "CorToolStripTextBox"
        Me.CorToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(676, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MateriaisTableAdapter
        '
        Me.MateriaisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.EstoqueTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Me.MateriaisTableAdapter
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'EditarMateriaisGeral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 596)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FillByCorToolStrip)
        Me.Controls.Add(Me.FillByCodigoChapaToolStrip)
        Me.Controls.Add(Me.MateriaisBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditarMateriaisGeral"
        Me.Text = "Consulta de Materiais"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MateriaisBindingNavigator.ResumeLayout(False)
        Me.MateriaisBindingNavigator.PerformLayout()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaisDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCodigoChapaToolStrip.ResumeLayout(False)
        Me.FillByCodigoChapaToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FillByCorToolStrip.ResumeLayout(False)
        Me.FillByCorToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents MateriaisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MateriaisTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MateriaisBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents MateriaisDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByCodigoChapaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CodChapaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodChapaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FillByCorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CorToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NomeChapaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomeChapaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DimensoesToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
