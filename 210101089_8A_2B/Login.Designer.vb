<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.showpass_cb = New System.Windows.Forms.CheckBox()
        Me.register_ll = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.error_label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'username_label
        '
        Me.username_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_label.AutoSize = True
        Me.username_label.BackColor = System.Drawing.Color.Transparent
        Me.username_label.Location = New System.Drawing.Point(20, 101)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(93, 19)
        Me.username_label.TabIndex = 0
        Me.username_label.Text = "Username :"
        '
        'password_label
        '
        Me.password_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_label.AutoSize = True
        Me.password_label.BackColor = System.Drawing.Color.Transparent
        Me.password_label.Location = New System.Drawing.Point(20, 158)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(90, 19)
        Me.password_label.TabIndex = 1
        Me.password_label.Text = "Password :"
        '
        'login_btn
        '
        Me.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_btn.BackColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(140, 296)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(210, 40)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Sign In"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'username_tb
        '
        Me.username_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_tb.Location = New System.Drawing.Point(152, 98)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(321, 27)
        Me.username_tb.TabIndex = 2
        '
        'password_tb
        '
        Me.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_tb.Location = New System.Drawing.Point(152, 154)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(321, 27)
        Me.password_tb.TabIndex = 3
        Me.password_tb.UseSystemPasswordChar = True
        '
        'showpass_cb
        '
        Me.showpass_cb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.showpass_cb.AutoSize = True
        Me.showpass_cb.BackColor = System.Drawing.Color.Transparent
        Me.showpass_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showpass_cb.ForeColor = System.Drawing.Color.Black
        Me.showpass_cb.Location = New System.Drawing.Point(152, 189)
        Me.showpass_cb.Name = "showpass_cb"
        Me.showpass_cb.Size = New System.Drawing.Size(141, 23)
        Me.showpass_cb.TabIndex = 4
        Me.showpass_cb.Text = "Show password"
        Me.showpass_cb.UseVisualStyleBackColor = False
        '
        'register_ll
        '
        Me.register_ll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.register_ll.AutoSize = True
        Me.register_ll.LinkColor = System.Drawing.Color.LimeGreen
        Me.register_ll.Location = New System.Drawing.Point(650, 542)
        Me.register_ll.Name = "register_ll"
        Me.register_ll.Size = New System.Drawing.Size(239, 19)
        Me.register_ll.TabIndex = 6
        Me.register_ll.TabStop = True
        Me.register_ll.Text = "Don't have an acount ? Sign Up"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.error_label)
        Me.GroupBox1.Controls.Add(Me.login_btn)
        Me.GroupBox1.Controls.Add(Me.username_tb)
        Me.GroupBox1.Controls.Add(Me.password_label)
        Me.GroupBox1.Controls.Add(Me.password_tb)
        Me.GroupBox1.Controls.Add(Me.username_label)
        Me.GroupBox1.Controls.Add(Me.showpass_cb)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(600, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 373)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'error_label
        '
        Me.error_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.error_label.AutoSize = True
        Me.error_label.Location = New System.Drawing.Point(108, 45)
        Me.error_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(45, 19)
        Me.error_label.TabIndex = 11
        Me.error_label.Text = "error"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 618)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.register_ll)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username_label As System.Windows.Forms.Label
    Friend WithEvents password_label As System.Windows.Forms.Label
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents showpass_cb As System.Windows.Forms.CheckBox
    Friend WithEvents register_ll As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents error_label As System.Windows.Forms.Label

End Class
