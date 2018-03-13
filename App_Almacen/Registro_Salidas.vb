Public Class Registro_Salidas
    Private Sub SALIDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SALIDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)

    End Sub

    Private Sub Registro_Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)

    End Sub
End Class