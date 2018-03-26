<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Salida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Salida))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalidaTXT = New System.Windows.Forms.ComboBox()
        Me.SALIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MPClienteDataSet = New App_Almacen.MPClienteDataSet()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ComenSalidasTXT = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AutorizaTXT = New System.Windows.Forms.TextBox()
        Me.SolicitanteTXT = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.piTXT = New System.Windows.Forms.TextBox()
        Me.ofTXT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NivelLBL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RackLBL = New System.Windows.Forms.Label()
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LoteLBL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FacturaLBL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OCLBL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClienteLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EntradaCBX = New System.Windows.Forms.ComboBox()
        Me.SALIDASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.SALIDASTableAdapter()
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.EstatusLBL = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager()
        Me.EntradaLBL = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SalidaTXT)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Folio"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancelar Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio:"
        '
        'SalidaTXT
        '
        Me.SalidaTXT.DataSource = Me.SALIDASBindingSource
        Me.SalidaTXT.DisplayMember = "FOLIO_SALIDA"
        Me.SalidaTXT.FormattingEnabled = True
        Me.SalidaTXT.Location = New System.Drawing.Point(50, 25)
        Me.SalidaTXT.Name = "SalidaTXT"
        Me.SalidaTXT.Size = New System.Drawing.Size(121, 21)
        Me.SalidaTXT.TabIndex = 1
        '
        'SALIDASBindingSource
        '
        Me.SALIDASBindingSource.DataMember = "SALIDAS"
        Me.SALIDASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'MPClienteDataSet
        '
        Me.MPClienteDataSet.DataSetName = "MPClienteDataSet"
        Me.MPClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ComenSalidasTXT)
        Me.GroupBox6.Location = New System.Drawing.Point(313, 264)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(322, 135)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Comentarios Salida"
        '
        'ComenSalidasTXT
        '
        Me.ComenSalidasTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "OBSERVACIONES_SALIDA", True))
        Me.ComenSalidasTXT.Location = New System.Drawing.Point(6, 15)
        Me.ComenSalidasTXT.Multiline = True
        Me.ComenSalidasTXT.Name = "ComenSalidasTXT"
        Me.ComenSalidasTXT.Size = New System.Drawing.Size(310, 114)
        Me.ComenSalidasTXT.TabIndex = 0
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(649, 353)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 39)
        Me.GuardarBTN.TabIndex = 21
        Me.GuardarBTN.Text = "Guardar Cambios"
        Me.GuardarBTN.UseVisualStyleBackColor = True
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
        Me.GroupBox5.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(295, 138)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Salida"
        '
        'AutorizaTXT
        '
        Me.AutorizaTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "AUTORIZACION", True))
        Me.AutorizaTXT.Location = New System.Drawing.Point(88, 96)
        Me.AutorizaTXT.Name = "AutorizaTXT"
        Me.AutorizaTXT.Size = New System.Drawing.Size(198, 20)
        Me.AutorizaTXT.TabIndex = 27
        '
        'SolicitanteTXT
        '
        Me.SolicitanteTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "SOLICITANTE", True))
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
        Me.piTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "PI", True))
        Me.piTXT.Location = New System.Drawing.Point(145, 44)
        Me.piTXT.Name = "piTXT"
        Me.piTXT.Size = New System.Drawing.Size(100, 20)
        Me.piTXT.TabIndex = 23
        '
        'ofTXT
        '
        Me.ofTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "OF", True))
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(382, 158)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 100)
        Me.GroupBox4.TabIndex = 18
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
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NivelLBL)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.RackLBL)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 97)
        Me.GroupBox3.TabIndex = 17
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 97)
        Me.GroupBox2.TabIndex = 16
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
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LoteLBL)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.FacturaLBL)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.OCLBL)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.ClienteLBL)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.EntradaCBX)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(712, 72)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Información General"
        '
        'LoteLBL
        '
        Me.LoteLBL.AutoSize = True
        Me.LoteLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "LOTE", True))
        Me.LoteLBL.Location = New System.Drawing.Point(559, 49)
        Me.LoteLBL.Name = "LoteLBL"
        Me.LoteLBL.Size = New System.Drawing.Size(19, 13)
        Me.LoteLBL.TabIndex = 17
        Me.LoteLBL.Text = "00"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Folio de Entrada:"
        '
        'EntradaCBX
        '
        Me.EntradaCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EntradaCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EntradaCBX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "FOLIO_ENTRADA", True))
        Me.EntradaCBX.DataSource = Me.ENTRADASBindingSource
        Me.EntradaCBX.DisplayMember = "FOLIO_ENTRADA"
        Me.EntradaCBX.FormattingEnabled = True
        Me.EntradaCBX.Location = New System.Drawing.Point(113, 17)
        Me.EntradaCBX.Name = "EntradaCBX"
        Me.EntradaCBX.Size = New System.Drawing.Size(121, 21)
        Me.EntradaCBX.TabIndex = 0
        '
        'SALIDASTableAdapter
        '
        Me.SALIDASTableAdapter.ClearBeforeFill = True
        '
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'EstatusLBL
        '
        Me.EstatusLBL.AutoSize = True
        Me.EstatusLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALIDASBindingSource, "ESTATUS", True))
        Me.EstatusLBL.Location = New System.Drawing.Point(483, 32)
        Me.EstatusLBL.Name = "EstatusLBL"
        Me.EstatusLBL.Size = New System.Drawing.Size(42, 13)
        Me.EstatusLBL.TabIndex = 23
        Me.EstatusLBL.Text = "Estatus"
        Me.EstatusLBL.Visible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENTRADASTableAdapter = Me.ENTRADASTableAdapter
        Me.TableAdapterManager.InventarioMPTableAdapter = Nothing
        Me.TableAdapterManager.SALIDASTableAdapter = Me.SALIDASTableAdapter
        Me.TableAdapterManager.UpdateOrder = App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EntradaLBL
        '
        Me.EntradaLBL.AutoSize = True
        Me.EntradaLBL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "FOLIO_SALIDA", True))
        Me.EntradaLBL.Location = New System.Drawing.Point(483, 61)
        Me.EntradaLBL.Name = "EntradaLBL"
        Me.EntradaLBL.Size = New System.Drawing.Size(39, 13)
        Me.EntradaLBL.TabIndex = 24
        Me.EntradaLBL.Text = "Label3"
        Me.EntradaLBL.Visible = False
        '
        'Modificar_Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 409)
        Me.Controls.Add(Me.EntradaLBL)
        Me.Controls.Add(Me.EstatusLBL)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_Salida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Salida"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SalidaTXT As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ComenSalidasTXT As TextBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AutorizaTXT As TextBox
    Friend WithEvents SolicitanteTXT As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents piTXT As TextBox
    Friend WithEvents ofTXT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NivelLBL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RackLBL As Label
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
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LoteLBL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FacturaLBL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents OCLBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ClienteLBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EntradaCBX As ComboBox
    Friend WithEvents MPClienteDataSet As MPClienteDataSet
    Friend WithEvents SALIDASBindingSource As BindingSource
    Friend WithEvents SALIDASTableAdapter As MPClienteDataSetTableAdapters.SALIDASTableAdapter
    Friend WithEvents ENTRADASBindingSource As BindingSource
    Friend WithEvents ENTRADASTableAdapter As MPClienteDataSetTableAdapters.ENTRADASTableAdapter
    Friend WithEvents EstatusLBL As Label
    Friend WithEvents TableAdapterManager As MPClienteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EntradaLBL As Label
End Class
