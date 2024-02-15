Public Class productControl
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductCount As Integer
    Public Property ProductPicture As Image

    Private Sub productControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ProductPicture
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("C2")
    End Sub
    Public Sub buy()
        If ProductCount > 0 Then
            ProductCount = ProductCount - 1
        End If
        If ProductCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
