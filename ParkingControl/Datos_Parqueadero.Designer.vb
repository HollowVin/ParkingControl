<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Datos_Parqueadero
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
        Me.DNameLabel = New System.Windows.Forms.Label()
        Me.DFare1Label = New System.Windows.Forms.Label()
        Me.DFare2Label = New System.Windows.Forms.Label()
        Me.DFare4Label = New System.Windows.Forms.Label()
        Me.DCapacityLabel = New System.Windows.Forms.Label()
        Me.DAddressLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DFare1TextBox = New System.Windows.Forms.TextBox()
        Me.DFare2TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DFare4TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.DSaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DNameLabel
        '
        Me.DNameLabel.AutoSize = True
        Me.DNameLabel.Location = New System.Drawing.Point(42, 39)
        Me.DNameLabel.Name = "DNameLabel"
        Me.DNameLabel.Size = New System.Drawing.Size(62, 17)
        Me.DNameLabel.TabIndex = 0
        Me.DNameLabel.Text = "Nombre:"
        '
        'DFare1Label
        '
        Me.DFare1Label.AutoSize = True
        Me.DFare1Label.Location = New System.Drawing.Point(432, 183)
        Me.DFare1Label.Name = "DFare1Label"
        Me.DFare1Label.Size = New System.Drawing.Size(94, 17)
        Me.DFare1Label.TabIndex = 4
        Me.DFare1Label.Text = "Tarifa 1 hora:"
        '
        'DFare2Label
        '
        Me.DFare2Label.AutoSize = True
        Me.DFare2Label.Location = New System.Drawing.Point(432, 112)
        Me.DFare2Label.Name = "DFare2Label"
        Me.DFare2Label.Size = New System.Drawing.Size(106, 17)
        Me.DFare2Label.TabIndex = 5
        Me.DFare2Label.Text = "Tarifa 1/2 hora:"
        '
        'DFare4Label
        '
        Me.DFare4Label.AutoSize = True
        Me.DFare4Label.Location = New System.Drawing.Point(432, 41)
        Me.DFare4Label.Name = "DFare4Label"
        Me.DFare4Label.Size = New System.Drawing.Size(106, 17)
        Me.DFare4Label.TabIndex = 6
        Me.DFare4Label.Text = "Tarifa 1/4 hora:"
        '
        'DCapacityLabel
        '
        Me.DCapacityLabel.AutoSize = True
        Me.DCapacityLabel.Location = New System.Drawing.Point(42, 183)
        Me.DCapacityLabel.Name = "DCapacityLabel"
        Me.DCapacityLabel.Size = New System.Drawing.Size(79, 17)
        Me.DCapacityLabel.TabIndex = 7
        Me.DCapacityLabel.Text = "Capacidad:"
        '
        'DAddressLabel
        '
        Me.DAddressLabel.AutoSize = True
        Me.DAddressLabel.Location = New System.Drawing.Point(42, 110)
        Me.DAddressLabel.Name = "DAddressLabel"
        Me.DAddressLabel.Size = New System.Drawing.Size(71, 17)
        Me.DAddressLabel.TabIndex = 8
        Me.DAddressLabel.Text = "Direccion:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 22)
        Me.TextBox1.TabIndex = 10
        '
        'DFare1TextBox
        '
        Me.DFare1TextBox.Location = New System.Drawing.Point(554, 178)
        Me.DFare1TextBox.Name = "DFare1TextBox"
        Me.DFare1TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare1TextBox.TabIndex = 13
        '
        'DFare2TextBox
        '
        Me.DFare2TextBox.Location = New System.Drawing.Point(554, 105)
        Me.DFare2TextBox.Name = "DFare2TextBox"
        Me.DFare2TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare2TextBox.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(140, 178)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(112, 22)
        Me.TextBox6.TabIndex = 15
        '
        'DFare4TextBox
        '
        Me.DFare4TextBox.Location = New System.Drawing.Point(554, 34)
        Me.DFare4TextBox.Name = "DFare4TextBox"
        Me.DFare4TextBox.Size = New System.Drawing.Size(100, 22)
        Me.DFare4TextBox.TabIndex = 16
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(140, 105)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(246, 22)
        Me.TextBox8.TabIndex = 17
        '
        'DSaveButton
        '
        Me.DSaveButton.Location = New System.Drawing.Point(311, 277)
        Me.DSaveButton.Name = "DSaveButton"
        Me.DSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.DSaveButton.TabIndex = 18
        Me.DSaveButton.Text = "Guardar"
        Me.DSaveButton.UseVisualStyleBackColor = True
        '
        'Datos_Parqueadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 336)
        Me.Controls.Add(Me.DSaveButton)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.DFare4TextBox)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.DFare2TextBox)
        Me.Controls.Add(Me.DFare1TextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DAddressLabel)
        Me.Controls.Add(Me.DCapacityLabel)
        Me.Controls.Add(Me.DFare4Label)
        Me.Controls.Add(Me.DFare2Label)
        Me.Controls.Add(Me.DFare1Label)
        Me.Controls.Add(Me.DNameLabel)
        Me.Name = "Datos_Parqueadero"
        Me.Text = "Datos_Parqueadero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DNameLabel As Label
    Friend WithEvents DFare1Label As Label
    Friend WithEvents DFare2Label As Label
    Friend WithEvents DFare4Label As Label
    Friend WithEvents DCapacityLabel As Label
    Friend WithEvents DAddressLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DFare1TextBox As TextBox
    Friend WithEvents DFare2TextBox As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DFare4TextBox As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DSaveButton As Button
End Class
