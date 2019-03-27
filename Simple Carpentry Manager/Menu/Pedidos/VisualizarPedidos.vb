Public Class VisualizarPedidos
    Private Sub PedidoTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.PedidoTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub VisualizarPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet1.PedidoTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet1.PedidoTabela)
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.PedidoTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillBy(Me.MarcenariaDataSet.PedidoTabela, ClienteToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByCodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCodigoToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillByCodigo(Me.MarcenariaDataSet.PedidoTabela, CType(CódigoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EstimativaEntregaDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillBy1(Me.MarcenariaDataSet.PedidoTabela)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim desconto, desconcal, descontototal

        desconto = (TextBox4.Text) / 100
        desconcal = ValorTextBox.Text * desconto
        descontototal = ValorTextBox.Text - desconcal


        MsgBox("Desconto de " & TextBox4.Text & "% no valor do pedido: R$" & descontototal)

    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        RelatorioPedido.Show()
    End Sub
End Class