Imports System.Reflection.Emit

Public Class Home
    Private Sub KeepActivateMdiChild(ByVal mdiChildForm As Form)
        If selectedsport.coachid <> 0 Then
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
        Else
            MessageBox.Show("Log in to gain full access")
        End If

    End Sub

    Private Sub KeepActivateMdiChildbtn(ByVal mdiChildForm As Form)
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
        Label3.Text = selectedsport.Full_name
        designation.Text = selectedsport.coachEmail
        detailsName.Text = selectedsport.sportname
        ' Call ApplyButtonHoverEffects method to attach event handlers to all buttons
        ApplyButtonHoverEffects(Me)

        If selectedsport.coachid <> 0 Then
            blogin.Text = "Log out"
        Else
            blogin.Text = "Log in"
        End If
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
        If selectedsport.coachid <> 0 Then
            selectedsport.coachid = 0
            selectedsport.Full_name = "Log in"
            selectedsport.coachEmail = ""
            selectedsport.sportid = 0
            selectedsport.sportid = "Michezo system"
            MessageBox.Show("You have successfully loged out")
            Dim newForm As New Home()
            newForm.MdiParent = mainparent
            newForm.Show()
            Me.Close()
        Else
            Login.MdiParent = mainparent
            KeepActivateMdiChildbtn(Login)
        End If

    End Sub

    Private Sub bsignup_Click(sender As Object, e As EventArgs) Handles bsignup.Click
        If selectedsport.coachid <> 0 Then
            MessageBox.Show("You are logged in as: " & selectedsport.coachid)
        Else
            Login.MdiParent = mainparent
            KeepActivateMdiChildbtn(Login)
        End If
    End Sub

    Private Sub bhandball_Click(sender As Object, e As EventArgs) Handles bhandball.Click
        selectedsport.Data = "1"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bbasketball_Click(sender As Object, e As EventArgs) Handles bbasketball.Click
        selectedsport.Data = "2"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bkarate_Click(sender As Object, e As EventArgs) Handles bkarate.Click
        selectedsport.Data = "3"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bbadminton_Click(sender As Object, e As EventArgs) Handles bbadminton.Click
        selectedsport.Data = "4"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bhockey_Click(sender As Object, e As EventArgs) Handles bhockey.Click
        selectedsport.Data = "5"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bathletics_Click(sender As Object, e As EventArgs) Handles bathletics.Click
        selectedsport.Data = "6"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bfootball_Click(sender As Object, e As EventArgs) Handles bfootball.Click
        selectedsport.Data = "7"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub ptennis_Click(sender As Object, e As EventArgs) Handles ptennis.Click
        selectedsport.Data = "8"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bchess_Click(sender As Object, e As EventArgs) Handles bchess.Click
        selectedsport.Data = "9"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub brugby_Click(sender As Object, e As EventArgs) Handles brugby.Click
        selectedsport.Data = "10"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bswim_Click(sender As Object, e As EventArgs) Handles bswim.Click
        selectedsport.Data = "11"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

    Private Sub bvolley_Click(sender As Object, e As EventArgs) Handles bvolley.Click
        selectedsport.Data = "12"
        mysport.MdiParent = mainparent
        KeepActivateMdiChild(mysport)
    End Sub

End Class
