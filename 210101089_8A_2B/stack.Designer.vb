<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stack))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.quiz_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.top_el = New System.Windows.Forms.Label()
        Me.Top_btn = New System.Windows.Forms.Button()
        Me.error_label = New System.Windows.Forms.Label()
        Me.top10 = New System.Windows.Forms.Label()
        Me.top8 = New System.Windows.Forms.Label()
        Me.top9 = New System.Windows.Forms.Label()
        Me.StackBox10 = New System.Windows.Forms.Label()
        Me.StackBox8 = New System.Windows.Forms.Label()
        Me.StackBox9 = New System.Windows.Forms.Label()
        Me.top7 = New System.Windows.Forms.Label()
        Me.top5 = New System.Windows.Forms.Label()
        Me.top2 = New System.Windows.Forms.Label()
        Me.top4 = New System.Windows.Forms.Label()
        Me.top3 = New System.Windows.Forms.Label()
        Me.top6 = New System.Windows.Forms.Label()
        Me.top1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StackBox7 = New System.Windows.Forms.Label()
        Me.StackBox5 = New System.Windows.Forms.Label()
        Me.StackBox2 = New System.Windows.Forms.Label()
        Me.StackBox4 = New System.Windows.Forms.Label()
        Me.StackBox3 = New System.Windows.Forms.Label()
        Me.StackBox6 = New System.Windows.Forms.Label()
        Me.StackBox1 = New System.Windows.Forms.Label()
        Me.StackPop = New System.Windows.Forms.Button()
        Me.StackPush = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 161)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1240, 475)
        Me.Panel2.TabIndex = 14
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1240, 475)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.AutoScrollMinSize = New System.Drawing.Size(0, 700)
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.quiz_btn)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(1232, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Stack"
        '
        'quiz_btn
        '
        Me.quiz_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz_btn.Location = New System.Drawing.Point(902, 522)
        Me.quiz_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.quiz_btn.Name = "quiz_btn"
        Me.quiz_btn.Size = New System.Drawing.Size(233, 72)
        Me.quiz_btn.TabIndex = 3
        Me.quiz_btn.Text = "Start Quiz"
        Me.quiz_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1137, 582)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stack :"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.AutoScrollMinSize = New System.Drawing.Size(0, 800)
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.top_el)
        Me.TabPage2.Controls.Add(Me.Top_btn)
        Me.TabPage2.Controls.Add(Me.error_label)
        Me.TabPage2.Controls.Add(Me.top10)
        Me.TabPage2.Controls.Add(Me.top8)
        Me.TabPage2.Controls.Add(Me.top9)
        Me.TabPage2.Controls.Add(Me.StackBox10)
        Me.TabPage2.Controls.Add(Me.StackBox8)
        Me.TabPage2.Controls.Add(Me.StackBox9)
        Me.TabPage2.Controls.Add(Me.top7)
        Me.TabPage2.Controls.Add(Me.top5)
        Me.TabPage2.Controls.Add(Me.top2)
        Me.TabPage2.Controls.Add(Me.top4)
        Me.TabPage2.Controls.Add(Me.top3)
        Me.TabPage2.Controls.Add(Me.top6)
        Me.TabPage2.Controls.Add(Me.top1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.StackBox7)
        Me.TabPage2.Controls.Add(Me.StackBox5)
        Me.TabPage2.Controls.Add(Me.StackBox2)
        Me.TabPage2.Controls.Add(Me.StackBox4)
        Me.TabPage2.Controls.Add(Me.StackBox3)
        Me.TabPage2.Controls.Add(Me.StackBox6)
        Me.TabPage2.Controls.Add(Me.StackBox1)
        Me.TabPage2.Controls.Add(Me.StackPop)
        Me.TabPage2.Controls.Add(Me.StackPush)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage2.Size = New System.Drawing.Size(1232, 440)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Play with Stack"
        '
        'top_el
        '
        Me.top_el.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top_el.Location = New System.Drawing.Point(729, 633)
        Me.top_el.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top_el.Name = "top_el"
        Me.top_el.Size = New System.Drawing.Size(279, 78)
        Me.top_el.TabIndex = 36
        Me.top_el.Text = "Label3"
        Me.top_el.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Top_btn
        '
        Me.Top_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top_btn.Location = New System.Drawing.Point(783, 531)
        Me.Top_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Top_btn.Name = "Top_btn"
        Me.Top_btn.Size = New System.Drawing.Size(169, 78)
        Me.Top_btn.TabIndex = 35
        Me.Top_btn.Text = "Top"
        Me.Top_btn.UseVisualStyleBackColor = True
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(203, 110)
        Me.error_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(92, 29)
        Me.error_label.TabIndex = 34
        Me.error_label.Text = "Label3"
        '
        'top10
        '
        Me.top10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top10.Location = New System.Drawing.Point(344, 176)
        Me.top10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top10.Name = "top10"
        Me.top10.Size = New System.Drawing.Size(183, 54)
        Me.top10.TabIndex = 33
        Me.top10.Text = "← Top"
        Me.top10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top8
        '
        Me.top8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top8.Location = New System.Drawing.Point(344, 284)
        Me.top8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top8.Name = "top8"
        Me.top8.Size = New System.Drawing.Size(183, 54)
        Me.top8.TabIndex = 32
        Me.top8.Text = "← Top"
        Me.top8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top9
        '
        Me.top9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top9.Location = New System.Drawing.Point(344, 230)
        Me.top9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top9.Name = "top9"
        Me.top9.Size = New System.Drawing.Size(183, 54)
        Me.top9.TabIndex = 31
        Me.top9.Text = "← Top"
        Me.top9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox10
        '
        Me.StackBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox10.Location = New System.Drawing.Point(191, 176)
        Me.StackBox10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox10.Name = "StackBox10"
        Me.StackBox10.Size = New System.Drawing.Size(138, 54)
        Me.StackBox10.TabIndex = 30
        Me.StackBox10.Text = "box10"
        Me.StackBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox8
        '
        Me.StackBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox8.Location = New System.Drawing.Point(191, 286)
        Me.StackBox8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox8.Name = "StackBox8"
        Me.StackBox8.Size = New System.Drawing.Size(138, 54)
        Me.StackBox8.TabIndex = 29
        Me.StackBox8.Text = "box8"
        Me.StackBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox9
        '
        Me.StackBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox9.Location = New System.Drawing.Point(191, 231)
        Me.StackBox9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox9.Name = "StackBox9"
        Me.StackBox9.Size = New System.Drawing.Size(138, 54)
        Me.StackBox9.TabIndex = 28
        Me.StackBox9.Text = "box9"
        Me.StackBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top7
        '
        Me.top7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top7.Location = New System.Drawing.Point(344, 339)
        Me.top7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top7.Name = "top7"
        Me.top7.Size = New System.Drawing.Size(183, 54)
        Me.top7.TabIndex = 27
        Me.top7.Text = "← Top"
        Me.top7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top5
        '
        Me.top5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top5.Location = New System.Drawing.Point(344, 451)
        Me.top5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top5.Name = "top5"
        Me.top5.Size = New System.Drawing.Size(183, 54)
        Me.top5.TabIndex = 26
        Me.top5.Text = "← Top"
        Me.top5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top2
        '
        Me.top2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top2.Location = New System.Drawing.Point(344, 618)
        Me.top2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top2.Name = "top2"
        Me.top2.Size = New System.Drawing.Size(183, 54)
        Me.top2.TabIndex = 25
        Me.top2.Text = "← Top"
        Me.top2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top4
        '
        Me.top4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top4.Location = New System.Drawing.Point(344, 505)
        Me.top4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top4.Name = "top4"
        Me.top4.Size = New System.Drawing.Size(183, 54)
        Me.top4.TabIndex = 24
        Me.top4.Text = "← Top"
        Me.top4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top3
        '
        Me.top3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top3.Location = New System.Drawing.Point(344, 564)
        Me.top3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top3.Name = "top3"
        Me.top3.Size = New System.Drawing.Size(183, 54)
        Me.top3.TabIndex = 23
        Me.top3.Text = "← Top"
        Me.top3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top6
        '
        Me.top6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top6.Location = New System.Drawing.Point(344, 397)
        Me.top6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top6.Name = "top6"
        Me.top6.Size = New System.Drawing.Size(183, 54)
        Me.top6.TabIndex = 22
        Me.top6.Text = "← Top"
        Me.top6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top1
        '
        Me.top1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.top1.Location = New System.Drawing.Point(344, 673)
        Me.top1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.top1.Name = "top1"
        Me.top1.Size = New System.Drawing.Size(183, 54)
        Me.top1.TabIndex = 21
        Me.top1.Text = "← Top"
        Me.top1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(783, 216)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 36)
        Me.TextBox1.TabIndex = 20
        '
        'StackBox7
        '
        Me.StackBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox7.Location = New System.Drawing.Point(191, 341)
        Me.StackBox7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox7.Name = "StackBox7"
        Me.StackBox7.Size = New System.Drawing.Size(138, 54)
        Me.StackBox7.TabIndex = 19
        Me.StackBox7.Text = "box7"
        Me.StackBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox5
        '
        Me.StackBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox5.Location = New System.Drawing.Point(191, 452)
        Me.StackBox5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox5.Name = "StackBox5"
        Me.StackBox5.Size = New System.Drawing.Size(138, 54)
        Me.StackBox5.TabIndex = 18
        Me.StackBox5.Text = "box5"
        Me.StackBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox2
        '
        Me.StackBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox2.Location = New System.Drawing.Point(191, 617)
        Me.StackBox2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox2.Name = "StackBox2"
        Me.StackBox2.Size = New System.Drawing.Size(138, 54)
        Me.StackBox2.TabIndex = 17
        Me.StackBox2.Text = "box2"
        Me.StackBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox4
        '
        Me.StackBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox4.Location = New System.Drawing.Point(191, 507)
        Me.StackBox4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox4.Name = "StackBox4"
        Me.StackBox4.Size = New System.Drawing.Size(138, 54)
        Me.StackBox4.TabIndex = 16
        Me.StackBox4.Text = "box4"
        Me.StackBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox3
        '
        Me.StackBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox3.Location = New System.Drawing.Point(191, 562)
        Me.StackBox3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox3.Name = "StackBox3"
        Me.StackBox3.Size = New System.Drawing.Size(138, 54)
        Me.StackBox3.TabIndex = 15
        Me.StackBox3.Text = "box3"
        Me.StackBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox6
        '
        Me.StackBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox6.Location = New System.Drawing.Point(191, 397)
        Me.StackBox6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox6.Name = "StackBox6"
        Me.StackBox6.Size = New System.Drawing.Size(138, 54)
        Me.StackBox6.TabIndex = 14
        Me.StackBox6.Text = "box6"
        Me.StackBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackBox1
        '
        Me.StackBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackBox1.Location = New System.Drawing.Point(191, 673)
        Me.StackBox1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StackBox1.Name = "StackBox1"
        Me.StackBox1.Size = New System.Drawing.Size(138, 54)
        Me.StackBox1.TabIndex = 13
        Me.StackBox1.Text = "box1"
        Me.StackBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StackPop
        '
        Me.StackPop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackPop.Location = New System.Drawing.Point(783, 410)
        Me.StackPop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StackPop.Name = "StackPop"
        Me.StackPop.Size = New System.Drawing.Size(169, 78)
        Me.StackPop.TabIndex = 12
        Me.StackPop.Text = "Pop"
        Me.StackPop.UseVisualStyleBackColor = True
        '
        'StackPush
        '
        Me.StackPush.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StackPush.Location = New System.Drawing.Point(783, 302)
        Me.StackPush.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.StackPush.Name = "StackPush"
        Me.StackPush.Size = New System.Drawing.Size(169, 78)
        Me.StackPush.TabIndex = 11
        Me.StackPush.Text = "Push"
        Me.StackPush.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(802, 39)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Try pushing and Poping to Stack (Max Size = 10)"
        '
        'stack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1240, 636)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "stack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stack"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents quiz_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents top_el As System.Windows.Forms.Label
    Friend WithEvents Top_btn As System.Windows.Forms.Button
    Friend WithEvents error_label As System.Windows.Forms.Label
    Friend WithEvents top10 As System.Windows.Forms.Label
    Friend WithEvents top8 As System.Windows.Forms.Label
    Friend WithEvents top9 As System.Windows.Forms.Label
    Friend WithEvents StackBox10 As System.Windows.Forms.Label
    Friend WithEvents StackBox8 As System.Windows.Forms.Label
    Friend WithEvents StackBox9 As System.Windows.Forms.Label
    Friend WithEvents top7 As System.Windows.Forms.Label
    Friend WithEvents top5 As System.Windows.Forms.Label
    Friend WithEvents top2 As System.Windows.Forms.Label
    Friend WithEvents top4 As System.Windows.Forms.Label
    Friend WithEvents top3 As System.Windows.Forms.Label
    Friend WithEvents top6 As System.Windows.Forms.Label
    Friend WithEvents top1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StackBox7 As System.Windows.Forms.Label
    Friend WithEvents StackBox5 As System.Windows.Forms.Label
    Friend WithEvents StackBox2 As System.Windows.Forms.Label
    Friend WithEvents StackBox4 As System.Windows.Forms.Label
    Friend WithEvents StackBox3 As System.Windows.Forms.Label
    Friend WithEvents StackBox6 As System.Windows.Forms.Label
    Friend WithEvents StackBox1 As System.Windows.Forms.Label
    Friend WithEvents StackPop As System.Windows.Forms.Button
    Friend WithEvents StackPush As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
