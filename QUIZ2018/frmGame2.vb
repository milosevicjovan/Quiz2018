Imports System.Data.OleDb
Public Class frmGame2
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 1
    Dim intCheck As Integer = 0
    Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Boolean
    Private Sub frmGame2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        b1 = False
        b2 = False
        b3 = False
        b4 = False
        b5 = False
        b6 = False
        b7 = False
        b8 = False
        b9 = False
        b10 = False
        b11 = False
        b12 = False
        lblNum.Text = ""
        lKey.Text = ""
        lKey2.Text = ""
        lKey2.Visible = False
        lKey.Visible = False
        t1.Text = ""
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
        lblNum.Text = LoadNumber(no)
    End Sub
    Private Function Check(ByVal number As Integer) As Boolean
        Dim result As Boolean = False
        Check = False
        Select Case number
            Case 1
                If b1 = True Then result = True Else result = False
            Case 2
                If b2 = True Then result = True Else result = False
            Case 3
                If b3 = True Then result = True Else result = False
            Case 4
                If b4 = True Then result = True Else result = False
            Case 5
                If b5 = True Then result = True Else result = False
            Case 6
                If b6 = True Then result = True Else result = False
            Case 7
                If b7 = True Then result = True Else result = False
            Case 8
                If b8 = True Then result = True Else result = False
            Case 9
                If b9 = True Then result = True Else result = False
            Case 10
                If b10 = True Then result = True Else result = False
            Case 11
                If b11 = True Then result = True Else result = False
            Case 12
                If b12 = True Then result = True Else result = False
        End Select
        Check = result
    End Function
    Private Sub Clear(number As Integer)
        Select Case number
            Case 1
                b1 = False
            Case 2
                b2 = False
            Case 3
                b3 = False
            Case 4
                b4 = False
            Case 5
                b5 = False
            Case 6
                b6 = False
            Case 7
                b7 = False
            Case 8
                b8 = False
            Case 9
                b9 = False
            Case 10
                b10 = False
            Case 11
                b11 = False
            Case 12
                b12 = False
        End Select
        t1.Text = ""
    End Sub
    Private Function LoadQuestion1(ByVal number As Integer) As String
        Dim result As String = ""
        LoadQuestion1 = result
        Dim strSQL As String = "Select Number2, T1 from GTC where GTC.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            lblNum.Text = ds.Tables(0).Rows(0).Item("Number2").ToString
            result = ds.Tables(0).Rows(0).Item("T1").ToString
            intCheck = 1
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
        LoadQuestion1 = result
    End Function
    Private Function LoadQuestion2(ByVal number As Integer) As String
        Dim result As String = ""
        LoadQuestion2 = result
        Dim strSQL As String = "Select T2 from GTC where GTC.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            result = ds.Tables(0).Rows(0).Item("T2").ToString
            intCheck = 2
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
        LoadQuestion2 = result
    End Function
    Private Function LoadQuestion3(ByVal number As Integer) As String
        Dim result As String = ""
        LoadQuestion3 = result
        Dim strSQL As String = "Select T3 from GTC where GTC.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            result = ds.Tables(0).Rows(0).Item("T3").ToString
            intCheck = 3
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
        LoadQuestion3 = result
    End Function
    Private Sub Change(number As Integer)
        Select Case number
            Case 1
                b1 = True
            Case 2
                b2 = True
            Case 3
                b3 = True
            Case 4
                b4 = True
            Case 5
                b5 = True
            Case 6
                b6 = True
            Case 7
                b7 = True
            Case 8
                b8 = True
            Case 9
                b9 = True
            Case 10
                b10 = True
            Case 11
                b11 = True
            Case 12
                b12 = True
        End Select
    End Sub
    Private Function LoadNumber(ByVal number As Integer) As String
        Dim result As String = ""
        LoadNumber = result
        Dim strSQL As String = "Select Number2 from GTC where GTC.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            result = ds.Tables(0).Rows(0).Item("Number2").ToString
            connection.Close()
            intCheck = 0
            If Check(number) = True Then
                t1.Text = LoadQuestion1(number)
                t1.Text = t1.Text + vbCrLf + vbCrLf + LoadQuestion2(number)
                t1.Text = t1.Text + vbCrLf + vbCrLf + LoadQuestion3(number)
            Else
                t1.Text = ""
            End If
        Catch ex As Exception
            [Error]()
        End Try
        LoadNumber = result
    End Function
    Private Sub LoadKeys(number As Integer)
        Dim strSQL As String = "Select Number, Key from GTC where GTC.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case number
                Case 1
                    lKey.Text = "KEY:   " + ds.Tables(0).Rows(0).Item("Number").ToString + "." + ds.Tables(0).Rows(0).Item("Key").ToString
                Case <= 6
                    lKey.Text = lKey.Text + vbCrLf + vbCrLf + "           " + ds.Tables(0).Rows(0).Item("Number").ToString + "." + ds.Tables(0).Rows(0).Item("Key").ToString
                Case 7
                    lKey2.Text = ds.Tables(0).Rows(0).Item("Number").ToString + "." + ds.Tables(0).Rows(0).Item("Key").ToString
                Case > 7
                    lKey2.Text = lKey2.Text + vbCrLf + vbCrLf + ds.Tables(0).Rows(0).Item("Number").ToString + "." + ds.Tables(0).Rows(0).Item("Key").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub

    Private Sub MoveNext()
        If no < 12 Then
            no += 1
            lblNum.Text = LoadNumber(no)
        End If
    End Sub
    Private Sub MovePrevious()
        If no > 1 Then
            no -= 1
            lblNum.Text = LoadNumber(no)
        End If
    End Sub
    Private Sub Start()
        b1 = False
        b2 = False
        b3 = False
        b4 = False
        b5 = False
        b6 = False
        b7 = False
        b8 = False
        b9 = False
        b10 = False
        b11 = False
        b12 = False
        no = 1
        intCheck = 0
        lblNum.Text = LoadNumber(no)
        lKey.Visible = False
        lKey2.Visible = False
        lblNum.Visible = True
        t1.Text = ""
        t1.Visible = True
    End Sub
    Private Sub frmGame2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Q Then
            Start()
        End If
        If e.KeyValue = Keys.H Then
            Clear(no)
        End If
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
        If e.KeyValue = Keys.NumPad1 Then
            If intCheck = 0 Then
                t1.Text = LoadQuestion1(no)
                Change(no)
            End If
        End If

        If e.KeyValue = Keys.NumPad2 Then
            If intCheck = 1 Then
                t1.Text = t1.Text + vbCrLf + vbCrLf + LoadQuestion2(no)
            End If
        End If

        If e.KeyValue = Keys.NumPad3 Then
            If intCheck = 2 Then
                t1.Text = t1.Text + vbCrLf + vbCrLf + LoadQuestion3(no)
            End If
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
            lblNum.Visible = False
            t1.Visible = False
            For i As Integer = 1 To 12
                LoadKeys(i)
            Next
            lKey.Visible = True
            lKey2.Visible = True
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