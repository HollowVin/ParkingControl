<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Parqueadero
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
        Me.PNameLabel = New System.Windows.Forms.Label()
        Me.PAddresLabel = New System.Windows.Forms.Label()
        Me.PCapacityLabel = New System.Windows.Forms.Label()
        Me.PFare4Label = New System.Windows.Forms.Label()
        Me.PFare2Label = New System.Windows.Forms.Label()
        Me.PFare1Label = New System.Windows.Forms.Label()
        Me.PNameTextBox = New System.Windows.Forms.TextBox()
        Me.PAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PCapacityTextBox = New System.Windows.Forms.TextBox()
        Me.PFare4TextBox = New System.Windows.Forms.TextBox()
        Me.PFare2TextBox = New System.Windows.Forms.TextBox()
        Me.PFare1TextBox = New System.Windows.Forms.TextBox()
        Me.PSaveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PNameLabel
        '
        Me.PNameLabel.AutoSize = True
        Me.PNameLabel.Location = New System.Drawing.Point(49, 43)
        Me.PNameLabel.Name = "PNameLabel"
        Me.PNameLabel.Size = New System.Drawing.Size(62, 17)
        Me.PNameLabel.TabIndex = 0
        Me.PNameLabel.Text = "Nombre:"
        '
        'PAddresLabel
        '
        Me.PAddresLabel.AutoSize = True
        Me.PAddresLabel.Location = New System.Drawing.Point(49, 122)
        Me.PAddresLabel.Name = "PAddresLabel"
        Me.PAddresLabel.Size = New System.Drawing.Size(71, 17)
        Me.PAddresLabel.TabIndex = 1
        Me.PAddresLabel.Text = "Direccion:"
        '
        'PCapacityLabel
        '
        Me.PCapacityLabel.AutoSize = True
        Me.PCapacityLabel.Location = New System.Drawing.Point(49, 197)
        Me.PCapacityLabel.Name = "PCapacityLabel"
        Me.PCapacityLabel.Size = New System.Drawing.Size(79, 17)
        Me.PCapacityLabel.TabIndex = 2
        Me.PCapacityLabel.Text = "Capacidad:"
        '
        'PFare4Label
        '
        Me.PFare4Label.AutoSize = True
        Me.PFare4Label.Location = New System.Drawing.Point(420, 45)
        Me.PFare4Label.Name = "PFare4Label"
        Me.PFare4Label.Size = New System.Drawing.Size(106, 17)
        Me.PFare4Label.TabIndex = 3
        Me.PFare4Label.Text = "Tarifa 1/4 hora:"
        '
        'PFare2Label
        '
        Me.PFare2Label.AutoSize = True
        Me.PFare2Label.Location = New System.Drawing.Point(420, 124)
        Me.PFare2Label.Name = "PFare2Label"
        Me.PFare2Label.Size = New System.Drawing.Size(106, 17)
        Me.PFare2Label.TabIndex = 4
        Me.PFare2Label.Text = "Tarifa 1/2 hora:"
        '
        'PFare1Label
        '
        Me.PFare1Label.AutoSize = True
        Me.PFare1Label.Location = New System.Drawing.Point(420, 199)
        Me.PFare1Label.Name = "PFare1Label"
        Me.PFare1Label.Size = New System.Drawing.Size(82, 17)
        Me.PFare1Label.TabIndex = 5
        Me.PFare1Label.Text = "Tarifa hora:"
        '
        'PNameTextBox
        '
        Me.PNameTextBox.Location = New System.Drawing.Point(142, 38)
        Me.PNameTextBox.Name = "PNameTextBox"
        Me.PNameTextBox.Size = New System.Drawing.Size(92, 22)
        Me.PNameTextBox.TabIndex = 6
        '
        'PAddressTextBox
        '
        Me.PAddressTextBox.Location = New System.Drawing.Point(142, 117)
        Me.PAddressTextBox.Name = "PAddressTextBox"
        Me.PAddressTextBox.Size = New System.Drawing.Size(226, 22)
        Me.PAddressTextBox.TabIndex = 7
        '
        'PCapacityTextBox
        '
        Me.PCapacityTextBox.Location = New System.Drawing.Point(142, 194)
        Me.PCapacityTextBox.Name = "PCapacityTextBox"
        Me.PCapacityTextBox.Size = New System.Drawing.Size(92, 22)
        Me.PCapacityTextBox.TabIndex = 8
        '
        'PFare4TextBox
        '
        Me.PFare4TextBox.Location = New System.Drawing.Point(541, 40)
        Me.PFare4TextBox.Name = "PFare4TextBox"
        Me.PFare4TextBox.Size = New System.Drawing.Size(87, 22)
        Me.PFare4TextBox.TabIndex = 9
        '
        'PFare2TextBox
        '
        Me.PFare2TextBox.Location = New System.Drawing.Point(541, 119)
        Me.PFare2TextBox.Name = "PFare2TextBox"
        Me.PFare2TextBox.Size = New System.Drawing.Size(87, 22)
        Me.PFare2TextBox.TabIndex = 10
        '
        'PFare1TextBox
        '
        Me.PFare1TextBox.Location = New System.Drawing.Point(541, 192)
        Me.PFare1TextBox.Name = "PFare1TextBox"
        Me.PFare1TextBox.Size = New System.Drawing.Size(87, 22)
        Me.PFare1TextBox.TabIndex = 11
        '
        'PSaveButton
        '
        Me.PSaveButton.Location = New System.Drawing.Point(290, 281)
        Me.PSaveButton.Name = "PSaveButton"
        Me.PSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.PSaveButton.TabIndex = 12
        Me.PSaveButton.Text = "Guardar"
        Me.PSaveButton.UseVisualStyleBackColor = True
        '
        'Datos_Parqueadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 346)
        Me.Controls.Add(Me.PSaveButton)
        Me.Controls.Add(Me.PFare1TextBox)
        Me.Controls.Add(Me.PFare2TextBox)
        Me.Controls.Add(Me.PFare4TextBox)
        Me.Controls.Add(Me.PCapacityTextBox)
        Me.Controls.Add(Me.PAddressTextBox)
        Me.Controls.Add(Me.PNameTextBox)
        Me.Controls.Add(Me.PFare1Label)
        Me.Controls.Add(Me.PFare2Label)
        Me.Controls.Add(Me.PFare4Label)
        Me.Controls.Add(Me.PCapacityLabel)
        Me.Controls.Add(Me.PAddresLabel)
        Me.Controls.Add(Me.PNameLabel)
        Me.Name = "Datos_Parqueadero"
        Me.Text = "Datos_Parqueadero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNameLabel As Label
    Friend WithEvents PAddresLabel As Label
    Friend WithEvents PCapacityLabel As Label
    Friend WithEvents PFare4Label As Label
    Friend WithEvents PFare2Label As Label
    Friend WithEvents PFare1Label As Label
    Friend WithEvents PNameTextBox As TextBox
    Friend WithEvents PAddressTextBox As TextBox
    Friend WithEvents PCapacityTextBox As TextBox
    Friend WithEvents PFare4TextBox As TextBox
    Friend WithEvents PFare2TextBox As TextBox
    Friend WithEvents PFare1TextBox As TextBox
    Friend WithEvents PSaveButton As Button
End Class
