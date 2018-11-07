Imports System.IO

Public Class Form1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.filepath = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        Dim oldname As String = My.Settings.filepath & "\" & My.Settings.filename & "." & My.Settings.fileext1
        Dim newname As String = My.Settings.filepath & "\" & My.Settings.filename & "." & My.Settings.fileext2

        If File.Exists(oldname) Then
            MessageBox.Show("Datei existiert bereits!")
            Exit Sub
        End If

        Dim objStreamWriter As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(oldname)

        For i As Integer = textBox5.Text To 0 Step -10

            'Write a line of text.
            objStreamWriter.WriteLine("This is a stupid text, created by FileSimulator")

            Threading.Thread.Sleep(10)

        Next

        'Close the file.
        objStreamWriter.Close()

        If Not My.Settings.fileext2 = "" Then FileSystem.Rename(oldname, newname)

    End Sub
End Class
