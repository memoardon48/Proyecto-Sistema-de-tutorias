Imports System.Data.SqlClient
Public Class BalanceGenereal
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM BalanceGeneral"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvbalancegen.DataSource = mostrar2
        conectar.Close()


    End Sub

    Private Sub BalanceGneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ingresos As Double = 0
        Dim egresos As Double = 0
        Dim i As Integer

        cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Pagos"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using
        dgvPagos.DataSource = mostrar2

        Dim mostrarFac As String = "SELECT * FROM Factura"
        Dim mostrarFac2 As New DataTable

        Using ejecutar2 As New SqlDataAdapter(mostrarFac, conectar)
            ejecutar2.Fill(mostrarFac2)
        End Using
        dgvfacturas.DataSource = mostrarFac2

        conectar.Close()

        For i = 0 To (dgvPagos.Rows.Count - 1) Step 1
            egresos += Val(dgvPagos.Rows(i).Cells(3).Value)
        Next

        For i = 0 To (dgvfacturas.Rows.Count - 1) Step 1
            ingresos += Val(dgvfacturas.Rows(i).Cells(2).Value)
        Next

        txtEgresos.Text = egresos
        txtIngresos.Text = ingresos


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtActivosC.Text = String.Empty Or txtActivosNC.Text = String.Empty Or txtPasivosCo.Text = String.Empty Or txtPasivosNC.Text = String.Empty Or txtPatrimonio.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If (validarNumero(txtActivosC.Text) And validarNumero(txtActivosNC.Text) And validarNumero(txtPasivosCo.Text) And validarNumero(txtPasivosNC.Text) And validarNumero(txtPatrimonio.Text)) Then
                conectar.Open()

                Dim agregar As String = "INSERT INTO BalanceGeneral (activosCorrientes,activosNoCorrientes,pasivosCorrientes,pasivosNoCorrientes,patrimonio, fecha)  VALUES(@activosCorrientes,@activosNoCorrientes,@pasivosCorrientes,@pasivosNoCorrientes,@patrimonio, GETDATE())"
                Dim agregar2 As New SqlCommand(agregar, conectar)

                agregar2.Parameters.AddWithValue("@activosCorrientes", txtActivosC.Text)
                agregar2.Parameters.AddWithValue("@activosNoCorrientes", txtActivosNC.Text)
                agregar2.Parameters.AddWithValue("@pasivosCorrientes", txtPasivosCo.Text)
                agregar2.Parameters.AddWithValue("@pasivosNoCorrientes", txtPasivosNC.Text)
                agregar2.Parameters.AddWithValue("@patrimonio", txtPatrimonio.Text)
                agregar2.ExecuteNonQuery()
                conectar.Close()
                cargarDatos()
                conectar.Open()
                Dim codigo As String
                Dim filas As Integer
                filas = dgvbalancegen.Rows.Count
                codigo = dgvbalancegen.Rows(filas - 1).Cells(0).Value
                Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'BalanceGeneral', 'BalanceGeneral', @codRegistro, GETDATE())"
                Dim audi2 As New SqlCommand(audi, conectar)
                audi2.Parameters.AddWithValue("@userName", user)
                audi2.Parameters.AddWithValue("@accion", "Insertar Balance General")
                audi2.Parameters.AddWithValue("@codRegistro", codigo)
                audi2.ExecuteNonQuery()
                conectar.Close()


            Else
                MessageBox.Show("Ingrese valores correctos en los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


            txtCodigoB.Clear()
            txtActivosC.Clear()
            txtActivosC.Clear()
            txtActivosNC.Clear()
            txtPasivosCo.Clear()
            txtPasivosNC.Clear()
            txtPatrimonio.Clear()
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtActivosC.Text = String.Empty Or txtActivosNC.Text = String.Empty Or txtPasivosCo.Text = String.Empty Or txtPasivosNC.Text = String.Empty Or txtPatrimonio.Text = String.Empty Or txtCodigoB.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If (validarNumero(txtActivosC.Text) And validarNumero(txtActivosNC.Text) And validarNumero(txtPasivosCo.Text) And validarNumero(txtPasivosNC.Text) And validarNumero(txtPatrimonio.Text)) Then
                conectar.Open()
                Dim modificarC As String = "UPDATE BalanceGeneral SET activosCorrientes = @activosCorrientes,activosNoCorrientes= @activosNoCorrientes,pasivosCorrientes=@pasivosCorrientes,pasivosNoCorrientes=@pasivosNoCorrientes,patrimonio=@patrimonio WHERE codBalance =@codBalance"
                Dim modificarC2 As New SqlCommand(modificarC, conectar)

                modificarC2.Parameters.AddWithValue("@codBalance", Val(txtCodigoB.Text))
                modificarC2.Parameters.AddWithValue("@activosCorrientes", Val(txtActivosC.Text))
                modificarC2.Parameters.AddWithValue("@activosNoCorrientes", Val(txtActivosNC.Text))
                modificarC2.Parameters.AddWithValue("@pasivosCorrientes", Val(txtPasivosCo.Text))
                modificarC2.Parameters.AddWithValue("@pasivosNoCorrientes", Val(txtPasivosNC.Text))
                modificarC2.Parameters.AddWithValue("@patrimonio", Val(txtPatrimonio.Text))
                modificarC2.ExecuteNonQuery()

                Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'BalanceGeneral', 'BalanceGeneral', @codRegistro, GETDATE())"
                Dim audi2 As New SqlCommand(audi, conectar)
                audi2.Parameters.AddWithValue("@userName", user)
                audi2.Parameters.AddWithValue("@accion", "Modificar Balance General")
                audi2.Parameters.AddWithValue("@codRegistro", txtCodigoB.Text)
                audi2.ExecuteNonQuery()
                conectar.Close()
                cargarDatos()

                txtCodigoB.Clear()
                txtActivosC.Clear()
                txtActivosC.Clear()
                txtActivosNC.Clear()
                txtPasivosCo.Clear()
                txtPasivosNC.Clear()
                txtPatrimonio.Clear()
                btnAgregar.Enabled = True
            Else
                MessageBox.Show("Ingrese valores correctos en los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub dgvbalancegen_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbalancegen.CellContentClick

    End Sub

    Private Sub dgvbalancegen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbalancegen.CellDoubleClick
        txtCodigoB.Text = dgvbalancegen.CurrentRow.Cells(0).Value
        txtActivosC.Text = dgvbalancegen.CurrentRow.Cells(1).Value
        txtActivosNC.Text = dgvbalancegen.CurrentRow.Cells(2).Value
        txtPasivosCo.Text = dgvbalancegen.CurrentRow.Cells(3).Value
        txtPasivosNC.Text = dgvbalancegen.CurrentRow.Cells(4).Value
        txtPatrimonio.Text = dgvbalancegen.CurrentRow.Cells(5).Value
        btnAgregar.Enabled = False

    End Sub

    Function validarNumero(ByVal numero As String)
        Try
            Dim convertido As Double
            convertido = Convert.ToDouble(numero)
            If (convertido >= 0) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
End Class