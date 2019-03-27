<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stk_Saida
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stk_Saida))
        Me.EstoqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstoqueTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.EstoqueTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.EstoqueConsultapornomeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NomeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NomeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.EstoqueConsultapornomeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ESTOQUESelecionartodosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ESTOQUESelecionartodosToolStripButton = New System.Windows.Forms.ToolStripButton()
        CodigoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoqueBindingNavigator.SuspendLayout()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoqueConsultapornomeToolStrip.SuspendLayout()
        Me.ESTOQUESelecionartodosToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(17, 69)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(43, 13)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(17, 95)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(17, 121)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(91, 13)
        QuantidadeLabel.TabIndex = 5
        QuantidadeLabel.Text = "Quantidade atual:"
        '
        'EstoqueBindingNavigator
        '
        Me.EstoqueBindingNavigator.AddNewItem = Nothing
        Me.EstoqueBindingNavigator.BindingSource = Me.EstoqueBindingSource
        Me.EstoqueBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstoqueBindingNavigator.DeleteItem = Nothing
        Me.EstoqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1})
        Me.EstoqueBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstoqueBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstoqueBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstoqueBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstoqueBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstoqueBindingNavigator.Name = "EstoqueBindingNavigator"
        Me.EstoqueBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstoqueBindingNavigator.Size = New System.Drawing.Size(427, 25)
        Me.EstoqueBindingNavigator.TabIndex = 0
        Me.EstoqueBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(118, 22)
        Me.ToolStripButton1.Text = "Entrada de produtos"
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(96, 66)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.ReadOnly = True
        Me.CodigoTextBox.Size = New System.Drawing.Size(303, 20)
        Me.CodigoTextBox.TabIndex = 2
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(96, 92)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(303, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Quantidade", True))
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(114, 118)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.ReadOnly = True
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(285, 20)
        Me.QuantidadeTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Digite a quantidade"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Retirar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 274)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Saida de produtos no estoque"
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
        'EstoqueConsultapornomeToolStrip
        '
        Me.EstoqueConsultapornomeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeToolStripLabel, Me.NomeToolStripTextBox, Me.EstoqueConsultapornomeToolStripButton})
        Me.EstoqueConsultapornomeToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.EstoqueConsultapornomeToolStrip.Name = "EstoqueConsultapornomeToolStrip"
        Me.EstoqueConsultapornomeToolStrip.Size = New System.Drawing.Size(427, 25)
        Me.EstoqueConsultapornomeToolStrip.TabIndex = 15
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
        'ESTOQUESelecionartodosToolStrip
        '
        Me.ESTOQUESelecionartodosToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ESTOQUESelecionartodosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ESTOQUESelecionartodosToolStripButton})
        Me.ESTOQUESelecionartodosToolStrip.Location = New System.Drawing.Point(0, 328)
        Me.ESTOQUESelecionartodosToolStrip.Name = "ESTOQUESelecionartodosToolStrip"
        Me.ESTOQUESelecionartodosToolStrip.Size = New System.Drawing.Size(427, 25)
        Me.ESTOQUESelecionartodosToolStrip.TabIndex = 16
        Me.ESTOQUESelecionartodosToolStrip.Text = "ESTOQUESelecionartodosToolStrip"
        '
        'ESTOQUESelecionartodosToolStripButton
        '
        Me.ESTOQUESelecionartodosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ESTOQUESelecionartodosToolStripButton.Name = "ESTOQUESelecionartodosToolStripButton"
        Me.ESTOQUESelecionartodosToolStripButton.Size = New System.Drawing.Size(91, 22)
        Me.ESTOQUESelecionartodosToolStripButton.Text = "Reiniciar Filtros"
        '
        'Stk_Saida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 353)
        Me.Controls.Add(Me.ESTOQUESelecionartodosToolStrip)
        Me.Controls.Add(Me.EstoqueConsultapornomeToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.QuantidadeTextBox)
        Me.Controls.Add(Me.EstoqueBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stk_Saida"
        Me.Text = "Saida do estoque"
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoqueBindingNavigator.ResumeLayout(False)
        Me.EstoqueBindingNavigator.PerformLayout()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoqueConsultapornomeToolStrip.ResumeLayout(False)
        Me.EstoqueConsultapornomeToolStrip.PerformLayout()
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
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents EstoqueConsultapornomeToolStrip As ToolStrip
    Friend WithEvents NomeToolStripLabel As ToolStripLabel
    Friend WithEvents NomeToolStripTextBox As ToolStripTextBox
    Friend WithEvents EstoqueConsultapornomeToolStripButton As ToolStripButton
    Friend WithEvents ESTOQUESelecionartodosToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ESTOQUESelecionartodosToolStripButton As System.Windows.Forms.ToolStripButton
End Class
