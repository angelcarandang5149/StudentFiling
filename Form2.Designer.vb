<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Logout = New Button()
        View1 = New Button()
        Edit1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        View2 = New Button()
        Edit2 = New Button()
        SuspendLayout()
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.Window
        Logout.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logout.Location = New Point(255, 249)
        Logout.Name = "Logout"
        Logout.Size = New Size(110, 41)
        Logout.TabIndex = 3
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = False
        ' 
        ' View1
        ' 
        View1.BackColor = SystemColors.Window
        View1.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        View1.Location = New Point(92, 70)
        View1.Name = "View1"
        View1.Size = New Size(88, 38)
        View1.TabIndex = 4
        View1.Text = "View"
        View1.UseVisualStyleBackColor = False
        ' 
        ' Edit1
        ' 
        Edit1.BackColor = SystemColors.Window
        Edit1.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Edit1.Location = New Point(187, 70)
        Edit1.Name = "Edit1"
        Edit1.Size = New Size(86, 38)
        Edit1.TabIndex = 5
        Edit1.Text = "Edit"
        Edit1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(112, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 43)
        Label1.TabIndex = 6
        Label1.Text = "Student"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(106, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 44)
        Label2.TabIndex = 7
        Label2.Text = "Employee"
        ' 
        ' View2
        ' 
        View2.BackColor = SystemColors.Window
        View2.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        View2.Location = New Point(92, 176)
        View2.Name = "View2"
        View2.Size = New Size(88, 39)
        View2.TabIndex = 8
        View2.Text = "View"
        View2.UseVisualStyleBackColor = False
        ' 
        ' Edit2
        ' 
        Edit2.BackColor = SystemColors.Window
        Edit2.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Edit2.Location = New Point(187, 176)
        Edit2.Name = "Edit2"
        Edit2.Size = New Size(86, 39)
        Edit2.TabIndex = 9
        Edit2.Text = "Edit"
        Edit2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(362, 289)
        Controls.Add(Edit2)
        Controls.Add(View2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Edit1)
        Controls.Add(View1)
        Controls.Add(Logout)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Name Page"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Logout As Button
    Friend WithEvents View1 As Button
    Friend WithEvents Edit1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents View2 As Button
    Friend WithEvents Edit2 As Button
End Class
