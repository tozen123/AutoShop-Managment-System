<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PartsProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartsProducts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttonGenerateID = New System.Windows.Forms.Button()
        Me.txtBoxProductID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.buttonUpdate = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.txtBoxProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.buttonSearchNext = New System.Windows.Forms.Button()
        Me.searchTxtBoxID = New System.Windows.Forms.TextBox()
        Me.buttonSearchPrevious = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.searchTxtBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchTxtBoxName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.buttonGoSearch = New System.Windows.Forms.Button()
        Me.buttonClearFields = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonRefresh = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(89, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 55)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Parts Products"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-18, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1219, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 357)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1176, 431)
        Me.DataGridView1.TabIndex = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.buttonGenerateID)
        Me.GroupBox1.Controls.Add(Me.txtBoxProductID)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBoxPrice)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.buttonUpdate)
        Me.GroupBox1.Controls.Add(Me.buttonDelete)
        Me.GroupBox1.Controls.Add(Me.txtBoxProductName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buttonAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 225)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'buttonGenerateID
        '
        Me.buttonGenerateID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGenerateID.Location = New System.Drawing.Point(317, 54)
        Me.buttonGenerateID.Name = "buttonGenerateID"
        Me.buttonGenerateID.Size = New System.Drawing.Size(167, 24)
        Me.buttonGenerateID.TabIndex = 73
        Me.buttonGenerateID.Text = "Generate ID"
        Me.buttonGenerateID.UseVisualStyleBackColor = True
        '
        'txtBoxProductID
        '
        Me.txtBoxProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtBoxProductID.Location = New System.Drawing.Point(123, 54)
        Me.txtBoxProductID.Name = "txtBoxProductID"
        Me.txtBoxProductID.Size = New System.Drawing.Size(188, 24)
        Me.txtBoxProductID.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(22, 18)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "ID"
        '
        'txtBoxPrice
        '
        Me.txtBoxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtBoxPrice.Location = New System.Drawing.Point(123, 143)
        Me.txtBoxPrice.Name = "txtBoxPrice"
        Me.txtBoxPrice.Size = New System.Drawing.Size(361, 24)
        Me.txtBoxPrice.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Price"
        '
        'buttonUpdate
        '
        Me.buttonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonUpdate.Location = New System.Drawing.Point(381, 179)
        Me.buttonUpdate.Name = "buttonUpdate"
        Me.buttonUpdate.Size = New System.Drawing.Size(155, 30)
        Me.buttonUpdate.TabIndex = 68
        Me.buttonUpdate.Text = "Update"
        Me.buttonUpdate.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDelete.Location = New System.Drawing.Point(206, 179)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(155, 30)
        Me.buttonDelete.TabIndex = 67
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'txtBoxProductName
        '
        Me.txtBoxProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtBoxProductName.Location = New System.Drawing.Point(123, 103)
        Me.txtBoxProductName.Name = "txtBoxProductName"
        Me.txtBoxProductName.Size = New System.Drawing.Size(361, 24)
        Me.txtBoxProductName.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Name"
        '
        'buttonAdd
        '
        Me.buttonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdd.Location = New System.Drawing.Point(36, 179)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(155, 30)
        Me.buttonAdd.TabIndex = 63
        Me.buttonAdd.Text = "Insert"
        Me.buttonAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.buttonSearchNext)
        Me.GroupBox2.Controls.Add(Me.searchTxtBoxID)
        Me.GroupBox2.Controls.Add(Me.buttonSearchPrevious)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.searchTxtBoxPrice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.searchTxtBoxName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.buttonGoSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(591, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 225)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'buttonSearchNext
        '
        Me.buttonSearchNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSearchNext.Location = New System.Drawing.Point(249, 149)
        Me.buttonSearchNext.Name = "buttonSearchNext"
        Me.buttonSearchNext.Size = New System.Drawing.Size(155, 30)
        Me.buttonSearchNext.TabIndex = 60
        Me.buttonSearchNext.Text = "Next"
        Me.buttonSearchNext.UseVisualStyleBackColor = True
        '
        'searchTxtBoxID
        '
        Me.searchTxtBoxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.searchTxtBoxID.Location = New System.Drawing.Point(105, 40)
        Me.searchTxtBoxID.Name = "searchTxtBoxID"
        Me.searchTxtBoxID.Size = New System.Drawing.Size(299, 24)
        Me.searchTxtBoxID.TabIndex = 76
        '
        'buttonSearchPrevious
        '
        Me.buttonSearchPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSearchPrevious.Location = New System.Drawing.Point(249, 185)
        Me.buttonSearchPrevious.Name = "buttonSearchPrevious"
        Me.buttonSearchPrevious.Size = New System.Drawing.Size(155, 30)
        Me.buttonSearchPrevious.TabIndex = 61
        Me.buttonSearchPrevious.Text = "Previous"
        Me.buttonSearchPrevious.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 18)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "ID"
        '
        'searchTxtBoxPrice
        '
        Me.searchTxtBoxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.searchTxtBoxPrice.Location = New System.Drawing.Point(105, 119)
        Me.searchTxtBoxPrice.Name = "searchTxtBoxPrice"
        Me.searchTxtBoxPrice.Size = New System.Drawing.Size(299, 24)
        Me.searchTxtBoxPrice.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Price"
        '
        'searchTxtBoxName
        '
        Me.searchTxtBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.searchTxtBoxName.Location = New System.Drawing.Point(105, 80)
        Me.searchTxtBoxName.Name = "searchTxtBoxName"
        Me.searchTxtBoxName.Size = New System.Drawing.Size(299, 24)
        Me.searchTxtBoxName.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Name"
        '
        'buttonGoSearch
        '
        Me.buttonGoSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGoSearch.Location = New System.Drawing.Point(27, 179)
        Me.buttonGoSearch.Name = "buttonGoSearch"
        Me.buttonGoSearch.Size = New System.Drawing.Size(94, 30)
        Me.buttonGoSearch.TabIndex = 63
        Me.buttonGoSearch.Text = "Go"
        Me.buttonGoSearch.UseVisualStyleBackColor = True
        '
        'buttonClearFields
        '
        Me.buttonClearFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClearFields.Location = New System.Drawing.Point(1021, 321)
        Me.buttonClearFields.Name = "buttonClearFields"
        Me.buttonClearFields.Size = New System.Drawing.Size(155, 30)
        Me.buttonClearFields.TabIndex = 59
        Me.buttonClearFields.Text = "Clear Fields"
        Me.buttonClearFields.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1072, -39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'buttonRefresh
        '
        Me.buttonRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRefresh.Location = New System.Drawing.Point(1021, 285)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Size = New System.Drawing.Size(155, 30)
        Me.buttonRefresh.TabIndex = 63
        Me.buttonRefresh.Text = "Refresh"
        Me.buttonRefresh.UseVisualStyleBackColor = True
        '
        'PartsProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.buttonClearFields)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PartsProducts"
        Me.Text = "PartsProducts"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents buttonClearFields As Button
    Friend WithEvents buttonSearchNext As Button
    Friend WithEvents buttonSearchPrevious As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents buttonAdd As Button
    Friend WithEvents txtBoxProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents buttonUpdate As Button
    Friend WithEvents buttonDelete As Button
    Friend WithEvents txtBoxPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents buttonGoSearch As Button
    Friend WithEvents searchTxtBoxPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents searchTxtBoxName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchTxtBoxID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBoxProductID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents buttonGenerateID As Button
    Friend WithEvents buttonRefresh As Button
End Class
