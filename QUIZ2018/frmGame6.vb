Imports System.Data.OleDb
Public Class frmGame6
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 1
    Dim keyNumber As Integer = 1
    Private Sub frmGame6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t1.Text = ""
        lR.Text = ""
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub LoadQuestion(number As Integer)
        Dim strSQL As String = "Select Text from DoYouRemember where DoYouRemember.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case number
                Case 1
                    t1.Text = ds.Tables(0).Rows(0).Item("Text").ToString
                Case <= 5
                    t1.Text = t1.Text + vbCr + vbCr + ds.Tables(0).Rows(0).Item("Text").ToString
                Case 6
                    t1.Text = ds.Tables(0).Rows(0).Item("Text").ToString
                    lR.Text = ""
                Case > 6
                    t1.Text = t1.Text + vbCr + vbCr + ds.Tables(0).Rows(0).Item("Text").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub LoadKey(number As Integer)
        Dim strSQL As String = "Select Key from DoYouRemember where DoYouRemember.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case number
                Case 1
                    lR.Text = ds.Tables(0).Rows(0).Item("Key").ToString
                Case <= 5
                    lR.Text = lR.Text + vbCr + vbCr + ds.Tables(0).Rows(0).Item("Key").ToString
                Case 6
                    lR.Text = ds.Tables(0).Rows(0).Item("Key").ToString
                Case > 6
                    lR.Text = lR.Text + vbCr + vbCr + ds.Tables(0).Rows(0).Item("Key").ToString
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
    Private Sub Key()
        If keyNumber < 11 Then
            LoadKey(keyNumber)
            keyNumber += 1
        End If
    End Sub
    Private Sub frmGame6_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            MoveNext()
        End If
        If e.KeyValue = Keys.R Then
            Key()
        End If
        If e.KeyValue = Keys.Escape Then
            frmMenu.Show()
            Me.Close()
        End If
        If e.KeyValue = Keys.D Then
            t1.Text = ""
            lR.Text = ""
            no = 1
            keyNumber = 1
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