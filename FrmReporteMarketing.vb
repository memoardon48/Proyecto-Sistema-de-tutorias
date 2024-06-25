Public Class FrmReporteMarketing
    Private Sub FrmReporteMarketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Marketing' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSis.Select_marketing' table. You can move, or remove it, as needed.
        dtpFecha2.MinDate = dtpFecha1.Value.AddDays(1)


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.Select_MarketingTableAdapter.Fill(Me.DataSis.Select_Marketing, dtpFecha1.Value, dtpFecha2.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpFecha1_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha1.ValueChanged
        dtpFecha2.MinDate = dtpFecha1.Value.AddDays(1)
    End Sub
End Class