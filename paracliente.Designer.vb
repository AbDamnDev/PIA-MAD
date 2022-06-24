<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paracliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paracliente))
        Me.bCancelar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.CBESTADO = New System.Windows.Forms.ComboBox()
        Me.TNOMBRE = New System.Windows.Forms.TextBox()
        Me.TAPELLIDOP = New System.Windows.Forms.TextBox()
        Me.TAPELLIDOM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LIDClient = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TCelular = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TCURP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TCalle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tnumero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tcolonia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TMuni = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TCP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Lestado = New System.Windows.Forms.Label()
        Me.TBring = New System.Windows.Forms.Button()
        Me.Usern = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LBorn = New System.Windows.Forms.Label()
        Me.IDperoUser = New System.Windows.Forms.Label()
        Me.TUsername = New System.Windows.Forms.TextBox()
        Me.Tnewpass = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DGVparaver = New System.Windows.Forms.DataGridView()
        Me.Lcurpcurp = New System.Windows.Forms.Label()
        Me.Lusus = New System.Windows.Forms.Label()
        Me.LLCelular = New System.Windows.Forms.Label()
        Me.LLmail = New System.Windows.Forms.Label()
        CType(Me.DGVparaver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(694, 426)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(94, 29)
        Me.bCancelar.TabIndex = 0
        Me.bCancelar.Text = "Cancelar"
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Enabled = False
        Me.Bmodificar.Location = New System.Drawing.Point(594, 426)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(94, 29)
        Me.Bmodificar.TabIndex = 1
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'CBESTADO
        '
        Me.CBESTADO.FormattingEnabled = True
        Me.CBESTADO.Location = New System.Drawing.Point(250, 298)
        Me.CBESTADO.Name = "CBESTADO"
        Me.CBESTADO.Size = New System.Drawing.Size(151, 28)
        Me.CBESTADO.TabIndex = 2
        '
        'TNOMBRE
        '
        Me.TNOMBRE.Location = New System.Drawing.Point(13, 47)
        Me.TNOMBRE.Name = "TNOMBRE"
        Me.TNOMBRE.Size = New System.Drawing.Size(152, 27)
        Me.TNOMBRE.TabIndex = 3
        '
        'TAPELLIDOP
        '
        Me.TAPELLIDOP.Location = New System.Drawing.Point(13, 104)
        Me.TAPELLIDOP.Name = "TAPELLIDOP"
        Me.TAPELLIDOP.Size = New System.Drawing.Size(152, 27)
        Me.TAPELLIDOP.TabIndex = 4
        '
        'TAPELLIDOM
        '
        Me.TAPELLIDOM.Location = New System.Drawing.Point(11, 167)
        Me.TAPELLIDOM.Name = "TAPELLIDOM"
        Me.TAPELLIDOM.Size = New System.Drawing.Size(154, 27)
        Me.TAPELLIDOM.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre:"
        '
        'LIDClient
        '
        Me.LIDClient.AutoSize = True
        Me.LIDClient.Location = New System.Drawing.Point(594, 13)
        Me.LIDClient.Name = "LIDClient"
        Me.LIDClient.Size = New System.Drawing.Size(24, 20)
        Me.LIDClient.TabIndex = 7
        Me.LIDClient.Text = "ID"
        Me.LIDClient.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Apellido Materno:"
        '
        'TCelular
        '
        Me.TCelular.Location = New System.Drawing.Point(13, 236)
        Me.TCelular.Name = "TCelular"
        Me.TCelular.Size = New System.Drawing.Size(152, 27)
        Me.TCelular.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Celular:"
        '
        'TCorreo
        '
        Me.TCorreo.Location = New System.Drawing.Point(13, 299)
        Me.TCorreo.Name = "TCorreo"
        Me.TCorreo.Size = New System.Drawing.Size(152, 27)
        Me.TCorreo.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Correo:"
        '
        'TCURP
        '
        Me.TCURP.Location = New System.Drawing.Point(13, 363)
        Me.TCURP.Name = "TCURP"
        Me.TCURP.Size = New System.Drawing.Size(152, 27)
        Me.TCURP.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(13, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CURP:"
        '
        'TCalle
        '
        Me.TCalle.Location = New System.Drawing.Point(250, 47)
        Me.TCalle.Name = "TCalle"
        Me.TCalle.Size = New System.Drawing.Size(151, 27)
        Me.TCalle.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(250, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Calle:"
        '
        'Tnumero
        '
        Me.Tnumero.Location = New System.Drawing.Point(250, 104)
        Me.Tnumero.Name = "Tnumero"
        Me.Tnumero.Size = New System.Drawing.Size(151, 27)
        Me.Tnumero.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(250, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Numero:"
        '
        'Tcolonia
        '
        Me.Tcolonia.Location = New System.Drawing.Point(250, 167)
        Me.Tcolonia.Name = "Tcolonia"
        Me.Tcolonia.Size = New System.Drawing.Size(151, 27)
        Me.Tcolonia.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(250, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Colonia:"
        '
        'TMuni
        '
        Me.TMuni.Location = New System.Drawing.Point(250, 236)
        Me.TMuni.Name = "TMuni"
        Me.TMuni.Size = New System.Drawing.Size(151, 27)
        Me.TMuni.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(250, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Municipio:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(250, 275)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Estado:"
        '
        'TCP
        '
        Me.TCP.Location = New System.Drawing.Point(250, 363)
        Me.TCP.Name = "TCP"
        Me.TCP.Size = New System.Drawing.Size(151, 27)
        Me.TCP.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(250, 340)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "CP:"
        '
        'Lestado
        '
        Me.Lestado.AutoSize = True
        Me.Lestado.Location = New System.Drawing.Point(541, 37)
        Me.Lestado.Name = "Lestado"
        Me.Lestado.Size = New System.Drawing.Size(61, 20)
        Me.Lestado.TabIndex = 29
        Me.Lestado.Text = "Label14"
        Me.Lestado.Visible = False
        '
        'TBring
        '
        Me.TBring.Location = New System.Drawing.Point(494, 426)
        Me.TBring.Name = "TBring"
        Me.TBring.Size = New System.Drawing.Size(94, 29)
        Me.TBring.TabIndex = 30
        Me.TBring.Text = "Traer Datos"
        Me.TBring.UseVisualStyleBackColor = True
        '
        'Usern
        '
        Me.Usern.AutoSize = True
        Me.Usern.Location = New System.Drawing.Point(654, 47)
        Me.Usern.Name = "Usern"
        Me.Usern.Size = New System.Drawing.Size(53, 20)
        Me.Usern.TabIndex = 31
        Me.Usern.Text = "Label7"
        Me.Usern.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(13, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Fecha de Nacimiento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 427)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 33
        '
        'LBorn
        '
        Me.LBorn.AutoSize = True
        Me.LBorn.Location = New System.Drawing.Point(541, 94)
        Me.LBorn.Name = "LBorn"
        Me.LBorn.Size = New System.Drawing.Size(61, 20)
        Me.LBorn.TabIndex = 34
        Me.LBorn.Text = "Label14"
        Me.LBorn.Visible = False
        '
        'IDperoUser
        '
        Me.IDperoUser.AutoSize = True
        Me.IDperoUser.Location = New System.Drawing.Point(460, 16)
        Me.IDperoUser.Name = "IDperoUser"
        Me.IDperoUser.Size = New System.Drawing.Size(84, 20)
        Me.IDperoUser.TabIndex = 35
        Me.IDperoUser.Text = "IDperoUser"
        Me.IDperoUser.Visible = False
        '
        'TUsername
        '
        Me.TUsername.Location = New System.Drawing.Point(460, 167)
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(125, 27)
        Me.TUsername.TabIndex = 36
        '
        'Tnewpass
        '
        Me.Tnewpass.Location = New System.Drawing.Point(460, 236)
        Me.Tnewpass.Name = "Tnewpass"
        Me.Tnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tnewpass.Size = New System.Drawing.Size(125, 27)
        Me.Tnewpass.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(460, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Usuario:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(458, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 20)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Contraseña:"
        '
        'DGVparaver
        '
        Me.DGVparaver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVparaver.Location = New System.Drawing.Point(436, 298)
        Me.DGVparaver.Name = "DGVparaver"
        Me.DGVparaver.RowHeadersWidth = 51
        Me.DGVparaver.RowTemplate.Height = 29
        Me.DGVparaver.Size = New System.Drawing.Size(352, 109)
        Me.DGVparaver.TabIndex = 40
        '
        'Lcurpcurp
        '
        Me.Lcurpcurp.AutoSize = True
        Me.Lcurpcurp.Location = New System.Drawing.Point(436, 81)
        Me.Lcurpcurp.Name = "Lcurpcurp"
        Me.Lcurpcurp.Size = New System.Drawing.Size(61, 20)
        Me.Lcurpcurp.TabIndex = 41
        Me.Lcurpcurp.Text = "Label16"
        Me.Lcurpcurp.Visible = False
        '
        'Lusus
        '
        Me.Lusus.AutoSize = True
        Me.Lusus.Location = New System.Drawing.Point(425, 48)
        Me.Lusus.Name = "Lusus"
        Me.Lusus.Size = New System.Drawing.Size(61, 20)
        Me.Lusus.TabIndex = 42
        Me.Lusus.Text = "Label16"
        Me.Lusus.Visible = False
        '
        'LLCelular
        '
        Me.LLCelular.AutoSize = True
        Me.LLCelular.Location = New System.Drawing.Point(664, 13)
        Me.LLCelular.Name = "LLCelular"
        Me.LLCelular.Size = New System.Drawing.Size(61, 20)
        Me.LLCelular.TabIndex = 43
        Me.LLCelular.Text = "Label16"
        Me.LLCelular.Visible = False
        '
        'LLmail
        '
        Me.LLmail.AutoSize = True
        Me.LLmail.Location = New System.Drawing.Point(554, 61)
        Me.LLmail.Name = "LLmail"
        Me.LLmail.Size = New System.Drawing.Size(61, 20)
        Me.LLmail.TabIndex = 44
        Me.LLmail.Text = "Label16"
        Me.LLmail.Visible = False
        '
        'paracliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.LLmail)
        Me.Controls.Add(Me.LLCelular)
        Me.Controls.Add(Me.Lusus)
        Me.Controls.Add(Me.Lcurpcurp)
        Me.Controls.Add(Me.DGVparaver)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Tnewpass)
        Me.Controls.Add(Me.TUsername)
        Me.Controls.Add(Me.IDperoUser)
        Me.Controls.Add(Me.LBorn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Usern)
        Me.Controls.Add(Me.TBring)
        Me.Controls.Add(Me.Lestado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TCP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TMuni)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Tcolonia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Tnumero)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TCalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TCURP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TCorreo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TCelular)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LIDClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TAPELLIDOM)
        Me.Controls.Add(Me.TAPELLIDOP)
        Me.Controls.Add(Me.TNOMBRE)
        Me.Controls.Add(Me.CBESTADO)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.bCancelar)
        Me.Name = "paracliente"
        Me.Text = "paracliente"
        CType(Me.DGVparaver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bCancelar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents CBESTADO As ComboBox
    Friend WithEvents TNOMBRE As TextBox
    Friend WithEvents TAPELLIDOP As TextBox
    Friend WithEvents TAPELLIDOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LIDClient As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TCelular As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TCURP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TCalle As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Tnumero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Tcolonia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TMuni As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TCP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Lestado As Label
    Friend WithEvents TBring As Button
    Friend WithEvents Usern As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LBorn As Label
    Friend WithEvents IDperoUser As Label
    Friend WithEvents TUsername As TextBox
    Friend WithEvents Tnewpass As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DGVparaver As DataGridView
    Friend WithEvents Lcurpcurp As Label
    Friend WithEvents Lusus As Label
    Friend WithEvents LLCelular As Label
    Friend WithEvents LLmail As Label
End Class
