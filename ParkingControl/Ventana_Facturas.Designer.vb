<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_Facturas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TablaFacturas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comebackbutton = New System.Windows.Forms.Button()
        CType(Me.TablaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaFacturas
        '
        Me.TablaFacturas.AllowUserToAddRows = False
        Me.TablaFacturas.AllowUserToDeleteRows = False
        Me.TablaFacturas.AllowUserToOrderColumns = True
        Me.TablaFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.TablaFacturas.Location = New System.Drawing.Point(1, 0)
        Me.TablaFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.TablaFacturas.MultiSelect = False
        Me.TablaFacturas.Name = "TablaFacturas"
        Me.TablaFacturas.ReadOnly = True
        Me.TablaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaFacturas.Size = New System.Drawing.Size(798, 356)
        Me.TablaFacturas.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Numero"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "CI"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Comebackbutton
        '
        Me.Comebackbutton.Location = New System.Drawing.Point(356, 392)
        Me.Comebackbutton.Name = "Comebackbutton"
        Me.Comebackbutton.Size = New System.Drawing.Size(75, 23)
        Me.Comebackbutton.TabIndex = 15
        Me.Comebackbutton.Text = "Regresar"
        Me.Comebackbutton.UseVisualStyleBackColor = True
        '
        'Ventana_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Comebackbutton)
        Me.Controls.Add(Me.TablaFacturas)
        Me.Name = "Ventana_Facturas"
        Me.Text = "Ventana_Facturas"
        CType(Me.TablaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaFacturas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Comebackbutton As Button
End Class
