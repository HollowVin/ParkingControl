<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parqueadero
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParqueaderoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkingTab = New System.Windows.Forms.TabControl()
        Me.Check_inTab = New System.Windows.Forms.TabPage()
        Me.CPlateTextBox = New System.Windows.Forms.TextBox()
        Me.CChargeButton = New System.Windows.Forms.Button()
        Me.CGenerateButton = New System.Windows.Forms.Button()
        Me.CPlateLabel = New System.Windows.Forms.Label()
        Me.CCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CCodeLabel = New System.Windows.Forms.Label()
        Me.CDepartureLabel = New System.Windows.Forms.Label()
        Me.CCheckinHourLabel = New System.Windows.Forms.Label()
        Me.BillTab = New System.Windows.Forms.TabPage()
        Me.BPrintButton = New System.Windows.Forms.Button()
        Me.BLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.BDateTextBox = New System.Windows.Forms.TextBox()
        Me.BAddressTextBox = New System.Windows.Forms.TextBox()
        Me.BPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.BCI_RUCTextBox = New System.Windows.Forms.TextBox()
        Me.BTotalTextBox = New System.Windows.Forms.TextBox()
        Me.BNameTextBox = New System.Windows.Forms.TextBox()
        Me.BDateLabel = New System.Windows.Forms.Label()
        Me.BCI_RUCLabel = New System.Windows.Forms.Label()
        Me.BLastNameLabel = New System.Windows.Forms.Label()
        Me.BPhoneLabel = New System.Windows.Forms.Label()
        Me.BTotalLabel = New System.Windows.Forms.Label()
        Me.BAddressLabel = New System.Windows.Forms.Label()
        Me.BNameLabel = New System.Windows.Forms.Label()
        Me.AvailableSpotsLabel = New System.Windows.Forms.Label()
        Me.TakenSpotsLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CIngresarButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ParkingTab.SuspendLayout()
        Me.Check_inTab.SuspendLayout()
        Me.BillTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParqueaderoToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ParqueaderoToolStripMenuItem
        '
        Me.ParqueaderoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.ParqueaderoToolStripMenuItem.Name = "ParqueaderoToolStripMenuItem"
        Me.ParqueaderoToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.ParqueaderoToolStripMenuItem.Text = "Parqueadero"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ParkingTab
        '
        Me.ParkingTab.AccessibleName = ""
        Me.ParkingTab.Controls.Add(Me.Check_inTab)
        Me.ParkingTab.Controls.Add(Me.BillTab)
        Me.ParkingTab.Location = New System.Drawing.Point(0, 65)
        Me.ParkingTab.Name = "ParkingTab"
        Me.ParkingTab.SelectedIndex = 0
        Me.ParkingTab.Size = New System.Drawing.Size(800, 387)
        Me.ParkingTab.TabIndex = 1
        '
        'Check_inTab
        '
        Me.Check_inTab.Controls.Add(Me.CIngresarButton)
        Me.Check_inTab.Controls.Add(Me.CPlateTextBox)
        Me.Check_inTab.Controls.Add(Me.CChargeButton)
        Me.Check_inTab.Controls.Add(Me.CGenerateButton)
        Me.Check_inTab.Controls.Add(Me.CPlateLabel)
        Me.Check_inTab.Controls.Add(Me.CCodeTextBox)
        Me.Check_inTab.Controls.Add(Me.CCodeLabel)
        Me.Check_inTab.Controls.Add(Me.CDepartureLabel)
        Me.Check_inTab.Controls.Add(Me.CCheckinHourLabel)
        Me.Check_inTab.Location = New System.Drawing.Point(4, 25)
        Me.Check_inTab.Name = "Check_inTab"
        Me.Check_inTab.Padding = New System.Windows.Forms.Padding(3)
        Me.Check_inTab.Size = New System.Drawing.Size(792, 358)
        Me.Check_inTab.TabIndex = 0
        Me.Check_inTab.Text = "Ingreso"
        Me.Check_inTab.UseVisualStyleBackColor = True
        '
        'CPlateTextBox
        '
        Me.CPlateTextBox.Location = New System.Drawing.Point(181, 174)
        Me.CPlateTextBox.Name = "CPlateTextBox"
        Me.CPlateTextBox.Size = New System.Drawing.Size(137, 22)
        Me.CPlateTextBox.TabIndex = 8
        '
        'CChargeButton
        '
        Me.CChargeButton.Location = New System.Drawing.Point(461, 246)
        Me.CChargeButton.Name = "CChargeButton"
        Me.CChargeButton.Size = New System.Drawing.Size(75, 23)
        Me.CChargeButton.TabIndex = 7
        Me.CChargeButton.Text = "Cobrar"
        Me.CChargeButton.UseVisualStyleBackColor = True
        '
        'CGenerateButton
        '
        Me.CGenerateButton.Location = New System.Drawing.Point(243, 246)
        Me.CGenerateButton.Name = "CGenerateButton"
        Me.CGenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.CGenerateButton.TabIndex = 6
        Me.CGenerateButton.Text = "Generar"
        Me.CGenerateButton.UseVisualStyleBackColor = True
        '
        'CPlateLabel
        '
        Me.CPlateLabel.AutoSize = True
        Me.CPlateLabel.Location = New System.Drawing.Point(102, 179)
        Me.CPlateLabel.Name = "CPlateLabel"
        Me.CPlateLabel.Size = New System.Drawing.Size(51, 17)
        Me.CPlateLabel.TabIndex = 5
        Me.CPlateLabel.Text = "Placa: "
        '
        'CCodeTextBox
        '
        Me.CCodeTextBox.Enabled = False
        Me.CCodeTextBox.Location = New System.Drawing.Point(181, 28)
        Me.CCodeTextBox.Name = "CCodeTextBox"
        Me.CCodeTextBox.Size = New System.Drawing.Size(137, 22)
        Me.CCodeTextBox.TabIndex = 4
        '
        'CCodeLabel
        '
        Me.CCodeLabel.AutoSize = True
        Me.CCodeLabel.Location = New System.Drawing.Point(99, 33)
        Me.CCodeLabel.Name = "CCodeLabel"
        Me.CCodeLabel.Size = New System.Drawing.Size(60, 17)
        Me.CCodeLabel.TabIndex = 3
        Me.CCodeLabel.Text = "Codigo: "
        '
        'CDepartureLabel
        '
        Me.CDepartureLabel.AutoSize = True
        Me.CDepartureLabel.Location = New System.Drawing.Point(458, 113)
        Me.CDepartureLabel.Name = "CDepartureLabel"
        Me.CDepartureLabel.Size = New System.Drawing.Size(90, 17)
        Me.CDepartureLabel.TabIndex = 1
        Me.CDepartureLabel.Text = "Hora_Salida:"
        '
        'CCheckinHourLabel
        '
        Me.CCheckinHourLabel.AutoSize = True
        Me.CCheckinHourLabel.Location = New System.Drawing.Point(99, 113)
        Me.CCheckinHourLabel.Name = "CCheckinHourLabel"
        Me.CCheckinHourLabel.Size = New System.Drawing.Size(102, 17)
        Me.CCheckinHourLabel.TabIndex = 0
        Me.CCheckinHourLabel.Text = "Hora_Ingreso: "
        '
        'BillTab
        '
        Me.BillTab.Controls.Add(Me.BPrintButton)
        Me.BillTab.Controls.Add(Me.BLastNameTextBox)
        Me.BillTab.Controls.Add(Me.BDateTextBox)
        Me.BillTab.Controls.Add(Me.BAddressTextBox)
        Me.BillTab.Controls.Add(Me.BPhoneTextBox)
        Me.BillTab.Controls.Add(Me.BCI_RUCTextBox)
        Me.BillTab.Controls.Add(Me.BTotalTextBox)
        Me.BillTab.Controls.Add(Me.BNameTextBox)
        Me.BillTab.Controls.Add(Me.BDateLabel)
        Me.BillTab.Controls.Add(Me.BCI_RUCLabel)
        Me.BillTab.Controls.Add(Me.BLastNameLabel)
        Me.BillTab.Controls.Add(Me.BPhoneLabel)
        Me.BillTab.Controls.Add(Me.BTotalLabel)
        Me.BillTab.Controls.Add(Me.BAddressLabel)
        Me.BillTab.Controls.Add(Me.BNameLabel)
        Me.BillTab.Location = New System.Drawing.Point(4, 25)
        Me.BillTab.Name = "BillTab"
        Me.BillTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BillTab.Size = New System.Drawing.Size(792, 358)
        Me.BillTab.TabIndex = 1
        Me.BillTab.Text = "Factura"
        Me.BillTab.UseVisualStyleBackColor = True
        '
        'BPrintButton
        '
        Me.BPrintButton.Location = New System.Drawing.Point(450, 274)
        Me.BPrintButton.Name = "BPrintButton"
        Me.BPrintButton.Size = New System.Drawing.Size(94, 26)
        Me.BPrintButton.TabIndex = 16
        Me.BPrintButton.Text = "Imprimir"
        Me.BPrintButton.UseVisualStyleBackColor = True
        '
        'BLastNameTextBox
        '
        Me.BLastNameTextBox.Location = New System.Drawing.Point(181, 93)
        Me.BLastNameTextBox.Name = "BLastNameTextBox"
        Me.BLastNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BLastNameTextBox.TabIndex = 15
        '
        'BDateTextBox
        '
        Me.BDateTextBox.Location = New System.Drawing.Point(181, 155)
        Me.BDateTextBox.Name = "BDateTextBox"
        Me.BDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BDateTextBox.TabIndex = 14
        '
        'BAddressTextBox
        '
        Me.BAddressTextBox.Location = New System.Drawing.Point(181, 215)
        Me.BAddressTextBox.Name = "BAddressTextBox"
        Me.BAddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BAddressTextBox.TabIndex = 13
        '
        'BPhoneTextBox
        '
        Me.BPhoneTextBox.Location = New System.Drawing.Point(181, 278)
        Me.BPhoneTextBox.Name = "BPhoneTextBox"
        Me.BPhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BPhoneTextBox.TabIndex = 12
        '
        'BCI_RUCTextBox
        '
        Me.BCI_RUCTextBox.Location = New System.Drawing.Point(541, 45)
        Me.BCI_RUCTextBox.Name = "BCI_RUCTextBox"
        Me.BCI_RUCTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BCI_RUCTextBox.TabIndex = 11
        '
        'BTotalTextBox
        '
        Me.BTotalTextBox.Location = New System.Drawing.Point(541, 157)
        Me.BTotalTextBox.Name = "BTotalTextBox"
        Me.BTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BTotalTextBox.TabIndex = 9
        '
        'BNameTextBox
        '
        Me.BNameTextBox.Location = New System.Drawing.Point(181, 42)
        Me.BNameTextBox.Name = "BNameTextBox"
        Me.BNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BNameTextBox.TabIndex = 8
        '
        'BDateLabel
        '
        Me.BDateLabel.AutoSize = True
        Me.BDateLabel.Location = New System.Drawing.Point(82, 160)
        Me.BDateLabel.Name = "BDateLabel"
        Me.BDateLabel.Size = New System.Drawing.Size(55, 17)
        Me.BDateLabel.TabIndex = 7
        Me.BDateLabel.Text = "Fecha: "
        '
        'BCI_RUCLabel
        '
        Me.BCI_RUCLabel.AutoSize = True
        Me.BCI_RUCLabel.Location = New System.Drawing.Point(446, 48)
        Me.BCI_RUCLabel.Name = "BCI_RUCLabel"
        Me.BCI_RUCLabel.Size = New System.Drawing.Size(57, 17)
        Me.BCI_RUCLabel.TabIndex = 6
        Me.BCI_RUCLabel.Text = "CI/RUC:"
        '
        'BLastNameLabel
        '
        Me.BLastNameLabel.AutoSize = True
        Me.BLastNameLabel.Location = New System.Drawing.Point(82, 98)
        Me.BLastNameLabel.Name = "BLastNameLabel"
        Me.BLastNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.BLastNameLabel.TabIndex = 4
        Me.BLastNameLabel.Text = "Apellidos: "
        '
        'BPhoneLabel
        '
        Me.BPhoneLabel.AutoSize = True
        Me.BPhoneLabel.Location = New System.Drawing.Point(82, 281)
        Me.BPhoneLabel.Name = "BPhoneLabel"
        Me.BPhoneLabel.Size = New System.Drawing.Size(68, 17)
        Me.BPhoneLabel.TabIndex = 3
        Me.BPhoneLabel.Text = "Telefono:"
        '
        'BTotalLabel
        '
        Me.BTotalLabel.AutoSize = True
        Me.BTotalLabel.Location = New System.Drawing.Point(447, 160)
        Me.BTotalLabel.Name = "BTotalLabel"
        Me.BTotalLabel.Size = New System.Drawing.Size(44, 17)
        Me.BTotalLabel.TabIndex = 2
        Me.BTotalLabel.Text = "Total:"
        '
        'BAddressLabel
        '
        Me.BAddressLabel.AutoSize = True
        Me.BAddressLabel.Location = New System.Drawing.Point(82, 220)
        Me.BAddressLabel.Name = "BAddressLabel"
        Me.BAddressLabel.Size = New System.Drawing.Size(71, 17)
        Me.BAddressLabel.TabIndex = 1
        Me.BAddressLabel.Text = "Direccion:"
        '
        'BNameLabel
        '
        Me.BNameLabel.AutoSize = True
        Me.BNameLabel.Location = New System.Drawing.Point(82, 48)
        Me.BNameLabel.Name = "BNameLabel"
        Me.BNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.BNameLabel.TabIndex = 0
        Me.BNameLabel.Text = "Nombres: "
        '
        'AvailableSpotsLabel
        '
        Me.AvailableSpotsLabel.AutoSize = True
        Me.AvailableSpotsLabel.Location = New System.Drawing.Point(182, 45)
        Me.AvailableSpotsLabel.Name = "AvailableSpotsLabel"
        Me.AvailableSpotsLabel.Size = New System.Drawing.Size(105, 17)
        Me.AvailableSpotsLabel.TabIndex = 2
        Me.AvailableSpotsLabel.Text = "Disponibles: 45"
        '
        'TakenSpotsLabel
        '
        Me.TakenSpotsLabel.AutoSize = True
        Me.TakenSpotsLabel.Location = New System.Drawing.Point(451, 45)
        Me.TakenSpotsLabel.Name = "TakenSpotsLabel"
        Me.TakenSpotsLabel.Size = New System.Drawing.Size(97, 17)
        Me.TakenSpotsLabel.TabIndex = 4
        Me.TakenSpotsLabel.Text = "Ocupados: 15"
        '
        'CIngresarButton
        '
        Me.CIngresarButton.Location = New System.Drawing.Point(372, 27)
        Me.CIngresarButton.Name = "CIngresarButton"
        Me.CIngresarButton.Size = New System.Drawing.Size(75, 23)
        Me.CIngresarButton.TabIndex = 9
        Me.CIngresarButton.Text = "Ingresar"
        Me.CIngresarButton.UseVisualStyleBackColor = True
        '
        'Parqueadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TakenSpotsLabel)
        Me.Controls.Add(Me.ParkingTab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AvailableSpotsLabel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Parqueadero"
        Me.Text = "Parqueadero"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ParkingTab.ResumeLayout(False)
        Me.Check_inTab.ResumeLayout(False)
        Me.Check_inTab.PerformLayout()
        Me.BillTab.ResumeLayout(False)
        Me.BillTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParqueaderoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParkingTab As TabControl
    Friend WithEvents Check_inTab As TabPage
    Friend WithEvents BillTab As TabPage
    Friend WithEvents CCodeLabel As Label
    Friend WithEvents CDepartureLabel As Label
    Friend WithEvents CCheckinHourLabel As Label
    Friend WithEvents AvailableSpotsLabel As Label
    Friend WithEvents TakenSpotsLabel As Label
    Friend WithEvents CCodeTextBox As TextBox
    Friend WithEvents BDateLabel As Label
    Friend WithEvents BCI_RUCLabel As Label
    Friend WithEvents BLastNameLabel As Label
    Friend WithEvents BPhoneLabel As Label
    Friend WithEvents BTotalLabel As Label
    Friend WithEvents BAddressLabel As Label
    Friend WithEvents BNameLabel As Label
    Friend WithEvents CPlateLabel As Label
    Friend WithEvents BPrintButton As Button
    Friend WithEvents BLastNameTextBox As TextBox
    Friend WithEvents BDateTextBox As TextBox
    Friend WithEvents BAddressTextBox As TextBox
    Friend WithEvents BPhoneTextBox As TextBox
    Friend WithEvents BCI_RUCTextBox As TextBox
    Friend WithEvents BTotalTextBox As TextBox
    Friend WithEvents BNameTextBox As TextBox
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CChargeButton As Button
    Friend WithEvents CGenerateButton As Button
    Friend WithEvents CPlateTextBox As TextBox
    Friend WithEvents CIngresarButton As Button
End Class
