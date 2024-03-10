Imports MySql.Data.MySqlClient

Public Class editaccount
    Private Sub editaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        Label7.Text = selectedsport.editmail
        PopulateComboBox()
        RetrieveDataEmail(selectedsport.editmail)
    End Sub

    Private Sub RetrieveDataEmail(ByVal emailValue As String)
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        Dim queryString As String = "SELECT p.`player`, p.`firstname`, p.`lastname`, p.`DOB`, p.`mobile`, p.`bloodgroup`, p.`emergencycontact`, p.`email`, s.`sportname`
FROM `player` p
INNER Join `sport` s ON p.`sport` = s.`sportid`"


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
                    Label5.Text = reader.GetString(1) & " " & reader.GetString(2)
                    TextBox1.Text = reader.GetString(4)
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
                        Dim sportName As String = reader.GetInt32(0)
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

End Class