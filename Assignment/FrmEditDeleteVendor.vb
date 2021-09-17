Imports System.Data.OleDb
Public Class FrmEditDeleteVendor
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim cmd1 As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim dr1 As OleDbDataAdapter

    Private Sub txtUserID_TextChanged_1(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        Dim found As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        Try
            While dr.Read()
                If dr(0) = txtUserID.Text Then
                    txtPassword.Text = dr(1).ToString()
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
                    cmbbxCategory.Items.Remove(0)
                    cmbbxCategory.Items.Add(dr(8).ToString())
                    cmbbxCategory.SelectedItem = cmbbxCategory.Items(0)
                    If dr(9).ToString().Contains("A1") Then
                        A1.Checked = True
                    End If
                    If dr(9).ToString().Contains("A2") Then
                        A2.Checked = True
                    End If
                    If dr(9).ToString().Contains("A3") Then
                        A3.Checked = True
                    End If
                    If dr(9).ToString().Contains("A4") Then
                        A4.Checked = True
                    End If
                    If dr(9).ToString().Contains("A5") Then
                        A5.Checked = True
                    End If
                    If dr(9).ToString().Contains("B1") Then
                        B1.Checked = True
                    End If
                    If dr(9).ToString().Contains("B2") Then
                        B2.Checked = True
                    End If
                    If dr(9).ToString().Contains("B3") Then
                        B3.Checked = True
                    End If
                    If dr(9).ToString().Contains("B4") Then
                        B4.Checked = True
                    End If
                    If dr(9).ToString().Contains("B5") Then
                        B5.Checked = True
                    End If
                    If dr(9).ToString().Contains("C1") Then
                        C1.Checked = True
                    End If
                    If dr(9).ToString().Contains("C2") Then
                        C2.Checked = True
                    End If
                    If dr(9).ToString().Contains("C3") Then
                        C3.Checked = True
                    End If
                    If dr(9).ToString().Contains("C4") Then
                        C4.Checked = True
                    End If
                    If dr(9).ToString().Contains("C5") Then
                        C5.Checked = True
                    End If
                    If dr(9).ToString().Contains("D1") Then
                        D1.Checked = True
                    End If
                    If dr(9).ToString().Contains("D2") Then
                        D2.Checked = True
                    End If
                    If dr(9).ToString().Contains("D3") Then
                        D3.Checked = True
                    End If
                    If dr(9).ToString().Contains("D4") Then
                        D4.Checked = True
                    End If
                    If dr(9).ToString().Contains("D5") Then
                        D5.Checked = True
                    End If
                    If dr(9).ToString().Contains("E1") Then
                        E1.Checked = True
                    End If
                    If dr(9).ToString().Contains("E2") Then
                        E2.Checked = True
                    End If
                    If dr(9).ToString().Contains("E3") Then
                        E3.Checked = True
                    End If
                    If dr(9).ToString().Contains("E4") Then
                        E4.Checked = True
                    End If
                    If dr(9).ToString().Contains("E5") Then
                        E5.Checked = True
                    End If
                    found = True
                ElseIf found = False Then
                    txtAddress.Clear()
                    cmbbxCategory.Items.Clear()
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
                End If
                Console.ReadLine()
            End While
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT CategoryOfProduct FROM [User] ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        Dim asian As Boolean = False
        Dim malay As Boolean = False
        Dim western As Boolean = False
        Dim Fruits As Boolean = False
        Dim beverage As Boolean = False
        While dr.Read()
            If dr(0).ToString().Equals("Asian") Then
                asian = True
            ElseIf dr(0).ToString().Equals("Malay") Then
                malay = True
            ElseIf dr(0).ToString().Equals("Western") Then
                western = True
            ElseIf dr(0).ToString().Equals("Fruits") Then
                Fruits = True
            ElseIf dr(0).ToString().Equals("Beverage") Then
                beverage = True
            End If
            Console.ReadLine()
        End While
        If cmbbxCategory.SelectedText IsNot "Asian" And asian = False Then
            cmbbxCategory.Items.Add("Asian")
        End If
        If cmbbxCategory.SelectedText IsNot "Malay" And malay = False Then
            cmbbxCategory.Items.Add("Malay")
        End If
        If cmbbxCategory.SelectedText IsNot "Western" And western = False Then
            cmbbxCategory.Items.Add("Western")
        End If
        If cmbbxCategory.SelectedText IsNot "Fruits" And Fruits = False Then
            cmbbxCategory.Items.Add("Fruits")
        End If
        If cmbbxCategory.SelectedText IsNot "Beverage" And beverage = False Then
            cmbbxCategory.Items.Add("Beverage")
        End If

        If txtPassword.Text IsNot "" Then
            txtUserID.ReadOnly = True
            txtAddress.ReadOnly = False
            cmbbxCategory.Enabled = True
            txtEmail.ReadOnly = False
            txtUserName.ReadOnly = False
            msktxtContact.ReadOnly = False
            msktxtIC.ReadOnly = False
            radMale.Enabled = True
            radFemale.Enabled = True
            A1.Enabled = True
            A2.Enabled = True
            A3.Enabled = True
            A4.Enabled = True
            A5.Enabled = True
            B1.Enabled = True
            B2.Enabled = True
            B3.Enabled = True
            B4.Enabled = True
            B5.Enabled = True
            C1.Enabled = True
            C2.Enabled = True
            C3.Enabled = True
            C4.Enabled = True
            C5.Enabled = True
            D1.Enabled = True
            D2.Enabled = True
            D3.Enabled = True
            D4.Enabled = True
            D5.Enabled = True
            E1.Enabled = True
            E2.Enabled = True
            E3.Enabled = True
            E4.Enabled = True
            E5.Enabled = True
        Else
            MessageBox.Show("Please Enter Vendor ID!")
        End If
    End Sub

    Private Sub FrmEditVendor1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Select()
        cmbbxCategory.SelectedItem = cmbbxCategory.Items(0)
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT Email, ContactNumber, IcNo,UserID FROM [User] ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        If txtUserID.ReadOnly = True Then
            Dim username As String = txtUserName.Text
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
            Dim securityPattern As String = ""
            Dim count As Integer = 0
            If A1.Checked Then
                securityPattern &= "A1"
                count = count + 1
            End If
            If A2.Checked Then
                securityPattern &= "A2"
                count = count + 1
            End If
            If A3.Checked Then
                securityPattern &= "A3"
                count = count + 1
            End If
            If A4.Checked Then
                securityPattern &= "A4"
                count = count + 1
            End If
            If A5.Checked Then
                securityPattern &= "A5"
                count = count + 1
            End If
            If B1.Checked Then
                securityPattern &= "B1"
                count = count + 1
            End If
            If B2.Checked Then
                securityPattern &= "B2"
                count = count + 1
            End If
            If B3.Checked Then
                securityPattern &= "B3"
                count = count + 1
            End If
            If B4.Checked Then
                securityPattern &= "B4"
                count = count + 1
            End If
            If B5.Checked Then
                securityPattern &= "B5"
                count = count + 1
            End If
            If C1.Checked Then
                securityPattern &= "C1"
                count = count + 1
            End If
            If C2.Checked Then
                securityPattern &= "C2"
                count = count + 1
            End If
            If C3.Checked Then
                securityPattern &= "C3"
                count = count + 1
            End If
            If C4.Checked Then
                securityPattern &= "C4"
                count = count + 1
            End If
            If C5.Checked Then
                securityPattern &= "C5"
                count = count + 1
            End If
            If D1.Checked Then
                securityPattern &= "D1"
                count = count + 1
            End If
            If D2.Checked Then
                securityPattern &= "D2"
                count = count + 1
            End If
            If D3.Checked Then
                securityPattern &= "D3"
                count = count + 1
            End If
            If D4.Checked Then
                securityPattern &= "D4"
                count = count + 1
            End If
            If D5.Checked Then
                securityPattern &= "D5"
                count = count + 1
            End If
            If E1.Checked Then
                securityPattern &= "E1"
                count = count + 1
            End If
            If E2.Checked Then
                securityPattern &= "E2"
                count = count + 1
            End If
            If E3.Checked Then
                securityPattern &= "E3"
                count = count + 1
            End If
            If E4.Checked Then
                securityPattern &= "E4"
                count = count + 1
            End If
            If E5.Checked Then
                securityPattern &= "E5"
                count = count + 1
            End If
            Dim duplicate As Boolean = False
            While dr.Read()
                If (email.Equals(dr(0).ToString) And dr(0).ToString IsNot "") Or (contactNum.Equals(dr(1).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(1).ToString, "^(\s*)(-\s*)$") = False) Or
                (icNum.Equals(dr(2).ToString) And System.Text.RegularExpressions.Regex.IsMatch(dr(2).ToString, "^(\s*)(-\s*)(-\s*)$") = False) Then
                    If dr(3).ToString().Equals(txtUserID.Text) = False Then
                        duplicate = True
                    End If
                End If
            End While
            If ((System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$")) And
                (System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") Or System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$")) And (System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9][\.]?[A-Za-z0-9]+.my$") Or
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+.com$") Or email.Equals("")) And
                duplicate = False And count = 5) Then
                cmd = New OleDbCommand("UPDATE [User] SET [UserName] = ?, [IcNo] = ?,
                                [Gender] = ?, [ContactNumber] = ?, [Email] = ?, [Address] = ?, 
                                [CategoryOfProduct] = ?, [SecurityPattern] = ?
                                WHERE [UserID] = ?", con)
                cmd.Parameters.AddWithValue("@p1", txtUserName.Text)
                cmd.Parameters.AddWithValue("@p2", msktxtIC.Text)
                cmd.Parameters.AddWithValue("@p3", gender)
                cmd.Parameters.AddWithValue("@p4", msktxtContact.Text)
                cmd.Parameters.AddWithValue("@p5", txtEmail.Text)
                cmd.Parameters.AddWithValue("@p6", txtAddress.Text)
                cmd.Parameters.AddWithValue("@p7", cmbbxCategory.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@p8", securityPattern)
                cmd.Parameters.AddWithValue("@p9", txtUserID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Edit Successfully!")
                txtUserID.Clear()
                txtAddress.Clear()
                cmbbxCategory.Items.Add("--------------------------")
                cmbbxCategory.SelectedItem = cmbbxCategory.Items(0)
                cmbbxCategory.Items.Clear()
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
                txtUserID.ReadOnly = False
                txtAddress.ReadOnly = True
                cmbbxCategory.Enabled = False
                txtEmail.ReadOnly = True
                txtUserName.ReadOnly = True
                msktxtContact.ReadOnly = True
                msktxtIC.ReadOnly = True
                radMale.Enabled = False
                radFemale.Enabled = False
                A1.Enabled = False
                A2.Enabled = False
                A3.Enabled = False
                A4.Enabled = False
                A5.Enabled = False
                B1.Enabled = False
                B2.Enabled = False
                B3.Enabled = False
                B4.Enabled = False
                B5.Enabled = False
                C1.Enabled = False
                C2.Enabled = False
                C3.Enabled = False
                C4.Enabled = False
                C5.Enabled = False
                D1.Enabled = False
                D2.Enabled = False
                D3.Enabled = False
                D4.Enabled = False
                D5.Enabled = False
                E1.Enabled = False
                E2.Enabled = False
                E3.Enabled = False
                E4.Enabled = False
                E5.Enabled = False
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\s*)(-\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(icNum, "^(\d{6})(-\d{2})(-\d{4})$") = False Then
                MessageBox.Show("IC number must contains be 12 numeric characters")
                msktxtIC.Select()
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\s*)(-\s*)$") = False And System.Text.RegularExpressions.Regex.IsMatch(contactNum, "^(\d{3})(-\d{7})(\d?)$") = False Then
                MessageBox.Show("Contact Number must contains 10 or 11 numeric characters")
                msktxtContact.Select()
            ElseIf System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+[\.]?[A-Za-z0-9]+[\.]?[A-Za-z0-9]+.my$") = False And
                System.Text.RegularExpressions.Regex.IsMatch(email, "^[A-Za-z0-9]+[\-]?[A-Za-z0-9]+@[A-Za-z0-9]+.com$") = False And email.Equals("") = False Then
                MessageBox.Show("Invalid Email Address")
                txtEmail.Select()
            ElseIf duplicate = True Then
                MessageBox.Show("IC number / Email Address / Contact Number was duplicated")
            ElseIf count <> 5 Then
                MessageBox.Show("Please select 5 boxes for Assignment purpose")
            End If
        Else
            MessageBox.Show("Please Press Edit Button to Edit")
        End If
        Me.Hide()
        FrmAdminMenu.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim userExist As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT [UserID] FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
        cmd1 = New OleDbCommand("DELETE FROM [User] WHERE [UserID] = ?", con)
        cmd1.Parameters.AddWithValue("@p1", txtUserID.Text)
        dr = cmd.ExecuteReader
        While dr.Read()
            If dr(0).ToString.Equals(txtUserID.Text) Then
                userExist = True
            End If
        End While
        If userExist = True Then
            If MessageBox.Show("Are You Sure you want to delete this Vendor?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                cmd1.ExecuteNonQuery()
                txtUserID.Clear()
                txtAddress.Clear()
                cmbbxCategory.Items.Clear()
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
                MessageBox.Show("Delete Successfully!")
            End If
        Else
            MessageBox.Show("Vendor not exist!")
        End If
        Hide()
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
End Class