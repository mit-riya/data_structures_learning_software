<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.vector_gb = New System.Windows.Forms.GroupBox()
        Me.vector_text = New System.Windows.Forms.Label()
        Me.vector_check = New System.Windows.Forms.CheckBox()
        Me.sorting_gb = New System.Windows.Forms.GroupBox()
        Me.sorting_text = New System.Windows.Forms.Label()
        Me.sorting_check = New System.Windows.Forms.CheckBox()
        Me.stack_gb = New System.Windows.Forms.GroupBox()
        Me.stack_text = New System.Windows.Forms.Label()
        Me.stack_check = New System.Windows.Forms.CheckBox()
        Me.linkedlist_gb = New System.Windows.Forms.GroupBox()
        Me.linkedlist_text = New System.Windows.Forms.Label()
        Me.linkedlist_check = New System.Windows.Forms.CheckBox()
        Me.searching_gb = New System.Windows.Forms.GroupBox()
        Me.searching_text = New System.Windows.Forms.Label()
        Me.searching_check = New System.Windows.Forms.CheckBox()
        Me.queue_gb = New System.Windows.Forms.GroupBox()
        Me.queue_text = New System.Windows.Forms.Label()
        Me.queue_check = New System.Windows.Forms.CheckBox()
        Me.array_gb = New System.Windows.Forms.GroupBox()
        Me.array_text = New System.Windows.Forms.Label()
        Me.array_check = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.username_label = New System.Windows.Forms.Label()
        Me.progressbar = New System.Windows.Forms.ProgressBar()
        Me.userid_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.vector_gb.SuspendLayout()
        Me.sorting_gb.SuspendLayout()
        Me.stack_gb.SuspendLayout()
        Me.linkedlist_gb.SuspendLayout()
        Me.searching_gb.SuspendLayout()
        Me.queue_gb.SuspendLayout()
        Me.array_gb.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoScrollMinSize = New System.Drawing.Size(0, 1500)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.vector_gb)
        Me.Panel3.Controls.Add(Me.sorting_gb)
        Me.Panel3.Controls.Add(Me.stack_gb)
        Me.Panel3.Controls.Add(Me.linkedlist_gb)
        Me.Panel3.Controls.Add(Me.searching_gb)
        Me.Panel3.Controls.Add(Me.queue_gb)
        Me.Panel3.Controls.Add(Me.array_gb)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1045, 618)
        Me.Panel3.TabIndex = 11
        '
        'vector_gb
        '
        Me.vector_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.vector_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.vector_gb.Controls.Add(Me.vector_text)
        Me.vector_gb.Controls.Add(Me.vector_check)
        Me.vector_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vector_gb.ForeColor = System.Drawing.Color.White
        Me.vector_gb.Location = New System.Drawing.Point(48, 919)
        Me.vector_gb.Name = "vector_gb"
        Me.vector_gb.Size = New System.Drawing.Size(250, 250)
        Me.vector_gb.TabIndex = 25
        Me.vector_gb.TabStop = False
        Me.vector_gb.Text = "Vectors"
        '
        'vector_text
        '
        Me.vector_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vector_text.Location = New System.Drawing.Point(11, 68)
        Me.vector_text.Name = "vector_text"
        Me.vector_text.Size = New System.Drawing.Size(228, 110)
        Me.vector_text.TabIndex = 7
        Me.vector_text.Text = "tar tar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vector!"
        Me.vector_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'vector_check
        '
        Me.vector_check.AutoSize = True
        Me.vector_check.Enabled = False
        Me.vector_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vector_check.Location = New System.Drawing.Point(213, 29)
        Me.vector_check.Name = "vector_check"
        Me.vector_check.Size = New System.Drawing.Size(14, 13)
        Me.vector_check.TabIndex = 0
        Me.vector_check.UseVisualStyleBackColor = True
        '
        'sorting_gb
        '
        Me.sorting_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.sorting_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sorting_gb.Controls.Add(Me.sorting_text)
        Me.sorting_gb.Controls.Add(Me.sorting_check)
        Me.sorting_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sorting_gb.ForeColor = System.Drawing.Color.White
        Me.sorting_gb.Location = New System.Drawing.Point(357, 281)
        Me.sorting_gb.Name = "sorting_gb"
        Me.sorting_gb.Size = New System.Drawing.Size(250, 250)
        Me.sorting_gb.TabIndex = 21
        Me.sorting_gb.TabStop = False
        Me.sorting_gb.Text = "Sorting"
        '
        'sorting_text
        '
        Me.sorting_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.sorting_text.Location = New System.Drawing.Point(15, 67)
        Me.sorting_text.Name = "sorting_text"
        Me.sorting_text.Size = New System.Drawing.Size(220, 110)
        Me.sorting_text.TabIndex = 5
        Me.sorting_text.Text = "Sort your way " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to clarity!"
        Me.sorting_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sorting_check
        '
        Me.sorting_check.AutoSize = True
        Me.sorting_check.Enabled = False
        Me.sorting_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sorting_check.Location = New System.Drawing.Point(213, 29)
        Me.sorting_check.Name = "sorting_check"
        Me.sorting_check.Size = New System.Drawing.Size(14, 13)
        Me.sorting_check.TabIndex = 0
        Me.sorting_check.UseVisualStyleBackColor = True
        '
        'stack_gb
        '
        Me.stack_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.stack_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stack_gb.Controls.Add(Me.stack_text)
        Me.stack_gb.Controls.Add(Me.stack_check)
        Me.stack_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stack_gb.ForeColor = System.Drawing.Color.White
        Me.stack_gb.Location = New System.Drawing.Point(669, 281)
        Me.stack_gb.Name = "stack_gb"
        Me.stack_gb.Size = New System.Drawing.Size(250, 250)
        Me.stack_gb.TabIndex = 20
        Me.stack_gb.TabStop = False
        Me.stack_gb.Text = "Stacks"
        '
        'stack_text
        '
        Me.stack_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.stack_text.Location = New System.Drawing.Point(16, 67)
        Me.stack_text.Name = "stack_text"
        Me.stack_text.Size = New System.Drawing.Size(220, 110)
        Me.stack_text.TabIndex = 6
        Me.stack_text.Text = "Stack up your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "knowledge!"
        Me.stack_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stack_check
        '
        Me.stack_check.AutoSize = True
        Me.stack_check.Enabled = False
        Me.stack_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stack_check.Location = New System.Drawing.Point(213, 29)
        Me.stack_check.Name = "stack_check"
        Me.stack_check.Size = New System.Drawing.Size(14, 13)
        Me.stack_check.TabIndex = 0
        Me.stack_check.UseVisualStyleBackColor = True
        '
        'linkedlist_gb
        '
        Me.linkedlist_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.linkedlist_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.linkedlist_gb.Controls.Add(Me.linkedlist_text)
        Me.linkedlist_gb.Controls.Add(Me.linkedlist_check)
        Me.linkedlist_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkedlist_gb.ForeColor = System.Drawing.Color.White
        Me.linkedlist_gb.Location = New System.Drawing.Point(669, 602)
        Me.linkedlist_gb.Name = "linkedlist_gb"
        Me.linkedlist_gb.Size = New System.Drawing.Size(250, 250)
        Me.linkedlist_gb.TabIndex = 23
        Me.linkedlist_gb.TabStop = False
        Me.linkedlist_gb.Text = "Linked List"
        '
        'linkedlist_text
        '
        Me.linkedlist_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linkedlist_text.Location = New System.Drawing.Point(11, 68)
        Me.linkedlist_text.Name = "linkedlist_text"
        Me.linkedlist_text.Size = New System.Drawing.Size(228, 110)
        Me.linkedlist_text.TabIndex = 7
        Me.linkedlist_text.Text = "Connect the dots" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data journey!"
        Me.linkedlist_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'linkedlist_check
        '
        Me.linkedlist_check.AutoSize = True
        Me.linkedlist_check.Enabled = False
        Me.linkedlist_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.linkedlist_check.Location = New System.Drawing.Point(213, 29)
        Me.linkedlist_check.Name = "linkedlist_check"
        Me.linkedlist_check.Size = New System.Drawing.Size(14, 13)
        Me.linkedlist_check.TabIndex = 0
        Me.linkedlist_check.UseVisualStyleBackColor = True
        '
        'searching_gb
        '
        Me.searching_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.searching_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.searching_gb.Controls.Add(Me.searching_text)
        Me.searching_gb.Controls.Add(Me.searching_check)
        Me.searching_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searching_gb.ForeColor = System.Drawing.Color.White
        Me.searching_gb.Location = New System.Drawing.Point(357, 602)
        Me.searching_gb.Name = "searching_gb"
        Me.searching_gb.Size = New System.Drawing.Size(250, 250)
        Me.searching_gb.TabIndex = 24
        Me.searching_gb.TabStop = False
        Me.searching_gb.Text = "Searching"
        '
        'searching_text
        '
        Me.searching_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searching_text.Location = New System.Drawing.Point(15, 68)
        Me.searching_text.Name = "searching_text"
        Me.searching_text.Size = New System.Drawing.Size(220, 110)
        Me.searching_text.TabIndex = 7
        Me.searching_text.Text = "Search smarter," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "not harder!"
        Me.searching_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'searching_check
        '
        Me.searching_check.AutoSize = True
        Me.searching_check.Enabled = False
        Me.searching_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searching_check.Location = New System.Drawing.Point(213, 29)
        Me.searching_check.Name = "searching_check"
        Me.searching_check.Size = New System.Drawing.Size(14, 13)
        Me.searching_check.TabIndex = 0
        Me.searching_check.UseVisualStyleBackColor = True
        '
        'queue_gb
        '
        Me.queue_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.queue_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.queue_gb.Controls.Add(Me.queue_text)
        Me.queue_gb.Controls.Add(Me.queue_check)
        Me.queue_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queue_gb.ForeColor = System.Drawing.Color.White
        Me.queue_gb.Location = New System.Drawing.Point(48, 602)
        Me.queue_gb.Name = "queue_gb"
        Me.queue_gb.Size = New System.Drawing.Size(250, 250)
        Me.queue_gb.TabIndex = 22
        Me.queue_gb.TabStop = False
        Me.queue_gb.Text = "Queues"
        '
        'queue_text
        '
        Me.queue_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.queue_text.Location = New System.Drawing.Point(15, 68)
        Me.queue_text.Name = "queue_text"
        Me.queue_text.Size = New System.Drawing.Size(220, 110)
        Me.queue_text.TabIndex = 7
        Me.queue_text.Text = "Join the queue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for success!"
        Me.queue_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'queue_check
        '
        Me.queue_check.AutoSize = True
        Me.queue_check.Enabled = False
        Me.queue_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.queue_check.Location = New System.Drawing.Point(213, 29)
        Me.queue_check.Name = "queue_check"
        Me.queue_check.Size = New System.Drawing.Size(14, 13)
        Me.queue_check.TabIndex = 0
        Me.queue_check.UseVisualStyleBackColor = True
        '
        'array_gb
        '
        Me.array_gb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.array_gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.array_gb.Controls.Add(Me.array_text)
        Me.array_gb.Controls.Add(Me.array_check)
        Me.array_gb.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.array_gb.ForeColor = System.Drawing.Color.White
        Me.array_gb.Location = New System.Drawing.Point(48, 281)
        Me.array_gb.Name = "array_gb"
        Me.array_gb.Size = New System.Drawing.Size(250, 250)
        Me.array_gb.TabIndex = 19
        Me.array_gb.TabStop = False
        Me.array_gb.Text = "Arrays"
        '
        'array_text
        '
        Me.array_text.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.array_text.Location = New System.Drawing.Point(15, 67)
        Me.array_text.Name = "array_text"
        Me.array_text.Size = New System.Drawing.Size(220, 110)
        Me.array_text.TabIndex = 4
        Me.array_text.Text = "Master the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fudamentals of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "array!"
        Me.array_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'array_check
        '
        Me.array_check.AutoSize = True
        Me.array_check.Enabled = False
        Me.array_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.array_check.Location = New System.Drawing.Point(213, 29)
        Me.array_check.Name = "array_check"
        Me.array_check.Size = New System.Drawing.Size(14, 13)
        Me.array_check.TabIndex = 0
        Me.array_check.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Violet
        Me.Panel2.Controls.Add(Me.logout_btn)
        Me.Panel2.Controls.Add(Me.username_label)
        Me.Panel2.Controls.Add(Me.progressbar)
        Me.Panel2.Controls.Add(Me.userid_label)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 161)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 45)
        Me.Panel2.TabIndex = 13
        '
        'logout_btn
        '
        Me.logout_btn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.logout_btn.Location = New System.Drawing.Point(859, 6)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(135, 34)
        Me.logout_btn.TabIndex = 8
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = True
        '
        'username_label
        '
        Me.username_label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.username_label.AutoSize = True
        Me.username_label.Location = New System.Drawing.Point(123, 12)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(83, 19)
        Me.username_label.TabIndex = 5
        Me.username_label.Text = "Username"
        '
        'progressbar
        '
        Me.progressbar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.progressbar.Location = New System.Drawing.Point(243, 6)
        Me.progressbar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.progressbar.Name = "progressbar"
        Me.progressbar.Size = New System.Drawing.Size(238, 34)
        Me.progressbar.TabIndex = 7
        '
        'userid_label
        '
        Me.userid_label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.userid_label.AutoSize = True
        Me.userid_label.Location = New System.Drawing.Point(35, 12)
        Me.userid_label.Name = "userid_label"
        Me.userid_label.Size = New System.Drawing.Size(60, 19)
        Me.userid_label.TabIndex = 6
        Me.userid_label.Text = "UserID"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 161)
        Me.Panel1.TabIndex = 12
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 618)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.vector_gb.ResumeLayout(False)
        Me.vector_gb.PerformLayout()
        Me.sorting_gb.ResumeLayout(False)
        Me.sorting_gb.PerformLayout()
        Me.stack_gb.ResumeLayout(False)
        Me.stack_gb.PerformLayout()
        Me.linkedlist_gb.ResumeLayout(False)
        Me.linkedlist_gb.PerformLayout()
        Me.searching_gb.ResumeLayout(False)
        Me.searching_gb.PerformLayout()
        Me.queue_gb.ResumeLayout(False)
        Me.queue_gb.PerformLayout()
        Me.array_gb.ResumeLayout(False)
        Me.array_gb.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents username_label As System.Windows.Forms.Label
    Friend WithEvents progressbar As System.Windows.Forms.ProgressBar
    Friend WithEvents userid_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents linkedlist_gb As System.Windows.Forms.GroupBox
    Friend WithEvents linkedlist_check As System.Windows.Forms.CheckBox
    Friend WithEvents searching_gb As System.Windows.Forms.GroupBox
    Friend WithEvents searching_check As System.Windows.Forms.CheckBox
    Friend WithEvents queue_gb As System.Windows.Forms.GroupBox
    Friend WithEvents queue_check As System.Windows.Forms.CheckBox
    Friend WithEvents sorting_gb As System.Windows.Forms.GroupBox
    Friend WithEvents sorting_check As System.Windows.Forms.CheckBox
    Friend WithEvents stack_gb As System.Windows.Forms.GroupBox
    Friend WithEvents stack_check As System.Windows.Forms.CheckBox
    Friend WithEvents array_gb As System.Windows.Forms.GroupBox
    Friend WithEvents array_check As System.Windows.Forms.CheckBox
    Friend WithEvents array_text As System.Windows.Forms.Label
    Friend WithEvents sorting_text As System.Windows.Forms.Label
    Friend WithEvents stack_text As System.Windows.Forms.Label
    Friend WithEvents linkedlist_text As System.Windows.Forms.Label
    Friend WithEvents searching_text As System.Windows.Forms.Label
    Friend WithEvents queue_text As System.Windows.Forms.Label
    Friend WithEvents vector_gb As System.Windows.Forms.GroupBox
    Friend WithEvents vector_text As System.Windows.Forms.Label
    Friend WithEvents vector_check As System.Windows.Forms.CheckBox
End Class
