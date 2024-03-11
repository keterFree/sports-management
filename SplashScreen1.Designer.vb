<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Copyright = New Label()
        Version = New Label()
        Label1 = New Label()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MainLayoutPanel.BackgroundImage = My.Resources.Resources.wall2
        MainLayoutPanel.ColumnCount = 3
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 2, 2)
        MainLayoutPanel.Controls.Add(Label1, 1, 1)
        MainLayoutPanel.Location = New Point(1, -1)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowCount = 3
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        MainLayoutPanel.Size = New Size(1338, 767)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 159F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Location = New Point(1024, 611)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(181, 54)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.DimGray
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Copyright.ForeColor = SystemColors.ButtonHighlight
        Copyright.Location = New Point(14, 32)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(152, 17)
        Copyright.TabIndex = 2
        Copyright.Text = "@group14"
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.DimGray
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Version.ForeColor = SystemColors.ButtonHighlight
        Version.Location = New Point(14, 5)
        Version.Name = "Version"
        Version.Size = New Size(152, 17)
        Version.TabIndex = 1
        Version.Text = "Version 1.0"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(449, 255)
        Label1.Name = "Label1"
        Label1.Size = New Size(440, 255)
        Label1.TabIndex = 2
        Label1.Text = "Michezo System" & vbCrLf & "Group 7"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1340, 767)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        MainLayoutPanel.PerformLayout()
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Copyright As Label
    Friend WithEvents Version As Label
    Friend WithEvents Label1 As Label

End Class
