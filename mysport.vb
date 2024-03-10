Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement






Public Class mysport
    Dim thesport As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub mysport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thesport = selectedsport.Data
        sport.Text = thesport
        WindowState = FormWindowState.Maximized

        RetrieveDataFromDatabase("1")
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

    Private Sub RetrieveDataFromDatabase(ByVal sportValue As String)
        Dim connectionString As String = "server=localhost;userid=root;password='';database=sports"
        Dim queryString As String = "SELECT `player`, `firstname`, `lastname`, `DOB`, `mobile`, `bloodgroup`, `emergencycontact`, `email`, `sport` FROM `player` WHERE sport = @Sport"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@Sport", sportValue)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Clear existing items in the ListView
                PlayerList.Items.Clear()

                ' Check if the reader has any rows
                If reader.HasRows Then
                    While reader.Read()
                        ' Access the data from each row
                        Dim player As String = reader.GetString(0)
                        Dim firstName As String = reader.GetString(1)
                        Dim lastName As String = reader.GetString(2)
                        Dim mobile As String = reader.GetString(4)
                        Dim bloodGroup As String = reader.GetString(5)
                        Dim emergencyContact As String = reader.GetString(6)
                        Dim email As String = reader.GetString(7)

                        ' Calculate age from date of birth
                        Dim dob As Date = reader.GetDateTime(3)
                        Dim age As Integer = Date.Now.Year - dob.Year
                        If Date.Now < dob.AddYears(age) Then
                            age -= 1
                        End If

                        ' Concatenate first and last names
                        Dim fullName As String = $"{firstName} {lastName}"

                        ' Create a ListViewItem and add it to the ListView
                        Dim item As New ListViewItem({fullName, mobile, bloodGroup, emergencyContact, email, age.ToString()})
                        PlayerList.Items.Add(item)
                    End While
                Else
                    Console.WriteLine("No rows found.")
                End If
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If PlayerList.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = PlayerList.SelectedItems(0)

            ' Populate input controls with selected item's data for editing
            selectedsport.editmail = selectedItem.SubItems(4).Text

            editaccount.MdiParent = mainparent
            KeepActivateMdiChild(editaccount)
        End If


    End Sub
End Class