<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vector))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PageTitle = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.insert_textbox = New System.Windows.Forms.TextBox()
        Me.remove_textbox = New System.Windows.Forms.TextBox()
        Me.update_textbox = New System.Windows.Forms.TextBox()
        Me.access_textbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Size_display = New System.Windows.Forms.TextBox()
        Me.access_display = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.new_num_txbx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Access_index = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Remove_elem = New System.Windows.Forms.Button()
        Me.Insert_elem = New System.Windows.Forms.Button()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -328)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(613, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1218, -328)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(530, 132)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(608, -328)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(613, 132)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox1.Location = New System.Drawing.Point(33, -169)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(122, 46)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "Vectors"
        '
        'PageTitle
        '
        Me.PageTitle.BackColor = System.Drawing.Color.White
        Me.PageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageTitle.Font = New System.Drawing.Font("Jokerman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageTitle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.PageTitle.Location = New System.Drawing.Point(33, -296)
        Me.PageTitle.Name = "PageTitle"
        Me.PageTitle.ReadOnly = True
        Me.PageTitle.Size = New System.Drawing.Size(285, 57)
        Me.PageTitle.TabIndex = 5
        Me.PageTitle.Text = " AlgorithmicAtlas"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(32, 236)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(1295, 109)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.White
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox3.Location = New System.Drawing.Point(32, 350)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox3.TabIndex = 7
        Me.RichTextBox3.Text = "Basic Vector Operations"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.White
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(32, 385)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(1295, 145)
        Me.RichTextBox4.TabIndex = 8
        Me.RichTextBox4.Text = resources.GetString("RichTextBox4.Text")
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.White
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox5.Location = New System.Drawing.Point(33, 832)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox5.TabIndex = 10
        Me.RichTextBox5.Text = "Ready to test yourself?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(64, 876)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 54)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Take Quiz"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vector (V):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insert element:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Delete index:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update index:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Access index (i):"
        '
        'insert_textbox
        '
        Me.insert_textbox.BackColor = System.Drawing.Color.White
        Me.insert_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.insert_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_textbox.Location = New System.Drawing.Point(198, 85)
        Me.insert_textbox.Multiline = True
        Me.insert_textbox.Name = "insert_textbox"
        Me.insert_textbox.Size = New System.Drawing.Size(123, 32)
        Me.insert_textbox.TabIndex = 5
        '
        'remove_textbox
        '
        Me.remove_textbox.BackColor = System.Drawing.Color.White
        Me.remove_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.remove_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove_textbox.Location = New System.Drawing.Point(198, 222)
        Me.remove_textbox.Multiline = True
        Me.remove_textbox.Name = "remove_textbox"
        Me.remove_textbox.Size = New System.Drawing.Size(123, 33)
        Me.remove_textbox.TabIndex = 6
        '
        'update_textbox
        '
        Me.update_textbox.BackColor = System.Drawing.Color.White
        Me.update_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_textbox.Location = New System.Drawing.Point(198, 173)
        Me.update_textbox.Multiline = True
        Me.update_textbox.Name = "update_textbox"
        Me.update_textbox.Size = New System.Drawing.Size(123, 33)
        Me.update_textbox.TabIndex = 7
        '
        'access_textbox
        '
        Me.access_textbox.BackColor = System.Drawing.Color.White
        Me.access_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.access_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.access_textbox.Location = New System.Drawing.Point(198, 129)
        Me.access_textbox.Multiline = True
        Me.access_textbox.Name = "access_textbox"
        Me.access_textbox.Size = New System.Drawing.Size(123, 32)
        Me.access_textbox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(857, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Size of V:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(857, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Output V[i]:"
        '
        'Size_display
        '
        Me.Size_display.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Size_display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Size_display.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_display.Location = New System.Drawing.Point(981, 82)
        Me.Size_display.Multiline = True
        Me.Size_display.Name = "Size_display"
        Me.Size_display.Size = New System.Drawing.Size(201, 32)
        Me.Size_display.TabIndex = 11
        '
        'access_display
        '
        Me.access_display.BackColor = System.Drawing.Color.PaleTurquoise
        Me.access_display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.access_display.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.access_display.Location = New System.Drawing.Point(981, 135)
        Me.access_display.Multiline = True
        Me.access_display.Name = "access_display"
        Me.access_display.Size = New System.Drawing.Size(201, 32)
        Me.access_display.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Plum
        Me.GroupBox1.Controls.Add(Me.new_num_txbx)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.reset)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Access_index)
        Me.GroupBox1.Controls.Add(Me.UpdateButton)
        Me.GroupBox1.Controls.Add(Me.Remove_elem)
        Me.GroupBox1.Controls.Add(Me.Insert_elem)
        Me.GroupBox1.Controls.Add(Me.access_display)
        Me.GroupBox1.Controls.Add(Me.Size_display)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.access_textbox)
        Me.GroupBox1.Controls.Add(Me.update_textbox)
        Me.GroupBox1.Controls.Add(Me.remove_textbox)
        Me.GroupBox1.Controls.Add(Me.insert_textbox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 536)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 276)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'new_num_txbx
        '
        Me.new_num_txbx.BackColor = System.Drawing.Color.White
        Me.new_num_txbx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.new_num_txbx.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_num_txbx.Location = New System.Drawing.Point(535, 174)
        Me.new_num_txbx.Multiline = True
        Me.new_num_txbx.Name = "new_num_txbx"
        Me.new_num_txbx.Size = New System.Drawing.Size(123, 33)
        Me.new_num_txbx.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(354, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "With new element:"
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.reset.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(950, 205)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(108, 49)
        Me.reset.TabIndex = 18
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(167, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1004, 57)
        Me.Panel1.TabIndex = 17
        '
        'Access_index
        '
        Me.Access_index.BackColor = System.Drawing.Color.DodgerBlue
        Me.Access_index.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Access_index.ForeColor = System.Drawing.Color.White
        Me.Access_index.Location = New System.Drawing.Point(358, 127)
        Me.Access_index.Name = "Access_index"
        Me.Access_index.Size = New System.Drawing.Size(62, 34)
        Me.Access_index.TabIndex = 16
        Me.Access_index.Text = "Go"
        Me.Access_index.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.UpdateButton.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(678, 174)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(62, 34)
        Me.UpdateButton.TabIndex = 15
        Me.UpdateButton.Text = "Go"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Remove_elem
        '
        Me.Remove_elem.BackColor = System.Drawing.Color.DodgerBlue
        Me.Remove_elem.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remove_elem.ForeColor = System.Drawing.Color.White
        Me.Remove_elem.Location = New System.Drawing.Point(358, 221)
        Me.Remove_elem.Name = "Remove_elem"
        Me.Remove_elem.Size = New System.Drawing.Size(62, 34)
        Me.Remove_elem.TabIndex = 14
        Me.Remove_elem.Text = "Go"
        Me.Remove_elem.UseVisualStyleBackColor = False
        '
        'Insert_elem
        '
        Me.Insert_elem.BackColor = System.Drawing.Color.DodgerBlue
        Me.Insert_elem.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_elem.ForeColor = System.Drawing.Color.White
        Me.Insert_elem.Location = New System.Drawing.Point(358, 85)
        Me.Insert_elem.Name = "Insert_elem"
        Me.Insert_elem.Size = New System.Drawing.Size(62, 34)
        Me.Insert_elem.TabIndex = 13
        Me.Insert_elem.Text = "Go"
        Me.Insert_elem.UseVisualStyleBackColor = False
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BackColor = System.Drawing.Color.White
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox6.Location = New System.Drawing.Point(32, 192)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ReadOnly = True
        Me.RichTextBox6.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox6.TabIndex = 13
        Me.RichTextBox6.Text = "Vectors"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1748, 161)
        Me.Panel2.TabIndex = 14
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BackColor = System.Drawing.Color.White
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox7.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox7.Location = New System.Drawing.Point(600, 832)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.ReadOnly = True
        Me.RichTextBox7.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox7.TabIndex = 15
        Me.RichTextBox7.Text = "Try another module!"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(610, 876)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 54)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Vector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.PageTitle)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Vector"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PageTitle As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents insert_textbox As System.Windows.Forms.TextBox
    Friend WithEvents remove_textbox As System.Windows.Forms.TextBox
    Friend WithEvents update_textbox As System.Windows.Forms.TextBox
    Friend WithEvents access_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Size_display As System.Windows.Forms.TextBox
    Friend WithEvents access_display As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents Access_index As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents Remove_elem As System.Windows.Forms.Button
    Friend WithEvents Insert_elem As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents new_num_txbx As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
