Imports System.Data.SqlClient

Public Class FrmBuscarUsuario
    Private Sub FrmBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Usuario"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvUsuarios.DataSource = mostrar2
        conectar.Close()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick


    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        FrmReporteAuditoria.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class