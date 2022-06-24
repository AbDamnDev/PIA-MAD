<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carrito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Carrito))
        Me.DGVMISHOOPIN = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.LSUCURSAL = New System.Windows.Forms.Label()
        Me.LNumCarrito = New System.Windows.Forms.Label()
        Me.CBefectivo = New System.Windows.Forms.CheckBox()
        Me.CBtarjeta = New System.Windows.Forms.CheckBox()
        Me.Bmevoy = New System.Windows.Forms.Button()
        Me.Bcomprar = New System.Windows.Forms.Button()
        Me.DGVtarjetass = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBtucasa = New System.Windows.Forms.CheckBox()
        Me.CBentienda = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LApagar = New System.Windows.Forms.Label()
        Me.Bquitar = New System.Windows.Forms.Button()
        Me.Bmodificar = New System.Windows.Forms.Button()
        Me.LDiscount = New System.Windows.Forms.Label()
        Me.Labeldisc = New System.Windows.Forms.Label()
        Me.BMAS = New System.Windows.Forms.Button()
        Me.BMENOS = New System.Windows.Forms.Button()
        Me.Tcanti = New System.Windows.Forms.TextBox()
        Me.LPSTOCK = New System.Windows.Forms.Label()
        Me.LtarjetaS = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalfinal = New System.Windows.Forms.Label()
        CType(Me.DGVMISHOOPIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVtarjetass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMISHOOPIN
        '
        Me.DGVMISHOOPIN.AllowUserToAddRows = False
        Me.DGVMISHOOPIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMISHOOPIN.Location = New System.Drawing.Point(12, 387)
        Me.DGVMISHOOPIN.Name = "DGVMISHOOPIN"
        Me.DGVMISHOOPIN.RowHeadersWidth = 51
        Me.DGVMISHOOPIN.RowTemplate.Height = 29
        Me.DGVMISHOOPIN.Size = New System.Drawing.Size(770, 221)
        Me.DGVMISHOOPIN.TabIndex = 0
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.BackColor = System.Drawing.Color.Transparent
        Me.Cliente.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Cliente.Location = New System.Drawing.Point(13, 13)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(67, 24)
        Me.Cliente.TabIndex = 1
        Me.Cliente.Text = "Label1"
        '
        'LSUCURSAL
        '
        Me.LSUCURSAL.AutoSize = True
        Me.LSUCURSAL.BackColor = System.Drawing.Color.Transparent
        Me.LSUCURSAL.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LSUCURSAL.Location = New System.Drawing.Point(13, 55)
        Me.LSUCURSAL.Name = "LSUCURSAL"
        Me.LSUCURSAL.Size = New System.Drawing.Size(61, 24)
        Me.LSUCURSAL.TabIndex = 2
        Me.LSUCURSAL.Text = "Label1"
        '
        'LNumCarrito
        '
        Me.LNumCarrito.AutoSize = True
        Me.LNumCarrito.BackColor = System.Drawing.Color.Transparent
        Me.LNumCarrito.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LNumCarrito.ForeColor = System.Drawing.Color.Black
        Me.LNumCarrito.Location = New System.Drawing.Point(13, 97)
        Me.LNumCarrito.Name = "LNumCarrito"
        Me.LNumCarrito.Size = New System.Drawing.Size(0, 24)
        Me.LNumCarrito.TabIndex = 3
        '
        'CBefectivo
        '
        Me.CBefectivo.AutoSize = True
        Me.CBefectivo.BackColor = System.Drawing.Color.Transparent
        Me.CBefectivo.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBefectivo.Location = New System.Drawing.Point(697, 32)
        Me.CBefectivo.Name = "CBefectivo"
        Me.CBefectivo.Size = New System.Drawing.Size(91, 26)
        Me.CBefectivo.TabIndex = 4
        Me.CBefectivo.Text = "Efectivo"
        Me.CBefectivo.UseVisualStyleBackColor = False
        '
        'CBtarjeta
        '
        Me.CBtarjeta.AutoSize = True
        Me.CBtarjeta.BackColor = System.Drawing.Color.Transparent
        Me.CBtarjeta.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBtarjeta.Location = New System.Drawing.Point(697, 67)
        Me.CBtarjeta.Name = "CBtarjeta"
        Me.CBtarjeta.Size = New System.Drawing.Size(84, 26)
        Me.CBtarjeta.TabIndex = 5
        Me.CBtarjeta.Text = "Tarjeta"
        Me.CBtarjeta.UseVisualStyleBackColor = False
        '
        'Bmevoy
        '
        Me.Bmevoy.Location = New System.Drawing.Point(921, 579)
        Me.Bmevoy.Name = "Bmevoy"
        Me.Bmevoy.Size = New System.Drawing.Size(94, 29)
        Me.Bmevoy.TabIndex = 6
        Me.Bmevoy.Text = "Cancelar"
        Me.Bmevoy.UseVisualStyleBackColor = True
        '
        'Bcomprar
        '
        Me.Bcomprar.Location = New System.Drawing.Point(821, 579)
        Me.Bcomprar.Name = "Bcomprar"
        Me.Bcomprar.Size = New System.Drawing.Size(94, 29)
        Me.Bcomprar.TabIndex = 7
        Me.Bcomprar.Text = "Comprar"
        Me.Bcomprar.UseVisualStyleBackColor = True
        '
        'DGVtarjetass
        '
        Me.DGVtarjetass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtarjetass.Location = New System.Drawing.Point(697, 97)
        Me.DGVtarjetass.Name = "DGVtarjetass"
        Me.DGVtarjetass.RowHeadersWidth = 51
        Me.DGVtarjetass.RowTemplate.Height = 29
        Me.DGVtarjetass.Size = New System.Drawing.Size(318, 189)
        Me.DGVtarjetass.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(697, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Métodos de Pago"
        '
        'CBtucasa
        '
        Me.CBtucasa.AutoSize = True
        Me.CBtucasa.BackColor = System.Drawing.Color.Transparent
        Me.CBtucasa.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBtucasa.Location = New System.Drawing.Point(422, 13)
        Me.CBtucasa.Name = "CBtucasa"
        Me.CBtucasa.Size = New System.Drawing.Size(163, 27)
        Me.CBtucasa.TabIndex = 10
        Me.CBtucasa.Text = "Envío a Domicilio"
        Me.CBtucasa.UseVisualStyleBackColor = False
        '
        'CBentienda
        '
        Me.CBentienda.AutoSize = True
        Me.CBentienda.BackColor = System.Drawing.Color.Transparent
        Me.CBentienda.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CBentienda.Location = New System.Drawing.Point(422, 51)
        Me.CBentienda.Name = "CBentienda"
        Me.CBentienda.Size = New System.Drawing.Size(174, 27)
        Me.CBentienda.TabIndex = 11
        Me.CBentienda.Text = "Recoger en Tienda"
        Me.CBentienda.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio:"
        '
        'LApagar
        '
        Me.LApagar.AutoSize = True
        Me.LApagar.BackColor = System.Drawing.Color.Transparent
        Me.LApagar.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LApagar.Location = New System.Drawing.Point(13, 208)
        Me.LApagar.Name = "LApagar"
        Me.LApagar.Size = New System.Drawing.Size(0, 27)
        Me.LApagar.TabIndex = 13
        '
        'Bquitar
        '
        Me.Bquitar.Enabled = False
        Me.Bquitar.Location = New System.Drawing.Point(789, 503)
        Me.Bquitar.Name = "Bquitar"
        Me.Bquitar.Size = New System.Drawing.Size(126, 29)
        Me.Bquitar.TabIndex = 14
        Me.Bquitar.Text = "Eliminar"
        Me.Bquitar.UseVisualStyleBackColor = True
        '
        'Bmodificar
        '
        Me.Bmodificar.Enabled = False
        Me.Bmodificar.Location = New System.Drawing.Point(788, 468)
        Me.Bmodificar.Name = "Bmodificar"
        Me.Bmodificar.Size = New System.Drawing.Size(127, 29)
        Me.Bmodificar.TabIndex = 15
        Me.Bmodificar.Text = "Modificar"
        Me.Bmodificar.UseVisualStyleBackColor = True
        '
        'LDiscount
        '
        Me.LDiscount.AutoSize = True
        Me.LDiscount.BackColor = System.Drawing.Color.Transparent
        Me.LDiscount.Font = New System.Drawing.Font("Segoe UI Emoji", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LDiscount.Location = New System.Drawing.Point(235, 176)
        Me.LDiscount.Name = "LDiscount"
        Me.LDiscount.Size = New System.Drawing.Size(200, 31)
        Me.LDiscount.TabIndex = 16
        Me.LDiscount.Text = "Descuento Total:"
        '
        'Labeldisc
        '
        Me.Labeldisc.AutoSize = True
        Me.Labeldisc.BackColor = System.Drawing.Color.Transparent
        Me.Labeldisc.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labeldisc.Location = New System.Drawing.Point(235, 208)
        Me.Labeldisc.Name = "Labeldisc"
        Me.Labeldisc.Size = New System.Drawing.Size(0, 27)
        Me.Labeldisc.TabIndex = 17
        '
        'BMAS
        '
        Me.BMAS.Enabled = False
        Me.BMAS.Location = New System.Drawing.Point(886, 419)
        Me.BMAS.Name = "BMAS"
        Me.BMAS.Size = New System.Drawing.Size(29, 29)
        Me.BMAS.TabIndex = 18
        Me.BMAS.Text = "+"
        Me.BMAS.UseVisualStyleBackColor = True
        '
        'BMENOS
        '
        Me.BMENOS.Enabled = False
        Me.BMENOS.Location = New System.Drawing.Point(789, 419)
        Me.BMENOS.Name = "BMENOS"
        Me.BMENOS.Size = New System.Drawing.Size(29, 29)
        Me.BMENOS.TabIndex = 19
        Me.BMENOS.Text = "-"
        Me.BMENOS.UseVisualStyleBackColor = True
        '
        'Tcanti
        '
        Me.Tcanti.Enabled = False
        Me.Tcanti.Location = New System.Drawing.Point(824, 420)
        Me.Tcanti.Name = "Tcanti"
        Me.Tcanti.Size = New System.Drawing.Size(50, 27)
        Me.Tcanti.TabIndex = 20
        '
        'LPSTOCK
        '
        Me.LPSTOCK.AutoSize = True
        Me.LPSTOCK.Location = New System.Drawing.Point(365, 254)
        Me.LPSTOCK.Name = "LPSTOCK"
        Me.LPSTOCK.Size = New System.Drawing.Size(53, 20)
        Me.LPSTOCK.TabIndex = 22
        Me.LPSTOCK.Text = "Label3"
        Me.LPSTOCK.Visible = False
        '
        'LtarjetaS
        '
        Me.LtarjetaS.AutoSize = True
        Me.LtarjetaS.Location = New System.Drawing.Point(563, 295)
        Me.LtarjetaS.Name = "LtarjetaS"
        Me.LtarjetaS.Size = New System.Drawing.Size(67, 20)
        Me.LtarjetaS.TabIndex = 23
        Me.LtarjetaS.Text = "LtarjetaS"
        Me.LtarjetaS.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Total A Pagar:"
        '
        'totalfinal
        '
        Me.totalfinal.AutoSize = True
        Me.totalfinal.BackColor = System.Drawing.Color.Transparent
        Me.totalfinal.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalfinal.Location = New System.Drawing.Point(13, 295)
        Me.totalfinal.Name = "totalfinal"
        Me.totalfinal.Size = New System.Drawing.Size(0, 27)
        Me.totalfinal.TabIndex = 25
        '
        'Carrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1074, 620)
        Me.Controls.Add(Me.totalfinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LtarjetaS)
        Me.Controls.Add(Me.LPSTOCK)
        Me.Controls.Add(Me.Tcanti)
        Me.Controls.Add(Me.BMENOS)
        Me.Controls.Add(Me.BMAS)
        Me.Controls.Add(Me.Labeldisc)
        Me.Controls.Add(Me.LDiscount)
        Me.Controls.Add(Me.Bmodificar)
        Me.Controls.Add(Me.Bquitar)
        Me.Controls.Add(Me.LApagar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBentienda)
        Me.Controls.Add(Me.CBtucasa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVtarjetass)
        Me.Controls.Add(Me.Bcomprar)
        Me.Controls.Add(Me.Bmevoy)
        Me.Controls.Add(Me.CBtarjeta)
        Me.Controls.Add(Me.CBefectivo)
        Me.Controls.Add(Me.LNumCarrito)
        Me.Controls.Add(Me.LSUCURSAL)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.DGVMISHOOPIN)
        Me.Name = "Carrito"
        Me.Text = "Carrito"
        CType(Me.DGVMISHOOPIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVtarjetass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMISHOOPIN As DataGridView
    Friend WithEvents Cliente As Label
    Friend WithEvents LSUCURSAL As Label
    Friend WithEvents LNumCarrito As Label
    Friend WithEvents CBefectivo As CheckBox
    Friend WithEvents CBtarjeta As CheckBox
    Friend WithEvents Bmevoy As Button
    Friend WithEvents Bcomprar As Button
    Friend WithEvents DGVtarjetass As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CBtucasa As CheckBox
    Friend WithEvents CBentienda As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LApagar As Label
    Friend WithEvents Bquitar As Button
    Friend WithEvents Bmodificar As Button
    Friend WithEvents LDiscount As Label
    Friend WithEvents Labeldisc As Label
    Friend WithEvents BMAS As Button
    Friend WithEvents BMENOS As Button
    Friend WithEvents Tcanti As TextBox
    Friend WithEvents LPSTOCK As Label
    Friend WithEvents LtarjetaS As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalfinal As Label
End Class
