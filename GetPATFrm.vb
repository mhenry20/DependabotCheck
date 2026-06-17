Public Class GetPATFrm
    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        '''<summary>
        '''User has requested to continue with informaiton entered for PAT.
        '''Check if they want to save PAT in registry and then return to calling form.
        '''</summary>
        GitHubPAT = GitHubPATTbox.Text
        If StoreGitHubPATCbox.Checked Then
            SaveRegSetting(AppName, "Settings", "GitHubPat", GitHubPAT)
        End If
        Me.Dispose()
    End Sub

    Private Sub GetPATFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''<summary>
        '''Initial load of the form will set the Tbox to the existing PAT if there is one.
        '''</summary>
        GitHubPATTbox.Text = GitHubPAT
    End Sub
End Class