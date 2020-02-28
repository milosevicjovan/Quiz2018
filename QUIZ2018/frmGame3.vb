Imports System.Data.OleDb
Public Class frmGame3
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 0
    Private Sub frmGame3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t1.Text = ""
        lKey.Text = ""
        lKey.Visible = False
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub LoadQuestion(number As Integer)
        Dim strSQL As String = "Select T1 from WhoSaidIt where WhoSaidIt.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            t1.Text = ds.Tables(0).Rows(0).Item("T1").ToString
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub LoadKeys(number As Integer)
        Dim strSQL As String = "Select Number, Key from WhoSaidIt where WhoSaidIt.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            If number = 1 Then
                lKey.Text = "KEY:   " + ds.Tables(0).Rows(0).Item("Key").ToString
            Else
                lKey.Text = lKey.Text + vbCrLf + vbCrLf + "           " + ds.Tables(0).Rows(0).Item("Key").ToString
            End If
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub Restart()
        no = 1
        LoadQuestion(no)
    End Sub

    Private Sub MoveNext()
        If no < 5 Then
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

    Private Sub frmGame3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
        If e.KeyValue = Keys.R Then
            Restart()
            lKey.Visible = False
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
        If e.KeyValue = Keys.S Then
            t1.Visible = False
            For i As Integer = 1 To 5
                LoadKeys(i)
            Next
            lKey.Visible = True
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