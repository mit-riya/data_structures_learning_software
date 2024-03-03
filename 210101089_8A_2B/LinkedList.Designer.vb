<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkedList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinkedList))
        Me.quiz_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.delete_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.new_num_tb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.update_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.insert_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LL_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'quiz_btn
        '
        Me.quiz_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.quiz_btn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz_btn.ForeColor = System.Drawing.Color.White
        Me.quiz_btn.Location = New System.Drawing.Point(31, 928)
        Me.quiz_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.quiz_btn.Name = "quiz_btn"
        Me.quiz_btn.Size = New System.Drawing.Size(200, 62)
        Me.quiz_btn.TabIndex = 22
        Me.quiz_btn.Text = "Take Quiz"
        Me.quiz_btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1207, 161)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.quiz_btn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 1039)
        Me.Panel1.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(610, 928)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 62)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label11.Location = New System.Drawing.Point(600, 890)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 27)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Try another module!"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 252)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1121, 135)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "We will look at some commonly used linked list operations in this tutorial:" & Global.Microsoft.VisualBasic.ChrW(10) & "1) In" & _
            "sert elements" & Global.Microsoft.VisualBasic.ChrW(10) & "2) Search elements" & Global.Microsoft.VisualBasic.ChrW(10) & "3) Update elements" & Global.Microsoft.VisualBasic.ChrW(10) & "4) Delete elements"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(26, 70)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1121, 135)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label7.Location = New System.Drawing.Point(23, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 37)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Linked List"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label6.Location = New System.Drawing.Point(25, 219)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 27)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Basic Linked List Operations"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label13.Location = New System.Drawing.Point(25, 890)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(245, 27)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Ready to test yourself?"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Plum
        Me.Panel3.Controls.Add(Me.reset)
        Me.Panel3.Controls.Add(Me.delete_btn)
        Me.Panel3.Controls.Add(Me.delete_tb)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.new_num_tb)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.update_btn)
        Me.Panel3.Controls.Add(Me.update_tb)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.search_btn)
        Me.Panel3.Controls.Add(Me.search_tb)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.insert_btn)
        Me.Panel3.Controls.Add(Me.insert_tb)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.LL_panel)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(31, 412)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1125, 450)
        Me.Panel3.TabIndex = 25
        '
        'reset
        '
        Me.reset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.reset.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(968, 372)
        Me.reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(132, 56)
        Me.reset.TabIndex = 23
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.delete_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.delete_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(475, 322)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(76, 37)
        Me.delete_btn.TabIndex = 33
        Me.delete_btn.Text = "Go"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'delete_tb
        '
        Me.delete_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.delete_tb.BackColor = System.Drawing.Color.White
        Me.delete_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.delete_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_tb.Location = New System.Drawing.Point(254, 322)
        Me.delete_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.delete_tb.Multiline = True
        Me.delete_tb.Name = "delete_tb"
        Me.delete_tb.Size = New System.Drawing.Size(150, 37)
        Me.delete_tb.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 327)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Delete element:"
        '
        'new_num_tb
        '
        Me.new_num_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.new_num_tb.BackColor = System.Drawing.Color.White
        Me.new_num_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.new_num_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_num_tb.Location = New System.Drawing.Point(718, 274)
        Me.new_num_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.new_num_tb.Multiline = True
        Me.new_num_tb.Name = "new_num_tb"
        Me.new_num_tb.Size = New System.Drawing.Size(150, 37)
        Me.new_num_tb.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(469, 281)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "With new element:"
        '
        'update_btn
        '
        Me.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.update_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.update_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.Location = New System.Drawing.Point(913, 274)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(76, 37)
        Me.update_btn.TabIndex = 28
        Me.update_btn.Text = "Go"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'update_tb
        '
        Me.update_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.update_tb.BackColor = System.Drawing.Color.White
        Me.update_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_tb.Location = New System.Drawing.Point(254, 274)
        Me.update_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.update_tb.Multiline = True
        Me.update_tb.Name = "update_tb"
        Me.update_tb.Size = New System.Drawing.Size(150, 37)
        Me.update_tb.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 281)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Update element:"
        '
        'search_btn
        '
        Me.search_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.search_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.search_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.White
        Me.search_btn.Location = New System.Drawing.Point(474, 228)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(76, 37)
        Me.search_btn.TabIndex = 25
        Me.search_btn.Text = "Go"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'search_tb
        '
        Me.search_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.search_tb.BackColor = System.Drawing.Color.White
        Me.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_tb.Location = New System.Drawing.Point(254, 228)
        Me.search_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.search_tb.Multiline = True
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(150, 37)
        Me.search_tb.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Search element:"
        '
        'insert_btn
        '
        Me.insert_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insert_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.insert_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_btn.ForeColor = System.Drawing.Color.White
        Me.insert_btn.Location = New System.Drawing.Point(474, 182)
        Me.insert_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(76, 37)
        Me.insert_btn.TabIndex = 22
        Me.insert_btn.Text = "Go"
        Me.insert_btn.UseVisualStyleBackColor = False
        '
        'insert_tb
        '
        Me.insert_tb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insert_tb.BackColor = System.Drawing.Color.White
        Me.insert_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.insert_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_tb.Location = New System.Drawing.Point(254, 182)
        Me.insert_tb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.insert_tb.Multiline = True
        Me.insert_tb.Name = "insert_tb"
        Me.insert_tb.Size = New System.Drawing.Size(150, 37)
        Me.insert_tb.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Insert element:"
        '
        'LL_panel
        '
        Me.LL_panel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LL_panel.Location = New System.Drawing.Point(219, 16)
        Me.LL_panel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LL_panel.Name = "LL_panel"
        Me.LL_panel.Size = New System.Drawing.Size(881, 155)
        Me.LL_panel.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 27)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Linked List:"
        '
        'LinkedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 1200)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LinkedList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LinkedList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents quiz_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents delete_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents new_num_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents update_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents search_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents insert_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LL_panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
