<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCondition
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
        Label1 = New Label()
        tboxName = New TextBox()
        Panel2 = New Panel()
        lblTitle = New Label()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        Panel4 = New Panel()
        rtboxDescription = New RichTextBox()
        Label3 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = SystemColors.ButtonFace
        btnAccept.ForeColor = Color.Navy
        btnAccept.Image = My.Resources.Resources.tabler_icon_check
        btnAccept.ImageAlign = ContentAlignment.MiddleRight
        btnAccept.Location = New Point(316, 7)
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
        FlowLayoutPanel1.Location = New Point(8, 344)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 4, 0, 0)
        FlowLayoutPanel1.RightToLeft = RightToLeft.Yes
        FlowLayoutPanel1.Size = New Size(505, 44)
        FlowLayoutPanel1.TabIndex = 10
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.ButtonFace
        btnCancel.ForeColor = Color.Navy
        btnCancel.Image = My.Resources.Resources.tabler_icon_x
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(412, 7)
        btnCancel.Name = "btnCancel"
        btnCancel.Padding = New Padding(4)
        btnCancel.Size = New Size(90, 36)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancelar"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 22)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' tboxName
        ' 
        tboxName.Dock = DockStyle.Bottom
        tboxName.Location = New Point(8, 37)
        tboxName.Name = "tboxName"
        tboxName.Size = New Size(452, 23)
        tboxName.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(tboxName)
        Panel2.Location = New Point(18, 20)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8)
        Panel2.Size = New Size(468, 68)
        Panel2.TabIndex = 7
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Roboto Slab", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(3, 13)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(321, 28)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Administrar Condición Médica"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(505, 49)
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
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(505, 336)
        SplitContainer1.SplitterDistance = 52
        SplitContainer1.TabIndex = 9
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(rtboxDescription)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(18, 109)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(8)
        Panel4.Size = New Size(468, 144)
        Panel4.TabIndex = 12
        ' 
        ' rtboxDescription
        ' 
        rtboxDescription.Dock = DockStyle.Bottom
        rtboxDescription.Location = New Point(8, 40)
        rtboxDescription.Name = "rtboxDescription"
        rtboxDescription.Size = New Size(452, 96)
        rtboxDescription.TabIndex = 2
        rtboxDescription.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Roboto Slab Medium", 12F, FontStyle.Bold)
        Label3.Location = New Point(8, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 22)
        Label3.TabIndex = 1
        Label3.Text = "Descripción"
        ' 
        ' frmManageCondition
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 396)
        Controls.Add(SplitContainer1)
        Controls.Add(FlowLayoutPanel1)
        Name = "frmManageCondition"
        Padding = New Padding(8)
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManageCondition"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tboxName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rtboxDescription As RichTextBox
    Friend WithEvents Label3 As Label
End Class
