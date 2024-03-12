Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement




Public Class mainparent
        Dim conn As MySqlConnection
        Dim COMMAND As MySqlCommand
    Private Sub KeepActivateMdiChild(ByVal mdiChildForm As Form)
        ' Iterate through all MDI child forms
        For Each childForm As Form In Me.MdiChildren
            ' Check if the child form is the one to be activated
            If childForm Is mdiChildForm Then
                ' If it is, show the child form
                mdiChildForm.Show()

            Else
                ' If it's not, hide the other child forms
                childForm.Close()
            End If
        Next
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        home.MdiParent = Me
        KeepActivateMdiChild(Home)
    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click
        dashboard.MdiParent = Me
        KeepActivateMdiChild(dashboard)
    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click
        Home.MdiParent = Me
        KeepActivateMdiChild(Home)
        If Me.ActiveMdiChild Is Home Then
            ' If it is, show the child form
            MenuStrip.Hide()
        End If
    End Sub

    Private Sub MyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyAccountToolStripMenuItem.Click
        useraccount.MdiParent = Me
        KeepActivateMdiChild(useraccount)
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        Login.MdiParent = Me
        KeepActivateMdiChild(Login)
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        signup.MdiParent = Me
        KeepActivateMdiChild(signup)
    End Sub

    Private Sub CheckConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckConnectionToolStripMenuItem.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=sports"
        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
