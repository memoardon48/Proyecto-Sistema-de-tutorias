Imports System.Data.SqlClient
Public Class PagosRRHH


    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT F.codTutoria, T.codTutor, F.Total FROM Factura F INNER JOIN Tutoria T ON F.codTutoria = T.codTutoria WHERE T.pagadaTutor = 'NO'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        Dvgtutorias.DataSource = mostrar2
        conectar.Close()


    End Sub


    Private Sub PagosRRHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Pagos"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using
        dgvPagos.DataSource = mostrar2
        conectar.Close()

        btnAgregar.Enabled = True



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcodtutor.TextChanged
        If (txtcodtutor.Text = String.Empty) Then
            txtporcentaje.Text = " "

        Else

            conectar.Open()


            Dim consulta As String = "SELECT porcentaje FROM Tutor WHERE codTutor = " & txtcodtutor.Text
            Dim recuperar As SqlDataReader

            Dim ejecutar As New SqlCommand
            ejecutar = New SqlCommand(consulta, conectar)
            recuperar = ejecutar.ExecuteReader()

            If (recuperar.Read() = True) Then
                txtporcentaje.Text = recuperar(0)
            Else
                txtporcentaje.Text = " "

            End If
            conectar.Close()
        End If



    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtcodtutor.Text = String.Empty Or txtcodtutoria.Text = String.Empty Or txtTotalFac.Text = String.Empty Or txtporcentaje.Text = String.Empty Or txtcantidad.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim agregar As String = "INSERT INTO Pagos (codTutor,codTutoria,monto, fechaPago)  VALUES(@codTutor,@codTutoria,@monto, GETDATE())"
            Dim agregar2 As New SqlCommand(agregar, conectar)

            agregar2.Parameters.AddWithValue("@codTutor", txtcodtutor.Text)
            agregar2.Parameters.AddWithValue("@codTutoria", txtcodtutoria.Text)
            agregar2.Parameters.AddWithValue("@monto", txtcantidad.Text)
            agregar2.ExecuteNonQuery()

            Dim update As String = "UPDATE Tutoria SET pagadaTutor = 'SI' WHERE codTutoria = @codTutoria"
            Dim update2 As New SqlCommand(update, conectar)
            update2.Parameters.AddWithValue("@codTutoria", txtcodtutoria.Text)
            update2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()

            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvPagos.Rows.Count
            codigo = dgvPagos.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Pagos', 'PagosRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar Pago (" & txtcantidad.Text & ")")
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()

            conectar.Open()
            Dim mostrar As String = "SELECT * FROM Pagos"
            Dim mostrar2 As New DataTable

            Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                ejecutar.Fill(mostrar2)
            End Using
            dgvPagos.DataSource = mostrar2
            conectar.Close()

            txtcantidad.Clear()
            txtCodPago.Clear()
            txtcodtutor.Clear()
            txtcodtutoria.Clear()
            txtporcentaje.Clear()
            txtTotalFac.Clear()
            btnAgregar.Enabled = False
        End If


    End Sub

    Private Sub Btneliminar_Click(sender As Object, e As EventArgs) Handles Btneliminar.Click
        If (txtCodPago.Text = String.Empty Or txtcodtutor.Text = String.Empty Or txtcodtutoria.Text = String.Empty Or txtporcentaje.Text = String.Empty Or txtcantidad.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim eliminar As String = "DELETE FROM Pagos WHERE codPago = @codPago"
            Dim eliminar2 As New SqlCommand(eliminar, conectar)
            eliminar2.Parameters.AddWithValue("@codPago", txtCodPago.Text)
            eliminar2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            conectar.Open()
            Dim mostrar As String = "SELECT * FROM Pagos"
            Dim mostrar2 As New DataTable

            Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                ejecutar.Fill(mostrar2)
            End Using
            dgvPagos.DataSource = mostrar2

            Dim update As String = "UPDATE Tutoria SET pagadaTutor = 'NO' WHERE codTutoria = @codTutoria"
            Dim update2 As New SqlCommand(update, conectar)
            update2.Parameters.AddWithValue("@codTutoria", txtcodtutoria.Text)
            update2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Pagos', 'PagosRRHH', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Eliminar Pago (" & txtcantidad.Text & ")")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodPago.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            txtcantidad.Clear()
            txtCodPago.Clear()
            txtcodtutor.Clear()
            txtcodtutoria.Clear()
            txtporcentaje.Clear()
            txtTotalFac.Clear()

        End If


    End Sub

    Private Sub Dvgtutorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dvgtutorias.CellContentClick

    End Sub

    Private Sub Dvgtutorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dvgtutorias.CellDoubleClick

        txtcodtutoria.Text = Dvgtutorias.CurrentRow.Cells(0).Value
        txtcodtutor.Text = Dvgtutorias.CurrentRow.Cells(1).Value
        txtTotalFac.Text = Dvgtutorias.CurrentRow.Cells(2).Value
        btnAgregar.Enabled = False

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        btnCalcular.Enabled = True
        txtcantidad.Text = Val(txtporcentaje.Text) * Val(txtTotalFac.Text)
        btnAgregar.Enabled = True
    End Sub

    Private Sub dgvPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagos.CellContentClick

    End Sub

    Private Sub dgvPagos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPagos.CellDoubleClick
        txtCodPago.Text = dgvPagos.CurrentRow.Cells(0).Value
        txtcodtutor.Text = dgvPagos.CurrentRow.Cells(1).Value
        txtcodtutoria.Text = dgvPagos.CurrentRow.Cells(2).Value
        txtcantidad.Text = dgvPagos.CurrentRow.Cells(3).Value
    End Sub
End Class