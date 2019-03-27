<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stk_ProdutosNovo
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim FornecedorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stk_ProdutosNovo))
        Dim ValorLabel As System.Windows.Forms.Label
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.EstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoqueTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.EstoqueTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.EstoqueBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstoqueBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        FornecedorLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstoqueBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(11, 71)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(42, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome*:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(11, 97)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(69, 13)
        QuantidadeLabel.TabIndex = 5
        QuantidadeLabel.Text = "Quantidade*:"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Location = New System.Drawing.Point(11, 123)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(64, 13)
        FornecedorLabel.TabIndex = 7
        FornecedorLabel.Text = "Fornecedor:"
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
        Me.EstoqueBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstoqueBindingNavigator.BindingSource = Me.EstoqueBindingSource
        Me.EstoqueBindingNavigator.CountItem = Nothing
        Me.EstoqueBindingNavigator.DeleteItem = Nothing
        Me.EstoqueBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.EstoqueBindingNavigatorSaveItem})
        Me.EstoqueBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstoqueBindingNavigator.MoveFirstItem = Nothing
        Me.EstoqueBindingNavigator.MoveLastItem = Nothing
        Me.EstoqueBindingNavigator.MoveNextItem = Nothing
        Me.EstoqueBindingNavigator.MovePreviousItem = Nothing
        Me.EstoqueBindingNavigator.Name = "EstoqueBindingNavigator"
        Me.EstoqueBindingNavigator.PositionItem = Nothing
        Me.EstoqueBindingNavigator.Size = New System.Drawing.Size(580, 25)
        Me.EstoqueBindingNavigator.TabIndex = 0
        Me.EstoqueBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(108, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'EstoqueBindingNavigatorSaveItem
        '
        Me.EstoqueBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstoqueBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstoqueBindingNavigatorSaveItem.Name = "EstoqueBindingNavigatorSaveItem"
        Me.EstoqueBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 22)
        Me.EstoqueBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(90, 68)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(462, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Quantidade", True))
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(90, 94)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(462, 20)
        Me.QuantidadeTextBox.TabIndex = 6
        '
        'FornecedorTextBox
        '
        Me.FornecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Fornecedor", True))
        Me.FornecedorTextBox.Location = New System.Drawing.Point(90, 120)
        Me.FornecedorTextBox.Name = "FornecedorTextBox"
        Me.FornecedorTextBox.Size = New System.Drawing.Size(462, 20)
        Me.FornecedorTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.StockManagerLogo
        Me.PictureBox1.Location = New System.Drawing.Point(420, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "*Campos Obrigatorios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Registro de novo produto"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(11, 153)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(34, 13)
        ValorLabel.TabIndex = 26
        ValorLabel.Text = "Valor:"
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstoqueBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(90, 146)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(462, 20)
        Me.ValorTextBox.TabIndex = 27
        '
        'Stk_ProdutosNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 343)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.QuantidadeTextBox)
        Me.Controls.Add(FornecedorLabel)
        Me.Controls.Add(Me.FornecedorTextBox)
        Me.Controls.Add(Me.EstoqueBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stk_ProdutosNovo"
        Me.Text = "Novo Produto"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstoqueBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstoqueBindingNavigator.ResumeLayout(False)
        Me.EstoqueBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents EstoqueBindingSource As BindingSource
    Friend WithEvents EstoqueTableAdapter As MarcenariaDataSetTableAdapters.EstoqueTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstoqueBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EstoqueBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents FornecedorTextBox As TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ValorTextBox As TextBox
End Class
