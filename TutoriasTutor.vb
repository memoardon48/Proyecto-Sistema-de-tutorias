Imports System.Data.SqlClient

Public Class TutoriasTutor
    Dim clase As String
    Dim tutor As String
    Dim tutoria As String

    Sub cargarTutos()
        conectar.Open()
        Dim cargar As String = "SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.estado = 'en espera'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using

        DgvTutorias.DataSource = cargar2

        conectar.Close()
    End Sub



    Sub cargarPagadas()
        conectar.Open()
        Dim cargar As String = "SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codTutor, (TT.nombre + ' ' + TT.apellido) AS nombreTutor, T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado, T.pagadaCliente  FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Tutor TT ON T.codTutor = TT.codTutor INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.pagadaCliente = 'SI'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using

        dgvPagadas.DataSource = cargar2

        conectar.Close()
    End Sub
    Private Sub TutoriasTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPagadas()

        cargarTutos()

    End Sub

    Private Sub dgvTutores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutores.CellContentClick

    End Sub

    Private Sub DgvTutorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTutorias.CellContentClick

    End Sub

    Private Sub DgvTutorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTutorias.CellDoubleClick
        Dim codigo As String
        codigo = DgvTutorias.CurrentRow.Cells(3).Value
        tutoria = DgvTutorias.CurrentRow.Cells(0).Value
        conectar.Open()
        Dim cargar As String = "SELECT CT.codClase, C.nombreClase, CT.codTutor, (T.nombre +' ' + T.apellido) AS nombreTutor, CT.estado FROM ClaseTutor CT INNER JOIN Tutor T ON CT.codTutor = T.codTutor INNER JOIN Clase C ON CT.codClase = C.codClase  WHERE CT.estado = 'habilitado' AND CT.codClase = " & codigo
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using

        dgvTutores.DataSource = cargar2

        conectar.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        conectar.Open()
        Dim update As String = "UPDATE Tutoria SET codTutor = @codTutor, estado = 'confirmada'  WHERE codTutoria = @codTutoria"
        Dim update2 As New SqlCommand(update, conectar)
        update2.Parameters.AddWithValue("@codTutor", tutor)
        update2.Parameters.AddWithValue("@codTutoria", tutoria)
        update2.ExecuteNonQuery()

        Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutoria', 'TutoriasTutor', @codRegistro, GETDATE())"
        Dim audi2 As New SqlCommand(audi, conectar)
        audi2.Parameters.AddWithValue("@userName", user)
        audi2.Parameters.AddWithValue("@accion", "Insertar Tutor de la Tutoría (Tutor: " & tutor & ")")
        audi2.Parameters.AddWithValue("@codRegistro", tutoria)
        audi2.ExecuteNonQuery()
        conectar.Close()
        cargarTutos()
        MessageBox.Show("EL tutor ha sido asignado", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgvTutores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTutores.CellDoubleClick
        tutor = dgvTutores.CurrentRow.Cells(2).Value

    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        conectar.Open()
        Dim update As String = "UPDATE Tutoria SET estado = 'rechazada'  WHERE codTutoria = @codTutoria"
        Dim update2 As New SqlCommand(update, conectar)
        update2.Parameters.AddWithValue("@codTutoria", tutoria)
        update2.ExecuteNonQuery()

        Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutoria', 'TutoriasTutor', @codRegistro, GETDATE())"
        Dim audi2 As New SqlCommand(audi, conectar)
        audi2.Parameters.AddWithValue("@userName", user)
        audi2.Parameters.AddWithValue("@accion", "Rechazar Tutoría")
        audi2.Parameters.AddWithValue("@codRegistro", tutoria)
        audi2.ExecuteNonQuery()
        conectar.Close()
        cargarTutos()
        MessageBox.Show("La tutoría ha sido rechazada", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class