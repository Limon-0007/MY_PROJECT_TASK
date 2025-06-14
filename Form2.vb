Public Class Form2
    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        Application.Exit()
    End Sub

    Dim targetTotalEmployees As Integer = 0
    Dim currentCount As Integer = 0

    Private targets As New Dictionary(Of Label, Integer)
    Private currents As New Dictionary(Of Label, Integer)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize your labels with their target numbers here
        targets.Clear()
        currents.Clear()

        targets.Add(Label4, 21)
        targets.Add(Label8, 570)
        targets.Add(Label6, 1750)
        targets.Add(Label10, 16)

        ' Initialize current counts to zero and labels text
        For Each lbl As Label In targets.Keys
            currents(lbl) = 0
            lbl.Text = "0"
        Next

        ' Start timer for animation
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim allDone As Boolean = True

        For Each lbl As Label In targets.Keys
            Dim targetValue As Integer = targets(lbl)
            Dim currentValue As Integer = currents(lbl)

            If currentValue < targetValue Then
                allDone = False
                ' Increase count faster by step (you can adjust step size)
                Dim stepSize As Integer = Math.Max(1, (targetValue \ 30)) ' bigger target = bigger step

                currents(lbl) = Math.Min(targetValue, currentValue + stepSize)
                lbl.Text = currents(lbl).ToString()
            End If
        Next

        If allDone Then
            Timer1.Stop()
        End If
    End Sub
End Class