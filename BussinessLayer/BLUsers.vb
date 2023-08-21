Imports EntityLayer
Imports DataLayer


Public Class BLUsers

    Dim DataUsers As New DLUsers()
    Dim MsgValida As String 'Para validar los mensajes
    Public Function ValidarDatos(ByVal clase As Object) As Boolean
        Dim validado As Boolean = True
        'Para validar entre las diferentes clase de un catálogo
        Select Case clase.GetType.Name
            Case = "UserClass"    'Clase Users
                If clase.Nombre = "" Or clase.Cuenta = "" Or clase.Password = "" Then
                    validado = False
                    MessageBox.Show("Debe contener nombre, cuenta y contraseña")
                End If

        End Select
        Return validado
    End Function

    Public Sub ConnectionTest()
        DataUsers.CreateConnect()
    End Sub

    Public Sub Crear(ByVal user As UserClass)
        DataUsers.Crear(user)

    End Sub
    Public Sub Modificar(ByVal user As UserClass)
        DataUsers.Modificar(user)

    End Sub

    Public Sub Eliminar(ByVal user As UserClass)
        MsgValida = MsgBox("¿Realmente desea eliminar el registro?", vbYesNo, MessageBoxIcon.Question)
        If MsgValida = MsgBoxResult.Yes Then
            DataUsers.Eliminar(user)
        End If
    End Sub

    Public Function List() As DataSet
        Return DataUsers.List
    End Function

    Public Function NewUser(ByVal user As UserClass) As Integer
        Return DataUsers.NewAccount(user)
    End Function


End Class
