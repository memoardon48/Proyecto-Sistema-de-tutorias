Imports System.Data.SqlClient

Public Class FrmBuscarTutor
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutor.CellDoubleClick
        ClasesTutor.txtCodigoT.Text = dgvTutor.CurrentRow.Cells(0).Value
        EvaluacionesRRHH.txtCodtuto.Text = dgvTutor.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub FrmBuscarTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Tutor WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvTutor.DataSource = mostrar2
        conectar.Close()
    End Sub
End Class