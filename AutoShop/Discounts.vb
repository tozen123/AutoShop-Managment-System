Public Class Discounts
    Dim dataTable As New DataTable()
    Private Sub Discounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        button_add.Enabled = False
        button_delete.Enabled = False
        button_update.Enabled = False
        button_clearFields.Enabled = False

        txtBox_discountValue.Enabled = False
        txtBox_name.Enabled = False

        loadDiscounts()

    End Sub
    Public Sub loadDiscounts()
        Dim Str As String
        Str = "SELECT * FROM `discount`"
        Try
            readqueary(Str)

            For i As Integer = 0 To cmdread.FieldCount - 1
                Dim columnName As String = cmdread.GetName(i)
                Dim columnType As Type = cmdread.GetFieldType(i)
                DataTable.Columns.Add(columnName, columnType)
            Next
            While cmdread.Read
                Dim row As DataRow = DataTable.NewRow()
                For i As Integer = 0 To cmdread.FieldCount - 1
                    row(i) = cmdread(i)
                Next
                DataTable.Rows.Add(row)
            End While

            DataGridView1.DataSource = DataTable
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
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

    Private Sub button_add_Click(sender As Object, e As EventArgs)
        Dim command As String
        command = "INSERT INTO discount (`discount_id`, `discount_value`, `discount_part_name`) " &
            " VALUES ('" & txtBox_discountID.Text & "', '" & txtBox_discountValue.Text & "', '" & txtBox_name.Text & "')"
        Try

            readqueary(command)
            MsgBox("New record has been successfully added")
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
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
End Class