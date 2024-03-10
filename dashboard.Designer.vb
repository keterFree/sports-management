<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        dashimg = New PictureBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        hometitle = New Label()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(dashimg, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 1, 1)
        TableLayoutPanel2.Location = New Point(3, 67)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 3
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 31.25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 37.5F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 31.25F))
        TableLayoutPanel2.Size = New Size(1002, 469)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(dashimg, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 0)
        TableLayoutPanel1.Location = New Point(253, 149)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(5)
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(495, 169)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' dashimg
        ' 
        dashimg.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dashimg.BackColor = Color.Transparent
        dashimg.Location = New Point(10, 10)
        dashimg.Name = "dashimg"
        dashimg.Size = New Size(233, 149)
        dashimg.TabIndex = 0
        dashimg.TabStop = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.BackColor = SystemColors.ControlLight
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(Label5, 0, 3)
        TableLayoutPanel3.Controls.Add(Label4, 0, 2)
        TableLayoutPanel3.Controls.Add(Label3, 0, 1)
        TableLayoutPanel3.Controls.Add(Label2, 0, 0)
        TableLayoutPanel3.Location = New Point(251, 10)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 4
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Size = New Size(234, 149)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(3, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(228, 38)
        Label5.TabIndex = 4
        Label5.Text = "Sport"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(3, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(228, 37)
        Label4.TabIndex = 3
        Label4.Text = "Tier"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(3, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(228, 37)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Ravie", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 37)
        Label2.TabIndex = 1
        Label2.Text = "Full Name"
        Label2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.BackColor = Color.Transparent
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel2, 0, 1)
        TableLayoutPanel4.Controls.Add(hometitle, 0, 0)
        TableLayoutPanel4.Location = New Point(12, 12)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 12F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 88F))
        TableLayoutPanel4.Size = New Size(1008, 539)
        TableLayoutPanel4.TabIndex = 2
        ' 
        ' hometitle
        ' 
        hometitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        hometitle.AutoSize = True
        hometitle.BackColor = SystemColors.ControlDark
        hometitle.Font = New Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hometitle.Location = New Point(3, 0)
        hometitle.Name = "hometitle"
        hometitle.Size = New Size(1002, 64)
        hometitle.TabIndex = 2
        hometitle.Text = "Michezo sports system"
        hometitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        BackgroundImage = My.Resources.Resources.wall2
        ClientSize = New Size(1032, 563)
        ControlBox = False
        Controls.Add(TableLayoutPanel4)
        Name = "dashboard"
        Text = "dashboard"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        CType(dashimg, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dashimg As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents hometitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
