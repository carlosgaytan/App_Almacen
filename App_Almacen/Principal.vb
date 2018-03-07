Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PRUEBAENTRADAS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PRUEBASALIDAS.Show()
    End Sub

    Private Sub Reg_entradas_Click(sender As Object, e As EventArgs) Handles Reg_entradas.Click
        Registro_Entradas.Show()
    End Sub

    Private Sub ENTRADASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ENTRADASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ENTRADASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)
    End Sub

End Class
