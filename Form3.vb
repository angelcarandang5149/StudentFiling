Imports MySql.Data.MySqlClient

Public Class Form3
    Dim gender As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub AddStudent_Click(sender As Object, e As EventArgs) Handles AddStudent.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=person"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into person.student (lastname,firstlename,middlename,age,id,course,yearlevel,gender) values ('" & TextBox_SLN.Text & "','" & TextBox_SFN.Text & "','" & TextBox_SMN.Text & "','" & TextBox_SAge.Text & "','" & TextBox_SID.Text & "','" & TextBox_SCourse.Text & "','" & TextBox_SYrL.Text & "','" & gender & "')"
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
            Query = "update person.student (lastname,firstlename,middlename,age,id,course,yearlevel,gender) values ('" & TextBox_SLN.Text & "','" & TextBox_SFN.Text & "','" & TextBox_SMN.Text & "','" & TextBox_SAge.Text & "','" & TextBox_SID.Text & "','" & TextBox_SCourse.Text & "','" & TextBox_SYrL.Text & "','" & gender & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

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
            Query = "delete from person.employee where id='" & TextBox_SID.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Deleted")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub SMale_CheckedChanged(sender As Object, e As EventArgs) Handles SMale.CheckedChanged
        gender = "M"
    End Sub

    Private Sub SFemale_CheckedChanged(sender As Object, e As EventArgs) Handles SFemale.CheckedChanged
        gender = "F"
    End Sub

    Private Sub ViewStudent_Click(sender As Object, e As EventArgs) Handles ViewStudent.Click
        Dim form4 As New Form4()
        form4.CallingForm = Me
        Hide()
        form4.ShowDialog()
    End Sub
    Private form2Instance As Form2
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        form2Instance = Application.OpenForms.OfType(Of Form2)().FirstOrDefault()

        If form2Instance Is Nothing Then
            form2Instance = New Form2()
        End If

        form2Instance.Show()

        Me.Hide()
    End Sub
End Class