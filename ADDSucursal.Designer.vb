<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADDSucursal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonBye = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Baddtienda = New System.Windows.Forms.Button()
        Me.Bmodtienda = New System.Windows.Forms.Button()
        Me.Bshowtienda = New System.Windows.Forms.Button()
        Me.DGVsucursal = New System.Windows.Forms.DataGridView()
        Me.Tnamesucur = New System.Windows.Forms.TextBox()
        Me.Tcallesucur = New System.Windows.Forms.TextBox()
        Me.Tnumsucur = New System.Windows.Forms.TextBox()
        Me.Tcoloniasucur = New System.Windows.Forms.TextBox()
        Me.Tmunisucur = New System.Windows.Forms.TextBox()
        Me.Tcpsucur = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LState = New System.Windows.Forms.Label()
        Me.BlimipiaS = New System.Windows.Forms.Button()
        Me.Labelmodsuc = New System.Windows.Forms.Label()
        Me.BCargasucurmasiva = New System.Windows.Forms.Button()
        Me.CBencargado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lmamamia = New System.Windows.Forms.Label()
        Me.LparID = New System.Windows.Forms.Label()
        CType(Me.DGVsucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'ButtonBye
        '
        Me.ButtonBye.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonBye.Location = New System.Drawing.Point(694, 409)
        Me.ButtonBye.Name = "ButtonBye"
        Me.ButtonBye.Size = New System.Drawing.Size(94, 29)
        Me.ButtonBye.TabIndex = 1
        Me.ButtonBye.Text = "Cancelar"
        Me.ButtonBye.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de la Sucursal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Calle:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(307, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Número:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(569, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Colonia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Municipio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(308, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Estado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(569, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "C.P.:"
        '
        'Baddtienda
        '
        Me.Baddtienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baddtienda.Location = New System.Drawing.Point(13, 409)
        Me.Baddtienda.Name = "Baddtienda"
        Me.Baddtienda.Size = New System.Drawing.Size(94, 29)
        Me.Baddtienda.TabIndex = 11
        Me.Baddtienda.Text = "Ingresar"
        Me.Baddtienda.UseVisualStyleBackColor = False
        '
        'Bmodtienda
        '
        Me.Bmodtienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bmodtienda.Location = New System.Drawing.Point(113, 409)
        Me.Bmodtienda.Name = "Bmodtienda"
        Me.Bmodtienda.Size = New System.Drawing.Size(94, 29)
        Me.Bmodtienda.TabIndex = 12
        Me.Bmodtienda.Text = "Modificar"
        Me.Bmodtienda.UseVisualStyleBackColor = False
        '
        'Bshowtienda
        '
        Me.Bshowtienda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bshowtienda.Location = New System.Drawing.Point(213, 409)
        Me.Bshowtienda.Name = "Bshowtienda"
        Me.Bshowtienda.Size = New System.Drawing.Size(94, 29)
        Me.Bshowtienda.TabIndex = 13
        Me.Bshowtienda.Text = "Mostrar"
        Me.Bshowtienda.UseVisualStyleBackColor = False
        '
        'DGVsucursal
        '
        Me.DGVsucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVsucursal.Location = New System.Drawing.Point(307, 13)
        Me.DGVsucursal.Name = "DGVsucursal"
        Me.DGVsucursal.RowHeadersWidth = 51
        Me.DGVsucursal.RowTemplate.Height = 29
        Me.DGVsucursal.Size = New System.Drawing.Size(481, 209)
        Me.DGVsucursal.TabIndex = 14
        '
        'Tnamesucur
        '
        Me.Tnamesucur.Location = New System.Drawing.Point(13, 76)
        Me.Tnamesucur.Name = "Tnamesucur"
        Me.Tnamesucur.Size = New System.Drawing.Size(219, 27)
        Me.Tnamesucur.TabIndex = 15
        '
        'Tcallesucur
        '
        Me.Tcallesucur.Location = New System.Drawing.Point(13, 267)
        Me.Tcallesucur.Name = "Tcallesucur"
        Me.Tcallesucur.Size = New System.Drawing.Size(219, 27)
        Me.Tcallesucur.TabIndex = 17
        '
        'Tnumsucur
        '
        Me.Tnumsucur.Location = New System.Drawing.Point(308, 267)
        Me.Tnumsucur.Name = "Tnumsucur"
        Me.Tnumsucur.Size = New System.Drawing.Size(219, 27)
        Me.Tnumsucur.TabIndex = 18
        '
        'Tcoloniasucur
        '
        Me.Tcoloniasucur.Location = New System.Drawing.Point(569, 267)
        Me.Tcoloniasucur.Name = "Tcoloniasucur"
        Me.Tcoloniasucur.Size = New System.Drawing.Size(219, 27)
        Me.Tcoloniasucur.TabIndex = 19
        '
        'Tmunisucur
        '
        Me.Tmunisucur.Location = New System.Drawing.Point(13, 345)
        Me.Tmunisucur.Name = "Tmunisucur"
        Me.Tmunisucur.Size = New System.Drawing.Size(219, 27)
        Me.Tmunisucur.TabIndex = 20
        '
        'Tcpsucur
        '
        Me.Tcpsucur.Location = New System.Drawing.Point(569, 345)
        Me.Tcpsucur.Name = "Tcpsucur"
        Me.Tcpsucur.Size = New System.Drawing.Size(219, 27)
        Me.Tcpsucur.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(308, 346)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(219, 28)
        Me.ComboBox2.TabIndex = 22
        '
        'LState
        '
        Me.LState.AutoSize = True
        Me.LState.Location = New System.Drawing.Point(371, 323)
        Me.LState.Name = "LState"
        Me.LState.Size = New System.Drawing.Size(0, 20)
        Me.LState.TabIndex = 23
        Me.LState.Visible = False
        '
        'BlimipiaS
        '
        Me.BlimipiaS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BlimipiaS.Location = New System.Drawing.Point(585, 409)
        Me.BlimipiaS.Name = "BlimipiaS"
        Me.BlimipiaS.Size = New System.Drawing.Size(94, 29)
        Me.BlimipiaS.TabIndex = 24
        Me.BlimipiaS.Text = "Limpiar"
        Me.BlimipiaS.UseVisualStyleBackColor = False
        '
        'Labelmodsuc
        '
        Me.Labelmodsuc.AutoSize = True
        Me.Labelmodsuc.Location = New System.Drawing.Point(394, 397)
        Me.Labelmodsuc.Name = "Labelmodsuc"
        Me.Labelmodsuc.Size = New System.Drawing.Size(53, 20)
        Me.Labelmodsuc.TabIndex = 25
        Me.Labelmodsuc.Text = "Label3"
        Me.Labelmodsuc.Visible = False
        '
        'BCargasucurmasiva
        '
        Me.BCargasucurmasiva.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BCargasucurmasiva.Location = New System.Drawing.Point(433, 409)
        Me.BCargasucurmasiva.Name = "BCargasucurmasiva"
        Me.BCargasucurmasiva.Size = New System.Drawing.Size(146, 29)
        Me.BCargasucurmasiva.TabIndex = 27
        Me.BCargasucurmasiva.Text = "Carga Masiva"
        Me.BCargasucurmasiva.UseVisualStyleBackColor = False
        '
        'CBencargado
        '
        Me.CBencargado.FormattingEnabled = True
        Me.CBencargado.Location = New System.Drawing.Point(13, 147)
        Me.CBencargado.Name = "CBencargado"
        Me.CBencargado.Size = New System.Drawing.Size(151, 28)
        Me.CBencargado.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Encargado"
        '
        'lmamamia
        '
        Me.lmamamia.AutoSize = True
        Me.lmamamia.Location = New System.Drawing.Point(223, 196)
        Me.lmamamia.Name = "lmamamia"
        Me.lmamamia.Size = New System.Drawing.Size(61, 20)
        Me.lmamamia.TabIndex = 30
        Me.lmamamia.Text = "Label11"
        Me.lmamamia.Visible = False
        '
        'LparID
        '
        Me.LparID.AutoSize = True
        Me.LparID.Location = New System.Drawing.Point(223, 131)
        Me.LparID.Name = "LparID"
        Me.LparID.Size = New System.Drawing.Size(61, 20)
        Me.LparID.TabIndex = 31
        Me.LparID.Text = "Label11"
        Me.LparID.Visible = False
        '
        'ADDSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LparID)
        Me.Controls.Add(Me.lmamamia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBencargado)
        Me.Controls.Add(Me.BCargasucurmasiva)
        Me.Controls.Add(Me.Labelmodsuc)
        Me.Controls.Add(Me.BlimipiaS)
        Me.Controls.Add(Me.LState)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Tcpsucur)
        Me.Controls.Add(Me.Tmunisucur)
        Me.Controls.Add(Me.Tcoloniasucur)
        Me.Controls.Add(Me.Tnumsucur)
        Me.Controls.Add(Me.Tcallesucur)
        Me.Controls.Add(Me.Tnamesucur)
        Me.Controls.Add(Me.DGVsucursal)
        Me.Controls.Add(Me.Bshowtienda)
        Me.Controls.Add(Me.Bmodtienda)
        Me.Controls.Add(Me.Baddtienda)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonBye)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ADDSucursal"
        Me.Text = "ADDSucursal"
        CType(Me.DGVsucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonBye As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Baddtienda As Button
    Friend WithEvents Bmodtienda As Button
    Friend WithEvents Bshowtienda As Button
    Friend WithEvents DGVsucursal As DataGridView
    Friend WithEvents Tnamesucur As TextBox
    Friend WithEvents Tcallesucur As TextBox
    Friend WithEvents Tnumsucur As TextBox
    Friend WithEvents Tcoloniasucur As TextBox
    Friend WithEvents Tmunisucur As TextBox
    Friend WithEvents Tcpsucur As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LState As Label
    Friend WithEvents BlimipiaS As Button
    Friend WithEvents Labelmodsuc As Label
    Friend WithEvents BCargasucurmasiva As Button
    Friend WithEvents CBencargado As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lmamamia As Label
    Friend WithEvents LparID As Label
End Class
