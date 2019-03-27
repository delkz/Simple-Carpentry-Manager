Public Class Cliente
    Private Sub ClienteTabelaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteTabelaBindingNavigatorSaveItem.Click, ClienteTabelaBindingNavigatorSaveItem.Click, ClienteTabelaBindingNavigatorSaveItem.Click, ClienteTabelaBindingNavigatorSaveItem.Click, ClienteTabelaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        ''Liberação das Text Box
        NomeTextBox.Enabled = False
        EmailTextBox.Enabled = False
        EnderecoTextBox.Enabled = False
        TelefoneTextBox.Enabled = False
        Celular1TextBox.Enabled = False
        Celular2TextBox.Enabled = False
        'LogradouroTextBox.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        ObservacoesTextBox.Enabled = False
        ClienteTabelaBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.ClienteTabela'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClienteTabelaTableAdapter.Fill(Me.MarcenariaDataSet.ClienteTabela)

        ''Bloqueio das Text Box
        NomeTextBox.Enabled = False
        EmailTextBox.Enabled = False
        EnderecoTextBox.Enabled = False
        TelefoneTextBox.Enabled = False
        Celular1TextBox.Enabled = False
        Celular2TextBox.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True
        ObservacoesTextBox.Enabled = False
        ClienteTabelaBindingNavigatorSaveItem.Enabled = False
    End Sub


    Private Sub btn_salvar_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteTabelaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        NomeTextBox.Enabled = False
        EmailTextBox.Enabled = False
        EnderecoTextBox.Enabled = False
        TelefoneTextBox.Enabled = False
        Celular1TextBox.Enabled = False
        Celular2TextBox.Enabled = False
        'LogradouroTextBox.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True
        ObservacoesTextBox.Enabled = False
        ClienteTabelaBindingNavigatorSaveItem.Enabled = False
        ' MsgBox("Salvo com sucesso", MsgBoxStyle.Information, Title:="Salvo")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ''Liberação das Text Box
        NomeTextBox.Enabled = True
        EmailTextBox.Enabled = True
        EnderecoTextBox.Enabled = True
        TelefoneTextBox.Enabled = True
        Celular1TextBox.Enabled = True
        Celular2TextBox.Enabled = True
        'LogradouroTextBox.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        ObservacoesTextBox.Enabled = True
        ClienteTabelaBindingNavigatorSaveItem.Enabled = True
    End Sub
End Class