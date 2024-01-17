Imports System.IO

Public Class Form1
    Dim records(50) As String
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(Field1.Text)
        outFile.Write("|")
        outFile.Write(Field2.Text)
        outFile.Write("|")
        outFile.Write(Field3.Text)
        outFile.Write("|")
        outFile.Write(Field4.Text)
        outFile.Write("|")
        outFile.Write(Field5.Text)
        outFile.Write("|")
        outFile.Write(PictureBox1.ImageLocation)
        outFile.WriteLine()
        outFile.Close()
    End Sub
    Private Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            records(0) = inFile.ReadLine
            'records(1) = inFile.ReadLine
            inFile.Close()
            showrecord(0)
        End If
    End Sub
    Sub showrecord(index As Integer)
        Dim Fields() As String
        Fields = records(index).split("|")
    End Sub
End Class
