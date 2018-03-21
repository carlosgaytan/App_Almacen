Public Class Alta_Clientes
    Dim NoCliente

    Private Sub Alta_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        If NoCliente <> NoClienteTXT.Text Then

            ' Crea una nueva fila en el registro
            Dim NuevoCliente As Clientes.CLIENTESRow
            NuevoCliente = Clientes._CLIENTES.NewCLIENTESRow

            'Carga la información en la fila
            NuevoCliente.NO_CLIENTE = NoClienteTXT.Text
            NuevoCliente.NOMBRE = NombreTXT.Text
            NuevoCliente.DOMICILIO = DomicilioTXT.Text
            NuevoCliente.TELEFONO = TelefonoTXT.Text
            NuevoCliente.CONTACTO = ContactoTXT.Text
            NuevoCliente.CP = CPTXT.Text
            NuevoCliente.CORREO_ELECTRONICO = CorreoTXT.Text

            'Insertar la fila en la tabla apropiada del DataSet
            Clientes._CLIENTES.AddCLIENTESRow(NuevoCliente)
            'MPClienteDataSet.ENTRADAS.AddENTRADASRow(NuevaEntrada)

            'Enviar informacón a la base de datos
            CLIENTESTableAdapter.Update(Clientes._CLIENTES)
            'ENTRADASTableAdapter.Update(MPClienteDataSet.ENTRADAS)

            'Muestra mensaje de confirmación
            MessageBox.Show("Registro guardado", "Registros")

            NoClienteTXT.Clear()
            NombreTXT.Clear()
            DomicilioTXT.Clear()
            TelefonoTXT.Clear()
            ContactoTXT.Clear()
            CPTXT.Clear()
            CorreoTXT.Clear()

            'Actualiza DataGridView
            Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)
        ElseIf NoCliente = NoClienteTXT.Text Then
            MessageBox.Show("Número de cliente ya registrado", "¡Advertencia!")
        End If
    End Sub

    Private Sub NoClienteTXT_TextChanged(sender As Object, e As EventArgs) Handles NoClienteTXT.TextChanged
        If NoClienteTXT.Text <> "" Then
            Me.BuscarClienteTableAdapter.BuscaNoFill(Me.Clientes.BuscarCliente, NoClienteTXT.Text)

            NoCliente = Clientes.BuscarCliente.Last.NO_CLIENTE
        End If
    End Sub
End Class