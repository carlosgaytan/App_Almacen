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
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ENTRADASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ENTRADASBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ENTRADASDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SALIDASDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.FiltroMpGroup.SuspendLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IventariosMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusquedaCBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.ENTRADASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ENTRADASBindingNavigator.SuspendLayout()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SALIDASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASSALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reg_entradas
        '
        Me.Reg_entradas.Location = New System.Drawing.Point(23, 57)
        Me.Reg_entradas.Name = "Reg_entradas"
        Me.Reg_entradas.Size = New System.Drawing.Size(75, 39)
        Me.Reg_entradas.TabIndex = 2
        Me.Reg_entradas.Text = "Registro Entradas"
        Me.Reg_entradas.UseVisualStyleBackColor = True
        '
        'Reg_Salidas
        '
        Me.Reg_Salidas.Location = New System.Drawing.Point(23, 111)
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
        Me.TabControl1.Location = New System.Drawing.Point(121, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1018, 533)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FiltroMpGroup)
        Me.TabPage3.Controls.Add(Me.RestaurarBTN)
        Me.TabPage3.Controls.Add(Me.FiltroBTN)
        Me.TabPage3.Controls.Add(Me.BusquedaCBX)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1010, 507)
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
        Me.Buscar.Items.AddRange(New Object() {"Folio Entrada", "Fecha", "Cliente", "Factura/Remisión", "OC", "Certificado Calidad", "Largo", "Ancho", "Espesor", "Material", "Peso KG", "RACK", "Nivel", "Observaciones"})
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
        Me.ObservacionesCBX.Size = New System.Drawing.Size(120, 20)
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
        Me.BusquedaCBX.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49})
        Me.BusquedaCBX.DataSource = Me.IventariosMPBindingSource
        Me.BusquedaCBX.Location = New System.Drawing.Point(6, 35)
        Me.BusquedaCBX.Name = "BusquedaCBX"
        Me.BusquedaCBX.ReadOnly = True
        Me.BusquedaCBX.Size = New System.Drawing.Size(998, 466)
        Me.BusquedaCBX.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Folio Entrada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 87
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
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "LOTE_DIA"
        Me.DataGridViewTextBoxColumn43.HeaderText = "LOTE_DIA"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Width = 84
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "LOTE_MES"
        Me.DataGridViewTextBoxColumn44.HeaderText = "LOTE_MES"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Width = 89
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "LOTE_AÑO"
        Me.DataGridViewTextBoxColumn45.HeaderText = "LOTE_AÑO"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 89
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "LOTE_CLIENTE"
        Me.DataGridViewTextBoxColumn46.HeaderText = "LOTE_CLIENTE"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 111
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "LOTE_MATERIAL"
        Me.DataGridViewTextBoxColumn47.HeaderText = "LOTE_MATERIAL"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Width = 120
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "LOTE_FOLIO"
        Me.DataGridViewTextBoxColumn48.HeaderText = "LOTE_FOLIO"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Width = 97
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "FOLIO_SALIDA"
        Me.DataGridViewTextBoxColumn49.HeaderText = "Folio Salida"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ENTRADASBindingNavigator)
        Me.TabPage1.Controls.Add(Me.ENTRADASDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1010, 507)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entradas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ENTRADASBindingNavigator
        '
        Me.ENTRADASBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ENTRADASBindingNavigator.BindingSource = Me.ENTRADASBindingSource
        Me.ENTRADASBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ENTRADASBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ENTRADASBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ENTRADASBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ENTRADASBindingNavigatorSaveItem})
        Me.ENTRADASBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.ENTRADASBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ENTRADASBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ENTRADASBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ENTRADASBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ENTRADASBindingNavigator.Name = "ENTRADASBindingNavigator"
        Me.ENTRADASBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ENTRADASBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.ENTRADASBindingNavigator.TabIndex = 6
        Me.ENTRADASBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ENTRADASBindingNavigatorSaveItem
        '
        Me.ENTRADASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ENTRADASBindingNavigatorSaveItem.Image = CType(resources.GetObject("ENTRADASBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ENTRADASBindingNavigatorSaveItem.Name = "ENTRADASBindingNavigatorSaveItem"
        Me.ENTRADASBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ENTRADASBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ENTRADASDataGridView
        '
        Me.ENTRADASDataGridView.AllowUserToAddRows = False
        Me.ENTRADASDataGridView.AllowUserToDeleteRows = False
        Me.ENTRADASDataGridView.AllowUserToOrderColumns = True
        Me.ENTRADASDataGridView.AutoGenerateColumns = False
        Me.ENTRADASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ENTRADASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FOLIO_SALIDA, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.ENTRADASDataGridView.DataSource = Me.ENTRADASBindingSource
        Me.ENTRADASDataGridView.Location = New System.Drawing.Point(3, 31)
        Me.ENTRADASDataGridView.Name = "ENTRADASDataGridView"
        Me.ENTRADASDataGridView.ReadOnly = True
        Me.ENTRADASDataGridView.Size = New System.Drawing.Size(1001, 470)
        Me.ENTRADASDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "LOTE_DIA"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Lote Día"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 69
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LOTE_MES"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Lote Mes"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 70
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "LOTE_AÑO"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Lote Año"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 69
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "LOTE_CLIENTE"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Lote Cliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 81
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "LOTE_MATERIAL"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Lote Material"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 86
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "LOTE_FOLIO"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Consecutivo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 91
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SALIDASDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1010, 507)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SALIDASDataGridView
        '
        Me.SALIDASDataGridView.AllowUserToAddRows = False
        Me.SALIDASDataGridView.AllowUserToDeleteRows = False
        Me.SALIDASDataGridView.AllowUserToOrderColumns = True
        Me.SALIDASDataGridView.AutoGenerateColumns = False
        Me.SALIDASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SALIDASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.PI, Me.SOLICITANTE, Me.LOTE, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.SALIDASDataGridView.DataSource = Me.SALIDASBindingSource
        Me.SALIDASDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SALIDASDataGridView.Name = "SALIDASDataGridView"
        Me.SALIDASDataGridView.ReadOnly = True
        Me.SALIDASDataGridView.Size = New System.Drawing.Size(998, 498)
        Me.SALIDASDataGridView.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Filtrar por:"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 557)
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
        Me.TabPage1.PerformLayout()
        CType(Me.ENTRADASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ENTRADASBindingNavigator.ResumeLayout(False)
        Me.ENTRADASBindingNavigator.PerformLayout()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SALIDASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASSALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ENTRADASBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ENTRADASBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ENTRADASDataGridView As DataGridView
    Friend WithEvents SALIDASBindingSource As BindingSource
    Friend WithEvents SALIDASTableAdapter As MPClienteDataSetTableAdapters.SALIDASTableAdapter
    Friend WithEvents SALIDASDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents EntradasFSW As IO.FileSystemWatcher
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents IventariosMPBindingSource As BindingSource
    Friend WithEvents InventarioMPTableAdapter As MPClienteDataSetTableAdapters.InventarioMPTableAdapter
    Friend WithEvents BusquedaCBX As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
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
End Class
