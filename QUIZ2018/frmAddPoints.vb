Imports System.Data.OleDb
Public Class frmAddPoints
    Dim connection As New OleDbConnection(connectionstring)
    Private Sub frmAddPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
        Me.TopMost = True
        Me.KeyPreview = True
    End Sub

    Private Sub Clear()
        t1.Text = "0"
        t2.Text = "0"
        t3.Text = "0"
        t4.Text = "0"
        t5.Text = "0"
        t6.Text = "0"
        t7.Text = "0"
        t8.Text = "0"
        t9.Text = "0"
        t10.Text = "0"
    End Sub
    Private Sub UpdatePoints(numberOfPoints As Integer, no As Integer)
        Dim strGame As String = "Game1"
        Select Case gameNumber
            Case 1
                strGame = "Game1"
            Case 2
                strGame = "Game2"
            Case 3
                strGame = "Game3"
            Case 4
                strGame = "Game4"
            Case 5
                strGame = "Game5"
            Case 6
                strGame = "Game6"
            Case 7
                strGame = "Game7"
            Case 8
                strGame = "Game8"
            Case 9
                strGame = "Game9"
        End Select
        Dim strSQl As String = "update Points set " & strGame & "= Points." & strGame & " + " & numberOfPoints & " where Points.Number=" & no
        Using comm As OleDbCommand = New OleDbCommand(strSQl)
            Try
                connection.Open()
                comm.Connection = connection
                comm.ExecuteNonQuery()
                connection.Close()
            Catch ex As Exception
                [Error]()
            End Try
        End Using
    End Sub

    Private Sub frmAddPoints_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyValue = Keys.F5 Then
            UpdatePoints(Convert.ToInt32(t1.Text), 1)
            UpdatePoints(Convert.ToInt32(t2.Text), 2)
            UpdatePoints(Convert.ToInt32(t3.Text), 3)
            UpdatePoints(Convert.ToInt32(t4.Text), 4)
            UpdatePoints(Convert.ToInt32(t5.Text), 5)
            UpdatePoints(Convert.ToInt32(t6.Text), 6)
            UpdatePoints(Convert.ToInt32(t7.Text), 7)
            UpdatePoints(Convert.ToInt32(t8.Text), 8)
            UpdatePoints(Convert.ToInt32(t9.Text), 9)
            UpdatePoints(Convert.ToInt32(t10.Text), 10)
            Me.Close()
        End If
    End Sub
End Class