Public Class frmGame4
    Private Sub frmGame4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
        AxWindowsMediaPlayer1.URL = currentDirectory + "\video\itsalive.mp4"
    End Sub

    Private Sub frmGame4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            e.Handled = True
            AxWindowsMediaPlayer1.Dispose()
            Me.Close()
            frmMenu.Show()
        End If
        If e.KeyValue = Keys.N Then
            frmGame4Text.Show()
            e.Handled = True
            AxWindowsMediaPlayer1.Dispose()
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