<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GitHubCheckFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ConnectionLbl = New Label()
        ExitBtn = New Button()
        RepoListView = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        GetReposBtn = New Button()
        UpdateGithubPatBtn = New Button()
        SuspendLayout()
        ' 
        ' ConnectionLbl
        ' 
        ConnectionLbl.AutoSize = True
        ConnectionLbl.Location = New Point(25, 20)
        ConnectionLbl.Name = "ConnectionLbl"
        ConnectionLbl.Size = New Size(142, 15)
        ConnectionLbl.TabIndex = 0
        ConnectionLbl.Text = "Connected/Disconnected"
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(218, 415)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(75, 23)
        ExitBtn.TabIndex = 1
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' RepoListView
        ' 
        RepoListView.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        RepoListView.FullRowSelect = True
        RepoListView.GridLines = True
        RepoListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
        RepoListView.Location = New Point(20, 49)
        RepoListView.Name = "RepoListView"
        RepoListView.Size = New Size(470, 360)
        RepoListView.Sorting = SortOrder.Ascending
        RepoListView.TabIndex = 2
        RepoListView.UseCompatibleStateImageBehavior = False
        RepoListView.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Repository"
        ColumnHeader1.Width = 160
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Dependabot Alert Count"
        ColumnHeader2.Width = 160
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Last Update"
        ColumnHeader3.Width = 160
        ' 
        ' GetReposBtn
        ' 
        GetReposBtn.Location = New Point(229, 16)
        GetReposBtn.Name = "GetReposBtn"
        GetReposBtn.Size = New Size(75, 23)
        GetReposBtn.TabIndex = 3
        GetReposBtn.Text = "Get Repos"
        GetReposBtn.UseVisualStyleBackColor = True
        ' 
        ' UpdateGithubPatBtn
        ' 
        UpdateGithubPatBtn.Location = New Point(359, 16)
        UpdateGithubPatBtn.Name = "UpdateGithubPatBtn"
        UpdateGithubPatBtn.Size = New Size(126, 23)
        UpdateGithubPatBtn.TabIndex = 4
        UpdateGithubPatBtn.Text = "Update Github PAT"
        UpdateGithubPatBtn.UseVisualStyleBackColor = True
        ' 
        ' GitHubCheckFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(510, 448)
        Controls.Add(UpdateGithubPatBtn)
        Controls.Add(GetReposBtn)
        Controls.Add(RepoListView)
        Controls.Add(ExitBtn)
        Controls.Add(ConnectionLbl)
        Name = "GitHubCheckFrm"
        Text = "Henry Solutions Check for Dependabot Alerts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ConnectionLbl As Label
    Friend WithEvents ExitBtn As Button
    Friend WithEvents RepoListView As ListView
    Friend WithEvents GetReposBtn As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents UpdateGithubPatBtn As Button

End Class
