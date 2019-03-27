Public Class editarpedido
    Private Sub PedidoTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PedidoTabelaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PedidoTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)
        MsgBox("Salvo com sucesso")
    End Sub

    Private Sub editarpedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.PedidoTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)

    End Sub

    Private Sub FillByCodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCodigoToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillByCodigo(Me.MarcenariaDataSet.PedidoTabela, CType(CódigoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillBy(Me.MarcenariaDataSet.PedidoTabela, ClienteToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.PedidoTabelaTableAdapter.FillBy1(Me.MarcenariaDataSet.PedidoTabela)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class