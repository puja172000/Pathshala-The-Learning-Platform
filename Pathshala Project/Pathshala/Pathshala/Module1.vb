Imports System.Data.OleDb
Module Module1
    Public cn As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\Pathshala Project\Pathshala.accdb")
    Public rs As New OleDb.OleDbCommand
    Public sql, sql1 As String
End Module
