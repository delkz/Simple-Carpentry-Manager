Public Class buscarupdate

    Private Sub buscarupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_Versaoinstalada.Text = VersaoSistema
        LB_Versaorecente.Text = NovaVersao
        LinkLabel3.Links.Add(0, 0, "http://simplecarpentrymanager.tk/")
        LinkLabel2.Links.Add(0, 0, LocalDownload)
        Label5.Text = dirlocal

        If NovaVersao <> VersaoSistema Then
            If NovaVersao = "Servidor Indisponivel" Then
                LinkLabel2.Links.Add(0, 0, LocalDownload)
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(dirlocal)
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub


    Private Sub buscarupdbtn_Click(sender As Object, e As EventArgs) Handles buscarupdbtn.Click
        If My.Computer.Network.IsAvailable Then

            Try
                Dim web As New Net.WebClient
                NovaVersao = web.DownloadString("https://simplecarpentrymanager.000webhostapp.com/scm/versioncheck.txt")
                LocalDownload = web.DownloadString("https://simplecarpentrymanager.000webhostapp.com/scm/versionlocate.txt")
                LB_Versaorecente.Text = NovaVersao

                If NovaVersao <> VersaoSistema Then
                    MessageBox.Show("Foi encontrada uma versão diferente da instalada atualmente.")
                Else
                    MsgBox("Não Foram encontradas atualizações")
                End If

            Catch ex As Exception
                MsgBox("Servidor Indisponivel, tente novamente mais tarde.")
                NovaVersao = "Servidor Indisponivel"
                LocalDownload = "Servidor Indisponivel"


            End Try
        Else
            NovaVersao = "Servidor Indisponivel"
            LocalDownload = "Servidor Indisponivel"
        End If


    End Sub


End Class

