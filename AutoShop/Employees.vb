Public Class Employees
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBox_midName.Enabled = False
        txtBox_lname.Enabled = False
        txtBox_addr.Enabled = False
        dtpBirthdate.Enabled = False
        txtBox_employeeID.Enabled = False
        cb_EmployeeSkill.Enabled = False
        dtpStartDate.Enabled = False
        btn_Add.Enabled = False
        btn_Update.Enabled = False
        btn_Delete.Enabled = False
        btn_generateEmpId.Enabled = False

        Dim str As String
        str = "SELECT emp_fname, emp_midname, emp_lname FROM employees"
        Try
            readqueary(str)

            With cmdread
                While .Read
                    ListBoxEmployee.Items.Add(.GetValue(0) + " " + .GetValue(1) + " " + .GetValue(2))
                End While
            End With

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_generateEmpId_Click(sender As Object, e As EventArgs) Handles btn_generateEmpId.Click
        Dim command As String
        Dim resultsID As New List(Of Integer)

        Dim random As New Random()
        Dim randomInt As Integer = random.Next(999999999)

        command = "SELECT emp_id FROM `employees`"
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
            txtBox_employeeID.Text = randomInt
        End If
    End Sub

    Private Sub txtBox_fname_TextChanged(sender As Object, e As EventArgs) Handles txtBox_fname.TextChanged
        txtBox_midName.Enabled = True
    End Sub
    Private Sub txtBox_midName_TextChanged(sender As Object, e As EventArgs) Handles txtBox_midName.TextChanged
        txtBox_lname.Enabled = True
    End Sub

    Private Sub txtBox_lname_TextChanged(sender As Object, e As EventArgs) Handles txtBox_lname.TextChanged
        txtBox_addr.Enabled = True
    End Sub

    Private Sub txtBox_addr_TextChanged(sender As Object, e As EventArgs) Handles txtBox_addr.TextChanged
        dtpBirthdate.Enabled = True
    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        txtBox_employeeID.Enabled = True
        btn_generateEmpId.Enabled = True
    End Sub

    Private Sub txtBox_employeeID_TextChanged(sender As Object, e As EventArgs) Handles txtBox_employeeID.TextChanged
        cb_EmployeeSkill.Enabled = True
    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        btn_Add.Enabled = True
    End Sub


    Private Sub ListBoxEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployee.SelectedIndexChanged
        txtBox_fname.Enabled = True
        txtBox_midName.Enabled = True
        txtBox_lname.Enabled = True
        txtBox_addr.Enabled = True
        dtpBirthdate.Enabled = True
        txtBox_employeeID.Enabled = True
        cb_EmployeeSkill.Enabled = True
        dtpStartDate.Enabled = True
        btn_Add.Enabled = True
        btn_Update.Enabled = True
        btn_Delete.Enabled = True
        btn_generateEmpId.Enabled = True

        Dim command As String
        If ListBoxEmployee.SelectedItems.Count > 0 Then
            command = "SELECT `emp_id`, `emp_skill`, `emp_fname`, `emp_midname`, `emp_lname`, `emp_birthdate`, `emp_addr`, `emp_startDate` FROM `employees` WHERE emp_fname ='" & ListBoxEmployee.SelectedItem.ToString.Split(" ")(0) & "'"
            Try
                readqueary(command)
                With cmdread
                    While .Read
                        txtBox_employeeID.Text = .GetValue(0)
                        cb_EmployeeSkill.Text = .GetValue(1)
                        txtBox_fname.Text = .GetValue(2)
                        txtBox_midName.Text = .GetValue(3)
                        txtBox_lname.Text = .GetValue(4)
                        dtpBirthdate.Text = .GetValue(5)
                        txtBox_addr.Text = .GetValue(6)
                        dtpStartDate.Value = .GetValue(7)
                    End While
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btn_ClearFields_Click(sender As Object, e As EventArgs) Handles btn_ClearFields.Click
        txtBox_midName.Clear()
        txtBox_lname.Clear()
        txtBox_addr.Clear()
        dtpBirthdate.Enabled = False
        txtBox_employeeID.Clear()
        cb_EmployeeSkill.SelectedIndex = -1
        dtpStartDate.Enabled = False
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim command As String
        command = "INSERT INTO employees (`emp_id`, `emp_skill`, `emp_fname`, `emp_midname`, `emp_lname`, `emp_birthdate`, `emp_addr`, `emp_startDate`) " &
            " VALUES ('" & txtBox_employeeID.Text & "', '" & cb_EmployeeSkill.SelectedItem.ToString & "', '" & txtBox_fname.Text & "', '" & txtBox_midName.Text & "', '" & txtBox_lname.Text & "', '" & Convert.ToDateTime(dtpBirthdate.Value).ToString("yyyy-MM-dd") & "' ,'" & txtBox_addr.Text & "','" & Convert.ToDateTime(dtpStartDate.Value).ToString("yyyy-MM-dd") & "')"
        Try

            readqueary(command)
            MsgBox("New record has been successfully added")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cb_EmployeeSkill_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_EmployeeSkill.SelectedIndexChanged
        dtpStartDate.Enabled = True
    End Sub
End Class