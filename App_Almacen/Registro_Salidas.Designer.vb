<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Salidas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Salidas))
        Me.MPClienteDataSet = New App_Almacen.MPClienteDataSet()
        Me.SALIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALIDASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.SALIDASTableAdapter()
        Me.TableAdapterManager = New App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager()
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.EntradaCBX = New System.Windows.Forms.ComboBox()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FechaLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SalidaLBL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConsecutivoLBL = New System.Windows.Forms.Label()
        Me.MatLBL = New System.Windows.Forms.Label()
        Me.ClienLBL = New System.Windows.Forms.Label()
        Me.YearLBL = New System.Windows.Forms.Label()
        Me.MesLBL = New System.Windows.Forms.Label()
        Me.DiaLBL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FacturaLBL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OCLBL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClienteLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PesoLBL = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaterialLBL = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.EspesorLBL = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AnchoLBL = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LargoLBL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NivelLBL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RackLBL = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AutorizaTXT = New System.Windows.Forms.TextBox()
        Me.SolicitanteTXT = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.piTXT = New System.Windows.Forms.TextBox()
        Me.ofTXT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LimpiarBTN = New System.Windows.Forms.Button()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComenSalidasTXT = New System.Windows.Forms.TextBox()
        Me.SalidaEntrada = New System.Windows.Forms.Label()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MPClienteDataSet
        '
        Me.MPClienteDataSet.DataSetName = "MPClienteDataSet"
        Me.MPClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALIDASBindingSource
        '
        Me.SALIDASBindingSource.DataMember = "SALIDAS"
        Me.SALIDASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'SALIDASTableAdapter
        '
        Me.SALIDASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENTRADASTableAdapter = Me.ENTRADASTableAdapter
        Me.TableAdapterManager.SALIDASTableAdapter = Me.SALIDASTableAdapter
        Me.TableAdapterManager.UpdateOrder = App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'EntradaCBX
        '
        Me.EntradaCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EntradaCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EntradaCBX.DataSource = Me.ENTRADASBindingSource
        Me.EntradaCBX.DisplayMember = "FOLIO_ENTRADA"
        Me.EntradaCBX.FormattingEnabled = True
        Me.EntradaCBX.Location = New System.Drawing.Point(113, 17)
        Me.EntradaCBX.Name = "EntradaCBX"
        Me.EntradaCBX.Size = New System.Drawing.Size(121, 21)
        Me.EntradaCBX.TabIndex = 0
        '
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio de Entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'FechaLBL
        '
        Me.FechaLBL.AutoSize = True
        Me.FechaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLBL.Location = New System.Drawing.Point(75, 9)
        Me.FechaLBL.Name = "FechaLBL"
        Me.FechaLBL.Size = New System.Drawing.Size(57, 17)
        Me.FechaLBL.TabIndex = 3
        Me.FechaLBL.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Folio Salida:"
        '
        'SalidaLBL
        '
        Me.SalidaLBL.AutoSize = True
        Me.SalidaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalidaLBL.Location = New System.Drawing.Point(449, 9)
        Me.SalidaLBL.Name = "SalidaLBL"
        Me.SalidaLBL.Size = New System.Drawing.Size(98, 17)
        Me.SalidaLBL.TabIndex = 4
        Me.SalidaLBL.Text = "Folio Salida:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConsecutivoLBL)
        Me.GroupBox1.Controls.Add(Me.MatLBL)
        Me.GroupBox1.Controls.Add(Me.ClienLBL)
        Me.GroupBox1.Controls.Add(Me.YearLBL)
        Me.GroupBox1.Controls.Add(Me.MesLBL)
        Me.GroupBox1.Controls.Add(Me.DiaLBL)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.FacturaLBL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.OCLBL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ClienteLBL)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EntradaCBX)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 72)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información General"
        '
        'ConsecutivoLBL
        '
        Me.ConsecutivoLBL.AutoSize = True
        Me.ConsecutivoLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_FOLIO", True))
        Me.ConsecutivoLBL.Location = New System.Drawing.Point(682, 49)
        Me.ConsecutivoLBL.Name = "ConsecutivoLBL"
        Me.ConsecutivoLBL.Size = New System.Drawing.Size(19, 13)
        Me.ConsecutivoLBL.TabIndex = 16
        Me.ConsecutivoLBL.Text = "00"
        '
        'MatLBL
        '
        Me.MatLBL.AutoSize = True
        Me.MatLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_MATERIAL", True))
        Me.MatLBL.Location = New System.Drawing.Point(653, 49)
        Me.MatLBL.Name = "MatLBL"
        Me.MatLBL.Size = New System.Drawing.Size(31, 13)
        Me.MatLBL.TabIndex = 15
        Me.MatLBL.Text = "GGG"
        '
        'ClienLBL
        '
        Me.ClienLBL.AutoSize = True
        Me.ClienLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_CLIENTE", True))
        Me.ClienLBL.Location = New System.Drawing.Point(622, 49)
        Me.ClienLBL.Name = "ClienLBL"
        Me.ClienLBL.Size = New System.Drawing.Size(31, 13)
        Me.ClienLBL.TabIndex = 14
        Me.ClienLBL.Text = "0100"
        '
        'YearLBL
        '
        Me.YearLBL.AutoSize = True
        Me.YearLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_AÑO", True))
        Me.YearLBL.Location = New System.Drawing.Point(592, 49)
        Me.YearLBL.Name = "YearLBL"
        Me.YearLBL.Size = New System.Drawing.Size(31, 13)
        Me.YearLBL.TabIndex = 13
        Me.YearLBL.Text = "0100"
        '
        'MesLBL
        '
        Me.MesLBL.AutoSize = True
        Me.MesLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_MES", True))
        Me.MesLBL.Location = New System.Drawing.Point(575, 49)
        Me.MesLBL.Name = "MesLBL"
        Me.MesLBL.Size = New System.Drawing.Size(19, 13)
        Me.MesLBL.TabIndex = 12
        Me.MesLBL.Text = "01"
        '
        'DiaLBL
        '
        Me.DiaLBL.AutoSize = True
        Me.DiaLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE_DIA", True))
        Me.DiaLBL.Location = New System.Drawing.Point(558, 49)
        Me.DiaLBL.Name = "DiaLBL"
        Me.DiaLBL.Size = New System.Drawing.Size(19, 13)
        Me.DiaLBL.TabIndex = 11
        Me.DiaLBL.Text = "01"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(523, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Lote:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "CERTIFICADO_CALIDAD", True))
        Me.Label5.Location = New System.Drawing.Point(557, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Certificado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Certificado:"
        '
        'FacturaLBL
        '
        Me.FacturaLBL.AutoSize = True
        Me.FacturaLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "FACTURA_REMISION", True))
        Me.FacturaLBL.Location = New System.Drawing.Point(388, 20)
        Me.FacturaLBL.Name = "FacturaLBL"
        Me.FacturaLBL.Size = New System.Drawing.Size(46, 13)
        Me.FacturaLBL.TabIndex = 7
        Me.FacturaLBL.Text = "Factura:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(333, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Factura:"
        '
        'OCLBL
        '
        Me.OCLBL.AutoSize = True
        Me.OCLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "OC", True))
        Me.OCLBL.Location = New System.Drawing.Point(270, 20)
        Me.OCLBL.Name = "OCLBL"
        Me.OCLBL.Size = New System.Drawing.Size(25, 13)
        Me.OCLBL.TabIndex = 5
        Me.OCLBL.Text = "OC:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "OC:"
        '
        'ClienteLBL
        '
        Me.ClienteLBL.AutoSize = True
        Me.ClienteLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "CLIENTE", True))
        Me.ClienteLBL.Location = New System.Drawing.Point(57, 49)
        Me.ClienteLBL.Name = "ClienteLBL"
        Me.ClienteLBL.Size = New System.Drawing.Size(42, 13)
        Me.ClienteLBL.TabIndex = 3
        Me.ClienteLBL.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PesoLBL)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.MaterialLBL)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.EspesorLBL)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.AnchoLBL)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LargoLBL)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 97)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descripción MP"
        '
        'PesoLBL
        '
        Me.PesoLBL.AutoSize = True
        Me.PesoLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "PESO_KG", True))
        Me.PesoLBL.Location = New System.Drawing.Point(75, 75)
        Me.PesoLBL.Name = "PesoLBL"
        Me.PesoLBL.Size = New System.Drawing.Size(34, 13)
        Me.PesoLBL.TabIndex = 19
        Me.PesoLBL.Text = "Peso:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Peso KG:"
        '
        'MaterialLBL
        '
        Me.MaterialLBL.AutoSize = True
        Me.MaterialLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "MATERIAL", True))
        Me.MaterialLBL.Location = New System.Drawing.Point(180, 49)
        Me.MaterialLBL.Name = "MaterialLBL"
        Me.MaterialLBL.Size = New System.Drawing.Size(44, 13)
        Me.MaterialLBL.TabIndex = 17
        Me.MaterialLBL.Text = "Material"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(124, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Material:"
        '
        'EspesorLBL
        '
        Me.EspesorLBL.AutoSize = True
        Me.EspesorLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "ESPESOR", True))
        Me.EspesorLBL.Location = New System.Drawing.Point(180, 23)
        Me.EspesorLBL.Name = "EspesorLBL"
        Me.EspesorLBL.Size = New System.Drawing.Size(45, 13)
        Me.EspesorLBL.TabIndex = 15
        Me.EspesorLBL.Text = "Espesor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(124, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Espesor:"
        '
        'AnchoLBL
        '
        Me.AnchoLBL.AutoSize = True
        Me.AnchoLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "ANCHO", True))
        Me.AnchoLBL.Location = New System.Drawing.Point(75, 49)
        Me.AnchoLBL.Name = "AnchoLBL"
        Me.AnchoLBL.Size = New System.Drawing.Size(38, 13)
        Me.AnchoLBL.TabIndex = 13
        Me.AnchoLBL.Text = "Ancho"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Ancho MM:"
        '
        'LargoLBL
        '
        Me.LargoLBL.AutoSize = True
        Me.LargoLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LARGO", True))
        Me.LargoLBL.Location = New System.Drawing.Point(75, 23)
        Me.LargoLBL.Name = "LargoLBL"
        Me.LargoLBL.Size = New System.Drawing.Size(34, 13)
        Me.LargoLBL.TabIndex = 11
        Me.LargoLBL.Text = "Largo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Largo MM:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NivelLBL)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.RackLBL)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 97)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ubicación"
        '
        'NivelLBL
        '
        Me.NivelLBL.AutoSize = True
        Me.NivelLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "NIVEL", True))
        Me.NivelLBL.Location = New System.Drawing.Point(47, 55)
        Me.NivelLBL.Name = "NivelLBL"
        Me.NivelLBL.Size = New System.Drawing.Size(31, 13)
        Me.NivelLBL.TabIndex = 23
        Me.NivelLBL.Text = "Nivel"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Rack:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Nivel:"
        '
        'RackLBL
        '
        Me.RackLBL.AutoSize = True
        Me.RackLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "RACK", True))
        Me.RackLBL.Location = New System.Drawing.Point(47, 29)
        Me.RackLBL.Name = "RackLBL"
        Me.RackLBL.Size = New System.Drawing.Size(36, 13)
        Me.RackLBL.TabIndex = 21
        Me.RackLBL.Text = "RACK"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(382, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 100)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Comentarios Entrada"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "OBSERVACIONES_ENTRADA", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 75)
        Me.TextBox1.TabIndex = 10
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AutorizaTXT)
        Me.GroupBox5.Controls.Add(Me.SolicitanteTXT)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.piTXT)
        Me.GroupBox5.Controls.Add(Me.ofTXT)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(295, 138)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Salida"
        '
        'AutorizaTXT
        '
        Me.AutorizaTXT.Location = New System.Drawing.Point(88, 96)
        Me.AutorizaTXT.Name = "AutorizaTXT"
        Me.AutorizaTXT.Size = New System.Drawing.Size(198, 20)
        Me.AutorizaTXT.TabIndex = 27
        '
        'SolicitanteTXT
        '
        Me.SolicitanteTXT.Location = New System.Drawing.Point(88, 70)
        Me.SolicitanteTXT.Name = "SolicitanteTXT"
        Me.SolicitanteTXT.Size = New System.Drawing.Size(198, 20)
        Me.SolicitanteTXT.TabIndex = 26
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Autoriza:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Solicitante:"
        '
        'piTXT
        '
        Me.piTXT.Location = New System.Drawing.Point(145, 44)
        Me.piTXT.Name = "piTXT"
        Me.piTXT.Size = New System.Drawing.Size(100, 20)
        Me.piTXT.TabIndex = 23
        '
        'ofTXT
        '
        Me.ofTXT.Location = New System.Drawing.Point(145, 18)
        Me.ofTXT.Name = "ofTXT"
        Me.ofTXT.Size = New System.Drawing.Size(100, 20)
        Me.ofTXT.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Pedido Interno:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Orden de Fabricación:"
        '
        'LimpiarBTN
        '
        Me.LimpiarBTN.Location = New System.Drawing.Point(649, 278)
        Me.LimpiarBTN.Name = "LimpiarBTN"
        Me.LimpiarBTN.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarBTN.TabIndex = 11
        Me.LimpiarBTN.Text = "Limpiar"
        Me.LimpiarBTN.UseVisualStyleBackColor = True
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(649, 307)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 39)
        Me.GuardarBTN.TabIndex = 12
        Me.GuardarBTN.Text = "Registrar Salida"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComenSalidasTXT)
        Me.GroupBox6.Location = New System.Drawing.Point(313, 218)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(322, 135)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Comentarios Salida"
        '
        'ComenSalidasTXT
        '
        Me.ComenSalidasTXT.Location = New System.Drawing.Point(6, 15)
        Me.ComenSalidasTXT.Multiline = True
        Me.ComenSalidasTXT.Name = "ComenSalidasTXT"
        Me.ComenSalidasTXT.Size = New System.Drawing.Size(310, 114)
        Me.ComenSalidasTXT.TabIndex = 0
        '
        'SalidaEntrada
        '
        Me.SalidaEntrada.AutoSize = True
        Me.SalidaEntrada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "FOLIO_SALIDA", True))
        Me.SalidaEntrada.Location = New System.Drawing.Point(660, 236)
        Me.SalidaEntrada.Name = "SalidaEntrada"
        Me.SalidaEntrada.Size = New System.Drawing.Size(45, 13)
        Me.SalidaEntrada.TabIndex = 14
        Me.SalidaEntrada.Text = "Label21"
        '
        'Registro_Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 365)
        Me.Controls.Add(Me.SalidaEntrada)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.LimpiarBTN)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SalidaLBL)
        Me.Controls.Add(Me.FechaLBL)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Salidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Salidas de MP"
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MPClienteDataSet As MPClienteDataSet
    Friend WithEvents SALIDASBindingSource As BindingSource
    Friend WithEvents SALIDASTableAdapter As MPClienteDataSetTableAdapters.SALIDASTableAdapter
    Friend WithEvents TableAdapterManager As MPClienteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ENTRADASTableAdapter As MPClienteDataSetTableAdapters.ENTRADASTableAdapter
    Friend WithEvents EntradaCBX As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ENTRADASBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents FechaLBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SalidaLBL As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FacturaLBL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OCLBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ClienteLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PesoLBL As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents MaterialLBL As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents EspesorLBL As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents AnchoLBL As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LargoLBL As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NivelLBL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RackLBL As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ConsecutivoLBL As Label
    Friend WithEvents MatLBL As Label
    Friend WithEvents ClienLBL As Label
    Friend WithEvents YearLBL As Label
    Friend WithEvents MesLBL As Label
    Friend WithEvents DiaLBL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AutorizaTXT As TextBox
    Friend WithEvents SolicitanteTXT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents piTXT As TextBox
    Friend WithEvents ofTXT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LimpiarBTN As Button
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComenSalidasTXT As TextBox
    Friend WithEvents SalidaEntrada As Label
End Class
