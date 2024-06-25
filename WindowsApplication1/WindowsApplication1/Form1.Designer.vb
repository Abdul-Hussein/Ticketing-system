<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VoiceRecordingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.SolutionDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ModelToolStripMenuItem, Me.SubToolStripMenuItem, Me.VoiceRecordingToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "Master"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ModelToolStripMenuItem
        '
        Me.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem"
        Me.ModelToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ModelToolStripMenuItem.Text = "Main Issue"
        '
        'SubToolStripMenuItem
        '
        Me.SubToolStripMenuItem.Name = "SubToolStripMenuItem"
        Me.SubToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SubToolStripMenuItem.Text = "Sub Issue"
        '
        'VoiceRecordingToolStripMenuItem
        '
        Me.VoiceRecordingToolStripMenuItem.Name = "VoiceRecordingToolStripMenuItem"
        Me.VoiceRecordingToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VoiceRecordingToolStripMenuItem.Text = "Voice Recording"
        Me.VoiceRecordingToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(63, 20)
        Me.ToolStripMenuItem2.Text = "Solution"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolutionDetailsToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.LogDetailsToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem3.Text = "Report"
        '
        'SolutionDetailsToolStripMenuItem
        '
        Me.SolutionDetailsToolStripMenuItem.Name = "SolutionDetailsToolStripMenuItem"
        Me.SolutionDetailsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SolutionDetailsToolStripMenuItem.Text = "Solution Details"
        Me.SolutionDetailsToolStripMenuItem.Visible = False
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'LogDetailsToolStripMenuItem
        '
        Me.LogDetailsToolStripMenuItem.Name = "LogDetailsToolStripMenuItem"
        Me.LogDetailsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LogDetailsToolStripMenuItem.Text = "Log Details"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.stock_photo_hand_holding_a_wooden_puzzle_with_the_word_solution_there_is_a_matching_puzzle_next_to_it_with_the_1098145733
        Me.ClientSize = New System.Drawing.Size(1284, 1005)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "IT Solutions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolutionDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VoiceRecordingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
