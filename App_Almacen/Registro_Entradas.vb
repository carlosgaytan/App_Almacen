Public Class Registro_Entradas

    Private Sub Registro_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaLBL.Text = DateAndTime.DateString

        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)


    End Sub

End Class