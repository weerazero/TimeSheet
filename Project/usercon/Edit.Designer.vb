<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.start = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.enddate = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.projectid = New Bunifu.Framework.UI.BunifuDropdown()
        Me.projectnamebox = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.menegerbox = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
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
        Me.btnSubmit.Location = New System.Drawing.Point(323, 468)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(314, 43)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(147, 118)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(92, 22)
        Me.BunifuCustomLabel3.TabIndex = 15
        Me.BunifuCustomLabel3.Text = "ProjectID"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(549, 198)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(91, 22)
        Me.BunifuCustomLabel2.TabIndex = 14
        Me.BunifuCustomLabel2.Text = "EndDate"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(549, 118)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(98, 22)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "StartDate"
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.Salmon
        Me.start.BorderRadius = 0
        Me.start.ForeColor = System.Drawing.Color.White
        Me.start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.start.FormatCustom = Nothing
        Me.start.Location = New System.Drawing.Point(553, 143)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(303, 36)
        Me.start.TabIndex = 12
        Me.start.Value = New Date(2019, 2, 13, 14, 12, 52, 949)
        '
        'enddate
        '
        Me.enddate.BackColor = System.Drawing.Color.Salmon
        Me.enddate.BorderRadius = 0
        Me.enddate.ForeColor = System.Drawing.Color.White
        Me.enddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.enddate.FormatCustom = Nothing
        Me.enddate.Location = New System.Drawing.Point(553, 234)
        Me.enddate.Name = "enddate"
        Me.enddate.Size = New System.Drawing.Size(303, 36)
        Me.enddate.TabIndex = 11
        Me.enddate.Value = New Date(2019, 2, 13, 14, 12, 52, 949)
        '
        'projectid
        '
        Me.projectid.BackColor = System.Drawing.Color.Transparent
        Me.projectid.BorderRadius = 3
        Me.projectid.DisabledColor = System.Drawing.Color.Gray
        Me.projectid.ForeColor = System.Drawing.Color.White
        Me.projectid.Items = New String() {"ertq", "qert", "yuik", "qert"}
        Me.projectid.Location = New System.Drawing.Point(151, 143)
        Me.projectid.Name = "projectid"
        Me.projectid.NomalColor = System.Drawing.Color.Salmon
        Me.projectid.onHoverColor = System.Drawing.Color.Tomato
        Me.projectid.selectedIndex = -1
        Me.projectid.Size = New System.Drawing.Size(217, 35)
        Me.projectid.TabIndex = 10
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
        Me.projectnamebox.Location = New System.Drawing.Point(151, 228)
        Me.projectnamebox.Margin = New System.Windows.Forms.Padding(4)
        Me.projectnamebox.Name = "projectnamebox"
        Me.projectnamebox.Size = New System.Drawing.Size(217, 42)
        Me.projectnamebox.TabIndex = 17
        Me.projectnamebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(147, 323)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(112, 22)
        Me.BunifuCustomLabel4.TabIndex = 19
        Me.BunifuCustomLabel4.Text = "MenegerId"
        '
        'menegerbox
        '
        Me.menegerbox.BackColor = System.Drawing.Color.Transparent
        Me.menegerbox.BorderRadius = 3
        Me.menegerbox.DisabledColor = System.Drawing.Color.Gray
        Me.menegerbox.ForeColor = System.Drawing.Color.White
        Me.menegerbox.Items = New String() {"ertq", "qert", "yuik", "qert"}
        Me.menegerbox.Location = New System.Drawing.Point(151, 348)
        Me.menegerbox.Name = "menegerbox"
        Me.menegerbox.NomalColor = System.Drawing.Color.Salmon
        Me.menegerbox.onHoverColor = System.Drawing.Color.Tomato
        Me.menegerbox.selectedIndex = -1
        Me.menegerbox.Size = New System.Drawing.Size(217, 35)
        Me.menegerbox.TabIndex = 18
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(392, 34)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(165, 28)
        Me.BunifuCustomLabel5.TabIndex = 20
        Me.BunifuCustomLabel5.Text = "EDIT PROJECT"
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.menegerbox)
        Me.Controls.Add(Me.projectnamebox)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.enddate)
        Me.Controls.Add(Me.projectid)
        Me.Name = "Edit"
        Me.Size = New System.Drawing.Size(932, 656)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents start As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents enddate As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents projectid As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents projectnamebox As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents menegerbox As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
