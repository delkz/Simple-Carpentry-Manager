Public Class Stk_ProdutosNovo
    Private Sub EstoqueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstoqueBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstoqueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        NomeTextBox.Enabled = False
        ValorTextBox.Enabled = False
        QuantidadeTextBox.Enabled = False
        FornecedorTextBox.Enabled = False

        BindingNavigatorAddNewItem.Enabled = True
        EstoqueBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub Stk_ProdutosNovo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.EstoqueTableAdapter.Fill(Me.MarcenariaDataSet.Estoque)
        ''Bloqueio das textbox
        NomeTextBox.Enabled = False
        ValorTextBox.Enabled = False
        QuantidadeTextBox.Enabled = False
        FornecedorTextBox.Enabled = False

        BindingNavigatorAddNewItem.Enabled = True
        EstoqueBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        NomeTextBox.Enabled = True
        ValorTextBox.Enabled = True
        QuantidadeTextBox.Enabled = True
        FornecedorTextBox.Enabled = True

        BindingNavigatorAddNewItem.Enabled = False
        EstoqueBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class