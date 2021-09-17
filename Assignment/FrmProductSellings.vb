Imports System.Data.OleDb


Public Class FrmProductSellings
    Private conn As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Assignment\bin\Debug\Database1.mdb")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader
        Dim adp As New OleDbDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "select DISTINCT(u.UserID), p.ProductID, p.ProductPrice, u.CategoryOfProduct
               FROM   `Product` `p` INNER JOIN `User` `u` ON `p`.`UserID`=`u`.`UserID` 
               order by u.userId"

        'sql = "select * from product"

        Try
            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            adp.SelectCommand = cmd
            adp.Fill(dt, "product" & "user")
            Dim report As New CrystalReport3
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