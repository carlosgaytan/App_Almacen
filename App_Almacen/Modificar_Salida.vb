Public Class Modificar_Salida
    Private Sub Modificar_Salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If EstatusLBL.Text = "CANCELADO" Then
            MessageBox.Show("El folio se encuentra cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf MessageBox.Show("¿Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            EstatusLBL.Text = "CANCELADO"
            EntradaLBL.Text = "-"

            'Actualiza registro
            Me.Validate()
            Me.SALIDASBindingSource.EndEdit()
            Me.ENTRADASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)

            INFOADICIONAL.ACTUALIZARENTRADAS = 1
            INFOADICIONAL.ACTUALIZARINVENTARIOMP = 1
            INFOADICIONAL.ACTUALIZARSALIDAS = 1
            MessageBox.Show("Registro Actualizado", "Guardado")
        End If
    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click
        If MessageBox.Show("¿Desea guardar cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            'Actualiza registro
            Me.Validate()
            Me.SALIDASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)

            INFOADICIONAL.ACTUALIZARENTRADAS = 1
            INFOADICIONAL.ACTUALIZARINVENTARIOMP = 1
            INFOADICIONAL.ACTUALIZARSALIDAS = 1

        End If
    End Sub
End Class