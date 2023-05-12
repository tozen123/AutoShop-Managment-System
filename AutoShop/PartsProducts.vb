
Imports MySql.Data.MySqlClient
Public Class PartsProducts
    Private Sub PartsProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Str As String
        Str = "SELECT * FROM `parts_products`"
        Try
            readqueary(Str)
            Dim dataTable As New DataTable()
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
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click

    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click

    End Sub

    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click

    End Sub
End Class