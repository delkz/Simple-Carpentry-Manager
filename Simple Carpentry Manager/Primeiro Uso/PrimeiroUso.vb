Public Class PrimeiroUsoCriarUsuario
    Private Sub PrimeiroUso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.variaveisSistema' table. You can move, or remove it, as needed.
        Me.VariaveisSistemaTableAdapter.Fill(Me.MarcenariaDataSet.variaveisSistema)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.VariaveisSistemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)
        If VariaveisSistemaTableAdapter.ScalarQueryLoginSistema = "On" Then
            SistemaLogin = "On"
            PU_CriarUser.Show()
            Me.Close()
        Else
            lvlacss = 1
            usuariolog = "Padrão"
            SistemaLogin = "Off"
            PU_FINAL.Show()
            Me.Close()
        End If

    End Sub
End Class