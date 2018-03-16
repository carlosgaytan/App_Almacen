Public Class FiltroMP
    Private Sub FiltroMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MATERIALES.MATERIAL' Puede moverla o quitarla según sea necesario.
        Me.MATERIALTableAdapter.MATERIALFill(Me.MATERIALES.MATERIAL)
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)

    End Sub
End Class