Imports System.Data.OleDb
Public Class FrmAdminMenu
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnAddVendor_Click(sender As Object, e As EventArgs) Handles btnAddVendor.Click
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT COUNT(*) FROM [User] WHERE UserID LIKE 'V%'", con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If dr(0) = 5 Then
                MessageBox.Show("Vendor Is Full Please delete one to add new")
            Else
                Hide()
                FrmAddVendor.Show()
            End If
        End While
    End Sub

    Private Sub btnEditDelete_Click(sender As Object, e As EventArgs) Handles btnEditDelete.Click
        Hide()
        FrmEditDeleteVendor.Show()
    End Sub

    Private Sub btnAnnouncement_Click(sender As Object, e As EventArgs) Handles btnAnnouncement.Click
        Hide()
        FrmAnnouncement.Show()
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Hide()
        FrmAddAdmin.Show()
    End Sub

    Private Sub btnEditAdmin_Click(sender As Object, e As EventArgs) Handles btnEditAdmin.Click
        Hide()
        FrmEditDeleteAdmin.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MainMenu.Close()
            Hide()
            FrmAdminLogin.txtAdminId.Clear()
            FrmAdminLogin.txtPassword.Clear()
            MainMenu.Show()
        End If
    End Sub

    Private Sub FrmAdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmProductSellings.Show()
    End Sub
End Class