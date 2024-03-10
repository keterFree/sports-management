Imports System.Reflection.Emit

Public Class Home
    Private Sub KeepActivateMdiChild(ByVal mdiChildForm As Form)
        ' Iterate through all MDI child forms
        For Each childForm As Form In mainparent.MdiChildren
            ' Check if the child form is the one to be activated
            If childForm Is mdiChildForm Then
                ' If it is, show the child form
                mdiChildForm.Show()
            Else
                ' If it's not, hide the other child forms
                childForm.Hide()
            End If
        Next
        If mainparent.ActiveMdiChild IsNot Me Then
            ' If it is, show the child form
            mainparent.MenuStrip.Show()
        End If
    End Sub

    Private Sub changeImg(imgUrl As String)
        ' Load an image from file
        PictureBox1.Image = Image.FromFile(imgUrl)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub Home_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        changeImg("C:\Users\ADMIN\Downloads\passport.png")
        ' Call ApplyButtonHoverEffects method to attach event handlers to all buttons
        ApplyButtonHoverEffects(Me)
    End Sub

    Private Sub ApplyButtonHoverEffects(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            ' Check if the control is a button
            If TypeOf ctrl Is Button Then
                ' Attach event handlers for MouseEnter and MouseLeave events
                AddHandler ctrl.MouseEnter, AddressOf Button_MouseEnter
                AddHandler ctrl.MouseLeave, AddressOf Button_MouseLeave
            End If

            ' If the control is a container, recursively call ApplyButtonHoverEffects
            If ctrl.HasChildren Then
                ApplyButtonHoverEffects(ctrl)
            End If
        Next
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        ' Change the button's appearance when the mouse enters
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = Color.LightGray
        btn.ForeColor = Color.Blue
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        ' Revert the button's appearance when the mouse leaves
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = SystemColors.Control
        btn.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub bdash_Click(sender As Object, e As EventArgs) Handles bdash.Click
        dashboard.MdiParent = mainparent
        KeepActivateMdiChild(dashboard)
    End Sub
    Private Sub buseraccount_Click(sender As Object, e As EventArgs) Handles buseraccount.Click
        useraccount.MdiParent = mainparent
        KeepActivateMdiChild(useraccount)
    End Sub

    Private Sub blogin_Click(sender As Object, e As EventArgs) Handles blogin.Click
        Login.MdiParent = mainparent
        KeepActivateMdiChild(Login)
    End Sub

    Private Sub bsignup_Click(sender As Object, e As EventArgs) Handles bsignup.Click
        signup.MdiParent = mainparent
        KeepActivateMdiChild(signup)
    End Sub

    Private Sub bhandball_Click(sender As Object, e As EventArgs) Handles bhandball.Click
        selectedsport.Data = "Handball"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub
End Class
