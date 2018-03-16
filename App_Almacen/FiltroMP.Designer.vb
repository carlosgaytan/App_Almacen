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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FiltroBTN = New System.Windows.Forms.Button()
        Me.RestaurarBTN = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Clientes = New App_Almacen.Clientes()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTESTableAdapter = New App_Almacen.ClientesTableAdapters.CLIENTESTableAdapter()
        Me.MATERIALES = New App_Almacen.MATERIALES()
        Me.MATERIALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MATERIALTableAdapter = New App_Almacen.MATERIALESTableAdapters.MATERIALTableAdapter()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(96, 200)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(120, 20)
        Me.TextBox7.TabIndex = 6
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
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CLIENTESBindingSource
        Me.ComboBox1.DisplayMember = "NOMBRE"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"C. 6", "C. 7", "C. 8", "C. 9", "C. 10", "C. 11", "C. 12", "C. 13", "C. 14", "C. 15", "C. 16", "C. 18", "C. 19", "C. 20", "C. 22", "C. 24", "C. 26", "C. 28", "C. 30", "1/8''", "3/16''", "1/4''", "5/16''", "3/8''", "7/16''", "1/2''", "5/8''", "3/4''", "7/8''", "1''", "1 1/8''", "1 1/4''", "1 3/8''", "1 1/2''", "1 5/8''", "1 3/4''", "2''", "2 1/4''", "2 1/2''", "2 3/4''", "3''", "3 1/2''", "4''", "4 1/2''", "5''"})
        Me.ComboBox2.Location = New System.Drawing.Point(96, 92)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox2.TabIndex = 17
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.MATERIALBindingSource
        Me.ComboBox3.DisplayMember = "MATERIAL"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(96, 119)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox3.TabIndex = 18
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "INT.", "EXT."})
        Me.ComboBox4.Location = New System.Drawing.Point(96, 146)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox4.TabIndex = 19
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.ComboBox5.Location = New System.Drawing.Point(96, 173)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox5.TabIndex = 20
        '
        'Clientes
        '
        Me.Clientes.DataSetName = "Clientes"
        Me.Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.Clientes
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'MATERIALES
        '
        Me.MATERIALES.DataSetName = "MATERIALES"
        Me.MATERIALES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MATERIALBindingSource
        '
        Me.MATERIALBindingSource.DataMember = "MATERIAL"
        Me.MATERIALBindingSource.DataSource = Me.MATERIALES
        '
        'MATERIALTableAdapter
        '
        Me.MATERIALTableAdapter.ClearBeforeFill = True
        '
        'ComboBox6
        '
        Me.ComboBox6.DataSource = Me.CLIENTESBindingSource
        Me.ComboBox6.DisplayMember = "NOMBRE"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(96, 38)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox6.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Cliente:"
        '
        'FiltroMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 285)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RestaurarBTN)
        Me.Controls.Add(Me.FiltroBTN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FiltroMP"
        Me.Text = "Filtro"
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MATERIALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FiltroBTN As Button
    Friend WithEvents RestaurarBTN As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Clientes As Clientes
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As ClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents MATERIALES As MATERIALES
    Friend WithEvents MATERIALBindingSource As BindingSource
    Friend WithEvents MATERIALTableAdapter As MATERIALESTableAdapters.MATERIALTableAdapter
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Label8 As Label
End Class
