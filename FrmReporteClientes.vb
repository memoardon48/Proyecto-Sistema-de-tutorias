Public Class FrmReporteClientes
    Private Sub FrmReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Clientes' table. You can move, or remove it, as needed.
        cboUniversidad.SelectedItem = "UNAH"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Select_ClientesTableAdapter.Fill(Me.DataSis.Select_Clientes, cboUniversidad.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class