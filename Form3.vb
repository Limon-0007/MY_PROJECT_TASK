Imports Microsoft.Win32

Public Class Form3
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Employee)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub EmployeeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        EmployeeDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EmployeeBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmployeeBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                EmployeeBindingSource.RemoveCurrent()
                EmployeeTableAdapter.Update(Access_tables_for_projectDataSet.Employee)
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            EmployeeBindingSource.EndEdit()
            EmployeeTableAdapter.Update(Access_tables_for_projectDataSet.Employee)
            MessageBox.Show("Record saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            EmployeeBindingSource.Filter = Nothing
            Access_tables_for_projectDataSet.Employee.Clear()
            EmployeeTableAdapter.Fill(Access_tables_for_projectDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EmployeeDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellContentClick
        EmployeeDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub
    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Dim x As String
        x = TextBox1.Text.Trim().ToString()
        EmployeeTableAdapter.FillBy(Me.Access_tables_for_projectDataSet.Employee, x, x)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class