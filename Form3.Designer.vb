<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        TextBox_SLN = New TextBox()
        TextBox_SFN = New TextBox()
        Label2 = New Label()
        TextBox_SMN = New TextBox()
        Label3 = New Label()
        TextBox_SAge = New TextBox()
        Label4 = New Label()
        TextBox_SYrL = New TextBox()
        Label5 = New Label()
        TextBox_SCourse = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        SMale = New RadioButton()
        SFemale = New RadioButton()
        AddStudent = New Button()
        ViewStudent = New Button()
        TextBox_SID = New TextBox()
        Label8 = New Label()
        Update = New Button()
        Delete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(12, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 32)
        Label1.TabIndex = 1
        Label1.Text = "Last Name"
        ' 
        ' TextBox_SLN
        ' 
        TextBox_SLN.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SLN.Location = New Point(12, 25)
        TextBox_SLN.Name = "TextBox_SLN"
        TextBox_SLN.Size = New Size(198, 35)
        TextBox_SLN.TabIndex = 2
        ' 
        ' TextBox_SFN
        ' 
        TextBox_SFN.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SFN.Location = New Point(216, 25)
        TextBox_SFN.Name = "TextBox_SFN"
        TextBox_SFN.Size = New Size(198, 35)
        TextBox_SFN.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(216, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 5
        Label2.Text = "First Name"
        ' 
        ' TextBox_SMN
        ' 
        TextBox_SMN.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SMN.Location = New Point(420, 25)
        TextBox_SMN.Name = "TextBox_SMN"
        TextBox_SMN.Size = New Size(198, 35)
        TextBox_SMN.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(420, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 32)
        Label3.TabIndex = 7
        Label3.Text = "Middle Name"
        ' 
        ' TextBox_SAge
        ' 
        TextBox_SAge.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SAge.Location = New Point(12, 110)
        TextBox_SAge.Name = "TextBox_SAge"
        TextBox_SAge.Size = New Size(61, 35)
        TextBox_SAge.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(12, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 32)
        Label4.TabIndex = 9
        Label4.Text = "Age"
        ' 
        ' TextBox_SYrL
        ' 
        TextBox_SYrL.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SYrL.Location = New Point(379, 110)
        TextBox_SYrL.Name = "TextBox_SYrL"
        TextBox_SYrL.Size = New Size(61, 35)
        TextBox_SYrL.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(379, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 32)
        Label5.TabIndex = 11
        Label5.Text = "Year Level"
        ' 
        ' TextBox_SCourse
        ' 
        TextBox_SCourse.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SCourse.Location = New Point(175, 110)
        TextBox_SCourse.Name = "TextBox_SCourse"
        TextBox_SCourse.Size = New Size(198, 35)
        TextBox_SCourse.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlDarkDark
        Label6.Location = New Point(175, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 32)
        Label6.TabIndex = 13
        Label6.Text = "Course(Acronym)"
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlDarkDark
        Label7.Location = New Point(446, 112)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 32)
        Label7.TabIndex = 14
        Label7.Text = "Gender"
        ' 
        ' SMale
        ' 
        SMale.AutoSize = True
        SMale.BackColor = Color.Transparent
        SMale.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SMale.Location = New Point(523, 112)
        SMale.Name = "SMale"
        SMale.Size = New Size(52, 33)
        SMale.TabIndex = 15
        SMale.TabStop = True
        SMale.Text = "M"
        SMale.UseVisualStyleBackColor = False
        ' 
        ' SFemale
        ' 
        SFemale.AutoSize = True
        SFemale.BackColor = Color.Transparent
        SFemale.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SFemale.Location = New Point(581, 112)
        SFemale.Name = "SFemale"
        SFemale.Size = New Size(46, 33)
        SFemale.TabIndex = 16
        SFemale.TabStop = True
        SFemale.Text = "F"
        SFemale.UseVisualStyleBackColor = False
        ' 
        ' AddStudent
        ' 
        AddStudent.BackColor = SystemColors.Window
        AddStudent.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStudent.Location = New Point(12, 197)
        AddStudent.Name = "AddStudent"
        AddStudent.Size = New Size(79, 39)
        AddStudent.TabIndex = 17
        AddStudent.Text = "Add"
        AddStudent.UseVisualStyleBackColor = False
        ' 
        ' ViewStudent
        ' 
        ViewStudent.BackColor = SystemColors.Window
        ViewStudent.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewStudent.Location = New Point(532, 197)
        ViewStudent.Name = "ViewStudent"
        ViewStudent.Size = New Size(86, 39)
        ViewStudent.TabIndex = 18
        ViewStudent.Text = "View"
        ViewStudent.UseVisualStyleBackColor = False
        ' 
        ' TextBox_SID
        ' 
        TextBox_SID.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_SID.Location = New Point(79, 110)
        TextBox_SID.Name = "TextBox_SID"
        TextBox_SID.Size = New Size(90, 35)
        TextBox_SID.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlDarkDark
        Label8.Location = New Point(79, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 32)
        Label8.TabIndex = 20
        Label8.Text = "ID"
        ' 
        ' Update
        ' 
        Update.BackColor = SystemColors.Window
        Update.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Update.Location = New Point(158, 197)
        Update.Name = "Update"
        Update.Size = New Size(109, 39)
        Update.TabIndex = 23
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' Delete
        ' 
        Delete.BackColor = SystemColors.Window
        Delete.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(353, 197)
        Delete.Name = "Delete"
        Delete.Size = New Size(110, 39)
        Delete.TabIndex = 24
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(629, 235)
        Controls.Add(Delete)
        Controls.Add(Update)
        Controls.Add(Label8)
        Controls.Add(TextBox_SID)
        Controls.Add(ViewStudent)
        Controls.Add(AddStudent)
        Controls.Add(SFemale)
        Controls.Add(SMale)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox_SCourse)
        Controls.Add(Label5)
        Controls.Add(TextBox_SYrL)
        Controls.Add(Label4)
        Controls.Add(TextBox_SAge)
        Controls.Add(Label3)
        Controls.Add(TextBox_SMN)
        Controls.Add(Label2)
        Controls.Add(TextBox_SFN)
        Controls.Add(TextBox_SLN)
        Controls.Add(Label1)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Student Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_SLN As TextBox
    Friend WithEvents TextBox_SFN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_SMN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_SAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_SYrL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_SCourse As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SMale As RadioButton
    Friend WithEvents SFemale As RadioButton
    Friend WithEvents AddStudent As Button
    Friend WithEvents ViewStudent As Button
    Friend WithEvents TextBox_SID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
End Class
