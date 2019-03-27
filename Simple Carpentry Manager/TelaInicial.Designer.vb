<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaInicial))
        Me.MenuTool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerUsuariosCadastradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CriarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecibosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MateriaisRegistradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeralToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaIndividualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataAtualLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PedidoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.PedidoTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.TableAdapterManager = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager()
        Me.KalamariSoluçeosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTool.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTool
        '
        Me.MenuTool.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton4, Me.ToolStripSeparator1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton3, Me.ToolStripDropDownButton5, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripLabel1})
        Me.MenuTool.Location = New System.Drawing.Point(0, 0)
        Me.MenuTool.Name = "MenuTool"
        Me.MenuTool.Size = New System.Drawing.Size(798, 25)
        Me.MenuTool.TabIndex = 0
        Me.MenuTool.Text = "ToolStrip2"
        '
        'ToolStripDropDownButton4
        '
        Me.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ConfiguracoesToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.ToolStripDropDownButton4.Image = CType(resources.GetObject("ToolStripDropDownButton4.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4"
        Me.ToolStripDropDownButton4.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton4.Text = "Sistema"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'CadastrarUsuariosToolStripMenuItem
        '
        Me.CadastrarUsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.VerUsuariosCadastradosToolStripMenuItem, Me.EditarUsuariosToolStripMenuItem})
        Me.CadastrarUsuariosToolStripMenuItem.Name = "CadastrarUsuariosToolStripMenuItem"
        Me.CadastrarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CadastrarUsuariosToolStripMenuItem.Text = "Outros Usuarios"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'VerUsuariosCadastradosToolStripMenuItem
        '
        Me.VerUsuariosCadastradosToolStripMenuItem.Name = "VerUsuariosCadastradosToolStripMenuItem"
        Me.VerUsuariosCadastradosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.VerUsuariosCadastradosToolStripMenuItem.Text = "Ver usuarios cadastrados"
        '
        'EditarUsuariosToolStripMenuItem
        '
        Me.EditarUsuariosToolStripMenuItem.Name = "EditarUsuariosToolStripMenuItem"
        Me.EditarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EditarUsuariosToolStripMenuItem.Text = "Editar Usuarios"
        '
        'ConfiguracoesToolStripMenuItem
        '
        Me.ConfiguracoesToolStripMenuItem.Name = "ConfiguracoesToolStripMenuItem"
        Me.ConfiguracoesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConfiguracoesToolStripMenuItem.Text = "Configurações"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsoToolStripMenuItem, Me.KalamariSoluçeosToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'ManualDeUsoToolStripMenuItem
        '
        Me.ManualDeUsoToolStripMenuItem.Name = "ManualDeUsoToolStripMenuItem"
        Me.ManualDeUsoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManualDeUsoToolStripMenuItem.Text = "Manual de uso"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.EditarClientesToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripDropDownButton2.Text = "Cliente"
        Me.ToolStripDropDownButton2.ToolTipText = "Menu Cliente"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem2.Text = "Criar Cliente"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(168, 22)
        Me.ToolStripMenuItem3.Text = "Visualizar Clientes"
        '
        'EditarClientesToolStripMenuItem
        '
        Me.EditarClientesToolStripMenuItem.Name = "EditarClientesToolStripMenuItem"
        Me.EditarClientesToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditarClientesToolStripMenuItem.Text = "Editar Clientes"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarPedidoToolStripMenuItem, Me.VisualizarPedidosToolStripMenuItem, Me.EditarPedidoToolStripMenuItem, Me.RecibosToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripDropDownButton3.Text = "Pedido"
        '
        'CriarPedidoToolStripMenuItem
        '
        Me.CriarPedidoToolStripMenuItem.Name = "CriarPedidoToolStripMenuItem"
        Me.CriarPedidoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CriarPedidoToolStripMenuItem.Text = "Criar Pedido"
        '
        'VisualizarPedidosToolStripMenuItem
        '
        Me.VisualizarPedidosToolStripMenuItem.Name = "VisualizarPedidosToolStripMenuItem"
        Me.VisualizarPedidosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.VisualizarPedidosToolStripMenuItem.Text = "Visualizar Pedidos"
        '
        'EditarPedidoToolStripMenuItem
        '
        Me.EditarPedidoToolStripMenuItem.Name = "EditarPedidoToolStripMenuItem"
        Me.EditarPedidoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.EditarPedidoToolStripMenuItem.Text = "Editar Pedidos"
        '
        'RecibosToolStripMenuItem
        '
        Me.RecibosToolStripMenuItem.Name = "RecibosToolStripMenuItem"
        Me.RecibosToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RecibosToolStripMenuItem.Text = "Recibos"
        '
        'ToolStripDropDownButton5
        '
        Me.ToolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MateriaisRegistradosToolStripMenuItem, Me.GerenciarListaToolStripMenuItem})
        Me.ToolStripDropDownButton5.Image = CType(resources.GetObject("ToolStripDropDownButton5.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5"
        Me.ToolStripDropDownButton5.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripDropDownButton5.Text = "Materiais"
        '
        'MateriaisRegistradosToolStripMenuItem
        '
        Me.MateriaisRegistradosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeralToolStripMenuItem1, Me.ConsultaIndividualToolStripMenuItem1})
        Me.MateriaisRegistradosToolStripMenuItem.Name = "MateriaisRegistradosToolStripMenuItem"
        Me.MateriaisRegistradosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.MateriaisRegistradosToolStripMenuItem.Text = "Materiais Registrados"
        '
        'ConsultaGeralToolStripMenuItem1
        '
        Me.ConsultaGeralToolStripMenuItem1.Name = "ConsultaGeralToolStripMenuItem1"
        Me.ConsultaGeralToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaGeralToolStripMenuItem1.Text = "Consulta Geral"
        '
        'ConsultaIndividualToolStripMenuItem1
        '
        Me.ConsultaIndividualToolStripMenuItem1.Name = "ConsultaIndividualToolStripMenuItem1"
        Me.ConsultaIndividualToolStripMenuItem1.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaIndividualToolStripMenuItem1.Text = "Consulta Individual"
        '
        'GerenciarListaToolStripMenuItem
        '
        Me.GerenciarListaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoMaterialToolStripMenuItem, Me.ListaCompletaToolStripMenuItem})
        Me.GerenciarListaToolStripMenuItem.Name = "GerenciarListaToolStripMenuItem"
        Me.GerenciarListaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.GerenciarListaToolStripMenuItem.Text = "Gerenciar Lista"
        '
        'NovoMaterialToolStripMenuItem
        '
        Me.NovoMaterialToolStripMenuItem.Name = "NovoMaterialToolStripMenuItem"
        Me.NovoMaterialToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NovoMaterialToolStripMenuItem.Text = "Novo Material"
        '
        'ListaCompletaToolStripMenuItem
        '
        Me.ListaCompletaToolStripMenuItem.Name = "ListaCompletaToolStripMenuItem"
        Me.ListaCompletaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ListaCompletaToolStripMenuItem.Text = "Editar Material"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripButton1.Text = "Desconectar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataAtualLabel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 513)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2branco
        Me.PictureBox3.Location = New System.Drawing.Point(12, 346)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(283, 134)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(467, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 186)
        Me.Panel2.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(298, 29)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Controle de estoque"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(298, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Relatório Clientes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(8, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(298, 29)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Emitir Recibos"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(298, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Pedidos Proximos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 42)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(298, 29)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Relatório Pedidos"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.novaversaoaviso
        Me.PictureBox2.Location = New System.Drawing.Point(495, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(-3, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Simple Carpentry Manager" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Compilação Dezembro/2018" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataAtualLabel
        '
        Me.DataAtualLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAtualLabel.Location = New System.Drawing.Point(0, 0)
        Me.DataAtualLabel.Name = "DataAtualLabel"
        Me.DataAtualLabel.Size = New System.Drawing.Size(431, 25)
        Me.DataAtualLabel.TabIndex = 4
        Me.DataAtualLabel.Text = "DataAtual"
        Me.DataAtualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.titlescreen
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(798, 513)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
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
        'PedidoTabelaTableAdapter
        '
        Me.PedidoTabelaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTabelaTableAdapter = Nothing
        Me.TableAdapterManager.EstoqueTableAdapter = Nothing
        Me.TableAdapterManager.MateriaisTableAdapter = Nothing
        Me.TableAdapterManager.PedidoTabelaTableAdapter = Me.PedidoTabelaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.variaveisSistemaTableAdapter = Nothing
        '
        'KalamariSoluçeosToolStripMenuItem
        '
        Me.KalamariSoluçeosToolStripMenuItem.Name = "KalamariSoluçeosToolStripMenuItem"
        Me.KalamariSoluçeosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KalamariSoluçeosToolStripMenuItem.Text = "Kalamari Soluções"
        '
        'TelaInicial
        '
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(798, 538)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuTool)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TelaInicial"
        Me.Text = "SCM X.X.X | Conectado com o perfil  XXXX"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuTool.ResumeLayout(False)
        Me.MenuTool.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents CriarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuTool As ToolStrip
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents CriarPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents VisualizarPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton4 As ToolStripDropDownButton
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents VerUsuariosCadastradosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents EditarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton5 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents MateriaisRegistradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerenciarListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaCompletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaGeralToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaIndividualToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAtualLabel As System.Windows.Forms.Label
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents PedidoTabelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidoTabelaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter
    Friend WithEvents TableAdapterManager As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RecibosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents KalamariSoluçeosToolStripMenuItem As ToolStripMenuItem
End Class
