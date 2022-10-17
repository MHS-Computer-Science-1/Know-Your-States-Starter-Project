Public Class Form1
    Dim states(49), capitals(49) As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Display all the states and capitals
        Dim i As Integer
        For i = 0 To 49
            ListBox1.Items.Add(states(i) & ", " & capitals(i))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open file and load states and capitals into arrays
        FileOpen(1, "states.txt", OpenMode.Input)

        Dim i As Integer
        For i = 0 To 49
            Input(1, states(i))
            Input(1, capitals(i))
        Next
    End Sub
End Class
