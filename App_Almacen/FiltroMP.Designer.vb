<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltroMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiltroMP))
        Me.EntradaTXT = New System.Windows.Forms.TextBox()
        Me.ObservacionesCBX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FiltroBTN = New System.Windows.Forms.Button()
        Me.RestaurarBTN = New System.Windows.Forms.Button()
        Me.ClienteCBX = New System.Windows.Forms.ComboBox()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes = New App_Almacen.Clientes()
        Me.EspesorCBX = New System.Windows.Forms.ComboBox()
        Me.MaterialCBX = New System.Windows.Forms.ComboBox()
        Me.MATERIALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATERIALES = New App_Almacen.MATERIALES()
        Me.RachCBX = New System.Windows.Forms.ComboBox()
        Me.NivelCBX = New System.Windows.Forms.ComboBox()
        Me.CLIENTESTableAdapter = New App_Almacen.ClientesTableAdapters.CLIENTESTableAdapter()
        Me.MATERIALTableAdapter = New App_Almacen.MATERIALESTableAdapters.MATERIALTableAdapter()
        Me.NoClienteCBX = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntradaTXT
        '
        Me.EntradaTXT.Location = New System.Drawing.Point(96, 12)
        Me.EntradaTXT.Name = "EntradaTXT"
        Me.EntradaTXT.Size = New System.Drawing.Size(120, 20)
        Me.EntradaTXT.TabIndex = 0
        '
        'ObservacionesCBX
        '
        Me.ObservacionesCBX.Location = New System.Drawing.Point(96, 200)
        Me.ObservacionesCBX.Name = "ObservacionesCBX"
        Me.ObservacionesCBX.Size = New System.Drawing.Size(120, 20)
        Me.ObservacionesCBX.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Folio Entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Espesor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Material:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Rack:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nivel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Observaciones:"
        '
        'FiltroBTN
        '
        Me.FiltroBTN.Location = New System.Drawing.Point(141, 245)
        Me.FiltroBTN.Name = "FiltroBTN"
        Me.FiltroBTN.Size = New System.Drawing.Size(75, 23)
        Me.FiltroBTN.TabIndex = 14
        Me.FiltroBTN.Text = "Filtrar"
        Me.FiltroBTN.UseVisualStyleBackColor = True
        '
        'RestaurarBTN
        '
        Me.RestaurarBTN.Location = New System.Drawing.Point(15, 237)
        Me.RestaurarBTN.Name = "RestaurarBTN"
        Me.RestaurarBTN.Size = New System.Drawing.Size(75, 38)
        Me.RestaurarBTN.TabIndex = 15
        Me.RestaurarBTN.Text = "Restaurar filtro"
        Me.RestaurarBTN.UseVisualStyleBackColor = True
        '
        'ClienteCBX
        '
        Me.ClienteCBX.DataSource = Me.CLIENTESBindingSource
        Me.ClienteCBX.DisplayMember = "NOMBRE"
        Me.ClienteCBX.FormattingEnabled = True
        Me.ClienteCBX.Location = New System.Drawing.Point(96, 65)
        Me.ClienteCBX.Name = "ClienteCBX"
        Me.ClienteCBX.Size = New System.Drawing.Size(120, 21)
        Me.ClienteCBX.TabIndex = 16
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
        'EspesorCBX
        '
        Me.EspesorCBX.FormattingEnabled = True
        Me.EspesorCBX.Items.AddRange(New Object() {"C. 6", "C. 7", "C. 8", "C. 9", "C. 10", "C. 11", "C. 12", "C. 13", "C. 14", "C. 15", "C. 16", "C. 18", "C. 19", "C. 20", "C. 22", "C. 24", "C. 26", "C. 28", "C. 30", "1/8''", "3/16''", "1/4''", "5/16''", "3/8''", "7/16''", "1/2''", "5/8''", "3/4''", "7/8''", "1''", "1 1/8''", "1 1/4''", "1 3/8''", "1 1/2''", "1 5/8''", "1 3/4''", "2''", "2 1/4''", "2 1/2''", "2 3/4''", "3''", "3 1/2''", "4''", "4 1/2''", "5''"})
        Me.EspesorCBX.Location = New System.Drawing.Point(96, 92)
        Me.EspesorCBX.Name = "EspesorCBX"
        Me.EspesorCBX.Size = New System.Drawing.Size(120, 21)
        Me.EspesorCBX.TabIndex = 17
        '
        'MaterialCBX
        '
        Me.MaterialCBX.DataSource = Me.MATERIALBindingSource
        Me.MaterialCBX.DisplayMember = "MATERIAL"
        Me.MaterialCBX.FormattingEnabled = True
        Me.MaterialCBX.Location = New System.Drawing.Point(96, 119)
        Me.MaterialCBX.Name = "MaterialCBX"
        Me.MaterialCBX.Size = New System.Drawing.Size(120, 21)
        Me.MaterialCBX.TabIndex = 18
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
        'RachCBX
        '
        Me.RachCBX.FormattingEnabled = True
        Me.RachCBX.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "INT.", "EXT."})
        Me.RachCBX.Location = New System.Drawing.Point(96, 146)
        Me.RachCBX.Name = "RachCBX"
        Me.RachCBX.Size = New System.Drawing.Size(120, 21)
        Me.RachCBX.TabIndex = 19
        '
        'NivelCBX
        '
        Me.NivelCBX.FormattingEnabled = True
        Me.NivelCBX.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.NivelCBX.Location = New System.Drawing.Point(96, 173)
        Me.NivelCBX.Name = "NivelCBX"
        Me.NivelCBX.Size = New System.Drawing.Size(120, 21)
        Me.NivelCBX.TabIndex = 20
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'MATERIALTableAdapter
        '
        Me.MATERIALTableAdapter.ClearBeforeFill = True
        '
        'NoClienteCBX
        '
        Me.NoClienteCBX.DataSource = Me.CLIENTESBindingSource
        Me.NoClienteCBX.DisplayMember = "NOMBRE"
        Me.NoClienteCBX.FormattingEnabled = True
        Me.NoClienteCBX.Location = New System.Drawing.Point(96, 38)
        Me.NoClienteCBX.Name = "NoClienteCBX"
        Me.NoClienteCBX.Size = New System.Drawing.Size(120, 21)
        Me.NoClienteCBX.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "No. Cliente:"
        '
        'FiltroMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 285)
        Me.Controls.Add(Me.NoClienteCBX)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NivelCBX)
        Me.Controls.Add(Me.RachCBX)
        Me.Controls.Add(Me.MaterialCBX)
        Me.Controls.Add(Me.EspesorCBX)
        Me.Controls.Add(Me.ClienteCBX)
        Me.Controls.Add(Me.RestaurarBTN)
        Me.Controls.Add(Me.FiltroBTN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ObservacionesCBX)
        Me.Controls.Add(Me.EntradaTXT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FiltroMP"
        Me.Text = "Filtro"
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EntradaTXT As TextBox
    Friend WithEvents ObservacionesCBX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FiltroBTN As Button
    Friend WithEvents RestaurarBTN As Button
    Friend WithEvents ClienteCBX As ComboBox
    Friend WithEvents EspesorCBX As ComboBox
    Friend WithEvents MaterialCBX As ComboBox
    Friend WithEvents RachCBX As ComboBox
    Friend WithEvents NivelCBX As ComboBox
    Friend WithEvents Clientes As Clientes
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As ClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents MATERIALES As MATERIALES
    Friend WithEvents MATERIALBindingSource As BindingSource
    Friend WithEvents MATERIALTableAdapter As MATERIALESTableAdapters.MATERIALTableAdapter
    Friend WithEvents NoClienteCBX As ComboBox
    Friend WithEvents Label8 As Label
End Class
