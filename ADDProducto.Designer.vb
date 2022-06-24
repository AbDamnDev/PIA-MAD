<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADDProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADDProducto))
        Me.Bcancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TX = New System.Windows.Forms.TextBox()
        Me.TDescProduct = New System.Windows.Forms.TextBox()
        Me.TPriceProduct = New System.Windows.Forms.TextBox()
        Me.TMinusProduct = New System.Windows.Forms.TextBox()
        Me.TCatProduct = New System.Windows.Forms.TextBox()
        Me.DGVProducto = New System.Windows.Forms.DataGridView()
        Me.Buttonadd = New System.Windows.Forms.Button()
        Me.Bmod = New System.Windows.Forms.Button()
        Me.Bshow = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BCleanp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TStockP = New System.Windows.Forms.TextBox()
        Me.CBsucursal = New System.Windows.Forms.ComboBox()
        Me.SecretLabel = New System.Windows.Forms.Label()
        Me.CBShowPS = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SecretLabel2 = New System.Windows.Forms.Label()
        Me.Lidp = New System.Windows.Forms.Label()
        Me.Lidsp = New System.Windows.Forms.Label()
        Me.SucursalLBP = New System.Windows.Forms.Label()
        Me.BMassCP = New System.Windows.Forms.Button()
        Me.lnew = New System.Windows.Forms.Label()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bcancel
        '
        Me.Bcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bcancel.ForeColor = System.Drawing.Color.White
        Me.Bcancel.Location = New System.Drawing.Point(638, 383)
        Me.Bcancel.Name = "Bcancel"
        Me.Bcancel.Size = New System.Drawing.Size(94, 29)
        Me.Bcancel.TabIndex = 0
        Me.Bcancel.Text = "Cancelar"
        Me.Bcancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción del Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Descuento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Categoría:"
        '
        'TX
        '
        Me.TX.Location = New System.Drawing.Point(13, 86)
        Me.TX.Name = "TX"
        Me.TX.Size = New System.Drawing.Size(178, 27)
        Me.TX.TabIndex = 7
        '
        'TDescProduct
        '
        Me.TDescProduct.Location = New System.Drawing.Point(13, 153)
        Me.TDescProduct.Name = "TDescProduct"
        Me.TDescProduct.Size = New System.Drawing.Size(178, 27)
        Me.TDescProduct.TabIndex = 8
        '
        'TPriceProduct
        '
        Me.TPriceProduct.Location = New System.Drawing.Point(13, 210)
        Me.TPriceProduct.Name = "TPriceProduct"
        Me.TPriceProduct.Size = New System.Drawing.Size(178, 27)
        Me.TPriceProduct.TabIndex = 9
        '
        'TMinusProduct
        '
        Me.TMinusProduct.Location = New System.Drawing.Point(13, 269)
        Me.TMinusProduct.Name = "TMinusProduct"
        Me.TMinusProduct.Size = New System.Drawing.Size(178, 27)
        Me.TMinusProduct.TabIndex = 10
        '
        'TCatProduct
        '
        Me.TCatProduct.Location = New System.Drawing.Point(13, 322)
        Me.TCatProduct.Name = "TCatProduct"
        Me.TCatProduct.Size = New System.Drawing.Size(178, 27)
        Me.TCatProduct.TabIndex = 11
        '
        'DGVProducto
        '
        Me.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProducto.Location = New System.Drawing.Point(390, 106)
        Me.DGVProducto.Name = "DGVProducto"
        Me.DGVProducto.RowHeadersWidth = 51
        Me.DGVProducto.RowTemplate.Height = 29
        Me.DGVProducto.Size = New System.Drawing.Size(342, 243)
        Me.DGVProducto.TabIndex = 12
        '
        'Buttonadd
        '
        Me.Buttonadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Buttonadd.ForeColor = System.Drawing.Color.White
        Me.Buttonadd.Location = New System.Drawing.Point(13, 383)
        Me.Buttonadd.Name = "Buttonadd"
        Me.Buttonadd.Size = New System.Drawing.Size(94, 29)
        Me.Buttonadd.TabIndex = 13
        Me.Buttonadd.Text = "Agregar"
        Me.Buttonadd.UseVisualStyleBackColor = False
        '
        'Bmod
        '
        Me.Bmod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bmod.ForeColor = System.Drawing.Color.White
        Me.Bmod.Location = New System.Drawing.Point(538, 383)
        Me.Bmod.Name = "Bmod"
        Me.Bmod.Size = New System.Drawing.Size(94, 29)
        Me.Bmod.TabIndex = 14
        Me.Bmod.Text = "Modificar"
        Me.Bmod.UseVisualStyleBackColor = False
        '
        'Bshow
        '
        Me.Bshow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bshow.ForeColor = System.Drawing.Color.White
        Me.Bshow.Location = New System.Drawing.Point(128, 383)
        Me.Bshow.Name = "Bshow"
        Me.Bshow.Size = New System.Drawing.Size(94, 29)
        Me.Bshow.TabIndex = 15
        Me.Bshow.Text = "Mostrar"
        Me.Bshow.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(581, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sucursal:"
        '
        'BCleanp
        '
        Me.BCleanp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCleanp.ForeColor = System.Drawing.Color.White
        Me.BCleanp.Location = New System.Drawing.Point(239, 383)
        Me.BCleanp.Name = "BCleanp"
        Me.BCleanp.Size = New System.Drawing.Size(94, 29)
        Me.BCleanp.TabIndex = 18
        Me.BCleanp.Text = "Limpiar"
        Me.BCleanp.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(390, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Stock:"
        '
        'TStockP
        '
        Me.TStockP.Location = New System.Drawing.Point(390, 36)
        Me.TStockP.Name = "TStockP"
        Me.TStockP.Size = New System.Drawing.Size(151, 27)
        Me.TStockP.TabIndex = 20
        '
        'CBsucursal
        '
        Me.CBsucursal.FormattingEnabled = True
        Me.CBsucursal.Location = New System.Drawing.Point(581, 36)
        Me.CBsucursal.Name = "CBsucursal"
        Me.CBsucursal.Size = New System.Drawing.Size(151, 28)
        Me.CBsucursal.TabIndex = 22
        '
        'SecretLabel
        '
        Me.SecretLabel.AutoSize = True
        Me.SecretLabel.Location = New System.Drawing.Point(390, 70)
        Me.SecretLabel.Name = "SecretLabel"
        Me.SecretLabel.Size = New System.Drawing.Size(53, 20)
        Me.SecretLabel.TabIndex = 23
        Me.SecretLabel.Text = "Label9"
        Me.SecretLabel.Visible = False
        '
        'CBShowPS
        '
        Me.CBShowPS.FormattingEnabled = True
        Me.CBShowPS.Location = New System.Drawing.Point(370, 383)
        Me.CBShowPS.Name = "CBShowPS"
        Me.CBShowPS.Size = New System.Drawing.Size(151, 28)
        Me.CBShowPS.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(370, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Sucursal para ver productos:"
        '
        'SecretLabel2
        '
        Me.SecretLabel2.AutoSize = True
        Me.SecretLabel2.Location = New System.Drawing.Point(485, 70)
        Me.SecretLabel2.Name = "SecretLabel2"
        Me.SecretLabel2.Size = New System.Drawing.Size(94, 20)
        Me.SecretLabel2.TabIndex = 26
        Me.SecretLabel2.Text = "SecretLabel2"
        Me.SecretLabel2.Visible = False
        '
        'Lidp
        '
        Me.Lidp.AutoSize = True
        Me.Lidp.Location = New System.Drawing.Point(239, 124)
        Me.Lidp.Name = "Lidp"
        Me.Lidp.Size = New System.Drawing.Size(61, 20)
        Me.Lidp.TabIndex = 27
        Me.Lidp.Text = "Label10"
        Me.Lidp.Visible = False
        '
        'Lidsp
        '
        Me.Lidsp.AutoSize = True
        Me.Lidsp.Location = New System.Drawing.Point(239, 153)
        Me.Lidsp.Name = "Lidsp"
        Me.Lidsp.Size = New System.Drawing.Size(61, 20)
        Me.Lidsp.TabIndex = 28
        Me.Lidsp.Text = "Label10"
        Me.Lidsp.Visible = False
        '
        'SucursalLBP
        '
        Me.SucursalLBP.AutoSize = True
        Me.SucursalLBP.Location = New System.Drawing.Point(654, 13)
        Me.SucursalLBP.Name = "SucursalLBP"
        Me.SucursalLBP.Size = New System.Drawing.Size(0, 20)
        Me.SucursalLBP.TabIndex = 29
        Me.SucursalLBP.Visible = False
        '
        'BMassCP
        '
        Me.BMassCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BMassCP.ForeColor = System.Drawing.Color.White
        Me.BMassCP.Location = New System.Drawing.Point(599, 351)
        Me.BMassCP.Name = "BMassCP"
        Me.BMassCP.Size = New System.Drawing.Size(133, 29)
        Me.BMassCP.TabIndex = 30
        Me.BMassCP.Text = "Carga Masiva"
        Me.BMassCP.UseVisualStyleBackColor = False
        '
        'lnew
        '
        Me.lnew.AutoSize = True
        Me.lnew.Location = New System.Drawing.Point(250, 211)
        Me.lnew.Name = "lnew"
        Me.lnew.Size = New System.Drawing.Size(61, 20)
        Me.lnew.TabIndex = 31
        Me.lnew.Text = "Label10"
        Me.lnew.Visible = False
        '
        'ADDProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lnew)
        Me.Controls.Add(Me.BMassCP)
        Me.Controls.Add(Me.SucursalLBP)
        Me.Controls.Add(Me.Lidsp)
        Me.Controls.Add(Me.Lidp)
        Me.Controls.Add(Me.SecretLabel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBShowPS)
        Me.Controls.Add(Me.SecretLabel)
        Me.Controls.Add(Me.CBsucursal)
        Me.Controls.Add(Me.TStockP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BCleanp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bshow)
        Me.Controls.Add(Me.Bmod)
        Me.Controls.Add(Me.Buttonadd)
        Me.Controls.Add(Me.DGVProducto)
        Me.Controls.Add(Me.TCatProduct)
        Me.Controls.Add(Me.TMinusProduct)
        Me.Controls.Add(Me.TPriceProduct)
        Me.Controls.Add(Me.TDescProduct)
        Me.Controls.Add(Me.TX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bcancel)
        Me.Name = "ADDProducto"
        Me.Text = "ADDProducto"
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bcancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TX As TextBox
    Friend WithEvents TDescProduct As TextBox
    Friend WithEvents TPriceProduct As TextBox
    Friend WithEvents TMinusProduct As TextBox
    Friend WithEvents TCatProduct As TextBox
    Friend WithEvents DGVProducto As DataGridView
    Friend WithEvents Buttonadd As Button
    Friend WithEvents Bmod As Button
    Friend WithEvents Bshow As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BCleanp As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TStockP As TextBox
    Friend WithEvents CBsucursal As ComboBox
    Friend WithEvents SecretLabel As Label
    Friend WithEvents CBShowPS As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SecretLabel2 As Label
    Friend WithEvents Lidp As Label
    Friend WithEvents Lidsp As Label
    Friend WithEvents SucursalLBP As Label
    Friend WithEvents BMassCP As Button
    Friend WithEvents lnew As Label
End Class
