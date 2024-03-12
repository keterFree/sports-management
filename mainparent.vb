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


    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click
        If Me.ActiveMdiChild Is dashboard Then
            Me.Close()
        End If
        Dim newForm As New dashboard()
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click
        WindowState = FormWindowState.Maximized
        Home.MdiParent = Me
        KeepActivateMdiChild(Home)
        If Me.ActiveMdiChild Is Home Then
            ' If it is, show the child form
            MenuStrip.Hide()
        End If
    End Sub


    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click

        If selectedsport.coachid <> 0 Then
            selectedsport.coachid = 0
            selectedsport.Full_name = "Log in"
            selectedsport.coachEmail = ""
            selectedsport.sportid = 0
            selectedsport.sportid = "Michezo system"
            MessageBox.Show("You have successfully loged out")
            If Me.ActiveMdiChild Is Login Then
                Me.Close()
            End If
            Dim newForm As New Home()
            newForm.MdiParent = Me
            newForm.Show()

        Else
            Login.MdiParent = Me
            KeepActivateMdiChild(Login)
        End If

    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        If selectedsport.coachid <> 0 Then
            MessageBox.Show("You are logged in as: " & selectedsport.Full_name)
        Else
            signup.MdiParent = Me
            KeepActivateMdiChild(signup)
        End If
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

    Private Sub mainparent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Login.MdiParent = Me
        KeepActivateMdiChild(Login)
    End Sub
End Class
