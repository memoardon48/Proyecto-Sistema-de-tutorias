﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteFactura
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSis = New Proyecto_Final.DataSis()
        Me.Select_FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_FacturaTableAdapter = New Proyecto_Final.DataSisTableAdapters.Select_FacturaTableAdapter()
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Select_FacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Final.ReportFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(727, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSis
        '
        Me.DataSis.DataSetName = "DataSis"
        Me.DataSis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_FacturaBindingSource
        '
        Me.Select_FacturaBindingSource.DataMember = "Select_Factura"
        Me.Select_FacturaBindingSource.DataSource = Me.DataSis
        '
        'Select_FacturaTableAdapter
        '
        Me.Select_FacturaTableAdapter.ClearBeforeFill = True
        '
        'ReporteFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteFactura"
        Me.Text = "ReporteFactura"
        CType(Me.DataSis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Select_FacturaBindingSource As BindingSource
    Friend WithEvents DataSis As DataSis
    Friend WithEvents Select_FacturaTableAdapter As DataSisTableAdapters.Select_FacturaTableAdapter
End Class
