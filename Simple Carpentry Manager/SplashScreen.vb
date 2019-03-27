Public NotInheritable Class SplashScreen
    Dim pb1, pb2, pb3 As String


    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.Network.IsAvailable Then
            Try
                Dim web As New Net.WebClient
                NovaVersao = web.DownloadString("https://simplecarpentrymanager.000webhostapp.com/scm/versioncheck.txt")
                LocalDownload = web.DownloadString("https://simplecarpentrymanager.000webhostapp.com/scm/versionlocate.txt")
            Catch ex As Exception
                NovaVersao = "Servidor Indisponivel"
                LocalDownload = "Servidor Indisponivel"
            End Try
        Else
            NovaVersao = "Servidor Indisponivel"
            LocalDownload = "Servidor Indisponivel"
        End If
        ''----------------------------------------------------------------''
        ''----------------------------------------------------------------''
        Label3.Text = "Versão Build: " + VersaoSistema
        Timer1.Start()

        Statuslabel.Text = "Carregando Banco de Dados(PedidoTabela)..."
        Me.PedidoTabelaTableAdapter1.Fill(Me.MarcenariaDataSet1.PedidoTabela)

        Statuslabel.Text = "Carregando Banco de Dados(ClienteTabela)..."
        Me.ClienteTabelaTableAdapter1.Fill(Me.MarcenariaDataSet1.ClienteTabela)

        Statuslabel.Text = "Carregando Banco de Dados(Usuarios)..."
        Me.UsuarioTableAdapter1.Fill(Me.MarcenariaDataSet1.Usuario)

        Statuslabel.Text = "Iniciando Aplicação..."


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        lvlacss = 1
        usuariolog = "Desenvolvedor"
        TelaInicial.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.VariaveisSistemaTableAdapter1.ScalarQueryPrimeiroUso = "1" Then
            If Me.VariaveisSistemaTableAdapter1.ScalarQueryTemaSistema() = "Default" Then
                SistemaTema = "Default"
            End If

            If Me.VariaveisSistemaTableAdapter1.ScalarQueryTemaSistema() = "Dark" Then
                SistemaTema = "Dark"
            End If

            If Me.VariaveisSistemaTableAdapter1.ScalarQueryLoginSistema() = "Off" Then
                SistemaLogin = "Off"
                lvlacss = 1
                usuariolog = "Padrão"
            Else
                SistemaLogin = "On"
            End If

            If Me.VariaveisSistemaTableAdapter1.GetDataByTelacheia Is "True" Then
                TelaCheias = True
            Else
                TelaCheias = False
            End If


            If SistemaLogin = "On" Then
                login.Show()
                Me.Close()
            Else
                TelaInicial.Show()
                Me.Close()
            End If
        Else
            PrimeiroUsoCriarUsuario.Show()
            Me.Close()
        End If
    End Sub

End Class
