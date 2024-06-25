<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceGenereal
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
        Me.dgvfacturas = New System.Windows.Forms.DataGridView()
        Me.txtIngresos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEgresos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigoB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPatrimonio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPasivosNC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPasivosCo = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtActivosNC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtActivosC = New System.Windows.Forms.TextBox()
        Me.dgvbalancegen = New System.Windows.Forms.DataGridView()
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvbalancegen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvfacturas
        '
        Me.dgvfacturas.AllowUserToAddRows = False
        Me.dgvfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfacturas.Location = New System.Drawing.Point(27, 110)
        Me.dgvfacturas.Name = "dgvfacturas"
        Me.dgvfacturas.Size = New System.Drawing.Size(541, 250)
        Me.dgvfacturas.TabIndex = 60
        '
        'txtIngresos
        '
        Me.txtIngresos.Enabled = False
        Me.txtIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresos.Location = New System.Drawing.Point(295, 27)
        Me.txtIngresos.Name = "txtIngresos"
        Me.txtIngresos.Size = New System.Drawing.Size(273, 40)
        Me.txtIngresos.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 33)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Total Ingresos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(282, 33)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Facturas registradas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(610, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 33)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Pagos Tutores"
        '
        'txtEgresos
        '
        Me.txtEgresos.Enabled = False
        Me.txtEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEgresos.Location = New System.Drawing.Point(874, 27)
        Me.txtEgresos.Name = "txtEgresos"
        Me.txtEgresos.Size = New System.Drawing.Size(273, 40)
        Me.txtEgresos.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(610, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(195, 33)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Total Egresos"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Location = New System.Drawing.Point(606, 110)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.Size = New System.Drawing.Size(541, 250)
        Me.dgvPagos.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.txtCodigoB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPatrimonio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPasivosNC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPasivosCo)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtActivosNC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtActivosC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 320)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BALANCE GENERAL"
        '
        'txtCodigoB
        '
        Me.txtCodigoB.Enabled = False
        Me.txtCodigoB.Location = New System.Drawing.Point(212, 22)
        Me.txtCodigoB.Name = "txtCodigoB"
        Me.txtCodigoB.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigoB.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 16)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Codigo de Balance"
        '
        'txtPatrimonio
        '
        Me.txtPatrimonio.Location = New System.Drawing.Point(212, 214)
        Me.txtPatrimonio.Name = "txtPatrimonio"
        Me.txtPatrimonio.Size = New System.Drawing.Size(100, 22)
        Me.txtPatrimonio.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Patrimonio"
        '
        'txtPasivosNC
        '
        Me.txtPasivosNC.Location = New System.Drawing.Point(212, 173)
        Me.txtPasivosNC.Name = "txtPasivosNC"
        Me.txtPasivosNC.Size = New System.Drawing.Size(100, 22)
        Me.txtPasivosNC.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Pasivos No Corrientes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Pasivos Corrientes"
        '
        'txtPasivosCo
        '
        Me.txtPasivosCo.Location = New System.Drawing.Point(212, 140)
        Me.txtPasivosCo.Name = "txtPasivosCo"
        Me.txtPasivosCo.Size = New System.Drawing.Size(100, 22)
        Me.txtPasivosCo.TabIndex = 71
        '
        'btnModificar
        '
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnModificar.Image = Global.Proyecto_Final.My.Resources.Resources.edit_icon_icons_com_66118__1_
        Me.btnModificar.Location = New System.Drawing.Point(212, 255)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(159, 55)
        Me.btnModificar.TabIndex = 69
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(30, 255)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(155, 55)
        Me.btnAgregar.TabIndex = 68
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtActivosNC
        '
        Me.txtActivosNC.Location = New System.Drawing.Point(212, 99)
        Me.txtActivosNC.Name = "txtActivosNC"
        Me.txtActivosNC.Size = New System.Drawing.Size(100, 22)
        Me.txtActivosNC.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Activos No Corrientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Activos Corrientes"
        '
        'txtActivosC
        '
        Me.txtActivosC.Location = New System.Drawing.Point(212, 60)
        Me.txtActivosC.Name = "txtActivosC"
        Me.txtActivosC.Size = New System.Drawing.Size(100, 22)
        Me.txtActivosC.TabIndex = 65
        '
        'dgvbalancegen
        '
        Me.dgvbalancegen.AllowUserToAddRows = False
        Me.dgvbalancegen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbalancegen.Location = New System.Drawing.Point(476, 423)
        Me.dgvbalancegen.Name = "dgvbalancegen"
        Me.dgvbalancegen.Size = New System.Drawing.Size(657, 250)
        Me.dgvbalancegen.TabIndex = 73
        '
        'BalanceGenereal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1188, 716)
        Me.Controls.Add(Me.dgvbalancegen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEgresos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIngresos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvfacturas)
        Me.Name = "BalanceGenereal"
        Me.Text = "BalanceGenereal"
        CType(Me.dgvfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvbalancegen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvfacturas As DataGridView
    Friend WithEvents txtIngresos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEgresos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvbalancegen As DataGridView
    Friend WithEvents txtCodigoB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPatrimonio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPasivosNC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPasivosCo As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtActivosNC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtActivosC As TextBox
End Class
