Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PRUEBAENTRADAS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PRUEBASALIDAS.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        fecha.Text = DateAndTime.DateString & " " & DateAndTime.Timer
    End Sub

    Private Sub Reg_entradas_Click(sender As Object, e As EventArgs) Handles Reg_entradas.Click
        Registro_Entradas.Show()
    End Sub
End Class
