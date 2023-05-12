Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBox__customerId.Enabled = False
        txtBox_MidName.Enabled = False
        txtBox_lname.Enabled = False
        txtBox_customer_addr.Enabled = False
        txtBox_vehicle_id.Enabled = False
        dtp_inquireDate.Enabled = False
        btn_generateID.Enabled = False
        btn_generateVeID.Enabled = False
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        btn_Add.Enabled = False

        Dim str As String
        str = "SELECT customer_first_name, customer_mid_name, customer_last_name FROM customer"
        Try
            readqueary(str)

            With cmdread
                While .Read
                    listBoxCustomer.Items.Add(.GetValue(0) + " " + .GetValue(1) + " " + .GetValue(2))
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim command As String
        command = "INSERT INTO customer (`customer_id`, `customer_first_name`, `customer_mid_name`, `customer_last_name`, `customer_addr`, `customer_vehicle_id`, `customer_inquireDate`) " &
            " VALUES ('" & txtBox__customerId.Text & "', '" & txtBox_fname.Text & "', '" & txtBox_MidName.Text & "', '" & txtBox_lname.Text & "', '" & txtBox_customer_addr.Text & "', '" & txtBox_vehicle_id.Text & "','" & Convert.ToDateTime(dtp_inquireDate.Value).ToString("yyyy-MM-dd") & "')"
        Try

            readqueary(command)
            MsgBox("New record has been successfully added")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxCustomer.SelectedIndexChanged


        Dim command As String
        If listBoxCustomer.SelectedItems.Count > 0 Then
            command = "SELECT `customer_id`, `customer_first_name`, `customer_mid_name`, `customer_last_name`, `customer_addr`, `customer_vehicle_id`, `customer_inquireDate` FROM `customer` WHERE customer_first_name ='" & listBoxCustomer.SelectedItem.ToString.Split(" ")(0) & "'"
            txtBox__customerId.Enabled = True
            txtBox_MidName.Enabled = True
            txtBox_lname.Enabled = True
            txtBox_customer_addr.Enabled = True
            txtBox_vehicle_id.Enabled = True
            dtp_inquireDate.Enabled = True
            btn_generateID.Enabled = True
            btn_generateVeID.Enabled = True
            btn_Update.Enabled = True
            btn_Delete.Enabled = True

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

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim command As String

        command = "DELETE from customer where customer_first_name='" & listBoxCustomer.SelectedItem.ToString.Split(" ")(0) & "'"
        Try
            readqueary(command)
            MsgBox("New record has been successfully deleted")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtBox_fname_TextChanged(sender As Object, e As EventArgs) Handles txtBox_fname.TextChanged
        txtBox_MidName.Enabled = True
    End Sub

    Private Sub txtBox_MidName_TextChanged(sender As Object, e As EventArgs) Handles txtBox_MidName.TextChanged
        txtBox_lname.Enabled = True
    End Sub

    Private Sub txtBox_lname_TextChanged(sender As Object, e As EventArgs) Handles txtBox_lname.TextChanged
        txtBox_customer_addr.Enabled = True
    End Sub

    Private Sub txtBox__customerId_TextChanged(sender As Object, e As EventArgs) Handles txtBox__customerId.TextChanged
        txtBox_vehicle_id.Enabled = True
        btn_generateVeID.Enabled = True
    End Sub

    Private Sub txtBox_vehicle_id_TextChanged(sender As Object, e As EventArgs) Handles txtBox_vehicle_id.TextChanged
        dtp_inquireDate.Enabled = True
    End Sub

    Private Sub dtp_inquireDate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_inquireDate.ValueChanged
        btn_Add.Enabled = True
    End Sub

    Private Sub btn_ClearField_Click(sender As Object, e As EventArgs) Handles btn_ClearField.Click
        listBoxCustomer.SelectedItems.Clear()
        If listBoxCustomer.SelectedItems.Count > 1 Then
            If listBoxCustomer.SelectedIndex = 0 Then
                listBoxCustomer.SelectedItems.Clear()
                listBoxCustomer.SetSelected(0, True)
            End If
        End If

        txtBox__customerId.Clear()
        txtBox_fname.Clear()
        txtBox_MidName.Clear()
        txtBox_lname.Clear()
        txtBox_customer_addr.Clear()
        txtBox_vehicle_id.Clear()

        txtBox__customerId.Enabled = False
        txtBox_MidName.Enabled = False
        txtBox_lname.Enabled = False
        txtBox_customer_addr.Enabled = False
        txtBox_vehicle_id.Enabled = False
        dtp_inquireDate.Enabled = False
        btn_generateID.Enabled = False
        btn_generateVeID.Enabled = False
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        btn_Add.Enabled = False
    End Sub

    Private Sub btn_generateID_Click(sender As Object, e As EventArgs) Handles btn_generateID.Click
        Dim command As String
        Dim resultsID As New List(Of Integer)

        Dim random As New Random()
        Dim randomInt As Integer = random.Next(999999999)

        command = "SELECT customer_id FROM `customer`"
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
            txtBox__customerId.Text = randomInt
        End If
    End Sub

    Private Sub btn_generateVeID_Click(sender As Object, e As EventArgs) Handles btn_generateVeID.Click
        Dim command As String
        Dim resultsID As New List(Of Integer)

        Dim random As New Random()
        Dim randomInt As Integer = random.Next(999999999)

        command = "SELECT customer_vehicle_id FROM `customer`"
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
            txtBox_vehicle_id.Text = randomInt
        End If
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Dim command As String
        command = "

                UPDATE `customer` SET `customer_id`='" & txtBox__customerId.Text & "',`customer_first_name`='" & txtBox_fname.Text & "',
                `customer_mid_name`='" & txtBox_MidName.Text & "',`customer_last_name`='" & txtBox_lname.Text & "',
                `customer_addr`='" & txtBox_customer_addr.Text & "',`customer_vehicle_id`='" & txtBox_vehicle_id.Text & "',
                `customer_inquireDate`='" & Convert.ToDateTime(dtp_inquireDate.Value).ToString("yyyy-MM-dd") & "' 
                WHERE customer_first_name='" & listBoxCustomer.SelectedItem.ToString.Split(" ")(0) & "'

                "

        Try

            readqueary(command)
            MsgBox("New record has been successfully updated")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtBox_customer_addr_TextChanged(sender As Object, e As EventArgs) Handles txtBox_customer_addr.TextChanged

        txtBox__customerId.Enabled = True
        btn_generateID.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class