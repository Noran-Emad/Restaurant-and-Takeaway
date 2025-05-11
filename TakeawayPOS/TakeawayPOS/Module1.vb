Imports System.Data.SqlClient
Module Module1
    Public conn As New SqlConnection("Data Source=DESKTOP-KJJOK3Q\SQLEXPRESS;Initial Catalog=TakeawayDB;Integrated Security=True")
    Public da As New SqlDataAdapter()
    Public ds As New DataSet()
    Public dv As New DataView()
    Public cmd As New SqlClient.SqlCommand()

    Public staffName As String = ""
    Public staffId As Integer = 0
    Public MFlag As Boolean = False
End Module
