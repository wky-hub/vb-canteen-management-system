Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class frmVendorReport
    Dim FirstDate As Date
    Dim SecondDate As Date
    Private conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Desktop\Assignment\Database1.accdb")

    Public Sub GetReport()
        Dim rpt As New CrystalReport3
        rpt.Load(Application.StartupPath & "\CrystalReport3.rpt")

        Dim pfields As New ParameterFields

        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        pfield.Name = "start_date"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "end_date"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'FirstDate = DateTimePicker1.Value
        'SecondDate = DateTimePicker2.Value
        GetReport()

        Dim cmd As OleDbCommand
        'Dim dr As OleDbDataReader
        Dim adp As New OleDbDataAdapter
        Dim dt As New DataSet
        Dim sql As String = ""
        Dim conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\Desktop\Assignment\Database1.accdb")

        sql = "Select * from product"
        '" SELECT p.ProductID, o.OrderDate, (p.ProductPrice * od.Quantity) As 'Total Ammount'
        ' FROM `Product` `p`, `Order` `o`, `Order_Detail` `od`
        'Where `od`.`OrderID` = `o`.`OrderID` AND `od`.`ProductID` = `p`.`ProductID`
        '"

        Try
            conn.Open()
            cmd = New OleDbCommand(sql, conn)
            adp.SelectCommand = cmd
            'adp.Fill(dt, "Order_Detail")
            'adp.Fill(dt, "Order")
            adp.Fill(dt, "Product")
            Dim report As New CrystalReport2
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