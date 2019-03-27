Public Class RelatorioCliente

    Private Sub Teste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.PedidoTabela' table. You can move, or remove it, as needed.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)
        'TODO: This line of code loads data into the 'MarcenariaDataSet.ClienteTabela' table. You can move, or remove it, as needed.
        Me.ClienteTabelaTableAdapter.Fill(Me.MarcenariaDataSet.ClienteTabela)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class