<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucConditions
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
        dgvConditions = New DataGridView()
        NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DescriptionDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ConditionBindingSource = New BindingSource(components)
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnNew = New Button()
        btnSearch = New Button()
        btnModify = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        Label3 = New Label()
        CType(dgvConditions, ComponentModel.ISupportInitialize).BeginInit()
        CType(ConditionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvConditions
        ' 
        dgvConditions.AllowUserToAddRows = False
        dgvConditions.AllowUserToDeleteRows = False
        dgvConditions.AutoGenerateColumns = False
        dgvConditions.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvConditions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvConditions.Columns.AddRange(New DataGridViewColumn() {NameDataGridViewTextBoxColumn, DescriptionDataGridViewTextBoxColumn})
        dgvConditions.DataSource = ConditionBindingSource
        dgvConditions.Dock = DockStyle.Fill
        dgvConditions.EditMode = DataGridViewEditMode.EditOnF2
        dgvConditions.Location = New Point(0, 0)
        dgvConditions.Name = "dgvConditions"
        dgvConditions.ReadOnly = True
        dgvConditions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvConditions.Size = New Size(875, 335)
        dgvConditions.TabIndex = 0
        ' 
        ' NameDataGridViewTextBoxColumn
        ' 
        NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        NameDataGridViewTextBoxColumn.HeaderText = "Nombre"
        NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        NameDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' DescriptionDataGridViewTextBoxColumn
        ' 
        DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        DescriptionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        DescriptionDataGridViewTextBoxColumn.Width = 250
        ' 
        ' ConditionBindingSource
        ' 
        ConditionBindingSource.DataSource = GetType(Condition)
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnNew)
        FlowLayoutPanel1.Controls.Add(btnSearch)
        FlowLayoutPanel1.Controls.Add(btnModify)
        FlowLayoutPanel1.Controls.Add(btnDelete)
        FlowLayoutPanel1.Controls.Add(btnRefresh)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 375)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(875, 44)
        FlowLayoutPanel1.TabIndex = 6
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.ButtonFace
        btnNew.ForeColor = Color.Navy
        btnNew.Image = My.Resources.Resources.tabler_icon_plus
        btnNew.ImageAlign = ContentAlignment.MiddleRight
        btnNew.Location = New Point(753, 7)
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
        btnSearch.Location = New Point(608, 7)
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
        btnModify.Location = New Point(462, 7)
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
        btnDelete.Location = New Point(327, 7)
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
        btnRefresh.Location = New Point(192, 7)
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
        SplitContainer1.Panel2.Controls.Add(dgvConditions)
        SplitContainer1.Size = New Size(875, 411)
        SplitContainer1.SplitterDistance = 72
        SplitContainer1.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(875, 74)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Slab", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(374, 48)
        Label3.TabIndex = 13
        Label3.Text = "Condiciones Médicas"
        ' 
        ' ucConditions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(SplitContainer1)
        Name = "ucConditions"
        Padding = New Padding(8)
        Size = New Size(891, 427)
        CType(dgvConditions, ComponentModel.ISupportInitialize).EndInit()
        CType(ConditionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvConditions As DataGridView
    Friend WithEvents ConditionBindingSource As BindingSource
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn

End Class
