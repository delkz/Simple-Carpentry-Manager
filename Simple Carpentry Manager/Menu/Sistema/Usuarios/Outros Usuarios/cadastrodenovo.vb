Public Class cadastrodenovo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        Dim username2 As String
        Dim password2 As String

        username2 = UsernameTextBox.Text
        password2 = PasswordTextBox.Text

        If Me.UsuarioTableAdapter.InsertQueryUsuario(username2, password2) Then
            MsgBox("Cadastrado com sucesso")
            Me.Close()
        Else
            MsgBox("Erro ao Cadastrar,Favor Verifique")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTextBox.UseSystemPasswordChar = ""
        Else
            PasswordTextBox.UseSystemPasswordChar = "*"
        End If
    End Sub
End Class