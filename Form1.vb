Public Class Form1
    Dim generate As New MessagingToolkit.Barcode.BarcodeEncoder
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generate.IncludeLabel = True
        generate.CustomLabel = TextBox1.Text
        Try
            PictureBox1.Image = New Bitmap(generate.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code39, TextBox1.Text
                                                          ))



        Catch ex As Exception
            PictureBox1.Image = New Bitmap(generate.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, TextBox1.Text
                                                          ))
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
