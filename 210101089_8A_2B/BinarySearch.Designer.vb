<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarySearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BinarySearch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TargetTextBox = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.quiz_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(767, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the array with values separated by commas and click on load"
        '
        'txtInput
        '
        Me.txtInput.AllowDrop = True
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(22, 71)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInput.Size = New System.Drawing.Size(1375, 36)
        Me.txtInput.TabIndex = 6
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(629, 131)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(124, 34)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label2.Location = New System.Drawing.Point(38, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 37)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Binary Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label4.Location = New System.Drawing.Point(38, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 37)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Binary Search Algorithm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Label5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panel1.Controls.Add(Me.TargetTextBox)
        Me.Panel1.Controls.Add(Me.btnSort)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtInput)
        Me.Panel1.Controls.Add(Me.btnLoad)
        Me.Panel1.Location = New System.Drawing.Point(45, 633)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1425, 400)
        Me.Panel1.TabIndex = 22
        '
        'TargetTextBox
        '
        Me.TargetTextBox.AllowDrop = True
        Me.TargetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetTextBox.Location = New System.Drawing.Point(594, 192)
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TargetTextBox.Size = New System.Drawing.Size(100, 36)
        Me.TargetTextBox.TabIndex = 12
        Me.TargetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSort
        '
        Me.btnSort.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(812, 194)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(124, 34)
        Me.btnSort.TabIndex = 11
        Me.btnSort.Text = "Search"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(484, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Enter the value to find and click on search"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1470, 161)
        Me.Panel2.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label13.Location = New System.Drawing.Point(42, 1059)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(223, 27)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Try another module!"
        '
        'quiz_btn
        '
        Me.quiz_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.quiz_btn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz_btn.ForeColor = System.Drawing.Color.White
        Me.quiz_btn.Location = New System.Drawing.Point(50, 1100)
        Me.quiz_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.quiz_btn.Name = "quiz_btn"
        Me.quiz_btn.Size = New System.Drawing.Size(200, 62)
        Me.quiz_btn.TabIndex = 36
        Me.quiz_btn.Text = "Back"
        Me.quiz_btn.UseVisualStyleBackColor = False
        '
        'BinarySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1482, 1055)
        Me.Controls.Add(Me.quiz_btn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "BinarySearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BinarySearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents quiz_btn As System.Windows.Forms.Button
End Class
