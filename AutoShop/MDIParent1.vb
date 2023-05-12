Imports System.Windows.Forms

Public Class MDIParent1
    Dim AvailForm As New Avails()
    Dim CustomerForm As New Customer()
    Dim DiscountsForm As New Discounts()
    Dim EmployeeForm As New Employees()
    Dim PartsProductForm As New PartsProducts()
    Dim PurchaseRecordForm As New PurchaseRecords()
    Dim PurchaseForm As New Purchase()
    Dim ServiceForm As New Service()
    Dim ServiceRecordsForm As New Service()
    Dim SuppliersForm As New ServiceRecords()
    Dim UsesForm As New Uses()

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

  
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer



    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()



        Dim Employees As New Employees()

        Employees.MdiParent = Me
        Employees.StartPosition = FormStartPosition.Manual

        Employees.Show()

        disableHeader()
    End Sub


    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click

        AvailForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim Customer As New Customer()

        Customer.MdiParent = Me
        Customer.StartPosition = FormStartPosition.Manual

        Customer.Show()

        disableHeader()
    End Sub

    Public Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        AvailForm.Hide()
        CustomerForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()
        Dim Discounts As New Discounts()

        Discounts.MdiParent = Me
        Discounts.StartPosition = FormStartPosition.Manual

        Discounts.Show()

        disableHeader()
    End Sub

    Private Sub PartsProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsProductsToolStripMenuItem.Click
        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()

        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()
        Dim PartsProducts As New PartsProducts()

        PartsProducts.MdiParent = Me
        PartsProducts.StartPosition = FormStartPosition.Manual

        PartsProducts.Show()

        disableHeader()
    End Sub

    Private Sub AvailServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailServiceToolStripMenuItem.Click


        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()


        Dim Avails As New Avails()

        Avails.MdiParent = Me
        Avails.StartPosition = FormStartPosition.Manual

        Avails.Show()

        disableHeader()
    End Sub


    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click

        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim Purchase As New Purchase()

        Purchase.MdiParent = Me
        Purchase.StartPosition = FormStartPosition.Manual

        Purchase.Show()

        disableHeader()
    End Sub

    Private Sub disableHeader()
        label_header.Visible = False
    End Sub


    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click

        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim Suppliers As New Suppliers()

        Suppliers.MdiParent = Me
        Suppliers.StartPosition = FormStartPosition.Manual

        Suppliers.Show()

        disableHeader()
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem.Click

        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim ServiceRecords As New ServiceRecords()

        ServiceRecords.MdiParent = Me
        ServiceRecords.StartPosition = FormStartPosition.Manual

        ServiceRecords.Show()

        disableHeader()
    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click

        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseForm.Hide()
        ServiceForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim PurchaseRecords As New PurchaseRecords()

        PurchaseRecords.MdiParent = Me
        PurchaseRecords.StartPosition = FormStartPosition.Manual

        PurchaseRecords.Show()

        disableHeader()
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click

        AvailForm.Hide()
        CustomerForm.Hide()
        DiscountsForm.Hide()
        PartsProductForm.Hide()
        PurchaseRecordForm.Hide()
        PurchaseForm.Hide()
        ServiceRecordsForm.Hide()
        SuppliersForm.Hide()
        UsesForm.Hide()
        EmployeeForm.Hide()

        Dim Service As New Service()

        Service.MdiParent = Me
        Service.StartPosition = FormStartPosition.Manual

        Service.Show()

        disableHeader()
    End Sub


End Class
