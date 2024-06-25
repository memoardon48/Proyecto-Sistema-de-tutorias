Public Class ReporteFactura
    Private Sub ReporteFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Factura' table. You can move, or remove it, as needed.
        Me.Select_FacturaTableAdapter.Fill(Me.DataSis.Select_Factura, TutoriasCliente.txtCodFactura.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class