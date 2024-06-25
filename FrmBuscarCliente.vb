Imports System.Data.SqlClient

Public Class FrmBuscarCliente
    Private Sub FrmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Cliente WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvClientes.DataSource = mostrar2
        conectar.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        TutoriasCliente.txtCodCliente.Text = dgvClientes.CurrentRow.Cells(0).Value
        TutoriasCliente.txtNombreCliente.Text = dgvClientes.CurrentRow.Cells(1).Value + " " + dgvClientes.CurrentRow.Cells(2).Value
        Me.Close()

    End Sub
End Class