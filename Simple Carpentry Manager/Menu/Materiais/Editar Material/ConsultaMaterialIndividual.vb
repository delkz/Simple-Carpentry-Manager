Public Class EditarMaterialIndividual

    Private Sub MateriaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MateriaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

    End Sub

    Private Sub ConsultaMaterialIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.Materiais' table. You can move, or remove it, as needed.
        Me.MateriaisTableAdapter.Fill(Me.MarcenariaDataSet.Materiais)

    End Sub

    Private Sub FillByCodigoChapaToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCodigoChapaToolStripButton.Click
        Try
            Me.MateriaisTableAdapter.FillByCodigoChapa(Me.MarcenariaDataSet.Materiais, CodChapaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.MateriaisTableAdapter.FillBy1(Me.MarcenariaDataSet.Materiais, NomeChapaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByCorToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByCorToolStripButton.Click
        Try
            Me.MateriaisTableAdapter.FillByCor(Me.MarcenariaDataSet.Materiais, CorToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByAllToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByAllToolStripButton.Click
        Try
            Me.MateriaisTableAdapter.FillByAll(Me.MarcenariaDataSet.Materiais)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class