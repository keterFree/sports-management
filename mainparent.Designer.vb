<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainparent
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
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        FileMenu = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        SignUpToolStripMenuItem = New ToolStripMenuItem()
        LogInToolStripMenuItem = New ToolStripMenuItem()
        CheckConnectionToolStripMenuItem = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileMenu, EditMenu, SignUpToolStripMenuItem, LogInToolStripMenuItem, CheckConnectionToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(8, 3, 0, 3)
        MenuStrip.Size = New Size(843, 30)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' FileMenu
        ' 
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(96, 24)
        FileMenu.Text = "Dashboard"
        ' 
        ' EditMenu
        ' 
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(73, 24)
        EditMenu.Text = "Explore"
        ' 
        ' SignUpToolStripMenuItem
        ' 
        SignUpToolStripMenuItem.Name = "SignUpToolStripMenuItem"
        SignUpToolStripMenuItem.Size = New Size(71, 24)
        SignUpToolStripMenuItem.Text = "sign up"
        ' 
        ' LogInToolStripMenuItem
        ' 
        LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        LogInToolStripMenuItem.Size = New Size(61, 24)
        LogInToolStripMenuItem.Text = "log in"
        ' 
        ' CheckConnectionToolStripMenuItem
        ' 
        CheckConnectionToolStripMenuItem.Name = "CheckConnectionToolStripMenuItem"
        CheckConnectionToolStripMenuItem.Size = New Size(137, 24)
        CheckConnectionToolStripMenuItem.Text = "check connection"
        ' 
        ' mainparent
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 697)
        Controls.Add(MenuStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 5, 4, 5)
        Name = "mainparent"
        Text = "Michezo"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents SignUpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckConnectionToolStripMenuItem As ToolStripMenuItem

End Class
