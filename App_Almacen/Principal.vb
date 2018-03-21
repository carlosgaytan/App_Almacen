Imports System.IO

Public Class Principal
    Dim EntradaFilt, NoClienteFilt, ClienteFilt, EspesorFilt, MaterialFilt, RackFilt, NivelFilt, ObservFilt, FechaFilt, FacturaFilt, OCFILT, CalidadFILT, LargoFilt, AnchoFilt, PesoFilt, SalidaEntradaFilt, NoClienteEntradaFilt, ClienteEntradaFilt, EspesorEntradaFilt, MaterialEntradaFilt, RackEntradaFilt, NivelEntradaFilt, ObservEntradaFilt, FacturaEntradaFilt, OCEntradaFILT, CalidadEntradaFILT, LargoEntradaFilt, AnchoEntradaFilt, PesoEntradaFilt


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

#Region "Filtro Inventario MP"
    Private Sub FiltroBTN_Click(sender As Object, e As EventArgs) Handles FiltroBTN.Click

        'Muestra el formuilario de Filtro Inventario MP
        FiltroMpGroup.Visible = True
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

    End Sub

    Private Sub FiltrarBTN_Click(sender As Object, e As EventArgs) Handles FiltrarBTN.Click

        'Filtro de Inventario MP
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
            ObservFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", ObservacionesCBX.Text)
            IventariosMPBindingSource.Filter = ObservFilt
        ElseIf FacturaTXT.Text <> "" Then
            FacturaFilt = String.Format("FACTURA_REMISISON Like '{0}%'", FacturaTXT.Text)
            IventariosMPBindingSource.Filter = FacturaFilt
        ElseIf ocTXT.Text <> "" Then
            OCFILT = String.Format("OC Like '{0}%'", ocTXT.Text)
            IventariosMPBindingSource.Filter = OCFILT
        ElseIf CalidadTXT.Text <> "" Then
            CalidadFILT = String.Format("CERTIFICADO_CALIDAD Like '{0}%'", CalidadTXT.Text)
            IventariosMPBindingSource.Filter = CalidadFILT
        ElseIf LargoTXT.Text <> "" Then
            LargoFilt = String.Format("LARGO Like '{0}%'", LargoTXT.Text)
            IventariosMPBindingSource.Filter = LargoFilt
        ElseIf AnchoTXT.Text <> "" Then
            AnchoFilt = String.Format("ANCHO Like '{0}%'", AnchoTXT.Text)
            IventariosMPBindingSource.Filter = AnchoFilt
        ElseIf PesoTXT.Text <> "" Then
            PesoFilt = String.Format("PESO KG Like '{0}%'", PesoTXT.Text)
            IventariosMPBindingSource.Filter = PesoFilt

        End If

        FiltroMpGroup.Visible = False

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Buscar.SelectedIndexChanged, Buscar.TextChanged
        'Oculta el filtro Inventario MP
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

        'Muestra los textbox o combobox indicados para la busqueda
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
        'Oculta el filtro Inventario MP
        FiltroMpGroup.Visible = False
    End Sub

    Private Sub RestaurarBTN_Click(sender As Object, e As EventArgs) Handles RestaurarBTN.Click
        'Remueve el filtro en Inventario MP
        IventariosMPBindingSource.RemoveFilter()
    End Sub

#End Region

