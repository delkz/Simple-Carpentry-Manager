Public Class EditarMateriaisGeral

    Private Sub MateriaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MateriaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MateriaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub ConsultaMateriaisGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.Materiais' table. You can move, or remove it, as needed.
        Me.MateriaisTableAdapter.Fill(Me.MarcenariaDataSet.Materiais)

    End Sub

    Private Sub FillByCodigoChapaToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillByCodigoChapa(Me.MarcenariaDataSet.Materiais, CodChapaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByCorToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillByCor(Me.MarcenariaDataSet.Materiais, CorToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillBy1(Me.MarcenariaDataSet.Materiais, NomeChapaToolStripTextBox.Text)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByAllToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MateriaisTableAdapter.FillByAll(Me.MarcenariaDataSet.Materiais)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub NomeChapaToolStripTextBox_textChanged(sender As Object, e As EventArgs) Handles NomeChapaToolStripTextBox.TextChanged
        Me.MateriaisBindingSource.Filter = "NomeChapa like '%" & NomeChapaToolStripTextBox.Text & "%'"
    End Sub

    Private Sub CorToolStripTextBox_textChanged(sender As Object, e As EventArgs) Handles CorToolStripTextBox.TextChanged
        Me.MateriaisBindingSource.Filter = "Cor like '%" & CorToolStripTextBox.Text & "%'"
    End Sub

    Private Sub CodChapaToolStripTextBox_textChanged(sender As Object, e As EventArgs) Handles CodChapaToolStripTextBox.TextChanged
        Me.MateriaisBindingSource.Filter = "CodChapa like '%" & CodChapaToolStripTextBox.Text & "%'"
    End Sub

    Private Sub DimensoesToolStripTextBox1_textChanged(sender As Object, e As EventArgs) Handles DimensoesToolStripTextBox1.TextChanged
        Me.MateriaisBindingSource.Filter = "Expressura like '%" & DimensoesToolStripTextBox1.Text & "%'"
    End Sub

    Private Sub CodChapaToolStripTextBox_Click(sender As Object, e As EventArgs) Handles CodChapaToolStripTextBox.Click

    End Sub
End Class