Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class signup

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
    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs)

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

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        ApplyButtonHoverEffects(Me)
        PopulateComboBox()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.MdiParent = mainparent
        KeepActivateMdiChild(Home)
    End Sub

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

    Private Function SignUp(ByVal firstName As String, ByVal lastName As String, ByVal email As String, ByVal sport As String, ByVal contacts As String, ByVal password As String, ByVal confirmPassword As String) As Boolean
        ' Validate inputs
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(sport) OrElse String.IsNullOrWhiteSpace(contacts) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.")
            Return False
        End If

        ' Check if passwords match
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match.")
            Return False
        End If

        ' Hash the password
        Dim hashedPassword As String = HashPassword(password)

        ' Define connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"

        ' Define SQL query with parameters
        Dim queryString As String = "INSERT INTO `coaches`(`firstname`, `lastname`, `email`, `sport`, `contacts`, `password`) VALUES (@FirstName, @LastName, @Email, @Sport, @Contacts, @Password)"

        ' Create MySqlConnection and MySqlCommand objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@LastName", lastName)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Sport", GetSportIdByName(sport))
                command.Parameters.AddWithValue("@Contacts", contacts)
                command.Parameters.AddWithValue("@Password", hashedPassword)

                Try
                    ' Open connection
                    connection.Open()

                    ' ExecuteNonQuery() for insert operation
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        MessageBox.Show("Sign-up successful.")
                        Return True

                    Else
                        MessageBox.Show("Sign-up failed.")
                        Return False
                    End If
                Catch ex As Exception
                    ' Handle exception
                    MessageBox.Show($"Error signing up: {ex.Message}")
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve data from text boxes, combo box, and password text boxes
        Dim fullName As String = TextBox1.Text.Trim()
        Dim spaceIndex As Integer = fullName.IndexOf(" ")

        Dim firstName As String
        Dim lastName As String

        If spaceIndex <> -1 Then
            firstName = fullName.Substring(0, spaceIndex)
            lastName = fullName.Substring(spaceIndex + 1)
        Else
            ' If no space found, consider the entire input as first name
            firstName = fullName
            lastName = ""
        End If

        Dim email As String = TextBox4.Text.Trim()
        Dim sport As String = ComboBox1.SelectedItem.ToString()
        Dim contacts As String = TextBox5.Text.Trim()
        Dim password As String = TextBox2.Text
        Dim confirmPassword As String = TextBox3.Text

        ' Call the SignUp function with first name, last name, and other details
        Dim signUpSuccessful As Boolean = SignUp(firstName, lastName, email, sport, contacts, password, confirmPassword)

        If signUpSuccessful Then
            ' Clear the form or perform any other necessary actions
            Dim newForm As New Login()
            newForm.MdiParent = mainparent
            newForm.Show()
            Me.Close()
        End If

    End Sub

    Private Function GetSportIdByName(sportName As String) As Integer
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        ' SQL query to retrieve the sport ID based on sport name
        Dim query As String = "SELECT sportid FROM sport WHERE sportname = @SportName or sportid = @SportName"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameter to prevent SQL injection
                command.Parameters.AddWithValue("@SportName", sportName)

                ' Execute the SQL command and get the sport ID
                Dim sportId As Object = command.ExecuteScalar()

                ' Check if the sport ID is not null
                If sportId IsNot Nothing AndAlso Not DBNull.Value.Equals(sportId) Then
                    Return Convert.ToInt32(sportId)
                Else
                    Return -1 ' Sport ID not found
                End If
            End Using
        End Using
    End Function

    Private Sub PopulateComboBox()
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        Dim queryString As String = "SELECT `sportname` FROM `sport`"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Clear existing items in the ComboBox
                ComboBox1.Items.Clear()

                ' Check if the reader has any rows
                If reader.HasRows Then
                    While reader.Read()
                        ' Add sport name to the ComboBox
                        Dim sportName As String = reader.GetString(0)
                        ComboBox1.Items.Add(sportName)
                    End While
                Else
                    MessageBox.Show("No sports found.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim newForm As New Login()
        newForm.MdiParent = mainparent
        newForm.Show()
        Me.Close()
    End Sub
End Class
