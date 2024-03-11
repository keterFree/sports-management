Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class editevent
    Private Sub editevent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        If Not String.IsNullOrWhiteSpace(selectedsport.editeventid) Then
            PopulateEventDetails(selectedsport.editeventid)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newForm As New mysport()
        newForm.MdiParent = mainparent
        newForm.Show()
        Me.Close()
    End Sub

    Private Sub PopulateEventDetails(ByVal eventID As Integer)
        ' Define connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"

        ' Define SQL query with parameters
        Dim queryString As String = "SELECT `sport`, `eventname`, `time`, `location` FROM `events` WHERE `eventid` = @EventID"

        ' Create MySqlConnection and MySqlCommand objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                ' Add parameter
                command.Parameters.AddWithValue("@EventID", eventID)

                Try
                    ' Open connection
                    connection.Open()

                    ' Execute the command and retrieve data
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Check if there are rows returned
                        If reader.Read() Then
                            ' Populate text boxes with data from the database
                            'TextBoxSport.Text = reader.GetString(0)
                            TextBox4.Text = reader.GetString(1)
                            DateTimePicker1.Value = reader.GetDateTime(2)
                            TextBox2.Text = reader.GetString(3)
                        Else
                            MessageBox.Show("Event not found.")
                        End If
                    End Using
                Catch ex As Exception
                    ' Handle exception
                    MessageBox.Show($"Error retrieving event details: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub


    Private Function AddEventToDatabase() As Boolean
        ' Retrieve data from text boxes and DateTimePicker control
        Dim sport As String = selectedsport.Data
        Dim eventName As String = TextBox4.Text.Trim()
        Dim eventTime As DateTime = DateTimePicker1.Value
        Dim location As String = TextBox2.Text.Trim()

        ' Define connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"

        ' Define SQL query with parameters
        Dim queryString As String = "INSERT INTO `events`(`sport`, `eventname`, `time`, `location`) VALUES (@Sport, @EventName, @Time, @Location)"

        ' Create MySqlConnection and MySqlCommand objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@Sport", sport)
                command.Parameters.AddWithValue("@EventName", eventName)
                command.Parameters.AddWithValue("@Time", eventTime)
                command.Parameters.AddWithValue("@Location", location)

                Try
                    ' Open connection
                    connection.Open()

                    ' ExecuteNonQuery() for insert operation
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        Return True ' Record added successfully
                    Else
                        Return False ' Record not added (could be due to error)
                    End If
                Catch ex As Exception
                    ' Handle exception
                    MessageBox.Show($"Error adding event to the database: {ex.Message}")
                    Return False ' Record not added due to exception
                End Try
            End Using
        End Using
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If AddEventToDatabase() Then
            MessageBox.Show("Event details added successfully.")
            Dim newForm As New mysport()
            newForm.MdiParent = mainparent
            newForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Event not found or no changes made.")
        End If
    End Sub
    Private Function ValidateInputs() As Boolean

        ' Validate event name
        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please enter a valid event name.")
            Return False
        End If

        ' Validate location
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter a valid location.")
            Return False
        End If

        ' If all validations passed
        Return True
    End Function

    Private Sub UpdateEventDetails(ByVal eventID As Integer)

        If Not ValidateInputs() Then
            ' Validation failed, exit function
            Return
        End If

        ' Retrieve data from text boxes and DateTimePicker control
        Dim sport As String = selectedsport.Data
        Dim eventName As String = TextBox4.Text.Trim()
        Dim eventTime As DateTime = DateTimePicker1.Value
        Dim location As String = TextBox2.Text.Trim()

        ' Define connection string
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"

        ' Define SQL query with parameters
        Dim queryString As String = "UPDATE `events` SET `sport` = @Sport, `eventname` = @EventName, `time` = @Time, `location` = @Location WHERE `eventid` = @EventID"

        ' Create MySqlConnection and MySqlCommand objects
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryString, connection)
                ' Add parameters
                command.Parameters.AddWithValue("@Sport", sport)
                command.Parameters.AddWithValue("@EventName", eventName)
                command.Parameters.AddWithValue("@Time", eventTime)
                command.Parameters.AddWithValue("@Location", location)
                command.Parameters.AddWithValue("@EventID", eventID)

                Try
                    ' Open connection
                    connection.Open()

                    ' ExecuteNonQuery() for update operation
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Check if any rows were affected
                    If rowsAffected > 0 Then
                        MessageBox.Show("Event details updated successfully.")
                    Else
                        MessageBox.Show("Event not found or no changes made.")
                    End If
                Catch ex As Exception
                    ' Handle exception
                    MessageBox.Show($"Error updating event details: {ex.Message}")
                End Try
            End Using
        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateEventDetails(selectedsport.editeventid)
    End Sub

End Class