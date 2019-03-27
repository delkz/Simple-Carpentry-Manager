<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configurarapp
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
        Dim DbLoginSistemaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configurarapp))
        Me.VariaveisSistemaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.VariaveisSistemaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DbLoginSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TelacheiaChkBox = New System.Windows.Forms.CheckBox()
        Me.VariaveisSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.VariaveisSistemaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        DbLoginSistemaLabel = New System.Windows.Forms.Label()
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VariaveisSistemaBindingNavigator.SuspendLayout()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbLoginSistemaLabel
        '
        DbLoginSistemaLabel.AutoSize = True
        DbLoginSistemaLabel.Location = New System.Drawing.Point(14, 40)
        DbLoginSistemaLabel.Name = "DbLoginSistemaLabel"
        DbLoginSistemaLabel.Size = New System.Drawing.Size(88, 13)
        DbLoginSistemaLabel.TabIndex = 3
        DbLoginSistemaLabel.Text = "Sistema de Login"
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
        Me.VariaveisSistemaBindingNavigator.Size = New System.Drawing.Size(434, 25)
        Me.VariaveisSistemaBindingNavigator.TabIndex = 0
        Me.VariaveisSistemaBindingNavigator.Text = "BindingNavigator1"
        '
        'VariaveisSistemaBindingNavigatorSaveItem
        '
        Me.VariaveisSistemaBindingNavigatorSaveItem.Image = CType(resources.GetObject("VariaveisSistemaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Name = "VariaveisSistemaBindingNavigatorSaveItem"
        Me.VariaveisSistemaBindingNavigatorSaveItem.Size = New System.Drawing.Size(109, 22)
        Me.VariaveisSistemaBindingNavigatorSaveItem.Text = "Salvar alteração"
        '
        'DbLoginSistemaComboBox
        '
        Me.DbLoginSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariaveisSistemaBindingSource, "dbLoginSistema", True))
        Me.DbLoginSistemaComboBox.FormattingEnabled = True
        Me.DbLoginSistemaComboBox.Items.AddRange(New Object() {"On", "Off"})
        Me.DbLoginSistemaComboBox.Location = New System.Drawing.Point(130, 37)
        Me.DbLoginSistemaComboBox.Name = "DbLoginSistemaComboBox"
        Me.DbLoginSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbLoginSistemaComboBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "*Requer privilegios administrativos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Buscar Atualizações"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Diretorio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Diretorio De instalação"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(139, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 29)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Ler mudanças das ultimas atualizações"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Copiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Abrir em tela cheia"
        Me.Label4.Visible = False
        '
        'TelacheiaChkBox
        '
        Me.TelacheiaChkBox.AutoSize = True
        Me.TelacheiaChkBox.Location = New System.Drawing.Point(130, 78)
        Me.TelacheiaChkBox.Name = "TelacheiaChkBox"
        Me.TelacheiaChkBox.Size = New System.Drawing.Size(15, 14)
        Me.TelacheiaChkBox.TabIndex = 15
        Me.TelacheiaChkBox.UseVisualStyleBackColor = True
        Me.TelacheiaChkBox.Visible = False
        '
        'VariaveisSistemaBindingSource
        '
        Me.VariaveisSistemaBindingSource.DataMember = "variaveisSistema"
        Me.VariaveisSistemaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VariaveisSistemaTableAdapter
        '
        Me.VariaveisSistemaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Me.VariaveisSistemaTableAdapter
        '
        'configurarapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(434, 373)
        Me.Controls.Add(Me.TelacheiaChkBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(DbLoginSistemaLabel)
        Me.Controls.Add(Me.DbLoginSistemaComboBox)
        Me.Controls.Add(Me.VariaveisSistemaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "configurarapp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurações"
        CType(Me.VariaveisSistemaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VariaveisSistemaBindingNavigator.ResumeLayout(False)
        Me.VariaveisSistemaBindingNavigator.PerformLayout()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents VariaveisSistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VariaveisSistemaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VariaveisSistemaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DbLoginSistemaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VariaveisSistemaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TelacheiaChkBox As CheckBox
End Class
