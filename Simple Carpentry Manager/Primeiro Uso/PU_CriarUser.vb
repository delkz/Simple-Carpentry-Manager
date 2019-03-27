Public Class PU_CriarUser

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.VariaveisSistemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        Dim username2 As String
        Dim password2 As String
        Dim perm As String

        username2 = UsernameTextBox.Text
        password2 = PasswordTextBox.Text
        perm = "adm"

        Me.UsuarioTableAdapter.DeleteQueryAdm()

        If Me.UsuarioTableAdapter.InsertQueryPrimeiroUso(username2, password2, perm) Then
            lvlacss = 1
            usuariolog = UsernameTextBox.Text
            PU_FINAL.Show()
            Me.Close()
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub
End Class