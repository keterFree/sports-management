Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

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

        ' Retrieve email and password from text boxes or other input controls
        Dim email As String = mailbox.Text.Trim()
        Dim password As String = Passwordbox.Text

        ' Call the Login function
        Dim loginSuccessful As Boolean = Login(email, password)

        ' If login is successful, perform further actions
        If loginSuccessful Then
            ' Redirect to another page or perform other necessary actions
            Dim newForm As New Home()
            newForm.MdiParent = mainparent
            newForm.Show()
            Me.Close()
        Else
            ' Clear password field or display error message, etc.
            ' Display an error message or clear password field
            'MessageBox.Show("Invalid email or password.")

        End If

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

    Private Function Login(ByVal email As String, ByVal password As String) As Boolean
        ' Validate inputs
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        ' Define connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"

        ' Define SQL query to retrieve user credentials and additional information
        Dim queryString As String = "SELECT `coachid`, `firstname`, `lastname`, `email`, `sport`, `contacts`, `password` FROM `coaches` WHERE `email` = @Email"

        ' Create MySqlConnection and MySqlCommand objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                ' Add parameter
                command.Parameters.AddWithValue("@Email", email)

                Try
                    ' Open connection
                    connection.Open()

                    ' Execute the command and retrieve user information from the database
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    ' Check if a record is found
                    If reader.Read() Then
                        ' Retrieve user information
                        Dim hashedPassword As String = reader.GetString("password")
                        Dim storedCoachId As String = reader.GetInt32("coachid")
                        Dim firstName As String = reader.GetString("firstname")
                        Dim lastName As String = reader.GetString("lastname")
                        Dim sportId As String = reader.GetInt32("sport")
                        Dim storedEmail As String = reader.GetString("email")

                        ' Check if the password matches
                        Dim hashedProvidedPassword As String = HashPassword(password)
                        If hashedPassword = hashedProvidedPassword Then
                            ' Set values for the variables
                            selectedsport.Full_name = $"{firstName} {lastName}"
                            selectedsport.coachid = storedCoachId
                            selectedsport.coachEmail = storedEmail
                            selectedsport.sportid = sportId
                            selectedsport.sportname = GetSportNameById(sportId)

                            ' Display success message
                            MessageBox.Show("Login successful.")

                            Return True
                        Else
                            ' Password does not match
                            MessageBox.Show("Invalid  password.")
                            Passwordbox.Clear()
                            ' Optionally, set focus back to the password field
                            Passwordbox.Focus()
                            Return False
                        End If
                    Else
                        ' No user found with the given email
                        MessageBox.Show("Invalid email.")
                        mailbox.Clear()
                        ' Optionally, set focus back to the password field
                        mailbox.Focus()
                        Return False
                    End If
                Catch ex As Exception
                    ' Handle exception
                    MessageBox.Show($"Error logging in: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function GetSportNameById(sportId As Integer) As String
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        ' SQL query to retrieve the sport name based on sport ID
        Dim query As String = "SELECT sportname FROM sport WHERE sportid = @SportId"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameter to prevent SQL injection
                command.Parameters.AddWithValue("@SportId", sportId)

                ' Execute the SQL command and get the sport name
                Dim sportName As Object = command.ExecuteScalar()

                ' Check if the sport name is not null
                If sportName IsNot Nothing AndAlso Not DBNull.Value.Equals(sportName) Then
                    Return sportName.ToString()
                Else
                    Return "sport" ' Sport name not found
                End If
            End Using
        End Using
    End Function


    Private Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = sha256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To hashedBytes.Length - 1
                builder.Append(hashedBytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim newForm As New signup()
        newForm.MdiParent = mainparent
        newForm.Show()
        Me.Close()
    End Sub
End Class
