<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEmployee
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        components = New ComponentModel.Container()
        dgvEmployees = New DataGridView()
        NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        LastNameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        AddressDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SexDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        StateDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        UsernameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SpecialtyDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ViewEmployeeUserBindingSource = New BindingSource(components)
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnNew = New Button()
        btnSearch = New Button()
        btnModify = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        Label3 = New Label()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        CType(ViewEmployeeUserBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.AutoGenerateColumns = False
        dgvEmployees.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Columns.AddRange(New DataGridViewColumn() {NameDataGridViewTextBoxColumn, LastNameDataGridViewTextBoxColumn, AddressDataGridViewTextBoxColumn, SexDataGridViewTextBoxColumn, StateDataGridViewTextBoxColumn, UsernameDataGridViewTextBoxColumn, SpecialtyDataGridViewTextBoxColumn})
        dgvEmployees.DataSource = ViewEmployeeUserBindingSource
        dgvEmployees.Dock = DockStyle.Fill
        dgvEmployees.EditMode = DataGridViewEditMode.EditOnF2
        dgvEmployees.Location = New Point(0, 0)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.ReadOnly = True
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.Size = New Size(813, 412)
        dgvEmployees.TabIndex = 0
        ' 
        ' NameDataGridViewTextBoxColumn
        ' 
        NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        NameDataGridViewTextBoxColumn.HeaderText = "Nombres"
        NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        NameDataGridViewTextBoxColumn.ReadOnly = True
        NameDataGridViewTextBoxColumn.Width = 125
        ' 
        ' LastNameDataGridViewTextBoxColumn
        ' 
        LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        LastNameDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        LastNameDataGridViewTextBoxColumn.ReadOnly = True
        LastNameDataGridViewTextBoxColumn.Width = 125
        ' 
        ' AddressDataGridViewTextBoxColumn
        ' 
        AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        AddressDataGridViewTextBoxColumn.HeaderText = "Dirección"
        AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        AddressDataGridViewTextBoxColumn.ReadOnly = True
        AddressDataGridViewTextBoxColumn.Width = 150
        ' 
        ' SexDataGridViewTextBoxColumn
        ' 
        SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        SexDataGridViewTextBoxColumn.HeaderText = "Sexo"
        SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        SexDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' StateDataGridViewTextBoxColumn
        ' 
        StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        StateDataGridViewTextBoxColumn.HeaderText = "Estado"
        StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        StateDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' UsernameDataGridViewTextBoxColumn
        ' 
        UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        UsernameDataGridViewTextBoxColumn.HeaderText = "Usuario Asociado"
        UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        UsernameDataGridViewTextBoxColumn.ReadOnly = True
        UsernameDataGridViewTextBoxColumn.Width = 150
        ' 
        ' SpecialtyDataGridViewTextBoxColumn
        ' 
        SpecialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty"
        SpecialtyDataGridViewTextBoxColumn.HeaderText = "Especialidad"
        SpecialtyDataGridViewTextBoxColumn.Name = "SpecialtyDataGridViewTextBoxColumn"
        SpecialtyDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' ViewEmployeeUserBindingSource
        ' 
        ViewEmployeeUserBindingSource.DataSource = GetType(ViewEmployeeUser)
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnNew)
        FlowLayoutPanel1.Controls.Add(btnSearch)
        FlowLayoutPanel1.Controls.Add(btnModify)
        FlowLayoutPanel1.Controls.Add(btnDelete)
        FlowLayoutPanel1.Controls.Add(btnRefresh)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 452)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(813, 44)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.ButtonFace
        btnNew.ForeColor = Color.Navy
        btnNew.Image = My.Resources.Resources.tabler_icon_plus
        btnNew.ImageAlign = ContentAlignment.MiddleRight
        btnNew.Location = New Point(691, 7)
        btnNew.Name = "btnNew"
        btnNew.Padding = New Padding(4)
        btnNew.Size = New Size(119, 36)
        btnNew.TabIndex = 0
        btnNew.Text = "Nuevo Registro"
        btnNew.TextAlign = ContentAlignment.MiddleLeft
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.ButtonFace
        btnSearch.ForeColor = Color.Navy
        btnSearch.Image = My.Resources.Resources.tabler_icon_search
        btnSearch.ImageAlign = ContentAlignment.MiddleRight
        btnSearch.Location = New Point(546, 7)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(4)
        btnSearch.Size = New Size(139, 36)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Buscar un Registro"
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        btnSearch.Visible = False
        ' 
        ' btnModify
        ' 
        btnModify.BackColor = SystemColors.ButtonFace
        btnModify.ForeColor = Color.Navy
        btnModify.Image = My.Resources.Resources.tabler_icon_edit
        btnModify.ImageAlign = ContentAlignment.MiddleRight
        btnModify.Location = New Point(400, 7)
        btnModify.Name = "btnModify"
        btnModify.Padding = New Padding(4)
        btnModify.Size = New Size(140, 36)
        btnModify.TabIndex = 1
        btnModify.Text = "Modificar Registro"
        btnModify.TextAlign = ContentAlignment.MiddleLeft
        btnModify.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ButtonFace
        btnDelete.ForeColor = Color.Navy
        btnDelete.Image = My.Resources.Resources.tabler_icon_trash
        btnDelete.ImageAlign = ContentAlignment.MiddleRight
        btnDelete.Location = New Point(265, 7)
        btnDelete.Name = "btnDelete"
        btnDelete.Padding = New Padding(4)
        btnDelete.Size = New Size(129, 36)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Eliminar Registro"
        btnDelete.TextAlign = ContentAlignment.MiddleLeft
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonFace
        btnRefresh.ForeColor = Color.Navy
        btnRefresh.Image = My.Resources.Resources.tabler_icon_refresh
        btnRefresh.ImageAlign = ContentAlignment.MiddleRight
        btnRefresh.Location = New Point(130, 7)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Padding = New Padding(4)
        btnRefresh.Size = New Size(129, 36)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refrescar Datos"
        btnRefresh.TextAlign = ContentAlignment.MiddleLeft
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(8, 8)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(dgvEmployees)
        SplitContainer1.Size = New Size(813, 488)
        SplitContainer1.SplitterDistance = 72
        SplitContainer1.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(813, 74)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Slab", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 48)
        Label3.TabIndex = 13
        Label3.Text = "Empleados"
        ' 
        ' ucEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(SplitContainer1)
        Name = "ucEmployee"
        Padding = New Padding(8)
        Size = New Size(829, 504)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        CType(ViewEmployeeUserBindingSource, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ViewEmployeeUserBindingSource As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

End Class
