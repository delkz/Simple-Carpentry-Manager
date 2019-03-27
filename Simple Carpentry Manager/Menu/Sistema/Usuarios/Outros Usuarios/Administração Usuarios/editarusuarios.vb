Public Class editarusuarios
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub editarusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
        Me.UsuarioTableAdapter.Fill(Me.MarcenariaDataSet.Usuario)

    End Sub
End Class