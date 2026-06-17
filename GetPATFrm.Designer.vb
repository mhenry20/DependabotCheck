<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetPATFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        GitHubPATTbox = New TextBox()
        ContinueBtn = New Button()
        CancelBtn = New Button()
        StoreGitHubPATCbox = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 0
        Label1.Text = "Github PAT:"
        ' 
        ' GitHubPATTbox
        ' 
        GitHubPATTbox.Location = New Point(86, 15)
        GitHubPATTbox.Name = "GitHubPATTbox"
        GitHubPATTbox.PlaceholderText = "Github Personal Access Token"
        GitHubPATTbox.Size = New Size(310, 23)
        GitHubPATTbox.TabIndex = 1
        ' 
        ' ContinueBtn
        ' 
        ContinueBtn.Location = New Point(84, 75)
        ContinueBtn.Name = "ContinueBtn"
        ContinueBtn.Size = New Size(75, 23)
        ContinueBtn.TabIndex = 2
        ContinueBtn.Text = "Continue"
        ContinueBtn.UseVisualStyleBackColor = True
        ' 
        ' CancelBtn
        ' 
        CancelBtn.DialogResult = DialogResult.Cancel
        CancelBtn.Location = New Point(248, 75)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(75, 23)
        CancelBtn.TabIndex = 3
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = True
        ' 
        ' StoreGitHubPATCbox
        ' 
        StoreGitHubPATCbox.AutoSize = True
        StoreGitHubPATCbox.Location = New Point(90, 48)
        StoreGitHubPATCbox.Name = "StoreGitHubPATCbox"
        StoreGitHubPATCbox.Size = New Size(227, 19)
        StoreGitHubPATCbox.TabIndex = 4
        StoreGitHubPATCbox.Text = "Store GitHub PAT in Windows Registry"
        StoreGitHubPATCbox.UseVisualStyleBackColor = True
        ' 
        ' GetPATFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(406, 112)
        ControlBox = False
        Controls.Add(StoreGitHubPATCbox)
        Controls.Add(CancelBtn)
        Controls.Add(ContinueBtn)
        Controls.Add(GitHubPATTbox)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MinimizeBox = False
        Name = "GetPATFrm"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Enter Github Personal Access Token"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GitHubPATTbox As TextBox
    Friend WithEvents ContinueBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents StoreGitHubPATCbox As CheckBox
End Class
