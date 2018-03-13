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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.ENTRADASBindingSource
        Me.ComboBox1.DisplayMember = "FOLIO_ENTRADA"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(105, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio de Entrada:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ENTRADASBindingSource, "CLIENTE", True))
        Me.TextBox1.Location = New System.Drawing.Point(70, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(341, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Registro_Salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 526)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Salidas"
        Me.Text = "Registro Salidas de MP"
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MPClienteDataSet As MPClienteDataSet
    Friend WithEvents SALIDASBindingSource As BindingSource
    Friend WithEvents SALIDASTableAdapter As MPClienteDataSetTableAdapters.SALIDASTableAdapter
    Friend WithEvents TableAdapterManager As MPClienteDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ENTRADASTableAdapter As MPClienteDataSetTableAdapters.ENTRADASTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ENTRADASBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
