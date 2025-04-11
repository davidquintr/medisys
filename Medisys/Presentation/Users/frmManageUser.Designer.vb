<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUser
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
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        lblTitle = New Label()
        Panel5 = New Panel()
        cboxRole = New ComboBox()
        Label5 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        tboxEmail = New TextBox()
        Panel3 = New Panel()
        Label2 = New Label()
        tboxPassword = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        tboxUsername = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnCancel = New Button()
        btnAccept = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
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
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(578, 320)
        SplitContainer1.SplitterDistance = 52
        SplitContainer1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(578, 49)
        Panel1.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Roboto Slab", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(3, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(221, 28)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Administrar Usuario"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(cboxRole)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(296, 108)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(8)
        Panel5.Size = New Size(263, 68)
        Panel5.TabIndex = 10
        ' 
        ' cboxRole
        ' 
        cboxRole.Dock = DockStyle.Bottom
        cboxRole.FormattingEnabled = True
        cboxRole.Items.AddRange(New Object() {"admin", "doctor"})
        cboxRole.Location = New Point(8, 37)
        cboxRole.Name = "cboxRole"
        cboxRole.Size = New Size(247, 23)
        cboxRole.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label5.Location = New Point(8, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 22)
        Label5.TabIndex = 1
        Label5.Text = "Rol"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(tboxEmail)
        Panel4.Location = New Point(16, 108)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(8)
        Panel4.Size = New Size(263, 68)
        Panel4.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label4.Location = New Point(8, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 22)
        Label4.TabIndex = 1
        Label4.Text = "Correo Electrónico"
        ' 
        ' tboxEmail
        ' 
        tboxEmail.Dock = DockStyle.Bottom
        tboxEmail.Location = New Point(8, 37)
        tboxEmail.Name = "tboxEmail"
        tboxEmail.Size = New Size(247, 23)
        tboxEmail.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(tboxPassword)
        Panel3.Location = New Point(296, 24)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(8)
        Panel3.Size = New Size(263, 68)
        Panel3.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label2.Location = New Point(8, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 22)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' tboxPassword
        ' 
        tboxPassword.Dock = DockStyle.Bottom
        tboxPassword.Location = New Point(8, 37)
        tboxPassword.Name = "tboxPassword"
        tboxPassword.Size = New Size(247, 23)
        tboxPassword.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(tboxUsername)
        Panel2.Location = New Point(16, 24)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8)
        Panel2.Size = New Size(263, 68)
        Panel2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 22)
        Label1.TabIndex = 1
        Label1.Text = "Nombre de Usuario"
        ' 
        ' tboxUsername
        ' 
        tboxUsername.Dock = DockStyle.Bottom
        tboxUsername.Location = New Point(8, 37)
        tboxUsername.Name = "tboxUsername"
        tboxUsername.Size = New Size(247, 23)
        tboxUsername.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnCancel)
        FlowLayoutPanel1.Controls.Add(btnAccept)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 284)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(578, 44)
        FlowLayoutPanel1.TabIndex = 6
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.ForeColor = Color.Navy
        btnCancel.Image = My.Resources.Resources.tabler_icon_x
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(485, 7)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(4)
        btnCancel.Size = New Size(90, 36)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancelar"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = SystemColors.ButtonFace
        btnAccept.ForeColor = Color.Navy
        btnAccept.Image = My.Resources.Resources.tabler_icon_check
        btnAccept.ImageAlign = ContentAlignment.MiddleRight
        btnAccept.Location = New Point(389, 7)
        btnAccept.Name = "btnAccept"
        btnAccept.Padding = New Padding(4)
        btnAccept.Size = New Size(90, 36)
        btnAccept.TabIndex = 9
        btnAccept.Text = "Aceptar"
        btnAccept.TextAlign = ContentAlignment.MiddleLeft
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' frmManageUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 336)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmManageUser"
        Padding = New Padding(8)
        Text = "frmManageUser"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tboxPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxUsername As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cboxRole As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tboxEmail As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAccept As Button
End Class
