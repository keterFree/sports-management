Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub KeepActivateMdiChild(ByVal mdiChildForm As Form)
        ' Iterate through all MDI child forms
        For Each childForm As Form In mainparent.MdiChildren
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
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Home.MdiParent = mainparent
        KeepActivateMdiChild(Home)
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
        btn.ForeColor = Color.DarkGreen
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        ' Revert the button's appearance when the mouse leaves
        Dim btn As Button = DirectCast(sender, Button)
        btn.BackColor = SystemColors.Control
        btn.ForeColor = SystemColors.ControlText
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        ApplyButtonHoverEffects(Me)
    End Sub
End Class
