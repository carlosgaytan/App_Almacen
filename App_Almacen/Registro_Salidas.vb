Public Class Registro_Salidas

    Private Sub Registro_Salidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)

    End Sub
End Class