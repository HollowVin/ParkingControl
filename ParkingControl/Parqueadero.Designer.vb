﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParqueaderoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkingTab = New System.Windows.Forms.TabControl()
        Me.Check_inTab = New System.Windows.Forms.TabPage()
        Me.CConsultButton = New System.Windows.Forms.Button()
        Me.TablaIngresoPlaca = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavingColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CTotalCobrarLabel = New System.Windows.Forms.Label()
        Me.CTotalTimeLabel = New System.Windows.Forms.Label()
        Me.CPrintButton = New System.Windows.Forms.Button()
        Me.CPlateTextBox = New System.Windows.Forms.TextBox()
        Me.CChargeButton = New System.Windows.Forms.Button()
        Me.CPlateLabel = New System.Windows.Forms.Label()
        Me.BillTab = New System.Windows.Forms.TabPage()
        Me.CalculateDateButton = New System.Windows.Forms.Button()
        Me.BCleanAllButton = New System.Windows.Forms.Button()
        Me.BFCButton = New System.Windows.Forms.Button()
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
        Me.OccupiedSpotsLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ParkingTab.SuspendLayout()
        Me.Check_inTab.SuspendLayout()
        CType(Me.TablaIngresoPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParqueaderoToolStripMenuItem, Me.RegistroFacturasToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ParqueaderoToolStripMenuItem
        '
        Me.ParqueaderoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.ParqueaderoToolStripMenuItem.Name = "ParqueaderoToolStripMenuItem"
        Me.ParqueaderoToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ParqueaderoToolStripMenuItem.Text = "Parqueadero"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'RegistroFacturasToolStripMenuItem
        '
        Me.RegistroFacturasToolStripMenuItem.Name = "RegistroFacturasToolStripMenuItem"
        Me.RegistroFacturasToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.RegistroFacturasToolStripMenuItem.Text = "Registro Facturas"
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
        Me.ParkingTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ParkingTab.Name = "ParkingTab"
        Me.ParkingTab.SelectedIndex = 0
        Me.ParkingTab.Size = New System.Drawing.Size(800, 386)
        Me.ParkingTab.TabIndex = 1
        '
        'Check_inTab
        '
        Me.Check_inTab.Controls.Add(Me.CConsultButton)
        Me.Check_inTab.Controls.Add(Me.TablaIngresoPlaca)
        Me.Check_inTab.Controls.Add(Me.CTotalCobrarLabel)
        Me.Check_inTab.Controls.Add(Me.CTotalTimeLabel)
        Me.Check_inTab.Controls.Add(Me.CPrintButton)
        Me.Check_inTab.Controls.Add(Me.CPlateTextBox)
        Me.Check_inTab.Controls.Add(Me.CChargeButton)
        Me.Check_inTab.Controls.Add(Me.CPlateLabel)
        Me.Check_inTab.Location = New System.Drawing.Point(4, 25)
        Me.Check_inTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_inTab.Name = "Check_inTab"
        Me.Check_inTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Check_inTab.Size = New System.Drawing.Size(792, 357)
        Me.Check_inTab.TabIndex = 0
        Me.Check_inTab.Text = "Ingreso"
        Me.Check_inTab.UseVisualStyleBackColor = True
        '
        'CConsultButton
        '
        Me.CConsultButton.Enabled = False
        Me.CConsultButton.Location = New System.Drawing.Point(339, 28)
        Me.CConsultButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CConsultButton.Name = "CConsultButton"
        Me.CConsultButton.Size = New System.Drawing.Size(97, 32)
        Me.CConsultButton.TabIndex = 14
        Me.CConsultButton.Text = "Consultar"
        Me.CConsultButton.UseVisualStyleBackColor = True
        '
        'TablaIngresoPlaca
        '
        Me.TablaIngresoPlaca.AllowUserToAddRows = False
        Me.TablaIngresoPlaca.AllowUserToDeleteRows = False
        Me.TablaIngresoPlaca.AllowUserToOrderColumns = True
        Me.TablaIngresoPlaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaIngresoPlaca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.LeavingColumn})
        Me.TablaIngresoPlaca.Location = New System.Drawing.Point(76, 80)
        Me.TablaIngresoPlaca.Margin = New System.Windows.Forms.Padding(4)
        Me.TablaIngresoPlaca.MultiSelect = False
        Me.TablaIngresoPlaca.Name = "TablaIngresoPlaca"
        Me.TablaIngresoPlaca.ReadOnly = True
        Me.TablaIngresoPlaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaIngresoPlaca.Size = New System.Drawing.Size(632, 174)
        Me.TablaIngresoPlaca.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Placa"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Entrada"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Salida"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cobro"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'LeavingColumn
        '
        Me.LeavingColumn.FalseValue = ""
        Me.LeavingColumn.HeaderText = "S"
        Me.LeavingColumn.Name = "LeavingColumn"
        Me.LeavingColumn.ReadOnly = True
        Me.LeavingColumn.TrueValue = ""
        Me.LeavingColumn.Width = 30
        '
        'CTotalCobrarLabel
        '
        Me.CTotalCobrarLabel.AutoSize = True
        Me.CTotalCobrarLabel.Location = New System.Drawing.Point(341, 190)
        Me.CTotalCobrarLabel.Name = "CTotalCobrarLabel"
        Me.CTotalCobrarLabel.Size = New System.Drawing.Size(111, 17)
        Me.CTotalCobrarLabel.TabIndex = 12
        Me.CTotalCobrarLabel.Text = "Total_a_Cobrar:"
        '
        'CTotalTimeLabel
        '
        Me.CTotalTimeLabel.AutoSize = True
        Me.CTotalTimeLabel.Location = New System.Drawing.Point(99, 190)
        Me.CTotalTimeLabel.Name = "CTotalTimeLabel"
        Me.CTotalTimeLabel.Size = New System.Drawing.Size(99, 17)
        Me.CTotalTimeLabel.TabIndex = 11
        Me.CTotalTimeLabel.Text = "Tiempo_Total:"
        '
        'CPrintButton
        '
        Me.CPrintButton.Location = New System.Drawing.Point(345, 271)
        Me.CPrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CPrintButton.Name = "CPrintButton"
        Me.CPrintButton.Size = New System.Drawing.Size(91, 30)
        Me.CPrintButton.TabIndex = 10
        Me.CPrintButton.Text = "Imprimir"
        Me.CPrintButton.UseVisualStyleBackColor = True
        '
        'CPlateTextBox
        '
        Me.CPlateTextBox.Location = New System.Drawing.Point(156, 28)
        Me.CPlateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CPlateTextBox.Name = "CPlateTextBox"
        Me.CPlateTextBox.Size = New System.Drawing.Size(137, 22)
        Me.CPlateTextBox.TabIndex = 8
        '
        'CChargeButton
        '
        Me.CChargeButton.Enabled = False
        Me.CChargeButton.Location = New System.Drawing.Point(477, 28)
        Me.CChargeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CChargeButton.Name = "CChargeButton"
        Me.CChargeButton.Size = New System.Drawing.Size(97, 32)
        Me.CChargeButton.TabIndex = 7
        Me.CChargeButton.Text = "Cobrar"
        Me.CChargeButton.UseVisualStyleBackColor = True
        '
        'CPlateLabel
        '
        Me.CPlateLabel.AutoSize = True
        Me.CPlateLabel.Location = New System.Drawing.Point(99, 33)
        Me.CPlateLabel.Name = "CPlateLabel"
        Me.CPlateLabel.Size = New System.Drawing.Size(51, 17)
        Me.CPlateLabel.TabIndex = 5
        Me.CPlateLabel.Text = "Placa: "
        '
        'BillTab
        '
        Me.BillTab.Controls.Add(Me.CalculateDateButton)
        Me.BillTab.Controls.Add(Me.BCleanAllButton)
        Me.BillTab.Controls.Add(Me.BFCButton)
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
        Me.BillTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BillTab.Name = "BillTab"
        Me.BillTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BillTab.Size = New System.Drawing.Size(792, 357)
        Me.BillTab.TabIndex = 1
        Me.BillTab.Text = "Factura"
        Me.BillTab.UseVisualStyleBackColor = True
        '
        'CalculateDateButton
        '
        Me.CalculateDateButton.Location = New System.Drawing.Point(245, 140)
        Me.CalculateDateButton.Name = "CalculateDateButton"
        Me.CalculateDateButton.Size = New System.Drawing.Size(19, 19)
        Me.CalculateDateButton.TabIndex = 19
        Me.CalculateDateButton.UseVisualStyleBackColor = True
        '
        'BCleanAllButton
        '
        Me.BCleanAllButton.Location = New System.Drawing.Point(445, 186)
        Me.BCleanAllButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BCleanAllButton.Name = "BCleanAllButton"
        Me.BCleanAllButton.Size = New System.Drawing.Size(133, 26)
        Me.BCleanAllButton.TabIndex = 18
        Me.BCleanAllButton.Text = "Limpiar Todo"
        Me.BCleanAllButton.UseVisualStyleBackColor = True
        '
        'BFCButton
        '
        Me.BFCButton.Location = New System.Drawing.Point(201, 258)
        Me.BFCButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BFCButton.Name = "BFCButton"
        Me.BFCButton.Size = New System.Drawing.Size(133, 26)
        Me.BFCButton.TabIndex = 17
        Me.BFCButton.Text = "Consumidor Final"
        Me.BFCButton.UseVisualStyleBackColor = True
        '
        'BPrintButton
        '
        Me.BPrintButton.Location = New System.Drawing.Point(445, 258)
        Me.BPrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BPrintButton.Name = "BPrintButton"
        Me.BPrintButton.Size = New System.Drawing.Size(93, 26)
        Me.BPrintButton.TabIndex = 6
        Me.BPrintButton.Text = "Imprimir"
        Me.BPrintButton.UseVisualStyleBackColor = True
        '
        'BLastNameTextBox
        '
        Me.BLastNameTextBox.Location = New System.Drawing.Point(139, 90)
        Me.BLastNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLastNameTextBox.Name = "BLastNameTextBox"
        Me.BLastNameTextBox.Size = New System.Drawing.Size(195, 22)
        Me.BLastNameTextBox.TabIndex = 2
        '
        'BDateTextBox
        '
        Me.BDateTextBox.Location = New System.Drawing.Point(139, 137)
        Me.BDateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BDateTextBox.Name = "BDateTextBox"
        Me.BDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BDateTextBox.TabIndex = 14
        '
        'BAddressTextBox
        '
        Me.BAddressTextBox.Location = New System.Drawing.Point(139, 186)
        Me.BAddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BAddressTextBox.Name = "BAddressTextBox"
        Me.BAddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BAddressTextBox.TabIndex = 5
        '
        'BPhoneTextBox
        '
        Me.BPhoneTextBox.Location = New System.Drawing.Point(541, 90)
        Me.BPhoneTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BPhoneTextBox.Name = "BPhoneTextBox"
        Me.BPhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BPhoneTextBox.TabIndex = 4
        '
        'BCI_RUCTextBox
        '
        Me.BCI_RUCTextBox.Location = New System.Drawing.Point(541, 44)
        Me.BCI_RUCTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BCI_RUCTextBox.Name = "BCI_RUCTextBox"
        Me.BCI_RUCTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BCI_RUCTextBox.TabIndex = 3
        '
        'BTotalTextBox
        '
        Me.BTotalTextBox.Enabled = False
        Me.BTotalTextBox.Location = New System.Drawing.Point(541, 137)
        Me.BTotalTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTotalTextBox.Name = "BTotalTextBox"
        Me.BTotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BTotalTextBox.TabIndex = 9
        '
        'BNameTextBox
        '
        Me.BNameTextBox.Location = New System.Drawing.Point(139, 39)
        Me.BNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BNameTextBox.Name = "BNameTextBox"
        Me.BNameTextBox.Size = New System.Drawing.Size(195, 22)
        Me.BNameTextBox.TabIndex = 1
        '
        'BDateLabel
        '
        Me.BDateLabel.AutoSize = True
        Me.BDateLabel.Location = New System.Drawing.Point(40, 140)
        Me.BDateLabel.Name = "BDateLabel"
        Me.BDateLabel.Size = New System.Drawing.Size(55, 17)
        Me.BDateLabel.TabIndex = 7
        Me.BDateLabel.Text = "Fecha: "
        '
        'BCI_RUCLabel
        '
        Me.BCI_RUCLabel.AutoSize = True
        Me.BCI_RUCLabel.Location = New System.Drawing.Point(443, 48)
        Me.BCI_RUCLabel.Name = "BCI_RUCLabel"
        Me.BCI_RUCLabel.Size = New System.Drawing.Size(57, 17)
        Me.BCI_RUCLabel.TabIndex = 6
        Me.BCI_RUCLabel.Text = "CI/RUC:"
        '
        'BLastNameLabel
        '
        Me.BLastNameLabel.AutoSize = True
        Me.BLastNameLabel.Location = New System.Drawing.Point(40, 94)
        Me.BLastNameLabel.Name = "BLastNameLabel"
        Me.BLastNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.BLastNameLabel.TabIndex = 4
        Me.BLastNameLabel.Text = "Apellidos: "
        '
        'BPhoneLabel
        '
        Me.BPhoneLabel.AutoSize = True
        Me.BPhoneLabel.Location = New System.Drawing.Point(441, 94)
        Me.BPhoneLabel.Name = "BPhoneLabel"
        Me.BPhoneLabel.Size = New System.Drawing.Size(68, 17)
        Me.BPhoneLabel.TabIndex = 3
        Me.BPhoneLabel.Text = "Teléfono:"
        '
        'BTotalLabel
        '
        Me.BTotalLabel.AutoSize = True
        Me.BTotalLabel.Location = New System.Drawing.Point(443, 140)
        Me.BTotalLabel.Name = "BTotalLabel"
        Me.BTotalLabel.Size = New System.Drawing.Size(44, 17)
        Me.BTotalLabel.TabIndex = 2
        Me.BTotalLabel.Text = "Total:"
        '
        'BAddressLabel
        '
        Me.BAddressLabel.AutoSize = True
        Me.BAddressLabel.Location = New System.Drawing.Point(40, 190)
        Me.BAddressLabel.Name = "BAddressLabel"
        Me.BAddressLabel.Size = New System.Drawing.Size(71, 17)
        Me.BAddressLabel.TabIndex = 1
        Me.BAddressLabel.Text = "Dirección:"
        '
        'BNameLabel
        '
        Me.BNameLabel.AutoSize = True
        Me.BNameLabel.Location = New System.Drawing.Point(40, 46)
        Me.BNameLabel.Name = "BNameLabel"
        Me.BNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.BNameLabel.TabIndex = 0
        Me.BNameLabel.Text = "Nombres: "
        '
        'AvailableSpotsLabel
        '
        Me.AvailableSpotsLabel.AutoSize = True
        Me.AvailableSpotsLabel.Location = New System.Drawing.Point(181, 46)
        Me.AvailableSpotsLabel.Name = "AvailableSpotsLabel"
        Me.AvailableSpotsLabel.Size = New System.Drawing.Size(89, 17)
        Me.AvailableSpotsLabel.TabIndex = 2
        Me.AvailableSpotsLabel.Text = "Disponibles: "
        '
        'OccupiedSpotsLabel
        '
        Me.OccupiedSpotsLabel.AutoSize = True
        Me.OccupiedSpotsLabel.Location = New System.Drawing.Point(451, 46)
        Me.OccupiedSpotsLabel.Name = "OccupiedSpotsLabel"
        Me.OccupiedSpotsLabel.Size = New System.Drawing.Size(89, 17)
        Me.OccupiedSpotsLabel.TabIndex = 4
        Me.OccupiedSpotsLabel.Text = "Ocupados: 0"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Parqueadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.OccupiedSpotsLabel)
        Me.Controls.Add(Me.ParkingTab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AvailableSpotsLabel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Parqueadero"
        Me.Text = "Parqueadero"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ParkingTab.ResumeLayout(False)
        Me.Check_inTab.ResumeLayout(False)
        Me.Check_inTab.PerformLayout()
        CType(Me.TablaIngresoPlaca, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AvailableSpotsLabel As Label
    Friend WithEvents OccupiedSpotsLabel As Label
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
    Friend WithEvents CPlateTextBox As TextBox
    Friend WithEvents CPrintButton As Button
    Friend WithEvents CTotalTimeLabel As Label
    Friend WithEvents BFCButton As Button
    Friend WithEvents BCleanAllButton As Button
    Friend WithEvents CTotalCobrarLabel As Label
    Friend WithEvents TablaIngresoPlaca As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents LeavingColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CalculateDateButton As Button
    Friend WithEvents CConsultButton As Button
    Friend WithEvents RegistroFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
