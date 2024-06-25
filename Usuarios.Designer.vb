<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMostrarHabilitados = New System.Windows.Forms.Button()
        Me.btnMostrarTod = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnDeshabilitar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(378, 48)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(436, 262)
        Me.dgvUsuarios.TabIndex = 0
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.Enabled = False
        Me.txtCodUsuario.Location = New System.Drawing.Point(154, 68)
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(143, 20)
        Me.txtCodUsuario.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(154, 109)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(143, 20)
        Me.txtUsername.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(154, 152)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(143, 20)
        Me.txtPass.TabIndex = 3
        '
        'cboTipo
        '
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"1 - Ventas", "2 - Contabilidad", "3 - Marketing", "4 - Gerencia", "5 - Recursos Humanos"})
        Me.cboTipo.Location = New System.Drawing.Point(154, 196)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(143, 21)
        Me.cboTipo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Código usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(33, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(36, 253)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 46)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMostrarHabilitados
        '
        Me.btnMostrarHabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarHabilitados.Image = CType(resources.GetObject("btnMostrarHabilitados.Image"), System.Drawing.Image)
        Me.btnMostrarHabilitados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrarHabilitados.Location = New System.Drawing.Point(635, 327)
        Me.btnMostrarHabilitados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarHabilitados.Name = "btnMostrarHabilitados"
        Me.btnMostrarHabilitados.Size = New System.Drawing.Size(176, 48)
        Me.btnMostrarHabilitados.TabIndex = 62
        Me.btnMostrarHabilitados.Text = "Mostrar Habilitados"
        Me.btnMostrarHabilitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrarHabilitados.UseVisualStyleBackColor = True
        '
        'btnMostrarTod
        '
        Me.btnMostrarTod.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTod.Image = CType(resources.GetObject("btnMostrarTod.Image"), System.Drawing.Image)
        Me.btnMostrarTod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMostrarTod.Location = New System.Drawing.Point(378, 327)
        Me.btnMostrarTod.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMostrarTod.Name = "btnMostrarTod"
        Me.btnMostrarTod.Size = New System.Drawing.Size(157, 48)
        Me.btnMostrarTod.TabIndex = 61
        Me.btnMostrarTod.Text = "Mostrar Todo"
        Me.btnMostrarTod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrarTod.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(154, 267)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(132, 20)
        Me.txtBuscar.TabIndex = 60
        '
        'btnDeshabilitar
        '
        Me.btnDeshabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeshabilitar.Image = CType(resources.GetObject("btnDeshabilitar.Image"), System.Drawing.Image)
        Me.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeshabilitar.Location = New System.Drawing.Point(540, 401)
        Me.btnDeshabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeshabilitar.Name = "btnDeshabilitar"
        Me.btnDeshabilitar.Size = New System.Drawing.Size(166, 59)
        Me.btnDeshabilitar.TabIndex = 59
        Me.btnDeshabilitar.Text = "Deshabilitar"
        Me.btnDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeshabilitar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.Location = New System.Drawing.Point(378, 401)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(135, 59)
        Me.btnModificar.TabIndex = 58
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHabilitar.Image = CType(resources.GetObject("btnHabilitar.Image"), System.Drawing.Image)
        Me.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHabilitar.Location = New System.Drawing.Point(213, 401)
        Me.btnHabilitar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(135, 59)
        Me.btnHabilitar.TabIndex = 57
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(41, 401)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(135, 59)
        Me.btnAgregar.TabIndex = 56
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(846, 484)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMostrarHabilitados)
        Me.Controls.Add(Me.btnMostrarTod)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnDeshabilitar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtCodUsuario)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents txtCodUsuario As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBuscar As Button
    Private WithEvents btnMostrarHabilitados As Button
    Friend WithEvents btnMostrarTod As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnDeshabilitar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents btnAgregar As Button
End Class
