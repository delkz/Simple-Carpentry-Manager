Public Class CriarMaterial

    Private Sub MateriaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MateriaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)
        CodChapaTextBox.Enabled = False
        NomeChapaTextBox.Enabled = False
        ExpressuraTextBox.Enabled = False
        CorTextBox.Enabled = False
        FornecedorTextBox.Enabled = False
        Valor_porchapa_TextBox.Enabled = False
        MateriaisBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True

    End Sub

    Private Sub CriarMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.Materiais' table. You can move, or remove it, as needed.
        Me.MateriaisTableAdapter.Fill(Me.MarcenariaDataSet.Materiais)
        'TODO: This line of code loads data into the 'MarcenariaDataSet.Materiais' table. You can move, or remove it, as needed.
        'Me.MateriaisTableAdapter.Fill(Me.MarcenariaDataSet.Materiais)
        CodChapaTextBox.Enabled = False
        NomeChapaTextBox.Enabled = False
        ExpressuraTextBox.Enabled = False
        CorTextBox.Enabled = False
        FornecedorTextBox.Enabled = False
        Valor_porchapa_TextBox.Enabled = False
        MateriaisBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MateriaisBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MateriaisBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles MateriaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MateriaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        CodChapaTextBox.Enabled = False
        NomeChapaTextBox.Enabled = False
        ExpressuraTextBox.Enabled = False
        CorTextBox.Enabled = False
        FornecedorTextBox.Enabled = False
        Valor_porchapa_TextBox.Enabled = False
        MateriaisBindingNavigatorSaveItem.Enabled = False
        MsgBox("Salvo com sucesso")
    End Sub


    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillBy(Me.MarcenariaDataSet.Materiais)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BindingNavigatorAddNewItem_Click_1(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CodChapaTextBox.Enabled = True
        NomeChapaTextBox.Enabled = True
        ExpressuraTextBox.Enabled = True
        CorTextBox.Enabled = True
        FornecedorTextBox.Enabled = True
        Valor_porchapa_TextBox.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        MateriaisBindingNavigatorSaveItem.Enabled = True


    End Sub
End Class