Public Class TelaInicial

    Private Sub TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Teste de Versão
        Timer1.Start()
        If NovaVersao <> VersaoSistema Then
            If NovaVersao = "Servidor Indisponivel" Then
                PictureBox2.Visible = False
            Else
                PictureBox2.Visible = True
            End If
        Else
            PictureBox2.Visible = False
        End If

        If SistemaLogin = "Off" Then
            ToolStripButton1.Text = "Finalizar"
        End If

        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)
        Me.Text = VersaoSistema + " | Conectado com o perfil " + usuariolog

        Me.BackColor = Color.FromArgb(25, 36, 60)
        DataAtualLabel.ForeColor = Color.White

        ''As linhas a seguir bloqueiam os menus para os logados com permissão de usuario
        If lvlacss = 0 Then
            EditarClientesToolStripMenuItem.Enabled = False
            EditarPedidoToolStripMenuItem.Enabled = False
            EditarUsuariosToolStripMenuItem.Enabled = False
            CadastroToolStripMenuItem.Enabled = False
            ListaCompletaToolStripMenuItem.Enabled = False
            NovoMaterialToolStripMenuItem.Enabled = False
        End If
        If SistemaLogin = "Off" Then
            UsuariosToolStripMenuItem.Enabled = False
        End If
        'Data Atual
        DataAtualLabel.Text = FormatDateTime(Today, DateFormat.LongDate)

        If TelaCheias = True Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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

        If NovaVersao <> VersaoSistema Then
            If NovaVersao = "Servidor Indisponivel" Then
                PictureBox2.Visible = False
            Else
                PictureBox2.Visible = True
            End If
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Cliente.Show()
    End Sub

    Private Sub CriarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriarPedidoToolStripMenuItem.Click
        Pedido.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        visualizarclientes.Show()
    End Sub

    Private Sub VisualizarPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarPedidosToolStripMenuItem.Click
        VisualizarPedidos.Show()
    End Sub

    Private Sub EditarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarClientesToolStripMenuItem.Click
        editarocliente.Show()
    End Sub

    Private Sub EditarPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarPedidoToolStripMenuItem.Click
        EditarPedido.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        login.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        cadastrodenovo.Show()
    End Sub

    Private Sub VerUsuariosCadastradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuariosCadastradosToolStripMenuItem.Click
        usuarioscadastrados.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If SistemaLogin = "Off" Then
            Me.Close()
        Else
            lvlacss = 0
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub EditarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarUsuariosToolStripMenuItem.Click
        editarusu.Show()
    End Sub

    Private Sub ConfiguracoesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracoesToolStripMenuItem.Click
        configurarapp.Show()
    End Sub
    ''Materiais
    Private Sub ConsultaGeralToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaGeralToolStripMenuItem1.Click
        EditarMateriaisGeral.Show()
    End Sub

    Private Sub ConsultaIndividualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaIndividualToolStripMenuItem1.Click
        EditarMaterialIndividual.Show()
    End Sub

    Private Sub NovoMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoMaterialToolStripMenuItem.Click
        CriarMaterial.Show()
    End Sub

    Private Sub ListaCompletaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaCompletaToolStripMenuItem.Click
        EditarMaterial.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Obrigado por usar o Simple Carpentry Manager!")
    End Sub

    Private Sub PedidoTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidoTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PedidosProximos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RelatorioCliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RelatorioPedido.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        buscarupdate.Show()
    End Sub

    Private Sub ManualDeUsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualDeUsoToolStripMenuItem.Click
        Process.Start("Manual.pdf")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        recibo1.Show()
    End Sub

    Private Sub RecibosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecibosToolStripMenuItem.Click
        recibo1.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        recibo1.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        RelatorioCliente.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Stk_TelaInicial.Show()
        Me.Close()
    End Sub

    Private Sub KalamariSoluçeosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalamariSoluçeosToolStripMenuItem.Click
        Process.Start("http://kalamarisolucoes.tk/")
    End Sub
End Class
