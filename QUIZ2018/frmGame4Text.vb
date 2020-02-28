Imports System.Data.OleDb
Public Class frmGame4Text
    Dim connection As New OleDbConnection(connectionstring)
    Private Sub frmGame4Text_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub ShowText()
        L1.Visible = True
        L2.Visible = True
        L3.Visible = True
        L4.Visible = True
        L5.Visible = True
        L6.Visible = True
        L7.Visible = True
        L8.Visible = True
        L9.Visible = True
        L10.Visible = True
        L11.Visible = True
        L12.Visible = True
        L13.Visible = True
        L14.Visible = True
        L15.Visible = True
        L16.Visible = True
        L17.Visible = True
        L18.Visible = True
        L19.Visible = True
        L20.Visible = True
    End Sub
    Private Sub HideText()
        L1.Visible = False
        L2.Visible = False
        L3.Visible = False
        L4.Visible = False
        L5.Visible = False
        L6.Visible = False
        L7.Visible = False
        L8.Visible = False
        L9.Visible = False
        L10.Visible = False
        L11.Visible = False
        L12.Visible = False
        L13.Visible = False
        L14.Visible = False
        L15.Visible = False
        L16.Visible = False
        L17.Visible = False
        L18.Visible = False
        L19.Visible = False
        L20.Visible = False
    End Sub

    Private Sub frmGame4Text_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.S Then
            ShowText()
        End If
        If e.KeyValue = Keys.H Then
            HideText()
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
        If e.KeyValue = Keys.F2 Then
            frmAddPoints.Show()
            frmAddPoints.lName.Text = Label1.Text
        End If
        If e.KeyValue = Keys.F3 Then
            frmResults.Show()
        End If
    End Sub
End Class