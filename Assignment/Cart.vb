Imports System.Data.OleDb
Public Class Cart
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Sub UpdateCount()
        lblCount.Text = lstCart.Items.Count.ToString("0")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim sql As String = "select productName,productPrice from [product] p , [user] u where p.userid = u.userid and productStatus = 'available'"
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        Dim i As Integer = 0
        Dim tempCount As Integer = 0
        Dim tempTotal As Integer = 0

        If lstCart.SelectedIndex < 0 Then
            MessageBox.Show("Please select an item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                While dr.Read() And lstCart.SelectedItem.ToString.Length > dr(0).ToString.Length
                    If dr(0).Equals(lstCart.SelectedItem.ToString.Substring(0, dr(0).ToString().Length)) Then
                        tempTotal += CDec(lstCart.SelectedItem.ToString.Substring(dr(0).ToString.Length + 3)) * dr(1)
                        tempCount += 1
                    End If
                End While
                lstCart.Items.RemoveAt(lstCart.SelectedIndex)
                lblCount.Text = CStr(CDec(lblCount.Text) - tempCount)
                lblTotal.Text = CStr(CDec(lblTotal.Text) - tempTotal)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCart.Items.Clear()
        UpdateCount()
        lblTotal.Text = 0
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        MainMenu.Show()
        UpdateCount()
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateCount()
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim confirm As Long = 0

        confirm = MessageBox.Show("Do you confirm to pay?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = vbYes Then
            Me.Hide()
            Payment.Show()
        End If
    End Sub

    Private Sub lstCart_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstCart.MouseDoubleClick
        Dim sql As String = "select productName,productPrice from [product] p , [user] u where p.userid = u.userid and productStatus = 'available'"
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        Dim i As Integer = 0
        Dim tempCount As Integer = 0
        Dim tempTotal As Integer = 0
        Try
            While dr.Read() And lstCart.SelectedItem.ToString.Length > dr(0).ToString.Length
                If dr(0).Equals(lstCart.SelectedItem.ToString.Substring(0, dr(0).ToString().Length)) Then
                    tempTotal += CDec(lstCart.SelectedItem.ToString.Substring(dr(0).ToString.Length + 3)) * dr(1)
                    tempCount += 1
                End If
            End While
            lstCart.Items.RemoveAt(lstCart.SelectedIndex)
            lblCount.Text = CStr(CDec(lblCount.Text) - tempCount)
            lblTotal.Text = CStr(CDec(lblTotal.Text) - tempTotal)
        Catch ex As Exception

        End Try

    End Sub
End Class