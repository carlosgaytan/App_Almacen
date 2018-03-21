Imports System.IO

Public Class Principal
    Dim EntradaFilt, NoClienteFilt, ClienteFilt, EspesorFilt, MaterialFilt, RackFilt, NivelFilt, ObservFilt, FechaFilt, FacturaFilt, OCFILT, CalidadFILT, LargoFilt, AnchoFilt, PesoFilt
    Function OcultarFiltro()
        ClienteCBX.Visible = False
        NoClienteCBX.Visible = False
        EspesorCBX.Visible = False
        MaterialCBX.Visible = False
        RackCBX.Visible = False
        NivelCBX.Visible = False
        ObservacionesCBX.Visible = False
        FacturaTXT.Visible = False
        ocTXT.Visible = False
        CalidadTXT.Visible = False
        LargoTXT.Visible = False
        AnchoTXT.Visible = False
        PesoTXT.Visible = False

    End Function

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.IventariosMP' Puede moverla o quitarla según sea necesario.
        Me.InventarioMPTableAdapter.InventarioMPFill(Me.MPClienteDataSet.IventariosMP)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

    End Sub

    Private Sub Reg_entradas_Click(sender As Object, e As EventArgs) Handles Reg_entradas.Click
        'Abre el formulario de Regsitro de Entradas
        Registro_Entradas.Show()
    End Sub

    Private Sub ENTRADASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ENTRADASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ENTRADASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)
    End Sub

    Private Sub EntradasFSW_Changed(sender As Object, e As FileSystemEventArgs) Handles EntradasFSW.Changed

        'Actualiza la base de datos al registrar cambios en la BD bajo la condición de que INFOADICIONAL sea distinto a "" en ENTRADAS
        If INFOADICIONAL.ACTUALIZARENTRADAS <> "" Then
            Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
            Me.InventarioMPTableAdapter.InventarioMPFill(Me.MPClienteDataSet.IventariosMP)
            INFOADICIONAL.ACTUALIZARENTRADAS = ""
        End If

        'Actualiza la base de datos al registrar cambios en la BD bajo la condición de que INFOADICIONAL sea distinto a "" en Salidas
        If INFOADICIONAL.ACTUALIZARSALIDAS <> "" Then
            Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)
            Me.InventarioMPTableAdapter.InventarioMPFill(Me.MPClienteDataSet.IventariosMP)
            INFOADICIONAL.ACTUALIZARSALIDAS = ""
        End If

    End Sub

    Private Sub Reg_Salidas_Click(sender As Object, e As EventArgs) Handles Reg_Salidas.Click
        'Abre el formulario de Registro de Salidas
        Registro_Salidas.Show()
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Confirmación de cierre
        If MessageBox.Show("¿Seguro que desea salir", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub FiltroBTN_Click(sender As Object, e As EventArgs) Handles FiltroBTN.Click

        FiltroMpGroup.Visible = True
        NoClienteCBX.Text = ""
        ClienteCBX.Text = ""
        EspesorCBX.Text = ""
        MaterialCBX.Text = ""
        RackCBX.Text = ""
        NivelCBX.Text = ""
        ObservacionesCBX.Text = ""

    End Sub

    Private Sub FiltrarBTN_Click(sender As Object, e As EventArgs) Handles FiltrarBTN.Click

        If ClienteCBX.Text <> "" Then
            ClienteFilt = String.Format("CLIENTE Like '{0}%'", ClienteCBX.Text)
            IventariosMPBindingSource.Filter = ClienteFilt
        ElseIf NoClienteCBX.Text <> "" Then
            NoClienteFilt = String.Format("LOTE_CLIENTE Like '{0}%'", NoClienteCBX.Text)
            IventariosMPBindingSource.Filter = NoClienteFilt
        ElseIf EspesorCBX.Text <> "" Then
            EspesorFilt = String.Format("ESPESOR Like '{0}%'", EspesorCBX.Text)
            IventariosMPBindingSource.Filter = EspesorFilt
        ElseIf MaterialCBX.Text <> "" Then
            MaterialFilt = String.Format("MATERIAL Like '{0}%'", MaterialCBX.Text)
            IventariosMPBindingSource.Filter = MaterialFilt
        ElseIf RackCBX.Text <> "" Then
            RackFilt = String.Format("RACK Like '{0}%'", RackCBX.Text)
            IventariosMPBindingSource.Filter = RackFilt
        ElseIf NivelCBX.Text <> "" Then
            NivelFilt = String.Format("NIVEL Like '{0}%'", NivelCBX.Text)
            IventariosMPBindingSource.Filter = NivelFilt
        ElseIf ObservacionesCBX.Text <> "" Then
            ObservFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", NoClienteCBX.Text)
            IventariosMPBindingSource.Filter = ObservFilt
        ElseIf FacturaTXT.Text <> "" Then
            FacturaFilt = String.Format("FACTURA_REMISISON Like '{0}%'", FacturaTXT.Text)
            IventariosMPBindingSource.Filter = FacturaFilt
        ElseIf ocTXT.Text <> "" Then
            OCFILT = String.Format("OC Like '{0}%'", ocTXT.Text)
            IventariosMPBindingSource.Filter = OCFILT
        ElseIf ObservacionesCBX.Text <> "" Then
            ObservFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", NoClienteCBX.Text)
            IventariosMPBindingSource.Filter = ObservFilt
        ElseIf CalidadTXT.Text <> "" Then
            CalidadFILT = String.Format("CERTIFICADO_CALIDAD Like '{0}%'", CalidadTXT.Text)
            IventariosMPBindingSource.Filter = CalidadFILT
        ElseIf LargoTXT.Text <> "" Then
            LargoFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", LargoTXT.Text)
            IventariosMPBindingSource.Filter = LargoFilt
        ElseIf AnchoTXT.Text <> "" Then
            AnchoFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", AnchoTXT.Text)
            IventariosMPBindingSource.Filter = AnchoFilt
        ElseIf PesoTXT.Text <> "" Then
            PesoFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", PesoTXT.Text)
            IventariosMPBindingSource.Filter = PesoFilt

        End If

        FiltroMpGroup.Visible = False

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Buscar.SelectedIndexChanged, Buscar.TextChanged

        OcultarFiltro()
        NoClienteCBX.Text = ""
        ClienteCBX.Text = ""
        EspesorCBX.Text = ""
        MaterialCBX.Text = ""
        RackCBX.Text = ""
        NivelCBX.Text = ""
        ObservacionesCBX.Text = ""
        FacturaTXT.Text = ""
        ocTXT.Text = ""
        CalidadTXT.Text = ""
        LargoTXT.Text = ""
        AnchoTXT.Text = ""
        PesoTXT.Text = ""

        If Buscar.Text = "Cliente" Then
            ClienteCBX.Visible = True
        ElseIf Buscar.Text = "No Cliente" Then
            NoClienteCBX.Visible = True
        ElseIf Buscar.Text = "Espesor" Then
            EspesorCBX.Visible = True
        ElseIf Buscar.Text = "Material" Then
            MaterialCBX.Visible = True
        ElseIf Buscar.Text = "RACK" Then
            RackCBX.Visible = True
        ElseIf Buscar.Text = "Nivel" Then
            NivelCBX.Visible = True
        ElseIf Buscar.Text = "Observaciones" Then
            ObservacionesCBX.Visible = True
        ElseIf Buscar.Text = "Factura/Remisión" Then
            FacturaTXT.Visible = True
        ElseIf Buscar.Text = "OC" Then
            ocTXT.Visible = True
        ElseIf Buscar.Text = "Certificado Calidad" Then
            CalidadTXT.Visible = True
        ElseIf Buscar.Text = "Largo" Then
            LargoTXT.Visible = True
        ElseIf Buscar.Text = "Ancho" Then
            AnchoTXT.Visible = True
        ElseIf Buscar.Text = "Peso KG" Then
            PesoTXT.Visible = True
        End If

    End Sub


    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        FiltroMpGroup.Visible = False
    End Sub

    Private Sub RestaurarBTN_Click(sender As Object, e As EventArgs) Handles RestaurarBTN.Click
        IventariosMPBindingSource.RemoveFilter()
    End Sub
End Class
