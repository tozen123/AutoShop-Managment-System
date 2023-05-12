<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBoxCustomers = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.gp_cDetails = New System.Windows.Forms.GroupBox()
        Me.txtBox__customerId = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_inquireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBox_vehicle_id = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gp_cInfo = New System.Windows.Forms.GroupBox()
        Me.txtBox_customer_addr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBox_lname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBox_MidName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBox_fname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_clearFields = New System.Windows.Forms.Button()
        Me.btn_AddFinish = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBox_quantity = New System.Windows.Forms.TextBox()
        Me.listBox_partsproductlist = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBox_partsProductId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBox_PartPrice = New System.Windows.Forms.TextBox()
        Me.button_AddToPurchase = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.button_resetAll = New System.Windows.Forms.Button()
        Me.button_deletetopurchase = New System.Windows.Forms.Button()
        Me.dataGridViewPurchase = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBox_totalCast = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCustomerInformation.SuspendLayout()
        Me.gp_cDetails.SuspendLayout()
        Me.gp_cInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataGridViewPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(94, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 55)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Purchase Transaction"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-13, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1219, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Customer Record List"
        '
        'listBoxCustomers
        '
        Me.listBoxCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxCustomers.FormattingEnabled = True
        Me.listBoxCustomers.ItemHeight = 20
        Me.listBoxCustomers.Location = New System.Drawing.Point(12, 141)
        Me.listBoxCustomers.Name = "listBoxCustomers"
        Me.listBoxCustomers.Size = New System.Drawing.Size(285, 224)
        Me.listBoxCustomers.TabIndex = 57
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-13, 738)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1219, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'gpCustomerInformation
        '
        Me.gpCustomerInformation.Controls.Add(Me.gp_cDetails)
        Me.gpCustomerInformation.Controls.Add(Me.gp_cInfo)
        Me.gpCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCustomerInformation.Location = New System.Drawing.Point(317, 114)
        Me.gpCustomerInformation.Name = "gpCustomerInformation"
        Me.gpCustomerInformation.Size = New System.Drawing.Size(855, 251)
        Me.gpCustomerInformation.TabIndex = 59
        Me.gpCustomerInformation.TabStop = False
        Me.gpCustomerInformation.Text = "Customer"
        '
        'gp_cDetails
        '
        Me.gp_cDetails.Controls.Add(Me.txtBox__customerId)
        Me.gp_cDetails.Controls.Add(Me.Label13)
        Me.gp_cDetails.Controls.Add(Me.dtp_inquireDate)
        Me.gp_cDetails.Controls.Add(Me.Label14)
        Me.gp_cDetails.Controls.Add(Me.txtBox_vehicle_id)
        Me.gp_cDetails.Controls.Add(Me.Label15)
        Me.gp_cDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_cDetails.Location = New System.Drawing.Point(441, 30)
        Me.gp_cDetails.Name = "gp_cDetails"
        Me.gp_cDetails.Size = New System.Drawing.Size(392, 215)
        Me.gp_cDetails.TabIndex = 45
        Me.gp_cDetails.TabStop = False
        Me.gp_cDetails.Text = "Details"
        '
        'txtBox__customerId
        '
        Me.txtBox__customerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox__customerId.Location = New System.Drawing.Point(115, 45)
        Me.txtBox__customerId.Name = "txtBox__customerId"
        Me.txtBox__customerId.Size = New System.Drawing.Size(264, 24)
        Me.txtBox__customerId.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 18)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "ID"
        '
        'dtp_inquireDate
        '
        Me.dtp_inquireDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inquireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inquireDate.Location = New System.Drawing.Point(115, 166)
        Me.dtp_inquireDate.Name = "dtp_inquireDate"
        Me.dtp_inquireDate.Size = New System.Drawing.Size(264, 24)
        Me.dtp_inquireDate.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Inquire Date"
        '
        'txtBox_vehicle_id
        '
        Me.txtBox_vehicle_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_vehicle_id.Location = New System.Drawing.Point(115, 108)
        Me.txtBox_vehicle_id.Name = "txtBox_vehicle_id"
        Me.txtBox_vehicle_id.Size = New System.Drawing.Size(264, 24)
        Me.txtBox_vehicle_id.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 18)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Vehicle ID"
        '
        'gp_cInfo
        '
        Me.gp_cInfo.Controls.Add(Me.txtBox_customer_addr)
        Me.gp_cInfo.Controls.Add(Me.Label4)
        Me.gp_cInfo.Controls.Add(Me.txtBox_lname)
        Me.gp_cInfo.Controls.Add(Me.Label5)
        Me.gp_cInfo.Controls.Add(Me.txtBox_MidName)
        Me.gp_cInfo.Controls.Add(Me.Label7)
        Me.gp_cInfo.Controls.Add(Me.txtBox_fname)
        Me.gp_cInfo.Controls.Add(Me.Label12)
        Me.gp_cInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_cInfo.Location = New System.Drawing.Point(39, 30)
        Me.gp_cInfo.Name = "gp_cInfo"
        Me.gp_cInfo.Size = New System.Drawing.Size(385, 215)
        Me.gp_cInfo.TabIndex = 44
        Me.gp_cInfo.TabStop = False
        Me.gp_cInfo.Text = "Information"
        '
        'txtBox_customer_addr
        '
        Me.txtBox_customer_addr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_customer_addr.Location = New System.Drawing.Point(126, 169)
        Me.txtBox_customer_addr.Name = "txtBox_customer_addr"
        Me.txtBox_customer_addr.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_customer_addr.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Address"
        '
        'txtBox_lname
        '
        Me.txtBox_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_lname.Location = New System.Drawing.Point(126, 124)
        Me.txtBox_lname.Name = "txtBox_lname"
        Me.txtBox_lname.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_lname.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Last Name"
        '
        'txtBox_MidName
        '
        Me.txtBox_MidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_MidName.Location = New System.Drawing.Point(126, 80)
        Me.txtBox_MidName.Name = "txtBox_MidName"
        Me.txtBox_MidName.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_MidName.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Middle Name"
        '
        'txtBox_fname
        '
        Me.txtBox_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_fname.Location = New System.Drawing.Point(126, 34)
        Me.txtBox_fname.Name = "txtBox_fname"
        Me.txtBox_fname.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_fname.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "First Name"
        '
        'btn_clearFields
        '
        Me.btn_clearFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearFields.Location = New System.Drawing.Point(12, 669)
        Me.btn_clearFields.Name = "btn_clearFields"
        Me.btn_clearFields.Size = New System.Drawing.Size(315, 52)
        Me.btn_clearFields.TabIndex = 64
        Me.btn_clearFields.Text = "Clear Fields"
        Me.btn_clearFields.UseVisualStyleBackColor = True
        '
        'btn_AddFinish
        '
        Me.btn_AddFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddFinish.Location = New System.Drawing.Point(641, 674)
        Me.btn_AddFinish.Name = "btn_AddFinish"
        Me.btn_AddFinish.Size = New System.Drawing.Size(197, 47)
        Me.btn_AddFinish.TabIndex = 62
        Me.btn_AddFinish.Text = "Finish"
        Me.btn_AddFinish.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Quantity"
        '
        'txtBox_quantity
        '
        Me.txtBox_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_quantity.Location = New System.Drawing.Point(407, 108)
        Me.txtBox_quantity.Name = "txtBox_quantity"
        Me.txtBox_quantity.Size = New System.Drawing.Size(195, 24)
        Me.txtBox_quantity.TabIndex = 38
        '
        'listBox_partsproductlist
        '
        Me.listBox_partsproductlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBox_partsproductlist.FormattingEnabled = True
        Me.listBox_partsproductlist.ItemHeight = 16
        Me.listBox_partsproductlist.Location = New System.Drawing.Point(25, 48)
        Me.listBox_partsproductlist.Name = "listBox_partsproductlist"
        Me.listBox_partsproductlist.Size = New System.Drawing.Size(260, 212)
        Me.listBox_partsproductlist.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Parts/Product List"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(292, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Part/Product ID"
        '
        'txtBox_partsProductId
        '
        Me.txtBox_partsProductId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_partsProductId.Location = New System.Drawing.Point(407, 48)
        Me.txtBox_partsProductId.Name = "txtBox_partsProductId"
        Me.txtBox_partsProductId.Size = New System.Drawing.Size(195, 24)
        Me.txtBox_partsProductId.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBox_PartPrice)
        Me.GroupBox1.Controls.Add(Me.button_AddToPurchase)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBox_partsProductId)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.listBox_partsproductlist)
        Me.GroupBox1.Controls.Add(Me.txtBox_quantity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 292)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase"
        '
        'txtBox_PartPrice
        '
        Me.txtBox_PartPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_PartPrice.Location = New System.Drawing.Point(407, 78)
        Me.txtBox_PartPrice.Name = "txtBox_PartPrice"
        Me.txtBox_PartPrice.Size = New System.Drawing.Size(195, 24)
        Me.txtBox_PartPrice.TabIndex = 47
        '
        'button_AddToPurchase
        '
        Me.button_AddToPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_AddToPurchase.Location = New System.Drawing.Point(295, 227)
        Me.button_AddToPurchase.Name = "button_AddToPurchase"
        Me.button_AddToPurchase.Size = New System.Drawing.Size(307, 33)
        Me.button_AddToPurchase.TabIndex = 70
        Me.button_AddToPurchase.Text = "Add"
        Me.button_AddToPurchase.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 18)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Part Price"
        '
        'button_resetAll
        '
        Me.button_resetAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_resetAll.Location = New System.Drawing.Point(1023, 674)
        Me.button_resetAll.Name = "button_resetAll"
        Me.button_resetAll.Size = New System.Drawing.Size(149, 47)
        Me.button_resetAll.TabIndex = 65
        Me.button_resetAll.Text = "Reset All Purchases"
        Me.button_resetAll.UseVisualStyleBackColor = True
        '
        'button_deletetopurchase
        '
        Me.button_deletetopurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_deletetopurchase.Location = New System.Drawing.Point(909, 674)
        Me.button_deletetopurchase.Name = "button_deletetopurchase"
        Me.button_deletetopurchase.Size = New System.Drawing.Size(108, 47)
        Me.button_deletetopurchase.TabIndex = 71
        Me.button_deletetopurchase.Text = "Delete"
        Me.button_deletetopurchase.UseVisualStyleBackColor = True
        '
        'dataGridViewPurchase
        '
        Me.dataGridViewPurchase.AllowUserToAddRows = False
        Me.dataGridViewPurchase.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPurchase.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewPurchase.Location = New System.Drawing.Point(641, 392)
        Me.dataGridViewPurchase.Name = "dataGridViewPurchase"
        Me.dataGridViewPurchase.ReadOnly = True
        Me.dataGridViewPurchase.Size = New System.Drawing.Size(531, 216)
        Me.dataGridViewPurchase.TabIndex = 69
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'txtBox_totalCast
        '
        Me.txtBox_totalCast.BackColor = System.Drawing.Color.PaleGreen
        Me.txtBox_totalCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_totalCast.Location = New System.Drawing.Point(775, 614)
        Me.txtBox_totalCast.Name = "txtBox_totalCast"
        Me.txtBox_totalCast.Size = New System.Drawing.Size(301, 49)
        Me.txtBox_totalCast.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(652, 637)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Total Cost"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(641, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 18)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Check Out Table"
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.button_deletetopurchase)
        Me.Controls.Add(Me.dataGridViewPurchase)
        Me.Controls.Add(Me.txtBox_totalCast)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.button_resetAll)
        Me.Controls.Add(Me.btn_clearFields)
        Me.Controls.Add(Me.btn_AddFinish)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpCustomerInformation)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listBoxCustomers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCustomerInformation.ResumeLayout(False)
        Me.gp_cDetails.ResumeLayout(False)
        Me.gp_cDetails.PerformLayout()
        Me.gp_cInfo.ResumeLayout(False)
        Me.gp_cInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataGridViewPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents Label1 As Label
    Friend WithEvents listBoxCustomers As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gpCustomerInformation As GroupBox
    Friend WithEvents gp_cDetails As GroupBox
    Friend WithEvents txtBox__customerId As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtp_inquireDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBox_vehicle_id As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents gp_cInfo As GroupBox
    Friend WithEvents txtBox_customer_addr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBox_lname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBox_MidName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBox_fname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_clearFields As Button
    Friend WithEvents btn_AddFinish As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBox_quantity As TextBox
    Friend WithEvents listBox_partsproductlist As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBox_partsProductId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBox_PartPrice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents button_resetAll As Button
    Friend WithEvents button_AddToPurchase As Button
    Friend WithEvents button_deletetopurchase As Button
    Friend WithEvents dataGridViewPurchase As DataGridView
    Friend WithEvents txtBox_totalCast As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
End Class
