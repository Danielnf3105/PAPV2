<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCheckbox2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BttSair = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BttLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PAPV1.My.Resources.Resources.Just_For_Friends__3_
        Me.PictureBox1.Location = New System.Drawing.Point(83, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(475, 218)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox1.Checked = True
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(446, 282)
        Me.BunifuCheckbox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 36
        '
        'BunifuCheckbox2
        '
        Me.BunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.Checked = True
        Me.BunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox2.Location = New System.Drawing.Point(446, 312)
        Me.BunifuCheckbox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuCheckbox2.Name = "BunifuCheckbox2"
        Me.BunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox2.TabIndex = 35
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(252, 310)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(187, 22)
        Me.TxtPassword.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "PassWord "
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(252, 282)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(187, 22)
        Me.TxtUserName.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Utilizador"
        '
        'BttSair
        '
        Me.BttSair.Activecolor = System.Drawing.Color.Red
        Me.BttSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttSair.BorderRadius = 0
        Me.BttSair.ButtonText = "Sair"
        Me.BttSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttSair.DisabledColor = System.Drawing.Color.Gray
        Me.BttSair.Iconcolor = System.Drawing.Color.Transparent
        Me.BttSair.Iconimage = Nothing
        Me.BttSair.Iconimage_right = Nothing
        Me.BttSair.Iconimage_right_Selected = Nothing
        Me.BttSair.Iconimage_Selected = Nothing
        Me.BttSair.IconMarginLeft = 0
        Me.BttSair.IconMarginRight = 0
        Me.BttSair.IconRightVisible = True
        Me.BttSair.IconRightZoom = 0R
        Me.BttSair.IconVisible = True
        Me.BttSair.IconZoom = 90.0R
        Me.BttSair.IsTab = False
        Me.BttSair.Location = New System.Drawing.Point(344, 339)
        Me.BttSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BttSair.Name = "BttSair"
        Me.BttSair.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttSair.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttSair.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttSair.selected = False
        Me.BttSair.Size = New System.Drawing.Size(95, 43)
        Me.BttSair.TabIndex = 40
        Me.BttSair.Text = "Sair"
        Me.BttSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BttSair.Textcolor = System.Drawing.Color.Black
        Me.BttSair.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BttLogin
        '
        Me.BttLogin.Activecolor = System.Drawing.Color.Lime
        Me.BttLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttLogin.BorderRadius = 0
        Me.BttLogin.ButtonText = "Login"
        Me.BttLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttLogin.DisabledColor = System.Drawing.Color.Gray
        Me.BttLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.BttLogin.Iconimage = Nothing
        Me.BttLogin.Iconimage_right = Nothing
        Me.BttLogin.Iconimage_right_Selected = Nothing
        Me.BttLogin.Iconimage_Selected = Nothing
        Me.BttLogin.IconMarginLeft = 0
        Me.BttLogin.IconMarginRight = 0
        Me.BttLogin.IconRightVisible = True
        Me.BttLogin.IconRightZoom = 0R
        Me.BttLogin.IconVisible = True
        Me.BttLogin.IconZoom = 90.0R
        Me.BttLogin.IsTab = False
        Me.BttLogin.Location = New System.Drawing.Point(252, 339)
        Me.BttLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BttLogin.Name = "BttLogin"
        Me.BttLogin.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttLogin.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttLogin.selected = False
        Me.BttLogin.Size = New System.Drawing.Size(95, 42)
        Me.BttLogin.TabIndex = 39
        Me.BttLogin.Text = "Login"
        Me.BttLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BttLogin.Textcolor = System.Drawing.Color.Black
        Me.BttLogin.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 450)
        Me.Controls.Add(Me.BttSair)
        Me.Controls.Add(Me.BttLogin)
        Me.Controls.Add(Me.BunifuCheckbox1)
        Me.Controls.Add(Me.BunifuCheckbox2)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCheckbox2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BttSair As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BttLogin As Bunifu.Framework.UI.BunifuFlatButton
End Class
