Public Class Form7
    Private Sub AttendanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Access_tables_for_projectDataSet)

    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Access_tables_for_projectDataSet.Attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.Access_tables_for_projectDataSet.Attendance)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub AttendanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AttendanceDataGridView.CellContentClick
        AttendanceDataGridView.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AttendanceBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            AttendanceBindingSource.EndEdit()
            AttendanceTableAdapter.Update(Access_tables_for_projectDataSet.Attendance)
            MessageBox.Show("Record saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                AttendanceBindingSource.RemoveCurrent()
                AttendanceTableAdapter.Update(Access_tables_for_projectDataSet.Attendance)
                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            AttendanceBindingSource.Filter = Nothing
            Access_tables_for_projectDataSet.Attendance.Clear()
            AttendanceTableAdapter.Fill(Access_tables_for_projectDataSet.Attendance)
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AttendanceBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AttendanceBindingSource.MoveNext()
    End Sub
End Class