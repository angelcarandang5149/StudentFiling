<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox_FN = New TextBox()
        Add = New Button()
        ViewStudent = New Button()
        TextBox_LN = New TextBox()
        Update = New Button()
        Delete = New Button()
        TextBoxUser = New TextBox()
        TextBoxPass = New TextBox()
        TextBox_ID = New TextBox()
        Label8 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Male = New RadioButton()
        Female = New RadioButton()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox_FN
        ' 
        TextBox_FN.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_FN.Location = New Point(12, 96)
        TextBox_FN.Name = "TextBox_FN"
        TextBox_FN.Size = New Size(222, 35)
        TextBox_FN.TabIndex = 3
        ' 
        ' Add
        ' 
        Add.BackColor = SystemColors.Window
        Add.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Add.Location = New Point(2, 253)
        Add.Name = "Add"
        Add.Size = New Size(79, 39)
        Add.TabIndex = 18
        Add.Text = "Add"
        Add.UseVisualStyleBackColor = False
        ' 
        ' ViewStudent
        ' 
        ViewStudent.BackColor = SystemColors.Window
        ViewStudent.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewStudent.Location = New Point(495, 253)
        ViewStudent.Name = "ViewStudent"
        ViewStudent.Size = New Size(86, 39)
        ViewStudent.TabIndex = 19
        ViewStudent.Text = "View"
        ViewStudent.UseVisualStyleBackColor = False
        ' 
        ' TextBox_LN
        ' 
        TextBox_LN.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_LN.Location = New Point(240, 96)
        TextBox_LN.Name = "TextBox_LN"
        TextBox_LN.Size = New Size(222, 35)
        TextBox_LN.TabIndex = 21
        ' 
        ' Update
        ' 
        Update.BackColor = SystemColors.Window
        Update.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Update.Location = New Point(146, 253)
        Update.Name = "Update"
        Update.Size = New Size(109, 39)
        Update.TabIndex = 22
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.BackColor = SystemColors.Window
        Delete.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(330, 253)
        Delete.Name = "Delete"
        Delete.Size = New Size(108, 39)
        Delete.TabIndex = 23
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' TextBoxUser
        ' 
        TextBoxUser.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUser.Location = New Point(12, 170)
        TextBoxUser.Name = "TextBoxUser"
        TextBoxUser.Size = New Size(222, 35)
        TextBoxUser.TabIndex = 24
        ' 
        ' TextBoxPass
        ' 
        TextBoxPass.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPass.Location = New Point(240, 170)
        TextBoxPass.Name = "TextBoxPass"
        TextBoxPass.Size = New Size(222, 35)
        TextBoxPass.TabIndex = 25
        ' 
        ' TextBox_ID
        ' 
        TextBox_ID.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_ID.Location = New Point(240, 24)
        TextBox_ID.Name = "TextBox_ID"
        TextBox_ID.Size = New Size(90, 35)
        TextBox_ID.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlDarkDark
        Label8.Location = New Point(240, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 32)
        Label8.TabIndex = 27
        Label8.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(12, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 28
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(240, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 32)
        Label1.TabIndex = 29
        Label1.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(484, 124)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 32)
        Label7.TabIndex = 30
        Label7.Text = "Gender"
        ' 
        ' Male
        ' 
        Male.AutoSize = True
        Male.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Male.Location = New Point(468, 159)
        Male.Name = "Male"
        Male.Size = New Size(52, 33)
        Male.TabIndex = 31
        Male.TabStop = True
        Male.Text = "M"
        Male.UseVisualStyleBackColor = True
        ' 
        ' Female
        ' 
        Female.AutoSize = True
        Female.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Female.Location = New Point(526, 159)
        Female.Name = "Female"
        Female.Size = New Size(46, 33)
        Female.TabIndex = 32
        Female.TabStop = True
        Female.Text = "F"
        Female.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(12, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 32)
        Label3.TabIndex = 33
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(240, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 32)
        Label4.TabIndex = 34
        Label4.Text = "Password"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(583, 293)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Female)
        Controls.Add(Male)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(TextBox_ID)
        Controls.Add(TextBoxPass)
        Controls.Add(TextBoxUser)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(TextBox_LN)
        Controls.Add(ViewStudent)
        Controls.Add(Add)
        Controls.Add(TextBox_FN)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Employee Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_FN As TextBox
    Friend WithEvents Add As Button
    Friend WithEvents ViewStudent As Button
    Friend WithEvents TextBox_LN As TextBox
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents TextBoxUser As TextBox
    Friend WithEvents TextBoxPass As TextBox
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
