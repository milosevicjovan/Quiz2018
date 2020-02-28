Imports System.Data.OleDb
Public Class frmGame9
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 0
    Private Sub frmGame9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tA.Visible = False
        lblNum.Text = ""
        lblQuestionNumber.Visible = False
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub LoadQuestion(number As Integer)
        Dim strSQL As String = "Select Number, Text, Key from WhoKnows where WhoKnows.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            lblQuestionNumber.Visible = True
            lblNum.Text = ds.Tables(0).Rows(0).Item("Number").ToString
            t1.Text = ds.Tables(0).Rows(0).Item("Text").ToString
            tA.Visible = False
            tA.Text = "KEY: " + ds.Tables(0).Rows(0).Item("Key").ToString
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub MoveNext()
        If no < 10 Then
            no += 1
            LoadQuestion(no)
        End If
    End Sub
    Private Sub MovePrevious()
        If no > 1 Then
            no -= 1
            LoadQuestion(no)
        End If
    End Sub

    Private Sub frmGame9_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.Right Then
            MoveNext()
        End If
        If e.KeyValue = Keys.Left Then
            MovePrevious()
        End If
        If e.KeyValue = Keys.S Then
            tA.Visible = True
        End If
        If e.KeyValue = Keys.H Then
            tA.Visible = False
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
            frmAddPoints.lName.Text = lblTitle.Text
        End If
        If e.KeyValue = Keys.F3 Then
            frmResults.Show()
        End If
    End Sub
End Class