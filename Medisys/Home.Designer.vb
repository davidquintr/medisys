<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        mainPanel = New Panel()
        Panel2 = New Panel()
        SplitContainer1 = New SplitContainer()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnDashboard = New Button()
        btnConditions = New Button()
        btnCheckup = New Button()
        btnPrescriptions = New Button()
        btnUsers = New Button()
        btnEmployees = New Button()
        btnSpecialties = New Button()
        btnPatients = New Button()
        txtUsername = New Label()
        txtRole = New Label()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        mainPanel.BackColor = Color.White
        mainPanel.Location = New Point(344, 12)
        mainPanel.Margin = New Padding(0)
        mainPanel.Name = "mainPanel"
        mainPanel.Padding = New Padding(8, 0, 8, 0)
        mainPanel.Size = New Size(747, 686)
        mainPanel.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(SplitContainer1)
        Panel2.Location = New Point(12, 12)
        Panel2.MinimumSize = New Size(280, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(326, 686)
        Panel2.TabIndex = 2
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SplitContainer1.FixedPanel = FixedPanel.Panel2
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(FlowLayoutPanel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(txtUsername)
        SplitContainer1.Panel2.Controls.Add(txtRole)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Padding = New Padding(8)
        SplitContainer1.Size = New Size(326, 686)
        SplitContainer1.SplitterDistance = 603
        SplitContainer1.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnDashboard)
        FlowLayoutPanel1.Controls.Add(btnConditions)
        FlowLayoutPanel1.Controls.Add(btnCheckup)
        FlowLayoutPanel1.Controls.Add(btnPrescriptions)
        FlowLayoutPanel1.Controls.Add(btnUsers)
        FlowLayoutPanel1.Controls.Add(btnEmployees)
        FlowLayoutPanel1.Controls.Add(btnSpecialties)
        FlowLayoutPanel1.Controls.Add(btnPatients)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(8)
        FlowLayoutPanel1.Size = New Size(326, 603)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.WhiteSmoke
        btnDashboard.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Roboto Slab", 12F)
        btnDashboard.ForeColor = Color.Navy
        btnDashboard.Image = My.Resources.Resources.tabler_icon_home
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(11, 11)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(4)
        btnDashboard.Size = New Size(305, 61)
        btnDashboard.TabIndex = 3
        btnDashboard.Text = "Inicio"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnConditions
        ' 
        btnConditions.BackColor = Color.WhiteSmoke
        btnConditions.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnConditions.FlatAppearance.BorderSize = 0
        btnConditions.FlatStyle = FlatStyle.Flat
        btnConditions.Font = New Font("Roboto Slab", 12F)
        btnConditions.ForeColor = Color.Navy
        btnConditions.Image = My.Resources.Resources.tabler_icon_heart_rate_monitor
        btnConditions.ImageAlign = ContentAlignment.MiddleLeft
        btnConditions.Location = New Point(11, 78)
        btnConditions.Name = "btnConditions"
        btnConditions.Padding = New Padding(4)
        btnConditions.Size = New Size(305, 61)
        btnConditions.TabIndex = 4
        btnConditions.Text = "Condiciones Médicas"
        btnConditions.UseVisualStyleBackColor = False
        ' 
        ' btnCheckup
        ' 
        btnCheckup.BackColor = Color.WhiteSmoke
        btnCheckup.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnCheckup.FlatAppearance.BorderSize = 0
        btnCheckup.FlatStyle = FlatStyle.Flat
        btnCheckup.Font = New Font("Roboto Slab", 12F)
        btnCheckup.ForeColor = Color.Navy
        btnCheckup.Image = My.Resources.Resources.tabler_icon_calendar_month
        btnCheckup.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckup.Location = New Point(11, 145)
        btnCheckup.Name = "btnCheckup"
        btnCheckup.Padding = New Padding(4)
        btnCheckup.Size = New Size(305, 61)
        btnCheckup.TabIndex = 5
        btnCheckup.Text = "Citas Médicas"
        btnCheckup.UseVisualStyleBackColor = False
        ' 
        ' btnPrescriptions
        ' 
        btnPrescriptions.BackColor = Color.WhiteSmoke
        btnPrescriptions.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnPrescriptions.FlatAppearance.BorderSize = 0
        btnPrescriptions.FlatStyle = FlatStyle.Flat
        btnPrescriptions.Font = New Font("Roboto Slab", 12F)
        btnPrescriptions.ForeColor = Color.Navy
        btnPrescriptions.Image = My.Resources.Resources.tabler_icon_pill
        btnPrescriptions.ImageAlign = ContentAlignment.MiddleLeft
        btnPrescriptions.Location = New Point(11, 212)
        btnPrescriptions.Name = "btnPrescriptions"
        btnPrescriptions.Padding = New Padding(4)
        btnPrescriptions.Size = New Size(305, 61)
        btnPrescriptions.TabIndex = 6
        btnPrescriptions.Text = "Prescipciones"
        btnPrescriptions.UseVisualStyleBackColor = False
        ' 
        ' btnUsers
        ' 
        btnUsers.BackColor = Color.WhiteSmoke
        btnUsers.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Roboto Slab", 12F)
        btnUsers.ForeColor = Color.Navy
        btnUsers.Image = My.Resources.Resources.tabler_icon_users
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(11, 279)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(4)
        btnUsers.Size = New Size(305, 61)
        btnUsers.TabIndex = 7
        btnUsers.Text = "Usuarios"
        btnUsers.UseVisualStyleBackColor = False
        ' 
        ' btnEmployees
        ' 
        btnEmployees.BackColor = Color.WhiteSmoke
        btnEmployees.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnEmployees.FlatAppearance.BorderSize = 0
        btnEmployees.FlatStyle = FlatStyle.Flat
        btnEmployees.Font = New Font("Roboto Slab", 12F)
        btnEmployees.ForeColor = Color.Navy
        btnEmployees.Image = My.Resources.Resources.tabler_icon_user_shield
        btnEmployees.ImageAlign = ContentAlignment.MiddleLeft
        btnEmployees.Location = New Point(11, 346)
        btnEmployees.Name = "btnEmployees"
        btnEmployees.Padding = New Padding(4)
        btnEmployees.Size = New Size(305, 61)
        btnEmployees.TabIndex = 8
        btnEmployees.Text = "Empleados"
        btnEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnSpecialties
        ' 
        btnSpecialties.BackColor = Color.WhiteSmoke
        btnSpecialties.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnSpecialties.FlatAppearance.BorderSize = 0
        btnSpecialties.FlatStyle = FlatStyle.Flat
        btnSpecialties.Font = New Font("Roboto Slab", 12F)
        btnSpecialties.ForeColor = Color.Navy
        btnSpecialties.Image = My.Resources.Resources.tabler_icon_dna
        btnSpecialties.ImageAlign = ContentAlignment.MiddleLeft
        btnSpecialties.Location = New Point(11, 413)
        btnSpecialties.Name = "btnSpecialties"
        btnSpecialties.Padding = New Padding(4)
        btnSpecialties.Size = New Size(305, 61)
        btnSpecialties.TabIndex = 9
        btnSpecialties.Text = "Especialidades"
        btnSpecialties.UseVisualStyleBackColor = False
        ' 
        ' btnPatients
        ' 
        btnPatients.BackColor = Color.WhiteSmoke
        btnPatients.FlatAppearance.BorderColor = Color.CornflowerBlue
        btnPatients.FlatAppearance.BorderSize = 0
        btnPatients.FlatStyle = FlatStyle.Flat
        btnPatients.Font = New Font("Roboto Slab", 12F)
        btnPatients.ForeColor = Color.Navy
        btnPatients.Image = My.Resources.Resources.tabler_icon_user_plus
        btnPatients.ImageAlign = ContentAlignment.MiddleLeft
        btnPatients.Location = New Point(11, 480)
        btnPatients.Name = "btnPatients"
        btnPatients.Padding = New Padding(4)
        btnPatients.Size = New Size(305, 61)
        btnPatients.TabIndex = 10
        btnPatients.Text = "Pacientes"
        btnPatients.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.AutoSize = True
        txtUsername.Font = New Font("Roboto Slab", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(74, 26)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(87, 22)
        txtUsername.TabIndex = 2
        txtUsername.Text = "Username"
        ' 
        ' txtRole
        ' 
        txtRole.AutoSize = True
        txtRole.Location = New Point(74, 11)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(30, 15)
        txtRole.TabIndex = 1
        txtRole.Text = "Role"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.user_icon
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(11, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(57, 57)
        Panel3.TabIndex = 0
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1103, 710)
        Controls.Add(Panel2)
        Controls.Add(mainPanel)
        Name = "Home"
        Text = "Medisys"
        Panel2.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents mainPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtRole As Label
    Friend WithEvents txtUsername As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnConditions As Button
    Friend WithEvents btnCheckup As Button
    Friend WithEvents btnPrescriptions As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnSpecialties As Button
    Friend WithEvents btnPatients As Button
End Class
