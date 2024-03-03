<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.error_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.signup_btn = New System.Windows.Forms.Button()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.email_label = New System.Windows.Forms.Label()
        Me.username_label = New System.Windows.Forms.Label()
        Me.login_link = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.error_label)
        Me.GroupBox1.Controls.Add(Me.password_label)
        Me.GroupBox1.Controls.Add(Me.password_tb)
        Me.GroupBox1.Controls.Add(Me.signup_btn)
        Me.GroupBox1.Controls.Add(Me.email_tb)
        Me.GroupBox1.Controls.Add(Me.username_tb)
        Me.GroupBox1.Controls.Add(Me.email_label)
        Me.GroupBox1.Controls.Add(Me.username_label)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(650, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 373)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'error_label
        '
        Me.error_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.error_label.AutoSize = True
        Me.error_label.Location = New System.Drawing.Point(106, 25)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(55, 19)
        Me.error_label.TabIndex = 8
        Me.error_label.Text = "error :"
        '
        'password_label
        '
        Me.password_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_label.AutoSize = True
        Me.password_label.Location = New System.Drawing.Point(20, 189)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(90, 19)
        Me.password_label.TabIndex = 6
        Me.password_label.Text = "Password :"
        '
        'password_tb
        '
        Me.password_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_tb.Location = New System.Drawing.Point(152, 186)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(321, 27)
        Me.password_tb.TabIndex = 5
        Me.password_tb.UseSystemPasswordChar = True
        '
        'signup_btn
        '
        Me.signup_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_btn.Location = New System.Drawing.Point(140, 296)
        Me.signup_btn.Name = "signup_btn"
        Me.signup_btn.Size = New System.Drawing.Size(210, 40)
        Me.signup_btn.TabIndex = 4
        Me.signup_btn.Text = "Sign Up"
        Me.signup_btn.UseVisualStyleBackColor = True
        '
        'email_tb
        '
        Me.email_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.email_tb.Location = New System.Drawing.Point(152, 125)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(321, 27)
        Me.email_tb.TabIndex = 3
        '
        'username_tb
        '
        Me.username_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_tb.Location = New System.Drawing.Point(152, 66)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(321, 27)
        Me.username_tb.TabIndex = 2
        '
        'email_label
        '
        Me.email_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.email_label.AutoSize = True
        Me.email_label.Location = New System.Drawing.Point(20, 128)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(59, 19)
        Me.email_label.TabIndex = 1
        Me.email_label.Text = "Email :"
        '
        'username_label
        '
        Me.username_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.username_label.AutoSize = True
        Me.username_label.Location = New System.Drawing.Point(20, 68)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(93, 19)
        Me.username_label.TabIndex = 0
        Me.username_label.Text = "Username :"
        '
        'login_link
        '
        Me.login_link.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_link.AutoSize = True
        Me.login_link.LinkColor = System.Drawing.Color.LimeGreen
        Me.login_link.Location = New System.Drawing.Point(650, 542)
        Me.login_link.Name = "login_link"
        Me.login_link.Size = New System.Drawing.Size(256, 19)
        Me.login_link.TabIndex = 7
        Me.login_link.TabStop = True
        Me.login_link.Text = "Already have an account? Sign In"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 618)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.login_link)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents login_link As System.Windows.Forms.LinkLabel
    Friend WithEvents password_label As System.Windows.Forms.Label
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents signup_btn As System.Windows.Forms.Button
    Friend WithEvents email_tb As System.Windows.Forms.TextBox
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents email_label As System.Windows.Forms.Label
    Friend WithEvents username_label As System.Windows.Forms.Label
    Friend WithEvents error_label As System.Windows.Forms.Label
End Class
