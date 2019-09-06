Public Class Ver_Reporte
    Private Sub Ver_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.REPORTE' Puede moverla o quitarla según sea necesario.
        'Me.REPORTETableAdapter.ReporteFill(Me.MPClienteDataSet.REPORTE)
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)

    End Sub

    Private Sub BuscarBTN_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        Try
            Me.REPORTETableAdapter.ReporteFill(Me.MPClienteDataSet.REPORTE, ClienteCBX.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class