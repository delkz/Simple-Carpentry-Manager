Public Class visualizarclientes
    Private Sub ClienteTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub visualizarclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.ClienteTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClienteTabelaTableAdapter.Fill(Me.MarcenariaDataSet.ClienteTabela)

        ''Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub FillBycodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBycodigoToolStripButton.Click
        Try
            Me.ClienteTabelaTableAdapter.FillBycodigo(Me.MarcenariaDataSet.ClienteTabela, CType(CódigoToolStripTextBox1.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBynomesToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillBynomesToolStripButton1.Click
        Try
            Me.ClienteTabelaTableAdapter.FillBynomes(Me.MarcenariaDataSet.ClienteTabela, NomeToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub NomeTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomeTextBox.TextChanged

    End Sub

    Private Sub CódigoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CódigoTextBox.TextChanged

    End Sub

    Private Sub FillByTodosToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByTodosToolStripButton.Click
        Try
            Me.ClienteTabelaTableAdapter.FillByTodos(Me.MarcenariaDataSet.ClienteTabela)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        RelatorioCliente.Show()
    End Sub
End Class