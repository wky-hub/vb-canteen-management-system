Imports System.Data.OleDb

Public Class FrmVendorLogin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorMenu.Close()
            FrmEditDeleteVendor1.Close()
            Order_management.Close()
            Form1.Close()
            MainMenu.Show()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT UserID,Password FROM [User] WHERE [UserID] LIKE 'A%' OR [UserID] LIKE 'V%'", con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If txtVendorId.Text = dr(0) And txtVendorId.Text.StartsWith("V") Then
                If Hash.VerifyHash(txtPassword.Text, dr(1).ToString()) Then
                    Me.Hide()
                    FrmVendorMenu.Show()
                    Data_maintenance.UserIDTextBox.Text = txtVendorId.Text
                    Data_maintenance.Label2.Text = txtVendorId.Text
                    Order_management.Label2.Text = txtVendorId.Text
                    login = True
                End If
            End If
            Console.ReadLine()
        End While
        If login = False Then
            MessageBox.Show("Wrong username or password")
            If txtVendorId.Text.StartsWith("A") Then
                If (MessageBox.Show("Trying to login admin side?", "Wrong Side?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Hide()
                    FrmAdminLogin.Show()
                    txtVendorId.Clear()
                    txtPassword.Clear()
                End If
            End If
        End If
        con.Close()
        FrmAdminLogin.Close()
        FrmEmail1.Close()
        FrmEmail2.Close()
        FrmResetPassword.Close()
        FrmSecurityPattern.Close()
    End Sub

    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        Hide()
        FrmSecurityPattern.Show()
        txtVendorId.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class