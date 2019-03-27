Public Class login

    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'MarcenariaDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
        'Me.UsuarioTableAdapter.Fill(Me.MarcenariaDataSet.Usuario)
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim usuario As String
        'Dim senha As String
        'Dim adm As String

        usuariolog = UsernameTextBox.Text
        senhalog = PasswordTextBox.Text


        If Me.UsuarioTableAdapter.ScalarQuerylogin(usuariolog, senhalog) Then

            If Me.UsuarioTableAdapter.permissaocomparar(usuariolog, senhalog) = "adm" Then
                lvlacss = 1
            End If

            TelaInicial.Show()
            Me.Close()
            Else
            MsgBox("Nome de usuario ou senha invalido")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastro.Show()
    End Sub


    Private Sub VerificarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles VerificarSenha.CheckedChanged
        If VerificarSenha.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class