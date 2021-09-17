Imports QRCoder
Imports System.Data.OleDb

Public Class ScanQR
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim PaymentNo As Integer
    Dim orderId As String
    Dim orderNo As Integer
    Dim day As String
    Dim time As String
    Dim gen As New QRCodeGenerator
    Dim data = gen.CreateQrCode("Payment Successful !!", QRCodeGenerator.ECCLevel.Q)
    Dim code As New QRCode(data)

    Private Sub ScanQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        picQR.Image = code.GetGraphic(8)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Private Sub GeneratePaymentNo()
        Try
            conn.Open()
            Dim sql As String = "Select Max (PaymentNo)+1 from Payment"
            Dim cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                If dr(0).ToString = vbNullString Then
                    PaymentNo = 1
                Else
                    PaymentNo = dr(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub OrdedId()
        Try
            conn.Open()
            Dim digit As Integer = 0
            Dim sql As String = "select max(OrderID) from payment"
            Dim cmd As New OleDbCommand(sql, conn)
            orderId = cmd.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(orderId) Then
                orderId = "D0000"
            End If
            orderId = orderId.Substring(1)
            Int32.TryParse(orderId, digit)
            digit = digit + 1
            orderId = "D" + digit.ToString("D4")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub OrderNum()
        Try
            conn.Open()
            Dim sql As String = "Select Max (NoOfOrder)+1 from Payment"
            Dim cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
            If dr.Read Then
                If dr(0).ToString = vbNullString Then
                    orderNo = 1
                Else
                    orderNo = dr(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim day As String = ""
        Dim time As String = ""
        Dim amount As Double = 0
        MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If vbOK Then
            Me.Hide()
            MainMenu.Show()
            Cart.lstCart.Items.Clear()
            Cart.lblTotal.Text = 0
            MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GeneratePaymentNo()
            Me.Hide()
            MainMenu.Show()
            Cart.lstCart.Items.Clear()
            Cart.lblTotal.Text = 0
            OrdedId()
            PaymentNo = CInt(PaymentNo)
            orderNo = CInt(orderNo)
            amount = (CDbl(Cart.lblTotal.Text)).ToString("C2")

            day = Now.Date.ToString("dd MM yyyy")
            time = TimeOfDay.ToString("hh:mm tt")

            conn.Open()
            Dim sql2 As String = "INSERT INTO [Order] VALUES(?,?,?)"
            cmd = New OleDbCommand(sql2, conn)
            cmd.Parameters.AddWithValue("@p1", orderId)
            cmd.Parameters.AddWithValue("@p2", time)
            cmd.Parameters.AddWithValue("@p3", day)
            cmd.ExecuteNonQuery()
            conn.Close()

            conn.Open()
            Dim sql1 As String = "INSERT INTO Payment VALUES ('" & PaymentNo & "', '" & amount & "', '" & orderId & "')"
            cmd = New OleDbCommand(sql1, conn)
            cmd.ExecuteNonQuery()
            conn.Close()

        End If
    End Sub
End Class