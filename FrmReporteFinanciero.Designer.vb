<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteFinanciero
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.Select_BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_BalanceTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_BalanceTableAdapter()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Select_BalanceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportFinanciero.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(68, 96)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(647, 318)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(557, 45)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 23)
        Me.btnMostrar.TabIndex = 9
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Location = New System.Drawing.Point(298, 44)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha2.TabIndex = 8
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Location = New System.Drawing.Point(96, 44)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(185, 20)
        Me.dtpFecha1.TabIndex = 7
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_BalanceBindingSource
        '
        Me.Select_BalanceBindingSource.DataMember = "Select_Balance"
        Me.Select_BalanceBindingSource.DataSource = Me.DataSis
        '
        'Select_BalanceTableAdapter
        '
        Me.Select_BalanceTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteFinanciero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmReporteFinanciero"
        Me.Text = "FrmReporteFinanciero"
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnMostrar As Button
    Friend WithEvents dtpFecha2 As DateTimePicker
    Friend WithEvents dtpFecha1 As DateTimePicker
    Friend WithEvents Select_BalanceBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents Select_BalanceTableAdapter As DataSisTableAdapters.Select_BalanceTableAdapter
End Class
