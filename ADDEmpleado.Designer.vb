<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADDEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BAddEmployee = New System.Windows.Forms.Button()
        Me.BModifyEmployee = New System.Windows.Forms.Button()
        Me.BShowemploy = New System.Windows.Forms.Button()
        Me.BDeleteEmp = New System.Windows.Forms.Button()
        Me.DTGregemp = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBnom = New System.Windows.Forms.TextBox()
        Me.TBLastnamep = New System.Windows.Forms.TextBox()
        Me.TBLastnameM = New System.Windows.Forms.TextBox()
        Me.TBcurp = New System.Windows.Forms.TextBox()
        Me.TBrfc = New System.Windows.Forms.TextBox()
        Me.CBAdmin = New System.Windows.Forms.CheckBox()
        Me.CBEmpleado = New System.Windows.Forms.CheckBox()
        Me.ButtonGoback = New System.Windows.Forms.Button()
        Me.TBuser = New System.Windows.Forms.TextBox()
        Me.TBcontrasena = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBcalle = New System.Windows.Forms.TextBox()
        Me.TBnum = New System.Windows.Forms.TextBox()
        Me.TBcolonia = New System.Windows.Forms.TextBox()
        Me.TBmuni = New System.Windows.Forms.TextBox()
        Me.TBcp = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CBNSE = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lempleadomod = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Lagrimas = New System.Windows.Forms.Label()
        Me.Labeltoremember = New System.Windows.Forms.Label()
        Me.LparaId = New System.Windows.Forms.Label()
        Me.ELidUser = New System.Windows.Forms.Label()
        Me.Lforcurp = New System.Windows.Forms.Label()
        Me.Lnombreusuario = New System.Windows.Forms.Label()
        Me.Lparaunrfc = New System.Windows.Forms.Label()
        CType(Me.DTGregemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(793, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INGRESA DATOS DEL EMPLEADO A REGISTRAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'BAddEmployee
        '
        Me.BAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAddEmployee.ForeColor = System.Drawing.Color.White
        Me.BAddEmployee.Location = New System.Drawing.Point(469, 561)
        Me.BAddEmployee.Name = "BAddEmployee"
        Me.BAddEmployee.Size = New System.Drawing.Size(94, 29)
        Me.BAddEmployee.TabIndex = 2
        Me.BAddEmployee.Text = "Registrar"
        Me.BAddEmployee.UseVisualStyleBackColor = False
        '
        'BModifyEmployee
        '
        Me.BModifyEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModifyEmployee.ForeColor = System.Drawing.Color.White
        Me.BModifyEmployee.Location = New System.Drawing.Point(469, 513)
        Me.BModifyEmployee.Name = "BModifyEmployee"
        Me.BModifyEmployee.Size = New System.Drawing.Size(94, 29)
        Me.BModifyEmployee.TabIndex = 3
        Me.BModifyEmployee.Text = "Modificar"
        Me.BModifyEmployee.UseVisualStyleBackColor = False
        '
        'BShowemploy
        '
        Me.BShowemploy.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BShowemploy.ForeColor = System.Drawing.Color.White
        Me.BShowemploy.Location = New System.Drawing.Point(582, 513)
        Me.BShowemploy.Name = "BShowemploy"
        Me.BShowemploy.Size = New System.Drawing.Size(94, 29)
        Me.BShowemploy.TabIndex = 4
        Me.BShowemploy.Text = "Mostrar"
        Me.BShowemploy.UseVisualStyleBackColor = False
        '
        'BDeleteEmp
        '
        Me.BDeleteEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BDeleteEmp.ForeColor = System.Drawing.Color.White
        Me.BDeleteEmp.Location = New System.Drawing.Point(694, 513)
        Me.BDeleteEmp.Name = "BDeleteEmp"
        Me.BDeleteEmp.Size = New System.Drawing.Size(94, 29)
        Me.BDeleteEmp.TabIndex = 5
        Me.BDeleteEmp.Text = "Eliminar"
        Me.BDeleteEmp.UseVisualStyleBackColor = False
        '
        'DTGregemp
        '
        Me.DTGregemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGregemp.Location = New System.Drawing.Point(321, 358)
        Me.DTGregemp.Name = "DTGregemp"
        Me.DTGregemp.RowHeadersWidth = 51
        Me.DTGregemp.RowTemplate.Height = 29
        Me.DTGregemp.Size = New System.Drawing.Size(467, 149)
        Me.DTGregemp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(27, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(31, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CURP:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(31, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "RFC:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(27, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fecha de Nacimiento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(491, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Dirección"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(321, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Usuario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(321, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Contraseña:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(33, 422)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Tipo de Usuario:"
        '
        'TBnom
        '
        Me.TBnom.Location = New System.Drawing.Point(31, 93)
        Me.TBnom.Name = "TBnom"
        Me.TBnom.Size = New System.Drawing.Size(200, 27)
        Me.TBnom.TabIndex = 16
        '
        'TBLastnamep
        '
        Me.TBLastnamep.Location = New System.Drawing.Point(31, 164)
        Me.TBLastnamep.Name = "TBLastnamep"
        Me.TBLastnamep.Size = New System.Drawing.Size(200, 27)
        Me.TBLastnamep.TabIndex = 17
        '
        'TBLastnameM
        '
        Me.TBLastnameM.Location = New System.Drawing.Point(31, 236)
        Me.TBLastnameM.Name = "TBLastnameM"
        Me.TBLastnameM.Size = New System.Drawing.Size(200, 27)
        Me.TBLastnameM.TabIndex = 18
        '
        'TBcurp
        '
        Me.TBcurp.Location = New System.Drawing.Point(31, 303)
        Me.TBcurp.Name = "TBcurp"
        Me.TBcurp.Size = New System.Drawing.Size(200, 27)
        Me.TBcurp.TabIndex = 19
        '
        'TBrfc
        '
        Me.TBrfc.Location = New System.Drawing.Point(31, 373)
        Me.TBrfc.Name = "TBrfc"
        Me.TBrfc.Size = New System.Drawing.Size(200, 27)
        Me.TBrfc.TabIndex = 20
        '
        'CBAdmin
        '
        Me.CBAdmin.AutoSize = True
        Me.CBAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBAdmin.Location = New System.Drawing.Point(31, 445)
        Me.CBAdmin.Name = "CBAdmin"
        Me.CBAdmin.Size = New System.Drawing.Size(126, 24)
        Me.CBAdmin.TabIndex = 22
        Me.CBAdmin.Text = "Administrador"
        Me.CBAdmin.UseVisualStyleBackColor = False
        '
        'CBEmpleado
        '
        Me.CBEmpleado.AutoSize = True
        Me.CBEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBEmpleado.Location = New System.Drawing.Point(31, 475)
        Me.CBEmpleado.Name = "CBEmpleado"
        Me.CBEmpleado.Size = New System.Drawing.Size(99, 24)
        Me.CBEmpleado.TabIndex = 23
        Me.CBEmpleado.Text = "Empleado"
        Me.CBEmpleado.UseVisualStyleBackColor = False
        '
        'ButtonGoback
        '
        Me.ButtonGoback.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonGoback.ForeColor = System.Drawing.Color.White
        Me.ButtonGoback.Location = New System.Drawing.Point(694, 561)
        Me.ButtonGoback.Name = "ButtonGoback"
        Me.ButtonGoback.Size = New System.Drawing.Size(94, 29)
        Me.ButtonGoback.TabIndex = 24
        Me.ButtonGoback.Text = "Cancelar"
        Me.ButtonGoback.UseVisualStyleBackColor = False
        '
        'TBuser
        '
        Me.TBuser.Location = New System.Drawing.Point(321, 93)
        Me.TBuser.Name = "TBuser"
        Me.TBuser.Size = New System.Drawing.Size(200, 27)
        Me.TBuser.TabIndex = 25
        '
        'TBcontrasena
        '
        Me.TBcontrasena.Location = New System.Drawing.Point(321, 146)
        Me.TBcontrasena.Name = "TBcontrasena"
        Me.TBcontrasena.Size = New System.Drawing.Size(200, 27)
        Me.TBcontrasena.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(321, 196)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Calle:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(321, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Número:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(321, 302)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 20)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Colonia:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(546, 196)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Municipio:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(546, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 20)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Estado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(546, 302)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 20)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "C.P.:"
        '
        'TBcalle
        '
        Me.TBcalle.Location = New System.Drawing.Point(321, 219)
        Me.TBcalle.Name = "TBcalle"
        Me.TBcalle.Size = New System.Drawing.Size(200, 27)
        Me.TBcalle.TabIndex = 33
        '
        'TBnum
        '
        Me.TBnum.Location = New System.Drawing.Point(321, 272)
        Me.TBnum.Name = "TBnum"
        Me.TBnum.Size = New System.Drawing.Size(200, 27)
        Me.TBnum.TabIndex = 34
        '
        'TBcolonia
        '
        Me.TBcolonia.Location = New System.Drawing.Point(321, 325)
        Me.TBcolonia.Name = "TBcolonia"
        Me.TBcolonia.Size = New System.Drawing.Size(200, 27)
        Me.TBcolonia.TabIndex = 35
        '
        'TBmuni
        '
        Me.TBmuni.Location = New System.Drawing.Point(546, 219)
        Me.TBmuni.Name = "TBmuni"
        Me.TBmuni.Size = New System.Drawing.Size(200, 27)
        Me.TBmuni.TabIndex = 36
        '
        'TBcp
        '
        Me.TBcp.Location = New System.Drawing.Point(546, 325)
        Me.TBcp.Name = "TBcp"
        Me.TBcp.Size = New System.Drawing.Size(200, 27)
        Me.TBcp.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(546, 272)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 28)
        Me.ComboBox1.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 536)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(582, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 20)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Sucursales:"
        '
        'CBNSE
        '
        Me.CBNSE.FormattingEnabled = True
        Me.CBNSE.Location = New System.Drawing.Point(582, 93)
        Me.CBNSE.Name = "CBNSE"
        Me.CBNSE.Size = New System.Drawing.Size(151, 28)
        Me.CBNSE.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(582, 561)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Lempleadomod
        '
        Me.Lempleadomod.AutoSize = True
        Me.Lempleadomod.Location = New System.Drawing.Point(321, 522)
        Me.Lempleadomod.Name = "Lempleadomod"
        Me.Lempleadomod.Size = New System.Drawing.Size(17, 20)
        Me.Lempleadomod.TabIndex = 44
        Me.Lempleadomod.Text = "0"
        Me.Lempleadomod.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(624, -11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 20)
        Me.Label19.TabIndex = 45
        Me.Label19.Visible = False
        '
        'Lagrimas
        '
        Me.Lagrimas.AutoSize = True
        Me.Lagrimas.Location = New System.Drawing.Point(669, 70)
        Me.Lagrimas.Name = "Lagrimas"
        Me.Lagrimas.Size = New System.Drawing.Size(61, 20)
        Me.Lagrimas.TabIndex = 46
        Me.Lagrimas.Text = "Label20"
        Me.Lagrimas.Visible = False
        '
        'Labeltoremember
        '
        Me.Labeltoremember.AutoSize = True
        Me.Labeltoremember.Location = New System.Drawing.Point(547, 135)
        Me.Labeltoremember.Name = "Labeltoremember"
        Me.Labeltoremember.Size = New System.Drawing.Size(61, 20)
        Me.Labeltoremember.TabIndex = 47
        Me.Labeltoremember.Text = "Label20"
        Me.Labeltoremember.Visible = False
        '
        'LparaId
        '
        Me.LparaId.AutoSize = True
        Me.LparaId.Location = New System.Drawing.Point(599, 164)
        Me.LparaId.Name = "LparaId"
        Me.LparaId.Size = New System.Drawing.Size(61, 20)
        Me.LparaId.TabIndex = 48
        Me.LparaId.Text = "Label20"
        Me.LparaId.Visible = False
        '
        'ELidUser
        '
        Me.ELidUser.AutoSize = True
        Me.ELidUser.Location = New System.Drawing.Point(624, 129)
        Me.ELidUser.Name = "ELidUser"
        Me.ELidUser.Size = New System.Drawing.Size(61, 20)
        Me.ELidUser.TabIndex = 49
        Me.ELidUser.Text = "Label20"
        Me.ELidUser.Visible = False
        '
        'Lforcurp
        '
        Me.Lforcurp.AutoSize = True
        Me.Lforcurp.Location = New System.Drawing.Point(361, 536)
        Me.Lforcurp.Name = "Lforcurp"
        Me.Lforcurp.Size = New System.Drawing.Size(61, 20)
        Me.Lforcurp.TabIndex = 50
        Me.Lforcurp.Text = "Label20"
        Me.Lforcurp.Visible = False
        '
        'Lnombreusuario
        '
        Me.Lnombreusuario.AutoSize = True
        Me.Lnombreusuario.Location = New System.Drawing.Point(305, 565)
        Me.Lnombreusuario.Name = "Lnombreusuario"
        Me.Lnombreusuario.Size = New System.Drawing.Size(61, 20)
        Me.Lnombreusuario.TabIndex = 51
        Me.Lnombreusuario.Text = "Label20"
        Me.Lnombreusuario.Visible = False
        '
        'Lparaunrfc
        '
        Me.Lparaunrfc.AutoSize = True
        Me.Lparaunrfc.Location = New System.Drawing.Point(185, 449)
        Me.Lparaunrfc.Name = "Lparaunrfc"
        Me.Lparaunrfc.Size = New System.Drawing.Size(61, 20)
        Me.Lparaunrfc.TabIndex = 52
        Me.Lparaunrfc.Text = "Label20"
        Me.Lparaunrfc.Visible = False
        '
        'ADDEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(813, 603)
        Me.Controls.Add(Me.Lparaunrfc)
        Me.Controls.Add(Me.Lnombreusuario)
        Me.Controls.Add(Me.Lforcurp)
        Me.Controls.Add(Me.ELidUser)
        Me.Controls.Add(Me.LparaId)
        Me.Controls.Add(Me.Labeltoremember)
        Me.Controls.Add(Me.Lagrimas)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Lempleadomod)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBNSE)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TBcp)
        Me.Controls.Add(Me.TBmuni)
        Me.Controls.Add(Me.TBcolonia)
        Me.Controls.Add(Me.TBnum)
        Me.Controls.Add(Me.TBcalle)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBcontrasena)
        Me.Controls.Add(Me.TBuser)
        Me.Controls.Add(Me.ButtonGoback)
        Me.Controls.Add(Me.CBEmpleado)
        Me.Controls.Add(Me.CBAdmin)
        Me.Controls.Add(Me.TBrfc)
        Me.Controls.Add(Me.TBcurp)
        Me.Controls.Add(Me.TBLastnameM)
        Me.Controls.Add(Me.TBLastnamep)
        Me.Controls.Add(Me.TBnom)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTGregemp)
        Me.Controls.Add(Me.BDeleteEmp)
        Me.Controls.Add(Me.BShowemploy)
        Me.Controls.Add(Me.BModifyEmployee)
        Me.Controls.Add(Me.BAddEmployee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ADDEmpleado"
        Me.Text = "Haz tu cuenta"
        CType(Me.DTGregemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BAddEmployee As Button
    Friend WithEvents BModifyEmployee As Button
    Friend WithEvents BShowemploy As Button
    Friend WithEvents BDeleteEmp As Button
    Friend WithEvents DTGregemp As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TBnom As TextBox
    Friend WithEvents TBLastnamep As TextBox
    Friend WithEvents TBLastnameM As TextBox
    Friend WithEvents TBcurp As TextBox
    Friend WithEvents TBrfc As TextBox
    Friend WithEvents CBAdmin As CheckBox
    Friend WithEvents CBEmpleado As CheckBox
    Friend WithEvents ButtonGoback As Button
    Friend WithEvents TBuser As TextBox
    Friend WithEvents TBcontrasena As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBcalle As TextBox
    Friend WithEvents TBnum As TextBox
    Friend WithEvents TBcolonia As TextBox
    Friend WithEvents TBmuni As TextBox
    Friend WithEvents TBcp As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents CBNSE As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Lempleadomod As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Lagrimas As Label
    Friend WithEvents Labeltoremember As Label
    Friend WithEvents IDempleado As Label
    Friend WithEvents LparaId As Label
    Friend WithEvents ELidUser As Label
    Friend WithEvents Lforcurp As Label
    Friend WithEvents Lnombreusuario As Label
    Friend WithEvents Lparaunrfc As Label
End Class
