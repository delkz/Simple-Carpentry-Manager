Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class recibo1
    Dim Rec_Cliente, Rec_Valor, Rec_Data, Rec_Presente, Rec_Correspondente, Rec_Valor_total, Rec_Nome, Rec_Texto As String

    Public Sub ReciboText()
        Rec_Texto = "
        ' =============================================================
        '
        ' Recebi(emos) de : " + ClienteTxtbox.Text + "
        ' A quantia de : " + Quantiatxtbox.Text + "
        ' Correspondente a:  " + CorrespondenTxtbox.Text + "
        ' E para maior clareza, afirmo o presente: ________________________________________
        '
        '
        ' Outras Observações:______________________________________________________
        '                    ______________________________________________________
        '	                 ______________________________________________________
        '	                 ______________________________________________________

        '
        '
        ' " + Rec_Data + "
        '
        '
        '
        ' _______________________________     
        '         Assinatura

        ' =============================================================
        "
    End Sub

    Private Sub CorrespondenTxtbox_TextChanged(sender As Object, e As EventArgs) Handles CorrespondenTxtbox.TextChanged
        Rec_Cliente = ClienteTxtbox.Text
        Rec_Valor = Quantiatxtbox.Text
        Rec_Correspondente = CorrespondenTxtbox.Text
        ReciboText()
        RichTextBox1.Text = Rec_Texto
    End Sub

    Private Sub Quantiatxtbox_TextChanged(sender As Object, e As EventArgs) Handles Quantiatxtbox.TextChanged
        Rec_Cliente = ClienteTxtbox.Text
        Rec_Valor = Quantiatxtbox.Text
        Rec_Correspondente = CorrespondenTxtbox.Text
        ReciboText()
        RichTextBox1.Text = Rec_Texto

    End Sub

    Private Sub ClienteTxtbox_TextChanged(sender As Object, e As EventArgs) Handles ClienteTxtbox.TextChanged
        Rec_Cliente = ClienteTxtbox.Text
        Rec_Valor = Quantiatxtbox.Text
        Rec_Correspondente = CorrespondenTxtbox.Text
        ReciboText()
        RichTextBox1.Text = Rec_Texto

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(My.Computer.FileSystem.SpecialDirectories.Desktop)
    End Sub

    Private Sub btncriar_Click(sender As Object, e As EventArgs) Handles btncriar.Click

        Rec_Cliente = ClienteTxtbox.Text
        Rec_Valor = Quantiatxtbox.Text
        Rec_Correspondente = CorrespondenTxtbox.Text
        Rec_Data = DataSistema

        RichTextBox1.Text = Rec_Texto

        If Not String.IsNullOrEmpty(CaminhoTxtbox.Text) And Not String.IsNullOrEmpty(TextBox2.Text) Then

            Rec_Nome = TextBox2.Text
            If File.Exists(CaminhoTxtbox.Text + Rec_Nome) Then
                MsgBox("Já existe um arquivo com esse nome. Renomeie e tente novamente")

            Else
                Dim pdfDoc As New Document
                Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(CaminhoTxtbox.Text + Rec_Nome, FileMode.Create))

                pdfDoc.Open()

                pdfDoc.Add(New Paragraph(RichTextBox1.Text))
                pdfDoc.Close()

                MsgBox("Recibo Gerado com sucesso. Local:" + CaminhoTxtbox.Text + Rec_Nome)
            End If



        Else
            MsgBox("Preencha todos os campos obrigatorios")
        End If


    End Sub

    Private Sub recibo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Rec_Data = DataSistema
        CaminhoTxtbox.Text = My.Computer.FileSystem.SpecialDirectories.Desktop + "\"
        ReciboText()
        RichTextBox1.Text = Rec_Texto


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        'Define as propriedades do controle FolderBrowserDialog

        fbd1.Description = "Selecione uma pasta para realizar o Backup"
        fbd1.RootFolder = Environment.SpecialFolder.MyComputer
        fbd1.ShowNewFolderButton = True

        'Exibe a caixa de diálogo
        If fbd1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Exibe a pasta selecionada
            CaminhoTxtbox.Text = fbd1.SelectedPath + "\"


        End If
    End Sub
End Class