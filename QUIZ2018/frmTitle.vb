Public Class frmTitle
    Private Sub frmTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = ""
        lblText.Text = ""
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
        LoadTitle()
        lblTitle.Visible = True
        lblText.Visible = True
    End Sub
    Public Sub LoadTitle()
        lblTitle.Visible = False
        lblText.Visible = False
        Select Case gameNumber
            Case 1
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "MULTIPLE CHOICE"
            Case 2
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "GUESS THE CHARACTER"
            Case 3
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "WHO SAID IT?"
            Case 4
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "FILL THE GAPS"
            Case 5
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "TRUE/FALSE"
            Case 6
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "DO YOU REMEMBER?"
            Case 7
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "PROBABLE PASSAGES"
            Case 8
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "ASSOCIATIONS"
            Case 9
                lblTitle.Text = "GAME " + gameNumber.ToString
                lblText.Text = "WHO KNOWS?"
            Case 10
                lblTitle.Text = "THE END"
                lblText.Text = "THANKS!"
        End Select
        lblTitle.Visible = True
        lblText.Visible = True
        Me.TopMost = True
    End Sub
    Public Sub OpenNext()
        Select Case gameNumber
            Case 1
                frmGame1.Show()
            Case 2
                frmGame2.Show()
            Case 3
                frmGame3.Show()
            Case 4
                Me.TopMost = True
                frmGame4Text.Show()
            Case 5
                frmGame5.Show()
            Case 6
                Me.TopMost = True
                frmGame6.Show()
            Case 7
                frmGame7.Show()
            Case 8
                frmGame8.Show()
            Case 9
                frmGame9.Show()
        End Select
        lblTitle.Text = ""
        lblText.Text = ""
    End Sub

    Private Sub frmTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
        End If
        If e.KeyValue = Keys.N Then
            OpenNext()
        End If
        If e.KeyValue = Keys.Q Then
            frmGame4.Show()
        End If
        If e.KeyValue = Keys.W Then
            frmGame6Video.Show()
        End If
        If e.KeyValue = Keys.V Then
            Me.TopMost = False
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(currentDirectory + "\video\itsalive.mp4", "")
        End If
        If e.KeyValue = Keys.B Then
            Me.TopMost = False
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(currentDirectory + "\video\DoYouRememberVideo.mp4", "")
        End If
        If e.KeyValue = Keys.P Then
            lblTitle.Text = ""
            lblText.Text = ""
            gameNumber -= 1
            LoadTitle()
        End If
    End Sub
End Class