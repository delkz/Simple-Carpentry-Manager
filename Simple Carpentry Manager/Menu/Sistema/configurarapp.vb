Public Class configurarapp

    Private Sub VariaveisSistemaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VariaveisSistemaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VariaveisSistemaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MarcenariaDataSet)

        If TelacheiaChkBox.Checked Then
            TelaCheias = True
        Else
            TelaCheias = False
        End If


        If TelaCheias = True Then
            Me.VariaveisSistemaTableAdapter.UpdateQueryTelacheia(True)
        Else
            Me.VariaveisSistemaTableAdapter.UpdateQueryTelacheia(False)
        End If


        If DbLoginSistemaComboBox.SelectedValue = "Off" Then
            SistemaLogin = "Off"
        End If

        MsgBox("Reinicie para aplicar modificações")


    End Sub

    Private Sub configurarapp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MarcenariaDataSet.variaveisSistema' table. You can move, or remove it, as needed.
        Me.VariaveisSistemaTableAdapter.Fill(Me.MarcenariaDataSet.variaveisSistema)
        If lvlacss = 0 Then
            DbLoginSistemaComboBox.Enabled = False
        End If
        Label2.Text = dirlocal

        If TelaCheias = True Then
            TelacheiaChkBox.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buscarupdate.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        changlog.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(dirlocal)
    End Sub
End Class