<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PorcentajesRRHH
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
        Me.dgvporcentahetutores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodTutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nupPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvporcentahetutores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvporcentahetutores
        '
        Me.dgvporcentahetutores.AllowUserToAddRows = False
        Me.dgvporcentahetutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvporcentahetutores.Location = New System.Drawing.Point(286, 36)
        Me.dgvporcentahetutores.Name = "dgvporcentahetutores"
        Me.dgvporcentahetutores.Size = New System.Drawing.Size(487, 376)
        Me.dgvporcentahetutores.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod tutor"
        '
        'txtCodTutor
        '
        Me.txtCodTutor.Enabled = False
        Me.txtCodTutor.Location = New System.Drawing.Point(96, 68)
        Me.txtCodTutor.Name = "txtCodTutor"
        Me.txtCodTutor.Size = New System.Drawing.Size(153, 20)
        Me.txtCodTutor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Porcentaje"
        '
        'nupPorcentaje
        '
        Me.nupPorcentaje.DecimalPlaces = 2
        Me.nupPorcentaje.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nupPorcentaje.Location = New System.Drawing.Point(96, 119)
        Me.nupPorcentaje.Maximum = New Decimal(New Integer() {80, 0, 0, 131072})
        Me.nupPorcentaje.Minimum = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.nupPorcentaje.Name = "nupPorcentaje"
        Me.nupPorcentaje.Size = New System.Drawing.Size(120, 20)
        Me.nupPorcentaje.TabIndex = 4
        Me.nupPorcentaje.Value = New Decimal(New Integer() {50, 0, 0, 131072})
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Proyecto_Final.My.Resources.Resources.add_icon_icons_com_74429__1_
        Me.btnAgregar.Location = New System.Drawing.Point(48, 180)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(156, 57)
        Me.btnAgregar.TabIndex = 48
        Me.btnAgregar.Text = "Colocar monto"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'PorcentajesRRHH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.nupPorcentaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodTutor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvporcentahetutores)
        Me.Name = "PorcentajesRRHH"
        Me.Text = "PorcentajesRRHH"
        CType(Me.dgvporcentahetutores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvporcentahetutores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodTutor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nupPorcentaje As NumericUpDown
    Friend WithEvents btnAgregar As Button
End Class
