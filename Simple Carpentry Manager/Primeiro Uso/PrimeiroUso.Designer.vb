<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeiroUsoCriarUsuario
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
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeiroUsoCriarUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.VariaveisSistemaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VariaveisSistemaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.DbLoginSistemaComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        DbLoginSistemaLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbLoginSistemaLabel
        '
        DbLoginSistemaLabel.AutoSize = True
        DbLoginSistemaLabel.ForeColor = System.Drawing.Color.White
        DbLoginSistemaLabel.Location = New System.Drawing.Point(215, 248)
        DbLoginSistemaLabel.Name = "DbLoginSistemaLabel"
        DbLoginSistemaLabel.Size = New System.Drawing.Size(155, 13)
        DbLoginSistemaLabel.TabIndex = 4
        DbLoginSistemaLabel.Text = "Deseja ligar o sistema de login?"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(269, 288)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 26)
        Label3.TabIndex = 7
        Label3.Text = "On = Sim" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Off = Não" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(173, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificamos que essa é sua primeira vez aqui" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vamos configurar o aplicativo p" &
    "ara seu melhor uso"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(193, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bem-vindo ao Simple Carpentry Manager"
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
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Me.VariaveisSistemaTableAdapter
        '
        'DbLoginSistemaComboBox
        '
        Me.DbLoginSistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VariaveisSistemaBindingSource, "dbLoginSistema", True))
        Me.DbLoginSistemaComboBox.FormattingEnabled = True
        Me.DbLoginSistemaComboBox.Items.AddRange(New Object() {"On", "Off"})
        Me.DbLoginSistemaComboBox.Location = New System.Drawing.Point(232, 264)
        Me.DbLoginSistemaComboBox.Name = "DbLoginSistemaComboBox"
        Me.DbLoginSistemaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DbLoginSistemaComboBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(260, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2branco
        Me.PictureBox1.Location = New System.Drawing.Point(160, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PrimeiroUsoCriarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 429)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DbLoginSistemaLabel)
        Me.Controls.Add(Me.DbLoginSistemaComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PrimeiroUsoCriarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar o primeiro uso"
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VariaveisSistemaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents VariaveisSistemaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VariaveisSistemaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DbLoginSistemaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
