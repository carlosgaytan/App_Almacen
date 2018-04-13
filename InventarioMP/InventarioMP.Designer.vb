<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioMP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioMP))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ActualizarInvent = New System.Windows.Forms.Button()
        Me.FiltroMpGroup = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PesoTXT = New System.Windows.Forms.TextBox()
        Me.AnchoTXT = New System.Windows.Forms.TextBox()
        Me.FacturaTXT = New System.Windows.Forms.TextBox()
        Me.LargoTXT = New System.Windows.Forms.TextBox()
        Me.CalidadTXT = New System.Windows.Forms.TextBox()
        Me.ocTXT = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.ComboBox()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.NoClienteCBX = New System.Windows.Forms.ComboBox()
        Me.NivelCBX = New System.Windows.Forms.ComboBox()
        Me.RackCBX = New System.Windows.Forms.ComboBox()
        Me.MaterialCBX = New System.Windows.Forms.ComboBox()
        Me.EspesorCBX = New System.Windows.Forms.ComboBox()
        Me.ClienteCBX = New System.Windows.Forms.ComboBox()
        Me.FiltrarBTN = New System.Windows.Forms.Button()
        Me.ObservacionesCBX = New System.Windows.Forms.TextBox()
        Me.RestaurarBTN = New System.Windows.Forms.Button()
        Me.FiltroBTN = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ActualizarEntradas = New System.Windows.Forms.Button()
        Me.GBEntrada = New System.Windows.Forms.GroupBox()
        Me.SalidaEntrada = New System.Windows.Forms.ComboBox()
        Me.PesoEntrada = New System.Windows.Forms.TextBox()
        Me.AnchoEntrada = New System.Windows.Forms.TextBox()
        Me.FacturaEntrada = New System.Windows.Forms.TextBox()
        Me.LargoEntrada = New System.Windows.Forms.TextBox()
        Me.CalidadEntrada = New System.Windows.Forms.TextBox()
        Me.OcEntrada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuscarEntrada = New System.Windows.Forms.ComboBox()
        Me.NoClienteEntrada = New System.Windows.Forms.ComboBox()
        Me.NivelEntrada = New System.Windows.Forms.ComboBox()
        Me.RackEntrada = New System.Windows.Forms.ComboBox()
        Me.MateriaEntrada = New System.Windows.Forms.ComboBox()
        Me.EspesorEntrada = New System.Windows.Forms.ComboBox()
        Me.ClienteEntrada = New System.Windows.Forms.ComboBox()
        Me.CancelarEntrada = New System.Windows.Forms.Button()
        Me.ObserEntradaTXT = New System.Windows.Forms.TextBox()
        Me.FiltrarEntrada = New System.Windows.Forms.Button()
        Me.RestEntradaBTN = New System.Windows.Forms.Button()
        Me.FiltroEntradaBTN = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ActualizarSalidas = New System.Windows.Forms.Button()
        Me.GBSalida = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ObservSalidas = New System.Windows.Forms.TextBox()
        Me.AutorizaTXT = New System.Windows.Forms.TextBox()
        Me.LoteTXT = New System.Windows.Forms.TextBox()
        Me.SolicitanteTXT = New System.Windows.Forms.TextBox()
        Me.PITXT = New System.Windows.Forms.TextBox()
        Me.OFTXT = New System.Windows.Forms.TextBox()
        Me.BuscarSalida = New System.Windows.Forms.ComboBox()
        Me.CancelarSalida = New System.Windows.Forms.Button()
        Me.FiltrarSalida = New System.Windows.Forms.Button()
        Me.RestSalidaBTN = New System.Windows.Forms.Button()
        Me.FiltroSalidaBTN = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FiltroMpGroup.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GBEntrada.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GBSalida.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1163, 653)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ActualizarInvent)
        Me.TabPage3.Controls.Add(Me.FiltroMpGroup)
        Me.TabPage3.Controls.Add(Me.RestaurarBTN)
        Me.TabPage3.Controls.Add(Me.FiltroBTN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1155, 627)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventario MP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ActualizarInvent
        '
        Me.ActualizarInvent.Location = New System.Drawing.Point(168, 6)
        Me.ActualizarInvent.Name = "ActualizarInvent"
        Me.ActualizarInvent.Size = New System.Drawing.Size(75, 23)
        Me.ActualizarInvent.TabIndex = 4
        Me.ActualizarInvent.Text = "Actualizar"
        Me.ActualizarInvent.UseVisualStyleBackColor = True
        '
        'FiltroMpGroup
        '
        Me.FiltroMpGroup.BackColor = System.Drawing.Color.LightGray
        Me.FiltroMpGroup.Controls.Add(Me.Label1)
        Me.FiltroMpGroup.Controls.Add(Me.PesoTXT)
        Me.FiltroMpGroup.Controls.Add(Me.AnchoTXT)
        Me.FiltroMpGroup.Controls.Add(Me.FacturaTXT)
        Me.FiltroMpGroup.Controls.Add(Me.LargoTXT)
        Me.FiltroMpGroup.Controls.Add(Me.CalidadTXT)
        Me.FiltroMpGroup.Controls.Add(Me.ocTXT)
        Me.FiltroMpGroup.Controls.Add(Me.Buscar)
        Me.FiltroMpGroup.Controls.Add(Me.CancelarBTN)
        Me.FiltroMpGroup.Controls.Add(Me.NoClienteCBX)
        Me.FiltroMpGroup.Controls.Add(Me.NivelCBX)
        Me.FiltroMpGroup.Controls.Add(Me.RackCBX)
        Me.FiltroMpGroup.Controls.Add(Me.MaterialCBX)
        Me.FiltroMpGroup.Controls.Add(Me.EspesorCBX)
        Me.FiltroMpGroup.Controls.Add(Me.ClienteCBX)
        Me.FiltroMpGroup.Controls.Add(Me.FiltrarBTN)
        Me.FiltroMpGroup.Controls.Add(Me.ObservacionesCBX)
        Me.FiltroMpGroup.Location = New System.Drawing.Point(479, 246)
        Me.FiltroMpGroup.Name = "FiltroMpGroup"
        Me.FiltroMpGroup.Size = New System.Drawing.Size(195, 118)
        Me.FiltroMpGroup.TabIndex = 3
        Me.FiltroMpGroup.TabStop = False
        Me.FiltroMpGroup.Text = "Filtrar"
        Me.FiltroMpGroup.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Filtrar por:"
        '
        'PesoTXT
        '
        Me.PesoTXT.Location = New System.Drawing.Point(62, 42)
        Me.PesoTXT.Name = "PesoTXT"
        Me.PesoTXT.Size = New System.Drawing.Size(120, 20)
        Me.PesoTXT.TabIndex = 48
        Me.PesoTXT.Visible = False
        '
        'AnchoTXT
        '
        Me.AnchoTXT.Location = New System.Drawing.Point(62, 42)
        Me.AnchoTXT.Name = "AnchoTXT"
        Me.AnchoTXT.Size = New System.Drawing.Size(120, 20)
        Me.AnchoTXT.TabIndex = 47
        Me.AnchoTXT.Visible = False
        '
        'FacturaTXT
        '
        Me.FacturaTXT.Location = New System.Drawing.Point(62, 42)
        Me.FacturaTXT.Name = "FacturaTXT"
        Me.FacturaTXT.Size = New System.Drawing.Size(120, 20)
        Me.FacturaTXT.TabIndex = 46
        Me.FacturaTXT.Visible = False
        '
        'LargoTXT
        '
        Me.LargoTXT.Location = New System.Drawing.Point(62, 42)
        Me.LargoTXT.Name = "LargoTXT"
        Me.LargoTXT.Size = New System.Drawing.Size(120, 20)
        Me.LargoTXT.TabIndex = 45
        Me.LargoTXT.Visible = False
        '
        'CalidadTXT
        '
        Me.CalidadTXT.Location = New System.Drawing.Point(62, 42)
        Me.CalidadTXT.Name = "CalidadTXT"
        Me.CalidadTXT.Size = New System.Drawing.Size(120, 20)
        Me.CalidadTXT.TabIndex = 44
        Me.CalidadTXT.Visible = False
        '
        'ocTXT
        '
        Me.ocTXT.Location = New System.Drawing.Point(62, 42)
        Me.ocTXT.Name = "ocTXT"
        Me.ocTXT.Size = New System.Drawing.Size(120, 20)
        Me.ocTXT.TabIndex = 43
        Me.ocTXT.Visible = False
        '
        'Buscar
        '
        Me.Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Buscar.FormattingEnabled = True
        Me.Buscar.Items.AddRange(New Object() {"Cliente", "Factura/Remisión", "OC", "Certificado Calidad", "Largo", "Ancho", "Espesor", "Material", "Peso KG", "RACK", "Nivel", "Observaciones"})
        Me.Buscar.Location = New System.Drawing.Point(62, 15)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(121, 21)
        Me.Buscar.TabIndex = 42
        '
        'CancelarBTN
        '
        Me.CancelarBTN.Location = New System.Drawing.Point(6, 82)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBTN.TabIndex = 41
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = True
        '
        'NoClienteCBX
        '
        Me.NoClienteCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NoClienteCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NoClienteCBX.DisplayMember = "NO_CLIENTE"
        Me.NoClienteCBX.FormattingEnabled = True
        Me.NoClienteCBX.Location = New System.Drawing.Point(62, 42)
        Me.NoClienteCBX.Name = "NoClienteCBX"
        Me.NoClienteCBX.Size = New System.Drawing.Size(120, 21)
        Me.NoClienteCBX.TabIndex = 40
        Me.NoClienteCBX.Visible = False
        '
        'NivelCBX
        '
        Me.NivelCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NivelCBX.DisplayMember = "NIVEL"
        Me.NivelCBX.FormattingEnabled = True
        Me.NivelCBX.Location = New System.Drawing.Point(62, 42)
        Me.NivelCBX.Name = "NivelCBX"
        Me.NivelCBX.Size = New System.Drawing.Size(120, 21)
        Me.NivelCBX.TabIndex = 38
        Me.NivelCBX.Visible = False
        '
        'RackCBX
        '
        Me.RackCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RackCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.RackCBX.DisplayMember = "RACK"
        Me.RackCBX.FormattingEnabled = True
        Me.RackCBX.Location = New System.Drawing.Point(62, 42)
        Me.RackCBX.Name = "RackCBX"
        Me.RackCBX.Size = New System.Drawing.Size(120, 21)
        Me.RackCBX.TabIndex = 37
        Me.RackCBX.Visible = False
        '
        'MaterialCBX
        '
        Me.MaterialCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MaterialCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.MaterialCBX.DisplayMember = "MATERIAL"
        Me.MaterialCBX.FormattingEnabled = True
        Me.MaterialCBX.Location = New System.Drawing.Point(62, 42)
        Me.MaterialCBX.Name = "MaterialCBX"
        Me.MaterialCBX.Size = New System.Drawing.Size(120, 21)
        Me.MaterialCBX.TabIndex = 36
        Me.MaterialCBX.Visible = False
        '
        'EspesorCBX
        '
        Me.EspesorCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EspesorCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EspesorCBX.FormattingEnabled = True
        Me.EspesorCBX.Items.AddRange(New Object() {"C. 6", "C. 7", "C. 8", "C. 9", "C. 10", "C. 11", "C. 12", "C. 13", "C. 14", "C. 15", "C. 16", "C. 18", "C. 19", "C. 20", "C. 22", "C. 24", "C. 26", "C. 28", "C. 30", "1/8''", "3/16''", "1/4''", "5/16''", "3/8''", "7/16''", "1/2''", "5/8''", "3/4''", "7/8''", "1''", "1 1/8''", "1 1/4''", "1 3/8''", "1 1/2''", "1 5/8''", "1 3/4''", "2''", "2 1/4''", "2 1/2''", "2 3/4''", "3''", "3 1/2''", "4''", "4 1/2''", "5''"})
        Me.EspesorCBX.Location = New System.Drawing.Point(62, 42)
        Me.EspesorCBX.Name = "EspesorCBX"
        Me.EspesorCBX.Size = New System.Drawing.Size(120, 21)
        Me.EspesorCBX.TabIndex = 35
        Me.EspesorCBX.Visible = False
        '
        'ClienteCBX
        '
        Me.ClienteCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClienteCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ClienteCBX.DisplayMember = "NOMBRE"
        Me.ClienteCBX.FormattingEnabled = True
        Me.ClienteCBX.Location = New System.Drawing.Point(62, 42)
        Me.ClienteCBX.Name = "ClienteCBX"
        Me.ClienteCBX.Size = New System.Drawing.Size(120, 21)
        Me.ClienteCBX.TabIndex = 34
        Me.ClienteCBX.Visible = False
        '
        'FiltrarBTN
        '
        Me.FiltrarBTN.Location = New System.Drawing.Point(108, 82)
        Me.FiltrarBTN.Name = "FiltrarBTN"
        Me.FiltrarBTN.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarBTN.TabIndex = 32
        Me.FiltrarBTN.Text = "Filtrar"
        Me.FiltrarBTN.UseVisualStyleBackColor = True
        '
        'ObservacionesCBX
        '
        Me.ObservacionesCBX.Location = New System.Drawing.Point(62, 42)
        Me.ObservacionesCBX.Name = "ObservacionesCBX"
        Me.ObservacionesCBX.Size = New System.Drawing.Size(121, 20)
        Me.ObservacionesCBX.TabIndex = 24
        Me.ObservacionesCBX.Visible = False
        '
        'RestaurarBTN
        '
        Me.RestaurarBTN.Location = New System.Drawing.Point(87, 6)
        Me.RestaurarBTN.Name = "RestaurarBTN"
        Me.RestaurarBTN.Size = New System.Drawing.Size(75, 23)
        Me.RestaurarBTN.TabIndex = 2
        Me.RestaurarBTN.Text = "Restaurar"
        Me.RestaurarBTN.UseVisualStyleBackColor = True
        '
        'FiltroBTN
        '
        Me.FiltroBTN.Location = New System.Drawing.Point(6, 6)
        Me.FiltroBTN.Name = "FiltroBTN"
        Me.FiltroBTN.Size = New System.Drawing.Size(75, 23)
        Me.FiltroBTN.TabIndex = 1
        Me.FiltroBTN.Text = "Filtrar"
        Me.FiltroBTN.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ActualizarEntradas)
        Me.TabPage1.Controls.Add(Me.GBEntrada)
        Me.TabPage1.Controls.Add(Me.RestEntradaBTN)
        Me.TabPage1.Controls.Add(Me.FiltroEntradaBTN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1155, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entradas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ActualizarEntradas
        '
        Me.ActualizarEntradas.Location = New System.Drawing.Point(168, 6)
        Me.ActualizarEntradas.Name = "ActualizarEntradas"
        Me.ActualizarEntradas.Size = New System.Drawing.Size(75, 23)
        Me.ActualizarEntradas.TabIndex = 6
        Me.ActualizarEntradas.Text = "Actualizar"
        Me.ActualizarEntradas.UseVisualStyleBackColor = True
        '
        'GBEntrada
        '
        Me.GBEntrada.BackColor = System.Drawing.Color.LightGray
        Me.GBEntrada.Controls.Add(Me.SalidaEntrada)
        Me.GBEntrada.Controls.Add(Me.PesoEntrada)
        Me.GBEntrada.Controls.Add(Me.AnchoEntrada)
        Me.GBEntrada.Controls.Add(Me.FacturaEntrada)
        Me.GBEntrada.Controls.Add(Me.LargoEntrada)
        Me.GBEntrada.Controls.Add(Me.CalidadEntrada)
        Me.GBEntrada.Controls.Add(Me.OcEntrada)
        Me.GBEntrada.Controls.Add(Me.Label2)
        Me.GBEntrada.Controls.Add(Me.BuscarEntrada)
        Me.GBEntrada.Controls.Add(Me.NoClienteEntrada)
        Me.GBEntrada.Controls.Add(Me.NivelEntrada)
        Me.GBEntrada.Controls.Add(Me.RackEntrada)
        Me.GBEntrada.Controls.Add(Me.MateriaEntrada)
        Me.GBEntrada.Controls.Add(Me.EspesorEntrada)
        Me.GBEntrada.Controls.Add(Me.ClienteEntrada)
        Me.GBEntrada.Controls.Add(Me.CancelarEntrada)
        Me.GBEntrada.Controls.Add(Me.ObserEntradaTXT)
        Me.GBEntrada.Controls.Add(Me.FiltrarEntrada)
        Me.GBEntrada.Location = New System.Drawing.Point(479, 246)
        Me.GBEntrada.Name = "GBEntrada"
        Me.GBEntrada.Size = New System.Drawing.Size(195, 118)
        Me.GBEntrada.TabIndex = 5
        Me.GBEntrada.TabStop = False
        Me.GBEntrada.Text = "Filtrar"
        Me.GBEntrada.Visible = False
        '
        'SalidaEntrada
        '
        Me.SalidaEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SalidaEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.SalidaEntrada.DisplayMember = "FOLIO_SALIDA"
        Me.SalidaEntrada.FormattingEnabled = True
        Me.SalidaEntrada.Location = New System.Drawing.Point(62, 42)
        Me.SalidaEntrada.Name = "SalidaEntrada"
        Me.SalidaEntrada.Size = New System.Drawing.Size(120, 21)
        Me.SalidaEntrada.TabIndex = 49
        Me.SalidaEntrada.Visible = False
        '
        'PesoEntrada
        '
        Me.PesoEntrada.Location = New System.Drawing.Point(62, 42)
        Me.PesoEntrada.Name = "PesoEntrada"
        Me.PesoEntrada.Size = New System.Drawing.Size(120, 20)
        Me.PesoEntrada.TabIndex = 48
        Me.PesoEntrada.Visible = False
        '
        'AnchoEntrada
        '
        Me.AnchoEntrada.Location = New System.Drawing.Point(62, 42)
        Me.AnchoEntrada.Name = "AnchoEntrada"
        Me.AnchoEntrada.Size = New System.Drawing.Size(120, 20)
        Me.AnchoEntrada.TabIndex = 47
        Me.AnchoEntrada.Visible = False
        '
        'FacturaEntrada
        '
        Me.FacturaEntrada.Location = New System.Drawing.Point(62, 42)
        Me.FacturaEntrada.Name = "FacturaEntrada"
        Me.FacturaEntrada.Size = New System.Drawing.Size(120, 20)
        Me.FacturaEntrada.TabIndex = 46
        Me.FacturaEntrada.Visible = False
        '
        'LargoEntrada
        '
        Me.LargoEntrada.Location = New System.Drawing.Point(62, 42)
        Me.LargoEntrada.Name = "LargoEntrada"
        Me.LargoEntrada.Size = New System.Drawing.Size(120, 20)
        Me.LargoEntrada.TabIndex = 45
        Me.LargoEntrada.Visible = False
        '
        'CalidadEntrada
        '
        Me.CalidadEntrada.Location = New System.Drawing.Point(62, 42)
        Me.CalidadEntrada.Name = "CalidadEntrada"
        Me.CalidadEntrada.Size = New System.Drawing.Size(120, 20)
        Me.CalidadEntrada.TabIndex = 44
        Me.CalidadEntrada.Visible = False
        '
        'OcEntrada
        '
        Me.OcEntrada.Location = New System.Drawing.Point(62, 42)
        Me.OcEntrada.Name = "OcEntrada"
        Me.OcEntrada.Size = New System.Drawing.Size(120, 20)
        Me.OcEntrada.TabIndex = 43
        Me.OcEntrada.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Filtrar por:"
        '
        'BuscarEntrada
        '
        Me.BuscarEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BuscarEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BuscarEntrada.FormattingEnabled = True
        Me.BuscarEntrada.Items.AddRange(New Object() {"Cliente", "Factura/Remisión", "OC", "Certificado Calidad", "Largo", "Ancho", "Espesor", "Material", "Peso KG", "RACK", "Nivel", "Observaciones", "Salida"})
        Me.BuscarEntrada.Location = New System.Drawing.Point(62, 15)
        Me.BuscarEntrada.Name = "BuscarEntrada"
        Me.BuscarEntrada.Size = New System.Drawing.Size(121, 21)
        Me.BuscarEntrada.TabIndex = 42
        '
        'NoClienteEntrada
        '
        Me.NoClienteEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NoClienteEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NoClienteEntrada.DisplayMember = "NO_CLIENTE"
        Me.NoClienteEntrada.FormattingEnabled = True
        Me.NoClienteEntrada.Location = New System.Drawing.Point(62, 42)
        Me.NoClienteEntrada.Name = "NoClienteEntrada"
        Me.NoClienteEntrada.Size = New System.Drawing.Size(120, 21)
        Me.NoClienteEntrada.TabIndex = 40
        Me.NoClienteEntrada.Visible = False
        '
        'NivelEntrada
        '
        Me.NivelEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NivelEntrada.FormattingEnabled = True
        Me.NivelEntrada.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.NivelEntrada.Location = New System.Drawing.Point(62, 42)
        Me.NivelEntrada.Name = "NivelEntrada"
        Me.NivelEntrada.Size = New System.Drawing.Size(120, 21)
        Me.NivelEntrada.TabIndex = 38
        Me.NivelEntrada.Visible = False
        '
        'RackEntrada
        '
        Me.RackEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RackEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.RackEntrada.FormattingEnabled = True
        Me.RackEntrada.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "INT.", "EXT."})
        Me.RackEntrada.Location = New System.Drawing.Point(62, 42)
        Me.RackEntrada.Name = "RackEntrada"
        Me.RackEntrada.Size = New System.Drawing.Size(120, 21)
        Me.RackEntrada.TabIndex = 37
        Me.RackEntrada.Visible = False
        '
        'MateriaEntrada
        '
        Me.MateriaEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MateriaEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.MateriaEntrada.DisplayMember = "MATERIAL"
        Me.MateriaEntrada.FormattingEnabled = True
        Me.MateriaEntrada.Location = New System.Drawing.Point(62, 42)
        Me.MateriaEntrada.Name = "MateriaEntrada"
        Me.MateriaEntrada.Size = New System.Drawing.Size(120, 21)
        Me.MateriaEntrada.TabIndex = 36
        Me.MateriaEntrada.Visible = False
        '
        'EspesorEntrada
        '
        Me.EspesorEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EspesorEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EspesorEntrada.FormattingEnabled = True
        Me.EspesorEntrada.Items.AddRange(New Object() {"C. 6", "C. 7", "C. 8", "C. 9", "C. 10", "C. 11", "C. 12", "C. 13", "C. 14", "C. 15", "C. 16", "C. 18", "C. 19", "C. 20", "C. 22", "C. 24", "C. 26", "C. 28", "C. 30", "1/8''", "3/16''", "1/4''", "5/16''", "3/8''", "7/16''", "1/2''", "5/8''", "3/4''", "7/8''", "1''", "1 1/8''", "1 1/4''", "1 3/8''", "1 1/2''", "1 5/8''", "1 3/4''", "2''", "2 1/4''", "2 1/2''", "2 3/4''", "3''", "3 1/2''", "4''", "4 1/2''", "5''"})
        Me.EspesorEntrada.Location = New System.Drawing.Point(62, 42)
        Me.EspesorEntrada.Name = "EspesorEntrada"
        Me.EspesorEntrada.Size = New System.Drawing.Size(120, 21)
        Me.EspesorEntrada.TabIndex = 35
        Me.EspesorEntrada.Visible = False
        '
        'ClienteEntrada
        '
        Me.ClienteEntrada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClienteEntrada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ClienteEntrada.DisplayMember = "NOMBRE"
        Me.ClienteEntrada.FormattingEnabled = True
        Me.ClienteEntrada.Location = New System.Drawing.Point(62, 42)
        Me.ClienteEntrada.Name = "ClienteEntrada"
        Me.ClienteEntrada.Size = New System.Drawing.Size(120, 21)
        Me.ClienteEntrada.TabIndex = 34
        Me.ClienteEntrada.Visible = False
        '
        'CancelarEntrada
        '
        Me.CancelarEntrada.Location = New System.Drawing.Point(6, 82)
        Me.CancelarEntrada.Name = "CancelarEntrada"
        Me.CancelarEntrada.Size = New System.Drawing.Size(75, 23)
        Me.CancelarEntrada.TabIndex = 41
        Me.CancelarEntrada.Text = "Cancelar"
        Me.CancelarEntrada.UseVisualStyleBackColor = True
        '
        'ObserEntradaTXT
        '
        Me.ObserEntradaTXT.Location = New System.Drawing.Point(62, 42)
        Me.ObserEntradaTXT.Name = "ObserEntradaTXT"
        Me.ObserEntradaTXT.Size = New System.Drawing.Size(120, 20)
        Me.ObserEntradaTXT.TabIndex = 24
        Me.ObserEntradaTXT.Visible = False
        '
        'FiltrarEntrada
        '
        Me.FiltrarEntrada.Location = New System.Drawing.Point(108, 82)
        Me.FiltrarEntrada.Name = "FiltrarEntrada"
        Me.FiltrarEntrada.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarEntrada.TabIndex = 32
        Me.FiltrarEntrada.Text = "Filtrar"
        Me.FiltrarEntrada.UseVisualStyleBackColor = True
        '
        'RestEntradaBTN
        '
        Me.RestEntradaBTN.Location = New System.Drawing.Point(87, 6)
        Me.RestEntradaBTN.Name = "RestEntradaBTN"
        Me.RestEntradaBTN.Size = New System.Drawing.Size(75, 23)
        Me.RestEntradaBTN.TabIndex = 4
        Me.RestEntradaBTN.Text = "Restaurar"
        Me.RestEntradaBTN.UseVisualStyleBackColor = True
        '
        'FiltroEntradaBTN
        '
        Me.FiltroEntradaBTN.Location = New System.Drawing.Point(6, 6)
        Me.FiltroEntradaBTN.Name = "FiltroEntradaBTN"
        Me.FiltroEntradaBTN.Size = New System.Drawing.Size(75, 23)
        Me.FiltroEntradaBTN.TabIndex = 3
        Me.FiltroEntradaBTN.Text = "Filtrar"
        Me.FiltroEntradaBTN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ActualizarSalidas)
        Me.TabPage2.Controls.Add(Me.GBSalida)
        Me.TabPage2.Controls.Add(Me.RestSalidaBTN)
        Me.TabPage2.Controls.Add(Me.FiltroSalidaBTN)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1155, 627)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ActualizarSalidas
        '
        Me.ActualizarSalidas.Location = New System.Drawing.Point(168, 6)
        Me.ActualizarSalidas.Name = "ActualizarSalidas"
        Me.ActualizarSalidas.Size = New System.Drawing.Size(75, 23)
        Me.ActualizarSalidas.TabIndex = 6
        Me.ActualizarSalidas.Text = "Actualizar"
        Me.ActualizarSalidas.UseVisualStyleBackColor = True
        '
        'GBSalida
        '
        Me.GBSalida.BackColor = System.Drawing.Color.LightGray
        Me.GBSalida.Controls.Add(Me.Label3)
        Me.GBSalida.Controls.Add(Me.ObservSalidas)
        Me.GBSalida.Controls.Add(Me.AutorizaTXT)
        Me.GBSalida.Controls.Add(Me.LoteTXT)
        Me.GBSalida.Controls.Add(Me.SolicitanteTXT)
        Me.GBSalida.Controls.Add(Me.PITXT)
        Me.GBSalida.Controls.Add(Me.OFTXT)
        Me.GBSalida.Controls.Add(Me.BuscarSalida)
        Me.GBSalida.Controls.Add(Me.CancelarSalida)
        Me.GBSalida.Controls.Add(Me.FiltrarSalida)
        Me.GBSalida.Location = New System.Drawing.Point(479, 246)
        Me.GBSalida.Name = "GBSalida"
        Me.GBSalida.Size = New System.Drawing.Size(195, 118)
        Me.GBSalida.TabIndex = 5
        Me.GBSalida.TabStop = False
        Me.GBSalida.Text = "Filtrar"
        Me.GBSalida.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Filtrar por:"
        '
        'ObservSalidas
        '
        Me.ObservSalidas.Location = New System.Drawing.Point(62, 42)
        Me.ObservSalidas.Name = "ObservSalidas"
        Me.ObservSalidas.Size = New System.Drawing.Size(120, 20)
        Me.ObservSalidas.TabIndex = 48
        Me.ObservSalidas.Visible = False
        '
        'AutorizaTXT
        '
        Me.AutorizaTXT.Location = New System.Drawing.Point(62, 42)
        Me.AutorizaTXT.Name = "AutorizaTXT"
        Me.AutorizaTXT.Size = New System.Drawing.Size(120, 20)
        Me.AutorizaTXT.TabIndex = 47
        Me.AutorizaTXT.Visible = False
        '
        'LoteTXT
        '
        Me.LoteTXT.Location = New System.Drawing.Point(62, 42)
        Me.LoteTXT.Name = "LoteTXT"
        Me.LoteTXT.Size = New System.Drawing.Size(120, 20)
        Me.LoteTXT.TabIndex = 46
        Me.LoteTXT.Visible = False
        '
        'SolicitanteTXT
        '
        Me.SolicitanteTXT.Location = New System.Drawing.Point(62, 42)
        Me.SolicitanteTXT.Name = "SolicitanteTXT"
        Me.SolicitanteTXT.Size = New System.Drawing.Size(120, 20)
        Me.SolicitanteTXT.TabIndex = 45
        Me.SolicitanteTXT.Visible = False
        '
        'PITXT
        '
        Me.PITXT.Location = New System.Drawing.Point(62, 42)
        Me.PITXT.Name = "PITXT"
        Me.PITXT.Size = New System.Drawing.Size(120, 20)
        Me.PITXT.TabIndex = 44
        Me.PITXT.Visible = False
        '
        'OFTXT
        '
        Me.OFTXT.Location = New System.Drawing.Point(62, 42)
        Me.OFTXT.Name = "OFTXT"
        Me.OFTXT.Size = New System.Drawing.Size(120, 20)
        Me.OFTXT.TabIndex = 43
        Me.OFTXT.Visible = False
        '
        'BuscarSalida
        '
        Me.BuscarSalida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BuscarSalida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BuscarSalida.FormattingEnabled = True
        Me.BuscarSalida.Items.AddRange(New Object() {"OF", "PI", "Solicitante", "Lote", "Autorización", "Observaciones"})
        Me.BuscarSalida.Location = New System.Drawing.Point(62, 15)
        Me.BuscarSalida.Name = "BuscarSalida"
        Me.BuscarSalida.Size = New System.Drawing.Size(121, 21)
        Me.BuscarSalida.TabIndex = 42
        '
        'CancelarSalida
        '
        Me.CancelarSalida.Location = New System.Drawing.Point(6, 82)
        Me.CancelarSalida.Name = "CancelarSalida"
        Me.CancelarSalida.Size = New System.Drawing.Size(75, 23)
        Me.CancelarSalida.TabIndex = 41
        Me.CancelarSalida.Text = "Cancelar"
        Me.CancelarSalida.UseVisualStyleBackColor = True
        '
        'FiltrarSalida
        '
        Me.FiltrarSalida.Location = New System.Drawing.Point(108, 82)
        Me.FiltrarSalida.Name = "FiltrarSalida"
        Me.FiltrarSalida.Size = New System.Drawing.Size(75, 23)
        Me.FiltrarSalida.TabIndex = 32
        Me.FiltrarSalida.Text = "Filtrar"
        Me.FiltrarSalida.UseVisualStyleBackColor = True
        '
        'RestSalidaBTN
        '
        Me.RestSalidaBTN.Location = New System.Drawing.Point(87, 6)
        Me.RestSalidaBTN.Name = "RestSalidaBTN"
        Me.RestSalidaBTN.Size = New System.Drawing.Size(75, 23)
        Me.RestSalidaBTN.TabIndex = 4
        Me.RestSalidaBTN.Text = "Restaurar"
        Me.RestSalidaBTN.UseVisualStyleBackColor = True
        '
        'FiltroSalidaBTN
        '
        Me.FiltroSalidaBTN.Location = New System.Drawing.Point(6, 6)
        Me.FiltroSalidaBTN.Name = "FiltroSalidaBTN"
        Me.FiltroSalidaBTN.Size = New System.Drawing.Size(75, 23)
        Me.FiltroSalidaBTN.TabIndex = 3
        Me.FiltroSalidaBTN.Text = "Filtrar"
        Me.FiltroSalidaBTN.UseVisualStyleBackColor = True
        '
        'InventarioMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 677)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventarioMP"
        Me.Text = "Inventario FTM"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.FiltroMpGroup.ResumeLayout(False)
        Me.FiltroMpGroup.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GBEntrada.ResumeLayout(False)
        Me.GBEntrada.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GBSalida.ResumeLayout(False)
        Me.GBSalida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ActualizarInvent As Button
    Friend WithEvents FiltroMpGroup As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PesoTXT As TextBox
    Friend WithEvents AnchoTXT As TextBox
    Friend WithEvents FacturaTXT As TextBox
    Friend WithEvents LargoTXT As TextBox
    Friend WithEvents CalidadTXT As TextBox
    Friend WithEvents ocTXT As TextBox
    Friend WithEvents Buscar As ComboBox
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents NoClienteCBX As ComboBox
    Friend WithEvents NivelCBX As ComboBox
    Friend WithEvents RackCBX As ComboBox
    Friend WithEvents MaterialCBX As ComboBox
    Friend WithEvents EspesorCBX As ComboBox
    Friend WithEvents ClienteCBX As ComboBox
    Friend WithEvents FiltrarBTN As Button
    Friend WithEvents ObservacionesCBX As TextBox
    Friend WithEvents RestaurarBTN As Button
    Friend WithEvents FiltroBTN As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ActualizarEntradas As Button
    Friend WithEvents GBEntrada As GroupBox
    Friend WithEvents SalidaEntrada As ComboBox
    Friend WithEvents PesoEntrada As TextBox
    Friend WithEvents AnchoEntrada As TextBox
    Friend WithEvents FacturaEntrada As TextBox
    Friend WithEvents LargoEntrada As TextBox
    Friend WithEvents CalidadEntrada As TextBox
    Friend WithEvents OcEntrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BuscarEntrada As ComboBox
    Friend WithEvents NoClienteEntrada As ComboBox
    Friend WithEvents NivelEntrada As ComboBox
    Friend WithEvents RackEntrada As ComboBox
    Friend WithEvents MateriaEntrada As ComboBox
    Friend WithEvents EspesorEntrada As ComboBox
    Friend WithEvents ClienteEntrada As ComboBox
    Friend WithEvents CancelarEntrada As Button
    Friend WithEvents ObserEntradaTXT As TextBox
    Friend WithEvents FiltrarEntrada As Button
    Friend WithEvents RestEntradaBTN As Button
    Friend WithEvents FiltroEntradaBTN As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ActualizarSalidas As Button
    Friend WithEvents GBSalida As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ObservSalidas As TextBox
    Friend WithEvents AutorizaTXT As TextBox
    Friend WithEvents LoteTXT As TextBox
    Friend WithEvents SolicitanteTXT As TextBox
    Friend WithEvents PITXT As TextBox
    Friend WithEvents OFTXT As TextBox
    Friend WithEvents BuscarSalida As ComboBox
    Friend WithEvents CancelarSalida As Button
    Friend WithEvents FiltrarSalida As Button
    Friend WithEvents RestSalidaBTN As Button
    Friend WithEvents FiltroSalidaBTN As Button
End Class
