<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete))
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.projectid = New Bunifu.Framework.UI.BunifuDropdown()
        Me.btnSubmit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(397, 90)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(92, 22)
        Me.BunifuCustomLabel3.TabIndex = 17
        Me.BunifuCustomLabel3.Text = "ProjectID"
        '
        'projectid
        '
        Me.projectid.BackColor = System.Drawing.Color.Transparent
        Me.projectid.BorderRadius = 3
        Me.projectid.DisabledColor = System.Drawing.Color.Gray
        Me.projectid.ForeColor = System.Drawing.Color.White
        Me.projectid.Items = New String() {"ertq", "qert", "yuik", "qert"}
        Me.projectid.Location = New System.Drawing.Point(337, 115)
        Me.projectid.Name = "projectid"
        Me.projectid.NomalColor = System.Drawing.Color.Salmon
        Me.projectid.onHoverColor = System.Drawing.Color.Tomato
        Me.projectid.selectedIndex = -1
        Me.projectid.Size = New System.Drawing.Size(217, 35)
        Me.projectid.TabIndex = 16
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
        Me.btnSubmit.Location = New System.Drawing.Point(293, 209)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(314, 43)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(361, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(193, 28)
        Me.BunifuCustomLabel1.TabIndex = 19
        Me.BunifuCustomLabel1.Text = "DELETE PROJECT"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.projectid)
        Me.Name = "Delete"
        Me.Size = New System.Drawing.Size(932, 290)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents projectid As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btnSubmit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
