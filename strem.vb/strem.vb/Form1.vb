Public Class Form1
    Public R As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Timer1.Start()

    End Sub


    Public i As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i = i + 1

        Dim Student = "Height" & i

        Dim ValueOfHigh As Integer = Me.R.Next(155, 200)

        Me.RichTextBox1.AppendText(Student.PadRight(8) & Environment.NewLine & ValueOfHigh & Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Timer1.Stop()

    End Sub
End Class
