'Imports CrystalDecisions.CrystalReports.Engine
Public Class frmReporteComprobante


    Private Sub frmReporteComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbSGSv3DataSet.generar_comprovante_ingreso' table. You can move, or remove it, as needed.
        Me.generar_comprovante_ingresoTableAdapter.Fill(Me.dbSGSv3DataSet.generar_comprovante_ingreso, txtidventa.Text)


        'Try
        '    Me.generar_comprobanteTableAdapter.Fill(Me.dbventasDataSet1.generar_comprobante, idventa:=txtidventa.Text)
        '    Me.ReportViewer1.RefreshReport()
        'Catch ex As Exception
        Me.ReportViewer1.RefreshReport()
        'End Try




        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim cryRpt As New ReportDocument
    '    cryRpt.Load("\CrystalReport1.rpt")
    '    CrystalReportViewer1.ReportSource = cryRpt
    '    CrystalReportViewer1.Refresh()
    'End Sub
End Class