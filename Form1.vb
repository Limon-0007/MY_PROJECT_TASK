Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredUsername As String = TextBox1.Text.Trim()
        Dim enteredPassword As String = TextBox2.Text.Trim()

        If enteredUsername = "" Or enteredPassword = "" Then
            MsgBox("Please enter both Username and Password.", MsgBoxStyle.OkOnly, "Login Failed")
            Exit Sub
        End If

        ' Ensure the table is filled with data
        Me.Emp_LoginTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Emp_Login)

        ' Search through all rows in the Emp_Login table
        For Each row As DataRow In Me.Access_tables_for_projectDataSet.Emp_Login.Rows
            Dim dbUsername As String = row("username").ToString().Trim()
            Dim dbPassword As String = row("password").ToString().Trim()

            If enteredUsername = dbUsername AndAlso enteredPassword = dbPassword Then
                MsgBox("Successfully logged in!!", MsgBoxStyle.OkOnly, "Welcome " & dbUsername)
                Form2.Show()
                Me.Hide()
                Exit Sub
            End If
        Next

        ' If no match found
        MsgBox("Invalid Username or Password", MsgBoxStyle.OkOnly, "Login Failed")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Emp_LoginTableAdapter.FillBy(Me.Access_tables_for_projectDataSet.Emp_Login, TextBox1.Text, TextBox2.Text)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.Emp_LoginTableAdapter.FillBy(Me.Access_tables_for_projectDataSet.Emp_Login, TextBox1.Text, TextBox2.Text)
    End Sub
    Private Sub Emp_LoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Emp_LoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Emp_Login' table. You can move, or remove it, as needed.
        Me.Emp_LoginTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Emp_Login)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim enteredUsername As String = InputBox("Enter Your Username to Retrieve Your Password", "Forgot Password")

        If enteredUsername.Trim() = "" Then
            MsgBox("Username is required.", MsgBoxStyle.OkOnly, "Warning")
            Exit Sub
        End If

        ' Reload latest data from the database
        Me.Emp_LoginTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Emp_Login)

        ' Search for the username
        Dim found As Boolean = False

        For Each row As DataRow In Me.Access_tables_for_projectDataSet.Emp_Login.Rows
            If row("Username").ToString().Trim().ToLower() = enteredUsername.Trim().ToLower() Then
                Dim password As String = row("Password").ToString()
                MsgBox("Your password is: " & password, MsgBoxStyle.OkOnly, "Password Recovery")
                found = True
                Exit For
            End If
        Next

        If Not found Then
            MsgBox("Username not found.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class
