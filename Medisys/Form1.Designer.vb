<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SplitContainer1 = New SplitContainer()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnCancel = New Button()
        btnAccept = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        tboxPassword = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        tboxUsername = New TextBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(FlowLayoutPanel2)
        SplitContainer1.Panel1.Controls.Add(FlowLayoutPanel1)
        SplitContainer1.Panel1.Controls.Add(Panel2)
        SplitContainer1.Panel1.Controls.Add(Panel1)
        SplitContainer1.Panel1.Padding = New Padding(8)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.SteelBlue
        SplitContainer1.Panel2.BackgroundImage = My.Resources.Resources.medisys_full
        SplitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Zoom
        SplitContainer1.Size = New Size(726, 457)
        SplitContainer1.SplitterDistance = 384
        SplitContainer1.TabIndex = 0
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label3)
        FlowLayoutPanel2.Controls.Add(Label4)
        FlowLayoutPanel2.Dock = DockStyle.Top
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(8, 8)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(368, 75)
        FlowLayoutPanel2.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Slab", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 48)
        Label3.TabIndex = 12
        Label3.Text = "Medisys"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(248, 15)
        Label4.TabIndex = 13
        Label4.Text = "Sistema de prescripciones y registros médicos"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnCancel)
        FlowLayoutPanel1.Controls.Add(btnAccept)
        FlowLayoutPanel1.Dock = DockStyle.Bottom
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New Point(8, 389)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(8)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(368, 60)
        FlowLayoutPanel1.TabIndex = 9
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.ForeColor = Color.Navy
        btnCancel.Image = My.Resources.Resources.tabler_icon_door_exit
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(11, 11)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(4)
        btnCancel.Size = New Size(170, 36)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Salir"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = SystemColors.ButtonFace
        btnAccept.ForeColor = Color.Navy
        btnAccept.Image = My.Resources.Resources.tabler_icon_login
        btnAccept.ImageAlign = ContentAlignment.MiddleRight
        btnAccept.Location = New Point(187, 11)
        btnAccept.Name = "btnAccept"
        btnAccept.Padding = New Padding(4)
        btnAccept.Size = New Size(170, 36)
        btnAccept.TabIndex = 1
        btnAccept.Text = "Iniciar Sesión"
        btnAccept.TextAlign = ContentAlignment.MiddleLeft
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(tboxPassword)
        Panel2.Location = New Point(12, 222)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8)
        Panel2.Size = New Size(361, 68)
        Panel2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Roboto Slab", 12F, FontStyle.Bold)
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
        tboxPassword.PasswordChar = "*"c
        tboxPassword.Size = New Size(345, 23)
        tboxPassword.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(tboxUsername)
        Panel1.Location = New Point(12, 148)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(8)
        Panel1.Size = New Size(361, 68)
        Panel1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Roboto Slab", 12F, FontStyle.Bold)
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 22)
        Label1.TabIndex = 1
        Label1.Text = "Nombre de Usuario"
        ' 
        ' tboxUsername
        ' 
        tboxUsername.Dock = DockStyle.Bottom
        tboxUsername.Location = New Point(8, 37)
        tboxUsername.Name = "tboxUsername"
        tboxUsername.Size = New Size(345, 23)
        tboxUsername.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(726, 457)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Iniciar Sesión - Medisys"
        SplitContainer1.Panel1.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tboxPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxUsername As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
