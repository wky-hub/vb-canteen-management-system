Public Class FrmVendorMenu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorLogin.Close()
            FrmVendorLogin.txtVendorId.Clear()
            FrmVendorLogin.txtPassword.Clear()
            MainMenu.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub btnEditDelete_Click(sender As Object, e As EventArgs) Handles btnEditDelete.Click

        Me.Hide()
        FrmEditDeleteVendor1.Show()
    End Sub

    Private Sub btnAddEditProduct_Click(sender As Object, e As EventArgs) Handles btnAddEditProduct.Click
        Me.Hide()
        Data_maintenance.Show()

    End Sub

    Private Sub btnOrderManagement_Click(sender As Object, e As EventArgs) Handles btnOrderManagement.Click

        Me.Close()
        Order_management.Show()
    End Sub
End Class