<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl2))
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.projectnamebox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.menegerbox = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDatepicker2 = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'projectnamebox
        '
        Me.projectnamebox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.projectnamebox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.projectnamebox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.projectnamebox.HintForeColor = System.Drawing.Color.Empty
        Me.projectnamebox.HintText = "ProjectName"
        Me.projectnamebox.isPassword = False
        Me.projectnamebox.LineFocusedColor = System.Drawing.Color.Salmon
        Me.projectnamebox.LineIdleColor = System.Drawing.Color.Gray
        Me.projectnamebox.LineMouseHoverColor = System.Drawing.Color.Tomato
        Me.projectnamebox.LineThickness = 3
        Me.projectnamebox.Location = New System.Drawing.Point(97, 65)
        Me.projectnamebox.Margin = New System.Windows.Forms.Padding(4)
        Me.projectnamebox.Name = "projectnamebox"
        Me.projectnamebox.Size = New System.Drawing.Size(379, 42)
        Me.projectnamebox.TabIndex = 1
        Me.projectnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'menegerbox
        '
        Me.menegerbox.BackColor = System.Drawing.Color.Transparent
        Me.menegerbox.BorderRadius = 3
        Me.menegerbox.DisabledColor = System.Drawing.Color.Gray
        Me.menegerbox.ForeColor = System.Drawing.Color.White
        Me.menegerbox.Items = New String() {"ertq", "qert", "yuik", "qert"}
        Me.menegerbox.Location = New System.Drawing.Point(97, 165)
        Me.menegerbox.Name = "menegerbox"
        Me.menegerbox.NomalColor = System.Drawing.Color.Salmon
        Me.menegerbox.onHoverColor = System.Drawing.Color.Tomato
        Me.menegerbox.selectedIndex = -1
        Me.menegerbox.Size = New System.Drawing.Size(217, 35)
        Me.menegerbox.TabIndex = 2
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.Salmon
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(97, 355)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker1.TabIndex = 3
        Me.BunifuDatepicker1.Value = New Date(2019, 2, 13, 14, 12, 52, 949)
        '
        'BunifuDatepicker2
        '
        Me.BunifuDatepicker2.BackColor = System.Drawing.Color.Salmon
        Me.BunifuDatepicker2.BorderRadius = 0
        Me.BunifuDatepicker2.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker2.FormatCustom = Nothing
        Me.BunifuDatepicker2.Location = New System.Drawing.Point(97, 252)
        Me.BunifuDatepicker2.Name = "BunifuDatepicker2"
        Me.BunifuDatepicker2.Size = New System.Drawing.Size(303, 36)
        Me.BunifuDatepicker2.TabIndex = 4
        Me.BunifuDatepicker2.Value = New Date(2019, 2, 13, 14, 12, 52, 949)
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(93, 227)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(98, 22)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "StartDate"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(93, 330)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(91, 22)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "EndDate"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(93, 140)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(112, 22)
        Me.BunifuCustomLabel3.TabIndex = 7
        Me.BunifuCustomLabel3.Text = "MenegerId"
        '
        'btnSubmit
        '
        Me.btnSubmit.ActiveBorderThickness = 1
        Me.btnSubmit.ActiveCornerRadius = 20
        Me.btnSubmit.ActiveFillColor = System.Drawing.Color.Tomato
        Me.btnSubmit.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.ActiveLineColor = System.Drawing.Color.Tomato
        Me.btnSubmit.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Control
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.ButtonText = "SUBMIT"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Honeydew
        Me.btnSubmit.IdleBorderThickness = 1
        Me.btnSubmit.IdleCornerRadius = 20
        Me.btnSubmit.IdleFillColor = System.Drawing.Color.Salmon
        Me.btnSubmit.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.IdleLineColor = System.Drawing.Color.Salmon
        Me.btnSubmit.Location = New System.Drawing.Point(97, 436)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(314, 43)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(892, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 656)
        Me.VScrollBar1.TabIndex = 9
        '
        'UserControl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuDatepicker2)
        Me.Controls.Add(Me.BunifuDatepicker1)
        Me.Controls.Add(Me.menegerbox)
        Me.Controls.Add(Me.projectnamebox)
        Me.Name = "UserControl2"
        Me.Size = New System.Drawing.Size(932, 656)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents projectnamebox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents menegerbox As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuDatepicker2 As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
