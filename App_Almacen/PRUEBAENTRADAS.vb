Public Class PRUEBAENTRADAS
    Private Sub ENTRADASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ENTRADASBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ENTRADASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPClienteDataSet)

    End Sub

    Private Sub PRUEBAENTRADAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MPClienteDataSet.ENTRADAS' Puede moverla o quitarla según sea necesario.
        Me.ENTRADASTableAdapter.Fill(Me.MPClienteDataSet.ENTRADAS)

        'Buen día Ing. Félix, el motivo por el cual le escribo y reenvío este correo es para compartirle la problemática en la cual me encuentro con respecto a la información que se me comparte de parte del Ing. Adrian, esto debido a que toda la información como OC o solicitudes de los clientes únicamente las está enviando a Gloria, Luis y Erick; esto sin comunicarnos a Sofia o mi sobre dicha información. El tema no es que me moleste el hecho de que no me informe pero si me causa molestia el hecho de que haga cosas de ese estilo debido a que de esta forma sin ningún problema me deja a un lado de todo lo que ocurre en la empresa.

        'Considero que esta es una actitud poco profesional por parte del ingeniero, si bien o no, no le agrado, creo no es la mejor forma de hacer las cosas. Lo que menos quiero es llegar al punto al cual Me están orillando y es que al no informarme de nada ni llevarme a formar parte de las cosas, el único resultado será que Me quede sin gran actividades las cuales pueda realizar y esto sea una perfecta justificación para mi baja, si no es que ya la está gestionando. Por lo cual, le pido si hubiese forma de que podamos arreglar de forma definitiva todo lo relacionado a la distribución de áreas y/o actividades con todo el personal, o en su defecto le solicito de la forma más atenta si pudiera ver la forma de cambiarme a otra área en donde de verdad me pueda desarrollar de una mejor forma tanto personal como profesionalmente.

        'Sin más por el momento, Me despido y le pido una disculpa por el correo pero creo que ya es necesario el hacerlo.

        '  Saludos,


    End Sub
End Class