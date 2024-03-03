<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class queue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(queue))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.error_label = New System.Windows.Forms.Label()
        Me.QueueBox10 = New System.Windows.Forms.Label()
        Me.QueueBox8 = New System.Windows.Forms.Label()
        Me.QueueBox9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.QueueBox7 = New System.Windows.Forms.Label()
        Me.QueueBox5 = New System.Windows.Forms.Label()
        Me.QueueBox2 = New System.Windows.Forms.Label()
        Me.QueueBox4 = New System.Windows.Forms.Label()
        Me.QueueBox3 = New System.Windows.Forms.Label()
        Me.QueueBox6 = New System.Windows.Forms.Label()
        Me.QueueBox1 = New System.Windows.Forms.Label()
        Me.dequeue_btn = New System.Windows.Forms.Button()
        Me.enqueue_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1228, 161)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1228, 463)
        Me.Panel2.TabIndex = 14
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1228, 463)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.RichTextBox7)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.RichTextBox5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1220, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Queue"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(46, 664)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 54)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Take Quiz"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.White
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox5.Location = New System.Drawing.Point(46, 606)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox5.TabIndex = 12
        Me.RichTextBox5.Text = "Ready to test yourself?"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1115, 782)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Queue :"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.AutoScrollMinSize = New System.Drawing.Size(0, 700)
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.error_label)
        Me.TabPage2.Controls.Add(Me.QueueBox10)
        Me.TabPage2.Controls.Add(Me.QueueBox8)
        Me.TabPage2.Controls.Add(Me.QueueBox9)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.QueueBox7)
        Me.TabPage2.Controls.Add(Me.QueueBox5)
        Me.TabPage2.Controls.Add(Me.QueueBox2)
        Me.TabPage2.Controls.Add(Me.QueueBox4)
        Me.TabPage2.Controls.Add(Me.QueueBox3)
        Me.TabPage2.Controls.Add(Me.QueueBox6)
        Me.TabPage2.Controls.Add(Me.QueueBox1)
        Me.TabPage2.Controls.Add(Me.dequeue_btn)
        Me.TabPage2.Controls.Add(Me.enqueue_btn)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1220, 425)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Play with Queue"
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(372, 126)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(92, 29)
        Me.error_label.TabIndex = 34
        Me.error_label.Text = "Label3"
        '
        'QueueBox10
        '
        Me.QueueBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox10.Location = New System.Drawing.Point(1302, 221)
        Me.QueueBox10.Name = "QueueBox10"
        Me.QueueBox10.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox10.TabIndex = 30
        Me.QueueBox10.Text = "box10"
        Me.QueueBox10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox8
        '
        Me.QueueBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox8.Location = New System.Drawing.Point(1022, 221)
        Me.QueueBox8.Name = "QueueBox8"
        Me.QueueBox8.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox8.TabIndex = 29
        Me.QueueBox8.Text = "box8"
        Me.QueueBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox9
        '
        Me.QueueBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox9.Location = New System.Drawing.Point(1162, 221)
        Me.QueueBox9.Name = "QueueBox9"
        Me.QueueBox9.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox9.TabIndex = 28
        Me.QueueBox9.Text = "box9"
        Me.QueueBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(54, 437)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 36)
        Me.TextBox1.TabIndex = 20
        '
        'QueueBox7
        '
        Me.QueueBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox7.Location = New System.Drawing.Point(882, 221)
        Me.QueueBox7.Name = "QueueBox7"
        Me.QueueBox7.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox7.TabIndex = 19
        Me.QueueBox7.Text = "box7"
        Me.QueueBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox5
        '
        Me.QueueBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox5.Location = New System.Drawing.Point(602, 221)
        Me.QueueBox5.Name = "QueueBox5"
        Me.QueueBox5.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox5.TabIndex = 18
        Me.QueueBox5.Text = "box5"
        Me.QueueBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox2
        '
        Me.QueueBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox2.Location = New System.Drawing.Point(182, 221)
        Me.QueueBox2.Name = "QueueBox2"
        Me.QueueBox2.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox2.TabIndex = 17
        Me.QueueBox2.Text = "box2"
        Me.QueueBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox4
        '
        Me.QueueBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox4.Location = New System.Drawing.Point(462, 221)
        Me.QueueBox4.Name = "QueueBox4"
        Me.QueueBox4.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox4.TabIndex = 16
        Me.QueueBox4.Text = "box4"
        Me.QueueBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox3
        '
        Me.QueueBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox3.Location = New System.Drawing.Point(322, 221)
        Me.QueueBox3.Name = "QueueBox3"
        Me.QueueBox3.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox3.TabIndex = 15
        Me.QueueBox3.Text = "box3"
        Me.QueueBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox6
        '
        Me.QueueBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox6.Location = New System.Drawing.Point(742, 221)
        Me.QueueBox6.Name = "QueueBox6"
        Me.QueueBox6.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox6.TabIndex = 14
        Me.QueueBox6.Text = "box6"
        Me.QueueBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QueueBox1
        '
        Me.QueueBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueueBox1.Location = New System.Drawing.Point(42, 221)
        Me.QueueBox1.Name = "QueueBox1"
        Me.QueueBox1.Size = New System.Drawing.Size(133, 56)
        Me.QueueBox1.TabIndex = 13
        Me.QueueBox1.Text = "box1"
        Me.QueueBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dequeue_btn
        '
        Me.dequeue_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dequeue_btn.Location = New System.Drawing.Point(661, 421)
        Me.dequeue_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dequeue_btn.Name = "dequeue_btn"
        Me.dequeue_btn.Size = New System.Drawing.Size(214, 82)
        Me.dequeue_btn.TabIndex = 12
        Me.dequeue_btn.Text = "Dequeue"
        Me.dequeue_btn.UseVisualStyleBackColor = True
        '
        'enqueue_btn
        '
        Me.enqueue_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enqueue_btn.Location = New System.Drawing.Point(291, 421)
        Me.enqueue_btn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.enqueue_btn.Name = "enqueue_btn"
        Me.enqueue_btn.Size = New System.Drawing.Size(214, 82)
        Me.enqueue_btn.TabIndex = 11
        Me.enqueue_btn.Text = "Enqueue"
        Me.enqueue_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(859, 39)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Try enqueue and dequeue to Queue (Max Size = 10)"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BackColor = System.Drawing.Color.White
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox7.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox7.Location = New System.Drawing.Point(482, 606)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.ReadOnly = True
        Me.RichTextBox7.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox7.TabIndex = 17
        Me.RichTextBox7.Text = "Try another module!"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(516, 664)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 54)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 624)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "queue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "queue"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents error_label As System.Windows.Forms.Label
    Friend WithEvents QueueBox10 As System.Windows.Forms.Label
    Friend WithEvents QueueBox8 As System.Windows.Forms.Label
    Friend WithEvents QueueBox9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents QueueBox7 As System.Windows.Forms.Label
    Friend WithEvents QueueBox5 As System.Windows.Forms.Label
    Friend WithEvents QueueBox2 As System.Windows.Forms.Label
    Friend WithEvents QueueBox4 As System.Windows.Forms.Label
    Friend WithEvents QueueBox3 As System.Windows.Forms.Label
    Friend WithEvents QueueBox6 As System.Windows.Forms.Label
    Friend WithEvents QueueBox1 As System.Windows.Forms.Label
    Friend WithEvents dequeue_btn As System.Windows.Forms.Button
    Friend WithEvents enqueue_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
