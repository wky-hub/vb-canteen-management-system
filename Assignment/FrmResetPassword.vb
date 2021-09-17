Imports System.Data.OleDb
Public Class FrmResetPassword
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("UPDATE [User] SET [Password] = ? WHERE UserID = ?", con)
        cmd.Parameters.AddWithValue("@p1", Hash.ComputeHash(txtPassword1.Text, Nothing))
        If FrmEmail1.txtUserId.Text = "" Then
            cmd.Parameters.AddWithValue("@p2", FrmSecurityPattern.txtVendorId.Text)
        Else
            cmd.Parameters.AddWithValue("@p2", FrmEmail1.txtUserId.Text)
        End If

        If txtPassword1.Text = txtPassword2.Text And txtPassword1.Text.Length >= 8 And System.Text.RegularExpressions.Regex.IsMatch(txtPassword1.Text, "^[A-Za-z0-9]+$") Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Reset Password Successfully!")
            If FrmEmail1.txtUserId.Text.StartsWith("A") Then
                Hide()
                FrmAdminLogin.Show()
            Else
                Hide()
                FrmVendorLogin.Show()
            End If
        ElseIf txtPassword1.Text.Length < 8 Or System.Text.RegularExpressions.Regex.IsMatch(txtPassword1.Text, "^[A-Za-z0-9]+$") = False Then
            MessageBox.Show("Password must contains at least 8 of alphanumeric characters")
        ElseIf txtPassword1.Text.Equals(txtPassword2.Text) = False Then
            MessageBox.Show("Password doesn't match")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmEmail1.Show()
            If FrmEmail1.txtUserId.Text.Equals("") Then
                Me.Hide()
                FrmSecurityPattern.Show()
            Else
                Hide()
                FrmVendorLogin.Show()
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword1.UseSystemPasswordChar = False
        Else
            txtPassword1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword2.UseSystemPasswordChar = False
        Else
            txtPassword2.UseSystemPasswordChar = True
        End If
    End Sub
End Class