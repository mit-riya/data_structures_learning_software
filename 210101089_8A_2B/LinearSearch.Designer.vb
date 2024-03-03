<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinearSearch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInputList = New System.Windows.Forms.TextBox()
        Me.btnLoadList = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quiz_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label1.Location = New System.Drawing.Point(31, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Linear Search"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1450, 50)
        Me.Label2.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.txtSearchValue)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtInputList)
        Me.Panel1.Controls.Add(Me.btnLoadList)
        Me.Panel1.Location = New System.Drawing.Point(18, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1425, 520)
        Me.Panel1.TabIndex = 23
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(22, 259)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(322, 229)
        Me.ListBox1.TabIndex = 24
        '
        'txtSearchValue
        '
        Me.txtSearchValue.AllowDrop = True
        Me.txtSearchValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchValue.Location = New System.Drawing.Point(594, 192)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSearchValue.Size = New System.Drawing.Size(100, 36)
        Me.txtSearchValue.TabIndex = 12
        Me.txtSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(812, 194)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(124, 34)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(767, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enter the array with values separated by commas and click on load"
        '
        'txtInputList
        '
        Me.txtInputList.AllowDrop = True
        Me.txtInputList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputList.Location = New System.Drawing.Point(22, 71)
        Me.txtInputList.Name = "txtInputList"
        Me.txtInputList.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInputList.Size = New System.Drawing.Size(1375, 36)
        Me.txtInputList.TabIndex = 6
        Me.txtInputList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLoadList
        '
        Me.btnLoadList.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadList.Location = New System.Drawing.Point(629, 131)
        Me.btnLoadList.Name = "btnLoadList"
        Me.btnLoadList.Size = New System.Drawing.Size(124, 34)
        Me.btnLoadList.TabIndex = 9
        Me.btnLoadList.Text = "Load"
        Me.btnLoadList.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1485, 161)
        Me.Panel2.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumOrchid
        Me.Label3.Location = New System.Drawing.Point(42, 850)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 27)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Try another module!"
        '
        'quiz_btn
        '
        Me.quiz_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.quiz_btn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quiz_btn.ForeColor = System.Drawing.Color.White
        Me.quiz_btn.Location = New System.Drawing.Point(50, 890)
        Me.quiz_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.quiz_btn.Name = "quiz_btn"
        Me.quiz_btn.Size = New System.Drawing.Size(200, 62)
        Me.quiz_btn.TabIndex = 40
        Me.quiz_btn.Text = "Back"
        Me.quiz_btn.UseVisualStyleBackColor = False
        '
        'LinearSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.quiz_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LinearSearch"
        Me.Text = "LinearSearch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtSearchValue As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInputList As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadList As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents quiz_btn As System.Windows.Forms.Button
End Class
