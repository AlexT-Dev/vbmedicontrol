Imports MySql.Data.MySqlClient
Imports EntityLayer
Imports System.Linq.Expressions
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DLUsers
    Private _Connect As String = "Server=localhost; user=root; Password=teaa701216mb1; port=3306; database=especialidades"
    Dim connect As New MySqlConnection(_Connect)
    Dim Query As String
    Public Sub CreateConnect()


        Try
            connect.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        'Daefinir variable para retorno con mensaje
        MessageBox.Show("conectado")
        connect.Close()
    End Sub

    Public Sub Crear(ByVal user As UserClass)
        connect.Open()
        Query = "insert into usuarios (nombreusuario, tipousuario, status, cuenta, password) values ('" & user.Nombre & "', '" & user.Tipo & "', '" & user.Status & "', '" & user.Cuenta & "', '" & user.Password & "')"
        Dim Command As New MySqlCommand(Query, connect)
        Command.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Regristro creado.")
    End Sub

    Public Sub Modificar(ByVal user As UserClass)
        connect.Open()
        Query = "update usuarios set nombreusuario = '" & user.Nombre & "', tipousuario = '" & user.Tipo & "', status = '" & user.Status & "' where cuenta = '" & user.Cuenta & "'"
        Dim Command As New MySqlCommand(Query, connect)
        Command.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Regristro modificado.")
    End Sub
    Public Sub Eliminar(ByVal user As UserClass)
        connect.Open()
        Query = "delete from usuarios where cuenta = '" & user.Cuenta & "'"
        Dim Command As New MySqlCommand(Query, connect)
        Command.ExecuteNonQuery()
        connect.Close()
        MessageBox.Show("Regristro eliminado.")
    End Sub
    Public Function List() As DataSet
        connect.Open()
        Dim Adapter As MySqlDataAdapter
        Dim dataSet As New DataSet
        Query = "select * from usuarios order by nombreusuario"
        Adapter = New MySqlDataAdapter(Query, connect)
        Adapter.Fill(dataSet, "users")
        connect.Close()
        Return dataSet
    End Function

    'Valida la existencia de un registro
    Public Function NewAccount(ByVal user As UserClass) As Integer
        connect.Open()
        Dim RowCount As Integer
        Query = "select count(cuenta) from usuarios where cuenta = '" & user.Cuenta & "'"
        Dim Command As New MySqlCommand(Query, connect)
        RowCount = Command.ExecuteScalar()
        connect.Close()
        Return RowCount

    End Function



End Class
