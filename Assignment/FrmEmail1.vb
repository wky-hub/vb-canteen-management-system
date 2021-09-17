Imports System.Data.OleDb
Imports System.Net.Mail
Public Class FrmEmail1
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmSecurityPattern.Show()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim reset As Boolean = False
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT UserID,Email FROM [User] WHERE [UserID] LIKE 'V%' OR [UserID] LIKE 'A%'", con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If txtUserId.Text = dr(0) Then
                reset = True
                resetPassword(dr(1).ToString)
            End If
            Console.ReadLine()
        End While
        If reset = False Then
            MessageBox.Show("Wrong User ID!")
        Else
            MessageBox.Show("A code has been sent to your email for reset password purpose." + vbNewLine +
                            "Kindly check your mailbox or junk mailbox", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            FrmEmail2.Show()
        End If
        con.Close()
    End Sub

    Private Sub resetPassword(ByVal email As String)
        Dim r As Random = New Random
        Dim s As Integer = 0
        s = r.Next(999999)
        lblReset.Text = s.ToString()
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("tarccms@gmail.com", "tarccms1234")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"
        e_mail = New MailMessage()
        e_mail.From = New MailAddress("tarccms@gmail.com")
        e_mail.To.Add(email)
        e_mail.Subject = "RESET PASSWORD"
        e_mail.IsBodyHtml = False
        e_mail.Body = "The code for reseting your password is " + vbNewLine + s.ToString()
        Smtp_Server.Send(e_mail)
    End Sub
End Class