Imports MY_PROJECT_TASK.access_tables_for_projectDataSetTableAdapters

Public Class Form6
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Staff)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        StaffBindingSource.MovePrevious()
    End Sub

    Private Sub StaffDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDataGridView.CellContentClick
        StaffDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            StaffBindingSource.EndEdit()
            StaffTableAdapter.Update(Access_tables_for_projectDataSet.Staff)
            MessageBox.Show("Record saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                StaffBindingSource.RemoveCurrent()
                StaffTableAdapter.Update(Access_tables_for_projectDataSet.Staff)
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            StaffBindingSource.Filter = Nothing
            Access_tables_for_projectDataSet.Employee.Clear()
            StaffTableAdapter.Fill(Access_tables_for_projectDataSet.Staff)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StaffBindingSource.MoveNext()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StaffBindingSource.AddNew()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Application.Exit()
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Dim x As String
        x = TextBox1.Text.Trim().ToString()
        StaffTableAdapter.FillBy(Me.Access_tables_for_projectDataSet.Staff, x)
    End Sub
End Class