Imports Microsoft.Win32
Imports Octokit

Module MainMod
    ''' <summary>
    ''' Main Module containing code for the application
    ''' </summary>

    Public AppName As String = "GitHubCheck"
    Public AppVersion As String = "1.0.0"
    Public GitHubPAT As String = ""

    Async Function ProcessRepositoriesAsync(ReqForm As GitHubCheckFrm) As Task
        ''' <summary>
        ''' Connects to api.github.com to find all owned repositories.  Each repository
        ''' is used to select dependabot alerts and report the count.  A rolw for each
        ''' repo is added to the list on the main form(GitHubCheckFrm).
        ''' </summary>
        ''' <param name="ReqForm">The form requesting the information</param>
        Dim githubToken As String = GitHubPAT
        Dim client As New GitHubClient(New ProductHeaderValue("DependabotChecker"))
        client.Credentials = New Credentials(githubToken)
        Dim TotalopenAlerts As Integer

        Try

            ReqForm.ConnectionLbl.Text = "Fetching your repositories..."

            Dim repoOptions As New RepositoryRequest() With {
                .Affiliation = RepositoryAffiliation.Owner
            }

            Dim pagingOptions As New ApiOptions() With {
                .PageCount = 1,   ' Only fetch 1 page of results
                .PageSize = 30    ' Limit that page to exactly 10 items (Max allowed by GitHub is 100 per page)
             }


            Dim repositories = Await client.Repository.GetAllForCurrent(repoOptions, pagingOptions)

            ReqForm.ConnectionLbl.Text = $"Found {repositories.Count} repositories."

            For Each repo In repositories
                Dim repoName As String = repo.Name
                Dim owner As String = repo.Owner.Login
                ' Get the last update date
                Dim lastUpdated As String = repo.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss")
                Dim alertCountDisplay As String = ""
                Dim openAlerts As Integer = 0

                Try

                    Dim dependabotUrl As New Uri($"https://api.github.com/repos/{owner}/{repoName}/dependabot/alerts?per_page=100")

                    Dim response = Await client.Connection.Get(Of List(Of GitHubDependabotAlert))(dependabotUrl, Nothing, Nothing)

                    If response.Body IsNot Nothing Then
                        ' Count how many alerts have a state of "open"
                        openAlerts = response.Body.Where(Function(a) a.State = "open").Count()
                        alertCountDisplay = openAlerts.ToString()
                        TotalopenAlerts += openAlerts
                    End If

                Catch ex As ApiException When ex.StatusCode = System.Net.HttpStatusCode.NotFound
                    ' 404 means Dependabot is disabled on this repo or you don't have security access
                    alertCountDisplay = "Disabled/No Access"
                Catch ex As Exception
                    alertCountDisplay = "Error"
                End Try

                Dim item As New ListViewItem(repoName)
                If openAlerts > 0 Then
                    item.BackColor = Color.LightPink
                End If
                item.SubItems.Add(alertCountDisplay)
                item.SubItems.Add(lastUpdated)


                ReqForm.RepoListView.Items.Add(item)


            Next
            If TotalopenAlerts > 0 Then
                ReqForm.RepoListView.Sort()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.ToString()}")
        End Try
    End Function

    Public Class GitHubDependabotAlert
        Public Property State As String
    End Class

    Public Sub SaveRegSetting(ByVal AppName As String, ByVal Section As String,
                              ByVal Key As String, ByRef Value As String)
        ''' <summary>
        ''' Creates a HenrySolutions registry key for application name in AppName.  With the
        ''' given key and value and in the given section.
        ''' </summary>
        ''' <param name="AppName">The name of the application that will store the key.</param>
        ''' <param name="Section">Can be a sub section for the keys</param>
        ''' <param name="Key">The name of the setting key.</param>
        ''' <param name="Value">The value for the key.</param>
        ''' 
        Dim regKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Henry Solutions\" & AppName & "\" & Section)

        If regKey IsNot Nothing Then
            regKey.SetValue(Key, Value)
        End If

    End Sub

    Public Function GetRegSetting(ByVal AppName As String, ByVal Section As String,
                             ByVal Key As String, ByVal DefaultValue As String) As String
        ''' <summary>
        ''' Reads a HenrySolutions registry key for application name in AppName.  With the
        ''' given key and value and in the given section.
        ''' </summary>
        ''' <param name="AppName">The name of the application that will store the key.</param>
        ''' <param name="Section">Can be a sub section for the keys</param>
        ''' <param name="Key">The name of the setting key.</param>
        ''' <param name="DefaultValue">The value for the key if it does not exist.</param>
        '''

        Dim result As String

        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Henry Solutions\" & AppName & "\" & Section, False)

        If regKey IsNot Nothing Then
            result = regKey.GetValue(Key, DefaultValue).ToString()
            regKey.Close()
        Else
            result = DefaultValue
        End If
        Return result

    End Function
End Module
