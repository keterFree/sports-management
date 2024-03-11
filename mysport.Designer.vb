<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mysport
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
        mainlayout = New TableLayoutPanel()
        body = New TableLayoutPanel()
        Label1 = New Label()
        PlayerList = New ListView()
        pname = New ColumnHeader()
        pcontacts = New ColumnHeader()
        pblood = New ColumnHeader()
        pemergency = New ColumnHeader()
        pmail = New ColumnHeader()
        cage = New ColumnHeader()
        TableLayoutPanel1 = New TableLayoutPanel()
        addplayer = New Button()
        delete = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        cSport = New ColumnHeader()
        cEvent = New ColumnHeader()
        cTime = New ColumnHeader()
        cLocation = New ColumnHeader()
        eid = New ColumnHeader()
        playersLabel = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        sport = New Label()
        mainlayout.SuspendLayout()
        body.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainlayout
        ' 
        mainlayout.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        mainlayout.ColumnCount = 1
        mainlayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        mainlayout.Controls.Add(body, 0, 1)
        mainlayout.Controls.Add(sport, 0, 0)
        mainlayout.Location = New Point(12, 12)
        mainlayout.Name = "mainlayout"
        mainlayout.RowCount = 2
        mainlayout.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        mainlayout.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        mainlayout.Size = New Size(1430, 809)
        mainlayout.TabIndex = 0
        ' 
        ' body
        ' 
        body.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        body.ColumnCount = 2
        body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.08419F))
        body.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.9158058F))
        body.Controls.Add(Label1, 1, 0)
        body.Controls.Add(PlayerList, 0, 1)
        body.Controls.Add(TableLayoutPanel1, 0, 2)
        body.Controls.Add(ListView1, 1, 1)
        body.Controls.Add(playersLabel, 0, 0)
        body.Controls.Add(TableLayoutPanel2, 1, 2)
        body.Location = New Point(3, 124)
        body.Name = "body"
        body.RowCount = 3
        body.RowStyles.Add(New RowStyle(SizeType.Percent, 9.807356F))
        body.RowStyles.Add(New RowStyle(SizeType.Percent, 90.19264F))
        body.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        body.Size = New Size(1424, 682)
        body.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(944, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(477, 62)
        Label1.TabIndex = 3
        Label1.Text = "The selected sport"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PlayerList
        ' 
        PlayerList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PlayerList.BackColor = SystemColors.Menu
        PlayerList.Columns.AddRange(New ColumnHeader() {pname, pcontacts, pblood, pemergency, pmail, cage})
        PlayerList.Location = New Point(3, 65)
        PlayerList.Name = "PlayerList"
        PlayerList.Size = New Size(935, 573)
        PlayerList.TabIndex = 1
        PlayerList.UseCompatibleStateImageBehavior = False
        PlayerList.View = View.Details
        ' 
        ' pname
        ' 
        pname.Text = "Player Name"
        pname.Width = 150
        ' 
        ' pcontacts
        ' 
        pcontacts.Text = "Contacts"
        pcontacts.Width = 100
        ' 
        ' pblood
        ' 
        pblood.Text = "Blood group"
        pblood.Width = 100
        ' 
        ' pemergency
        ' 
        pemergency.Text = "Emergency contacts"
        pemergency.Width = 150
        ' 
        ' pmail
        ' 
        pmail.DisplayIndex = 5
        pmail.Text = "Email"
        pmail.Width = 180
        ' 
        ' cage
        ' 
        cage.DisplayIndex = 4
        cage.Text = "Age"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(addplayer, 0, 0)
        TableLayoutPanel1.Controls.Add(delete, 1, 0)
        TableLayoutPanel1.Controls.Add(Button1, 0, 0)
        TableLayoutPanel1.Location = New Point(3, 644)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(935, 35)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' addplayer
        ' 
        addplayer.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        addplayer.Location = New Point(481, 3)
        addplayer.Name = "addplayer"
        addplayer.Size = New Size(138, 29)
        addplayer.TabIndex = 6
        addplayer.Text = "Add player"
        addplayer.UseVisualStyleBackColor = True
        ' 
        ' delete
        ' 
        delete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        delete.AutoEllipsis = True
        delete.Location = New Point(794, 3)
        delete.Name = "delete"
        delete.Size = New Size(138, 29)
        delete.TabIndex = 5
        delete.Text = "Delete player"
        delete.TextImageRelation = TextImageRelation.ImageBeforeText
        delete.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 29)
        Button1.TabIndex = 4
        Button1.Text = "Edit player details"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.BackColor = SystemColors.Menu
        ListView1.Columns.AddRange(New ColumnHeader() {cSport, cEvent, cTime, cLocation, eid})
        ListView1.Location = New Point(944, 65)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(477, 573)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' cSport
        ' 
        cSport.DisplayIndex = 1
        cSport.Text = "Sport"
        cSport.Width = 100
        ' 
        ' cEvent
        ' 
        cEvent.DisplayIndex = 2
        cEvent.Text = "Event name"
        cEvent.Width = 150
        ' 
        ' cTime
        ' 
        cTime.DisplayIndex = 3
        cTime.Text = "Time"
        cTime.Width = 100
        ' 
        ' cLocation
        ' 
        cLocation.DisplayIndex = 4
        cLocation.Text = "Location"
        cLocation.Width = 100
        ' 
        ' eid
        ' 
        eid.DisplayIndex = 0
        eid.Text = ""
        eid.Width = 30
        ' 
        ' playersLabel
        ' 
        playersLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        playersLabel.AutoSize = True
        playersLabel.Location = New Point(3, 0)
        playersLabel.Name = "playersLabel"
        playersLabel.Size = New Size(935, 62)
        playersLabel.TabIndex = 2
        playersLabel.Text = "The selected sport"
        playersLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(Button3, 0, 0)
        TableLayoutPanel2.Controls.Add(Button2, 0, 0)
        TableLayoutPanel2.Controls.Add(Button4, 0, 0)
        TableLayoutPanel2.Location = New Point(944, 644)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(477, 35)
        TableLayoutPanel2.TabIndex = 6
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(331, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(143, 29)
        Button3.TabIndex = 7
        Button3.Text = "Delete event"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.Location = New Point(170, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 29)
        Button2.TabIndex = 6
        Button2.Text = "Add event"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(3, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 29)
        Button4.TabIndex = 4
        Button4.Text = "Edit Event details"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' sport
        ' 
        sport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        sport.AutoSize = True
        sport.BackColor = SystemColors.ActiveCaption
        sport.Font = New Font("Segoe Print", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sport.Location = New Point(3, 0)
        sport.Name = "sport"
        sport.Size = New Size(1424, 121)
        sport.TabIndex = 1
        sport.Text = "The selected sport"
        sport.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' mysport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1454, 833)
        Controls.Add(mainlayout)
        Name = "mysport"
        Text = "mysport"
        mainlayout.ResumeLayout(False)
        mainlayout.PerformLayout()
        body.ResumeLayout(False)
        body.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainlayout As TableLayoutPanel
    Friend WithEvents body As TableLayoutPanel
    Friend WithEvents PlayerList As ListView
    Friend WithEvents pname As ColumnHeader
    Friend WithEvents pcontacts As ColumnHeader
    Friend WithEvents pblood As ColumnHeader
    Friend WithEvents pemergency As ColumnHeader
    Friend WithEvents pmail As ColumnHeader
    Friend WithEvents sport As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents playersLabel As Label
    Friend WithEvents cage As ColumnHeader
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents delete As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cSport As ColumnHeader
    Friend WithEvents cEvent As ColumnHeader
    Friend WithEvents cTime As ColumnHeader
    Friend WithEvents cLocation As ColumnHeader
    Friend WithEvents addplayer As Button
    Friend WithEvents eid As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
