Imports EntityLayer
Imports BussinessLayer

Public Class frmUserCatalog
    Dim BLUser As New BLUsers
    Dim NewUser As Integer   'Para definir si es nuevo o modificación


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtNombre.Text = ""
        txtCuenta.Text = ""
        txtPasssword.Text = ""
        cbEstado.Text = ""
        cbTipo.Text = ""

        gbDatosGrales.Enabled = True
        btnModify.Enabled = False
        btnNew.Enabled = False
        NewUser = 1 'define que es nuevo
        txtNombre.Focus()

    End Sub



    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtNombre.Text <> "" Then
            gbDatosGrales.Enabled = True
            btnModify.Enabled = False
            btnNew.Enabled = False
            NewUser = 2 'Define que es modificación

            txtPasssword.Enabled = False
            txtCuenta.Enabled = False
            txtNombre.Focus()
        Else
            MessageBox.Show("Elija un registro en la parte de abajo.")
            Exit Sub
        End If

    End Sub


    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles txtNombre.LostFocus
        txtNombre.Text = txtNombre.Text.ToUpper
    End Sub

    Private Sub BTNCancelar_Click(sender As Object, e As EventArgs) Handles BTNCancelar.Click
        btnModify.Enabled = True
        btnNew.Enabled = True
        btnNew.Focus()
        gbDatosGrales.Enabled = False
    End Sub


    Dim users As New UserClass()
    Dim ValidaDatos As Boolean

    Private Sub BTNGuardar_Click(sender As Object, e As EventArgs) Handles BTNGuardar.Click
        users.Nombre = txtNombre.Text
        users.Cuenta = txtCuenta.Text
        users.Password = txtPasssword.Text
        users.Tipo = cbTipo.Text
        users.Status = cbEstado.Text

        ValidaDatos = BLUser.ValidarDatos(users)

        If ValidaDatos = False Then Exit Sub


        btnModify.Enabled = True
        btnNew.Enabled = True
        txtPasssword.Enabled = True
        txtCuenta.Enabled = True

        If NewUser = 1 Then


            If BLUser.NewUser(users) = 0 Then
                'guarda la información
                BLUser.Crear(users)
            Else
                MessageBox.Show("La cuenta de usuario ya existe, favor de revisar la información")
            End If

        Else
                BLUser.Modificar(users)
        End If

        gbDatosGrales.Enabled = False
        LoadData()

    End Sub

    Private Sub frmUserCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

        'formato de las columnas del grid
        DGVDatos.Columns(0).HeaderText = "NOMBRE"
        DGVDatos.Columns(0).Width = 300
        DGVDatos.Columns(1).HeaderText = "TIPO"
        DGVDatos.Columns(1).Width = 180
        DGVDatos.Columns(2).HeaderText = "ESTADO"
        DGVDatos.Columns(2).Width = 100
        DGVDatos.Columns(3).HeaderText = "CUENTA"
        DGVDatos.Columns(3).Width = 320
        DGVDatos.Columns(4).Visible = False


    End Sub

    Private Sub DGVDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatos.CellClick
        Try
            txtNombre.Text = DGVDatos.CurrentRow.Cells("nombreusuario").Value
            txtCuenta.Text = DGVDatos.CurrentRow.Cells("cuenta").Value
            txtPasssword.Text = DGVDatos.CurrentRow.Cells("password").Value
            cbEstado.Text = DGVDatos.CurrentRow.Cells("status").Value
            cbTipo.Text = DGVDatos.CurrentRow.Cells("tipousuario").Value
        Catch ex As Exception

        End Try

    End Sub

    Public Sub LoadData()
        DGVDatos.DataSource = BLUser.List().Tables("users")
        txtNombre.Text = ""
        txtCuenta.Text = ""
        txtPasssword.Text = ""
        cbEstado.Text = ""
        cbTipo.Text = ""
    End Sub

    Private Sub BTNEliminar_Click(sender As Object, e As EventArgs) Handles BTNEliminar.Click
        If txtNombre.Text <> "" Then
            BLUser.Eliminar(users)
            LoadData()
        Else
            MessageBox.Show("Elija un registro en la parte de abajo.")
            Exit Sub
        End If
    End Sub
End Class
