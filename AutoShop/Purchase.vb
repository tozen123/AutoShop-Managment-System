Public Class Purchase
    Dim partName As String
    Dim totalCost As Integer
    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gp_cDetails.Enabled = False
        gp_cInfo.Enabled = False
        txtBox_totalCast.Enabled = False
        txtBox_partsProductId.Enabled = False
        txtBox_quantity.Enabled = False
        txtBox_PartPrice.Enabled = False

        btn_AddFinish.Enabled = False
        button_AddToPurchase.Enabled = False

        button_deletetopurchase.Enabled = False
        button_resetAll.Enabled = False

        Dim Str As String
        Str = "SELECT customer_first_name, customer_mid_name, customer_last_name FROM customer"
        Try
            readqueary(Str)

            With cmdread
                While .Read
                    listBoxCustomers.Items.Add(.GetValue(0) + " " + .GetValue(1) + " " + .GetValue(2))
                End While
            End With

        Catch ex As Exception
        End Try

        Dim str1 As String
        str1 = "SELECT id, name, price FROM parts_products"
        Try
            readqueary(str1)

            With cmdread
                While .Read
                    listBox_partsproductlist.Items.Add(.GetValue(1) + " , " + " Price: " + " , " + .GetValue(2).ToString())
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub

    Private Sub listBoxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxCustomers.SelectedIndexChanged
        Dim command As String
        If listBoxCustomers.SelectedItems.Count > 0 Then
            command = "SELECT `customer_id`, `customer_first_name`, `customer_mid_name`, `customer_last_name`, `customer_addr`, `customer_vehicle_id`, `customer_inquireDate` FROM `customer` WHERE customer_first_name ='" & listBoxCustomers.SelectedItem.ToString.Split(" ")(0) & "'"
            Try
                readqueary(command)
                With cmdread
                    While .Read
                        txtBox__customerId.Text = .GetValue(0)
                        txtBox_fname.Text = .GetValue(1)
                        txtBox_MidName.Text = .GetValue(2)
                        txtBox_lname.Text = .GetValue(3)
                        txtBox_customer_addr.Text = .GetValue(4)
                        txtBox_vehicle_id.Text = .GetValue(5)
                        dtp_inquireDate.Value = .GetValue(6)
                    End While
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub listBox_partsproductlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_partsproductlist.SelectedIndexChanged


        Dim command As String
        If listBox_partsproductlist.SelectedItems.Count > 0 Then

            txtBox_quantity.Enabled = True
            txtBox_quantity.Text = 1

            button_AddToPurchase.Enabled = True



            command = "SELECT `id`, `name`, `price` FROM `parts_products` WHERE name ='" & listBox_partsproductlist.SelectedItem.ToString.Split(",")(0) & "'"
            Try
                readqueary(command)
                With cmdread
                    While .Read
                        partName = .GetValue(1)
                        txtBox_partsProductId.Text = .GetValue(0)
                        txtBox_PartPrice.Text = .GetValue(2)
                    End While
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBox_quantity_TextChanged(sender As Object, e As EventArgs) Handles txtBox_quantity.TextChanged
        If listBox_partsproductlist.SelectedItems.Count > 0 Then
            Dim price As String
            price = 0
            Dim command As String
            command = "SELECT `id`, `name`, `price` FROM `parts_products` WHERE name ='" & listBox_partsproductlist.SelectedItem.ToString.Split(",")(0) & "'"
            Try
                readqueary(command)
                With cmdread
                    While .Read
                        'price = .GetValue(2)
                    End While
                End With
            Catch ex As Exception
            End Try
            'txtBox_totalCast.Text = Convert.ToInt32(price) * Convert.ToInt32(txtBox_quantity.Text.ToString())
        End If

    End Sub


    Private Sub btn_clearFields_Click(sender As Object, e As EventArgs) Handles btn_clearFields.Click
        txtBox__customerId.Clear()
        txtBox_fname.Clear()
        txtBox_MidName.Clear()
        txtBox_lname.Clear()
        txtBox_customer_addr.Clear()
        txtBox_vehicle_id.Clear()

        txtBox_partsProductId.Clear()
        txtBox__customerId.Clear()
        txtBox_totalCast.Clear()

        listBoxCustomers.ClearSelected()
        listBox_partsproductlist.ClearSelected()

        txtBox_PartPrice.Clear()
        txtBox_quantity.Clear()
        dataGridViewPurchase.Rows.Clear()

        button_deletetopurchase.Enabled = False
        button_resetAll.Enabled = False
    End Sub

    Private Sub gpCustomerInformation_Enter(sender As Object, e As EventArgs) Handles gpCustomerInformation.Enter

    End Sub

    Private Sub button_AddToPurchase_Click(sender As Object, e As EventArgs) Handles button_AddToPurchase.Click
        button_deletetopurchase.Enabled = True
        button_resetAll.Enabled = True

        Dim amount As Integer
        'ID, Name, Price, Quantity, TotalCost
        amount = Integer.Parse(txtBox_PartPrice.Text) * Integer.Parse(txtBox_quantity.Text)
        totalCost += amount

        txtBox_totalCast.Text = Convert.ToString(totalCost)

        dataGridViewPurchase.Rows.Add(txtBox_partsProductId.Text, partName, txtBox_PartPrice.Text, txtBox_quantity.Text, amount)
    End Sub

    Private Sub btn_AddFinish_Click(sender As Object, e As EventArgs) Handles btn_AddFinish.Click
        Dim conn As MySqlConnection = New MySqlConnection(strconn)
        Try
            conn.Open()
            For Each row As DataGridViewRow In dataGridViewPurchase.Rows
                Dim cmd As MySqlCommand = New MySqlCommand()
                cmd.Connection = conn
                cmd.CommandText = "INSERT INTO purchases(customer_id, part_product_id, quantity, cost) VALUES(@customerid, @part_product_id, @quantity, @cost)"
                cmd.Parameters.AddWithValue("@customerid", txtBox__customerId.Text)
                cmd.Parameters.AddWithValue("@part_product_id", row.Cells(0).Value)
                cmd.Parameters.AddWithValue("@quantity", row.Cells(3).Value)
                cmd.Parameters.AddWithValue("@cost", row.Cells(4).Value)
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Success!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub button_deletetopurchase_Click(sender As Object, e As EventArgs) Handles button_deletetopurchase.Click
        If dataGridViewPurchase.SelectedRows.Count > 0 Then
            dataGridViewPurchase.Rows.RemoveAt(dataGridViewPurchase.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub button_resetAll_Click(sender As Object, e As EventArgs) Handles button_resetAll.Click
        dataGridViewPurchase.Rows.Clear()
        button_deletetopurchase.Enabled = False
        button_resetAll.Enabled = False
        btn_AddFinish.Enabled = False
        txtBox_totalCast.Clear()

        totalCost = 0
    End Sub

    Private Sub txtBox_totalCast_TextChanged_1(sender As Object, e As EventArgs) Handles txtBox_totalCast.TextChanged
        btn_AddFinish.Enabled = True
    End Sub

End Class