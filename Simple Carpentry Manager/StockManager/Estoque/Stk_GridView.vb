Public Class Stk_GridView
    Private Sub Stk_GridView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)

    End Sub

    Private Sub EstoquePesquisaPorCodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles EstoquePesquisaPorCodigoToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.EstoquePesquisaPorCodigo(Me.MarcenariaDataSet.Estoque, CType(CodigoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EstoqueConsultapornomeToolStripButton_Click(sender As Object, e As EventArgs) Handles EstoqueConsultapornomeToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.EstoqueConsultapornome(Me.MarcenariaDataSet.Estoque, NomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '  Private Sub CodigoToolStripTextBox_textchanged(sender As Object, e As EventArgs) Handles CodigoToolStripTextBox.TextChanged
    '   Me.EstoqueBindingSource.Filter = "Codigo like '%" & CodigoToolStripTextBox.Text & "%'"
    '   End Sub

    '   Private Sub NomeToolStripTextBox_textchanged(sender As Object, e As EventArgs) Handles NomeToolStripTextBox.TextChanged
    '   Me.EstoqueBindingSource.Filter = "Nome like '%" & NomeToolStripLabel.Text & "%'"
    '    End Sub

    Private Sub ESTOQUESelecionartodosToolStripButton_Click(sender As Object, e As EventArgs) Handles ESTOQUESelecionartodosToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.ESTOQUESelecionartodos(Me.MarcenariaDataSet.Estoque)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class