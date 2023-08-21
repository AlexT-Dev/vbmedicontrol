<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserCatalog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gbDatosGrales = New GroupBox()
        BTNGuardar = New Button()
        BTNCancelar = New Button()
        cbEstado = New ComboBox()
        cbTipo = New ComboBox()
        txtPasssword = New TextBox()
        txtCuenta = New TextBox()
        txtNombre = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnModify = New Button()
        DGVDatos = New DataGridView()
        btnNew = New Button()
        Label6 = New Label()
        MenuStrip1 = New MenuStrip()
        BTNEliminar = New Button()
        gbDatosGrales.SuspendLayout()
        CType(DGVDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbDatosGrales
        ' 
        gbDatosGrales.Controls.Add(BTNGuardar)
        gbDatosGrales.Controls.Add(BTNCancelar)
        gbDatosGrales.Controls.Add(cbEstado)
        gbDatosGrales.Controls.Add(cbTipo)
        gbDatosGrales.Controls.Add(txtPasssword)
        gbDatosGrales.Controls.Add(txtCuenta)
        gbDatosGrales.Controls.Add(txtNombre)
        gbDatosGrales.Controls.Add(Label5)
        gbDatosGrales.Controls.Add(Label4)
        gbDatosGrales.Controls.Add(Label3)
        gbDatosGrales.Controls.Add(Label2)
        gbDatosGrales.Controls.Add(Label1)
        gbDatosGrales.Enabled = False
        gbDatosGrales.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        gbDatosGrales.Location = New Point(12, 12)
        gbDatosGrales.Name = "gbDatosGrales"
        gbDatosGrales.Size = New Size(983, 278)
        gbDatosGrales.TabIndex = 0
        gbDatosGrales.TabStop = False
        gbDatosGrales.Text = "Datos del Usuario"
        ' 
        ' BTNGuardar
        ' 
        BTNGuardar.BackColor = Color.Yellow
        BTNGuardar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BTNGuardar.ForeColor = SystemColors.Highlight
        BTNGuardar.Location = New Point(727, 231)
        BTNGuardar.Name = "BTNGuardar"
        BTNGuardar.Size = New Size(122, 41)
        BTNGuardar.TabIndex = 6
        BTNGuardar.Text = "&Guardar"
        BTNGuardar.UseVisualStyleBackColor = False
        ' 
        ' BTNCancelar
        ' 
        BTNCancelar.BackColor = SystemColors.ButtonShadow
        BTNCancelar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BTNCancelar.ForeColor = SystemColors.ControlText
        BTNCancelar.Location = New Point(855, 231)
        BTNCancelar.Name = "BTNCancelar"
        BTNCancelar.Size = New Size(122, 41)
        BTNCancelar.TabIndex = 7
        BTNCancelar.Text = "C&ancelar"
        BTNCancelar.UseVisualStyleBackColor = False
        ' 
        ' cbEstado
        ' 
        cbEstado.BackColor = Color.Yellow
        cbEstado.ForeColor = Color.Blue
        cbEstado.FormattingEnabled = True
        cbEstado.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        cbEstado.Location = New Point(151, 122)
        cbEstado.Name = "cbEstado"
        cbEstado.Size = New Size(198, 28)
        cbEstado.TabIndex = 3
        ' 
        ' cbTipo
        ' 
        cbTipo.BackColor = Color.Yellow
        cbTipo.ForeColor = Color.Blue
        cbTipo.FormattingEnabled = True
        cbTipo.Items.AddRange(New Object() {"ADMINISTRADOR", "AUXILIAR", "DOCTOR"})
        cbTipo.Location = New Point(151, 83)
        cbTipo.Name = "cbTipo"
        cbTipo.Size = New Size(325, 28)
        cbTipo.TabIndex = 2
        ' 
        ' txtPasssword
        ' 
        txtPasssword.Location = New Point(151, 194)
        txtPasssword.Name = "txtPasssword"
        txtPasssword.Size = New Size(177, 27)
        txtPasssword.TabIndex = 5
        txtPasssword.UseSystemPasswordChar = True
        ' 
        ' txtCuenta
        ' 
        txtCuenta.Location = New Point(151, 161)
        txtCuenta.Name = "txtCuenta"
        txtCuenta.Size = New Size(449, 27)
        txtCuenta.TabIndex = 4
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(151, 49)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(640, 27)
        txtNombre.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(46, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 20)
        Label5.TabIndex = 4
        Label5.Text = "Contraseña:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(76, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 20)
        Label4.TabIndex = 3
        Label4.Text = "Cuenta:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 2
        Label3.Text = "Estado:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 1
        Label2.Text = "Tipo:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' btnModify
        ' 
        btnModify.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnModify.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnModify.Location = New Point(140, 296)
        btnModify.Name = "btnModify"
        btnModify.Size = New Size(122, 41)
        btnModify.TabIndex = 9
        btnModify.Text = "&Modificar"
        btnModify.UseVisualStyleBackColor = False
        ' 
        ' DGVDatos
        ' 
        DGVDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDatos.Location = New Point(10, 409)
        DGVDatos.Name = "DGVDatos"
        DGVDatos.RowHeadersWidth = 51
        DGVDatos.RowTemplate.Height = 29
        DGVDatos.Size = New Size(985, 263)
        DGVDatos.TabIndex = 4
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = SystemColors.Highlight
        btnNew.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnNew.ForeColor = SystemColors.Info
        btnNew.Location = New Point(12, 296)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(122, 41)
        btnNew.TabIndex = 8
        btnNew.Text = "&Crear"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.BackColor = SystemColors.ActiveCaptionText
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(10, 381)
        Label6.Name = "Label6"
        Label6.Size = New Size(985, 31)
        Label6.TabIndex = 10
        Label6.Text = "RELACIÓN DE USUARIOS"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1009, 24)
        MenuStrip1.TabIndex = 11
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' BTNEliminar
        ' 
        BTNEliminar.BackColor = Color.Red
        BTNEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BTNEliminar.ForeColor = Color.Yellow
        BTNEliminar.Location = New Point(268, 296)
        BTNEliminar.Name = "BTNEliminar"
        BTNEliminar.Size = New Size(122, 41)
        BTNEliminar.TabIndex = 10
        BTNEliminar.Text = "&Eliminar"
        BTNEliminar.UseVisualStyleBackColor = False
        ' 
        ' frmUserCatalog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1009, 684)
        Controls.Add(BTNEliminar)
        Controls.Add(Label6)
        Controls.Add(btnNew)
        Controls.Add(DGVDatos)
        Controls.Add(btnModify)
        Controls.Add(gbDatosGrales)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmUserCatalog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catálogo de Usuarios"
        gbDatosGrales.ResumeLayout(False)
        gbDatosGrales.PerformLayout()
        CType(DGVDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents DGVDatos As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents txtPasssword As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents gbDatosGrales As GroupBox
    Friend WithEvents BTNCancelar As Button
    Friend WithEvents BTNGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BTNEliminar As Button
End Class
