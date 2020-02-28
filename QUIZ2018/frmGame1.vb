Imports System.Data.OleDb
Public Class frmGame1
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 0
    Private Sub frmGame1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lKey.Text = ""
        lKey2.Text = ""
        lKey2.Visible = False
        lKey.Visible = False
        lblNum.Text = ""
        lblText.Text = ""
        la.Text = ""
        lblQuestionNumber.Visible = False
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub LoadQuestion(number As Integer)
        Dim strSQL As String = "Select Number, Question, A, B, C, D from MultipleChoice where MultipleChoice.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            lblQuestionNumber.Visible = True
            lblNum.Text = ds.Tables(0).Rows(0).Item("Number").ToString
            lblText.Text = ds.Tables(0).Rows(0).Item("Question").ToString
            la.Text = ds.Tables(0).Rows(0).Item("A").ToString + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("B").ToString + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("C").ToString + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("D").ToString
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub LoadKeys(number As Integer)
        Dim strSQL As String = "Select Number, Key from MultipleChoice where MultipleChoice.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case number
                Case 1
                    lKey.Text = "KEY:   " + ds.Tables(0).Rows(0).Item("Number").ToString + ". " + ds.Tables(0).Rows(0).Item("Key").ToString
                Case <= 5
                    lKey.Text = lKey.Text + vbCrLf + vbCrLf + "           " + ds.Tables(0).Rows(0).Item("Number").ToString + ". " + ds.Tables(0).Rows(0).Item("Key").ToString
                Case 6
                    lKey2.Text = ds.Tables(0).Rows(0).Item("Number").ToString + ". " + ds.Tables(0).Rows(0).Item("Key").ToString
                Case > 6
                    lKey2.Text = lKey2.Text + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("Number").ToString + ". " + ds.Tables(0).Rows(0).Item("Key").ToString
            End Select

            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub

    Private Sub frmGame1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show() ' temporary, will be removed
            Me.Close()
        End If
        If e.KeyValue = Keys.Right Then
            MoveNext()
        End If
        If e.KeyValue = Keys.Left Then
            MovePrevious()
        End If
        If e.KeyValue = Keys.R Then
            lKey.Visible = False
            lKey2.Visible = False
            lblQuestionNumber.Visible = True
            lblNum.Visible = True
            lblText.Visible = True
            la.Visible = True
            Restart()
        End If
        If e.KeyValue = Keys.N Then
            frmTitle.lblTitle.Text = ""
            frmTitle.lblText.Text = ""
            gameNumber += 1
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
        If e.KeyValue = Keys.S Then
            lblQuestionNumber.Visible = False
            lblNum.Visible = False
            lblText.Visible = False
            la.Visible = False
            no = 1
            For i As Integer = 1 To 10
                LoadKeys(i)
            Next
            lKey.Visible = True
            lKey2.Visible = True
        End If
    End Sub
    Private Sub Restart()
        no = 1
        LoadQuestion(no)
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
End Class
