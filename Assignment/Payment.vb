Imports QRCoder

Public Class Payment
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        Me.Hide()
        Calculator.Show()
        Calculator.lblAmountDue.Text = Cart.lblTotal.Text
    End Sub

    Private Sub btnCards_Click(sender As Object, e As EventArgs) Handles btnCards.Click
        Me.Hide()
        Cards.Show()
    End Sub

    Private Sub btnMobilePay_Click(sender As Object, e As EventArgs) Handles btnMobilePay.Click
        Me.Hide()
        ScanQR.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Cart.Show()
    End Sub
End Class