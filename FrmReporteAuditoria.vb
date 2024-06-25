Public Class FrmReporteAuditoria
    Private Sub FrmReporteAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSis.Select_Auditoria' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btnBuscarUser_Click(sender As Object, e As EventArgs) Handles btnBuscarUser.Click
        FrmBuscarUsuario.Show()

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If (txtUsuario.Text = String.Empty) Then
            MessageBox.Show("Ingrese el usuario para el cual desea generar el reporte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Select_AuditoriaTableAdapter.Fill(Me.DataSis.Select_Auditoria, txtUsuario.Text)

            Me.ReportViewer1.RefreshReport()
        End If

    End Sub
End Class