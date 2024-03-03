<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Array
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Array))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.quiz_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.new_num_txbx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Reset_btn = New System.Windows.Forms.Button()
        Me.show_panel = New System.Windows.Forms.Panel()
        Me.Access_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Sum_btn = New System.Windows.Forms.Button()
        Me.Insert_btn = New System.Windows.Forms.Button()
        Me.access_display = New System.Windows.Forms.TextBox()
        Me.Size_display = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.access_textbox = New System.Windows.Forms.TextBox()
        Me.update_textbox = New System.Windows.Forms.TextBox()
        Me.sum_textbox = New System.Windows.Forms.TextBox()
        Me.insert_textbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.quiz_btn)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 939)
        Me.Panel1.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(620, 842)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 62)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label14.Location = New System.Drawing.Point(600, 795)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(223, 27)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Try another Module!"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label13.Location = New System.Drawing.Point(42, 795)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(245, 27)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Ready to test yourself?"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(42, 291)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1121, 139)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "We will look at some commonly used array operations in this tutorial:" & Global.Microsoft.VisualBasic.ChrW(10) & "1) Insert e" & _
            "lements" & Global.Microsoft.VisualBasic.ChrW(10) & "2) Access elements" & Global.Microsoft.VisualBasic.ChrW(10) & "3) Update elements" & Global.Microsoft.VisualBasic.ChrW(10) & "4) Delete elements"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label11.Location = New System.Drawing.Point(42, 258)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 27)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Basic Vector Operations"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(41, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1121, 135)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label9.Location = New System.Drawing.Point(39, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 37)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Arrays"
        '
        'quiz_btn
        '
        Me.quiz_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.quiz_btn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz_btn.ForeColor = System.Drawing.Color.White
        Me.quiz_btn.Location = New System.Drawing.Point(50, 842)
        Me.quiz_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.quiz_btn.Name = "quiz_btn"
        Me.quiz_btn.Size = New System.Drawing.Size(200, 62)
        Me.quiz_btn.TabIndex = 30
        Me.quiz_btn.Text = "Take Quiz"
        Me.quiz_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Plum
        Me.GroupBox1.Controls.Add(Me.new_num_txbx)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Reset_btn)
        Me.GroupBox1.Controls.Add(Me.show_panel)
        Me.GroupBox1.Controls.Add(Me.Access_btn)
        Me.GroupBox1.Controls.Add(Me.Update_btn)
        Me.GroupBox1.Controls.Add(Me.Sum_btn)
        Me.GroupBox1.Controls.Add(Me.Insert_btn)
        Me.GroupBox1.Controls.Add(Me.access_display)
        Me.GroupBox1.Controls.Add(Me.Size_display)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.access_textbox)
        Me.GroupBox1.Controls.Add(Me.update_textbox)
        Me.GroupBox1.Controls.Add(Me.sum_textbox)
        Me.GroupBox1.Controls.Add(Me.insert_textbox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 434)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1116, 330)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'new_num_txbx
        '
        Me.new_num_txbx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.new_num_txbx.BackColor = System.Drawing.Color.White
        Me.new_num_txbx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.new_num_txbx.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_num_txbx.Location = New System.Drawing.Point(526, 209)
        Me.new_num_txbx.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.new_num_txbx.Multiline = True
        Me.new_num_txbx.Name = "new_num_txbx"
        Me.new_num_txbx.Size = New System.Drawing.Size(108, 38)
        Me.new_num_txbx.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(302, 212)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "With new element:"
        '
        'Reset_btn
        '
        Me.Reset_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Reset_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Reset_btn.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_btn.ForeColor = System.Drawing.Color.White
        Me.Reset_btn.Location = New System.Drawing.Point(955, 243)
        Me.Reset_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Reset_btn.Name = "Reset_btn"
        Me.Reset_btn.Size = New System.Drawing.Size(132, 56)
        Me.Reset_btn.TabIndex = 18
        Me.Reset_btn.Text = "Reset"
        Me.Reset_btn.UseVisualStyleBackColor = False
        '
        'show_panel
        '
        Me.show_panel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.show_panel.Location = New System.Drawing.Point(178, 28)
        Me.show_panel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.show_panel.Name = "show_panel"
        Me.show_panel.Size = New System.Drawing.Size(923, 66)
        Me.show_panel.TabIndex = 17
        '
        'Access_btn
        '
        Me.Access_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Access_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Access_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Access_btn.ForeColor = System.Drawing.Color.White
        Me.Access_btn.Location = New System.Drawing.Point(412, 152)
        Me.Access_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Access_btn.Name = "Access_btn"
        Me.Access_btn.Size = New System.Drawing.Size(76, 37)
        Me.Access_btn.TabIndex = 16
        Me.Access_btn.Text = "Go"
        Me.Access_btn.UseVisualStyleBackColor = False
        '
        'Update_btn
        '
        Me.Update_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Update_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Update_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.ForeColor = System.Drawing.Color.White
        Me.Update_btn.Location = New System.Drawing.Point(656, 209)
        Me.Update_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(76, 37)
        Me.Update_btn.TabIndex = 15
        Me.Update_btn.Text = "Go"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'Sum_btn
        '
        Me.Sum_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sum_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Sum_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_btn.ForeColor = System.Drawing.Color.White
        Me.Sum_btn.Location = New System.Drawing.Point(412, 260)
        Me.Sum_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Sum_btn.Name = "Sum_btn"
        Me.Sum_btn.Size = New System.Drawing.Size(76, 37)
        Me.Sum_btn.TabIndex = 14
        Me.Sum_btn.Text = "Go"
        Me.Sum_btn.UseVisualStyleBackColor = False
        '
        'Insert_btn
        '
        Me.Insert_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Insert_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Insert_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_btn.ForeColor = System.Drawing.Color.White
        Me.Insert_btn.Location = New System.Drawing.Point(412, 103)
        Me.Insert_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Insert_btn.Name = "Insert_btn"
        Me.Insert_btn.Size = New System.Drawing.Size(76, 37)
        Me.Insert_btn.TabIndex = 13
        Me.Insert_btn.Text = "Go"
        Me.Insert_btn.UseVisualStyleBackColor = False
        '
        'access_display
        '
        Me.access_display.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.access_display.BackColor = System.Drawing.Color.PaleTurquoise
        Me.access_display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.access_display.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.access_display.Location = New System.Drawing.Point(935, 166)
        Me.access_display.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.access_display.Multiline = True
        Me.access_display.Name = "access_display"
        Me.access_display.Size = New System.Drawing.Size(150, 37)
        Me.access_display.TabIndex = 12
        '
        'Size_display
        '
        Me.Size_display.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Size_display.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Size_display.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Size_display.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Size_display.Location = New System.Drawing.Point(935, 109)
        Me.Size_display.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Size_display.Multiline = True
        Me.Size_display.Name = "Size_display"
        Me.Size_display.Size = New System.Drawing.Size(150, 37)
        Me.Size_display.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(784, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Output A[i]:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(817, 116)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Size of A:"
        '
        'access_textbox
        '
        Me.access_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.access_textbox.BackColor = System.Drawing.Color.White
        Me.access_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.access_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.access_textbox.Location = New System.Drawing.Point(216, 154)
        Me.access_textbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.access_textbox.Multiline = True
        Me.access_textbox.Name = "access_textbox"
        Me.access_textbox.Size = New System.Drawing.Size(150, 37)
        Me.access_textbox.TabIndex = 8
        '
        'update_textbox
        '
        Me.update_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.update_textbox.BackColor = System.Drawing.Color.White
        Me.update_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_textbox.Location = New System.Drawing.Point(216, 205)
        Me.update_textbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.update_textbox.Multiline = True
        Me.update_textbox.Name = "update_textbox"
        Me.update_textbox.Size = New System.Drawing.Size(68, 38)
        Me.update_textbox.TabIndex = 7
        '
        'sum_textbox
        '
        Me.sum_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sum_textbox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.sum_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sum_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum_textbox.Location = New System.Drawing.Point(216, 261)
        Me.sum_textbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.sum_textbox.Multiline = True
        Me.sum_textbox.Name = "sum_textbox"
        Me.sum_textbox.ReadOnly = True
        Me.sum_textbox.Size = New System.Drawing.Size(150, 38)
        Me.sum_textbox.TabIndex = 6
        '
        'insert_textbox
        '
        Me.insert_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insert_textbox.BackColor = System.Drawing.Color.White
        Me.insert_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.insert_textbox.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_textbox.Location = New System.Drawing.Point(216, 103)
        Me.insert_textbox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.insert_textbox.Multiline = True
        Me.insert_textbox.Name = "insert_textbox"
        Me.insert_textbox.Size = New System.Drawing.Size(150, 37)
        Me.insert_textbox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Access index (i):"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Update index:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 269)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sum of elements:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Insert element:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Array (A):"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1207, 161)
        Me.Panel2.TabIndex = 1
        '
        'Array
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 1100)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Array"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Array"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents quiz_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents new_num_txbx As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Reset_btn As System.Windows.Forms.Button
    Friend WithEvents show_panel As System.Windows.Forms.Panel
    Friend WithEvents Access_btn As System.Windows.Forms.Button
    Friend WithEvents Update_btn As System.Windows.Forms.Button
    Friend WithEvents Sum_btn As System.Windows.Forms.Button
    Friend WithEvents Insert_btn As System.Windows.Forms.Button
    Friend WithEvents access_display As System.Windows.Forms.TextBox
    Friend WithEvents Size_display As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents access_textbox As System.Windows.Forms.TextBox
    Friend WithEvents update_textbox As System.Windows.Forms.TextBox
    Friend WithEvents sum_textbox As System.Windows.Forms.TextBox
    Friend WithEvents insert_textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
