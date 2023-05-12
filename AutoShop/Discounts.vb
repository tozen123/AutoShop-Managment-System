Public Class Discounts
    Dim dataTable As New DataTable()
    Dim dataTable2 As New DataTable()
    Dim current_discountID As String
    Private Sub Discounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_add.Enabled = False
        button_delete.Enabled = False
        button_update.Enabled = False
        button_clearFields.Enabled = False

        txtBox_discountValue.Enabled = False
        txtBox_name.Enabled = False

        comboBoxDiscounts.Enabled = False
        DataGridView1.DataSource = dataTable
        txtBoxCurrentSelect.Enabled = False
        prodInfo.Enabled = False

        applyGroup.Enabled = False

        buttonApplyDiscount.Enabled = False
        buttonDelete.Enabled = False
        buttonUpdate.Enabled = False
        LoadAppliedDiscounts()
        loadDiscounts()
        LoadListBoxProducts()
        LoadComboBoxDiscounts()

    End Sub

    Public Sub LoadAppliedDiscounts()
        Dim Str As String
        Str = "SELECT * FROM `applies`"
        Try
            readqueary(Str)
            For i As Integer = 0 To cmdread.FieldCount - 1
                Dim columnName As String = cmdread.GetName(i)
                dataTable2.Columns.Add(columnName, cmdread.GetFieldType(i))
            Next
            While cmdread.Read
                Dim row As DataRow = dataTable2.NewRow()
                For i As Integer = 0 To cmdread.FieldCount - 1
                    row(i) = cmdread(i)
                Next
                dataTable2.Rows.Add(row)
            End While

            DataGridView2.DataSource = dataTable2
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Sub LoadComboBoxDiscounts()
        Dim str As String
        str = "SELECT `discount_id`, `discount_value`, `discount_part_name` FROM `discount`"
        Try
            readqueary(str)

            With cmdread
                While .Read
                    comboBoxDiscounts.Items.Add(.GetValue(1))
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub
    Public Sub LoadListBoxProducts()
        Dim str As String
        str = "SELECT `id`, `name`, `price` FROM `parts_products`"
        Try
            readqueary(str)

            With cmdread
                While .Read
                    listBoxProducts.Items.Add(.GetValue(1))
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub
    Public Sub loadDiscounts()
        Dim Str As String
        Str = "SELECT * FROM `discount`"
        Try
            readqueary(Str)
            DataGridView1.DataSource = Nothing
            dataTable.Clear()
            For i As Integer = 0 To cmdread.FieldCount - 1
                Dim columnName As String = cmdread.GetName(i)
                If columnName = "discount_id" Then
                    dataTable.Columns.Add("ID", cmdread.GetFieldType(i))
                Else
                    dataTable.Columns.Add(columnName, cmdread.GetFieldType(i))
                End If
            Next
            While cmdread.Read
                Dim row As DataRow = dataTable.NewRow()
                For i As Integer = 0 To cmdread.FieldCount - 1
                    row(i) = cmdread(i)
                Next
                dataTable.Rows.Add(row)
            End While

            DataGridView1.DataSource = dataTable
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
        End Try
    End Sub



    Private Sub txtBox_discountID_TextChanged(sender As Object, e As EventArgs) Handles txtBox_discountID.TextChanged
        txtBox_discountValue.Enabled = True
    End Sub

    Private Sub txtBox_discountValue_TextChanged(sender As Object, e As EventArgs) Handles txtBox_discountValue.TextChanged
        txtBox_name.Enabled = True
    End Sub

    Private Sub txtBox_name_TextChanged(sender As Object, e As EventArgs) Handles txtBox_name.TextChanged
        button_add.Enabled = True
        button_delete.Enabled = True
        button_update.Enabled = True
    End Sub

    Private Sub buttonGenerate_id_id_Click(sender As Object, e As EventArgs) Handles buttonGenerate_id_id.Click
        'Generate ID Button'

        Dim command As String
        Dim resultsID As New List(Of Integer)

        Dim random As New Random()
        Dim randomInt As Integer = random.Next(999999999)

        command = "SELECT discount_id  FROM `discount`"
        Try
            readqueary(command)
            With cmdread
                While .Read
                    resultsID.Add(.GetInt32(0))
                End While
            End With
        Catch ex As Exception

        End Try

        If Not resultsID.Contains(randomInt) Then
            txtBox_discountID.Text = randomInt
        End If
    End Sub

    Private Sub button_add_Click(sender As Object, e As EventArgs) Handles button_add.Click
        Dim command As String
        command = "INSERT INTO discount (`discount_id`, `discount_value`, `discount_part_name`) " &
            " VALUES ('" & txtBox_discountID.Text & "', '" & txtBox_discountValue.Text & "', '" & txtBox_name.Text & "')"
        Try

            readqueary(command)
            MsgBox("New record has been successfully added")
            loadDiscounts()
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub listBoxProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxProducts.SelectedIndexChanged

        Dim command As String
        If listBoxProducts.SelectedItems.Count > 0 Then
            command = "SELECT `id`, `name`, `price` FROM `parts_products` WHERE name='" & listBoxProducts.SelectedItem.ToString & "'"
            prodInfo.Enabled = True
            txtBoxProductID.Enabled = False
            txtBoxPartName.Enabled = False
            txtBoxPartPrice.Enabled = False

            applyGroup.Enabled = True

            Try
                readqueary(command)
                With cmdread
                    While .Read
                        txtBoxProductID.Text = .GetValue(0)
                        txtBoxPartName.Text = .GetValue(1)
                        txtBoxPartPrice.Text = .GetValue(2)
                    End While
                End With
                txtBoxCurrentSelect.Text = txtBoxPartName.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBoxCurrentSelect_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCurrentSelect.TextChanged

        comboBoxDiscounts.Enabled = True
    End Sub

    Private Sub comboBoxDiscounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxDiscounts.SelectedIndexChanged
        buttonApplyDiscount.Enabled = True
        buttonDelete.Enabled = True
        buttonUpdate.Enabled = True

        Dim selectedItem As Object = comboBoxDiscounts.SelectedItem
        If selectedItem IsNot Nothing Then


            Dim str As String
            str = "SELECT `discount_id`, `discount_value`, `discount_part_name` FROM `discount` WHERE discount_value= '" & selectedItem & "'"
            Try
                readqueary(str)
                With cmdread
                    While .Read
                        txtDiscountID.Text = .GetValue(0)
                    End While
                End With

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click

    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click

    End Sub

    Public Sub buttonApplyDiscount_Click(sender As Object, e As EventArgs) Handles buttonApplyDiscount.Click
        Dim str As String
        Dim currentDate As DateTime = DateTime.Today
        str = "INSERT INTO applies (`amount`, `date`, `discount_id`, `parts_product_id`) " &
            " VALUES ('" & comboBoxDiscounts.SelectedItem & "', '" & currentDate.ToString("yyyy-MM-dd") & "', '" & txtDiscountID.Text & "', '" & txtBoxProductID.Text & "')"
        Try

            readqueary(str)
            MsgBox("New record has been successfully added")
            loadDiscounts()
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub button_update_Click(sender As Object, e As EventArgs) Handles button_update.Click
        Dim command As String
        command = " UPDATE `discount` SET `discount_value`='" & txtBox_discountValue.Text & "',`discount_part_name`='" & txtBox_name.Text & "' WHERE `discount_id`='" & current_discountID & "'"


        Try

            readqueary(command)
            MsgBox("New record has been successfully updated")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

        current_discountID = selectedRow.Cells("ID").Value.ToString()

        Dim str As String
        str = "SELECT `discount_id`, `discount_value`, `discount_part_name` FROM `discount` WHERE discount_id= '" & current_discountID.ToString() & "'"
        Try
            readqueary(str)
            With cmdread
                While .Read
                    txtBox_discountID.Text = .GetValue(0)
                    txtBox_discountValue.Text = .GetValue(1)
                    txtBox_name.Text = .GetValue(2)
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click
        Dim command As String

        command = "DELETE FROM discount WHERE discount_id='" & current_discountID.ToString() & "'"
        Try
            readqueary(command)
            MsgBox("New record has been successfully deleted")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class