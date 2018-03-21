Public Class Alta_Clientes
    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Clientes)

    End Sub

    Private Sub Alta_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)

    End Sub
End Class