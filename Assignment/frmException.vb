Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class frmException
    Dim FirstDate As Date
    Dim SecondDate As Date
    Private conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Desktop\Assignment\Database1.accdb")

    Public Sub GetReport()
        Dim rpt As New CrystalReport4
        rpt.Load(Application.StartupPath & "\CrystalReport4.rpt")

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
        pfields.add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstDate = DateTimePicker1.Value
        SecondDate = DateTimePicker2.Value
        'GetReport()

        'Dim cmd As OleDbCommand
        ''Dim dr As OleDbDataReader
        'Dim adp As New OleDbDataAdapter
        'Dim dt As New DataSet
        'Dim sql As String

        'sql = "select * from product"

        'Try
        '    conn.Open()
        '    cmd = New OleDbCommand(sql, conn)
        '    adp.SelectCommand = cmd
        '    adp.Fill(dt, "product")
        '    Dim report As New CrystalReport1
        '    report.SetDataSource(dt)
        '    CrystalReportViewer1.ReportSource = report
        '    CrystalReportViewer1.Refresh()
        '    cmd.Dispose()
        '    adp.Dispose()
        '    dt.Dispose()
        '    conn.Dispose()



        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    conn.Close()
        'End Try
        'conn.Close()
    End Sub
End Class