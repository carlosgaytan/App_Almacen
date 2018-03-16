Public Class Registro_Salidas

    Private Sub Registro_Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)

        'Muestra el # de folio que se registrará
        SalidaLBL.Text = MPClienteDataSet.SALIDAS.Last.FOLIO_SALIDA + 1

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Actualiza en tiempo real la fecha y hora
        FechaLBL.Text = DateAndTime.DateString & " " & DateAndTime.TimeString

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click
        'Crea fila
        Dim RegistroSalida As MPClienteDataSet.SALIDASRow
        RegistroSalida = MPClienteDataSet.SALIDAS.NewSALIDASRow

        'Rellena la fila
        RegistroSalida.FOLIO_ENTRADA = EntradaCBX.Text
        RegistroSalida.FECHA_SALIDA = FechaLBL.Text
        RegistroSalida._OF = ofTXT.Text
        RegistroSalida.PI = piTXT.Text
        RegistroSalida.SOLICITANTE = SolicitanteTXT.Text
        RegistroSalida.AUTORIZACION = AutorizaTXT.Text
        'RegistroSalida.LOTE=
        RegistroSalida.OBSERVACIONES_SALIDA = ComenSalidasTXT.Text

        'Insertar la fila en la tabla apropiada del DataSet
        MPClienteDataSet.SALIDAS.AddSALIDASRow(RegistroSalida)

        'Enviar informacón a la base de datos
        SALIDASTableAdapter.Update(MPClienteDataSet.SALIDAS)

        'Confirma proceso
        MessageBox.Show("Registro guardado", "Registros")
        INFOADICIONAL.ACTUALIZARSALIDAS = 1

        'Recarga la tabla de Salidas y actualiza el contador de folio
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)
        SalidaLBL.Text = MPClienteDataSet.SALIDAS.Last.FOLIO_SALIDA + 1


    End Sub

    Private Sub LimpiarBTN_Click(sender As Object, e As EventArgs) Handles LimpiarBTN.Click

        'Confirmación de limpieza de textbox
        If MessageBox.Show("¿Seguro que desea limpiar datos?", "Limpiar",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
        = DialogResult.Yes Then
            ofTXT.Clear()
            piTXT.Clear()
            SolicitanteTXT.Clear()
            AutorizaTXT.Clear()
            ComenSalidasTXT.Clear()
        End If

    End Sub

    Private Sub Registro_Salidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Confirmación de cierre
        If MessageBox.Show("¿Seguro que desea salir", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub
End Class