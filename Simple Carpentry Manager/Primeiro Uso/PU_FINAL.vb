Public Class PU_FINAL

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.Checked = True Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VariaveisSistemaTableAdapter.UpdateQueryPrimeiroUso()
        TelaInicial.Show()
        Me.Close()

    End Sub

    Private Sub PU_FINAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub
End Class