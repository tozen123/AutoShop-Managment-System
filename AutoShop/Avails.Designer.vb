<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Avails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avails))
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_clearFields = New System.Windows.Forms.Button()
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
        Me.gp_serviceDetail = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cb_employeeList = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_discRemove = New System.Windows.Forms.Button()
        Me.txtBox_note = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtp_AvailDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_partDiscount = New System.Windows.Forms.ComboBox()
        Me.cb_serviceType = New System.Windows.Forms.ComboBox()
        Me.txtBox_discValue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBox_fee = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBox_totalFee = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.listBoxCustomers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.gpCustomerInformation.SuspendLayout()
        Me.gp_cDetails.SuspendLayout()
        Me.gp_cInfo.SuspendLayout()
        Me.gp_serviceDetail.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Add
        '
        Me.btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Location = New System.Drawing.Point(893, 489)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(279, 111)
        Me.btn_Add.TabIndex = 36
        Me.btn_Add.Text = "Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_clearFields
        '
        Me.btn_clearFields.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearFields.Location = New System.Drawing.Point(893, 620)
        Me.btn_clearFields.Name = "btn_clearFields"
        Me.btn_clearFields.Size = New System.Drawing.Size(279, 107)
        Me.btn_clearFields.TabIndex = 39
        Me.btn_clearFields.Text = "Clear Fields"
        Me.btn_clearFields.UseVisualStyleBackColor = True
        '
        'gpCustomerInformation
        '
        Me.gpCustomerInformation.Controls.Add(Me.gp_cDetails)
        Me.gpCustomerInformation.Controls.Add(Me.gp_cInfo)
        Me.gpCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpCustomerInformation.Location = New System.Drawing.Point(317, 116)
        Me.gpCustomerInformation.Name = "gpCustomerInformation"
        Me.gpCustomerInformation.Size = New System.Drawing.Size(855, 194)
        Me.gpCustomerInformation.TabIndex = 45
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
        Me.gp_cDetails.Size = New System.Drawing.Size(392, 158)
        Me.gp_cDetails.TabIndex = 45
        Me.gp_cDetails.TabStop = False
        Me.gp_cDetails.Text = "Details"
        '
        'txtBox__customerId
        '
        Me.txtBox__customerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox__customerId.Location = New System.Drawing.Point(113, 31)
        Me.txtBox__customerId.Name = "txtBox__customerId"
        Me.txtBox__customerId.Size = New System.Drawing.Size(264, 24)
        Me.txtBox__customerId.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 18)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "ID"
        '
        'dtp_inquireDate
        '
        Me.dtp_inquireDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inquireDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inquireDate.Location = New System.Drawing.Point(113, 91)
        Me.dtp_inquireDate.Name = "dtp_inquireDate"
        Me.dtp_inquireDate.Size = New System.Drawing.Size(264, 24)
        Me.dtp_inquireDate.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Inquire Date"
        '
        'txtBox_vehicle_id
        '
        Me.txtBox_vehicle_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_vehicle_id.Location = New System.Drawing.Point(113, 61)
        Me.txtBox_vehicle_id.Name = "txtBox_vehicle_id"
        Me.txtBox_vehicle_id.Size = New System.Drawing.Size(264, 24)
        Me.txtBox_vehicle_id.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 64)
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
        Me.gp_cInfo.Size = New System.Drawing.Size(385, 158)
        Me.gp_cInfo.TabIndex = 44
        Me.gp_cInfo.TabStop = False
        Me.gp_cInfo.Text = "Information"
        '
        'txtBox_customer_addr
        '
        Me.txtBox_customer_addr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_customer_addr.Location = New System.Drawing.Point(126, 124)
        Me.txtBox_customer_addr.Name = "txtBox_customer_addr"
        Me.txtBox_customer_addr.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_customer_addr.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Address"
        '
        'txtBox_lname
        '
        Me.txtBox_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_lname.Location = New System.Drawing.Point(126, 94)
        Me.txtBox_lname.Name = "txtBox_lname"
        Me.txtBox_lname.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_lname.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Last Name"
        '
        'txtBox_MidName
        '
        Me.txtBox_MidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_MidName.Location = New System.Drawing.Point(126, 64)
        Me.txtBox_MidName.Name = "txtBox_MidName"
        Me.txtBox_MidName.Size = New System.Drawing.Size(229, 24)
        Me.txtBox_MidName.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 67)
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
        'gp_serviceDetail
        '
        Me.gp_serviceDetail.Controls.Add(Me.Label18)
        Me.gp_serviceDetail.Controls.Add(Me.cb_employeeList)
        Me.gp_serviceDetail.Controls.Add(Me.Label17)
        Me.gp_serviceDetail.Controls.Add(Me.btn_discRemove)
        Me.gp_serviceDetail.Controls.Add(Me.txtBox_note)
        Me.gp_serviceDetail.Controls.Add(Me.Label16)
        Me.gp_serviceDetail.Controls.Add(Me.dtp_AvailDate)
        Me.gp_serviceDetail.Controls.Add(Me.Label3)
        Me.gp_serviceDetail.Controls.Add(Me.cbo_partDiscount)
        Me.gp_serviceDetail.Controls.Add(Me.cb_serviceType)
        Me.gp_serviceDetail.Controls.Add(Me.txtBox_discValue)
        Me.gp_serviceDetail.Controls.Add(Me.Label10)
        Me.gp_serviceDetail.Controls.Add(Me.Label9)
        Me.gp_serviceDetail.Controls.Add(Me.txtBox_fee)
        Me.gp_serviceDetail.Controls.Add(Me.Label8)
        Me.gp_serviceDetail.Controls.Add(Me.Label6)
        Me.gp_serviceDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gp_serviceDetail.Location = New System.Drawing.Point(317, 316)
        Me.gp_serviceDetail.Name = "gp_serviceDetail"
        Me.gp_serviceDetail.Size = New System.Drawing.Size(567, 411)
        Me.gp_serviceDetail.TabIndex = 46
        Me.gp_serviceDetail.TabStop = False
        Me.gp_serviceDetail.Text = "Inquire Service Detail"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(36, 191)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 18)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Parts/Product Usage"
        '
        'cb_employeeList
        '
        Me.cb_employeeList.FormattingEnabled = True
        Me.cb_employeeList.Location = New System.Drawing.Point(176, 112)
        Me.cb_employeeList.Name = "cb_employeeList"
        Me.cb_employeeList.Size = New System.Drawing.Size(279, 33)
        Me.cb_employeeList.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 18)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Employee"
        '
        'btn_discRemove
        '
        Me.btn_discRemove.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_discRemove.Location = New System.Drawing.Point(462, 229)
        Me.btn_discRemove.Name = "btn_discRemove"
        Me.btn_discRemove.Size = New System.Drawing.Size(43, 33)
        Me.btn_discRemove.TabIndex = 48
        Me.btn_discRemove.Text = "X"
        Me.btn_discRemove.UseVisualStyleBackColor = True
        '
        'txtBox_note
        '
        Me.txtBox_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_note.Location = New System.Drawing.Point(176, 330)
        Me.txtBox_note.Multiline = True
        Me.txtBox_note.Name = "txtBox_note"
        Me.txtBox_note.Size = New System.Drawing.Size(279, 75)
        Me.txtBox_note.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 353)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 18)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Note"
        '
        'dtp_AvailDate
        '
        Me.dtp_AvailDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_AvailDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_AvailDate.Location = New System.Drawing.Point(176, 30)
        Me.dtp_AvailDate.Name = "dtp_AvailDate"
        Me.dtp_AvailDate.Size = New System.Drawing.Size(279, 24)
        Me.dtp_AvailDate.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Avail Date"
        '
        'cbo_partDiscount
        '
        Me.cbo_partDiscount.FormattingEnabled = True
        Me.cbo_partDiscount.Location = New System.Drawing.Point(226, 229)
        Me.cbo_partDiscount.Name = "cbo_partDiscount"
        Me.cbo_partDiscount.Size = New System.Drawing.Size(229, 33)
        Me.cbo_partDiscount.TabIndex = 47
        '
        'cb_serviceType
        '
        Me.cb_serviceType.FormattingEnabled = True
        Me.cb_serviceType.Items.AddRange(New Object() {"Maintenance", "Repair"})
        Me.cb_serviceType.Location = New System.Drawing.Point(176, 68)
        Me.cb_serviceType.Name = "cb_serviceType"
        Me.cb_serviceType.Size = New System.Drawing.Size(279, 33)
        Me.cb_serviceType.TabIndex = 46
        '
        'txtBox_discValue
        '
        Me.txtBox_discValue.BackColor = System.Drawing.Color.PaleGreen
        Me.txtBox_discValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_discValue.Location = New System.Drawing.Point(226, 269)
        Me.txtBox_discValue.Name = "txtBox_discValue"
        Me.txtBox_discValue.Size = New System.Drawing.Size(279, 24)
        Me.txtBox_discValue.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 18)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Discount Value (%)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(67, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Part/Product Discount"
        '
        'txtBox_fee
        '
        Me.txtBox_fee.BackColor = System.Drawing.Color.PaleGreen
        Me.txtBox_fee.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_fee.Location = New System.Drawing.Point(176, 152)
        Me.txtBox_fee.Name = "txtBox_fee"
        Me.txtBox_fee.Size = New System.Drawing.Size(279, 24)
        Me.txtBox_fee.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 18)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Labor Fee"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Type"
        '
        'txtBox_totalFee
        '
        Me.txtBox_totalFee.BackColor = System.Drawing.Color.PaleGreen
        Me.txtBox_totalFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_totalFee.Location = New System.Drawing.Point(981, 360)
        Me.txtBox_totalFee.Name = "txtBox_totalFee"
        Me.txtBox_totalFee.Size = New System.Drawing.Size(191, 62)
        Me.txtBox_totalFee.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(890, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 18)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Total Fee"
        '
        'listBoxCustomers
        '
        Me.listBoxCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxCustomers.FormattingEnabled = True
        Me.listBoxCustomers.ItemHeight = 20
        Me.listBoxCustomers.Location = New System.Drawing.Point(12, 143)
        Me.listBoxCustomers.Name = "listBoxCustomers"
        Me.listBoxCustomers.Size = New System.Drawing.Size(285, 584)
        Me.listBoxCustomers.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Customer Record List"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-5, 742)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1219, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(85, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(467, 55)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Service Transaction"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1219, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1076, -40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 63
        Me.PictureBox3.TabStop = False
        '
        'Avails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listBoxCustomers)
        Me.Controls.Add(Me.gp_serviceDetail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBox_totalFee)
        Me.Controls.Add(Me.gpCustomerInformation)
        Me.Controls.Add(Me.btn_clearFields)
        Me.Controls.Add(Me.btn_Add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Avails"
        Me.Text = "Avails"
        Me.gpCustomerInformation.ResumeLayout(False)
        Me.gp_cDetails.ResumeLayout(False)
        Me.gp_cDetails.PerformLayout()
        Me.gp_cInfo.ResumeLayout(False)
        Me.gp_cInfo.PerformLayout()
        Me.gp_serviceDetail.ResumeLayout(False)
        Me.gp_serviceDetail.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_clearFields As Button
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
    Friend WithEvents gp_serviceDetail As GroupBox
    Public WithEvents txtBox_totalFee As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents txtBox_discValue As TextBox
    Public WithEvents Label10 As Label
    Public WithEvents Label9 As Label
    Public WithEvents txtBox_fee As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents Label6 As Label
    Friend WithEvents cb_serviceType As ComboBox
    Friend WithEvents listBoxCustomers As ListBox
    Public WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbo_partDiscount As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtp_AvailDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBox_note As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_discRemove As Button
    Friend WithEvents cb_employeeList As ComboBox
    Public WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Public WithEvents Label18 As Label
End Class
