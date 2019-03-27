Public Class Pedido
    Private Sub PedidoTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click, PedidoTabelaBindingNavigatorSaveItem.Click
        Me.Validate()

        Me.PedidoTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        ClienteComboBox.Enabled = False
        EnderecoEntregaTextBox.Enabled = False
        ValorTextBox.Enabled = False
        FormaPagamentoTextBox.Enabled = False
        DetalhesTextBox.Enabled = False
        DataPedidoDateTimePicker.Enabled = False
        EstimativaEntregaDateTimePicker.Enabled = False
        SituaçãoTextBox.Enabled = False
        EntregueCheckBox.Enabled = False

        BindingNavigatorAddNewItem.Enabled = True
        PedidoTabelaBindingNavigatorSaveItem.Enabled = False
        'MsgBox("Cadastrado com sucesso") 


    End Sub

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.ClienteTabela' table. You can move, or remove it, as needed.
        Me.ClienteTabelaTableAdapter.FillOrderByNome(Me.MarcenariaDataSet.ClienteTabela)
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.PedidoTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.PedidoTabelaTableAdapter.Fill(Me.MarcenariaDataSet.PedidoTabela)
        ClienteComboBox.Enabled = False
        EnderecoEntregaTextBox.Enabled = False
        ValorTextBox.Enabled = False
        FormaPagamentoTextBox.Enabled = False
        DetalhesTextBox.Enabled = False
        DataPedidoDateTimePicker.Enabled = False
        EstimativaEntregaDateTimePicker.Enabled = False
        SituaçãoTextBox.Enabled = False
        EntregueCheckBox.Enabled = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ClienteComboBox.Enabled = True
        EnderecoEntregaTextBox.Enabled = True
        ValorTextBox.Enabled = True
        FormaPagamentoTextBox.Enabled = True
        DetalhesTextBox.Enabled = True
        DataPedidoDateTimePicker.Enabled = True
        EstimativaEntregaDateTimePicker.Enabled = True
        SituaçãoTextBox.Enabled = True

        BindingNavigatorAddNewItem.Enabled = False
        PedidoTabelaBindingNavigatorSaveItem.Enabled = True
        EntregueCheckBox.Enabled = True

        EstimativaEntregaDateTimePicker.Value = Today
        DataPedidoDateTimePicker.Value = Today


    End Sub

    Private Sub SituaçãoTextBox_TextChanged(sender As Object, e As EventArgs) Handles SituaçãoTextBox.TextChanged

    End Sub

    Private Sub SituaçãoLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class