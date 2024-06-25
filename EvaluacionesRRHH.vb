Imports System.Data.SqlClient
Public Class EvaluacionesRRHH
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM EvaluacionesRRHH"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvRecursosHumanos.DataSource = mostrar2
        conectar.Close()
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtCodtuto.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim agregar As String = "INSERT INTO EvaluacionesRRHH(fecha, codTutor, metodo,tiempoEficaz,resolucionDudas,respetuo,confianza,comprensionCliente,preparacion) VALUES(@fecha, @codTutor, @metodo,@tipoEficaz,@resolucionDudas,@respetuo,@confianza,@compresionCliente,@preparacion)"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@fecha", dtpFecha.Value)
            agregar2.Parameters.AddWithValue("@codTutor", txtCodtuto.Text)
            agregar2.Parameters.AddWithValue("@metodo", nudMetododE.Value)
            agregar2.Parameters.AddWithValue("@tipoEficaz", nudTiempoeficaz.Value)
            agregar2.Parameters.AddWithValue("@resolucionDudas", nudResoludD.Value)
            agregar2.Parameters.AddWithValue("@respetuo", nudRespetuo.Value)
            agregar2.Parameters.AddWithValue("@confianza", nudConfianza.Value)
            agregar2.Parameters.AddWithValue("@compresionCliente", nudComprensiondC.Value)
            agregar2.Parameters.AddWithValue("@preparacion", nudPrepa.Value)
            agregar2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()

            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvRecursosHumanos.Rows.Count
            codigo = dgvRecursosHumanos.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'EvaluacionesRRHH', 'EvaluacionesRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar Evaluación")
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()

            txtCodtuto.Clear()
            txtCodEvalua.Clear()
            nudMetododE.Value = 1
            nudTiempoeficaz.Value = 1
            nudResoludD.Value = 1
            nudRespetuo.Value = 1
            nudConfianza.Value = 1
            nudComprensiondC.Value = 1
            nudPrepa.Value = 1

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtCodEvalua.Text = String.Empty Or txtCodtuto.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim modificar As String = "UPDATE EvaluacionesRRHH SET fecha=@fecha,codTutor = @codTutor, metodo=@metodo,tiempoEficaz=@tiempoEficaz,resolucionDudas=@resolucionDudas, respetuo=@respetuo, confianza=@confianza,comprensionCliente=@compresionCliente, preparacion=@preparacion WHERE codEvaluacion = @codEvaluacion"
            Dim modificar2 As New SqlCommand(modificar, conectar)
            modificar2.Parameters.AddWithValue("@fecha", dtpFecha.Value)
            modificar2.Parameters.AddWithValue("@codTutor", txtCodtuto.Text)
            modificar2.Parameters.AddWithValue("@metodo", nudMetododE.Value)
            modificar2.Parameters.AddWithValue("@tiempoEficaz", nudTiempoeficaz.Value)
            modificar2.Parameters.AddWithValue("@resolucionDudas", nudResoludD.Value)
            modificar2.Parameters.AddWithValue("@respetuo", nudRespetuo.Value)
            modificar2.Parameters.AddWithValue("@confianza", nudConfianza.Value)
            modificar2.Parameters.AddWithValue("@compresionCliente", nudComprensiondC.Value)
            modificar2.Parameters.AddWithValue("@preparacion", nudPrepa.Value)
            modificar2.Parameters.AddWithValue("@codEvaluacion", txtCodEvalua.Text)
            modificar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'EvaluacionesRRHH', 'EvaluacionesRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar Evaluación")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodEvalua.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()
            txtCodtuto.Clear()
            txtCodEvalua.Clear()
            nudMetododE.Value = 1
            nudTiempoeficaz.Value = 1
            nudResoludD.Value = 1
            nudRespetuo.Value = 1
            nudConfianza.Value = 1
            nudComprensiondC.Value = 1
            nudPrepa.Value = 1
            btnAgregar.Enabled = True


        End If


    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        If (txtCodEvalua.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim habilitar As String = "DELETE FROM EvaluacionesRRHH WHERE codEvaluacion = @codEvalucion"
            Dim habilitar2 As New SqlCommand(habilitar, conectar)
            habilitar2.Parameters.AddWithValue("@codEvalucion", txtCodEvalua.Text)
            habilitar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'EvaluacionesRRHH', 'EvaluacionesRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Eliminar Evaluación")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodEvalua.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()

            txtCodEvalua.Clear()
            txtCodtuto.Clear()
            nudMetododE.Value = 1
            nudTiempoeficaz.Value = 1
            nudResoludD.Value = 1
            nudRespetuo.Value = 1
            nudConfianza.Value = 1
            nudComprensiondC.Value = 1
            nudPrepa.Value = 1
            btnAgregar.Enabled = True
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FrmBuscarTutor.Show()

    End Sub

    Private Sub dgvRecursosHumanos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecursosHumanos.CellContentClick

    End Sub

    Private Sub dgvRecursosHumanos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecursosHumanos.CellDoubleClick
        txtCodEvalua.Text = dgvRecursosHumanos.CurrentRow.Cells(0).Value
        dtpFecha.Value = dgvRecursosHumanos.CurrentRow.Cells(1).Value
        txtCodtuto.Text = dgvRecursosHumanos.CurrentRow.Cells(2).Value
        nudMetododE.Value = dgvRecursosHumanos.CurrentRow.Cells(3).Value
        nudTiempoeficaz.Value = dgvRecursosHumanos.CurrentRow.Cells(4).Value
        nudResoludD.Value = dgvRecursosHumanos.CurrentRow.Cells(5).Value
        nudRespetuo.Value = dgvRecursosHumanos.CurrentRow.Cells(6).Value
        nudConfianza.Value = dgvRecursosHumanos.CurrentRow.Cells(7).Value
        nudComprensiondC.Value = dgvRecursosHumanos.CurrentRow.Cells(8).Value
        nudPrepa.Value = dgvRecursosHumanos.CurrentRow.Cells(9).Value
        btnAgregar.Enabled = False

    End Sub

    Private Sub EvaluacionesRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

        txtCodtuto.Clear()
        txtCodEvalua.Clear()
        nudMetododE.Value = 1
        nudTiempoeficaz.Value = 1
        nudResoludD.Value = 1
        nudRespetuo.Value = 1
        nudConfianza.Value = 1
        nudComprensiondC.Value = 1
        nudPrepa.Value = 1
    End Sub
End Class