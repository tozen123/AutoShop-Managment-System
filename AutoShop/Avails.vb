Public Class Avails

    Dim originalFee As String

    ' 
    ' This section handles the database in the Service and Avail
    ' When the user avails a service, it automatically creates a record in the avail db and service db, with in the service db the status is 
    ' defaulted into "work in progress" status
    '

    Private Sub Avails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gp_cDetails.Enabled = False
        gp_cInfo.Enabled = False

        gp_serviceDetail.Enabled = False

        btn_Add.Enabled = False
        btn_clearFields.Enabled = False

        cb_serviceType.Enabled = False
        txtBox_fee.Enabled = False
        txtBox_discValue.Enabled = False
        cbo_partDiscount.Enabled = False
        txtBox_totalFee.Enabled = False
        txtBox_note.Enabled = False
        cb_employeeList.Enabled = False

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

        Dim command2 As String
        command2 = "SELECT `discount_id`, `discount_value`, `discount_part_name` FROM `discount`"
        Try
            readqueary(command2)
            With cmdread
                While .Read
                    cbo_partDiscount.Items.Add(.GetValue(2))
                End While
            End With
        Catch ex As Exception
        End Try

        Dim command3 As String
        command3 = "SELECT `emp_id`,  `emp_skill`, `emp_fname`, `emp_midname`, `emp_lname`, `emp_birthdate`, `emp_addr`, `emp_startDate` FROM `employees`"
        Try
            readqueary(command3)
            With cmdread
                While .Read
                    cb_employeeList.Items.Add(.GetValue(1) + ":" + " " + .GetValue(2) + " " + .GetValue(3) + " " + .GetValue(4))
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub listBoxCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxCustomers.SelectedIndexChanged
        gp_serviceDetail.Enabled = True
        btn_clearFields.Enabled = True

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

    Private Sub cb_serviceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_serviceType.SelectedIndexChanged
        txtBox_fee.Enabled = True
    End Sub

    Private Sub txtBox_fee_TextChanged(sender As Object, e As EventArgs) Handles txtBox_fee.TextChanged
        cbo_partDiscount.Enabled = True
        originalFee = txtBox_fee.Text
        txtBox_totalFee.Text = txtBox_fee.Text
    End Sub

    Private Sub cbo_partDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_partDiscount.SelectedIndexChanged
        Dim command As String
        command = "SELECT `discount_id`, `discount_value`, `discount_part_name` FROM `discount` WHERE discount_part_name = '" & cbo_partDiscount.SelectedItem & "'"
        Try
            readqueary(command)
            With cmdread
                While .Read
                    txtBox_discValue.Text = .GetValue(1)
                End While
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBox_discValue_TextChanged(sender As Object, e As EventArgs) Handles txtBox_discValue.TextChanged
        If txtBox_discValue.Text = String.Empty Then
            Return
        End If
        Dim percentage As Double = (Convert.ToInt32(txtBox_totalFee.Text) - (Convert.ToDouble(txtBox_totalFee.Text) * Convert.ToInt32(txtBox_discValue.Text)) / 100)
        txtBox_totalFee.Text = percentage.ToString("#,#00.00")
    End Sub

    Private Sub txtBox_totalFee_TextChanged(sender As Object, e As EventArgs) Handles txtBox_totalFee.TextChanged


    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim command As String

        command = "INSERT INTO avails (`customerID`, `avail_type`, `avail_fee`, `avail_discount`, `avail_date`, `service_note_name`) " &
            " VALUES ('" & txtBox__customerId.Text & "', '" & cb_serviceType.SelectedItem & "', '" & txtBox_fee.Text & "', '" & txtBox_discValue.Text & "', '" & Convert.ToDateTime(dtp_AvailDate.Value).ToString("yyyy-MM-dd") & "', '" & txtBox_fname.Text + ", " + txtBox_lname.Text + " " + txtBox_MidName.Text + "-" + txtBox_note.Text & "')"
        Try

            readqueary(command)
            MsgBox("New record has been successfully added")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Dim command2 As String

        command2 = "INSERT INTO service (`service_employee`, `service_name`, `service_type`, `service_status`) " &
            " VALUES ('" & cb_employeeList.SelectedItem.ToString.Split(":")(1) & "', '" & txtBox_fname.Text + ", " + txtBox_lname.Text + " " + txtBox_MidName.Text + "-" + txtBox_note.Text & "', '" & cb_serviceType.SelectedItem.ToString() & "', '" & "Work in Progress" & "')"
        Try

            readqueary(command2)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dtp_AvailDate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_AvailDate.ValueChanged
        cb_serviceType.Enabled = True
        txtBox_note.Enabled = True
        cb_employeeList.Enabled = True
    End Sub

    Private Sub txtBox_note_TextChanged(sender As Object, e As EventArgs) Handles txtBox_note.TextChanged
        btn_Add.Enabled = True
    End Sub

    Private Sub btn_clearFields_Click(sender As Object, e As EventArgs) Handles btn_clearFields.Click
        txtBox__customerId.Clear()
        txtBox_fname.Clear()
        txtBox_MidName.Clear()
        txtBox_lname.Clear()
        txtBox_customer_addr.Clear()
        txtBox_vehicle_id.Clear()

        listBoxCustomers.ClearSelected()

        cb_serviceType.ResetText()
        cbo_partDiscount.ResetText()
        txtBox_fee.Clear()
        txtBox_discValue.Clear()
        txtBox_note.Clear()
        txtBox_totalFee.Clear()

        cb_employeeList.ResetText()
    End Sub

    Private Sub btn_discRemove_Click(sender As Object, e As EventArgs) Handles btn_discRemove.Click
        txtBox_discValue.Clear()
        cbo_partDiscount.ResetText()

        txtBox_totalFee.Text = originalFee
    End Sub

End Class