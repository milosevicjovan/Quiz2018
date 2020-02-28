Imports System.Data.OleDb
Module pblVariables
    Public currentDirectory As String = CurDir()
    Public connectionstring As String = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & currentDirectory & "\quizData.accdb;Persist Security Info=false;"
    Public gameNumber As Integer = 1
    Public Sub [Error]()
        MsgBox("Error: " & Err.Number & ", Description: " & Err.Description, vbOKOnly, "Quiz2018-JMilosevic")
    End Sub
End Module
