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
End Class