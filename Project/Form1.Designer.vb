<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtusername = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.warningpass = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.HintForeColor = System.Drawing.Color.DimGray
        Me.txtusername.HintText = "Username"
        Me.txtusername.isPassword = False
        Me.txtusername.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtusername.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtusername.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtusername.LineThickness = 4
        Me.txtusername.Location = New System.Drawing.Point(111, 130)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(370, 44)
        Me.txtusername.TabIndex = 0
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HintText = ""
        Me.txtPassword.isPassword = False
        Me.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtPassword.LineThickness = 4
        Me.txtPassword.Location = New System.Drawing.Point(111, 217)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(370, 44)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "Password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Honeydew
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(201, 313)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(181, 41)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Nothing
        Me.BunifuTileButton1.ImagePosition = 60
        Me.BunifuTileButton1.ImageZoom = 60
        Me.BunifuTileButton1.LabelPosition = 41
        Me.BunifuTileButton1.LabelText = "X"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(543, 15)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(21, 21)
        Me.BunifuTileButton1.TabIndex = 4
        '
        'warningpass
        '
        Me.warningpass.AutoSize = True
        Me.warningpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.warningpass.ForeColor = System.Drawing.SystemColors.Control
        Me.warningpass.Location = New System.Drawing.Point(363, 275)
        Me.warningpass.Name = "warningpass"
        Me.warningpass.Size = New System.Drawing.Size(85, 13)
        Me.warningpass.TabIndex = 5
        Me.warningpass.Text = "WrongPassword"
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton3.color = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = Nothing
        Me.BunifuTileButton3.ImagePosition = 60
        Me.BunifuTileButton3.ImageZoom = 60
        Me.BunifuTileButton3.LabelPosition = 41
        Me.BunifuTileButton3.LabelText = "-"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(511, 15)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(20, 21)
        Me.BunifuTileButton3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(579, 508)
        Me.Controls.Add(Me.BunifuTileButton3)
        Me.Controls.Add(Me.warningpass)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtusername)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents warningpass As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
End Class
