Imports MySql.Data.MySqlClient
Public Class Form4
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Sub loadstudentdatatable()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=person"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from person.student"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            SDataList.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub
    Public CallingForm As Form
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadstudentdatatable()
    End Sub
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If TypeOf CallingForm Is Form2 Then
            DirectCast(CallingForm, Form2).Show()
        ElseIf TypeOf CallingForm Is Form3 Then
            DirectCast(CallingForm, Form3).Show()
        End If
        Me.Hide()
    End Sub
End Class