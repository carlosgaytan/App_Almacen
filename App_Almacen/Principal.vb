Imports System.IO

Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.SALIDAS' Puede moverla o quitarla según sea necesario.
        Me.SALIDASTableAdapter.Fill(Me.MPClienteDataSet.SALIDAS)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

    End Sub

    Private Sub Reg_entradas_Click(sender As Object, e As EventArgs) Handles Reg_entradas.Click
        'Abre en formulacion de Regsitro de Entradas
        Registro_Entradas.Show()

    End Sub

    Private Sub ENTRADASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ENTRADASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ENTRADASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)
    End Sub

    Private Sub EntradasFSW_Changed(sender As Object, e As FileSystemEventArgs) Handles EntradasFSW.Changed

        'Actualiza la base de datos al registrar cambios en la BD bajo la condición de que INFOADICIONAL sea distinto a ""
        If INFOADICIONAL.ACTUALIZAR <> "" Then
            Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)
            INFOADICIONAL.ACTUALIZAR = ""
        End If

    End Sub
End Class
