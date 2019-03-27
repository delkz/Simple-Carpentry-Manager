<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracoes))
        Dim DbTemaSistemaLabel As System.Windows.Forms.Label
        Dim DbLoginSistemaLabel As System.Windows.Forms.Label
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.VariaveisSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VariaveisSistemaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.VariaveisSistemaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.VariaveisSistemaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DbTemaSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.DbLoginSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.VariaveisSistemaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DbTemaSistemaLabel = New System.Windows.Forms.Label()
        DbLoginSistemaLabel = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VariaveisSistemaBindingNavigator.SuspendLayout()
        CType(Me.VariaveisSistemaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VariaveisSistemaBindingSource
        '
        Me.VariaveisSistemaBindingSource.DataMember = "variaveisSistema"
        Me.VariaveisSistemaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'VariaveisSistemaTableAdapter
        '
        Me.VariaveisSistemaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Me.VariaveisSistemaTableAdapter
        '
        'VariaveisSistemaBindingNavigator
        '
        Me.VariaveisSistemaBindingNavigator.AddNewItem = Nothing
        Me.VariaveisSistemaBindingNavigator.BindingSource = Me.VariaveisSistemaBindingSource
        Me.VariaveisSistemaBindingNavigator.CountItem = Nothing
        Me.VariaveisSistemaBindingNavigator.DeleteItem = Nothing
        Me.VariaveisSistemaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VariaveisSistemaBindingNavigatorSaveItem})
        Me.VariaveisSistemaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VariaveisSistemaBindingNavigator.MoveFirstItem = Nothing
        Me.VariaveisSistemaBindingNavigator.MoveLastItem = Nothing
        Me.VariaveisSistemaBindingNavigator.MoveNextItem = Nothing
        Me.VariaveisSistemaBindingNavigator.MovePreviousItem = Nothing
        Me.VariaveisSistemaBindingNavigator.Name = "VariaveisSistemaBindingNavigator"
        Me.VariaveisSistemaBindingNavigator.PositionItem = Nothing
        Me.VariaveisSistemaBindingNavigator.Size = New System.Drawing.Size(486, 25)
        Me.VariaveisSistemaBindingNavigator.TabIndex = 0
        Me.VariaveisSistemaBindingNavigator.Text = "BindingNavigator1"
        '
        'VariaveisSistemaBindingNavigatorSaveItem
        '
        Me.VariaveisSistemaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VariaveisSistemaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VariaveisSistemaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Name = "VariaveisSistemaBindingNavigatorSaveItem"
        Me.VariaveisSistemaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DbTemaSistemaLabel
        '
        DbTemaSistemaLabel.AutoSize = True
        DbTemaSistemaLabel.Location = New System.Drawing.Point(12, 38)
        DbTemaSistemaLabel.Name = "DbTemaSistemaLabel"
        DbTemaSistemaLabel.Size = New System.Drawing.Size(92, 13)
        DbTemaSistemaLabel.TabIndex = 1
        DbTemaSistemaLabel.Text = "db Tema Sistema:"
        '
        'DbTemaSistemaComboBox
        '
        Me.DbTemaSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariaveisSistemaBindingSource, "dbTemaSistema", True))
        Me.DbTemaSistemaComboBox.FormattingEnabled = True
        Me.DbTemaSistemaComboBox.Items.AddRange(New Object() {"Default", "Dark"})
        Me.DbTemaSistemaComboBox.Location = New System.Drawing.Point(110, 35)
        Me.DbTemaSistemaComboBox.Name = "DbTemaSistemaComboBox"
        Me.DbTemaSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbTemaSistemaComboBox.TabIndex = 2
        '
        'DbLoginSistemaLabel
        '
        DbLoginSistemaLabel.AutoSize = True
        DbLoginSistemaLabel.Location = New System.Drawing.Point(13, 62)
        DbLoginSistemaLabel.Name = "DbLoginSistemaLabel"
        DbLoginSistemaLabel.Size = New System.Drawing.Size(91, 13)
        DbLoginSistemaLabel.TabIndex = 3
        DbLoginSistemaLabel.Text = "db Login Sistema:"
        '
        'DbLoginSistemaComboBox
        '
        Me.DbLoginSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariaveisSistemaBindingSource, "dbLoginSistema", True))
        Me.DbLoginSistemaComboBox.FormattingEnabled = True
        Me.DbLoginSistemaComboBox.Items.AddRange(New Object() {"On", "Off"})
        Me.DbLoginSistemaComboBox.Location = New System.Drawing.Point(110, 59)
        Me.DbLoginSistemaComboBox.Name = "DbLoginSistemaComboBox"
        Me.DbLoginSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbLoginSistemaComboBox.TabIndex = 4
        '
        'VariaveisSistemaDataGridView
        '
        Me.VariaveisSistemaDataGridView.AutoGenerateColumns = False
        Me.VariaveisSistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VariaveisSistemaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.VariaveisSistemaDataGridView.DataSource = Me.VariaveisSistemaBindingSource
        Me.VariaveisSistemaDataGridView.Location = New System.Drawing.Point(12, 102)
        Me.VariaveisSistemaDataGridView.Name = "VariaveisSistemaDataGridView"
        Me.VariaveisSistemaDataGridView.Size = New System.Drawing.Size(413, 220)
        Me.VariaveisSistemaDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dbTemaSistema"
        Me.DataGridViewTextBoxColumn2.HeaderText = "dbTemaSistema"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dbLoginSistema"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dbLoginSistema"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Configuracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 382)
        Me.Controls.Add(Me.VariaveisSistemaDataGridView)
        Me.Controls.Add(DbLoginSistemaLabel)
        Me.Controls.Add(Me.DbLoginSistemaComboBox)
        Me.Controls.Add(DbTemaSistemaLabel)
        Me.Controls.Add(Me.DbTemaSistemaComboBox)
        Me.Controls.Add(Me.VariaveisSistemaBindingNavigator)
        Me.Name = "Configuracoes"
        Me.Text = "Configuracoes"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VariaveisSistemaBindingNavigator.ResumeLayout(False)
        Me.VariaveisSistemaBindingNavigator.PerformLayout()
        CType(Me.VariaveisSistemaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents VariaveisSistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VariaveisSistemaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VariaveisSistemaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents VariaveisSistemaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DbTemaSistemaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DbLoginSistemaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VariaveisSistemaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
