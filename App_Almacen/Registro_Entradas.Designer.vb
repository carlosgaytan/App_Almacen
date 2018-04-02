<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Entradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Entradas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaLBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolioLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FacturaTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CertificadoTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OCTXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClienteCBX = New System.Windows.Forms.ComboBox()
        Me.CLIENTESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes = New App_Almacen.Clientes()
        Me.LargoTXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AnchoTXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaterialTXT = New System.Windows.Forms.ComboBox()
        Me.MATERIALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATERIALES = New App_Almacen.MATERIALES()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EspesorTXT = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NivelTXT = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RackTXT = New System.Windows.Forms.ComboBox()
        Me.MPClienteDataSet = New App_Almacen.MPClienteDataSet()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.TableAdapterManager = New App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager()
        Me.CLIENTESTableAdapter = New App_Almacen.ClientesTableAdapters.CLIENTESTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ObservTXT = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mesTXT = New System.Windows.Forms.TextBox()
        Me.diaTXT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ConsecTXT = New System.Windows.Forms.TextBox()
        Me.yearTXT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Material = New System.Windows.Forms.TextBox()
        Me.ClienteTXT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PesoLBL = New System.Windows.Forms.Label()
        Me.MATERIALTableAdapter = New App_Almacen.MATERIALESTableAdapters.MATERIALTableAdapter()
        Me.BuscaMatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscaMatTableAdapter = New App_Almacen.MATERIALESTableAdapters.BuscaMatTableAdapter()
        Me.TableAdapterManager1 = New App_Almacen.MATERIALESTableAdapters.TableAdapterManager()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CalcPesoBTN = New System.Windows.Forms.Button()
        CType(Me.CLIENTESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BuscaMatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'FechaLBL
        '
        Me.FechaLBL.AutoSize = True
        Me.FechaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FechaLBL.Location = New System.Drawing.Point(66, 9)
        Me.FechaLBL.Name = "FechaLBL"
        Me.FechaLBL.Size = New System.Drawing.Size(57, 17)
        Me.FechaLBL.TabIndex = 1
        Me.FechaLBL.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(299, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio:"
        '
        'FolioLBL
        '
        Me.FolioLBL.AutoSize = True
        Me.FolioLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FolioLBL.Location = New System.Drawing.Point(353, 9)
        Me.FolioLBL.Name = "FolioLBL"
        Me.FolioLBL.Size = New System.Drawing.Size(57, 17)
        Me.FolioLBL.TabIndex = 3
        Me.FolioLBL.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente:"
        '
        'FacturaTXT
        '
        Me.FacturaTXT.Location = New System.Drawing.Point(106, 77)
        Me.FacturaTXT.Name = "FacturaTXT"
        Me.FacturaTXT.Size = New System.Drawing.Size(100, 20)
        Me.FacturaTXT.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Factura/Remisión:"
        '
        'CertificadoTXT
        '
        Me.CertificadoTXT.Location = New System.Drawing.Point(72, 103)
        Me.CertificadoTXT.Name = "CertificadoTXT"
        Me.CertificadoTXT.Size = New System.Drawing.Size(100, 20)
        Me.CertificadoTXT.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Certificado:"
        '
        'OCTXT
        '
        Me.OCTXT.Location = New System.Drawing.Point(54, 51)
        Me.OCTXT.Name = "OCTXT"
        Me.OCTXT.Size = New System.Drawing.Size(100, 20)
        Me.OCTXT.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "OC:"
        '
        'ClienteCBX
        '
        Me.ClienteCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClienteCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClienteCBX.DataSource = Me.CLIENTESBindingSource1
        Me.ClienteCBX.DisplayMember = "NOMBRE"
        Me.ClienteCBX.FormattingEnabled = True
        Me.ClienteCBX.Location = New System.Drawing.Point(54, 24)
        Me.ClienteCBX.Name = "ClienteCBX"
        Me.ClienteCBX.Size = New System.Drawing.Size(148, 21)
        Me.ClienteCBX.TabIndex = 12
        '
        'CLIENTESBindingSource1
        '
        Me.CLIENTESBindingSource1.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource1.DataSource = Me.ClientesBindingSource
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataSource = Me.Clientes
        Me.ClientesBindingSource.Position = 0
        '
        'Clientes
        '
        Me.Clientes.DataSetName = "Clientes"
        Me.Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LargoTXT
        '
        Me.LargoTXT.Location = New System.Drawing.Point(70, 22)
        Me.LargoTXT.Name = "LargoTXT"
        Me.LargoTXT.Size = New System.Drawing.Size(48, 20)
        Me.LargoTXT.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Largo MM:"
        '
        'AnchoTXT
        '
        Me.AnchoTXT.Location = New System.Drawing.Point(70, 48)
        Me.AnchoTXT.Name = "AnchoTXT"
        Me.AnchoTXT.Size = New System.Drawing.Size(48, 20)
        Me.AnchoTXT.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ancho MM:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(134, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Espesor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CalcPesoBTN)
        Me.GroupBox1.Controls.Add(Me.MaterialTXT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.EspesorTXT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LargoTXT)
        Me.GroupBox1.Controls.Add(Me.AnchoTXT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(238, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 107)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Material"
        '
        'MaterialTXT
        '
        Me.MaterialTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.MaterialTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MaterialTXT.DataSource = Me.MATERIALBindingSource
        Me.MaterialTXT.DisplayMember = "MATERIAL"
        Me.MaterialTXT.FormattingEnabled = True
        Me.MaterialTXT.Location = New System.Drawing.Point(187, 51)
        Me.MaterialTXT.Name = "MaterialTXT"
        Me.MaterialTXT.Size = New System.Drawing.Size(94, 21)
        Me.MaterialTXT.TabIndex = 20
        '
        'MATERIALBindingSource
        '
        Me.MATERIALBindingSource.DataMember = "MATERIAL"
        Me.MATERIALBindingSource.DataSource = Me.MATERIALES
        '
        'MATERIALES
        '
        Me.MATERIALES.DataSetName = "MATERIALES"
        Me.MATERIALES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(134, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Material:"
        '
        'EspesorTXT
        '
        Me.EspesorTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EspesorTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EspesorTXT.FormattingEnabled = True
        Me.EspesorTXT.Items.AddRange(New Object() {"C. 6", "C. 7", "C. 8", "C. 9", "C. 10", "C. 11", "C. 12", "C. 13", "C. 14", "C. 15", "C. 16", "C. 18", "C. 19", "C. 20", "C. 22", "C. 24", "C. 26", "C. 28", "C. 30", "1/8''", "3/16''", "1/4''", "5/16''", "3/8''", "7/16''", "1/2''", "5/8''", "3/4''", "7/8''", "1''", "1 1/8''", "1 1/4''", "1 3/8''", "1 1/2''", "1 5/8''", "1 3/4''", "2''", "2 1/4''", "2 1/2''", "2 3/4''", "3''", "3 1/2''", "4''", "4 1/2''", "5''"})
        Me.EspesorTXT.Location = New System.Drawing.Point(203, 22)
        Me.EspesorTXT.Name = "EspesorTXT"
        Me.EspesorTXT.Size = New System.Drawing.Size(78, 21)
        Me.EspesorTXT.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ClienteCBX)
        Me.GroupBox2.Controls.Add(Me.CertificadoTXT)
        Me.GroupBox2.Controls.Add(Me.OCTXT)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.FacturaTXT)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 171)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NivelTXT)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.RackTXT)
        Me.GroupBox3.Location = New System.Drawing.Point(238, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(293, 58)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ubicación"
        '
        'NivelTXT
        '
        Me.NivelTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NivelTXT.FormattingEnabled = True
        Me.NivelTXT.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.NivelTXT.Location = New System.Drawing.Point(165, 25)
        Me.NivelTXT.Name = "NivelTXT"
        Me.NivelTXT.Size = New System.Drawing.Size(70, 21)
        Me.NivelTXT.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(125, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Nivel:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Rack:"
        '
        'RackTXT
        '
        Me.RackTXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RackTXT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.RackTXT.FormattingEnabled = True
        Me.RackTXT.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "INT.", "EXT."})
        Me.RackTXT.Location = New System.Drawing.Point(48, 25)
        Me.RackTXT.Name = "RackTXT"
        Me.RackTXT.Size = New System.Drawing.Size(70, 21)
        Me.RackTXT.TabIndex = 21
        '
        'MPClienteDataSet
        '
        Me.MPClienteDataSet.DataSetName = "MPClienteDataSet"
        Me.MPClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENTRADAS1TableAdapter = Nothing
        Me.TableAdapterManager.ENTRADASTableAdapter = Me.ENTRADASTableAdapter
        Me.TableAdapterManager.InventarioMPTableAdapter = Nothing
        Me.TableAdapterManager.SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ObservTXT)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(519, 135)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Observaciones"
        '
        'ObservTXT
        '
        Me.ObservTXT.Location = New System.Drawing.Point(6, 19)
        Me.ObservTXT.Multiline = True
        Me.ObservTXT.Name = "ObservTXT"
        Me.ObservTXT.Size = New System.Drawing.Size(507, 110)
        Me.ObservTXT.TabIndex = 0
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(441, 417)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(90, 35)
        Me.GuardarBTN.TabIndex = 22
        Me.GuardarBTN.Text = "Guardar registro"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.mesTXT)
        Me.GroupBox5.Controls.Add(Me.diaTXT)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.ConsecTXT)
        Me.GroupBox5.Controls.Add(Me.yearTXT)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Material)
        Me.GroupBox5.Controls.Add(Me.ClienteTXT)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(178, 212)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(353, 58)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lote"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(226, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Material:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Día:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(175, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Cliente:"
        '
        'mesTXT
        '
        Me.mesTXT.Location = New System.Drawing.Point(64, 32)
        Me.mesTXT.Name = "mesTXT"
        Me.mesTXT.Size = New System.Drawing.Size(48, 20)
        Me.mesTXT.TabIndex = 21
        Me.mesTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'diaTXT
        '
        Me.diaTXT.Location = New System.Drawing.Point(10, 32)
        Me.diaTXT.Name = "diaTXT"
        Me.diaTXT.Size = New System.Drawing.Size(48, 20)
        Me.diaTXT.TabIndex = 33
        Me.diaTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(277, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Consecutivo:"
        '
        'ConsecTXT
        '
        Me.ConsecTXT.Location = New System.Drawing.Point(286, 32)
        Me.ConsecTXT.Name = "ConsecTXT"
        Me.ConsecTXT.Size = New System.Drawing.Size(48, 20)
        Me.ConsecTXT.TabIndex = 32
        Me.ConsecTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'yearTXT
        '
        Me.yearTXT.Location = New System.Drawing.Point(118, 32)
        Me.yearTXT.Name = "yearTXT"
        Me.yearTXT.Size = New System.Drawing.Size(48, 20)
        Me.yearTXT.TabIndex = 28
        Me.yearTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(128, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Año:"
        '
        'Material
        '
        Me.Material.Location = New System.Drawing.Point(226, 32)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(48, 20)
        Me.Material.TabIndex = 30
        Me.Material.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClienteTXT
        '
        Me.ClienteTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource1, "NO_CLIENTE", True))
        Me.ClienteTXT.Location = New System.Drawing.Point(172, 32)
        Me.ClienteTXT.Name = "ClienteTXT"
        Me.ClienteTXT.Size = New System.Drawing.Size(48, 20)
        Me.ClienteTXT.TabIndex = 31
        Me.ClienteTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(73, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Mes:"
        '
        'PesoLBL
        '
        Me.PesoLBL.AutoSize = True
        Me.PesoLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PesoLBL.Location = New System.Drawing.Point(45, 245)
        Me.PesoLBL.Name = "PesoLBL"
        Me.PesoLBL.Size = New System.Drawing.Size(89, 26)
        Me.PesoLBL.TabIndex = 30
        Me.PesoLBL.Text = "Label19"
        Me.PesoLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PesoLBL.Visible = False
        '
        'MATERIALTableAdapter
        '
        Me.MATERIALTableAdapter.ClearBeforeFill = True
        '
        'BuscaMatBindingSource
        '
        Me.BuscaMatBindingSource.DataMember = "BuscaMat"
        Me.BuscaMatBindingSource.DataSource = Me.MATERIALES
        '
        'BuscaMatTableAdapter
        '
        Me.BuscaMatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BuscaMatTableAdapter = Me.BuscaMatTableAdapter
        Me.TableAdapterManager1.MATERIALTableAdapter = Me.MATERIALTableAdapter
        Me.TableAdapterManager1.UpdateOrder = App_Almacen.MATERIALESTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 26)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Peso KG:"
        '
        'CalcPesoBTN
        '
        Me.CalcPesoBTN.Location = New System.Drawing.Point(212, 78)
        Me.CalcPesoBTN.Name = "CalcPesoBTN"
        Me.CalcPesoBTN.Size = New System.Drawing.Size(75, 23)
        Me.CalcPesoBTN.TabIndex = 32
        Me.CalcPesoBTN.Text = "Calc. Peso"
        Me.CalcPesoBTN.UseVisualStyleBackColor = True
        '
        'Registro_Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 460)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PesoLBL)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FolioLBL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FechaLBL)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Entradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Entradas MP"
        CType(Me.CLIENTESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BuscaMatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MPClienteDataSet As MPClienteDataSet
    Friend WithEvents ENTRADASBindingSource As BindingSource
    Friend WithEvents ENTRADASTableAdapter As MPClienteDataSetTableAdapters.ENTRADASTableAdapter
    Friend WithEvents TableAdapterManager As MPClienteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaLBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolioLBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FacturaTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CertificadoTXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OCTXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ClienteCBX As ComboBox
    Friend WithEvents LargoTXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AnchoTXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EspesorTXT As ComboBox
    Friend WithEvents MaterialTXT As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NivelTXT As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RackTXT As ComboBox
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents Clientes As Clientes
    Friend WithEvents CLIENTESBindingSource1 As BindingSource
    Friend WithEvents CLIENTESTableAdapter As ClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ObservTXT As TextBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents mesTXT As TextBox
    Friend WithEvents diaTXT As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ConsecTXT As TextBox
    Friend WithEvents yearTXT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Material As TextBox
    Friend WithEvents ClienteTXT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PesoLBL As Label
    Friend WithEvents MATERIALES As MATERIALES
    Friend WithEvents MATERIALBindingSource As BindingSource
    Friend WithEvents MATERIALTableAdapter As MATERIALESTableAdapters.MATERIALTableAdapter
    Friend WithEvents BuscaMatBindingSource As BindingSource
    Friend WithEvents BuscaMatTableAdapter As MATERIALESTableAdapters.BuscaMatTableAdapter
    Friend WithEvents TableAdapterManager1 As MATERIALESTableAdapters.TableAdapterManager
    Friend WithEvents Label19 As Label
    Friend WithEvents CalcPesoBTN As Button
End Class
