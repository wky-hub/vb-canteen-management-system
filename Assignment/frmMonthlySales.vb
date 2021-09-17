Imports System.Data.OleDb

Public Class frmMonthlySales
    Private conn As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Assignment\bin\Debug\Database1.mdb")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As OleDbCommand
        Dim adp As New OleDbDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "select o.OrderDate, o.OrderID ,p.TotalAmount
               FROM   `Payment` `p` INNER JOIN `Order` `o` ON `p`.`OrderID`=`o`.`OrderID`
               order by o.OrderDate"
        Try
            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "payment" & "order")
            Dim report As New CrystalReport6
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            conn.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
        conn.Close()
    End Sub
End Class