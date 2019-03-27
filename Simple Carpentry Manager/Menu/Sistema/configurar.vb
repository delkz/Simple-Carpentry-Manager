Public Class configurar

    Private Sub VariaveisSistemaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VariaveisSistemaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VariaveisSistemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub configurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.variaveisSistema' table. You can move, or remove it, as needed.
        Me.VariaveisSistemaTableAdapter.Fill(Me.MarcenariaDataSet.variaveisSistema)

    End Sub
End Class