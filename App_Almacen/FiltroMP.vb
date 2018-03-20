Public Class FiltroMP
    'Dim EntradaFilt, NoClienteFilt, ClienteFilt, EspesorFilt, MaterialFilt, RackFilt, NivelFilt, ObservFilt

    Private Sub FiltroMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MATERIALES.MATERIAL' Puede moverla o quitarla según sea necesario.
        Me.MATERIALTableAdapter.MATERIALFill(Me.MATERIALES.MATERIAL)
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)

    End Sub

    Private Sub FiltroBTN_Click(sender As Object, e As EventArgs) Handles FiltroBTN.Click

        'ESTABLECE EL FILTRO CON EL CUAL SE MOSTRARÁ EL DATAGRIDVIEW
        INFOADICIONAL.EntradaFilt = EntradaTXT.Text

        Me.Close()

        'If EntradaTXT.Text <> "" Then
        '    INFOADICIONAL.EntradaFilt = String.Format("FOLIO_ENTRADA Like '{0}%'", EntradaTXT.Text)

        'End If
        'If Bcliente.Text <> "" And BOF.Text = "" And Bmaq.Text = "" Then
        '    FILTCliente = String.Format("CLIENTE Like '{0}%'", Bcliente.Text)
        '    ValesBindingSource1.Filter = FILTCliente
        'ElseIf BOF.Text <> "" And Bcliente.Text = "" And Bmaq.Text = "" Then
        '    FILTOF = String.Format("OF Like '{0}%'", BOF.Text)
        '    ValesBindingSource1.Filter = FILTOF
        'ElseIf Bmaq.Text <> "" And Bcliente.Text = "" And BOF.Text = "" Then
        '    FILTmaq = String.Format("MAQUINA Like '{0}%'", Bmaq.Text)
        '    ValesBindingSource1.Filter = FILTmaq
        'ElseIf Bcliente.Text <> "" And BOF.Text <> "" And Bmaq.Text = "" Then
        '    FILTCliente = String.Format("CLIENTE Like '{0}%'", Bcliente.Text)
        '    FILTOF = String.Format("OF Like '{0}%'", BOF.Text)
        '    ValesBindingSource1.Filter = FILTCliente
        '    ValesBindingSource1.Filter = FILTOF
        'ElseIf Bcliente.Text <> "" And BOF.Text = "" And Bmaq.Text <> "" Then
        '    FILTCliente = String.Format("CLIENTE Like '{0}%'", Bcliente.Text)
        '    FILTmaq = String.Format("MAQUINA Like '{0}%'", Bmaq.Text)
        '    ValesBindingSource1.Filter = FILTmaq
        '    ValesBindingSource1.Filter = FILTCliente
        'ElseIf Bcliente.Text = "" And BOF.Text <> "" And Bmaq.Text <> "" Then
        '    FILTOF = String.Format("OF Like '{0}%'", BOF.Text)
        '    FILTmaq = String.Format("MAQUINA Like '{0}%'", Bmaq.Text)
        '    ValesBindingSource1.Filter = FILTmaq
        '    ValesBindingSource1.Filter = FILTOF
        'ElseIf Bcliente.Text <> "" And BOF.Text <> "" And Bmaq.Text <> "" Then
        '    FILTCliente = String.Format("CLIENTE Like '{0}%'", Bcliente.Text)
        '    FILTOF = String.Format("OF Like '{0}%'", BOF.Text)
        '    FILTmaq = String.Format("MAQUINA Like '{0}%'", Bmaq.Text)
        '    ValesBindingSource1.Filter = FILTmaq
        '    ValesBindingSource1.Filter = FILTCliente
        '    ValesBindingSource1.Filter = FILTOF
        'End If


    End Sub
End Class