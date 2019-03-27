<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriarMaterial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CriarMaterial))
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.MateriaisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MateriaisTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.MateriaisTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.MateriaisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MateriaisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodChapaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeChapaTextBox = New System.Windows.Forms.TextBox()
        Me.ExpressuraTextBox = New System.Windows.Forms.TextBox()
        Me.CorTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_porchapa_TextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CodChapaLabel = New System.Windows.Forms.Label()
        NomeChapaLabel = New System.Windows.Forms.Label()
        ExpressuraLabel = New System.Windows.Forms.Label()
        CorLabel = New System.Windows.Forms.Label()
        FornecedorLabel = New System.Windows.Forms.Label()
        Valor_porchapa_Label = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MateriaisBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodChapaLabel
        '
        CodChapaLabel.AutoSize = True
        CodChapaLabel.Location = New System.Drawing.Point(12, 86)
        CodChapaLabel.Name = "CodChapaLabel"
        CodChapaLabel.Size = New System.Drawing.Size(91, 13)
        CodChapaLabel.TabIndex = 3
        CodChapaLabel.Text = "Codigo da chapa:"
        '
        'NomeChapaLabel
        '
        NomeChapaLabel.AutoSize = True
        NomeChapaLabel.Location = New System.Drawing.Point(12, 112)
        NomeChapaLabel.Name = "NomeChapaLabel"
        NomeChapaLabel.Size = New System.Drawing.Size(86, 13)
        NomeChapaLabel.TabIndex = 5
        NomeChapaLabel.Text = "Nome da chapa:"
        '
        'ExpressuraLabel
        '
        ExpressuraLabel.AutoSize = True
        ExpressuraLabel.Location = New System.Drawing.Point(12, 138)
        ExpressuraLabel.Name = "ExpressuraLabel"
        ExpressuraLabel.Size = New System.Drawing.Size(57, 13)
        ExpressuraLabel.TabIndex = 7
        ExpressuraLabel.Text = "Dimensão:"
        '
        'CorLabel
        '
        CorLabel.AutoSize = True
        CorLabel.Location = New System.Drawing.Point(12, 164)
        CorLabel.Name = "CorLabel"
        CorLabel.Size = New System.Drawing.Size(26, 13)
        CorLabel.TabIndex = 9
        CorLabel.Text = "Cor:"
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Location = New System.Drawing.Point(12, 190)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(64, 13)
        FornecedorLabel.TabIndex = 11
        FornecedorLabel.Text = "Fornecedor:"
        '
        'Valor_porchapa_Label
        '
        Valor_porchapa_Label.AutoSize = True
        Valor_porchapa_Label.Location = New System.Drawing.Point(12, 216)
        Valor_porchapa_Label.Name = "Valor_porchapa_Label"
        Valor_porchapa_Label.Size = New System.Drawing.Size(93, 13)
        Valor_porchapa_Label.TabIndex = 13
        Valor_porchapa_Label.Text = "Valor (Por Chapa):"
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MateriaisBindingSource
        '
        Me.MateriaisBindingSource.DataMember = "Materiais"
        Me.MateriaisBindingSource.DataSource = Me.MarcenariaDataSet
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
        'MateriaisBindingNavigator
        '
        Me.MateriaisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MateriaisBindingNavigator.BindingSource = Me.MateriaisBindingSource
        Me.MateriaisBindingNavigator.CountItem = Nothing
        Me.MateriaisBindingNavigator.DeleteItem = Nothing
        Me.MateriaisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.MateriaisBindingNavigatorSaveItem})
        Me.MateriaisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MateriaisBindingNavigator.MoveFirstItem = Nothing
        Me.MateriaisBindingNavigator.MoveLastItem = Nothing
        Me.MateriaisBindingNavigator.MoveNextItem = Nothing
        Me.MateriaisBindingNavigator.MovePreviousItem = Nothing
        Me.MateriaisBindingNavigator.Name = "MateriaisBindingNavigator"
        Me.MateriaisBindingNavigator.PositionItem = Nothing
        Me.MateriaisBindingNavigator.Size = New System.Drawing.Size(470, 25)
        Me.MateriaisBindingNavigator.TabIndex = 0
        Me.MateriaisBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(110, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar Novo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MateriaisBindingNavigatorSaveItem
        '
        Me.MateriaisBindingNavigatorSaveItem.Image = CType(resources.GetObject("MateriaisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MateriaisBindingNavigatorSaveItem.Name = "MateriaisBindingNavigatorSaveItem"
        Me.MateriaisBindingNavigatorSaveItem.Size = New System.Drawing.Size(94, 22)
        Me.MateriaisBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CodChapaTextBox
        '
        Me.CodChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "CodChapa", True))
        Me.CodChapaTextBox.Location = New System.Drawing.Point(103, 83)
        Me.CodChapaTextBox.Name = "CodChapaTextBox"
        Me.CodChapaTextBox.Size = New System.Drawing.Size(355, 20)
        Me.CodChapaTextBox.TabIndex = 4
        '
        'NomeChapaTextBox
        '
        Me.NomeChapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "NomeChapa", True))
        Me.NomeChapaTextBox.Location = New System.Drawing.Point(103, 109)
        Me.NomeChapaTextBox.Name = "NomeChapaTextBox"
        Me.NomeChapaTextBox.Size = New System.Drawing.Size(355, 20)
        Me.NomeChapaTextBox.TabIndex = 6
        '
        'ExpressuraTextBox
        '
        Me.ExpressuraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Expressura", True))
        Me.ExpressuraTextBox.Location = New System.Drawing.Point(103, 135)
        Me.ExpressuraTextBox.Name = "ExpressuraTextBox"
        Me.ExpressuraTextBox.Size = New System.Drawing.Size(355, 20)
        Me.ExpressuraTextBox.TabIndex = 8
        '
        'CorTextBox
        '
        Me.CorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Cor", True))
        Me.CorTextBox.Location = New System.Drawing.Point(103, 161)
        Me.CorTextBox.Name = "CorTextBox"
        Me.CorTextBox.Size = New System.Drawing.Size(355, 20)
        Me.CorTextBox.TabIndex = 10
        '
        'FornecedorTextBox
        '
        Me.FornecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Fornecedor", True))
        Me.FornecedorTextBox.Location = New System.Drawing.Point(103, 187)
        Me.FornecedorTextBox.Name = "FornecedorTextBox"
        Me.FornecedorTextBox.Size = New System.Drawing.Size(355, 20)
        Me.FornecedorTextBox.TabIndex = 12
        '
        'Valor_porchapa_TextBox
        '
        Me.Valor_porchapa_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MateriaisBindingSource, "Valor(porchapa)", True))
        Me.Valor_porchapa_TextBox.Location = New System.Drawing.Point(111, 213)
        Me.Valor_porchapa_TextBox.Name = "Valor_porchapa_TextBox"
        Me.Valor_porchapa_TextBox.Size = New System.Drawing.Size(347, 20)
        Me.Valor_porchapa_TextBox.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2
        Me.PictureBox1.Location = New System.Drawing.Point(234, 341)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'CriarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 485)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Name = "CriarMaterial"
        Me.Text = "Novo Material"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MateriaisBindingNavigator.ResumeLayout(False)
        Me.MateriaisBindingNavigator.PerformLayout()
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
    Friend WithEvents MateriaisBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CodChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeChapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpressuraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FornecedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Valor_porchapa_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
