Public Class FrmReporteTutorias
    Private Sub FrmReporteTutorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Tutoria' table. You can move, or remove it, as needed.
        dtpFecha2.MinDate = dtpFecha1.Value.AddDays(1)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.Select_TutoriaTableAdapter.Fill(Me.DataSis.Select_Tutoria, dtpFecha1.Value, dtpFecha2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtpFecha2_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha2.ValueChanged


    End Sub

    Private Sub dtpFecha1_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha1.ValueChanged
        dtpFecha2.MinDate = dtpFecha1.Value.AddDays(1)
    End Sub
End Class