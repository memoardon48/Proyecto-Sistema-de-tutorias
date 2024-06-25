<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gerencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gerencia))
        Me.btninformedemercado = New System.Windows.Forms.Button()
        Me.btndesempeño = New System.Windows.Forms.Button()
        Me.btnrfinanciero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btninformedemercado
        '
        Me.btninformedemercado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninformedemercado.Image = CType(resources.GetObject("btninformedemercado.Image"), System.Drawing.Image)
        Me.btninformedemercado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btninformedemercado.Location = New System.Drawing.Point(184, 209)
        Me.btninformedemercado.Margin = New System.Windows.Forms.Padding(2)
        Me.btninformedemercado.Name = "btninformedemercado"
        Me.btninformedemercado.Size = New System.Drawing.Size(215, 51)
        Me.btninformedemercado.TabIndex = 2
        Me.btninformedemercado.Text = "Informe estudio de Mercado"
        Me.btninformedemercado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btninformedemercado.UseVisualStyleBackColor = True
        '
        'btndesempeño
        '
        Me.btndesempeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndesempeño.Image = CType(resources.GetObject("btndesempeño.Image"), System.Drawing.Image)
        Me.btndesempeño.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndesempeño.Location = New System.Drawing.Point(340, 95)
        Me.btndesempeño.Margin = New System.Windows.Forms.Padding(2)
        Me.btndesempeño.Name = "btndesempeño"
        Me.btndesempeño.Size = New System.Drawing.Size(192, 51)
        Me.btndesempeño.TabIndex = 1
        Me.btndesempeño.Text = "Desempeño de Empleado"
        Me.btndesempeño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndesempeño.UseVisualStyleBackColor = True
        '
        'btnrfinanciero
        '
        Me.btnrfinanciero.AutoEllipsis = True
        Me.btnrfinanciero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrfinanciero.Image = CType(resources.GetObject("btnrfinanciero.Image"), System.Drawing.Image)
        Me.btnrfinanciero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrfinanciero.Location = New System.Drawing.Point(52, 95)
        Me.btnrfinanciero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnrfinanciero.Name = "btnrfinanciero"
        Me.btnrfinanciero.Size = New System.Drawing.Size(218, 51)
        Me.btnrfinanciero.TabIndex = 0
        Me.btnrfinanciero.Text = "Reporte Financiero"
        Me.btnrfinanciero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrfinanciero.UseVisualStyleBackColor = True
        '
        'gerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btninformedemercado)
        Me.Controls.Add(Me.btndesempeño)
        Me.Controls.Add(Me.btnrfinanciero)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "gerencia"
        Me.Text = "gerencia"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnrfinanciero As Button
    Friend WithEvents btndesempeño As Button
    Friend WithEvents btninformedemercado As Button
End Class
