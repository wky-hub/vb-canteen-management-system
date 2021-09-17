Imports System.Data.OleDb
Public Class FrmAddAdmin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT Email, ContactNumber, IcNo FROM [User] ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text
        Dim icNum As String = msktxtIC.Text
        Dim contactNum As String = msktxtContact.Text
        Dim gender As String = ""
        If radMale.Checked Then
            gender &= "Male"
        Else
            gender &= "Female"
        End If
        Dim email As String = txtEmail.Text
        Dim address As String = txtAddress.Text
        Dim duplicate As Boolean = False
        While dr.Read()
            If (email.Equals(dr(0).ToString) And dr(0).ToString IsNot "") Or (contactNum.Equals(dr(1).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(1).ToString, "^(\s*)(-\s*)$") = False) Or
                (icNum.Equals(dr(2).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(2).ToString, "^(\s*)(-\s*)(-\s*)$") = False) Then
                duplicate = True
            End If
        End While
        If (password.Length >= 8 And System.Text.RegularExpressions.Regex.IsMatch(password, "^[A-Za-z0-9]+$") And (System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$")) And (System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9]+[\.]?[A-Za-z0-9]+.my$") Or
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+.com$")) And duplicate = False) Then
            cmd = New OleDbCommand("INSERT INTO [User] Values(?,?,?,?,?,?,?,?,'-','-')", con)
            cmd.Parameters.AddWithValue("@p1", lblUserID.Text)
            cmd.Parameters.AddWithValue("@p2", Hash.ComputeHash(txtPassword.Text, Nothing))
            cmd.Parameters.AddWithValue("@p3", txtUserName.Text)
            cmd.Parameters.AddWithValue("@p4", msktxtIC.Text)
            cmd.Parameters.AddWithValue("@p5", gender)
            cmd.Parameters.AddWithValue("@p6", msktxtContact.Text)
            cmd.Parameters.AddWithValue("@p7", txtEmail.Text)
            cmd.Parameters.AddWithValue("@p8", txtAddress.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Added successfully!")
            lblUserID.Text = ""
            txtAddress.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
            txtUserName.Clear()
            radFemale.Checked = False
            radMale.Checked = False
            msktxtContact.Clear()
            msktxtIC.Clear()
            Me.Hide()
            FrmAdminMenu.Show()
        ElseIf password.Length < 8 Or System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, "^[A-Za-z0-9]+$") = False Then
            MessageBox.Show("Password must contains at least 8 of alphanumeric characters")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$") = False Then
            MessageBox.Show("IC number must contains be 12 numeric characters")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$") = False Then
            MessageBox.Show("Contact Number must contains 10 or 11 numeric characters")
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9]+[\.]?[A-Za-z0-9]+.my$") = False And
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+\.com$") = False Then
            MessageBox.Show("Invalid Email Address")
        ElseIf duplicate = True Then
            MessageBox.Show("IC number / Email Address / Contact Number was duplicated")
        End If
    End Sub

    Private Sub FrmAddAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Select()
        Dim i As Integer = 1
        Dim empty As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT UserID FROM [User] WHERE [UserID] LIKE 'A%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        While dr.Read() And empty = False
            If dr(0).ToString().Equals("A00" + i.ToString()) Then
                empty = False
            Else
                lblUserID.Text = "A00" + i.ToString()
                empty = True
            End If
            If empty = False Then
                i = i + 1
            End If
            Console.ReadLine()
        End While
        lblUserID.Text = "A00" + i.ToString()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmAdminMenu.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class