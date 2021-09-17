Imports System.Data.OleDb
Public Class FrmAddVendor
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
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
        Dim AssignmentPattern As String = ""
        Dim count As Integer = 0
        If A1.Checked Then
            AssignmentPattern &= "A1"
            count = count + 1
        End If
        If A2.Checked Then
            AssignmentPattern &= "A2"
            count = count + 1
        End If
        If A3.Checked Then
            AssignmentPattern &= "A3"
            count = count + 1
        End If
        If A4.Checked Then
            AssignmentPattern &= "A4"
            count = count + 1
        End If
        If A5.Checked Then
            AssignmentPattern &= "A5"
            count = count + 1
        End If
        If B1.Checked Then
            AssignmentPattern &= "B1"
            count = count + 1
        End If
        If B2.Checked Then
            AssignmentPattern &= "B2"
            count = count + 1
        End If
        If B3.Checked Then
            AssignmentPattern &= "B3"
            count = count + 1
        End If
        If B4.Checked Then
            AssignmentPattern &= "B4"
            count = count + 1
        End If
        If B5.Checked Then
            AssignmentPattern &= "B5"
            count = count + 1
        End If
        If C1.Checked Then
            AssignmentPattern &= "C1"
            count = count + 1
        End If
        If C2.Checked Then
            AssignmentPattern &= "C2"
            count = count + 1
        End If
        If C3.Checked Then
            AssignmentPattern &= "C3"
            count = count + 1
        End If
        If C4.Checked Then
            AssignmentPattern &= "C4"
            count = count + 1
        End If
        If C5.Checked Then
            AssignmentPattern &= "C5"
            count = count + 1
        End If
        If D1.Checked Then
            AssignmentPattern &= "D1"
            count = count + 1
        End If
        If D2.Checked Then
            AssignmentPattern &= "D2"
            count = count + 1
        End If
        If D3.Checked Then
            AssignmentPattern &= "D3"
            count = count + 1
        End If
        If D4.Checked Then
            AssignmentPattern &= "D4"
            count = count + 1
        End If
        If D5.Checked Then
            AssignmentPattern &= "D5"
            count = count + 1
        End If
        If E1.Checked Then
            AssignmentPattern &= "E1"
            count = count + 1
        End If
        If E2.Checked Then
            AssignmentPattern &= "E2"
            count = count + 1
        End If
        If E3.Checked Then
            AssignmentPattern &= "E3"
            count = count + 1
        End If
        If E4.Checked Then
            AssignmentPattern &= "E4"
            count = count + 1
        End If
        If E5.Checked Then
            AssignmentPattern &= "E5"
            count = count + 1
        End If
        Dim duplicate As Boolean = False
        While dr.Read()
            If (email.Equals(dr(0).ToString) And dr(0).ToString IsNot "") Or (contactNum.Equals(dr(1).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(1).ToString, "^(\s*)(-\s*)$") = False) Or
                (icNum.Equals(dr(2).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(2).ToString, "^(\s*)(-\s*)(-\s*)$") = False) Then
                duplicate = True
            End If
        End While
        dr.Close()
        Dim i As Integer = 1
        Dim empty As Boolean = False
        If (password.Length >= 8 And System.Text.RegularExpressions.Regex.IsMatch(password, "^[A-Za-z0-9]+$") And (System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9]+[\.]?[A-Za-z0-9]+.my$") Or
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+\.com$")) And
                duplicate = False And cmbbxCategory.SelectedIndex >= 0 And count = 5) Then
            cmd = New OleDbCommand("INSERT INTO [User] Values(?,?,?,?,?,?,?,?,?,?)", con)
            cmd.Parameters.AddWithValue("@p1", lblUserID.Text)
            cmd.Parameters.AddWithValue("@p2", Hash.ComputeHash(txtPassword.Text, Nothing))
            cmd.Parameters.AddWithValue("@p3", txtUserName.Text)
            cmd.Parameters.AddWithValue("@p4", msktxtIC.Text)
            cmd.Parameters.AddWithValue("@p5", gender)
            cmd.Parameters.AddWithValue("@p6", msktxtContact.Text)
            cmd.Parameters.AddWithValue("@p7", txtEmail.Text)
            cmd.Parameters.AddWithValue("@p8", txtAddress.Text)
            cmd.Parameters.AddWithValue("@p9", cmbbxCategory.SelectedItem.ToString)
            cmd.Parameters.AddWithValue("@p10", AssignmentPattern)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Added successfully!")
            Hide()
            FrmAdminMenu.Show()
            lblUserID.Text = ""
            txtAddress.Clear()
            cmbbxCategory.Text = ""
            txtEmail.Clear()
            txtPassword.Clear()
            txtUserName.Clear()
            radFemale.Checked = False
            radMale.Checked = False
            msktxtContact.Clear()
            msktxtIC.Clear()
            A1.Checked = False
            A2.Checked = False
            A3.Checked = False
            A4.Checked = False
            A5.Checked = False
            B1.Checked = False
            B2.Checked = False
            B3.Checked = False
            B4.Checked = False
            B5.Checked = False
            C1.Checked = False
            C2.Checked = False
            C3.Checked = False
            C4.Checked = False
            C5.Checked = False
            D1.Checked = False
            D2.Checked = False
            D3.Checked = False
            D4.Checked = False
            D5.Checked = False
            E1.Checked = False
            E2.Checked = False
            E3.Checked = False
            E4.Checked = False
            E5.Checked = False
            cmd = New OleDbCommand("SELECT UserID, CategoryOfProduct FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
            dr = cmd.ExecuteReader()
            While dr.Read() And empty = False
                If dr(0).ToString().Equals("V00" + i.ToString()) Then
                    empty = False
                Else
                    lblUserID.Text = "V00" + i.ToString()
                    empty = True
                End If
                If empty = False Then
                    i = i + 1
                End If
                Console.ReadLine()
            End While
            dr.Close()
            dr = cmd.ExecuteReader()
            While dr.Read()
                If dr(1).ToString.Equals("Asian") Then
                    cmbbxCategory.Items.Remove("Asian")
                ElseIf dr(1).ToString.Equals("Malay") Then
                    cmbbxCategory.Items.Remove("Malay")
                ElseIf dr(1).ToString.Equals("Western") Then
                    cmbbxCategory.Items.Remove("Western")
                ElseIf dr(1).ToString.Equals("Fruits") Then
                    cmbbxCategory.Items.Remove("Fruits")
                ElseIf dr(1).ToString.Equals("Beverage") Then
                    cmbbxCategory.Items.Remove("Beverage")
                End If
                Console.ReadLine()
            End While
            If i <= 5 Then
                lblUserID.Text = "V00" + i.ToString()
            End If
        ElseIf password.Length < 8 Or System.Text.RegularExpressions.Regex.IsMatch(txtPassword.Text, "^[A-Za-z0-9]+$") = False Then
            MessageBox.Show("Password must contains at least 8 of alphanumeric characters")
            txtPassword.Select()
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$") = False Then
            MessageBox.Show("IC number must contains be 12 numeric characters")
            msktxtIC.Select()
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$") = False Then
            MessageBox.Show("Contact Number must contains 10 or 11 numeric characters")
            msktxtContact.Select()
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9]+[\.]?[A-Za-z0-9]+.my$") = False And
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+\.com$") = False Then
            MessageBox.Show("Invalid Email Address")
            txtEmail.Select()
        ElseIf duplicate = True Then
            MessageBox.Show("IC number / Email Address / Contact Number was duplicated")
        ElseIf cmbbxCategory.SelectedIndex < 0 Then
            MessageBox.Show("Please select category of your product")
            cmbbxCategory.Select()
        ElseIf count <> 5 Then
            MessageBox.Show("Please select 5 boxes for Assignment purpose")
        End If
    End Sub

    Private Sub FrmAddVendor1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radMale.Select()
        Dim i As Integer = 1
        Dim empty As Boolean = False
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT UserID, CategoryOfProduct FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        While dr.Read() And empty = False
            If dr(0).ToString().Equals("V00" + i.ToString()) Then
                empty = False
            Else
                lblUserID.Text = "V00" + i.ToString()
                empty = True
            End If
            If empty = False Then
                i = i + 1
            End If
            Console.ReadLine()
        End While
        dr.Close()
        dr = cmd.ExecuteReader()
        While dr.Read()
            If dr(1).ToString.Equals("Asian") Then
                cmbbxCategory.Items.Remove("Asian")
            ElseIf dr(1).ToString.Equals("Malay") Then
                cmbbxCategory.Items.Remove("Malay")
            ElseIf dr(1).ToString.Equals("Western") Then
                cmbbxCategory.Items.Remove("Western")
            ElseIf dr(1).ToString.Equals("Fruits") Then
                cmbbxCategory.Items.Remove("Fruits")
            ElseIf dr(1).ToString.Equals("Beverage") Then
                cmbbxCategory.Items.Remove("Beverage")
            End If
            Console.ReadLine()
        End While
        If i <= 5 Then
            lblUserID.Text = "V00" + i.ToString()
        Else
            MessageBox.Show("Sorry, Vendor Slot is full, Please delete first to add one")
            Close()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorMenu.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class