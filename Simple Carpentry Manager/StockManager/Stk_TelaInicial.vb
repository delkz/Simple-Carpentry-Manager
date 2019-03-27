Public Class Stk_TelaInicial
    Private Sub VoltarSCMButton_Click(sender As Object, e As EventArgs) Handles VoltarSCMButton.Click
        TelaInicial.Show()
        Me.Close()
    End Sub

    Private Sub Stk_TelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(41, 0, 87)
        Me.Text = VersaoSistema + " | Conectado com o perfil " + usuariolog

        If lvlacss = 0 Then
            ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = False
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Stk_GridView.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Stk_Entrada.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Stk_Saida.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If lvlacss = 0 Then
            MsgBox("Você Não tem permissão necessaria para essa ação")
        Else
            Stk_ProdutosNovo.Show()
        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If lvlacss = 0 Then
            MsgBox("Você Não tem permissão necessaria para essa ação")
        Else
            Stk_EditarProdutos.Show()
        End If

    End Sub
End Class