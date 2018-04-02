Public Class Modificar_Entradas
    Private Sub Modificar_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

    End Sub


    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click
        If MessageBox.Show("¿Desea guardar los cambios realizados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            'Actualiza registro
            Me.Validate()
            Me.ENTRADASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)
            INFOADICIONAL.ACTUALIZARENTRADAS = 1
            INFOADICIONAL.ACTUALIZARINVENTARIOMP = 1
            MessageBox.Show("Cambios guardados", "Registro")
        End If
    End Sub

    Private Sub BuscarBTN_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        Try
            Me.ENTRADAS1TableAdapter.FiltroEntradaFill(Me.MPClienteDataSet.ENTRADAS1, CType(FolioCBX.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class