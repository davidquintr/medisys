<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageEmployee
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
        Panel7 = New Panel()
        cboxSpecialty = New ComboBox()
        Label6 = New Label()
        Panel6 = New Panel()
        cboxUser = New ComboBox()
        Label4 = New Label()
        Panel5 = New Panel()
        cboxSex = New ComboBox()
        Label5 = New Label()
        Panel4 = New Panel()
        rtboxAddress = New RichTextBox()
        Label3 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        tboxLastName = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        tboxName = New TextBox()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnCancel)
        FlowLayoutPanel1.Controls.Add(btnAccept)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 529)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(578, 44)
        FlowLayoutPanel1.TabIndex = 10
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Roboto Slab", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(3, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(241, 28)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Administrar Empleado"
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
        SplitContainer1.Panel2.Controls.Add(Panel7)
        SplitContainer1.Panel2.Controls.Add(Panel6)
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(578, 521)
        SplitContainer1.SplitterDistance = 52
        SplitContainer1.TabIndex = 9
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(cboxSpecialty)
        Panel7.Controls.Add(Label6)
        Panel7.Location = New Point(17, 366)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(8)
        Panel7.Size = New Size(543, 68)
        Panel7.TabIndex = 14
        ' 
        ' cboxSpecialty
        ' 
        cboxSpecialty.Dock = DockStyle.Bottom
        cboxSpecialty.FormattingEnabled = True
        cboxSpecialty.Location = New Point(8, 37)
        cboxSpecialty.Name = "cboxSpecialty"
        cboxSpecialty.Size = New Size(527, 23)
        cboxSpecialty.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label6.Location = New Point(8, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 22)
        Label6.TabIndex = 1
        Label6.Text = "Especialidad"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(cboxUser)
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(297, 271)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(8)
        Panel6.Size = New Size(263, 68)
        Panel6.TabIndex = 13
        ' 
        ' cboxUser
        ' 
        cboxUser.Dock = DockStyle.Bottom
        cboxUser.FormattingEnabled = True
        cboxUser.Location = New Point(8, 37)
        cboxUser.Name = "cboxUser"
        cboxUser.Size = New Size(247, 23)
        cboxUser.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label4.Location = New Point(8, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 22)
        Label4.TabIndex = 1
        Label4.Text = "Usuario Asignado"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(cboxSex)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(17, 271)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(8)
        Panel5.Size = New Size(263, 68)
        Panel5.TabIndex = 12
        ' 
        ' cboxSex
        ' 
        cboxSex.Dock = DockStyle.Bottom
        cboxSex.FormattingEnabled = True
        cboxSex.Items.AddRange(New Object() {"male", "female"})
        cboxSex.Location = New Point(8, 37)
        cboxSex.Name = "cboxSex"
        cboxSex.Size = New Size(247, 23)
        cboxSex.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label5.Location = New Point(8, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 22)
        Label5.TabIndex = 1
        Label5.Text = "Sexo"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(rtboxAddress)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(17, 105)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(8)
        Panel4.Size = New Size(543, 144)
        Panel4.TabIndex = 11
        ' 
        ' rtboxAddress
        ' 
        rtboxAddress.Dock = DockStyle.Bottom
        rtboxAddress.Location = New Point(8, 40)
        rtboxAddress.Name = "rtboxAddress"
        rtboxAddress.Size = New Size(527, 96)
        rtboxAddress.TabIndex = 2
        rtboxAddress.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label3.Location = New Point(8, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 22)
        Label3.TabIndex = 1
        Label3.Text = "Dirección"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(tboxLastName)
        Panel3.Location = New Point(297, 15)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(8)
        Panel3.Size = New Size(263, 68)
        Panel3.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label2.Location = New Point(8, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 22)
        Label2.TabIndex = 1
        Label2.Text = "Apellidos"
        ' 
        ' tboxLastName
        ' 
        tboxLastName.Dock = DockStyle.Bottom
        tboxLastName.Location = New Point(8, 37)
        tboxLastName.Name = "tboxLastName"
        tboxLastName.Size = New Size(247, 23)
        tboxLastName.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(tboxName)
        Panel2.Location = New Point(17, 15)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8)
        Panel2.Size = New Size(263, 68)
        Panel2.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 22)
        Label1.TabIndex = 1
        Label1.Text = "Nombres"
        ' 
        ' tboxName
        ' 
        tboxName.Dock = DockStyle.Bottom
        tboxName.Location = New Point(8, 37)
        tboxName.Name = "tboxName"
        tboxName.Size = New Size(247, 23)
        tboxName.TabIndex = 0
        ' 
        ' frmManageEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 581)
        Controls.Add(SplitContainer1)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmManageEmployee"
        Padding = New Padding(8)
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManageEmployee"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rtboxAddress As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tboxLastName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxName As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cboxUser As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cboxSex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cboxSpecialty As ComboBox
    Friend WithEvents Label6 As Label
End Class
