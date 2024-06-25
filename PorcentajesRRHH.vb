Imports System.Data.SqlClient
Public Class PorcentajesRRHH
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Tutor WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvporcentahetutores.DataSource = mostrar2
        conectar.Close()
    End Sub
    Private Sub PorcentajesRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvporcentahetutores.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtCodTutor.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para el campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim agregar As String = "UPDATE Tutor SET porcentaje =  @porcentaje WHERE codTutor = @codTutor"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@porcentaje", nupPorcentaje.Value)
            agregar2.Parameters.AddWithValue("@codTutor", txtCodTutor.Text)
            agregar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutor', 'PorcentajesRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar Porcentaje de Pago (" & nupPorcentaje.Value & ")")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodTutor.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()
        End If

    End Sub
    Private Sub dgvporcentahe_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvporcentahetutores.CellDoubleClick
        Dim verificar As Boolean

        txtCodTutor.Text = Val(dgvporcentahetutores.CurrentRow.Cells(0).Value)
        If (String.IsNullOrEmpty(dgvporcentahetutores.CurrentRow.Cells(8).Value.ToString)) Then
            nupPorcentaje.Value = 0.5
        Else
            nupPorcentaje.Value = dgvporcentahetutores.CurrentRow.Cells(8).Value
        End If

    End Sub



End Class