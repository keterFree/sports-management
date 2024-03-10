<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents login3 As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        login3 = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        OK = New Button()
        Cancel = New Button()
        login2 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        login1 = New TableLayoutPanel()
        logintitle = New Label()
        login0 = New TableLayoutPanel()
        login2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        login1.SuspendLayout()
        login0.SuspendLayout()
        SuspendLayout()
        ' 
        ' login3
        ' 
        login3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login3.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        login3.ForeColor = SystemColors.ControlText
        login3.Location = New Point(11, 8)
        login3.Name = "login3"
        login3.Size = New Size(365, 43)
        login3.TabIndex = 0
        login3.Text = "&User name:"
        login3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PasswordLabel.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        PasswordLabel.ForeColor = SystemColors.ControlText
        PasswordLabel.Location = New Point(11, 101)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(365, 29)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Password:"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        UsernameTextBox.Location = New Point(11, 54)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(365, 27)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PasswordTextBox.Location = New Point(11, 133)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(365, 27)
        PasswordTextBox.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        OK.Location = New Point(3, 3)
        OK.Name = "OK"
        OK.Size = New Size(246, 32)
        OK.TabIndex = 4
        OK.Text = "&log in"
        ' 
        ' Cancel
        ' 
        Cancel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(255, 3)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(107, 32)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancel"
        ' 
        ' login2
        ' 
        login2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login2.BackColor = Color.Transparent
        login2.ColumnCount = 3
        login2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        login2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        login2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        login2.Controls.Add(TableLayoutPanel2, 1, 1)
        login2.Location = New Point(3, 84)
        login2.Name = "login2"
        login2.RowCount = 3
        login2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        login2.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        login2.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        login2.Size = New Size(655, 322)
        login2.TabIndex = 6
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.BackColor = Color.Snow
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(login3, 0, 0)
        TableLayoutPanel2.Controls.Add(UsernameTextBox, 0, 1)
        TableLayoutPanel2.Controls.Add(PasswordTextBox, 0, 3)
        TableLayoutPanel2.Controls.Add(PasswordLabel, 0, 2)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 4)
        TableLayoutPanel2.Location = New Point(134, 35)
        TableLayoutPanel2.MaximumSize = New Size(400, 254)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(8)
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 46.4788742F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 53.5211258F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 29F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 69F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel2.Size = New Size(387, 251)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 113F))
        TableLayoutPanel3.Controls.Add(OK, 0, 0)
        TableLayoutPanel3.Controls.Add(Cancel, 1, 0)
        TableLayoutPanel3.Location = New Point(11, 202)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(365, 38)
        TableLayoutPanel3.TabIndex = 4
        ' 
        ' login1
        ' 
        login1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login1.BackColor = Color.Transparent
        login1.ColumnCount = 1
        login1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        login1.Controls.Add(login2, 0, 1)
        login1.Controls.Add(logintitle, 0, 0)
        login1.Location = New Point(90, 57)
        login1.MaximumSize = New Size(666, 413)
        login1.Name = "login1"
        login1.RowCount = 2
        login1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        login1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        login1.Size = New Size(661, 409)
        login1.TabIndex = 7
        ' 
        ' logintitle
        ' 
        logintitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        logintitle.AutoSize = True
        logintitle.BackColor = SystemColors.ActiveCaption
        logintitle.BorderStyle = BorderStyle.FixedSingle
        logintitle.Font = New Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logintitle.ForeColor = SystemColors.ButtonFace
        logintitle.Location = New Point(3, 0)
        logintitle.Name = "logintitle"
        logintitle.Size = New Size(655, 81)
        logintitle.TabIndex = 7
        logintitle.Text = "Log in"
        logintitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' login0
        ' 
        login0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login0.BackColor = Color.Transparent
        login0.ColumnCount = 3
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 667F))
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        login0.Controls.Add(login1, 1, 1)
        login0.Location = New Point(-2, -1)
        login0.Name = "login0"
        login0.RowCount = 3
        login0.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        login0.RowStyles.Add(New RowStyle(SizeType.Absolute, 415F))
        login0.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        login0.Size = New Size(841, 524)
        login0.TabIndex = 8
        ' 
        ' Login
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        BackgroundImage = My.Resources.Resources.wall
        CancelButton = Cancel
        ClientSize = New Size(839, 526)
        Controls.Add(login0)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        login2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        login1.ResumeLayout(False)
        login1.PerformLayout()
        login0.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents login2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents login1 As TableLayoutPanel
    Friend WithEvents logintitle As Label
    Friend WithEvents login0 As TableLayoutPanel

End Class
