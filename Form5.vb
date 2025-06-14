Imports MY_PROJECT_TASK.access_tables_for_projectDataSetTableAdapters

Public Class Form5
    Private Sub DepartmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DepartmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DepartmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Department)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub DepartmentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentDataGridView.CellContentClick
        DepartmentDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DepartmentBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DepartmentBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            DepartmentBindingSource.EndEdit()
            DepartmentTableAdapter.Update(Access_tables_for_projectDataSet.Department)
            MessageBox.Show("Record saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DepartmentBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                DepartmentBindingSource.RemoveCurrent()
                DepartmentTableAdapter.Update(Access_tables_for_projectDataSet.Department)
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            DepartmentBindingSource.Filter = Nothing
            Access_tables_for_projectDataSet.Employee.Clear()
            DepartmentTableAdapter.Fill(Access_tables_for_projectDataSet.Department)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Application.Exit()
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Dim x As String
        x = TextBox1.Text.Trim().ToString()
        DepartmentTableAdapter.FillBy(Me.Access_tables_for_projectDataSet.Department, x)
    End Sub
End Class