#Region "Filtro Entrada"
    Private Sub FiltroEntradaBTN_Click(sender As Object, e As EventArgs) Handles FiltroEntradaBTN.Click
        GBEntrada.Visible = True
        SalidaEntrada.Text = ""
        ObserEntradaTXT.Text = ""
        ClienteEntrada.Text = ""
        EspesorEntrada.Text = ""
        MateriaEntrada.Text = ""
        RackEntrada.Text = ""
        NivelEntrada.Text = ""
        NoClienteEntrada.Text = ""
        OcEntrada.Text = ""
        CalidadEntrada.Text = ""
        LargoEntrada.Text = ""
        FacturaEntrada.Text = ""
        AnchoEntrada.Text = ""
        PesoEntrada.Text = ""
    End Sub
    Private Sub RestEntradaBTN_Click(sender As Object, e As EventArgs) Handles RestEntradaBTN.Click
        ENTRADASBindingSource.RemoveFilter()
    End Sub
    Private Sub CancelarEntrada_Click(sender As Object, e As EventArgs) Handles CancelarEntrada.Click
        GBEntrada.Visible = False
    End Sub
    Private Sub FiltrarEntrada_Click(sender As Object, e As EventArgs) Handles FiltrarEntrada.Click
        'Filtro de Entradas
        If ClienteEntrada.Text <> "" Then
            ClienteEntradaFilt = String.Format("CLIENTE Like '{0}%'", ClienteEntrada.Text)
            ENTRADASBindingSource.Filter = ClienteEntradaFilt
        ElseIf NoClienteEntrada.Text <> "" Then
            NoClienteEntradaFilt = String.Format("LOTE_CLIENTE Like '{0}%'", NoClienteEntrada.Text)
            ENTRADASBindingSource.Filter = NoClienteEntradaFilt
        ElseIf EspesorEntrada.Text <> "" Then
            EspesorEntradaFilt = String.Format("ESPESOR Like '{0}%'", EspesorEntrada.Text)
            ENTRADASBindingSource.Filter = EspesorEntradaFilt
        ElseIf MateriaEntrada.Text <> "" Then
            MaterialEntradaFilt = String.Format("MATERIAL Like '{0}%'", MateriaEntrada.Text)
            ENTRADASBindingSource.Filter = MaterialEntradaFilt
        ElseIf RackEntrada.Text <> "" Then
            RackEntradaFilt = String.Format("RACK Like '{0}%'", RackEntrada.Text)
            ENTRADASBindingSource.Filter = RackEntradaFilt
        ElseIf NivelEntrada.Text <> "" Then
            NivelEntradaFilt = String.Format("NIVEL Like '{0}%'", NivelEntrada.Text)
            ENTRADASBindingSource.Filter = NivelEntradaFilt
        ElseIf ObserEntradaTXT.Text <> "" Then
            ObservEntradaFilt = String.Format("OBSERVACIONES_ENTRADA Like '{0}%'", ObserEntradaTXT.Text)
            ENTRADASBindingSource.Filter = ObservEntradaFilt
        ElseIf FacturaEntrada.Text <> "" Then
            FacturaEntradaFilt = String.Format("FACTURA_REMISISON Like '{0}%'", FacturaEntrada.Text)
            ENTRADASBindingSource.Filter = FacturaEntradaFilt
        ElseIf OcEntrada.Text <> "" Then
            OCEntradaFILT = String.Format("OC Like '{0}%'", OcEntrada.Text)
            ENTRADASBindingSource.Filter = OCFILT
        ElseIf SalidaEntrada.Text <> "" Then
            SalidaEntradaFilt = String.Format("FOLIO_SALIDA Like '{0}%'", SalidaEntrada.Text)
            ENTRADASBindingSource.Filter = SalidaEntradaFilt
        ElseIf CalidadEntrada.Text <> "" Then
            CalidadEntradaFILT = String.Format("CERTIFICADO_CALIDAD Like '{0}%'", CalidadEntrada.Text)
            ENTRADASBindingSource.Filter = CalidadEntradaFILT
        ElseIf LargoEntrada.Text <> "" Then
            LargoEntradaFilt = String.Format("LARGO Like '{0}%'", LargoEntrada.Text)
            ENTRADASBindingSource.Filter = LargoEntradaFilt
        ElseIf AnchoEntrada.Text <> "" Then
            AnchoEntradaFilt = String.Format("ANCHO Like '{0}%'", AnchoEntrada.Text)
            ENTRADASBindingSource.Filter = AnchoEntradaFilt
        ElseIf PesoEntrada.Text <> "" Then
            PesoEntradaFilt = String.Format("PESO_KG Like '{0}%'", PesoEntrada.Text)
            ENTRADASBindingSource.Filter = PesoEntradaFilt

        End If

        GBEntrada.Visible = False

    End Sub
    Private Sub BuscarEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BuscarEntrada.SelectedIndexChanged

        SalidaEntrada.Visible = False
        ObserEntradaTXT.Visible = False
        ClienteEntrada.Visible = False
        EspesorEntrada.Visible = False
        MateriaEntrada.Visible = False
        RackEntrada.Visible = False
        NivelEntrada.Visible = False
        NoClienteEntrada.Visible = False
        OcEntrada.Visible = False
        CalidadEntrada.Visible = False
        LargoEntrada.Visible = False
        FacturaEntrada.Visible = False
        AnchoEntrada.Visible = False
        PesoEntrada.Visible = False

        SalidaEntrada.Text = ""
        ObserEntradaTXT.Text = ""
        ClienteEntrada.Text = ""
        EspesorEntrada.Text = ""
        MateriaEntrada.Text = ""
        RackEntrada.Text = ""
        NivelEntrada.Text = ""
        NoClienteEntrada.Text = ""
        OcEntrada.Text = ""
        CalidadEntrada.Text = ""
        LargoEntrada.Text = ""
        FacturaEntrada.Text = ""
        AnchoEntrada.Text = ""
        PesoEntrada.Text = ""


        'Muestra los textbox o combobox indicados para la busqueda
        If BuscarEntrada.Text = "Cliente" Then
            ClienteEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "No Cliente" Then
            NoClienteEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Espesor" Then
            EspesorEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Material" Then
            MateriaEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "RACK" Then
            RackEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Nivel" Then
            NivelEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Observaciones" Then
            ObserEntradaTXT.Visible = True
        ElseIf BuscarEntrada.Text = "Factura/Remisión" Then
            FacturaEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "OC" Then
            OcEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Certificado Calidad" Then
            CalidadEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Largo" Then
            LargoEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Ancho" Then
            AnchoEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Peso KG" Then
            PesoEntrada.Visible = True
        ElseIf BuscarEntrada.Text = "Salida" Then
            SalidaEntrada.Visible = True

        End If

    End Sub
#End Region

#Region "Filtro Salida"
    Private Sub FiltroSalidaBTN_Click(sender As Object, e As EventArgs) Handles FiltroSalidaBTN.Click
        GBSalida
    End Sub


#End Region
End Class
