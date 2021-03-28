<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registar_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaskText_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.TextMorada = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCheckbox2 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCheckbox3 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCheckbox4 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCheckbox5 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BttSair = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BttCriarUser = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Location = New System.Drawing.Point(170, 280)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(149, 20)
        Me.TxtPassword.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 284)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PassWord "
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserName.Location = New System.Drawing.Point(170, 258)
        Me.TxtUserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(149, 20)
        Me.TxtUserName.TabIndex = 11
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNome.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtNome.Location = New System.Drawing.Point(170, 235)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(149, 20)
        Me.TxtNome.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 262)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Utilizador"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(113, 235)
        Me.LblNome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 8
        Me.LblNome.Text = "Nome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PAPV1.My.Resources.Resources.Just_For_Friends__3_
        Me.PictureBox1.Location = New System.Drawing.Point(70, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 191)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'MaskText_telefone
        '
        Me.MaskText_telefone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MaskText_telefone.Location = New System.Drawing.Point(170, 303)
        Me.MaskText_telefone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaskText_telefone.Mask = "999999999"
        Me.MaskText_telefone.Name = "MaskText_telefone"
        Me.MaskText_telefone.Size = New System.Drawing.Size(149, 20)
        Me.MaskText_telefone.TabIndex = 9
        '
        'TextMorada
        '
        Me.TextMorada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextMorada.Location = New System.Drawing.Point(170, 326)
        Me.TextMorada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextMorada.Name = "TextMorada"
        Me.TextMorada.Size = New System.Drawing.Size(149, 20)
        Me.TextMorada.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 330)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Morada"
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox1.Checked = True
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(326, 283)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 20
        Me.BunifuCheckbox1.Visible = False
        '
        'BunifuCheckbox2
        '
        Me.BunifuCheckbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox2.Checked = True
        Me.BunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox2.Location = New System.Drawing.Point(326, 306)
        Me.BunifuCheckbox2.Name = "BunifuCheckbox2"
        Me.BunifuCheckbox2.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox2.TabIndex = 21
        Me.BunifuCheckbox2.Visible = False
        '
        'BunifuCheckbox3
        '
        Me.BunifuCheckbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox3.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox3.Checked = True
        Me.BunifuCheckbox3.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox3.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox3.Location = New System.Drawing.Point(326, 236)
        Me.BunifuCheckbox3.Name = "BunifuCheckbox3"
        Me.BunifuCheckbox3.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox3.TabIndex = 22
        Me.BunifuCheckbox3.Visible = False
        '
        'BunifuCheckbox4
        '
        Me.BunifuCheckbox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox4.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox4.Checked = True
        Me.BunifuCheckbox4.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox4.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox4.Location = New System.Drawing.Point(326, 260)
        Me.BunifuCheckbox4.Name = "BunifuCheckbox4"
        Me.BunifuCheckbox4.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox4.TabIndex = 23
        Me.BunifuCheckbox4.Visible = False
        '
        'BunifuCheckbox5
        '
        Me.BunifuCheckbox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox5.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox5.Checked = True
        Me.BunifuCheckbox5.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.BunifuCheckbox5.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox5.Location = New System.Drawing.Point(326, 328)
        Me.BunifuCheckbox5.Name = "BunifuCheckbox5"
        Me.BunifuCheckbox5.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox5.TabIndex = 24
        Me.BunifuCheckbox5.Visible = False
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
        Me.BttSair.Location = New System.Drawing.Point(247, 358)
        Me.BttSair.Name = "BttSair"
        Me.BttSair.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttSair.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttSair.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttSair.selected = False
        Me.BttSair.Size = New System.Drawing.Size(71, 35)
        Me.BttSair.TabIndex = 28
        Me.BttSair.Text = "Sair"
        Me.BttSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BttSair.Textcolor = System.Drawing.Color.Black
        Me.BttSair.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BttCriarUser
        '
        Me.BttCriarUser.Activecolor = System.Drawing.Color.LimeGreen
        Me.BttCriarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttCriarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttCriarUser.BorderRadius = 0
        Me.BttCriarUser.ButtonText = "Criar utilizador"
        Me.BttCriarUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BttCriarUser.DisabledColor = System.Drawing.Color.Gray
        Me.BttCriarUser.Iconcolor = System.Drawing.Color.Transparent
        Me.BttCriarUser.Iconimage = Nothing
        Me.BttCriarUser.Iconimage_right = Nothing
        Me.BttCriarUser.Iconimage_right_Selected = Nothing
        Me.BttCriarUser.Iconimage_Selected = Nothing
        Me.BttCriarUser.IconMarginLeft = 0
        Me.BttCriarUser.IconMarginRight = 0
        Me.BttCriarUser.IconRightVisible = True
        Me.BttCriarUser.IconRightZoom = 0R
        Me.BttCriarUser.IconVisible = True
        Me.BttCriarUser.IconZoom = 90.0R
        Me.BttCriarUser.IsTab = False
        Me.BttCriarUser.Location = New System.Drawing.Point(170, 358)
        Me.BttCriarUser.Name = "BttCriarUser"
        Me.BttCriarUser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttCriarUser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BttCriarUser.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BttCriarUser.selected = False
        Me.BttCriarUser.Size = New System.Drawing.Size(71, 34)
        Me.BttCriarUser.TabIndex = 27
        Me.BttCriarUser.Text = "Criar utilizador"
        Me.BttCriarUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BttCriarUser.Textcolor = System.Drawing.Color.Black
        Me.BttCriarUser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Registar_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 402)
        Me.Controls.Add(Me.BttSair)
        Me.Controls.Add(Me.BttCriarUser)
        Me.Controls.Add(Me.BunifuCheckbox5)
        Me.Controls.Add(Me.BunifuCheckbox4)
        Me.Controls.Add(Me.BunifuCheckbox3)
        Me.Controls.Add(Me.BunifuCheckbox2)
        Me.Controls.Add(Me.BunifuCheckbox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextMorada)
        Me.Controls.Add(Me.MaskText_telefone)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblNome)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Registar_form"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaskText_telefone As MaskedTextBox
    Friend WithEvents TextMorada As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCheckbox2 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCheckbox3 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCheckbox4 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCheckbox5 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BttSair As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BttCriarUser As Bunifu.Framework.UI.BunifuFlatButton
End Class
