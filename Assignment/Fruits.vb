Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Fruits
    Dim fruits As String = ""
    Dim price As Double = 0
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim count As Integer = 0
    Dim i As Integer = 0

    Private Sub btnClick(sender As Object, e As EventArgs)
        Try
            conn.Open()
            Dim sentButton As Button = CType(sender, Button)

            For k As Integer = 1 To count
                sentButton.Name = "btn" & k
                picFruits.Visible = True
                fruits = sentButton.Text
                i = 0
                sentButton.Focus()
                Dim sql As String = "Select productImage from product where productName = '" & sentButton.Text & "'"
                cmd = New OleDbCommand(sql, conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim data As Byte() = DirectCast(dr(0), Byte())
                    Using ms As New MemoryStream(data)
                        picFruits.Image = Image.FromStream(ms)
                    End Using
                End While
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
        picFruits.Visible = False
        lblQty.Text = ""
    End Sub

    Private Sub picCart_Click(sender As Object, e As EventArgs) Handles picCart.Click
        Me.Hide()
        Cart.Show()
        Cart.UpdateCount()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Me.Hide()
        Cart.Show()
        Cart.UpdateCount()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        i += 1
        lblQty.Text = i.ToString
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If i <= 0 Then
            lblQty.Text = 0
        Else
            i -= 1
            lblQty.Text = i.ToString
        End If
    End Sub

    Dim total As Double = 0

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            total = CDbl(Cart.lblTotal.Text)
        Catch ex As Exception

        End Try
        Dim sql As String = "select productPrice from [product] p , [user] u 
                             where p.userid = u.userid and productStatus = 'available' and categoryOfProduct = 'fruits'
                             and p.productName = ? order by productID"
        Dim cmd As New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@p1", fruits)
        Dim i As Integer = 0
        Dim exist As Boolean = False
        If lblQty.Text = "" Or lblQty.Text = "0" Then
            MessageBox.Show("Please select quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conn.Open()
            dr = cmd.ExecuteReader()
            While dr.Read()
                total += (CDbl(dr(0)) * CDbl(lblQty.Text))
            End While
            If Cart.lstCart.Items.Count = 0 Then
                Cart.lstCart.Items.Add(fruits & " / " & lblQty.Text)
                exist = True
            Else
                While i < Cart.lstCart.Items.Count
                    If Cart.lstCart.Items.Item(i).ToString.StartsWith(fruits) And exist = False Then
                        Cart.lstCart.Items.Add(CStr(fruits + " / " & CStr(CDec(Cart.lstCart.Items.Item(i).ToString().Substring(fruits.Length + 3)) + CDec(lblQty.Text))))
                        Cart.lstCart.Items.RemoveAt(i)
                        exist = True
                    End If
                    i += 1
                End While
            End If
            If exist = False Then
                Cart.lstCart.Items.Add(fruits & " / " & lblQty.Text)
            End If
            Cart.lblTotal.Text = total
            lblQty.Text = ""
            conn.Close()
        End If
    End Sub

    Private Sub fruits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")

        Dim sql As String = "select productName,productPrice from [product] p , [user] u where p.userid = u.userid and productStatus = 'available' and categoryOfProduct = 'fruits'
                             order by productID"

        Dim cmd As New OleDbCommand(sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader()

        While dr.Read()
            Dim lbl As New Label
            Dim btn As New Button
            Dim myfont As New Font("Microsoft Sans serif", 14)
            Dim format As Integer = dr(1)

            pnlFruits.Controls.Add(btn)
            pnlFruits.Controls.Add(lbl)
            btn.Text = dr(0)
            lbl.Text = format.ToString("C2")

            For x As Integer = 0 To count
                btn.Size = New Size(160, 50)
                btn.ForeColor = Color.White
                btn.BackColor = Color.Black
                btn.Font = myfont
                btn.Name = "btn" & x + 1
                btn.Location = New Point(40, (100 * x) + 5)

                lbl.Size = New Size(100, 52)
                lbl.Location = New Point(250, (100 * x) + 19)
                lbl.ForeColor = Color.White
                lbl.BackColor = Color.Transparent
                lbl.Font = myfont
                lbl.Name = "lbl" & x + 1

            Next
            count = count + 1
            Console.ReadLine()
            AddHandler btn.Click, AddressOf btnClick
        End While
        conn.Close()
    End Sub
End Class