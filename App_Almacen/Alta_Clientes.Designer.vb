<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alta_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alta_Clientes))
        Me.CLIENTESDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Prueba = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.CorreoTXT = New System.Windows.Forms.TextBox()
        Me.CPTXT = New System.Windows.Forms.TextBox()
        Me.TelefonoTXT = New System.Windows.Forms.TextBox()
        Me.ContactoTXT = New System.Windows.Forms.TextBox()
        Me.DomicilioTXT = New System.Windows.Forms.TextBox()
        Me.NombreTXT = New System.Windows.Forms.TextBox()
        Me.NoClienteTXT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clientes = New App_Almacen.Clientes()
        Me.CLIENTESTableAdapter = New App_Almacen.ClientesTableAdapters.CLIENTESTableAdapter()
        Me.TableAdapterManager = New App_Almacen.ClientesTableAdapters.TableAdapterManager()
        Me.BuscarClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarClienteTableAdapter = New App_Almacen.ClientesTableAdapters.BuscarClienteTableAdapter()
        CType(Me.CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIENTESDataGridView
        '
        Me.CLIENTESDataGridView.AllowUserToAddRows = False
        Me.CLIENTESDataGridView.AllowUserToDeleteRows = False
        Me.CLIENTESDataGridView.AllowUserToOrderColumns = True
        Me.CLIENTESDataGridView.AutoGenerateColumns = False
        Me.CLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CLIENTESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CLIENTESDataGridView.DataSource = Me.CLIENTESBindingSource
        Me.CLIENTESDataGridView.Location = New System.Drawing.Point(12, 119)
        Me.CLIENTESDataGridView.Name = "CLIENTESDataGridView"
        Me.CLIENTESDataGridView.ReadOnly = True
        Me.CLIENTESDataGridView.Size = New System.Drawing.Size(936, 439)
        Me.CLIENTESDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Prueba)
        Me.GroupBox1.Controls.Add(Me.GuardarBTN)
        Me.GroupBox1.Controls.Add(Me.CorreoTXT)
        Me.GroupBox1.Controls.Add(Me.CPTXT)
        Me.GroupBox1.Controls.Add(Me.TelefonoTXT)
        Me.GroupBox1.Controls.Add(Me.ContactoTXT)
        Me.GroupBox1.Controls.Add(Me.DomicilioTXT)
        Me.GroupBox1.Controls.Add(Me.NombreTXT)
        Me.GroupBox1.Controls.Add(Me.NoClienteTXT)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(950, 101)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'Prueba
        '
        Me.Prueba.Location = New System.Drawing.Point(420, 74)
        Me.Prueba.Name = "Prueba"
        Me.Prueba.Size = New System.Drawing.Size(100, 20)
        Me.Prueba.TabIndex = 15
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(855, 72)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 14
        Me.GuardarBTN.Text = "Registrar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'CorreoTXT
        '
        Me.CorreoTXT.Location = New System.Drawing.Point(387, 45)
        Me.CorreoTXT.Name = "CorreoTXT"
        Me.CorreoTXT.Size = New System.Drawing.Size(165, 20)
        Me.CorreoTXT.TabIndex = 13
        '
        'CPTXT
        '
        Me.CPTXT.Location = New System.Drawing.Point(770, 45)
        Me.CPTXT.Name = "CPTXT"
        Me.CPTXT.Size = New System.Drawing.Size(100, 20)
        Me.CPTXT.TabIndex = 12
        '
        'TelefonoTXT
        '
        Me.TelefonoTXT.Location = New System.Drawing.Point(610, 45)
        Me.TelefonoTXT.Name = "TelefonoTXT"
        Me.TelefonoTXT.Size = New System.Drawing.Size(124, 20)
        Me.TelefonoTXT.TabIndex = 11
        '
        'ContactoTXT
        '
        Me.ContactoTXT.Location = New System.Drawing.Point(74, 45)
        Me.ContactoTXT.Name = "ContactoTXT"
        Me.ContactoTXT.Size = New System.Drawing.Size(233, 20)
        Me.ContactoTXT.TabIndex = 10
        '
        'DomicilioTXT
        '
        Me.DomicilioTXT.Location = New System.Drawing.Point(610, 19)
        Me.DomicilioTXT.Name = "DomicilioTXT"
        Me.DomicilioTXT.Size = New System.Drawing.Size(311, 20)
        Me.DomicilioTXT.TabIndex = 9
        '
        'NombreTXT
        '
        Me.NombreTXT.Location = New System.Drawing.Point(247, 19)
        Me.NombreTXT.Name = "NombreTXT"
        Me.NombreTXT.Size = New System.Drawing.Size(290, 20)
        Me.NombreTXT.TabIndex = 8
        '
        'NoClienteTXT
        '
        Me.NoClienteTXT.Location = New System.Drawing.Point(74, 19)
        Me.NoClienteTXT.Name = "NoClienteTXT"
        Me.NoClienteTXT.Size = New System.Drawing.Size(100, 20)
        Me.NoClienteTXT.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Correo Elect."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(740, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contacto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(558, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Domicilio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Cliente:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NO_CLIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No. Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 84
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DOMICILIO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TELEFONO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CONTACTO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CP"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 46
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CORREO_ELECTRONICO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Correo Electrónico"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 109
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
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuscarClienteTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.UpdateOrder = App_Almacen.ClientesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscarClienteBindingSource
        '
        Me.BuscarClienteBindingSource.DataMember = "BuscarCliente"
        Me.BuscarClienteBindingSource.DataSource = Me.Clientes
        '
        'BuscarClienteTableAdapter
        '
        Me.BuscarClienteTableAdapter.ClearBeforeFill = True
        '
        'Alta_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 570)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CLIENTESDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alta_Clientes"
        Me.Text = "Alta Clientes"
        CType(Me.CLIENTESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Clientes As Clientes
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As ClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents TableAdapterManager As ClientesTableAdapters.TableAdapterManager
    Friend WithEvents CLIENTESDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents CorreoTXT As TextBox
    Friend WithEvents CPTXT As TextBox
    Friend WithEvents TelefonoTXT As TextBox
    Friend WithEvents ContactoTXT As TextBox
    Friend WithEvents DomicilioTXT As TextBox
    Friend WithEvents NombreTXT As TextBox
    Friend WithEvents NoClienteTXT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Prueba As TextBox
    Friend WithEvents BuscarClienteBindingSource As BindingSource
    Friend WithEvents BuscarClienteTableAdapter As ClientesTableAdapters.BuscarClienteTableAdapter
End Class
