Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\database1.accdb")
            conn.Open()
            Dim style As New DataGridViewCellStyle
            style.ForeColor = Color.White
            style.BackColor = Color.Black
            ProductDataGridView.DefaultCellStyle = style

            Me.ProductTableAdapter.FillBy(Me.Database1DataSet.Product, UserIDTextBox.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conn.Close()
    End Sub

    Private Sub ProductNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = vbTrue
        Else
            e.Handled = vbFalse
        End If
    End Sub

    Private Sub ProductPriceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim count As Integer = 0
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Function checkData(itemName As String, price As String, status As String) As Boolean
        Dim flag As Boolean = True

        If itemName = "" Then
            MessageBox.Show("Item name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProductNameTextBox.Focus()
            flag = False
            ErrorProvider1.SetError(ProductNameTextBox, "Item name cannot be blank")
        Else
            ErrorProvider1.SetError(ProductNameTextBox, "")
        End If

        If price = "" Then
            MessageBox.Show("Item price cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProductPriceTextBox.Focus()
            flag = False
            ErrorProvider1.SetError(ProductPriceTextBox, "Item price cannot be blank")
        Else
            ErrorProvider1.SetError(ProductPriceTextBox, "")
        End If

        If status <> "Available" And status <> "Out of Stock" Then
            MessageBox.Show("This status is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            flag = False
            ErrorProvider1.SetError(ProductStatusComboBox, "Please choose the status from the combo box")
        Else
            ErrorProvider1.SetError(ProductStatusComboBox, "")
        End If

        Return flag

    End Function

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs)
        Try
            ProductBindingSource.AddNew()
            AutoNumberNo()
            ProductNameTextBox.Focus()
            UserIDTextBox.Text = FrmVendorLogin.txtVendorId.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            Dim respond As Single = 0
            respond = MessageBox.Show("Are you sure want to delete the record??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If respond = vbYes Then
                ProductBindingSource.RemoveCurrent()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Try
            Dim ans As Long = 0
            ans = MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = vbYes Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            Dim productName As String = ProductNameTextBox.Text
            Dim price As String = ProductPriceTextBox.Text
            Dim status As String = ProductStatusComboBox.Text
            Dim flag As Boolean = checkData(productName, price, status)
            If flag = True Then
                Dim respond As Single = 0
                respond = MessageBox.Show("Are you sure want to update/save the record??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If respond = vbYes Then
                    Me.Validate()
                    Me.ProductBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
                    MessageBox.Show("Record updated/saved successfully!!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ProductImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub AutoNumberNo()
        Try
            conn.Open()
            Dim digit As Integer = 0
            Dim result As String = ""

            Dim sql As String = "select max(productID) from product"
            Dim comm = New OleDbCommand(sql, conn)
            result = comm.ExecuteScalar().ToString()

            If String.IsNullOrEmpty(result) Then
                result = "P0000"
                ProductIDTextBox.Text = result
            End If
            result = result.Substring(2)
            Int32.TryParse(result, digit)
            digit = digit + 1
            result = "P" + digit.ToString("D4")
            ProductIDTextBox.Text = result

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ProductPriceTextBox_Validating(sender As Object, e As CancelEventArgs)
        Dim currency As Decimal

        'Convert the current value to currency, with or without a currency symbol.
        If Not Decimal.TryParse(ProductPriceTextBox.Text,
                                Globalization.NumberStyles.Currency,
                                Nothing,
                                currency) Then
            'Don't let the user leave the field if the value is invalid.
            With ProductPriceTextBox
                .HideSelection = False    '//Keep the selection highlighted, even after textbox loses focus.
                .SelectAll()

                MessageBox.Show("Please enter a valid currency amount.",
                                "Invalid Value",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

                .HideSelection = True
            End With

            e.Cancel = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.ProductTableAdapter.FillBy1(Me.Database1DataSet.Product, UserIDTextBox.Text, txtProdID.Text)
    End Sub

    Private Sub txtProdID_TextChanged(sender As Object, e As EventArgs)
        conn.Open()

        If txtProdID.Text = "" Then
            Me.ProductTableAdapter.FillBy(Me.Database1DataSet.Product, UserIDTextBox.Text)
        End If
        conn.Close()
    End Sub

    Private Sub txtProdID_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsPunctuation(e.KeyChar) Then
            e.Handled = vbTrue
        Else
            e.Handled = vbFalse
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to go back?", "BACK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Hide()
            FrmVendorMenu.Show()
        End If
    End Sub
End Class
