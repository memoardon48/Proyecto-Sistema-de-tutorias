Public Class gerencia
    Private Sub btnrfinanciero_Click(sender As Object, e As EventArgs) Handles btnrfinanciero.Click
        FrmReporteFinanciero.Show()

    End Sub

    Private Sub btninformedemercado_Click(sender As Object, e As EventArgs) Handles btninformedemercado.Click
        FrmReporteMarketing.Show()

    End Sub

    Private Sub btndesempeño_Click(sender As Object, e As EventArgs) Handles btndesempeño.Click
        FrmReporteEvaluacion.Show()

    End Sub
End Class