<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stk_GridView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stk_GridView))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.EstoquePesquisaPorCodigoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstoquePesquisaPorCodigoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EstoqueConsultapornomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstoqueConsultapornomeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EstoqueTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.EstoqueTableAdapter()
        Me.ESTOQUESelecionartodosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ESTOQUESelecionartodosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornecedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoquePesquisaPorCodigoToolStrip.SuspendLayout()
        Me.EstoqueConsultapornomeToolStrip.SuspendLayout()
        Me.ESTOQUESelecionartodosToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.QuantidadeDataGridViewTextBoxColumn, Me.FornecedorDataGridViewTextBoxColumn, Me.Valor})
        Me.DataGridView1.DataSource = Me.EstoqueBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(855, 676)
        Me.DataGridView1.TabIndex = 0
        '
        'EstoqueBindingSource
        '
        Me.EstoqueBindingSource.DataMember = "Estoque"
        Me.EstoqueBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstoquePesquisaPorCodigoToolStrip
        '
        Me.EstoquePesquisaPorCodigoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodigoToolStripLabel, Me.CodigoToolStripTextBox, Me.EstoquePesquisaPorCodigoToolStripButton})
        Me.EstoquePesquisaPorCodigoToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.EstoquePesquisaPorCodigoToolStrip.Name = "EstoquePesquisaPorCodigoToolStrip"
        Me.EstoquePesquisaPorCodigoToolStrip.Size = New System.Drawing.Size(855, 25)
        Me.EstoquePesquisaPorCodigoToolStrip.TabIndex = 1
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
        Me.EstoquePesquisaPorCodigoToolStripButton.Name = "EstoquePesquisaPorCodigoToolStripButton"
        Me.EstoquePesquisaPorCodigoToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.EstoquePesquisaPorCodigoToolStripButton.Text = "Pesquisar"
        '
        'EstoqueConsultapornomeToolStrip
        '
        Me.EstoqueConsultapornomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.EstoqueConsultapornomeToolStripButton})
        Me.EstoqueConsultapornomeToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.EstoqueConsultapornomeToolStrip.Name = "EstoqueConsultapornomeToolStrip"
        Me.EstoqueConsultapornomeToolStrip.Size = New System.Drawing.Size(855, 25)
        Me.EstoqueConsultapornomeToolStrip.TabIndex = 2
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
        Me.EstoqueConsultapornomeToolStripButton.Name = "EstoqueConsultapornomeToolStripButton"
        Me.EstoqueConsultapornomeToolStripButton.Size = New System.Drawing.Size(61, 22)
        Me.EstoqueConsultapornomeToolStripButton.Text = "Pesquisar"
        '
        'EstoqueTableAdapter
        '
        Me.EstoqueTableAdapter.ClearBeforeFill = True
        '
        'ESTOQUESelecionartodosToolStrip
        '
        Me.ESTOQUESelecionartodosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTOQUESelecionartodosToolStripButton})
        Me.ESTOQUESelecionartodosToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.ESTOQUESelecionartodosToolStrip.Name = "ESTOQUESelecionartodosToolStrip"
        Me.ESTOQUESelecionartodosToolStrip.Size = New System.Drawing.Size(855, 25)
        Me.ESTOQUESelecionartodosToolStrip.TabIndex = 4
        Me.ESTOQUESelecionartodosToolStrip.Text = "ESTOQUESelecionartodosToolStrip"
        '
        'ESTOQUESelecionartodosToolStripButton
        '
        Me.ESTOQUESelecionartodosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ESTOQUESelecionartodosToolStripButton.Name = "ESTOQUESelecionartodosToolStripButton"
        Me.ESTOQUESelecionartodosToolStripButton.Size = New System.Drawing.Size(91, 22)
        Me.ESTOQUESelecionartodosToolStripButton.Text = "Reiniciar Filtros"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 676)
        Me.Panel1.TabIndex = 5
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantidadeDataGridViewTextBoxColumn
        '
        Me.QuantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade"
        Me.QuantidadeDataGridViewTextBoxColumn.Name = "QuantidadeDataGridViewTextBoxColumn"
        Me.QuantidadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FornecedorDataGridViewTextBoxColumn
        '
        Me.FornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor"
        Me.FornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor"
        Me.FornecedorDataGridViewTextBoxColumn.Name = "FornecedorDataGridViewTextBoxColumn"
        Me.FornecedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "Valor"
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'Stk_GridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 751)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ESTOQUESelecionartodosToolStrip)
        Me.Controls.Add(Me.EstoqueConsultapornomeToolStrip)
        Me.Controls.Add(Me.EstoquePesquisaPorCodigoToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stk_GridView"
        Me.Text = "Tabela de controle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoquePesquisaPorCodigoToolStrip.ResumeLayout(False)
        Me.EstoquePesquisaPorCodigoToolStrip.PerformLayout()
        Me.EstoqueConsultapornomeToolStrip.ResumeLayout(False)
        Me.EstoqueConsultapornomeToolStrip.PerformLayout()
        Me.ESTOQUESelecionartodosToolStrip.ResumeLayout(False)
        Me.ESTOQUESelecionartodosToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents EstoqueBindingSource As BindingSource
    Friend WithEvents EstoqueTableAdapter As MarcenariaDataSetTableAdapters.EstoqueTableAdapter
    Friend WithEvents EstoquePesquisaPorCodigoToolStrip As ToolStrip
    Friend WithEvents CodigoToolStripLabel As ToolStripLabel
    Friend WithEvents CodigoToolStripTextBox As ToolStripTextBox
    Friend WithEvents EstoqueConsultapornomeToolStrip As ToolStrip
    Friend WithEvents NomeToolStripLabel As ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As ToolStripTextBox
    Friend WithEvents EstoquePesquisaPorCodigoToolStripButton As ToolStripButton
    Friend WithEvents EstoqueConsultapornomeToolStripButton As ToolStripButton
    Friend WithEvents ESTOQUESelecionartodosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ESTOQUESelecionartodosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FornecedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
End Class
