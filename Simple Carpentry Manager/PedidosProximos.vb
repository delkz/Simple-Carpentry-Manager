Public Class PedidosProximos

    Private Sub PedidoTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PedidoTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub PedidosProximos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.PedidoTabela' table. You can move, or remove it, as needed.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)
        Try
            Me.PedidoTabelaTableAdapter.FillBy2(Me.MarcenariaDataSet.PedidoTabela)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillBy2ToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        VisualizarPedidos.Show()
    End Sub
End Class