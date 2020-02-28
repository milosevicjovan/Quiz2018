Imports System.Data.OleDb
Public Class frmResults
    Dim connection As New OleDbConnection(connectionstring)
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.KeyPreview = True
        Me.DoubleBuffered = True
        Me.SuspendLayout()
        Me.ResumeLayout()
        LoadTeams()
        DataGridView1.ClearSelection()
    End Sub
    Private Sub LoadTeams()
        Dim strSQL As String = "Select Number, TeamName, Game1, Game2, Game3, Game4, Game5, Game6, Game7, Game8, Game9, 
                               (Game1 + Game2 + Game3 + Game4 + Game5 + Game6 + Game7 + Game8 + Game9) as TotalPoints from Points
                                order by (Game1 + Game2 + Game3 + Game4 + Game5 + Game6 + Game7 + Game8 + Game9) DESC"

        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        Try
            connection.Open()
            da.SelectCommand = New OleDbCommand(strSQL)
            da.SelectCommand.Connection = connection
            da.Fill(ds)
            tables = ds.Tables
            Dim view As New DataView(tables(0))
            source1.DataSource = view
            DataGridView1.DataSource = view
            connection.Close()
            AdjustGrid()
            GridColor()
        Catch ex As Exception
            [Error]()
        End Try
    End Sub
    Private Sub AdjustGrid()
        DataGridView1.Columns(0).Name = "Num"
        DataGridView1.Columns(1).Name = "Nam"
        DataGridView1.Columns(2).Name = "g1"
        DataGridView1.Columns(3).Name = "g2"
        DataGridView1.Columns(4).Name = "g3"
        DataGridView1.Columns(5).Name = "g4"
        DataGridView1.Columns(6).Name = "g5"
        DataGridView1.Columns(7).Name = "g6"
        DataGridView1.Columns(8).Name = "g7"
        DataGridView1.Columns(9).Name = "g8"
        DataGridView1.Columns(10).Name = "g9"
        DataGridView1.Columns(11).Name = "g9"
        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = ""
            .Columns(1).HeaderCell.Value = "Name"
            .Columns(2).HeaderCell.Value = "Game 1"
            .Columns(3).HeaderCell.Value = "Game 2"
            .Columns(4).HeaderCell.Value = "Game 3"
            .Columns(5).HeaderCell.Value = "Game 4"
            .Columns(6).HeaderCell.Value = "Game 5"
            .Columns(7).HeaderCell.Value = "Game 6"
            .Columns(8).HeaderCell.Value = "Game 7"
            .Columns(9).HeaderCell.Value = "Game 8"
            .Columns(10).HeaderCell.Value = "Game 9"
            .Columns(11).HeaderCell.Value = "TOTAL"
            .Columns(0).FillWeight = 80
            .Columns(1).FillWeight = 300
            .Columns(2).FillWeight = 100
            .Columns(3).FillWeight = 100
            .Columns(4).FillWeight = 100
            .Columns(5).FillWeight = 100
            .Columns(6).FillWeight = 100
            .Columns(7).FillWeight = 100
            .Columns(8).FillWeight = 100
            .Columns(9).FillWeight = 100
            .Columns(10).FillWeight = 100
            .Columns(11).FillWeight = 100
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = True
            .Columns(9).ReadOnly = True
            .Columns(10).ReadOnly = True
            .Columns(11).ReadOnly = True
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
        End With
    End Sub
    Private Sub GridColor()
        Dim intR As Integer = DataGridView1.RowCount - 1
        Dim jr As Integer
        For jr = 0 To intR
            DataGridView1.Item(11, jr).Style.BackColor = Color.LightGreen
        Next
        For jr = 0 To intR
            DataGridView1.Item(0, jr).Value = jr + 1
        Next
    End Sub
    Private Sub frmResults_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class