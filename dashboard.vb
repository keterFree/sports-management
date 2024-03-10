Public Class dashboard

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
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeImg("C:\Users\ADMIN\Downloads\passport.png")
        WindowState = FormWindowState.Maximized
        ' Call ApplyButtonHoverEffects method to attach event handlers to all buttons
        ApplyButtonHoverEffects(Me)

    End Sub
    Private Sub changeImg(imgUrl As String)
        ' Load an image from file
        dashimg.Image = Image.FromFile(imgUrl)
        dashimg.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

End Class