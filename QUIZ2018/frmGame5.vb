Imports System.Data.OleDb
Public Class frmGame5
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 1
    Private Sub frmGame5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t1.Text = ""
        t1.ForeColor = Color.Black
        t1.Font = New Font("Calibri", 30, FontStyle.Bold)
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub LoadKeys(number As Integer)
        Dim strSQL As String = "Select key1 from truefalse where truefalse.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            t1.Font = New Font("Calibri", 21, FontStyle.Bold)
            If number = 1 Then
                t1.Text = "KEY:   " + ds.Tables(0).Rows(0).Item("Key1")
            Else
                t1.Text = t1.Text + vbCrLf + vbCrLf + "           " + ds.Tables(0).Rows(0).Item("key1").ToString
            End If
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub LoadQuestion(number As Integer)
        Dim strSQL As String = "Select t1 from truefalse where truefalse.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case number
                Case 1
                    t1.Text = ds.Tables(0).Rows(0).Item("T1").ToString
                Case <= 5
                    t1.Text = t1.Text + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("T1").ToString
                Case 6
                    t1.Text = ds.Tables(0).Rows(0).Item("T1").ToString
                Case > 6
                    t1.Text = t1.Text + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("T1").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub

    Private Sub MoveNext()
        If no < 11 Then
            LoadQuestion(no)
            no += 1
        End If
    End Sub
    Private Sub frmGame5_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            MoveNext()
        End If
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.R Then
            no = 1
            t1.Text = ""
            t1.ForeColor = Color.Black
            t1.Font = New Font("Calibri", 30, FontStyle.Bold)
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
            no = 1
            t1.Text = ""
            t1.ForeColor = Color.Maroon
            For i As Integer = 1 To 10
                LoadKeys(i)
                no += 1
            Next
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