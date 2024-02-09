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
End Class
