Imports System.Diagnostics.Eventing
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class editaccount
    Private Sub editaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        If Not String.IsNullOrWhiteSpace(selectedsport.editmail) Then
            TextBox5.Text = selectedsport.editmail
            RetrieveDataEmail(selectedsport.editmail)
        End If
        PopulateComboBox()
    End Sub
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

    Private Sub RetrieveDataEmail(ByVal emailValue As String)
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        Dim queryString As String = "SELECT p.`player`, p.`firstname`, p.`lastname`, p.`DOB`, p.`mobile`, p.`bloodgroup`, p.`emergencycontact`, p.`email`, s.`sportname`
                                  FROM `player` p
                                  INNER JOIN `sport` s ON p.`sport` = s.`sportid`
                                  WHERE p.`email` = @Email"


        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@Email", emailValue)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Check if the reader has any rows
                If reader.HasRows Then
                    reader.Read() ' Read the first row

                    ' Populate the controls with retrieved data
                    TextBox3.Text = reader.GetString(1) & " " & reader.GetString(2)
                    TextBox1.Text = reader.GetString(5)
                    TextBox4.Text = reader.GetString(4)
                    DateTimePicker1.Value = reader.GetDateTime(3)
                    TextBox2.Text = reader.GetString(6)
                    ComboBox1.SelectedItem = reader.GetString(8) ' Assuming ComboBoxSport contains sport values
                Else
                    MessageBox.Show("No data found for the specified email.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

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



    Private connectionString As String = "server=localhost;userid=root;password='';database=sports"

    Private Sub InsertData()
        ' Retrieve data from text boxes and combo box
        Dim fullname As String = TextBox3.Text
        Dim names() As String = fullname.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        If names.Length < 2 Then
            MessageBox.Show("Please enter both first name and last name separated by a space.")
            Return
        End If

        Dim firstName As String = names(0)
        Dim lastName As String = names(1)

        Dim dob As Date = DateTimePicker1.Value
        Dim mobile As String = TextBox4.Text.Trim()
        Dim bloodgroup As String = TextBox1.Text.Trim()
        Dim emergencyContact As String = TextBox2.Text.Trim()
        Dim email As String = TextBox5.Text.Trim()
        Dim sport As String = ComboBox1.SelectedItem.ToString()

        ' Check if any of the required fields are empty
        If String.IsNullOrWhiteSpace(firstName) OrElse String.IsNullOrWhiteSpace(lastName) OrElse
                String.IsNullOrWhiteSpace(mobile) OrElse String.IsNullOrWhiteSpace(bloodgroup) OrElse
                String.IsNullOrWhiteSpace(emergencyContact) OrElse String.IsNullOrWhiteSpace(email) OrElse
                String.IsNullOrWhiteSpace(sport) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' Validate email format using regular expression
        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        ' Validate blood group format using regular expression
        If Not IsValidBloodGroup(bloodgroup) Then
            MessageBox.Show("Please enter a valid blood group (e.g., A+, B-, AB+, O-).")
            Return
        End If

        ' Check if email already exists
        If IsEmailExists(email) Then
            MessageBox.Show("Email already exists. Please use a different email.")
            Return
        End If

        ' SQL query to insert data into the player table
        Dim query As String = "INSERT INTO player (firstname, lastname, DOB, mobile, bloodgroup, emergencycontact, email, sport) " &
                              "VALUES (@Firstname, @Lastname, @DOB, @Mobile, @Bloodgroup, @EmergencyContact, @Email, @Sport)"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Firstname", firstName)
                command.Parameters.AddWithValue("@Lastname", lastName)
                command.Parameters.AddWithValue("@DOB", dob)
                command.Parameters.AddWithValue("@Mobile", mobile)
                command.Parameters.AddWithValue("@Bloodgroup", bloodgroup)
                command.Parameters.AddWithValue("@EmergencyContact", emergencyContact)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Sport", GetSportIdByName(sport))

                ' Execute the SQL command
                command.ExecuteNonQuery()

                MessageBox.Show("Data inserted successfully.")
                Dim newForm As New editaccount()
                newForm.MdiParent = mainparent
                newForm.Show()
                Me.Close()
            End Using
        End Using
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Validate email format using regular expression
        Dim emailRegex As New Regex("^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
        Return emailRegex.IsMatch(email)
    End Function

    Private Function IsValidBloodGroup(bloodGroup As String) As Boolean
        ' Validate blood group format using regular expression
        Dim bloodGroupRegex As New Regex("^(A|B|AB|O)[+-]$")
        Return bloodGroupRegex.IsMatch(bloodGroup)
    End Function
    Private Function IsEmailExists(email As String) As Boolean
        ' SQL query to check if the email already exists in the database
        Dim query As String = "SELECT COUNT(*) FROM player WHERE email = @Email"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameter to prevent SQL injection
                command.Parameters.AddWithValue("@Email", email)

                ' Execute the SQL command and get the count of rows
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' If count is greater than zero, email exists
                Return count > 0
            End Using
        End Using
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InsertData()
    End Sub

    Private Sub UpdateData()
        ' Retrieve data from text box and combo box
        Dim fullName As String = TextBox3.Text.Trim()
        Dim names() As String = fullName.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        If names.Length < 2 Then
            MessageBox.Show("Please enter both first name and last name separated by a space.")
            Return
        End If
        Dim firstName As String = names(0)
        Dim lastName As String = names(1)

        Dim dob As Date = DateTimePicker1.Value
        Dim mobile As String = TextBox4.Text.Trim()
        Dim bloodgroup As String = TextBox1.Text.Trim()
        Dim emergencyContact As String = TextBox2.Text.Trim()
        Dim email As String = TextBox5.Text.Trim()
        Dim sport As String

        If ComboBox1.SelectedItem IsNot Nothing Then
            sport = ComboBox1.SelectedItem.ToString()
        Else
            ' Set default value
            sport = selectedsport.Data
        End If

        ' Validate inputs
        If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) Then
            MessageBox.Show("Please enter both first name and last name.")
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If

        If Not IsValidBloodGroup(bloodgroup) Then
            MessageBox.Show("Please enter a valid blood group (e.g., A+, B-, AB+, O-).")
            Return
        End If

        ' SQL query to update data in the player table
        Dim query As String = "UPDATE player SET firstname = @Firstname, lastname = @Lastname, DOB = @DOB, mobile = @Mobile, " &
                              "bloodgroup = @Bloodgroup, emergencycontact = @EmergencyContact,email = @Email , sport = @Sport WHERE player= @PlayerID"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameters to prevent SQL injection
                command.Parameters.AddWithValue("@Firstname", firstName)
                command.Parameters.AddWithValue("@Lastname", lastName)
                command.Parameters.AddWithValue("@DOB", dob)
                command.Parameters.AddWithValue("@Mobile", mobile)
                command.Parameters.AddWithValue("@Bloodgroup", bloodgroup)
                command.Parameters.AddWithValue("@EmergencyContact", emergencyContact)
                command.Parameters.AddWithValue("@Sport", GetSportIdByName(sport))
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@PlayerID", GetPlayerIdByEmail(selectedsport.editmail))

                ' Execute the SQL command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Data updated successfully.")
                    Dim newForm As New mysport()
                    newForm.MdiParent = mainparent
                    newForm.Show()
                    Me.Close()
                Else
                    MessageBox.Show("No record found, try adding instead!")
                End If
            End Using
        End Using
    End Sub

    Private Function GetPlayerIdByEmail(email As String) As Integer
        ' SQL query to retrieve the player ID based on email
        Dim query As String = "SELECT player FROM player WHERE email = @Email"

        ' Create a connection to the MySQL database
        Using connection As New MySqlConnection(connectionString)
            ' Open the database connection
            connection.Open()

            ' Create a command to execute the SQL query
            Using command As New MySqlCommand(query, connection)
                ' Bind parameter to prevent SQL injection
                command.Parameters.AddWithValue("@Email", email)

                ' Execute the SQL command and get the player ID
                Dim playerId As Object = command.ExecuteScalar()

                ' Check if the player ID is not null
                If playerId IsNot Nothing AndAlso Not DBNull.Value.Equals(playerId) Then
                    Return Convert.ToInt32(playerId)
                Else
                    Return -1 ' Player ID not found
                End If
            End Using
        End Using
    End Function

    Private Function GetSportIdByName(sportName As String) As Integer
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New mysport()
        newForm.MdiParent = mainparent
        newForm.Show()
        Me.Close()
    End Sub
End Class