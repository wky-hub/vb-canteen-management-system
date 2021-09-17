Imports System.Data.OleDb

Public Class Calculator
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim PaymentNo As Integer
    Dim orderId As String
    Dim orderNo As Integer
    Dim day As String
    Dim time As String

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "1"
        Else
            lblAmount.Text = lblAmount.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "2"
        Else
            lblAmount.Text = lblAmount.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "3"
        Else
            lblAmount.Text = lblAmount.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "4"
        Else
            lblAmount.Text = lblAmount.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "5"
        Else
            lblAmount.Text = lblAmount.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "6"
        Else
            lblAmount.Text = lblAmount.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "7"
        Else
            lblAmount.Text = lblAmount.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "8"
        Else
            lblAmount.Text = lblAmount.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "9"
        Else
            lblAmount.Text = lblAmount.Text + "9"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If lblAmount.Text = "0" Then
            lblAmount.Text = "0"
        Else
            lblAmount.Text = lblAmount.Text + "0"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAmount.Text = ""
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not (lblAmount.Text.Contains(".")) Then
            lblAmount.Text += "."
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Payment.Show()
    End Sub

    Dim check As Integer = 1

    Private Function Calculate(ByVal total As Double, ByVal cash As Double) As Double
        Dim changes As Double = 0
        If cash > total Then
            changes = cash - total
            check = 1
        ElseIf total > cash Then
            changes = total - cash
            check = 2
        Else
            changes = 0
            check = 3
        End If
        Return changes
    End Function

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
        Try
            lblAmountDue.Text = Cart.lblTotal.Text
            lblPaid.Text = lblAmount.Text
            Dim changes As Double = 0
            Dim amount As Double = 0
            Dim paid As Double = 0

            amount = (CDbl(lblAmountDue.Text)).ToString("C2")
            paid = CDbl(lblPaid.Text)
            changes = Calculate(amount, paid)

            If check = 1 Then
                lblChangeDue.Text = changes.ToString("f2")
                MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GeneratePaymentNo()
                lblAmountDue.Text = ""
                lblPaid.Text = ""
                lblChangeDue.Text = ""
                lblAmount.Text = ""
                Me.Hide()
                MainMenu.Show()
                Cart.lstCart.Items.Clear()
                Cart.lblTotal.Text = 0
                OrdedId()
                PaymentNo = CInt(PaymentNo)
                orderNo = CInt(orderNo)

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
                Dim status As String = " "

                conn.Open()
                Dim sql3 As String = "INSERT INTO order_detail VALUES ('" & orderNo & "', '" & orderId & "','" & status & "')"
                cmd = New OleDbCommand(sql1, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

            ElseIf check = 2 Then
                MessageBox.Show("Insufficient amount, Please insert more !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblPaid.Text = ""
                lblChangeDue.Text = ""

            ElseIf check = 3 Then
                lblChangeDue.Text = changes.ToString("f2")
                MessageBox.Show("Payment Successful", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GeneratePaymentNo()
                lblAmountDue.Text = ""
                lblPaid.Text = ""
                lblChangeDue.Text = ""
                lblAmount.Text = ""
                Me.Hide()
                MainMenu.Show()
                Cart.lstCart.Items.Clear()
                Cart.lblTotal.Text = 0
                OrdedId()
                PaymentNo = CInt(PaymentNo)
                orderNo = CInt(orderNo)

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
            check = 1
        Catch ex As Exception
            MessageBox.Show("Please Insert Cash!!!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub lblAmount_TextChanged(sender As Object, e As EventArgs) Handles lblAmount.TextChanged
        lblPaid.Text = lblAmount.Text
    End Sub
End Class