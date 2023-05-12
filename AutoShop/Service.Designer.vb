<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Service
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Service))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textBoxEmployee = New System.Windows.Forms.TextBox()
        Me.cb_serviceType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBox_note = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Employee = New System.Windows.Forms.Label()
        Me.comboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonUpdate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.button_reset = New System.Windows.Forms.Button()
        Me.comboxEmployeeSearch = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.buttonGoSearch = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listNotes = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1059, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(76, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 55)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Service Work Progress"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-31, -12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1219, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 460)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1176, 328)
        Me.DataGridView1.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textBoxEmployee)
        Me.GroupBox1.Controls.Add(Me.cb_serviceType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtBox_note)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Employee)
        Me.GroupBox1.Controls.Add(Me.comboBoxStatus)
        Me.GroupBox1.Controls.Add(Me.buttonDelete)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buttonUpdate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(523, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 345)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'textBoxEmployee
        '
        Me.textBoxEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxEmployee.Location = New System.Drawing.Point(103, 35)
        Me.textBoxEmployee.Name = "textBoxEmployee"
        Me.textBoxEmployee.Size = New System.Drawing.Size(258, 26)
        Me.textBoxEmployee.TabIndex = 78
        '
        'cb_serviceType
        '
        Me.cb_serviceType.FormattingEnabled = True
        Me.cb_serviceType.Items.AddRange(New Object() {"Maintenance", "Repair"})
        Me.cb_serviceType.Location = New System.Drawing.Point(104, 208)
        Me.cb_serviceType.Name = "cb_serviceType"
        Me.cb_serviceType.Size = New System.Drawing.Size(258, 32)
        Me.cb_serviceType.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Type"
        '
        'txtBox_note
        '
        Me.txtBox_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_note.Location = New System.Drawing.Point(104, 83)
        Me.txtBox_note.Multiline = True
        Me.txtBox_note.Name = "txtBox_note"
        Me.txtBox_note.Size = New System.Drawing.Size(258, 105)
        Me.txtBox_note.TabIndex = 75
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 18)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Note"
        '
        'Employee
        '
        Me.Employee.AutoSize = True
        Me.Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee.Location = New System.Drawing.Point(23, 35)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(74, 18)
        Me.Employee.TabIndex = 72
        Me.Employee.Text = "Employee"
        '
        'comboBoxStatus
        '
        Me.comboBoxStatus.FormattingEnabled = True
        Me.comboBoxStatus.Items.AddRange(New Object() {"Work in Progress", "Completed"})
        Me.comboBoxStatus.Location = New System.Drawing.Point(104, 253)
        Me.comboBoxStatus.Name = "comboBoxStatus"
        Me.comboBoxStatus.Size = New System.Drawing.Size(258, 32)
        Me.comboBoxStatus.TabIndex = 71
        '
        'buttonDelete
        '
        Me.buttonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDelete.Location = New System.Drawing.Point(216, 300)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(146, 30)
        Me.buttonDelete.TabIndex = 67
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Status"
        '
        'buttonUpdate
        '
        Me.buttonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonUpdate.Location = New System.Drawing.Point(26, 300)
        Me.buttonUpdate.Name = "buttonUpdate"
        Me.buttonUpdate.Size = New System.Drawing.Size(143, 30)
        Me.buttonUpdate.TabIndex = 68
        Me.buttonUpdate.Text = "Update"
        Me.buttonUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.button_reset)
        Me.GroupBox2.Controls.Add(Me.comboxEmployeeSearch)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.buttonGoSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(901, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 148)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'button_reset
        '
        Me.button_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_reset.Location = New System.Drawing.Point(22, 108)
        Me.button_reset.Name = "button_reset"
        Me.button_reset.Size = New System.Drawing.Size(71, 30)
        Me.button_reset.TabIndex = 74
        Me.button_reset.Text = "Reset"
        Me.button_reset.UseVisualStyleBackColor = True
        '
        'comboxEmployeeSearch
        '
        Me.comboxEmployeeSearch.FormattingEnabled = True
        Me.comboxEmployeeSearch.Location = New System.Drawing.Point(99, 34)
        Me.comboxEmployeeSearch.Name = "comboxEmployeeSearch"
        Me.comboxEmployeeSearch.Size = New System.Drawing.Size(178, 32)
        Me.comboxEmployeeSearch.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Employee"
        '
        'buttonGoSearch
        '
        Me.buttonGoSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGoSearch.Location = New System.Drawing.Point(22, 72)
        Me.buttonGoSearch.Name = "buttonGoSearch"
        Me.buttonGoSearch.Size = New System.Drawing.Size(255, 30)
        Me.buttonGoSearch.TabIndex = 68
        Me.buttonGoSearch.Text = "Go"
        Me.buttonGoSearch.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(901, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(287, 34)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Clear All Fields"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listNotes
        '
        Me.listNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listNotes.FormattingEnabled = True
        Me.listNotes.ItemHeight = 18
        Me.listNotes.Location = New System.Drawing.Point(13, 144)
        Me.listNotes.Name = "listNotes"
        Me.listNotes.Size = New System.Drawing.Size(504, 310)
        Me.listNotes.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Service Works"
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listNotes)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Service"
        Me.Text = "Service"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttonUpdate As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Employee As Label
    Friend WithEvents txtBox_note As TextBox
    Friend WithEvents Label16 As Label
    Public WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents buttonGoSearch As Button
    Friend WithEvents comboxEmployeeSearch As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents textBoxEmployee As TextBox
    Friend WithEvents cb_serviceType As ComboBox
    Friend WithEvents comboBoxStatus As ComboBox
    Friend WithEvents listNotes As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents button_reset As Button
End Class
