Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Module Module1
    Public tax_rate As Double = 0.25
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader

    Public dataAdapterSQL As New SqlDataAdapter

    Public db_server = "'localhost'" ' server name
    Public db_uid = "'root'" ' user id
    Public db_pwd = "''" 'password
    Public db_name = "'autoshop'" 'database name

    Public strconn As String = "server =" & db_server & ";user id = " & db_uid & ";password = " & db_pwd & "; database =" & db_name & ""


    Public Sub readqueary(ByVal sql As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdread = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module
