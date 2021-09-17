Imports System.Data.OleDb
Public Class MainMenu
    Dim asianExist As Boolean = False
    Dim WesternExist As Boolean = False
    Dim BeverageExist As Boolean = False
    Dim MalayExist As Boolean = False
    Dim FruitsExist As Boolean = False
    Private Sub picWestern_Click(sender As Object, e As EventArgs) Handles picWestern.Click
        If WesternExist = True Then
            Me.Hide()
            Western.Show()
        Else
            MessageBox.Show("Sorry, Vendor Western are not available now")
        End If
    End Sub

    Private Sub picAsian_Click(sender As Object, e As EventArgs) Handles picAsian.Click
        If asianExist = True Then
            Me.Hide()
            Asian.Show()
        Else
            MessageBox.Show("Sorry, Vendor Asian are not available now")
        End If
    End Sub

    Private Sub picMalay_Click(sender As Object, e As EventArgs) Handles picMalay.Click
        If MalayExist = True Then
            Me.Hide()
            Malay.Show()
        Else
            MessageBox.Show("Sorry, Vendor Malay are not available now")
        End If
    End Sub

    Private Sub picBeverage_Click(sender As Object, e As EventArgs) Handles picBeverage.Click
        If BeverageExist = True Then
            Me.Hide()
            Beverage.Show()
        Else
            MessageBox.Show("Sorry, Vendor Beverage are not available now")
        End If
    End Sub

    Private Sub picFruits_Click(sender As Object, e As EventArgs) Handles picFruits.Click
        If FruitsExist = True Then
            Me.Hide()
            Fruits.Show()
        Else
            MessageBox.Show("Sorry, Vendor Fruits are not available now")
        End If
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Dim ans As Long = 0

        ans = MessageBox.Show("Are you sure to exit??", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = vbYes Then
            Me.Close()
            Asian.Close()
            Beverage.Close()
            Western.Close()
            Fruits.Close()
            Malay.Close()
            Cart.Close()
            Payment.Close()
            Calculator.Close()
            Cards.Close()
            ScanQR.Close()
            SplashScreen.Close()

        End If
    End Sub

    Private Sub InitializeComponent1()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Name = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Private Sub picVendor_Click(sender As Object, e As EventArgs) Handles picVendor.Click
        FrmVendorLogin.Show()
        Hide()
    End Sub

    Private Sub picAdmin_Click(sender As Object, e As EventArgs) Handles picAdmin.Click
        FrmAdminLogin.Show()
        Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader

        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        con.Open()
        cmd = New OleDbCommand("SELECT categoryOfProduct FROM [User]", con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            If dr(0).Equals("Asian") Then
                asianExist = True
            ElseIf dr(0).Equals("Western") Then
                WesternExist = True
            ElseIf dr(0).Equals("Beverage") Then
                BeverageExist = True
            ElseIf dr(0).Equals("Malay") Then
                MalayExist = True
            ElseIf dr(0).Equals("Fruits") Then
                FruitsExist = True
            End If
        End While
        If asianExist = False Then
            picAsian.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Assignment\Assignment\Resources\NOTAVAILABLE.jpg")
            Label3.ForeColor = Color.Red
            picAsian.Cursor = DefaultCursor
        End If
        If WesternExist = False Then
            picWestern.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Assignment\Assignment\Resources\NOTAVAILABLE.jpg")
            Label2.ForeColor = Color.Red
            picWestern.Cursor = DefaultCursor
        End If
        If BeverageExist = False Then
            picBeverage.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Assignment\Assignment\Resources\NOTAVAILABLE.jpg")
            Label5.ForeColor = Color.Red
            picBeverage.Cursor = DefaultCursor
        End If
        If MalayExist = False Then
            picMalay.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Assignment\Assignment\Resources\NOTAVAILABLE.jpg")
            Label4.ForeColor = Color.Red
            picMalay.Cursor = DefaultCursor
        End If
        If FruitsExist = False Then
            picFruits.Image = Image.FromFile("C:\Users\User\OneDrive\Desktop\Assignment\Assignment\Resources\NOTAVAILABLE.jpg")
            Label6.ForeColor = Color.Red
            picFruits.Cursor = DefaultCursor
        End If
    End Sub
End Class