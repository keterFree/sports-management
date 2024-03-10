<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class signup
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
        login0 = New TableLayoutPanel()
        login1 = New TableLayoutPanel()
        login2 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        login3 = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        PasswordLabel = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        OK = New Button()
        Cancel = New Button()
        logintitle = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        TextBox4 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        cpassword = New Label()
        TextBox2 = New TextBox()
        TableLayoutPanel7 = New TableLayoutPanel()
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        login1.SuspendLayout()
        login2.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' login0
        ' 
        login0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login0.BackColor = Color.Transparent
        login0.ColumnCount = 3
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 667F))
        login0.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        login0.Location = New Point(0, 0)
        login0.Name = "login0"
        login0.RowCount = 3
        login0.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        login0.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        login0.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        login0.Size = New Size(200, 100)
        login0.TabIndex = 0
        ' 
        ' login1
        ' 
        login1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login1.BackColor = Color.Transparent
        login1.ColumnCount = 1
        login1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        login1.Controls.Add(login2, 0, 1)
        login1.Controls.Add(logintitle, 0, 0)
        login1.Location = New Point(-230, 3)
        login1.MaximumSize = New Size(666, 413)
        login1.Name = "login1"
        login1.RowCount = 2
        login1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        login1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        login1.Size = New Size(661, 409)
        login1.TabIndex = 7
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
        ' OK
        ' 
        OK.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        OK.Location = New Point(3, 3)
        OK.Name = "OK"
        OK.Size = New Size(246, 32)
        OK.TabIndex = 4
        OK.Text = "&OK"
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
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 667F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 1, 1)
        TableLayoutPanel1.Location = New Point(-1, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 559F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1072, 619)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.BackColor = Color.Transparent
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(TableLayoutPanel5, 0, 1)
        TableLayoutPanel4.Controls.Add(Label3, 0, 0)
        TableLayoutPanel4.Location = New Point(205, 33)
        TableLayoutPanel4.MaximumSize = New Size(661, 559)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel4.Size = New Size(661, 553)
        TableLayoutPanel4.TabIndex = 7
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel5.BackColor = Color.Transparent
        TableLayoutPanel5.ColumnCount = 3
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 1, 1)
        TableLayoutPanel5.Location = New Point(3, 113)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 3
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 2.26244354F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 92.76018F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 4.97737551F))
        TableLayoutPanel5.Size = New Size(655, 437)
        TableLayoutPanel5.TabIndex = 6
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel6.BackColor = Color.Snow
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(TextBox4, 0, 3)
        TableLayoutPanel6.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel6.Controls.Add(Label4, 0, 2)
        TableLayoutPanel6.Controls.Add(Label1, 0, 0)
        TableLayoutPanel6.Controls.Add(Label2, 0, 4)
        TableLayoutPanel6.Controls.Add(TextBox3, 0, 7)
        TableLayoutPanel6.Controls.Add(cpassword, 0, 6)
        TableLayoutPanel6.Controls.Add(TextBox2, 0, 5)
        TableLayoutPanel6.Controls.Add(TableLayoutPanel7, 0, 8)
        TableLayoutPanel6.Location = New Point(134, 12)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.Padding = New Padding(8)
        TableLayoutPanel6.RowCount = 9
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102495F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102543F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1140633F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1140633F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102543F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102543F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102543F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1102495F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 11.1103592F))
        TableLayoutPanel6.Size = New Size(387, 399)
        TableLayoutPanel6.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox4.Location = New Point(11, 137)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(365, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(11, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(365, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(11, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(365, 42)
        Label4.TabIndex = 8
        Label4.Text = "&Email:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(11, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(365, 42)
        Label1.TabIndex = 0
        Label1.Text = "&User name:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(11, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(365, 42)
        Label2.TabIndex = 2
        Label2.Text = "&Password:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox3
        ' 
        TextBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox3.Location = New Point(11, 305)
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "*"c
        TextBox3.Size = New Size(365, 27)
        TextBox3.TabIndex = 6
        ' 
        ' cpassword
        ' 
        cpassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cpassword.Font = New Font("Segoe Print", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cpassword.ForeColor = SystemColors.ControlText
        cpassword.Location = New Point(11, 260)
        cpassword.Name = "cpassword"
        cpassword.Size = New Size(365, 42)
        cpassword.TabIndex = 5
        cpassword.Text = "&Confirm password:"
        cpassword.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(11, 221)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(365, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 113F))
        TableLayoutPanel7.Controls.Add(Button1, 0, 0)
        TableLayoutPanel7.Controls.Add(Button2, 1, 0)
        TableLayoutPanel7.Location = New Point(11, 347)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 1
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(365, 41)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(246, 35)
        Button1.TabIndex = 4
        Button1.Text = "&Sign up"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.DialogResult = DialogResult.Cancel
        Button2.Location = New Point(255, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 35)
        Button2.TabIndex = 5
        Button2.Text = "&Cancel"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(655, 110)
        Label3.TabIndex = 7
        Label3.Text = "Sign up"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' signup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wall
        ClientSize = New Size(1074, 616)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "signup"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "sign up"
        login1.ResumeLayout(False)
        login1.PerformLayout()
        login2.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents login0 As TableLayoutPanel
    Friend WithEvents login1 As TableLayoutPanel
    Friend WithEvents login2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents login3 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents logintitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cpassword As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label

End Class
