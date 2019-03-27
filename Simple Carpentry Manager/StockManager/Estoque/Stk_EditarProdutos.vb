Public Class Stk_EditarProdutos
    Private Sub EstoqueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstoqueBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub Stk_EditarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)

    End Sub



    Private Sub EstoqueConsultapornomeToolStripButton_Click(sender As Object, e As EventArgs) Handles EstoqueConsultapornomeToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.EstoqueConsultapornome(Me.MarcenariaDataSet.Estoque, NomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub EstoquePesquisaPorCodigoToolStripButton_Click(sender As Object, e As EventArgs) Handles EstoquePesquisaPorCodigoToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.EstoquePesquisaPorCodigo(Me.MarcenariaDataSet.Estoque, CType(CodigoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByTodosToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ESTOQUESelecionartodosToolStripButton_Click(sender As Object, e As EventArgs) Handles ESTOQUESelecionartodosToolStripButton.Click
        Try
            Me.EstoqueTableAdapter.ESTOQUESelecionartodos(Me.MarcenariaDataSet.Estoque)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Remover_Click(sender As Object, e As EventArgs) Handles Btn_Remover.Click
        If TextBox1.Text = "" Then
            MsgBox("Erro ao salvar: é necessario inserir um valor")
        Else
            If QuantidadeTextBox.Text > 0 Then
                If QuantidadeTextBox.Text - TextBox1.Text >= 0 Then
                    Try
                        Me.EstoqueTableAdapter.SaidaProdutosQuerry(TextBox1.Text, CodigoTextBox.Text)
                        MsgBox("Salvo com sucesso.")
                    Catch ex As Exception
                        MsgBox("Erro ao salvar: " & ex.ToString)
                    End Try
                    Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)
                Else
                    MsgBox("Erro ao salvar: Estoque não é suficiente")
                End If
            Else
                MsgBox("Erro ao salvar: Estoque Zerado")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        If TextBox1.Text = "" Then
            MsgBox("Erro ao salvar: é necessario inserir um valor")
        Else
            Try
                Me.EstoqueTableAdapter.EntradaProdutosQuerry(TextBox1.Text, CodigoTextBox.Text)
                MsgBox("Salvo com sucesso.")
            Catch ex As Exception
                MsgBox("Erro ao salvar: " & ex.ToString)
            End Try

            Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)
        End If
       
    End Sub
End Class