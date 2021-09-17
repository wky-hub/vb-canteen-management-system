Imports System.Data.OleDb
Public Class FrmSecurityPattern
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        FrmEmail1.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim pattern As String = ""
        Dim count As Integer = 0
        Dim login As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT UserID,securityPattern FROM [User] WHERE [UserID] LIKE 'V%'", con)
        dr = cmd.ExecuteReader()
        If A1.Checked Then
            pattern &= "A1"
            count = count + 1
        End If
        If A2.Checked Then
            pattern &= "A2"
            count = count + 1
        End If
        If A3.Checked Then
            pattern &= "A3"
            count = count + 1
        End If
        If A4.Checked Then
            pattern &= "A4"
            count = count + 1
        End If
        If A5.Checked Then
            pattern &= "A5"
            count = count + 1
        End If
        If B1.Checked Then
            pattern &= "B1"
            count = count + 1
        End If
        If B2.Checked Then
            pattern &= "B2"
            count = count + 1
        End If
        If B3.Checked Then
            pattern &= "B3"
            count = count + 1
        End If
        If B4.Checked Then
            pattern &= "B4"
            count = count + 1
        End If
        If B5.Checked Then
            pattern &= "B5"
            count = count + 1
        End If
        If C1.Checked Then
            pattern &= "C1"
            count = count + 1
        End If
        If C2.Checked Then
            pattern &= "C2"
            count = count + 1
        End If
        If C3.Checked Then
            pattern &= "C3"
            count = count + 1
        End If
        If C4.Checked Then
            pattern &= "C4"
            count = count + 1
        End If
        If C5.Checked Then
            pattern &= "C5"
            count = count + 1
        End If
        If D1.Checked Then
            pattern &= "D1"
            count = count + 1
        End If
        If D2.Checked Then
            pattern &= "D2"
            count = count + 1
        End If
        If D3.Checked Then
            pattern &= "D3"
            count = count + 1
        End If
        If D4.Checked Then
            pattern &= "D4"
            count = count + 1
        End If
        If D5.Checked Then
            pattern &= "D5"
            count = count + 1
        End If
        If E1.Checked Then
            pattern &= "E1"
            count = count + 1
        End If
        If E2.Checked Then
            pattern &= "E2"
            count = count + 1
        End If
        If E3.Checked Then
            pattern &= "E3"
            count = count + 1
        End If
        If E4.Checked Then
            pattern &= "E4"
            count = count + 1
        End If
        If E5.Checked Then
            pattern &= "E5"
            count = count + 1
        End If
        If count = 5 And txtVendorId.Text.Chars(0) = "V" Then
            While dr.Read()
                If txtVendorId.Text.Equals(dr(0).ToString()) And pattern.Equals(dr(1).ToString()) Then
                    login = True
                    MessageBox.Show("Correct security Pattern!")
                    Hide()
                    FrmResetPassword.Show()

                End If
                Console.ReadLine()
            End While
            If login = False Then
                MessageBox.Show("Wrong Vendor ID or security Pattern!")
            End If
        ElseIf txtVendorId.Text.Chars(0) = "V" Then
            MessageBox.Show("Wrong Vendor ID or security Pattern!")
            MessageBox.Show("security Pattern contains 5 'tick's")
        Else
            MessageBox.Show("Wrong Vendor ID or security Pattern!")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorLogin.Show()
        End If
    End Sub

End Class