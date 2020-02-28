Public Class frmGame7
    Private Sub frmGame7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lAnswer.Visible = False
        t1.Visible = True
        t2.Visible = False
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub

    Private Sub frmGame7_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.S Then
            t1.Visible = False
            t2.Visible = False
            lAnswer.Visible = True
        End If
        If e.KeyValue = Keys.H Then
            lAnswer.Visible = False
            t2.Visible = False
            t1.Visible = True
        End If
        If e.KeyValue = Keys.N Then
            frmTitle.lblTitle.Text = ""
            frmTitle.lblText.Text = ""
            gameNumber += 1
            frmTitle.LoadTitle()
            frmTitle.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.P Then
            frmTitle.lblTitle.Text = ""
            frmTitle.lblText.Text = ""
            gameNumber -= 1
            frmTitle.LoadTitle()
            frmTitle.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.Right Then
            t2.Visible = True
        End If
        If e.KeyValue = Keys.F2 Then
            frmAddPoints.Show()
            frmAddPoints.lName.Text = lblTitle.Text
        End If
        If e.KeyValue = Keys.F3 Then
            frmResults.Show()
        End If
    End Sub
End Class