Public Class PRUEBASALIDAS
    Private Sub SALIDASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SALIDASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SALIDASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)

    End Sub

    Private Sub PRUEBASALIDAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)

    End Sub
End Class