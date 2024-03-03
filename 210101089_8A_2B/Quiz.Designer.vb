<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quiz))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.subheading_label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.que_gb = New System.Windows.Forms.GroupBox()
        Me.option4_rb = New System.Windows.Forms.RadioButton()
        Me.option3_rb = New System.Windows.Forms.RadioButton()
        Me.option2_rb = New System.Windows.Forms.RadioButton()
        Me.option1_rb = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.que_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.proceed_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.que_gb.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.subheading_label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 618)
        Me.Panel1.TabIndex = 0
        '
        'subheading_label
        '
        Me.subheading_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subheading_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.subheading_label.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subheading_label.Location = New System.Drawing.Point(85, 278)
        Me.subheading_label.Name = "subheading_label"
        Me.subheading_label.Padding = New System.Windows.Forms.Padding(3)
        Me.subheading_label.Size = New System.Drawing.Size(226, 61)
        Me.subheading_label.TabIndex = 1
        Me.subheading_label.Text = "Its Quiz Time!"
        Me.subheading_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.que_gb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.proceed_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(392, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(653, 618)
        Me.Panel2.TabIndex = 1
        '
        'que_gb
        '
        Me.que_gb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.que_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.que_gb.Controls.Add(Me.option4_rb)
        Me.que_gb.Controls.Add(Me.option3_rb)
        Me.que_gb.Controls.Add(Me.option2_rb)
        Me.que_gb.Controls.Add(Me.option1_rb)
        Me.que_gb.Controls.Add(Me.Panel3)
        Me.que_gb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.que_gb.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.que_gb.Location = New System.Drawing.Point(13, 94)
        Me.que_gb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.que_gb.Name = "que_gb"
        Me.que_gb.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.que_gb.Size = New System.Drawing.Size(627, 442)
        Me.que_gb.TabIndex = 6
        Me.que_gb.TabStop = False
        '
        'option4_rb
        '
        Me.option4_rb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.option4_rb.AutoSize = True
        Me.option4_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.option4_rb.Enabled = False
        Me.option4_rb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.option4_rb.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option4_rb.Location = New System.Drawing.Point(64, 363)
        Me.option4_rb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.option4_rb.MaximumSize = New System.Drawing.Size(500, 80)
        Me.option4_rb.MinimumSize = New System.Drawing.Size(500, 50)
        Me.option4_rb.Name = "option4_rb"
        Me.option4_rb.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.option4_rb.Size = New System.Drawing.Size(500, 50)
        Me.option4_rb.TabIndex = 4
        Me.option4_rb.TabStop = True
        Me.option4_rb.Tag = "4"
        Me.option4_rb.Text = "Click the 'Submit' button when you have answered all the questions to see your sc" & _
            "ore."
        Me.option4_rb.UseVisualStyleBackColor = False
        '
        'option3_rb
        '
        Me.option3_rb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.option3_rb.AutoSize = True
        Me.option3_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.option3_rb.Enabled = False
        Me.option3_rb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.option3_rb.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option3_rb.Location = New System.Drawing.Point(64, 300)
        Me.option3_rb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.option3_rb.MaximumSize = New System.Drawing.Size(500, 80)
        Me.option3_rb.MinimumSize = New System.Drawing.Size(500, 50)
        Me.option3_rb.Name = "option3_rb"
        Me.option3_rb.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.option3_rb.Size = New System.Drawing.Size(500, 50)
        Me.option3_rb.TabIndex = 3
        Me.option3_rb.TabStop = True
        Me.option3_rb.Tag = "3"
        Me.option3_rb.Text = "Once you have selected an option, you can move to the next question by clicking t" & _
            "he 'Next' button."
        Me.option3_rb.UseVisualStyleBackColor = False
        '
        'option2_rb
        '
        Me.option2_rb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.option2_rb.AutoSize = True
        Me.option2_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.option2_rb.Enabled = False
        Me.option2_rb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.option2_rb.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option2_rb.Location = New System.Drawing.Point(64, 237)
        Me.option2_rb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.option2_rb.MaximumSize = New System.Drawing.Size(500, 80)
        Me.option2_rb.MinimumSize = New System.Drawing.Size(500, 50)
        Me.option2_rb.Name = "option2_rb"
        Me.option2_rb.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.option2_rb.Size = New System.Drawing.Size(500, 50)
        Me.option2_rb.TabIndex = 2
        Me.option2_rb.TabStop = True
        Me.option2_rb.Tag = "2"
        Me.option2_rb.Text = "Choose the correct option for each question by clicking on the corresponding radi" & _
            "o button."
        Me.option2_rb.UseVisualStyleBackColor = False
        '
        'option1_rb
        '
        Me.option1_rb.AutoSize = True
        Me.option1_rb.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.option1_rb.Enabled = False
        Me.option1_rb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.option1_rb.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.option1_rb.Location = New System.Drawing.Point(64, 176)
        Me.option1_rb.MaximumSize = New System.Drawing.Size(500, 80)
        Me.option1_rb.MinimumSize = New System.Drawing.Size(500, 50)
        Me.option1_rb.Name = "option1_rb"
        Me.option1_rb.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.option1_rb.Size = New System.Drawing.Size(500, 50)
        Me.option1_rb.TabIndex = 1
        Me.option1_rb.TabStop = True
        Me.option1_rb.Tag = "1"
        Me.option1_rb.Text = "There are 10 questions in this quiz." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Each question has four options."
        Me.option1_rb.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel3.Controls.Add(Me.que_label)
        Me.Panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel3.Location = New System.Drawing.Point(37, 29)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(550, 122)
        Me.Panel3.TabIndex = 0
        '
        'que_label
        '
        Me.que_label.AutoSize = True
        Me.que_label.Location = New System.Drawing.Point(12, 9)
        Me.que_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.que_label.MaximumSize = New System.Drawing.Size(500, 800)
        Me.que_label.MinimumSize = New System.Drawing.Size(500, 100)
        Me.que_label.Name = "que_label"
        Me.que_label.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.que_label.Size = New System.Drawing.Size(500, 100)
        Me.que_label.TabIndex = 0
        Me.que_label.Text = "Welcome to the Multiple Choice Quiz!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please read the following instructions:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(3)
        Me.Label1.Size = New System.Drawing.Size(653, 78)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "AlgorithmicAtlas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'proceed_btn
        '
        Me.proceed_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.proceed_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.proceed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.proceed_btn.ForeColor = System.Drawing.Color.White
        Me.proceed_btn.Location = New System.Drawing.Point(413, 563)
        Me.proceed_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.proceed_btn.Name = "proceed_btn"
        Me.proceed_btn.Size = New System.Drawing.Size(227, 37)
        Me.proceed_btn.TabIndex = 5
        Me.proceed_btn.Text = "Start Quiz"
        Me.proceed_btn.UseVisualStyleBackColor = False
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 618)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Quiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.que_gb.ResumeLayout(False)
        Me.que_gb.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents subheading_label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents que_gb As System.Windows.Forms.GroupBox
    Friend WithEvents option4_rb As System.Windows.Forms.RadioButton
    Friend WithEvents option3_rb As System.Windows.Forms.RadioButton
    Friend WithEvents option2_rb As System.Windows.Forms.RadioButton
    Friend WithEvents option1_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents que_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents proceed_btn As System.Windows.Forms.Button
End Class
