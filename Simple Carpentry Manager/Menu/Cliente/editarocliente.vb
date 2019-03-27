Public Class editarocliente

    Private Sub ClienteTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteTabelaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        MsgBox("Salvo com sucesso")

    End Sub

    Private Sub editarocliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.ClienteTabela' table. You can move, or remove it, as needed.
        Me.ClienteTabelaTableAdapter.Fill(Me.MarcenariaDataSet.ClienteTabela)

    End Sub

    Private Sub FillBynomesToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ClienteTabelaTableAdapter.FillBynomes(Me.MarcenariaDataSet.ClienteTabela, NomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBynomesToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillBynomesToolStripButton.Click
        Try
            Me.ClienteTabelaTableAdapter.FillBynomes(Me.MarcenariaDataSet.ClienteTabela, NomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBycodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBycodigoToolStripButton.Click
        Try
            Me.ClienteTabelaTableAdapter.FillBycodigo(Me.MarcenariaDataSet.ClienteTabela, CType(CódigoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByTodosToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByTodosToolStripButton.Click
        Try
            Me.ClienteTabelaTableAdapter.FillByTodos(Me.MarcenariaDataSet.ClienteTabela)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class