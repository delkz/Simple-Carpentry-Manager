<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelatorioPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RelatorioPedido))
        Me.PedidoTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcenariaDataSet = New Simple_Carpentry_Manager.MarcenariaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PedidoTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter()
        Me.ClienteTabelaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTabelaTableAdapter = New Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter()
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PedidoTabelaBindingSource
        '
        Me.PedidoTabelaBindingSource.DataMember = "PedidoTabela"
        Me.PedidoTabelaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'MarcenariaDataSet
        '
        Me.MarcenariaDataSet.DataSetName = "MarcenariaDataSet"
        Me.MarcenariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PedidoTabelaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Simple_Carpentry_Manager.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(534, 487)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.UseWaitCursor = True
        '
        'PedidoTabelaTableAdapter
        '
        Me.PedidoTabelaTableAdapter.ClearBeforeFill = True
        '
        'ClienteTabelaBindingSource
        '
        Me.ClienteTabelaBindingSource.DataMember = "ClienteTabela"
        Me.ClienteTabelaBindingSource.DataSource = Me.MarcenariaDataSet
        '
        'ClienteTabelaTableAdapter
        '
        Me.ClienteTabelaTableAdapter.ClearBeforeFill = True
        '
        'RelatorioPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 487)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RelatorioPedido"
        Me.Text = "Relatorio de Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PedidoTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcenariaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteTabelaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PedidoTabelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcenariaDataSet As Simple_Carpentry_Manager.MarcenariaDataSet
    Friend WithEvents PedidoTabelaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.PedidoTabelaTableAdapter
    Friend WithEvents ClienteTabelaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTabelaTableAdapter As Simple_Carpentry_Manager.MarcenariaDataSetTableAdapters.ClienteTabelaTableAdapter
End Class
