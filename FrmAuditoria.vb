Imports System.Data.SqlClient

Public Class FrmAuditoria
    Private Sub FrmAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Auditoria "
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvAuditoria.DataSource = mostrar2
        conectar.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmReporteAuditoria.Show()

    End Sub
End Class