<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        SDataList = New DataGridView()
        CType(SDataList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SDataList
        ' 
        SDataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SDataList.Location = New Point(-2, 0)
        SDataList.Name = "SDataList"
        SDataList.RowHeadersWidth = 51
        SDataList.Size = New Size(902, 451)
        SDataList.TabIndex = 0
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(900, 450)
        Controls.Add(SDataList)
        Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Student List"
        CType(SDataList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SDataList As DataGridView
End Class
