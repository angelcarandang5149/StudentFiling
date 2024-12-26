Imports MySql.Data.MySqlClient

Public Class Form5
    Dim gender As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Back_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Hide()
    End Sub
    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=person"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into person.employee (firstname,lastname,username,password,gender) values ('" & TextBox_ID.Text & "','" & TextBox_FN.Text & "','" & TextBoxUser.Text & "','" & TextBoxPass.Text & "','" & gender & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=person"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "update person.employee (firstname,lastname,username,password,gender) values ('" & TextBox_ID.Text & "','" & TextBox_FN.Text & "','" & TextBoxUser.Text & "','" & TextBoxPass.Text & "','" & gender & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader

            MessageBox.Show("Data Updated")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=person"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "delete from person.employee where id='" & TextBox_ID.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = Command.ExecuteReader

            MessageBox.Show("Deleted")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        gender = "M"
    End Sub

    Private Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        gender = "F"
    End Sub

    Private Sub ViewStudent_Click(sender As Object, e As EventArgs) Handles ViewStudent.Click
        Dim form6 As New Form6()
        form6.CallingForm = Me
        Hide()
        form6.ShowDialog()
    End Sub
    Private form2Instance As Form2
    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        form2Instance = Application.OpenForms.OfType(Of Form2)().FirstOrDefault()

        If form2Instance Is Nothing Then
            form2Instance = New Form2()
        End If

        form2Instance.Show()

        Me.Hide()
    End Sub
End Class