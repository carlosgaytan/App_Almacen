Imports System.IO

Public Class Principal
    Dim EntradaFilt, NoClienteFilt, ClienteFilt, EspesorFilt, MaterialFilt, RackFilt, NivelFilt, ObservFilt

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
            'ElseIf NoClienteCBX.Text <> "" Then
            '    NoClienteFilt = String.Format("CLIENTE Like '{0}%'", NoClienteCBX.Text)
            '    IventariosMPBindingSource.Filter = NoClienteFilt
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

        End If

        FiltroMpGroup.Visible = False

    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click
        FiltroMpGroup.Visible = False
    End Sub

    Private Sub RestaurarBTN_Click(sender As Object, e As EventArgs) Handles RestaurarBTN.Click
        IventariosMPBindingSource.RemoveFilter()
    End Sub
End Class
