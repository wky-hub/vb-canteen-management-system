Imports System.Data.OleDb

Public Class FrmAdminLogin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmAddAdmin.Hide()
            FrmAddVendor.Hide()
            FrmAdminMenu.Hide()
            FrmEditDeleteAdmin.Hide()
            FrmEditDeleteVendor.Hide()
            FrmAnnouncement.Hide()
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
            If txtAdminId.Text = dr(0) And txtAdminId.Text.StartsWith("A") Then
                If Hash.VerifyHash(txtPassword.Text, dr(1).ToString()) Then
                    FrmAdminMenu.Show()
                    Me.Hide()
                    login = True
                End If
            End If
            Console.ReadLine()
        End While
        If login = False Then
            MessageBox.Show("Wrong username or password")
            If txtAdminId.Text.StartsWith("V") Then
                If (MessageBox.Show("Trying to login vendor side?", "Wrong Side?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Hide()
                    FrmVendorLogin.Show()
                End If
            End If
        End If
        con.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        Hide()
        txtAdminId.Clear()
        txtPassword.Clear()
        FrmEmail1.Show()
    End Sub
End Class