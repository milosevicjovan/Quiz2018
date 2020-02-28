Imports System.Data.OleDb
Public Class frmGame8
    Dim connection As New OleDbConnection(connectionstring)
    Dim no As Integer = 1
    Private Sub frmGame8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub
    Private Sub columnA(number As Integer, cellNumber As Integer)
        Dim strSQL As String = "Select A, A1, A2, A3, A4 from Associations where Associations.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case cellNumber
                Case 0
                    A.Text = ds.Tables(0).Rows(0).Item("A").ToString
                Case 1
                    A1.Text = ds.Tables(0).Rows(0).Item("A1").ToString
                Case 2
                    A2.Text = ds.Tables(0).Rows(0).Item("A2").ToString
                Case 3
                    A3.Text = ds.Tables(0).Rows(0).Item("A3").ToString
                Case 4
                    A4.Text = ds.Tables(0).Rows(0).Item("A4").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub columnB(number As Integer, cellNumber As Integer)
        Dim strSQL As String = "Select B, B1, B2, B3, B4 from Associations where Associations.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case cellNumber
                Case 0
                    B.Text = ds.Tables(0).Rows(0).Item("B").ToString
                Case 1
                    B1.Text = ds.Tables(0).Rows(0).Item("B1").ToString
                Case 2
                    B2.Text = ds.Tables(0).Rows(0).Item("B2").ToString
                Case 3
                    B3.Text = ds.Tables(0).Rows(0).Item("B3").ToString
                Case 4
                    B4.Text = ds.Tables(0).Rows(0).Item("B4").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub columnC(number As Integer, cellNumber As Integer)
        Dim strSQL As String = "Select C, C1, C2, C3, C4 from Associations where Associations.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case cellNumber
                Case 0
                    C.Text = ds.Tables(0).Rows(0).Item("C").ToString
                Case 1
                    C1.Text = ds.Tables(0).Rows(0).Item("C1").ToString
                Case 2
                    C2.Text = ds.Tables(0).Rows(0).Item("C2").ToString
                Case 3
                    C3.Text = ds.Tables(0).Rows(0).Item("C3").ToString
                Case 4
                    C4.Text = ds.Tables(0).Rows(0).Item("C4").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub columnD(number As Integer, cellNumber As Integer)
        Dim strSQL As String = "Select D, D1, D2, D3, D4 from Associations where Associations.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            Select Case cellNumber
                Case 0
                    D.Text = ds.Tables(0).Rows(0).Item("D").ToString
                Case 1
                    D1.Text = ds.Tables(0).Rows(0).Item("D1").ToString
                Case 2
                    D2.Text = ds.Tables(0).Rows(0).Item("D2").ToString
                Case 3
                    D3.Text = ds.Tables(0).Rows(0).Item("D3").ToString
                Case 4
                    D4.Text = ds.Tables(0).Rows(0).Item("D4").ToString
            End Select
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub Final(number As Integer)
        Dim strSQL As String = "Select FINAL from Associations where Associations.Number=" & number
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            konacno.Text = ds.Tables(0).Rows(0).Item("FINAL").ToString
            connection.Close()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub Clear()
        A1.Text = "A1"
        A2.Text = "A2"
        A3.Text = "A3"
        A4.Text = "A4"
        A.Text = "COLUMN A"
        B1.Text = "B1"
        B2.Text = "B2"
        B3.Text = "B3"
        B4.Text = "B4"
        B.Text = "COLUMN B"
        C1.Text = "C1"
        C2.Text = "C2"
        C3.Text = "C3"
        C4.Text = "C4"
        C.Text = "COLUMN C"
        D1.Text = "D1"
        D2.Text = "D2"
        D3.Text = "D3"
        D4.Text = "D4"
        D.Text = "COLUMN D"
        konacno.Text = "FINAL"
    End Sub

    Private Sub MoveNext()
        If no < 5 Then
            no += 1
            lblAssociationNumber.Text = "Association number " + no.ToString
            Clear()
        End If
    End Sub
    Private Sub MovePrevious()
        If no > 1 Then
            no -= 1
            lblAssociationNumber.Text = "Association number " + no.ToString
            Clear()
        End If
    End Sub

    Private Sub frmGame8_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        '''''''''''''common procedures.............................................................
        If e.KeyValue = Keys.F8 Then
            Clear()
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
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyValue = Keys.Q Then
            columnA(no, 1)
        End If
        If e.KeyValue = Keys.W Then
            columnA(no, 2)
        End If
        If e.KeyValue = Keys.E Then
            columnA(no, 3)
        End If
        If e.KeyValue = Keys.R Then
            columnA(no, 4)
        End If
        If e.KeyValue = Keys.T Then
            columnA(no, 1)
            columnA(no, 2)
            columnA(no, 3)
            columnA(no, 4)
            columnA(no, 0)
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyValue = Keys.A Then
            columnB(no, 1)
        End If
        If e.KeyValue = Keys.S Then
            columnB(no, 2)
        End If
        If e.KeyValue = Keys.D Then
            columnB(no, 3)
        End If
        If e.KeyValue = Keys.F Then
            columnB(no, 4)
        End If
        If e.KeyValue = Keys.G Then
            columnB(no, 1)
            columnB(no, 2)
            columnB(no, 3)
            columnB(no, 4)
            columnB(no, 0)
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyValue = Keys.Z Then
            columnC(no, 1)
        End If
        If e.KeyValue = Keys.X Then
            columnC(no, 2)
        End If
        If e.KeyValue = Keys.C Then
            columnC(no, 3)
        End If
        If e.KeyValue = Keys.V Then
            columnC(no, 4)
        End If
        If e.KeyValue = Keys.B Then
            columnC(no, 1)
            columnC(no, 2)
            columnC(no, 3)
            columnC(no, 4)
            columnC(no, 0)
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyValue = Keys.NumPad1 Then
            columnD(no, 1)
        End If
        If e.KeyValue = Keys.NumPad2 Then
            columnD(no, 2)
        End If
        If e.KeyValue = Keys.NumPad3 Then
            columnD(no, 3)
        End If
        If e.KeyValue = Keys.NumPad4 Then
            columnD(no, 4)
        End If
        If e.KeyValue = Keys.NumPad5 Then
            columnD(no, 1)
            columnD(no, 2)
            columnD(no, 3)
            columnD(no, 4)
            columnD(no, 0)
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If e.KeyValue = Keys.F5 Then
            Final(no)
        End If
    End Sub
End Class