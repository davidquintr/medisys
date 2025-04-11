<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePatientConditions
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
        btnAccept = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnCancel = New Button()
        lblTitle = New Label()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        btnRemove = New Button()
        lboxPatientConditions = New ListBox()
        Panel5 = New Panel()
        cboxConditions = New ComboBox()
        Label5 = New Label()
        btnAdd = New Button()
        lblIDCard = New Label()
        lblNameLastName = New Label()
        picboxAvatar = New PictureBox()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(picboxAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = SystemColors.ButtonFace
        btnAccept.ForeColor = Color.Navy
        btnAccept.Image = My.Resources.Resources.tabler_icon_check
        btnAccept.ImageAlign = ContentAlignment.MiddleRight
        btnAccept.Location = New Point(351, 7)
        btnAccept.Name = "btnAccept"
        btnAccept.Padding = New Padding(4)
        btnAccept.Size = New Size(90, 36)
        btnAccept.TabIndex = 9
        btnAccept.Text = "Aceptar"
        btnAccept.TextAlign = ContentAlignment.MiddleLeft
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnCancel)
        FlowLayoutPanel1.Controls.Add(btnAccept)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 409)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(540, 44)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.ForeColor = Color.Navy
        btnCancel.Image = My.Resources.Resources.tabler_icon_x
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(447, 7)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(4)
        btnCancel.Size = New Size(90, 36)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancelar"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Roboto Slab", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(3, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(481, 28)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Administrar Condiciones Médicas del Paciente"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 49)
        Panel1.TabIndex = 2
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
        SplitContainer1.Panel2.Controls.Add(btnRemove)
        SplitContainer1.Panel2.Controls.Add(lboxPatientConditions)
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(btnAdd)
        SplitContainer1.Panel2.Controls.Add(lblIDCard)
        SplitContainer1.Panel2.Controls.Add(lblNameLastName)
        SplitContainer1.Panel2.Controls.Add(picboxAvatar)
        SplitContainer1.Size = New Size(540, 401)
        SplitContainer1.SplitterDistance = 52
        SplitContainer1.TabIndex = 9
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(386, 300)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(137, 31)
        btnRemove.TabIndex = 25
        btnRemove.Text = "Remover"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' lboxPatientConditions
        ' 
        lboxPatientConditions.FormattingEnabled = True
        lboxPatientConditions.ItemHeight = 15
        lboxPatientConditions.Location = New Point(16, 200)
        lboxPatientConditions.Name = "lboxPatientConditions"
        lboxPatientConditions.Size = New Size(507, 94)
        lboxPatientConditions.TabIndex = 24
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(cboxConditions)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(16, 114)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(8)
        Panel5.Size = New Size(364, 68)
        Panel5.TabIndex = 23
        ' 
        ' cboxConditions
        ' 
        cboxConditions.Dock = DockStyle.Bottom
        cboxConditions.FormattingEnabled = True
        cboxConditions.ImeMode = ImeMode.NoControl
        cboxConditions.Items.AddRange(New Object() {"male", "female"})
        cboxConditions.Location = New Point(8, 37)
        cboxConditions.Name = "cboxConditions"
        cboxConditions.Size = New Size(348, 23)
        cboxConditions.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label5.Location = New Point(8, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 22)
        Label5.TabIndex = 1
        Label5.Text = "Condiciones"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(386, 143)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(137, 31)
        btnAdd.TabIndex = 22
        btnAdd.Text = "Agregar"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lblIDCard
        ' 
        lblIDCard.AutoSize = True
        lblIDCard.Font = New Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIDCard.Location = New Point(86, 48)
        lblIDCard.Name = "lblIDCard"
        lblIDCard.Size = New Size(109, 22)
        lblIDCard.TabIndex = 19
        lblIDCard.Text = "Identity Card"
        ' 
        ' lblNameLastName
        ' 
        lblNameLastName.AutoSize = True
        lblNameLastName.Font = New Font("Roboto Slab", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNameLastName.Location = New Point(86, 22)
        lblNameLastName.Name = "lblNameLastName"
        lblNameLastName.Size = New Size(182, 26)
        lblNameLastName.TabIndex = 14
        lblNameLastName.Text = "Name - Last Name"
        ' 
        ' picboxAvatar
        ' 
        picboxAvatar.BackgroundImage = My.Resources.Resources.user_icon
        picboxAvatar.BackgroundImageLayout = ImageLayout.Stretch
        picboxAvatar.InitialImage = Nothing
        picboxAvatar.Location = New Point(16, 22)
        picboxAvatar.Name = "picboxAvatar"
        picboxAvatar.Size = New Size(64, 64)
        picboxAvatar.TabIndex = 18
        picboxAvatar.TabStop = False
        ' 
        ' frmManagePatientConditions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(556, 461)
        Controls.Add(SplitContainer1)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmManagePatientConditions"
        Padding = New Padding(8)
        Text = "frmManagePatientConditions"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(picboxAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lblIDCard As Label
    Friend WithEvents lblNameLastName As Label
    Friend WithEvents picboxAvatar As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cboxConditions As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents lboxPatientConditions As ListBox
End Class
