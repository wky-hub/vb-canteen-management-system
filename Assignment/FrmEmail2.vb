Imports System.Data.OleDb
Imports System.Net.Mail
Public Class FrmEmail2
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtCode.Text = FrmEmail1.lblReset.Text Then
            Me.Hide()
            FrmResetPassword.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorLogin.Show()
        End If
    End Sub

    Private Sub lblResend_Click(sender As Object, e As EventArgs) Handles lblResend.Click
        Dim reset As Boolean = False
        If lblResend.ForeColor = Color.Blue Then
            con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
            con.Open()
            cmd = New OleDbCommand("SELECT UserID,Email FROM [User] WHERE [UserID] LIKE 'V%'", con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                If FrmEmail1.txtUserId.Text = dr(0) Then
                    reset = True
                    resetPassword(dr(1).ToString)
                    MessageBox.Show("A code has been sent to your email for reset password purpose." + vbNewLine +
                            "Kindly check your mailbox or junk mailbox", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblResend.ForeColor = Color.White
                End If
                Console.ReadLine()
            End While
        Else
            MessageBox.Show("You can only resend the code once in 10 seconds")
        End If

    End Sub

    Private Sub resetPassword(ByVal email As String)
        Dim r As Random = New Random
        Dim s As Integer = 0
        s = r.Next(999999)
        FrmEmail1.lblReset.Text = s.ToString()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblResend.ForeColor = Color.White Then
            lblResend.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub FrmEmail2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class