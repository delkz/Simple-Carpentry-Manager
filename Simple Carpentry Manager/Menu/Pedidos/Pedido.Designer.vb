<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedido
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
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim DetalhesLabel As System.Windows.Forms.Label
        Dim DataPedidoLabel As System.Windows.Forms.Label
        Dim FormaPagamentoLabel As System.Windows.Forms.Label
        Dim EstimativaEntregaLabel As System.Windows.Forms.Label
        Dim EnderecoEntregaLabel As System.Windows.Forms.Label
        Dim SituaçãoLabel As System.Windows.Forms.Label
        Dim EntregueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedido))
        Me.PedidoTabelaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PedidoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PedidoTabelaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.DetalhesTextBox = New System.Windows.Forms.TextBox()
        Me.DataPedidoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PedidoTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.FormaPagamentoTextBox = New System.Windows.Forms.TextBox()
        Me.EstimativaEntregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EnderecoEntregaTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SituaçãoTextBox = New System.Windows.Forms.TextBox()
        Me.EntregueCheckBox = New System.Windows.Forms.CheckBox()
        ClienteLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        DetalhesLabel = New System.Windows.Forms.Label()
        DataPedidoLabel = New System.Windows.Forms.Label()
        FormaPagamentoLabel = New System.Windows.Forms.Label()
        EstimativaEntregaLabel = New System.Windows.Forms.Label()
        EnderecoEntregaLabel = New System.Windows.Forms.Label()
        SituaçãoLabel = New System.Windows.Forms.Label()
        EntregueLabel = New System.Windows.Forms.Label()
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidoTabelaBindingNavigator.SuspendLayout()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(6, 71)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(46, 13)
        ClienteLabel.TabIndex = 3
        ClienteLabel.Text = "Cliente*:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(6, 121)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(51, 13)
        ValorLabel.TabIndex = 5
        ValorLabel.Text = "Valor R$:"
        '
        'DetalhesLabel
        '
        DetalhesLabel.AutoSize = True
        DetalhesLabel.Location = New System.Drawing.Point(6, 170)
        DetalhesLabel.Name = "DetalhesLabel"
        DetalhesLabel.Size = New System.Drawing.Size(52, 13)
        DetalhesLabel.TabIndex = 7
        DetalhesLabel.Text = "Detalhes:"
        '
        'DataPedidoLabel
        '
        DataPedidoLabel.AutoSize = True
        DataPedidoLabel.Location = New System.Drawing.Point(6, 350)
        DataPedidoLabel.Name = "DataPedidoLabel"
        DataPedidoLabel.Size = New System.Drawing.Size(86, 13)
        DataPedidoLabel.TabIndex = 9
        DataPedidoLabel.Text = "Data Do Pedido:"
        '
        'FormaPagamentoLabel
        '
        FormaPagamentoLabel.AutoSize = True
        FormaPagamentoLabel.Location = New System.Drawing.Point(6, 148)
        FormaPagamentoLabel.Name = "FormaPagamentoLabel"
        FormaPagamentoLabel.Size = New System.Drawing.Size(96, 13)
        FormaPagamentoLabel.TabIndex = 16
        FormaPagamentoLabel.Text = "Forma Pagamento:"
        '
        'EstimativaEntregaLabel
        '
        EstimativaEntregaLabel.AutoSize = True
        EstimativaEntregaLabel.Location = New System.Drawing.Point(6, 376)
        EstimativaEntregaLabel.Name = "EstimativaEntregaLabel"
        EstimativaEntregaLabel.Size = New System.Drawing.Size(98, 13)
        EstimativaEntregaLabel.TabIndex = 17
        EstimativaEntregaLabel.Text = "Estimativa Entrega:"
        '
        'EnderecoEntregaLabel
        '
        EnderecoEntregaLabel.AutoSize = True
        EnderecoEntregaLabel.Location = New System.Drawing.Point(6, 96)
        EnderecoEntregaLabel.Name = "EnderecoEntregaLabel"
        EnderecoEntregaLabel.Size = New System.Drawing.Size(96, 13)
        EnderecoEntregaLabel.TabIndex = 17
        EnderecoEntregaLabel.Text = "Endereço Entrega:"
        '
        'SituaçãoLabel
        '
        SituaçãoLabel.AutoSize = True
        SituaçãoLabel.Location = New System.Drawing.Point(6, 405)
        SituaçãoLabel.Name = "SituaçãoLabel"
        SituaçãoLabel.Size = New System.Drawing.Size(52, 13)
        SituaçãoLabel.TabIndex = 25
        SituaçãoLabel.Text = "Situação:"
        AddHandler SituaçãoLabel.Click, AddressOf Me.SituaçãoLabel_Click
        '
        'EntregueLabel
        '
        EntregueLabel.AutoSize = True
        EntregueLabel.Location = New System.Drawing.Point(6, 438)
        EntregueLabel.Name = "EntregueLabel"
        EntregueLabel.Size = New System.Drawing.Size(53, 13)
        EntregueLabel.TabIndex = 26
        EntregueLabel.Text = "Entregue:"
        '
        'PedidoTabelaBindingNavigator
        '
        Me.PedidoTabelaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PedidoTabelaBindingNavigator.BindingSource = Me.PedidoTabelaBindingSource
        Me.PedidoTabelaBindingNavigator.CountItem = Nothing
        Me.PedidoTabelaBindingNavigator.DeleteItem = Nothing
        Me.PedidoTabelaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.PedidoTabelaBindingNavigatorSaveItem})
        Me.PedidoTabelaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PedidoTabelaBindingNavigator.MoveFirstItem = Nothing
        Me.PedidoTabelaBindingNavigator.MoveLastItem = Nothing
        Me.PedidoTabelaBindingNavigator.MoveNextItem = Nothing
        Me.PedidoTabelaBindingNavigator.MovePreviousItem = Nothing
        Me.PedidoTabelaBindingNavigator.Name = "PedidoTabelaBindingNavigator"
        Me.PedidoTabelaBindingNavigator.PositionItem = Nothing
        Me.PedidoTabelaBindingNavigator.Size = New System.Drawing.Size(495, 25)
        Me.PedidoTabelaBindingNavigator.TabIndex = 0
        Me.PedidoTabelaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(108, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PedidoTabelaBindingNavigatorSaveItem
        '
        Me.PedidoTabelaBindingNavigatorSaveItem.Enabled = False
        Me.PedidoTabelaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidoTabelaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidoTabelaBindingNavigatorSaveItem.Name = "PedidoTabelaBindingNavigatorSaveItem"
        Me.PedidoTabelaBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 22)
        Me.PedidoTabelaBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(108, 118)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(321, 20)
        Me.ValorTextBox.TabIndex = 3
        '
        'DetalhesTextBox
        '
        Me.DetalhesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Detalhes", True))
        Me.DetalhesTextBox.Location = New System.Drawing.Point(108, 174)
        Me.DetalhesTextBox.Multiline = True
        Me.DetalhesTextBox.Name = "DetalhesTextBox"
        Me.DetalhesTextBox.Size = New System.Drawing.Size(321, 167)
        Me.DetalhesTextBox.TabIndex = 5
        '
        'DataPedidoDateTimePicker
        '
        Me.DataPedidoDateTimePicker.Checked = False
        Me.DataPedidoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoTabelaBindingSource, "DataPedido", True))
        Me.DataPedidoDateTimePicker.Location = New System.Drawing.Point(108, 347)
        Me.DataPedidoDateTimePicker.Name = "DataPedidoDateTimePicker"
        Me.DataPedidoDateTimePicker.Size = New System.Drawing.Size(321, 20)
        Me.DataPedidoDateTimePicker.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 510)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "*Campos Obrigatorios"
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
        'FormaPagamentoTextBox
        '
        Me.FormaPagamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "FormaPagamento", True))
        Me.FormaPagamentoTextBox.Location = New System.Drawing.Point(108, 145)
        Me.FormaPagamentoTextBox.Name = "FormaPagamentoTextBox"
        Me.FormaPagamentoTextBox.Size = New System.Drawing.Size(321, 20)
        Me.FormaPagamentoTextBox.TabIndex = 4
        '
        'EstimativaEntregaDateTimePicker
        '
        Me.EstimativaEntregaDateTimePicker.Checked = False
        Me.EstimativaEntregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidoTabelaBindingSource, "EstimativaEntrega", True))
        Me.EstimativaEntregaDateTimePicker.Location = New System.Drawing.Point(108, 373)
        Me.EstimativaEntregaDateTimePicker.Name = "EstimativaEntregaDateTimePicker"
        Me.EstimativaEntregaDateTimePicker.Size = New System.Drawing.Size(321, 20)
        Me.EstimativaEntregaDateTimePicker.TabIndex = 7
        '
        'EnderecoEntregaTextBox
        '
        Me.EnderecoEntregaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "EnderecoEntrega", True))
        Me.EnderecoEntregaTextBox.Location = New System.Drawing.Point(108, 93)
        Me.EnderecoEntregaTextBox.Name = "EnderecoEntregaTextBox"
        Me.EnderecoEntregaTextBox.Size = New System.Drawing.Size(321, 20)
        Me.EnderecoEntregaTextBox.TabIndex = 2
        '
        'ClienteTabelaBindingSource
        '
        Me.ClienteTabelaBindingSource.DataMember = "ClienteTabela"
        Me.ClienteTabelaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'ClienteTabelaTableAdapter
        '
        Me.ClienteTabelaTableAdapter.ClearBeforeFill = True
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Cliente", True))
        Me.ClienteComboBox.DataSource = Me.ClienteTabelaBindingSource
        Me.ClienteComboBox.DisplayMember = "Nome"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(108, 66)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(321, 21)
        Me.ClienteComboBox.TabIndex = 1
        Me.ClienteComboBox.ValueMember = "Nome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(367, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'SituaçãoTextBox
        '
        Me.SituaçãoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidoTabelaBindingSource, "Situação", True))
        Me.SituaçãoTextBox.Location = New System.Drawing.Point(108, 402)
        Me.SituaçãoTextBox.Name = "SituaçãoTextBox"
        Me.SituaçãoTextBox.Size = New System.Drawing.Size(321, 20)
        Me.SituaçãoTextBox.TabIndex = 26
        '
        'EntregueCheckBox
        '
        Me.EntregueCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PedidoTabelaBindingSource, "Entregue", True))
        Me.EntregueCheckBox.Location = New System.Drawing.Point(108, 433)
        Me.EntregueCheckBox.Name = "EntregueCheckBox"
        Me.EntregueCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EntregueCheckBox.TabIndex = 27
        Me.EntregueCheckBox.UseVisualStyleBackColor = True
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(495, 543)
        Me.Controls.Add(EntregueLabel)
        Me.Controls.Add(Me.EntregueCheckBox)
        Me.Controls.Add(SituaçãoLabel)
        Me.Controls.Add(Me.SituaçãoTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClienteComboBox)
        Me.Controls.Add(EnderecoEntregaLabel)
        Me.Controls.Add(Me.EnderecoEntregaTextBox)
        Me.Controls.Add(EstimativaEntregaLabel)
        Me.Controls.Add(Me.EstimativaEntregaDateTimePicker)
        Me.Controls.Add(FormaPagamentoLabel)
        Me.Controls.Add(Me.FormaPagamentoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ClienteLabel)
        Me.Controls.Add(ValorLabel)
        Me.Controls.Add(Me.ValorTextBox)
        Me.Controls.Add(DetalhesLabel)
        Me.Controls.Add(Me.DetalhesTextBox)
        Me.Controls.Add(DataPedidoLabel)
        Me.Controls.Add(Me.DataPedidoDateTimePicker)
        Me.Controls.Add(Me.PedidoTabelaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pedido"
        Me.Text = "Novo Pedido"
        CType(Me.PedidoTabelaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidoTabelaBindingNavigator.ResumeLayout(False)
        Me.PedidoTabelaBindingNavigator.PerformLayout()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MarcenariaDataSet As MarcenariaDataSet
    Friend WithEvents PedidoTabelaBindingSource As BindingSource
    Friend WithEvents PedidoTabelaTableAdapter As MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter
    Friend WithEvents TableAdapterManager As MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidoTabelaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents PedidoTabelaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents DetalhesTextBox As TextBox
    Friend WithEvents DataPedidoDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents FormaPagamentoTextBox As TextBox
    Friend WithEvents EstimativaEntregaDateTimePicker As DateTimePicker
    Friend WithEvents EnderecoEntregaTextBox As TextBox
    Friend WithEvents ClienteTabelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTabelaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SituaçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EntregueCheckBox As System.Windows.Forms.CheckBox
End Class
