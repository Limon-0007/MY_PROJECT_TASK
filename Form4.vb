Public Class Form4
    Private Sub PayrollBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PayrollBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PayrollBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Department' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Payroll)
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Payroll)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PayrollBindingSource.MovePrevious()
    End Sub

    Private Sub PayrollDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PayrollDataGridView.CellContentClick
        PayrollDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PayrollBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            PayrollBindingSource.EndEdit()
            PayrollTableAdapter.Update(Access_tables_for_projectDataSet.Payroll)
            MessageBox.Show("Record saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                PayrollBindingSource.RemoveCurrent()
                PayrollTableAdapter.Update(Access_tables_for_projectDataSet.Payroll)
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            PayrollBindingSource.Filter = Nothing
            Access_tables_for_projectDataSet.Employee.Clear()
            PayrollTableAdapter.Fill(Access_tables_for_projectDataSet.Payroll)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PayrollBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class