Public Class productControl
    Public Property ProductID As String
    Public Property Price As Decimal
    Public Property count As Integer
    Public Property picture As Image

    Private Sub productControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = picture
        IDLabel.Text = ProductID
        PriceLabel.Text = Price.ToString("C2")
    End Sub
End Class
