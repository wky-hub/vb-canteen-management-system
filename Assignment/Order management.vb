Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO

Public Class Order_management
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Order_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Order_Detail' table. You can move, or remove it, as needed.
        'Me.Order_DetailTableAdapter.Fill(Me.Database1DataSet1.Order_Detail)
        Try
            conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\database1.accdb")
            conn.Open()
            ListView1.Items.Clear()
            Dim blank As String = ""
            Dim sql As String = "Select NoOfOrder,OrderID,o.ProductID,Quantity from order_detail o,product p Where o.productID = p.productID and p.UserID ='" & FrmVendorLogin.txtVendorId.Text & "' and o.status IS NULL"
            cmd = New OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader

            Dim count As Integer = 0

            While dr.Read()
                ListView1.Items.Add(dr(0))
                ListView1.Items(count).SubItems.Add(dr(1))
                ListView1.Items(count).SubItems.Add(dr(2))
                ListView1.Items(count).SubItems.Add(dr(3))
                count = count + 1
                Console.ReadLine()
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Order_DetailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order_DetailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_DetailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub btnPrepared_Click(sender As Object, e As EventArgs) Handles btnPrepared.Click
        Try
            Dim orderNo As Integer = 0
            orderNo = CInt(ListView1.FocusedItem.Text)
            Order_DetailTableAdapter.UpdateQuery(orderNo)
            Dim itm As ListViewItem
            itm = ListView1.FocusedItem
            itm.Remove()
            PictureBoxProduct.Image = Nothing
            lblProductName.Text = ""

        Catch ex As Exception
            MessageBox.Show("There are no orders yet!!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        conn.Open()
        Dim productID As String = ""

        If e.IsSelected Then
            productID = ListView1.FocusedItem.SubItems(2).Text
        End If

        Dim sql As String = "Select productName,productImage from product where productID = '" & productID & "'"
        cmd = New OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader
        While dr.Read
            lblProductName.Text = dr(0)

            Dim data As Byte() = DirectCast(dr(1), Byte())
            Using ms As New MemoryStream(data)
                PictureBoxProduct.Image = Image.FromStream(ms)
            End Using
        End While
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Now.Date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorMenu.Show()
        End If
    End Sub
End Class