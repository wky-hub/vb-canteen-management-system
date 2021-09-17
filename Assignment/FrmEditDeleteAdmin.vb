Imports System.Data.OleDb
Public Class FrmEditDeleteAdmin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dr1 As OleDbDataAdapter

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtPassword.Text IsNot "" Then
            txtUserID.ReadOnly = True
            txtPassword.ReadOnly = False
            txtAddress.ReadOnly = False
            txtEmail.ReadOnly = False
            txtUserName.ReadOnly = False
            msktxtContact.ReadOnly = False
            msktxtIC.ReadOnly = False
            radMale.Enabled = True
            radFemale.Enabled = True
        Else
            MessageBox.Show("Please Enter Admin ID!")
        End If
    End Sub

    Private Sub FrmEditAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmAdminLogin.txtAdminId.Text.Equals("A001") Then
            txtUserID.Select()
            btnDelete.Visible = True
        Else
            txtUserID.Text = FrmAdminLogin.txtAdminId.Text
            txtUserID.Enabled = False
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT Email, ContactNumber, IcNo,UserID FROM [User] ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        If txtUserID.ReadOnly = True Then
            Dim username As String = txtUserName.Text
            Dim password As String = txtPassword.Text
            Dim icNum As String = msktxtIC.Text
            Dim contactNum As String = msktxtContact.Text
            Dim gender As String = ""
            If radMale.Checked Then
                gender &= "Male"
            ElseIf radFemale.Checked Then
                gender &= "Female"
            End If
            Dim email As String = txtEmail.Text
            Dim address As String = txtAddress.Text
            Dim duplicate As Boolean = False
            While dr.Read()
                If (email.Equals(dr(0).ToString) And dr(0).ToString IsNot "") Or (contactNum.Equals(dr(1).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(1).ToString, "^(\s*)(-\s*)$") = False) Or
                (icNum.Equals(dr(2).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(2).ToString, "^(\s*)(-\s*)(-\s*)$") = False) Then
                    If dr(3).ToString().Equals(txtUserID.Text) = False Then
                        duplicate = True
                    End If
                End If
            End While
            dr.Close()
            If password.Length >= 8 And System.Text.RegularExpressions.Regex.IsMatch(password, "^[A-Za-z0-9]+$") And
                (System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9][\.]?[A-Za-z0-9]+.my$") Or
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+.com$")) And duplicate = False Then
                cmd1 = New OleDbCommand("UPDATE [User] SET [UserName] = ?, [IcNo] = ?,
                                [Gender] = ?, [ContactNumber] = ?, [Email] = ?, [Address] = ?, [Password] = ?
                                WHERE [UserID] = ?", con)
                cmd1.Parameters.AddWithValue("@p1", txtUserName.Text)
                cmd1.Parameters.AddWithValue("@p2", msktxtIC.Text)
                cmd1.Parameters.AddWithValue("@p3", gender)
                cmd1.Parameters.AddWithValue("@p4", msktxtContact.Text)
                cmd1.Parameters.AddWithValue("@p5", txtEmail.Text)
                cmd1.Parameters.AddWithValue("@p6", txtAddress.Text)
                cmd1.Parameters.AddWithValue("@p7", Hash.ComputeHash(password, Nothing))
                cmd1.Parameters.AddWithValue("@p8", txtUserID.Text)
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Edit Successfully!")
                FrmAdminLogin.txtPassword.Text = password
                txtUserID.Clear()
                txtAddress.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                txtUserName.Clear()
                radFemale.Checked = False
                radMale.Checked = False
                msktxtContact.Clear()
                msktxtIC.Clear()
                txtUserID.ReadOnly = False
                txtAddress.ReadOnly = True
                txtEmail.ReadOnly = True
                txtUserName.ReadOnly = True
                msktxtContact.ReadOnly = True
                msktxtIC.ReadOnly = True
                radMale.Enabled = False
                radFemale.Enabled = False
            ElseIf password.Length < 8 Or System.Text.RegularExpressions.Regex.IsMatch(password, "^[A-Za-z0-9]+$") = False Then
                MessageBox.Show("Password must contains at least 8 of alphanumeric characters")
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$") = False Then
                MessageBox.Show("IC number must contains be 12 numeric characters")
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$") = False Then
                MessageBox.Show("Contact Number must contains 10 or 11 numeric characters")
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\+-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.?][A-Za-z0-9]+[\.?][A-Za-z0-9]+.my$") = False And
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+.com$") = False And email.Equals("") = False Then
                MessageBox.Show("Invalid Email Address")
            ElseIf duplicate = True Then
                MessageBox.Show("IC number / Email Address / Contact Number was duplicated")
            End If
        Else
            MessageBox.Show("Please Press Edit Button to Edit")
            Me.Hide()
            FrmAdminMenu.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim userExist As Boolean = False
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT [UserID] FROM [User] WHERE [UserID] LIKE 'A%' ORDER BY [UserID]", con)
        cmd1 = New OleDbCommand("DELETE FROM [User] WHERE [UserID] = ?", con)
        cmd1.Parameters.AddWithValue("@p1", txtUserID.Text)
        dr = cmd.ExecuteReader()
        Dim deleteSelf As Boolean = False
        While dr.Read()
            If dr(0).ToString.Equals(txtUserID.Text.ToString()) And dr(0).ToString.Equals("A001") = False Then
                userExist = True
            ElseIf dr(0).ToString.Equals("A001") = False Then
                deleteSelf = True
            End If
        End While
        If userExist = True Then
            If MessageBox.Show("Are You Sure you want to delete this Vendor?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                cmd1.ExecuteNonQuery()
                txtUserID.Clear()
                txtAddress.Clear()
                txtEmail.Clear()
                txtPassword.Clear()
                txtUserName.Clear()
                radFemale.Checked = False
                radMale.Checked = False
                msktxtContact.Clear()
                msktxtIC.Clear()
                MessageBox.Show("Delete Successfully!")
            End If
        ElseIf deleteSelf = True Then
            MessageBox.Show("You Cannot Delete Your account")
        Else
            MessageBox.Show("Admin not exist!")
        End If
        Me.Hide()
        FrmAdminMenu.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmAdminMenu.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Dim found As Boolean = False
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [User] WHERE [UserID] LIKE 'A%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        Try
            While dr.Read()
                If dr(0) = txtUserID.Text Then
                    txtPassword.Text = FrmAdminLogin.txtPassword.Text
                    txtUserName.Text = dr(2).ToString()
                    msktxtIC.Text = dr(3).ToString()
                    If dr(4).ToString().Equals("Male") Then
                        radMale.Checked = True
                    ElseIf dr(4).ToString().Equals("Female") Then
                        radFemale.Checked = True
                    End If
                    msktxtContact.Text = dr(5).ToString()
                    txtEmail.Text = dr(6).ToString()
                    txtAddress.Text = dr(7).ToString()
                    found = True
                ElseIf found = False Then
                    txtAddress.Clear()
                    txtEmail.Clear()
                    txtPassword.Clear()
                    txtUserName.Clear()
                    radFemale.Checked = False
                    radMale.Checked = False
                    msktxtContact.Clear()
                    msktxtIC.Clear()
                End If
                Console.ReadLine()
            End While
        Catch ex As Exception
        End Try
    End Sub
End Class