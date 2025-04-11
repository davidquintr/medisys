<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePatient
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
        tboxName = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        tboxLastName = New TextBox()
        Panel3 = New Panel()
        rtboxAddress = New RichTextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        cboxSex = New ComboBox()
        Label5 = New Label()
        Panel5 = New Panel()
        SplitContainer1 = New SplitContainer()
        Panel1 = New Panel()
        lblTitle = New Label()
        btnUploadImage = New Button()
        btnManageConditions = New Button()
        Panel8 = New Panel()
        lblURI = New Label()
        picboxAvatar = New PictureBox()
        Panel7 = New Panel()
        Label6 = New Label()
        tboxPhone = New TextBox()
        Panel6 = New Panel()
        Label4 = New Label()
        tboxIDCard = New TextBox()
        btnCancel = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnAccept = New Button()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        CType(picboxAvatar, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tboxName
        ' 
        tboxName.Dock = DockStyle.Bottom
        tboxName.Location = New Point(8, 37)
        tboxName.Name = "tboxName"
        tboxName.Size = New Size(247, 23)
        tboxName.TabIndex = 0
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
        SplitContainer1.Panel2.Controls.Add(btnUploadImage)
        SplitContainer1.Panel2.Controls.Add(btnManageConditions)
        SplitContainer1.Panel2.Controls.Add(Panel8)
        SplitContainer1.Panel2.Controls.Add(picboxAvatar)
        SplitContainer1.Panel2.Controls.Add(Panel7)
        SplitContainer1.Panel2.Controls.Add(Panel6)
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(578, 620)
        SplitContainer1.SplitterDistance = 52
        SplitContainer1.TabIndex = 11
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
        lblTitle.Size = New Size(228, 28)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Administrar Paciente"
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.Location = New Point(423, 459)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(137, 31)
        btnUploadImage.TabIndex = 21
        btnUploadImage.Text = "Subir Imagen"
        btnUploadImage.UseVisualStyleBackColor = True
        ' 
        ' btnManageConditions
        ' 
        btnManageConditions.Location = New Point(17, 511)
        btnManageConditions.Name = "btnManageConditions"
        btnManageConditions.Size = New Size(543, 38)
        btnManageConditions.TabIndex = 20
        btnManageConditions.Text = "Administrar Condiciones Médicas"
        btnManageConditions.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lblURI)
        Panel8.Location = New Point(423, 370)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(4)
        Panel8.Size = New Size(137, 83)
        Panel8.TabIndex = 19
        ' 
        ' lblURI
        ' 
        lblURI.Dock = DockStyle.Fill
        lblURI.Location = New Point(4, 4)
        lblURI.Name = "lblURI"
        lblURI.Size = New Size(129, 75)
        lblURI.TabIndex = 0
        lblURI.Text = "URI"
        lblURI.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picboxAvatar
        ' 
        picboxAvatar.BackgroundImage = My.Resources.Resources.user_icon
        picboxAvatar.BackgroundImageLayout = ImageLayout.Stretch
        picboxAvatar.InitialImage = Nothing
        picboxAvatar.Location = New Point(297, 370)
        picboxAvatar.Name = "picboxAvatar"
        picboxAvatar.Size = New Size(120, 120)
        picboxAvatar.TabIndex = 17
        picboxAvatar.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(tboxPhone)
        Panel7.Location = New Point(17, 370)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(8)
        Panel7.Size = New Size(263, 68)
        Panel7.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label6.Location = New Point(8, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 22)
        Label6.TabIndex = 1
        Label6.Text = "Teléfono"
        ' 
        ' tboxPhone
        ' 
        tboxPhone.Dock = DockStyle.Bottom
        tboxPhone.Location = New Point(8, 37)
        tboxPhone.Name = "tboxPhone"
        tboxPhone.Size = New Size(247, 23)
        tboxPhone.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(tboxIDCard)
        Panel6.Location = New Point(297, 271)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(8)
        Panel6.Size = New Size(263, 68)
        Panel6.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label4.Location = New Point(8, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 22)
        Label4.TabIndex = 1
        Label4.Text = "Cédula"
        ' 
        ' tboxIDCard
        ' 
        tboxIDCard.Dock = DockStyle.Bottom
        tboxIDCard.Location = New Point(8, 37)
        tboxIDCard.Name = "tboxIDCard"
        tboxIDCard.Size = New Size(247, 23)
        tboxIDCard.TabIndex = 0
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnCancel)
        FlowLayoutPanel1.Controls.Add(btnAccept)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.Location = New Point(8, 628)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(578, 44)
        FlowLayoutPanel1.TabIndex = 12
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
        ' frmManagePatient
        ' 
        AcceptButton = btnAccept
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(594, 680)
        Controls.Add(SplitContainer1)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmManagePatient"
        Padding = New Padding(8)
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManagePatient"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel8.ResumeLayout(False)
        CType(picboxAvatar, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tboxName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tboxLastName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents rtboxAddress As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cboxSex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cboxSpecialty As ComboBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAccept As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tboxIDCard As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblURI As Label
    Friend WithEvents picboxAvatar As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tboxPhone As TextBox
    Friend WithEvents btnManageConditions As Button
    Friend WithEvents btnUploadImage As Button
End Class
