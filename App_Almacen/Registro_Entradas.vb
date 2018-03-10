Public Class Registro_Entradas
    Dim ESP, PES, MULT


    Private Sub Registro_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MATERIALES.MATERIAL' Puede moverla o quitarla según sea necesario.
        Me.MATERIALTableAdapter.MATERIALFill(Me.MATERIALES.MATERIAL)
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)
        FechaLBL.Text = DateAndTime.DateString

        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

        diaTXT.Text = DateAndTime.Day(Now)
        mesTXT.Text = DateAndTime.Month(Now)
        yearTXT.Text = DateAndTime.Year(Now)
        'Material.Text = If(MaterialTXT.Text = "Inoxidable", "IN", If(MaterialTXT.Text = "Acero", "AC", If(MaterialTXT.Text = "NYLAMID", "NY", If(MaterialTXT.Text = "Cobre", "CB", If(MaterialTXT.Text = "Pintro", "PNT", If(MaterialTXT.Text = "Aluminio", "AL", If(MaterialTXT.Text = "Inconel", "INC", "")))))))

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        ' Crea una nueva fila en el registro
        Dim NuevaEntrada As MPClienteDataSet.ENTRADASRow
        NuevaEntrada = MPClienteDataSet.ENTRADAS.NewENTRADASRow

        'Carga la información en la fila
        NuevaEntrada.FECHA = DateAndTime.DateString & " " & DateAndTime.TimeOfDay
        NuevaEntrada.CLIENTE = ClienteCBX.Text
        NuevaEntrada.FACTURA_REMISION = FacturaTXT.Text
        NuevaEntrada.OC = OCTXT.Text
        NuevaEntrada.CERTIFICADO_CALIDAD = CertificadoTXT.Text
        NuevaEntrada.LARGO = LargoTXT.Text
        NuevaEntrada.ANCHO = AnchoTXT.Text
        NuevaEntrada.ESPESOR = EspesorTXT.Text
        NuevaEntrada.MATERIAL = MaterialTXT.Text
        NuevaEntrada.RACK = RackTXT.Text
        NuevaEntrada.NIVEL = NivelTXT.Text
        NuevaEntrada.OBSERVACIONES_ENTRADA = ObservTXT.Text
        NuevaEntrada.LOTE_DIA = diaTXT.Text
        NuevaEntrada.LOTE_MES = mesTXT.Text
        NuevaEntrada.LOTE_AÑO = yearTXT.Text
        NuevaEntrada.LOTE_CLIENTE = ClienteTXT.Text
        NuevaEntrada.LOTE_FOLIO = ConsecTXT.Text
        'NuevaEntrada.PESO_KG

    End Sub

    Private Sub LargoTXT_TextChanged(sender As Object, e As EventArgs) Handles LargoTXT.TextChanged, AnchoTXT.TextChanged, EspesorTXT.SelectedIndexChanged, MaterialTXT.SelectedIndexChanged

        If EspesorTXT.Text = "C. 6" Then
            ESP = 4.94
        ElseIf EspesorTXT.Text = "C. 7" Then
            ESP = 4.7
        ElseIf EspesorTXT.Text = "C. 8" Then
            ESP = 4.2
        ElseIf EspesorTXT.Text = "C. 9" Then
            ESP = 3.81
        ElseIf EspesorTXT.Text = "C. 10" Then
            ESP = 3.42
        ElseIf EspesorTXT.Text = "C. 11" Then
            ESP = 3.04
        ElseIf EspesorTXT.Text = "C. 12" Then
            ESP = 2.7
        ElseIf EspesorTXT.Text = "C. 13" Then
            ESP = 2.3
        ElseIf EspesorTXT.Text = "C. 14" Then
            ESP = 1.9
        ElseIf EspesorTXT.Text = "C. 15" Then
            ESP = 1.71
        ElseIf EspesorTXT.Text = "C. 16" Then
            ESP = 1.52
        ElseIf EspesorTXT.Text = "C. 18" Then
            ESP = 1.21
        ElseIf EspesorTXT.Text = "C. 19" Then
            ESP = 1.04
        ElseIf EspesorTXT.Text = "C. 20" Then
            ESP = 0.91
        ElseIf EspesorTXT.Text = "C. 22" Then
            ESP = 0.76
        ElseIf EspesorTXT.Text = "C. 24" Then
            ESP = 0.61
        ElseIf EspesorTXT.Text = "C. 26" Then
            ESP = 0.45
        ElseIf EspesorTXT.Text = "C. 28" Then
            ESP = 0.38
        ElseIf EspesorTXT.Text = "C. 30" Then
            ESP = 0.3
        ElseIf EspesorTXT.Text = "1/8''" Then
            ESP = 3.1
        ElseIf EspesorTXT.Text = "3/16''" Then
            ESP = 4.76
        ElseIf EspesorTXT.Text = "1/4''" Then
            ESP = 6.35
        ElseIf EspesorTXT.Text = "5/16''" Then
            ESP = 7.94
        ElseIf EspesorTXT.Text = "3/8''" Then
            ESP = 9.52
        ElseIf EspesorTXT.Text = "7/16''" Then
            ESP = 11.11
        ElseIf EspesorTXT.Text = "1/2''" Then
            ESP = 12.7
        ElseIf EspesorTXT.Text = "5/8''" Then
            ESP = 15.88
        ElseIf EspesorTXT.Text = "3/4''" Then
            ESP = 19.05
        ElseIf EspesorTXT.Text = "7/8''" Then
            ESP = 22.23
        ElseIf EspesorTXT.Text = "1''" Then
            ESP = 25.4
        ElseIf EspesorTXT.Text = "1 1/8''" Then
            ESP = 28.6
        ElseIf EspesorTXT.Text = "1 1/4''" Then
            ESP = 31.7
        ElseIf EspesorTXT.Text = "1 3/8''" Then
            ESP = 34.92
        ElseIf EspesorTXT.Text = "1 1/2''" Then
            ESP = 38.1
        ElseIf EspesorTXT.Text = "1 5/8''" Then
            ESP = 41.28
        ElseIf EspesorTXT.Text = "1 3/4''" Then
            ESP = 44.5
        ElseIf EspesorTXT.Text = "2''" Then
            ESP = 50.8
        ElseIf EspesorTXT.Text = "2 1/4''" Then
            ESP = 57.15
        ElseIf EspesorTXT.Text = "2 1/2''" Then
            ESP = 63.6
        ElseIf EspesorTXT.Text = "2 3/4''" Then
            ESP = 69.85
        ElseIf EspesorTXT.Text = "3''" Then
            ESP = 76.2
        ElseIf EspesorTXT.Text = "3 1/2''" Then
            ESP = 88.9
        ElseIf EspesorTXT.Text = "4''" Then
            ESP = 101.6
        ElseIf EspesorTXT.Text = "4 1/2''" Then
            ESP = 114.3
        ElseIf EspesorTXT.Text = "5''" Then
            ESP = 127
        End If

        PesoLBL.Text = MATERIALES.MATERIAL.C

        MULT = 1000
        PES = ((Val(AnchoTXT.Text) / MULT) * (Val(LargoTXT.Text) / MULT) * (ESP / 1000)) * Val(DensidadTXT.Text)

        'PesoLBL.Text = FormatNumber(PES, 2)
    End Sub

End Class