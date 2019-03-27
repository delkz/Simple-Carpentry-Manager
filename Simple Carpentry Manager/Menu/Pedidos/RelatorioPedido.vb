Public Class RelatorioPedido

    Private Sub RelatorioPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.ClienteTabela' table. You can move, or remove it, as needed.
        Me.ClienteTabelaTableAdapter.Fill(Me.MarcenariaDataSet.ClienteTabela)
        'TODO: This line of code loads data into the 'MarcenariaDataSet.PedidoTabela' table. You can move, or remove it, as needed.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class