Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Path As String = Me.RichTextBox1.Text.Trim

        Using R As New StreamReader(Path)


            Do
                Dim Line As String = R.ReadLine
                If R.EndOfStream Then Exit Do
                Me.RichTextBox2.AppendText(Line & Environment.NewLine)

            Loop
        End Using

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim o As New OpenFileDialog
        o.ShowDialog()
        If String.IsNullOrWhiteSpace(o.FileName) Then Exit Sub

        Me.RichTextBox1.Text = o.FileName

    End Sub
End Class
