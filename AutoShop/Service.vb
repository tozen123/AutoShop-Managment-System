Public Class Service
    Dim d0 As String
    Dim d1 As String
    Dim d2 As String
    Dim d3 As String
    Dim dataTable As New DataTable()
    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        buttonGoSearch.Enabled = False
        Dim Str As String
        Str = "SELECT * FROM `service`"
        Try
            readqueary(Str)

            For i As Integer = 0 To cmdread.FieldCount - 1
                Dim columnName As String = cmdread.GetName(i)
                Dim columnType As Type = cmdread.GetFieldType(i)
                dataTable.Columns.Add(columnName, columnType)
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

        Dim command2 As String
        command2 = "SELECT `emp_fname`, `emp_midname`, `emp_lname` FROM `employees`"
        Try
            readqueary(command2)
            With cmdread
                While .Read
                    comboxEmployeeSearch.Items.Add(.GetValue(0) + " " + .GetValue(1) + " " + .GetValue(2))
                End While
            End With
        Catch ex As Exception
        End Try

        Dim Str1 As String
            Str1 = "SELECT `service_employee`, `service_name` FROM `service` ORDER BY service_status DESC;"
            Try
            readqueary(Str1)

            With cmdread
                While .Read
                    listNotes.Items.Add(.GetValue(0) + "|" + .GetValue(1))
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub

    Private Sub listNotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listNotes.SelectedIndexChanged
        GroupBox1.Enabled = True
        Dim command As String
        If listNotes.SelectedItems.Count > 0 Then
            command = "SELECT `service_employee`, `service_name`, `service_type`, `service_status` FROM `service` WHERE service_name='" & listNotes.SelectedItem.ToString.Split("|")(1) & "'"
            Try
                readqueary(command)
                With cmdread
                    While .Read
                        textBoxEmployee.Text = .GetValue(0)
                        txtBox_note.Text = .GetValue(1)
                        cb_serviceType.SelectedItem = .GetValue(2)
                        comboBoxStatus.SelectedItem = .GetValue(3)
                    End While
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click
        Dim command As String
        command = "
                UPDATE `service` SET `service_employee`='" & textBoxEmployee.Text & "',
                `service_name`='" & txtBox_note.Text & "',
                `service_type`='" & cb_serviceType.Text & "',
                `service_status`='" & comboBoxStatus.Text & "'
                WHERE service_name='" & listNotes.SelectedItem.ToString.Split("|")(1) & "'
                "
        Try
            readqueary(command)
            MsgBox("New record has been successfully updated")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try


        Dim command1 As String
        command1 = "UPDATE `avails` SET `service_note_name`='" & txtBox_note.Text & "' WHERE service_note_name='" & listNotes.SelectedItem.ToString.Split("|")(1) & "'"
        Try
            readqueary(command1)
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub buttonGoSearch_Click(sender As Object, e As EventArgs) Handles buttonGoSearch.Click
        Dim empSearch As String = comboxEmployeeSearch.SelectedItem

        Dim selectedColumnName As String = DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name

        If empSearch = "" Then
            dataTable.DefaultView.RowFilter = ""
        Else
            dataTable.DefaultView.RowFilter = "service_employee" & " LIKE '%" & empSearch & "%'"
        End If

        DataGridView1.DataSource = dataTable.DefaultView
    End Sub

    Private Sub comboxEmployeeSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxEmployeeSearch.SelectedIndexChanged
        buttonGoSearch.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Enabled = False
        buttonGoSearch.Enabled = False
        textBoxEmployee.Clear()
        txtBox_note.Clear()
        cb_serviceType.Text = ""
        comboxEmployeeSearch.Text = ""
        comboBoxStatus.Text = ""
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        Dim command As String

        command = "DELETE from customer where customer_first_name='" & listNotes.SelectedItem.ToString.Split("|")(1) & "'"
        Try
            readqueary(command)
            MsgBox("New record has been successfully deleted")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        dataTable.DefaultView.RowFilter = ""
        DataGridView1.DataSource = dataTable.DefaultView
    End Sub
End Class