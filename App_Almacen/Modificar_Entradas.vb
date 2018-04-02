Public Class Modificar_Entradas
    Dim ESP, PES, MULT, DENSIDAD

    Private Sub Modificar_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Clientes._CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.CLIENTEFill(Me.Clientes._CLIENTES)
        'TODO: esta línea de código carga datos en la tabla 'MATERIALES.MATERIAL' Puede moverla o quitarla según sea necesario.
        Me.MATERIALTableAdapter.MATERIALFill(Me.MATERIALES.MATERIAL)
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Espesores en MM de cada calibre
        If EspesorTXT.Text = "C. 6" Then
            ESP = 4.94
        ElseIf EspesorTXT.Text = "C. 7" Then
            ESP = 4.7
        ElseIf EspesorTXT.Text = "C. 8" Then
            ESP = 4.2
        ElseIf EspesorTXT.Text = "C. 9" Then
            ESP = 3.81
        ElseIf EspesorTXT.Text = "C. 10" Then
            ESP = 3.42
        ElseIf EspesorTXT.Text = "C. 11" Then
            ESP = 3.04
        ElseIf EspesorTXT.Text = "C. 12" Then
            ESP = 2.7
        ElseIf EspesorTXT.Text = "C. 13" Then
            ESP = 2.3
        ElseIf EspesorTXT.Text = "C. 14" Then
            ESP = 1.9
        ElseIf EspesorTXT.Text = "C. 15" Then
            ESP = 1.71
        ElseIf EspesorTXT.Text = "C. 16" Then
            ESP = 1.52
        ElseIf EspesorTXT.Text = "C. 18" Then
            ESP = 1.21
        ElseIf EspesorTXT.Text = "C. 19" Then
            ESP = 1.04
        ElseIf EspesorTXT.Text = "C. 20" Then
            ESP = 0.91
        ElseIf EspesorTXT.Text = "C. 22" Then
            ESP = 0.76
        ElseIf EspesorTXT.Text = "C. 24" Then
            ESP = 0.61
        ElseIf EspesorTXT.Text = "C. 26" Then
            ESP = 0.45
        ElseIf EspesorTXT.Text = "C. 28" Then
            ESP = 0.38
        ElseIf EspesorTXT.Text = "C. 30" Then
            ESP = 0.3
        ElseIf EspesorTXT.Text = "1/8''" Then
            ESP = 3.1
        ElseIf EspesorTXT.Text = "3/16''" Then
            ESP = 4.76
        ElseIf EspesorTXT.Text = "1/4''" Then
            ESP = 6.35
        ElseIf EspesorTXT.Text = "5/16''" Then
            ESP = 7.94
        ElseIf EspesorTXT.Text = "3/8''" Then
            ESP = 9.52
        ElseIf EspesorTXT.Text = "7/16''" Then
            ESP = 11.11
        ElseIf EspesorTXT.Text = "1/2''" Then
            ESP = 12.7
        ElseIf EspesorTXT.Text = "5/8''" Then
            ESP = 15.88
        ElseIf EspesorTXT.Text = "3/4''" Then
            ESP = 19.05
        ElseIf EspesorTXT.Text = "7/8''" Then
            ESP = 22.23
        ElseIf EspesorTXT.Text = "1''" Then
            ESP = 25.4
        ElseIf EspesorTXT.Text = "1 1/8''" Then
            ESP = 28.6
        ElseIf EspesorTXT.Text = "1 1/4''" Then
            ESP = 31.7
        ElseIf EspesorTXT.Text = "1 3/8''" Then
            ESP = 34.92
        ElseIf EspesorTXT.Text = "1 1/2''" Then
            ESP = 38.1
        ElseIf EspesorTXT.Text = "1 5/8''" Then
            ESP = 41.28
        ElseIf EspesorTXT.Text = "1 3/4''" Then
            ESP = 44.5
        ElseIf EspesorTXT.Text = "2''" Then
            ESP = 50.8
        ElseIf EspesorTXT.Text = "2 1/4''" Then
            ESP = 57.15
        ElseIf EspesorTXT.Text = "2 1/2''" Then
            ESP = 63.6
        ElseIf EspesorTXT.Text = "2 3/4''" Then
            ESP = 69.85
        ElseIf EspesorTXT.Text = "3''" Then
            ESP = 76.2
        ElseIf EspesorTXT.Text = "3 1/2''" Then
            ESP = 88.9
        ElseIf EspesorTXT.Text = "4''" Then
            ESP = 101.6
        ElseIf EspesorTXT.Text = "4 1/2''" Then
            ESP = 114.3
        ElseIf EspesorTXT.Text = "5''" Then
            ESP = 127
        End If

        'Carga la tabla con la densidad de los materiales seleccionados
        Me.BuscaMatTableAdapter.BUSCAMATFill(Me.MATERIALES.BuscaMat, MaterialTXT.Text)
        DENSIDAD = MATERIALES.BuscaMat.Last.KG_M3

        'Formula de calculo del peso de placas y láminas
        If DENSIDAD <> 0 Then
            MULT = 1000
            PES = ((Val(AnchoTXT.Text) / MULT) * (Val(LargoTXT.Text) / MULT) * (ESP / 1000)) * DENSIDAD
            PesoLBL.Visible = True
            PesoLBL.Text = FormatNumber(PES, 2)
        End If


    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click
        If MessageBox.Show("¿Desea guardar los cambios realizados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            'Actualiza registro
            Me.Validate()
            Me.ENTRADASBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)
            INFOADICIONAL.ACTUALIZARENTRADAS = 1
            INFOADICIONAL.ACTUALIZARINVENTARIOMP = 1
            MessageBox.Show("Cambios guardados", "Registro")
        End If
    End Sub


End Class