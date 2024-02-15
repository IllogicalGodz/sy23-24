Imports System.Reflection.Emit

Public Class Form1
    Dim WithEvents CS As New CoinSlot

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.InsetQuarter()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.InsetDimes()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.InsetNickels()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.InsetDollar()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_coinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles CS.coinReturnEvent
        If d > 0 Then
            DollarPic.Visible = True
        Else
            DollarPic.Visible = False
        End If
        If q > 0 Then
            QuarterPic.Visible = True
        Else
            QuarterPic.Visible = False
        End If
        If dm > 0 Then
            DimePic.Visible = True
        Else
            DimePic.Visible = False
        End If
        If n > 0 Then
            NickelPic.Visible = True
        Else
            NickelPic.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox.Text
            Case ProductControl1.ProductID
                CS.buy(ProductControl1)
            Case ProductControl2.ProductID
                CS.buy(ProductControl2)
            Case ProductControl3.ProductID
                CS.buy(ProductControl3)
            Case ProductControl4.ProductID
                CS.buy(ProductControl4)
            Case ProductControl5.ProductID
                CS.buy(ProductControl5)
            Case ProductControl6.ProductID
                CS.buy(ProductControl6)
            Case ProductControl7.ProductID
                CS.buy(ProductControl7)
            Case ProductControl8.ProductID
                CS.buy(ProductControl8)
            Case ProductControl9.ProductID
                CS.buy(ProductControl9)
            Case ProductControl10.ProductID
                CS.buy(ProductControl10)
            Case ProductControl11.ProductID
                CS.buy(ProductControl11)
            Case ProductControl12.ProductID
                CS.buy(ProductControl12)
            Case ProductControl13.ProductID
                CS.buy(ProductControl13)
            Case ProductControl14.ProductID
                CS.buy(ProductControl14)
            Case ProductControl15.ProductID
                CS.buy(ProductControl15)
            Case ProductControl16.ProductID
                CS.buy(ProductControl16)
            Case Else
        End Select
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CS_buyevent(p As Image) Handles CS.buyevent
        ProductPictureBox.Image = p
    End Sub
End Class
