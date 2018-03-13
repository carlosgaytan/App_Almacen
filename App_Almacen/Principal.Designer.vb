<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Reg_entradas = New System.Windows.Forms.Button()
        Me.Reg_Salidas = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ENTRADASBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SALIDASDataGridView = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EntradasFSW = New System.IO.FileSystemWatcher()
        Me.ENTRADASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MPClienteDataSet = New App_Almacen.MPClienteDataSet()
        Me.SALIDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENTRADASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.ENTRADASTableAdapter()
        Me.TableAdapterManager = New App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager()
        Me.SALIDASTableAdapter = New App_Almacen.MPClienteDataSetTableAdapters.SALIDASTableAdapter()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOLICITANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ENTRADASBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ENTRADASBindingNavigator.SuspendLayout()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SALIDASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(121, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1018, 533)
        Me.TabControl1.TabIndex = 5
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
        Me.ENTRADASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.ENTRADASDataGridView.DataSource = Me.ENTRADASBindingSource
        Me.ENTRADASDataGridView.Location = New System.Drawing.Point(3, 31)
        Me.ENTRADASDataGridView.Name = "ENTRADASDataGridView"
        Me.ENTRADASDataGridView.ReadOnly = True
        Me.ENTRADASDataGridView.Size = New System.Drawing.Size(1001, 470)
        Me.ENTRADASDataGridView.TabIndex = 0
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
        'ENTRADASBindingSource
        '
        Me.ENTRADASBindingSource.DataMember = "ENTRADAS"
        Me.ENTRADASBindingSource.DataSource = Me.MPClienteDataSet
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
        'ENTRADASTableAdapter
        '
        Me.ENTRADASTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ENTRADASTableAdapter = Me.ENTRADASTableAdapter
        Me.TableAdapterManager.SALIDASTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = App_Almacen.MPClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SALIDASTableAdapter
        '
        Me.SALIDASTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "FOLIO_SALIDA"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Folio Salida"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Folio Entrada"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FECHA_SALIDA"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fecha Salida"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "OF"
        Me.DataGridViewTextBoxColumn27.HeaderText = "OF"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'PI
        '
        Me.PI.DataPropertyName = "PI"
        Me.PI.HeaderText = "PI"
        Me.PI.Name = "PI"
        Me.PI.ReadOnly = True
        '
        'SOLICITANTE
        '
        Me.SOLICITANTE.DataPropertyName = "SOLICITANTE"
        Me.SOLICITANTE.HeaderText = "Solicitante"
        Me.SOLICITANTE.Name = "SOLICITANTE"
        Me.SOLICITANTE.ReadOnly = True
        '
        'LOTE
        '
        Me.LOTE.DataPropertyName = "LOTE"
        Me.LOTE.HeaderText = "Lote"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "AUTORIZACION"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Autorización"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "OBSERVACIONES_SALIDA"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FOLIO_ENTRADA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECHA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FACTURA_REMISION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Factura/Remisión"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "OC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "OC"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CERTIFICADO_CALIDAD"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Certificado Calidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LARGO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ANCHO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ESPESOR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Espesor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MATERIAL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Material"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "RACK"
        Me.DataGridViewTextBoxColumn14.HeaderText = "RACK"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NIVEL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nivel"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "OBSERVACIONES_ENTRADA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "LOTE_DIA"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Lote Día"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LOTE_MES"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Lote Mes"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "LOTE_AÑO"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Lote Año"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "LOTE_CLIENTE"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Lote Cliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "LOTE_MATERIAL"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Lote Material"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "LOTE_FOLIO"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Consecutivo"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
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
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ENTRADASBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ENTRADASBindingNavigator.ResumeLayout(False)
        Me.ENTRADASBindingNavigator.PerformLayout()
        CType(Me.ENTRADASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SALIDASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasFSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENTRADASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPClienteDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALIDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
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
End Class
