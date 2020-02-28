Public Class frmGame6Video
    Private Sub frmGame6Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
        AxWindowsMediaPlayer1.URL = currentDirectory + "\video\DoYouRememberVideo.mp4"
    End Sub

    Private Sub frmGame6Video_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            e.Handled = True
            AxWindowsMediaPlayer1.Dispose()
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.N Then
            e.Handled = True
            AxWindowsMediaPlayer1.Dispose()
            frmGame6.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.P Then
            e.Handled = True
            AxWindowsMediaPlayer1.Dispose()
            frmTitle.lblTitle.Text = ""
            frmTitle.lblText.Text = ""
            gameNumber -= 1
            frmTitle.LoadTitle()
            frmTitle.Show()
            Me.Close()
        End If
    End Sub
End Class