Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim result As DialogResult
        result = MessageBox.Show("Logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        Else
            Form1.Show()
            Hide()
        End If
    End Sub

    Private Sub Edit1_Click(sender As Object, e As EventArgs) Handles Edit1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub View1_Click(sender As Object, e As EventArgs) Handles View1.Click
        Dim form4 As New Form4()
        form4.CallingForm = Me
        Hide()
        form4.ShowDialog()
    End Sub

    Private Sub Edit2_Click(sender As Object, e As EventArgs) Handles Edit2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub View2_Click(sender As Object, e As EventArgs) Handles View2.Click
        Dim form6 As New Form6()
        form6.CallingForm = Me
        Hide()
        form6.ShowDialog()
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class