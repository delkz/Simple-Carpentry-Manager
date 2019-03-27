Public Class EditarMaterial

    Private Sub MateriaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MateriaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MateriaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)
        MsgBox("Salvo com sucesso")

    End Sub

    Private Sub EditarMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.Materiais' table. You can move, or remove it, as needed.
        Me.MateriaisTableAdapter.Fill(Me.MarcenariaDataSet.Materiais)

    End Sub

    ''Consultas
    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Me.MateriaisBindingSource.Filter = "Codchapa like '%" & ToolStripTextBox1.Text & "%'"
    End Sub

    Private Sub ToolStripTextBox2_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox2.TextChanged
        Me.MateriaisBindingSource.Filter = "NomeChapa like '%" & ToolStripTextBox2.Text & "%'"
    End Sub

    Private Sub ToolStripTextBox3_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox3.TextChanged
        Me.MateriaisBindingSource.Filter = "Cor like '%" & ToolStripTextBox3.Text & "%'"
    End Sub

    Private Sub ToolStripTextBox4_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox4.TextChanged
        Me.MateriaisBindingSource.Filter = "Expressura like '%" & ToolStripTextBox4.Text & "%'"
    End Sub

    Private Sub FillByAll1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillByAll1(Me.MarcenariaDataSet.Materiais)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class