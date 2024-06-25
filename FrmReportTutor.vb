Public Class FrmReportTutor
    Private Sub FrmReportTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Tutor' table. You can move, or remove it, as needed.
        cboUniversidad.SelectedItem = "UNAH"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Select_TutorTableAdapter.Fill(Me.DataSis.Select_Tutor, cboUniversidad.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class