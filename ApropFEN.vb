Public Class ApropFEN
    Private Sub Ctrub_Click(sender As Object, e As EventArgs) Handles ctrub.Click
        CONTRIB.Visible = True
    End Sub

    Private Sub CFOTO_Click(sender As Object, e As EventArgs) Handles CFOTO.Click
        CimagFEN.Visible = True
    End Sub

    Private Sub GitHubTXT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHubTXT.LinkClicked
        RGithub.Start()
    End Sub
End Class