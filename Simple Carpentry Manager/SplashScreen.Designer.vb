<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Me.PedidoTabelaTableAdapter1 = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.ClienteTabelaTableAdapter1 = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MarcenariaDataSet1 = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.Statuslabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UsuarioTableAdapter1 = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.UsuarioTableAdapter()
        Me.VariaveisSistemaTableAdapter1 = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MarcenariaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidoTabelaTableAdapter1
        '
        Me.PedidoTabelaTableAdapter1.ClearBeforeFill = True
        '
        'ClienteTabelaTableAdapter1
        '
        Me.ClienteTabelaTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desenvolvido por Kalamari Soluções" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'MarcenariaDataSet1
        '
        Me.MarcenariaDataSet1.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Statuslabel
        '
        Me.Statuslabel.AutoSize = True
        Me.Statuslabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Statuslabel.Location = New System.Drawing.Point(9, 392)
        Me.Statuslabel.Name = "Statuslabel"
        Me.Statuslabel.Size = New System.Drawing.Size(63, 13)
        Me.Statuslabel.TabIndex = 3
        Me.Statuslabel.Text = "StatusLabel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(323, 52)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Orientador de projeto: Laelson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lideres de projeto: Italo Guerra e David Silva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" &
    "ocumental: Matheus Alves,Filipe Ramos e Italo Guerra" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programação: David Silva e" &
    " Higor Rodrigues "
        '
        'Timer1
        '
        Me.Timer1.Interval = 8000
        '
        'UsuarioTableAdapter1
        '
        Me.UsuarioTableAdapter1.ClearBeforeFill = True
        '
        'VariaveisSistemaTableAdapter1
        '
        Me.VariaveisSistemaTableAdapter1.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Versão Build: XXX"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.SCMlogo2branco
        Me.PictureBox2.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(241, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Simple_Carpentry_Manager.My.Resources.Resources.loadingscreen
        Me.PictureBox1.Location = New System.Drawing.Point(338, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Statuslabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MarcenariaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents PedidoTabelaTableAdapter1 As MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter
    Public WithEvents ClienteTabelaTableAdapter1 As MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
    Public WithEvents MarcenariaDataSet1 As MarcenariaDataSet
    Friend WithEvents Statuslabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UsuarioTableAdapter1 As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents VariaveisSistemaTableAdapter1 As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.variaveisSistemaTableAdapter
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
