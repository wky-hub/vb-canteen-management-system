Imports System.Data.OleDb
Imports System.Net.Mail
Public Class FrmAnnouncement
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub FrmAnnouncement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer = 1
        con = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Assignment\bin\Debug\Database1.mdb")
        con.Open()
        cmd = New OleDbCommand("SELECT [UserID] FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If count = 1 Then
                chkbxV1.Text = dr(0).ToString()
                chkbxV1.Visible = True
            ElseIf count = 2 Then
                chkbxV2.Text = dr(0).ToString()
                chkbxV2.Visible = True
            ElseIf count = 3 Then
                chkbxV3.Text = dr(0).ToString()
                chkbxV3.Visible = True
            ElseIf count = 4 Then
                chkbxV4.Text = dr(0).ToString()
                chkbxV4.Visible = True
            ElseIf count = 5 Then
                chkbxV5.Text = dr(0).ToString()
                chkbxV5.Visible = True
            End If
            count = count + 1
            Console.ReadLine()
        End While
    End Sub

    Private Sub chkbxAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxAll.CheckedChanged
        If chkbxAll.Checked Then
            If chkbxV1.Text IsNot "" Then
                chkbxV1.Checked = True
            End If
            If chkbxV2.Text IsNot "" Then
                chkbxV2.Checked = True
            End If
            If chkbxV3.Text IsNot "" Then
                chkbxV3.Checked = True
            End If
            If chkbxV4.Text IsNot "" Then
                chkbxV4.Checked = True
            End If
            If chkbxV5.Text IsNot "" Then
                chkbxV5.Checked = True
            End If
        Else
            chkbxV1.Checked = False
            chkbxV2.Checked = False
            chkbxV3.Checked = False
            chkbxV4.Checked = False
            chkbxV5.Checked = False
        End If

    End Sub

    Private Sub btnAnnounce_Click(sender As Object, e As EventArgs) Handles btnAnnounce.Click
        Dim email(4) As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        con = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Assignment\bin\Debug\Database1.mdb")
        con.Open()
        cmd = New OleDbCommand("SELECT [UserID],[Email] FROM [User] WHERE [UserID] LIKE 'V%' ORDER BY [UserID]", con)
        dr = cmd.ExecuteReader()
        If (chkbxV1.Checked Or chkbxV2.Checked Or chkbxV3.Checked Or chkbxV4.Checked Or chkbxV5.Checked) And rtxtMessage.Text IsNot "" Then
            While dr.Read()
                If chkbxV1.Checked = True And dr(0).ToString() = chkbxV1.Text Then
                    email(i) = dr(1).ToString()
                    i = i + 1
                ElseIf chkbxV2.Checked = True And dr(0).ToString() = chkbxV2.Text Then
                    email(i) = dr(1).ToString()
                    i = i + 1
                ElseIf chkbxV3.Checked = True And dr(0).ToString() = chkbxV3.Text Then
                    email(i) = dr(1).ToString()
                    i = i + 1
                ElseIf chkbxV4.Checked = True And dr(0).ToString() = chkbxV4.Text Then
                    email(i) = dr(1).ToString()
                    i = i + 1
                ElseIf chkbxV5.Checked = True And dr(0).ToString() = chkbxV5.Text Then
                    email(i) = dr(1).ToString()
                    i = i + 1
                End If
                Console.ReadLine()
            End While
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("jeff82746@gmail.com", "yongjiet882746")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("jeff82746@gmail.com")
            e_mail.Subject = "Announcement from Admin"
            e_mail.IsBodyHtml = False
            e_mail.Body = rtxtMessage.Text.ToString()
            While j < i
                e_mail.To.Add(email(j))
                Smtp_Server.Send(e_mail)
                j = j + 1
            End While
            MessageBox.Show("Send Successfully!")
        Else
            MessageBox.Show("No Vendor selected or No message written")
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

    Private Sub chkbxV2_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxV2.CheckedChanged

    End Sub

    Private Sub chkbxV3_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxV3.CheckedChanged

    End Sub

    Private Sub chkbxV4_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxV4.CheckedChanged

    End Sub

    Private Sub chkbxV1_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxV1.CheckedChanged

    End Sub

    Private Sub chkbxV5_CheckedChanged(sender As Object, e As EventArgs) Handles chkbxV5.CheckedChanged

    End Sub
End Class