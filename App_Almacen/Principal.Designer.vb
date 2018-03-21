<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Reg_entradas = New System.Windows.Forms.Button()
        Me.Reg_Salidas = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
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
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes = New App_Almacen.Clientes()
        Me.NivelCBX = New System.Windows.Forms.ComboBox()
        Me.IventariosMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MPClienteDataSet = New App_Almacen.MPClienteDataSet()
        Me.RackCBX = New System.Windows.Forms.ComboBox()
        Me.MaterialCBX = New System.Windows.Forms.ComboBox()
        Me.EspesorCBX = New System.Windows.Forms.ComboBox()
        Me.ClienteCBX = New System.Windows.Forms.ComboBox()
        Me.FiltrarBTN = New System.Windows.Forms.Button()
        Me.ObservacionesCBX = New System.Windows.Forms.TextBox()
        Me.RestaurarBTN = New System.Windows.Forms.Button()
        Me.FiltroBTN = New System.Windows.Forms.Button()
        Me.BusquedaCBX = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GBEntrada = New System.Windows.Forms.GroupBox()
        Me.SalidaEntrada = New System.Windows.Forms.ComboBox()
        Me.ENTRADASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ENTRADASDataGridView = New System.Windows.Forms.DataGridView()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.SalidaDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EntradasFSW = New System.IO.FileSystemWatcher()
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.TableAdapterManager = New App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager()
        Me.SALIDASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.SALIDASTableAdapter()
        Me.InventarioMPTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.InventarioMPTableAdapter()
        Me.CLIENTESTableAdapter = New App_Almacen.ClientesTableAdapters.CLIENTESTableAdapter()
        Me.ENTRADASSALIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENTRADASSALIDASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBTN = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOLIO_SALIDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActualizarInvent = New System.Windows.Forms.Button()
        Me.ActualizarEntradas = New System.Windows.Forms.Button()
        Me.ActualizarSalidas = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FiltroMpGroup.SuspendLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IventariosMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusquedaCBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GBEntrada.SuspendLayout()
        CType(Me.ENTRADASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GBSalida.SuspendLayout()
        CType(Me.SalidaDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASSALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASSALIDASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reg_entradas
        '
        Me.Reg_entradas.Location = New System.Drawing.Point(12, 85)
        Me.Reg_entradas.Name = "Reg_entradas"
        Me.Reg_entradas.Size = New System.Drawing.Size(75, 39)
        Me.Reg_entradas.TabIndex = 2
        Me.Reg_entradas.Text = "Registro Entradas"
        Me.Reg_entradas.UseVisualStyleBackColor = True
        '
        'Reg_Salidas
        '
        Me.Reg_Salidas.Location = New System.Drawing.Point(12, 130)
        Me.Reg_Salidas.Name = "Reg_Salidas"
        Me.Reg_Salidas.Size = New System.Drawing.Size(75, 39)
        Me.Reg_Salidas.TabIndex = 3
        Me.Reg_Salidas.Text = "Registro Salidas"
        Me.Reg_Salidas.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(93, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1046, 533)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ActualizarInvent)
        Me.TabPage3.Controls.Add(Me.FiltroMpGroup)
        Me.TabPage3.Controls.Add(Me.RestaurarBTN)
        Me.TabPage3.Controls.Add(Me.FiltroBTN)
        Me.TabPage3.Controls.Add(Me.BusquedaCBX)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1038, 507)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventario MP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FiltroMpGroup
        '
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
        Me.FiltroMpGroup.Location = New System.Drawing.Point(381, 193)
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
        Me.NoClienteCBX.DataSource = Me.CLIENTESBindingSource
        Me.NoClienteCBX.DisplayMember = "NO_CLIENTE"
        Me.NoClienteCBX.FormattingEnabled = True
        Me.NoClienteCBX.Location = New System.Drawing.Point(62, 42)
        Me.NoClienteCBX.Name = "NoClienteCBX"
        Me.NoClienteCBX.Size = New System.Drawing.Size(120, 21)
        Me.NoClienteCBX.TabIndex = 40
        Me.NoClienteCBX.Visible = False
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.Clientes
        '
        'Clientes
        '
        Me.Clientes.DataSetName = "Clientes"
        Me.Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NivelCBX
        '
        Me.NivelCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.NivelCBX.DataSource = Me.IventariosMPBindingSource
        Me.NivelCBX.DisplayMember = "NIVEL"
        Me.NivelCBX.FormattingEnabled = True
        Me.NivelCBX.Location = New System.Drawing.Point(62, 42)
        Me.NivelCBX.Name = "NivelCBX"
        Me.NivelCBX.Size = New System.Drawing.Size(120, 21)
        Me.NivelCBX.TabIndex = 38
        Me.NivelCBX.Visible = False
        '
        'IventariosMPBindingSource
        '
        Me.IventariosMPBindingSource.DataMember = "IventariosMP"
        Me.IventariosMPBindingSource.DataSource = Me.MPClienteDataSet
        '
        'MPClienteDataSet
        '
        Me.MPClienteDataSet.DataSetName = "MPClienteDataSet"
        Me.MPClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RackCBX
        '
        Me.RackCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RackCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.RackCBX.DataSource = Me.IventariosMPBindingSource
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
        Me.MaterialCBX.DataSource = Me.IventariosMPBindingSource
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
        Me.ClienteCBX.DataSource = Me.CLIENTESBindingSource
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
        'BusquedaCBX
        '
        Me.BusquedaCBX.AllowUserToAddRows = False
        Me.BusquedaCBX.AllowUserToDeleteRows = False
        Me.BusquedaCBX.AllowUserToOrderColumns = True
        Me.BusquedaCBX.AutoGenerateColumns = False
        Me.BusquedaCBX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusquedaCBX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn49})
        Me.BusquedaCBX.DataSource = Me.IventariosMPBindingSource
        Me.BusquedaCBX.Location = New System.Drawing.Point(6, 35)
        Me.BusquedaCBX.Name = "BusquedaCBX"
        Me.BusquedaCBX.ReadOnly = True
        Me.BusquedaCBX.Size = New System.Drawing.Size(1026, 466)
        Me.BusquedaCBX.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ActualizarEntradas)
        Me.TabPage1.Controls.Add(Me.GBEntrada)
        Me.TabPage1.Controls.Add(Me.RestEntradaBTN)
        Me.TabPage1.Controls.Add(Me.FiltroEntradaBTN)
        Me.TabPage1.Controls.Add(Me.ENTRADASDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1038, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entradas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GBEntrada
        '
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
        Me.GBEntrada.Location = New System.Drawing.Point(408, 194)
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
        Me.SalidaEntrada.DataSource = Me.ENTRADASBindingSource1
        Me.SalidaEntrada.DisplayMember = "FOLIO_SALIDA"
        Me.SalidaEntrada.FormattingEnabled = True
        Me.SalidaEntrada.Location = New System.Drawing.Point(62, 42)
        Me.SalidaEntrada.Name = "SalidaEntrada"
        Me.SalidaEntrada.Size = New System.Drawing.Size(120, 21)
        Me.SalidaEntrada.TabIndex = 49
        Me.SalidaEntrada.Visible = False
        '
        'ENTRADASBindingSource1
        '
        Me.ENTRADASBindingSource1.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource1.DataSource = Me.MPClienteDataSet
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
        Me.NoClienteEntrada.DataSource = Me.CLIENTESBindingSource
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
        Me.MateriaEntrada.DataSource = Me.ENTRADASBindingSource1
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
        Me.ClienteEntrada.DataSource = Me.CLIENTESBindingSource
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
        'ENTRADASDataGridView
        '
        Me.ENTRADASDataGridView.AllowUserToAddRows = False
        Me.ENTRADASDataGridView.AllowUserToDeleteRows = False
        Me.ENTRADASDataGridView.AllowUserToOrderColumns = True
        Me.ENTRADASDataGridView.AutoGenerateColumns = False
        Me.ENTRADASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ENTRADASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FOLIO_SALIDA, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ENTRADASDataGridView.DataSource = Me.ENTRADASBindingSource
        Me.ENTRADASDataGridView.Location = New System.Drawing.Point(3, 35)
        Me.ENTRADASDataGridView.Name = "ENTRADASDataGridView"
        Me.ENTRADASDataGridView.ReadOnly = True
        Me.ENTRADASDataGridView.Size = New System.Drawing.Size(1029, 466)
        Me.ENTRADASDataGridView.TabIndex = 0
        '
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ActualizarSalidas)
        Me.TabPage2.Controls.Add(Me.GBSalida)
        Me.TabPage2.Controls.Add(Me.RestSalidaBTN)
        Me.TabPage2.Controls.Add(Me.FiltroSalidaBTN)
        Me.TabPage2.Controls.Add(Me.SalidaDGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1038, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GBSalida
        '
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
        Me.GBSalida.Location = New System.Drawing.Point(408, 194)
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
        'SalidaDGV
        '
        Me.SalidaDGV.AllowUserToAddRows = False
        Me.SalidaDGV.AllowUserToDeleteRows = False
        Me.SalidaDGV.AllowUserToOrderColumns = True
        Me.SalidaDGV.AutoGenerateColumns = False
        Me.SalidaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalidaDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.PI, Me.SOLICITANTE, Me.LOTE, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.SalidaDGV.DataSource = Me.SALIDASBindingSource
        Me.SalidaDGV.Location = New System.Drawing.Point(6, 35)
        Me.SalidaDGV.Name = "SalidaDGV"
        Me.SalidaDGV.ReadOnly = True
        Me.SalidaDGV.Size = New System.Drawing.Size(1026, 469)
        Me.SalidaDGV.TabIndex = 0
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "FOLIO_SALIDA"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Folio Salida"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 86
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Folio Entrada"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 94
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FECHA_SALIDA"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fecha Salida"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 94
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "OF"
        Me.DataGridViewTextBoxColumn27.HeaderText = "OF"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 46
        '
        'PI
        '
        Me.PI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PI.DataPropertyName = "PI"
        Me.PI.HeaderText = "PI"
        Me.PI.Name = "PI"
        Me.PI.ReadOnly = True
        Me.PI.Width = 42
        '
        'SOLICITANTE
        '
        Me.SOLICITANTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SOLICITANTE.DataPropertyName = "SOLICITANTE"
        Me.SOLICITANTE.HeaderText = "Solicitante"
        Me.SOLICITANTE.Name = "SOLICITANTE"
        Me.SOLICITANTE.ReadOnly = True
        Me.SOLICITANTE.Width = 81
        '
        'LOTE
        '
        Me.LOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LOTE.DataPropertyName = "LOTE"
        Me.LOTE.HeaderText = "Lote"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.ReadOnly = True
        Me.LOTE.Width = 53
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "AUTORIZACION"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Autorización"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 90
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "OBSERVACIONES_SALIDA"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 103
        '
        'SALIDASBindingSource
        '
        Me.SALIDASBindingSource.DataMember = "SALIDAS"
        Me.SALIDASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'EntradasFSW
        '
        Me.EntradasFSW.EnableRaisingEvents = True
        Me.EntradasFSW.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.EntradasFSW.Path = "S:\BASE DE DATOS\Almacén"
        Me.EntradasFSW.SynchronizingObject = Me
        '
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENTRADASTableAdapter = Me.ENTRADASTableAdapter
        Me.TableAdapterManager.InventarioMPTableAdapter = Nothing
        Me.TableAdapterManager.SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SALIDASTableAdapter
        '
        Me.SALIDASTableAdapter.ClearBeforeFill = True
        '
        'InventarioMPTableAdapter
        '
        Me.InventarioMPTableAdapter.ClearBeforeFill = True
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'ENTRADASSALIDASBindingSource
        '
        Me.ENTRADASSALIDASBindingSource.DataMember = "ENTRADASSALIDAS"
        Me.ENTRADASSALIDASBindingSource.DataSource = Me.ENTRADASBindingSource
        '
        'ENTRADASSALIDASBindingSource1
        '
        Me.ENTRADASSALIDASBindingSource1.DataMember = "ENTRADASSALIDAS"
        Me.ENTRADASSALIDASBindingSource1.DataSource = Me.ENTRADASBindingSource
        '
        'ClientesBTN
        '
        Me.ClientesBTN.Location = New System.Drawing.Point(12, 40)
        Me.ClientesBTN.Name = "ClientesBTN"
        Me.ClientesBTN.Size = New System.Drawing.Size(75, 39)
        Me.ClientesBTN.TabIndex = 6
        Me.ClientesBTN.Text = "Alta Clientes"
        Me.ClientesBTN.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Folio Entrada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 94
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 62
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 64
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "FACTURA_REMISION"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Factura/Remisión"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 116
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "OC"
        Me.DataGridViewTextBoxColumn33.HeaderText = "OC"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 47
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "CERTIFICADO_CALIDAD"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Certificado Calidad"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 110
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "LARGO"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 59
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "ANCHO"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 63
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ESPESOR"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Espesor"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Width = 70
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "MATERIAL"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 69
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "PESO_KG"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Peso KG"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 69
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "RACK"
        Me.DataGridViewTextBoxColumn40.HeaderText = "RACK"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 61
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "NIVEL"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Width = 56
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "OBSERVACIONES_ENTRADA"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Width = 103
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "LOTE"
        Me.DataGridViewTextBoxColumn43.HeaderText = "LOTE"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "FOLIO_SALIDA"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Folio Salida"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        Me.DataGridViewTextBoxColumn49.Width = 79
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 54
        '
        'FOLIO_SALIDA
        '
        Me.FOLIO_SALIDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FOLIO_SALIDA.DataPropertyName = "FOLIO_SALIDA"
        Me.FOLIO_SALIDA.HeaderText = "Salida"
        Me.FOLIO_SALIDA.Name = "FOLIO_SALIDA"
        Me.FOLIO_SALIDA.ReadOnly = True
        Me.FOLIO_SALIDA.Width = 61
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 62
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 64
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FACTURA_REMISION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Factura/Remisión"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 116
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OC"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CERTIFICADO_CALIDAD"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Certificado Calidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LARGO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 59
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ANCHO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 63
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ESPESOR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Espesor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MATERIAL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 69
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "RACK"
        Me.DataGridViewTextBoxColumn14.HeaderText = "RACK"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 61
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NIVEL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 56
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "OBSERVACIONES_ENTRADA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 103
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "LOTE"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
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
        'ActualizarEntradas
        '
        Me.ActualizarEntradas.Location = New System.Drawing.Point(168, 6)
        Me.ActualizarEntradas.Name = "ActualizarEntradas"
        Me.ActualizarEntradas.Size = New System.Drawing.Size(75, 23)
        Me.ActualizarEntradas.TabIndex = 6
        Me.ActualizarEntradas.Text = "Actualizar"
        Me.ActualizarEntradas.UseVisualStyleBackColor = True
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
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 557)
        Me.Controls.Add(Me.ClientesBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Reg_Salidas)
        Me.Controls.Add(Me.Reg_entradas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apps Almacén"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.FiltroMpGroup.ResumeLayout(False)
        Me.FiltroMpGroup.PerformLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IventariosMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusquedaCBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.GBEntrada.ResumeLayout(False)
        Me.GBEntrada.PerformLayout()
        CType(Me.ENTRADASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GBSalida.ResumeLayout(False)
        Me.GBSalida.PerformLayout()
        CType(Me.SalidaDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASSALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASSALIDASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reg_entradas As Button
    Friend WithEvents Reg_Salidas As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MPClienteDataSet As MPClienteDataSet
    Friend WithEvents ENTRADASBindingSource As BindingSource
    Friend WithEvents ENTRADASTableAdapter As MPClienteDataSetTableAdapters.ENTRADASTableAdapter
    Friend WithEvents TableAdapterManager As MPClienteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ENTRADASDataGridView As DataGridView
    Friend WithEvents SALIDASBindingSource As BindingSource
    Friend WithEvents SALIDASTableAdapter As MPClienteDataSetTableAdapters.SALIDASTableAdapter
    Friend WithEvents SalidaDGV As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents EntradasFSW As IO.FileSystemWatcher
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents IventariosMPBindingSource As BindingSource
    Friend WithEvents InventarioMPTableAdapter As MPClienteDataSetTableAdapters.InventarioMPTableAdapter
    Friend WithEvents BusquedaCBX As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents PI As DataGridViewTextBoxColumn
    Friend WithEvents SOLICITANTE As DataGridViewTextBoxColumn
    Friend WithEvents LOTE As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents FiltroBTN As Button
    Friend WithEvents RestaurarBTN As Button
    Friend WithEvents FiltroMpGroup As GroupBox
    Friend WithEvents NoClienteCBX As ComboBox
    Friend WithEvents NivelCBX As ComboBox
    Friend WithEvents RackCBX As ComboBox
    Friend WithEvents MaterialCBX As ComboBox
    Friend WithEvents ClienteCBX As ComboBox
    Friend WithEvents FiltrarBTN As Button
    Friend WithEvents ObservacionesCBX As TextBox
    Friend WithEvents Clientes As Clientes
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As ClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents ENTRADASSALIDASBindingSource As BindingSource
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents Buscar As ComboBox
    Friend WithEvents PesoTXT As TextBox
    Friend WithEvents AnchoTXT As TextBox
    Friend WithEvents FacturaTXT As TextBox
    Friend WithEvents LargoTXT As TextBox
    Friend WithEvents CalidadTXT As TextBox
    Friend WithEvents ocTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EspesorCBX As ComboBox
    Friend WithEvents GBEntrada As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PesoEntrada As TextBox
    Friend WithEvents AnchoEntrada As TextBox
    Friend WithEvents FacturaEntrada As TextBox
    Friend WithEvents LargoEntrada As TextBox
    Friend WithEvents CalidadEntrada As TextBox
    Friend WithEvents OcEntrada As TextBox
    Friend WithEvents BuscarEntrada As ComboBox
    Friend WithEvents CancelarEntrada As Button
    Friend WithEvents NoClienteEntrada As ComboBox
    Friend WithEvents NivelEntrada As ComboBox
    Friend WithEvents RackEntrada As ComboBox
    Friend WithEvents MateriaEntrada As ComboBox
    Friend WithEvents EspesorEntrada As ComboBox
    Friend WithEvents ClienteEntrada As ComboBox
    Friend WithEvents FiltrarEntrada As Button
    Friend WithEvents ObserEntradaTXT As TextBox
    Friend WithEvents RestEntradaBTN As Button
    Friend WithEvents FiltroEntradaBTN As Button
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
    Friend WithEvents SalidaEntrada As ComboBox
    Friend WithEvents ENTRADASBindingSource1 As BindingSource
    Friend WithEvents ENTRADASSALIDASBindingSource1 As BindingSource
    Friend WithEvents ClientesBTN As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FOLIO_SALIDA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents ActualizarInvent As Button
    Friend WithEvents ActualizarEntradas As Button
    Friend WithEvents ActualizarSalidas As Button
End Class
