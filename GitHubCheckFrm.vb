

Public Class GitHubCheckFrm
    ''' <summary>
    ''' This is the main form for processing through github.com repos counting
    ''' dependabot alerts
    ''' </summary>

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        '''<summary>
        '''Exit button logic
        '''</summary>
        Application.Exit()
    End Sub

    Private Sub GitHubCheckFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''<summary>
        ''' Initial logic when loading the form.  Check for PAT and display PAT entry
        ''' form if it is blank.
        '''</summary>
        ConnectionLbl.Text = "Disconnected"
        GitHubPAT = GetRegSetting(AppName, "Settings", "GitHubPAT", "")
        If GitHubPAT = "" Then
            Dim MyGetPatFrm As Form = New GetPATFrm()
            MyGetPatFrm.ShowDialog()
        Else
            ConnectionLbl.Text = "Using Stored GitHub PAT"
        End If


    End Sub

    Private Async Sub GetReposBtn_Click(sender As Object, e As EventArgs) Handles GetReposBtn.Click
        '''<summary>
        '''User request to process repositories.
        '''</summary>
        Await ProcessRepositoriesAsync(Me)
    End Sub

    Private Sub UpdateGithubPatBtn_Click(sender As Object, e As EventArgs) Handles UpdateGithubPatBtn.Click
        '''<summary>
        '''User request to change PAT
        '''</summary>
        Dim MyGetPatFrm As Form = New GetPATFrm()
        MyGetPatFrm.ShowDialog()

    End Sub
End Class
