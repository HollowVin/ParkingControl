Public Class Parqueadero
    Dim counter, available, numero As Integer
    Dim bill As ParkingControlClasses.Factura

    Private Sub Ingreso_Click(sender As Object, e As EventArgs) Handles Check_inTab.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AvailableSpotsLabel.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles BLastNameLabel.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles BNameLabel.Click

    End Sub

    Private Sub ParqueaderoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParqueaderoToolStripMenuItem.Click

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Datos_Parqueadero.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles BNameTextBox.TextChanged

    End Sub

    Private Sub CChargeButton_Click(sender As Object, e As EventArgs) Handles CChargeButton.Click
        Dim SelectedRow As DataGridViewRow = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index)

        If Not SelectedRow.Cells.Item(4).Value Then
            TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(2).Value = DateTime.Now.ToString("HH:mm:ss")
            Dim Departure_Hour As String = DateTime.Now.ToString("HH:mm:ss")
            Dim placa As String = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(0).Value
            Dim ChargeAmount As Decimal = Datos_Parqueadero.parks.CarExits(placa)
            TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(3).Value = ChargeAmount
            TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(4).Value = True
            ParkingTab.SelectTab(1)
            BTotalTextBox.Text = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(3).Value
        Else
            MessageBox.Show("El vehículo ya ha sido cobrado")
        End If
    End Sub

    Private Sub CGenerateButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CIngresarButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles BDateTextBox.TextChanged

    End Sub

    Private Sub BAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles BAddressTextBox.TextChanged

    End Sub

    Private Sub BPhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles BPhoneTextBox.TextChanged

    End Sub

    Private Sub BDateLabel_Click(sender As Object, e As EventArgs) Handles BDateLabel.Click

    End Sub

    Private Sub BPhoneLabel_Click(sender As Object, e As EventArgs) Handles BPhoneLabel.Click

    End Sub

    Private Sub BAddressLabel_Click(sender As Object, e As EventArgs) Handles BAddressLabel.Click

    End Sub

    Private Sub BLastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BLastNameTextBox.TextChanged

    End Sub

    Private Sub BCI_RUCLabel_Click(sender As Object, e As EventArgs) Handles BCI_RUCLabel.Click

    End Sub

    Private Sub CPrintButton_Click(sender As Object, e As EventArgs) Handles CPrintButton.Click
        If (CPlateTextBox.Text = "") Then
            MessageBox.Show("Ingrese la placa del vehiculo")
        Else
            If Datos_Parqueadero.parks.CarEnters(CPlateTextBox.Text) Then
                CConsultButton.Enabled = True
                counter += 1

                TablaIngresoPlaca.Rows.Add(Datos_Parqueadero.parks.CarsEntered.Last().PlateNumber.ToString,
                                        Datos_Parqueadero.parks.CarsEntered.Last().EnterTime.ToString("HH:mm:ss"))
                available = CType(Datos_Parqueadero.DCapacityTextBox.Text, Integer) - counter
                AvailableSpotsLabel.Text = "Disponibles: " + available.ToString
                OccupiedSpotsLabel.Text = "Ocupados: " + counter.ToString
            Else
                MessageBox.Show("El vehículo con esa placa ya ha ingresado")
            End If
        End If
    End Sub

    Private Sub BFCButton_Click(sender As Object, e As EventArgs) Handles BFCButton.Click
        BNameTextBox.Text = "Consumidor"
        BLastNameTextBox.Text = "Final"
        BCI_RUCTextBox.Text = "99999999999"
        BPhoneTextBox.Text = "9999999999"
        BDateTextBox.Text = DateTime.Now.ToString("d")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BCleanAllButton.Click
        BNameTextBox.Text = ""
        BLastNameTextBox.Text = ""
        BCI_RUCTextBox.Text = ""
        BPhoneTextBox.Text = ""
    End Sub

    Private Sub CPlateTextBox_TextChanged(sender As Object, e As EventArgs) Handles CPlateTextBox.TextChanged

    End Sub

    Private Sub BPrintButton_Click(sender As Object, e As EventArgs) Handles BPrintButton.Click
        bill = New ParkingControlClasses.Factura(1, "", "", "", "", 0.00)
        Dim SelectedRow As DataGridViewRow = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index)


        If (BNameTextBox.Text = "" Or BLastNameTextBox.Text = "" Or BCI_RUCTextBox.Text = "" Or BTotalTextBox.Text = "") Then
            MessageBox.Show("Los campos Nombre, Apellido, CI y Total son obligatorios")
        Else
            counter -= 1
            available += 1
            numero += 1

            AvailableSpotsLabel.Text = "Disponibles: " + available.ToString
            OccupiedSpotsLabel.Text = "Ocupados: " + counter.ToString

            bill.Name = BNameTextBox.Text + BLastNameTextBox.Text
            bill.Address = BAddressTextBox.Text
            bill.PhoneNumber = BPhoneTextBox.Text
            bill.CI = BCI_RUCTextBox.Text
            bill.EmissionDate = BDateTextBox.Text
            bill.Total = BTotalTextBox.Text
            Datos_Parqueadero.parks.AddFactura(bill)

            MessageBox.Show("Factura impresa con exito")

            BNameTextBox.Clear()
            BLastNameTextBox.Clear()
            BAddressTextBox.Clear()
            BPhoneTextBox.Clear()
            BCI_RUCTextBox.Clear()
            BDateTextBox.Clear()
            BTotalTextBox.Clear()

            Ventana_Facturas.TablaFacturas.Rows.Add(numero.ToString,
                                            Datos_Parqueadero.parks.FacturasEntered.Last().CI.ToString,
                                            Datos_Parqueadero.parks.FacturasEntered.Last().EmissionDate.ToString("d"),
                                            Datos_Parqueadero.parks.FacturasEntered.Last().Total.ToString)
        End If
    End Sub

    Private Sub Parqueadero_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TablaIngresoPlaca.RowsAdded
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub CalculateDateButton_Click(sender As Object, e As EventArgs) Handles CalculateDateButton.Click
        BDateTextBox.Text = DateTime.Now.ToString("d")
    End Sub

    Private Sub BTotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles BTotalTextBox.TextChanged

    End Sub

    Private Sub OccupiedSpotsLabel_Click(sender As Object, e As EventArgs) Handles OccupiedSpotsLabel.Click
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaIngresoPlaca.CellContentClick
        CChargeButton.Enabled = True
    End Sub

    Private Sub RegistroFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroFacturasToolStripMenuItem.Click
        Ventana_Facturas.Show()
    End Sub

    Private Sub CConsultButton_Click(sender As Object, e As EventArgs) Handles CConsultButton.Click

        Dim SelectedRow As DataGridViewRow = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index)

        TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(2).Value = DateTime.Now.ToString("HH:mm:ss")
        Dim Departure_Hour As String = DateTime.Now.ToString("HH:mm:ss")
        Dim placa As String = TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(0).Value
        Dim ChargeAmount As Decimal = Datos_Parqueadero.parks.ConsultPrice(placa)
        TablaIngresoPlaca.Rows.Item(TablaIngresoPlaca.SelectedRows.Item(0).Index).Cells.Item(3).Value = ChargeAmount
    End Sub
End Class
