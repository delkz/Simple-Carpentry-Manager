<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configurar
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
        Dim DbTemaSistemaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configurar))
        Dim DbLoginSistemaLabel As System.Windows.Forms.Label
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.VariaveisSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VariaveisSistemaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.VariaveisSistemaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DbTemaSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.VariaveisSistemaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DbLoginSistemaComboBox = New System.Windows.Forms.ComboBox()
        DbTemaSistemaLabel = New System.Windows.Forms.Label()
        DbLoginSistemaLabel = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VariaveisSistemaBindingNavigator.SuspendLayout()
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
        Me.VariaveisSistemaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VariaveisSistemaBindingNavigator.BindingSource = Me.VariaveisSistemaBindingSource
        Me.VariaveisSistemaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VariaveisSistemaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VariaveisSistemaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VariaveisSistemaBindingNavigatorSaveItem})
        Me.VariaveisSistemaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VariaveisSistemaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VariaveisSistemaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VariaveisSistemaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VariaveisSistemaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VariaveisSistemaBindingNavigator.Name = "VariaveisSistemaBindingNavigator"
        Me.VariaveisSistemaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VariaveisSistemaBindingNavigator.Size = New System.Drawing.Size(372, 25)
        Me.VariaveisSistemaBindingNavigator.TabIndex = 0
        Me.VariaveisSistemaBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DbTemaSistemaLabel
        '
        DbTemaSistemaLabel.AutoSize = True
        DbTemaSistemaLabel.Location = New System.Drawing.Point(12, 35)
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
        Me.DbTemaSistemaComboBox.Location = New System.Drawing.Point(110, 32)
        Me.DbTemaSistemaComboBox.Name = "DbTemaSistemaComboBox"
        Me.DbTemaSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbTemaSistemaComboBox.TabIndex = 2
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
        'VariaveisSistemaBindingNavigatorSaveItem
        '
        Me.VariaveisSistemaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VariaveisSistemaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VariaveisSistemaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Name = "VariaveisSistemaBindingNavigatorSaveItem"
        Me.VariaveisSistemaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DbLoginSistemaLabel
        '
        DbLoginSistemaLabel.AutoSize = True
        DbLoginSistemaLabel.Location = New System.Drawing.Point(13, 61)
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
        Me.DbLoginSistemaComboBox.Location = New System.Drawing.Point(110, 58)
        Me.DbLoginSistemaComboBox.Name = "DbLoginSistemaComboBox"
        Me.DbLoginSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbLoginSistemaComboBox.TabIndex = 4
        '
        'configurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 262)
        Me.Controls.Add(DbLoginSistemaLabel)
        Me.Controls.Add(Me.DbLoginSistemaComboBox)
        Me.Controls.Add(DbTemaSistemaLabel)
        Me.Controls.Add(Me.DbTemaSistemaComboBox)
        Me.Controls.Add(Me.VariaveisSistemaBindingNavigator)
        Me.Name = "configurar"
        Me.Text = "configurar"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VariaveisSistemaBindingNavigator.ResumeLayout(False)
        Me.VariaveisSistemaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents VariaveisSistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VariaveisSistemaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VariaveisSistemaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VariaveisSistemaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DbTemaSistemaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DbLoginSistemaComboBox As System.Windows.Forms.ComboBox
End Class
