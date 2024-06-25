Imports System.Data.SqlClient
Public Class Marketing
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM DatosMarketing"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvmarketing.DataSource = mostrar2
        conectar.Close()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtcodclase.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim agregar As String = "INSERT INTO DatosMarketing (Muestra,codClase,horario,redSocial,precioComun,Universidad,Fecha)  VALUES(@muestra,@codclase,@horario,@redsocial,@preciocomun,@universidad,@fecha)"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@muestra", nupmuestra.Text)
            agregar2.Parameters.AddWithValue("@codclase", txtcodclase.Text)
            agregar2.Parameters.AddWithValue("@horario", cbhorario.Text)
            agregar2.Parameters.AddWithValue("@redsocial", cbredsocial.Text)
            agregar2.Parameters.AddWithValue("@preciocomun", cbpreciocomun.Text)
            agregar2.Parameters.AddWithValue("@universidad", cbuniversidad.Text)
            agregar2.Parameters.AddWithValue("@fecha", dtpfecha.Value)
            agregar2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvmarketing.Rows.Count
            codigo = dgvmarketing.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'DatosMarketing', 'Marketing', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar Resultados Encuesta")
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()


            txtcodclase.Clear()
            nupmuestra.Value = 25
            cbuniversidad.SelectedIndex = 0
            cbhorario.SelectedIndex = 0
            cbredsocial.SelectedIndex = 0
            cbpreciocomun.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtcodclase.Text = String.Empty Or txtcodencuesta.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim modificar As String = "UPDATE DatosMarketing SET Muestra=@muestra, codClase = @codclase,horario = @horario,redSocial = @redsocial,precioComun = @preciocomun,Universidad = @universidad,Fecha = @fecha WHERE codEncuesta = @codEncuesta"
            Dim modificar2 As New SqlCommand(modificar, conectar)
            modificar2.Parameters.AddWithValue("@muestra", nupmuestra.Text)
            modificar2.Parameters.AddWithValue("@codclase", txtcodclase.Text)
            modificar2.Parameters.AddWithValue("@horario", cbhorario.Text)
            modificar2.Parameters.AddWithValue("@redsocial", cbredsocial.Text)
            modificar2.Parameters.AddWithValue("@preciocomun", cbpreciocomun.Text)
            modificar2.Parameters.AddWithValue("@universidad", cbuniversidad.Text)
            modificar2.Parameters.AddWithValue("@fecha", dtpfecha.Value)
            modificar2.Parameters.AddWithValue("@codEncuesta", txtcodencuesta.Text)
            modificar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'DatosMarketing', 'Marketing', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar Resultados Encuesta")
            audi2.Parameters.AddWithValue("@codRegistro", txtcodencuesta.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()
            txtcodclase.Clear()
            txtcodencuesta.Clear()
            btnAgregar.Enabled = True

        End If

    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        If (txtcodclase.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor para el campo del código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim eliminar As String = "DELETE FROM DatosMarketing WHERE codEncuesta = @codEncuesta"
            Dim eliminar2 As New SqlCommand(eliminar, conectar)
            eliminar2.Parameters.AddWithValue("@codEncuesta", txtcodencuesta.Text)
            eliminar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'DatosMarketing', 'Marketing', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Eliminar Resultados Encuesta")
            audi2.Parameters.AddWithValue("@codRegistro", txtcodencuesta.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()
            txtcodencuesta.Clear()
            txtcodclase.Clear()
            btnAgregar.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmBuscarClase.Show()
    End Sub

    Private Sub Marketing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbuniversidad.Items.Add("UNICAH")
        cbuniversidad.Items.Add("UNITEC")
        cbuniversidad.Items.Add("UNAH")
        cbuniversidad.Items.Add("CEUTEC")
        cbuniversidad.Items.Add("UTH")


        cbhorario.Items.Add("Tarde")
        cbhorario.Items.Add("Noche")
        cbhorario.Items.Add("Mañana")

        cbredsocial.Items.Add("WhatsApp")
        cbredsocial.Items.Add("Instagram")
        cbredsocial.Items.Add("Facebook")
        cbredsocial.Items.Add("Telegram")
        cbredsocial.Items.Add("Snapchat")

        cbpreciocomun.Items.Add("Lps.180 - Lps.200")
        cbpreciocomun.Items.Add("Lps.201 - Lps.250")
        cbpreciocomun.Items.Add("Lps.251 - Lps.300")
        cbpreciocomun.Items.Add("Lps.301 - Lps.350")
        cbpreciocomun.Items.Add("Lps.351 en adelante")

        cbuniversidad.SelectedIndex = 0
        cbhorario.SelectedIndex = 0
        cbredsocial.SelectedIndex = 0
        cbpreciocomun.SelectedIndex = 0

        cargarDatos()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbuniversidad.SelectedIndexChanged

    End Sub

    Private Sub dgvmarketing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmarketing.CellContentClick

    End Sub

    Private Sub dgvmarketing_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmarketing.CellDoubleClick
        txtcodencuesta.Text = dgvmarketing.CurrentRow.Cells(0).Value
        nupmuestra.Value = dgvmarketing.CurrentRow.Cells(1).Value
        txtcodclase.Text = dgvmarketing.CurrentRow.Cells(2).Value
        cbhorario.SelectedItem = dgvmarketing.CurrentRow.Cells(3).Value
        cbredsocial.SelectedItem = dgvmarketing.CurrentRow.Cells(4).Value
        cbpreciocomun.SelectedItem = dgvmarketing.CurrentRow.Cells(5).Value
        cbuniversidad.SelectedItem = dgvmarketing.CurrentRow.Cells(6).Value
        dtpfecha.Value = dgvmarketing.CurrentRow.Cells(7).Value
        btnAgregar.Enabled = False
    End Sub
End Class