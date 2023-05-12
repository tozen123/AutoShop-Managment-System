<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Discounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Discounts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.discountAddGroup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBox_name = New System.Windows.Forms.TextBox()
        Me.buttonGenerate_id_id = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBox_discountValue = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBox_discountID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.button_delete = New System.Windows.Forms.Button()
        Me.button_clearFields = New System.Windows.Forms.Button()
        Me.button_add = New System.Windows.Forms.Button()
        Me.button_update = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.applyGroup = New System.Windows.Forms.GroupBox()
        Me.txtDiscountID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboBoxDiscounts = New System.Windows.Forms.ComboBox()
        Me.txtBoxCurrentSelect = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.prodInfo = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBoxPartPrice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBoxPartName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBoxProductID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.listBoxProducts = New System.Windows.Forms.ListBox()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.buttonApplyDiscount = New System.Windows.Forms.Button()
        Me.buttonUpdate = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.discountAddGroup.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.applyGroup.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.prodInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(102, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 55)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Discounts"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1219, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 764)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1219, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 115)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1175, 643)
        Me.TabControl1.TabIndex = 68
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.Controls.Add(Me.discountAddGroup)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.button_delete)
        Me.TabPage1.Controls.Add(Me.button_clearFields)
        Me.TabPage1.Controls.Add(Me.button_add)
        Me.TabPage1.Controls.Add(Me.button_update)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1167, 617)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Discount"
        '
        'discountAddGroup
        '
        Me.discountAddGroup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.discountAddGroup.Controls.Add(Me.Label2)
        Me.discountAddGroup.Controls.Add(Me.Label7)
        Me.discountAddGroup.Controls.Add(Me.txtBox_name)
        Me.discountAddGroup.Controls.Add(Me.buttonGenerate_id_id)
        Me.discountAddGroup.Controls.Add(Me.Label8)
        Me.discountAddGroup.Controls.Add(Me.txtBox_discountValue)
        Me.discountAddGroup.Controls.Add(Me.Label9)
        Me.discountAddGroup.Controls.Add(Me.txtBox_discountID)
        Me.discountAddGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountAddGroup.Location = New System.Drawing.Point(242, 56)
        Me.discountAddGroup.Name = "discountAddGroup"
        Me.discountAddGroup.Size = New System.Drawing.Size(451, 208)
        Me.discountAddGroup.TabIndex = 75
        Me.discountAddGroup.TabStop = False
        Me.discountAddGroup.Text = "Discount Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Name"
        '
        'txtBox_name
        '
        Me.txtBox_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_name.Location = New System.Drawing.Point(100, 142)
        Me.txtBox_name.Name = "txtBox_name"
        Me.txtBox_name.Size = New System.Drawing.Size(234, 26)
        Me.txtBox_name.TabIndex = 68
        '
        'buttonGenerate_id_id
        '
        Me.buttonGenerate_id_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGenerate_id_id.Location = New System.Drawing.Point(284, 58)
        Me.buttonGenerate_id_id.Name = "buttonGenerate_id_id"
        Me.buttonGenerate_id_id.Size = New System.Drawing.Size(161, 28)
        Me.buttonGenerate_id_id.TabIndex = 67
        Me.buttonGenerate_id_id.Text = "Generate Discount ID"
        Me.buttonGenerate_id_id.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Value"
        '
        'txtBox_discountValue
        '
        Me.txtBox_discountValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_discountValue.Location = New System.Drawing.Point(100, 103)
        Me.txtBox_discountValue.Name = "txtBox_discountValue"
        Me.txtBox_discountValue.Size = New System.Drawing.Size(178, 26)
        Me.txtBox_discountValue.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "ID"
        '
        'txtBox_discountID
        '
        Me.txtBox_discountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_discountID.Location = New System.Drawing.Point(100, 58)
        Me.txtBox_discountID.Name = "txtBox_discountID"
        Me.txtBox_discountID.Size = New System.Drawing.Size(178, 26)
        Me.txtBox_discountID.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Discount Table"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1155, 277)
        Me.DataGridView1.TabIndex = 73
        '
        'button_delete
        '
        Me.button_delete.Location = New System.Drawing.Point(712, 159)
        Me.button_delete.Name = "button_delete"
        Me.button_delete.Size = New System.Drawing.Size(195, 38)
        Me.button_delete.TabIndex = 69
        Me.button_delete.Text = "Delete"
        Me.button_delete.UseVisualStyleBackColor = True
        '
        'button_clearFields
        '
        Me.button_clearFields.Location = New System.Drawing.Point(711, 231)
        Me.button_clearFields.Name = "button_clearFields"
        Me.button_clearFields.Size = New System.Drawing.Size(196, 33)
        Me.button_clearFields.TabIndex = 67
        Me.button_clearFields.Text = "Clear Fields"
        Me.button_clearFields.UseVisualStyleBackColor = True
        '
        'button_add
        '
        Me.button_add.Location = New System.Drawing.Point(712, 56)
        Me.button_add.Name = "button_add"
        Me.button_add.Size = New System.Drawing.Size(195, 38)
        Me.button_add.TabIndex = 66
        Me.button_add.Text = "Add"
        Me.button_add.UseVisualStyleBackColor = True
        '
        'button_update
        '
        Me.button_update.Location = New System.Drawing.Point(712, 109)
        Me.button_update.Name = "button_update"
        Me.button_update.Size = New System.Drawing.Size(195, 38)
        Me.button_update.TabIndex = 68
        Me.button_update.Text = "Update"
        Me.button_update.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage2.Controls.Add(Me.applyGroup)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.prodInfo)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.listBoxProducts)
        Me.TabPage2.Controls.Add(Me.buttonDelete)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.buttonApplyDiscount)
        Me.TabPage2.Controls.Add(Me.buttonUpdate)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1167, 617)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Apply Discount"
        '
        'applyGroup
        '
        Me.applyGroup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.applyGroup.Controls.Add(Me.txtDiscountID)
        Me.applyGroup.Controls.Add(Me.Label4)
        Me.applyGroup.Controls.Add(Me.Label3)
        Me.applyGroup.Controls.Add(Me.comboBoxDiscounts)
        Me.applyGroup.Controls.Add(Me.txtBoxCurrentSelect)
        Me.applyGroup.Controls.Add(Me.Label12)
        Me.applyGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applyGroup.Location = New System.Drawing.Point(8, 289)
        Me.applyGroup.Name = "applyGroup"
        Me.applyGroup.Size = New System.Drawing.Size(451, 202)
        Me.applyGroup.TabIndex = 85
        Me.applyGroup.TabStop = False
        Me.applyGroup.Text = "Apply Discount Details"
        '
        'txtDiscountID
        '
        Me.txtDiscountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountID.Location = New System.Drawing.Point(97, 147)
        Me.txtDiscountID.Name = "txtDiscountID"
        Me.txtDiscountID.Size = New System.Drawing.Size(348, 26)
        Me.txtDiscountID.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Discount ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(14, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Discount"
        '
        'comboBoxDiscounts
        '
        Me.comboBoxDiscounts.FormattingEnabled = True
        Me.comboBoxDiscounts.Location = New System.Drawing.Point(97, 108)
        Me.comboBoxDiscounts.Name = "comboBoxDiscounts"
        Me.comboBoxDiscounts.Size = New System.Drawing.Size(348, 28)
        Me.comboBoxDiscounts.TabIndex = 68
        '
        'txtBoxCurrentSelect
        '
        Me.txtBoxCurrentSelect.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtBoxCurrentSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCurrentSelect.ForeColor = System.Drawing.Color.Red
        Me.txtBoxCurrentSelect.Location = New System.Drawing.Point(272, 35)
        Me.txtBoxCurrentSelect.Name = "txtBoxCurrentSelect"
        Me.txtBoxCurrentSelect.Size = New System.Drawing.Size(173, 38)
        Me.txtBoxCurrentSelect.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(6, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(260, 24)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Currently Selected Product"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(583, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 20)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Applied Discount Table"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView2.Location = New System.Drawing.Point(587, 289)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(577, 251)
        Me.DataGridView2.TabIndex = 83
        '
        'prodInfo
        '
        Me.prodInfo.Controls.Add(Me.Label16)
        Me.prodInfo.Controls.Add(Me.txtBoxPartPrice)
        Me.prodInfo.Controls.Add(Me.Label17)
        Me.prodInfo.Controls.Add(Me.txtBoxPartName)
        Me.prodInfo.Controls.Add(Me.Label18)
        Me.prodInfo.Controls.Add(Me.txtBoxProductID)
        Me.prodInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodInfo.Location = New System.Drawing.Point(688, 80)
        Me.prodInfo.Name = "prodInfo"
        Me.prodInfo.Size = New System.Drawing.Size(476, 180)
        Me.prodInfo.TabIndex = 82
        Me.prodInfo.TabStop = False
        Me.prodInfo.Text = "Product Information"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(22, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 16)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "Part Price"
        '
        'txtBoxPartPrice
        '
        Me.txtBoxPartPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPartPrice.Location = New System.Drawing.Point(139, 126)
        Me.txtBoxPartPrice.Name = "txtBoxPartPrice"
        Me.txtBoxPartPrice.Size = New System.Drawing.Size(312, 26)
        Me.txtBoxPartPrice.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(22, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Part Name"
        '
        'txtBoxPartName
        '
        Me.txtBoxPartName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPartName.Location = New System.Drawing.Point(139, 93)
        Me.txtBoxPartName.Name = "txtBoxPartName"
        Me.txtBoxPartName.Size = New System.Drawing.Size(312, 26)
        Me.txtBoxPartName.TabIndex = 61
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(22, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 16)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "ID"
        '
        'txtBoxProductID
        '
        Me.txtBoxProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxProductID.Location = New System.Drawing.Point(139, 59)
        Me.txtBoxProductID.Name = "txtBoxProductID"
        Me.txtBoxProductID.Size = New System.Drawing.Size(312, 26)
        Me.txtBoxProductID.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(4, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 20)
        Me.Label19.TabIndex = 81
        Me.Label19.Text = "Parts/Product List"
        '
        'listBoxProducts
        '
        Me.listBoxProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxProducts.FormattingEnabled = True
        Me.listBoxProducts.ItemHeight = 16
        Me.listBoxProducts.Location = New System.Drawing.Point(4, 80)
        Me.listBoxProducts.Name = "listBoxProducts"
        Me.listBoxProducts.ScrollAlwaysVisible = True
        Me.listBoxProducts.Size = New System.Drawing.Size(678, 180)
        Me.listBoxProducts.TabIndex = 80
        '
        'buttonDelete
        '
        Me.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonDelete.Location = New System.Drawing.Point(461, 420)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(120, 38)
        Me.buttonDelete.TabIndex = 79
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(6, 497)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(451, 33)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Clear Fields"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'buttonApplyDiscount
        '
        Me.buttonApplyDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonApplyDiscount.Location = New System.Drawing.Point(461, 289)
        Me.buttonApplyDiscount.Name = "buttonApplyDiscount"
        Me.buttonApplyDiscount.Size = New System.Drawing.Size(120, 38)
        Me.buttonApplyDiscount.TabIndex = 76
        Me.buttonApplyDiscount.Text = "Apply Discount"
        Me.buttonApplyDiscount.UseVisualStyleBackColor = True
        '
        'buttonUpdate
        '
        Me.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.buttonUpdate.Location = New System.Drawing.Point(461, 372)
        Me.buttonUpdate.Name = "buttonUpdate"
        Me.buttonUpdate.Size = New System.Drawing.Size(120, 38)
        Me.buttonUpdate.TabIndex = 78
        Me.buttonUpdate.Text = "Update"
        Me.buttonUpdate.UseVisualStyleBackColor = True
        '
        'Discounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Discounts"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.discountAddGroup.ResumeLayout(False)
        Me.discountAddGroup.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.applyGroup.ResumeLayout(False)
        Me.applyGroup.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.prodInfo.ResumeLayout(False)
        Me.prodInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents discountAddGroup As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBox_name As TextBox
    Friend WithEvents buttonGenerate_id_id As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBox_discountValue As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBox_discountID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents button_delete As Button
    Friend WithEvents button_clearFields As Button
    Friend WithEvents button_add As Button
    Friend WithEvents button_update As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents applyGroup As GroupBox
    Friend WithEvents txtBoxCurrentSelect As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents prodInfo As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBoxPartPrice As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBoxPartName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBoxProductID As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents listBoxProducts As ListBox
    Friend WithEvents buttonDelete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents buttonApplyDiscount As Button
    Friend WithEvents buttonUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboBoxDiscounts As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiscountID As TextBox
End Class
