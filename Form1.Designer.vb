<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox_Un = New TextBox()
        Login = New Button()
        Label2 = New Label()
        TextBox_Pass = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 46)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' TextBox_Un
        ' 
        TextBox_Un.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Un.Location = New Point(173, 30)
        TextBox_Un.Name = "TextBox_Un"
        TextBox_Un.Size = New Size(260, 45)
        TextBox_Un.TabIndex = 1
        ' 
        ' Login
        ' 
        Login.BackColor = SystemColors.Window
        Login.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(252, 132)
        Login.Name = "Login"
        Login.Size = New Size(105, 50)
        Login.TabIndex = 2
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 45)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_Pass.Location = New Point(173, 81)
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.PasswordChar = "*"c
        TextBox_Pass.Size = New Size(260, 45)
        TextBox_Pass.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(464, 195)
        Controls.Add(TextBox_Pass)
        Controls.Add(Label2)
        Controls.Add(Login)
        Controls.Add(TextBox_Un)
        Controls.Add(Label1)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Un As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Pass As TextBox

End Class
