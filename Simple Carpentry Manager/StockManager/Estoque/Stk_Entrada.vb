Public Class Stk_Entrada
    Private Sub EstoqueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)



    End Sub

    Private Sub Stk_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Me.EstoqueTableAdapter.EntradaProdutosQuerry(TextBox1.Text, CodigoTextBox.Text)
            MsgBox("Salvo com sucesso.")
        Catch ex As Exception
            MsgBox("Erro ao salvar: " & ex.ToString)
        End Try

        Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)
    End Sub

    Private Sub EstoqueBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles EstoqueBindingNavigator.RefreshItems

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Stk_Saida.Show()
        Me.Close()
    End Sub

    Private Sub EstoqueConsultapornomeToolStripButton_Click(sender As Object, e As EventArgs) Handles EstoqueConsultapornomeToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.EstoqueConsultapornome(Me.MarcenariaDataSet.Estoque, NomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub ESTOQUESelecionartodosToolStripButton_Click(sender As Object, e As EventArgs) Handles ESTOQUESelecionartodosToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.ESTOQUESelecionartodos(Me.MarcenariaDataSet.Estoque)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class