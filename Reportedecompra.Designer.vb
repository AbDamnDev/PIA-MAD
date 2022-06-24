<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportedecompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportedecompra))
        Me.IDdecarrito = New System.Windows.Forms.Label()
        Me.BGoBack = New System.Windows.Forms.Button()
        Me.UsuarioNom = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDcliente = New System.Windows.Forms.Label()
        Me.Idsucursal = New System.Windows.Forms.Label()
        Me.DGVInfoCarrito = New System.Windows.Forms.DataGridView()
        Me.DGVSucursal = New System.Windows.Forms.DataGridView()
        Me.DGVClienteinfo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVProductCarrito = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lprecio = New System.Windows.Forms.Label()
        Me.Ldesdevent = New System.Windows.Forms.Label()
        Me.DGVtarjeta = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVInfoCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVClienteinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVProductCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVtarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDdecarrito
        '
        Me.IDdecarrito.AutoSize = True
        Me.IDdecarrito.BackColor = System.Drawing.Color.Transparent
        Me.IDdecarrito.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.IDdecarrito.Location = New System.Drawing.Point(16, 393)
        Me.IDdecarrito.Name = "IDdecarrito"
        Me.IDdecarrito.Size = New System.Drawing.Size(91, 25)
        Me.IDdecarrito.TabIndex = 0
        Me.IDdecarrito.Text = "ID Carrito"
        '
        'BGoBack
        '
        Me.BGoBack.Location = New System.Drawing.Point(1403, 797)
        Me.BGoBack.Name = "BGoBack"
        Me.BGoBack.Size = New System.Drawing.Size(115, 58)
        Me.BGoBack.TabIndex = 1
        Me.BGoBack.Text = "Salir"
        Me.BGoBack.UseVisualStyleBackColor = True
        '
        'UsuarioNom
        '
        Me.UsuarioNom.AutoSize = True
        Me.UsuarioNom.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioNom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsuarioNom.Location = New System.Drawing.Point(14, 34)
        Me.UsuarioNom.Name = "UsuarioNom"
        Me.UsuarioNom.Size = New System.Drawing.Size(87, 28)
        Me.UsuarioNom.TabIndex = 2
        Me.UsuarioNom.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1268, 797)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generar Ticket PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDcliente
        '
        Me.IDcliente.AutoSize = True
        Me.IDcliente.BackColor = System.Drawing.Color.Transparent
        Me.IDcliente.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IDcliente.Location = New System.Drawing.Point(13, 9)
        Me.IDcliente.Name = "IDcliente"
        Me.IDcliente.Size = New System.Drawing.Size(94, 25)
        Me.IDcliente.TabIndex = 4
        Me.IDcliente.Text = "ID Cliente"
        '
        'Idsucursal
        '
        Me.Idsucursal.AutoSize = True
        Me.Idsucursal.BackColor = System.Drawing.Color.Transparent
        Me.Idsucursal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Idsucursal.Location = New System.Drawing.Point(16, 212)
        Me.Idsucursal.Name = "Idsucursal"
        Me.Idsucursal.Size = New System.Drawing.Size(100, 25)
        Me.Idsucursal.TabIndex = 5
        Me.Idsucursal.Text = "ID Sucursal"
        '
        'DGVInfoCarrito
        '
        Me.DGVInfoCarrito.AllowUserToAddRows = False
        Me.DGVInfoCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInfoCarrito.Location = New System.Drawing.Point(16, 556)
        Me.DGVInfoCarrito.Name = "DGVInfoCarrito"
        Me.DGVInfoCarrito.RowHeadersWidth = 51
        Me.DGVInfoCarrito.RowTemplate.Height = 29
        Me.DGVInfoCarrito.Size = New System.Drawing.Size(1171, 235)
        Me.DGVInfoCarrito.TabIndex = 6
        '
        'DGVSucursal
        '
        Me.DGVSucursal.AllowUserToAddRows = False
        Me.DGVSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSucursal.Location = New System.Drawing.Point(16, 240)
        Me.DGVSucursal.Name = "DGVSucursal"
        Me.DGVSucursal.RowHeadersWidth = 51
        Me.DGVSucursal.RowTemplate.Height = 29
        Me.DGVSucursal.Size = New System.Drawing.Size(1321, 101)
        Me.DGVSucursal.TabIndex = 7
        '
        'DGVClienteinfo
        '
        Me.DGVClienteinfo.AllowUserToAddRows = False
        Me.DGVClienteinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClienteinfo.Location = New System.Drawing.Point(14, 65)
        Me.DGVClienteinfo.Name = "DGVClienteinfo"
        Me.DGVClienteinfo.RowHeadersWidth = 51
        Me.DGVClienteinfo.RowTemplate.Height = 29
        Me.DGVClienteinfo.Size = New System.Drawing.Size(979, 108)
        Me.DGVClienteinfo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Carrito:"
        '
        'DGVProductCarrito
        '
        Me.DGVProductCarrito.AllowUserToAddRows = False
        Me.DGVProductCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductCarrito.Location = New System.Drawing.Point(16, 421)
        Me.DGVProductCarrito.Name = "DGVProductCarrito"
        Me.DGVProductCarrito.RowHeadersWidth = 51
        Me.DGVProductCarrito.RowTemplate.Height = 29
        Me.DGVProductCarrito.Size = New System.Drawing.Size(1321, 115)
        Me.DGVProductCarrito.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(16, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sucursal:"
        '
        'Lprecio
        '
        Me.Lprecio.AutoSize = True
        Me.Lprecio.Location = New System.Drawing.Point(794, 34)
        Me.Lprecio.Name = "Lprecio"
        Me.Lprecio.Size = New System.Drawing.Size(53, 20)
        Me.Lprecio.TabIndex = 12
        Me.Lprecio.Text = "Label3"
        Me.Lprecio.Visible = False
        '
        'Ldesdevent
        '
        Me.Ldesdevent.AutoSize = True
        Me.Ldesdevent.Location = New System.Drawing.Point(918, 23)
        Me.Ldesdevent.Name = "Ldesdevent"
        Me.Ldesdevent.Size = New System.Drawing.Size(53, 20)
        Me.Ldesdevent.TabIndex = 13
        Me.Ldesdevent.Text = "Label3"
        Me.Ldesdevent.Visible = False
        '
        'DGVtarjeta
        '
        Me.DGVtarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtarjeta.Location = New System.Drawing.Point(1018, 65)
        Me.DGVtarjeta.Name = "DGVtarjeta"
        Me.DGVtarjeta.RowHeadersWidth = 51
        Me.DGVtarjeta.RowTemplate.Height = 29
        Me.DGVtarjeta.Size = New System.Drawing.Size(319, 108)
        Me.DGVtarjeta.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1226, 556)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 164)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Reportedecompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1530, 867)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGVtarjeta)
        Me.Controls.Add(Me.Ldesdevent)
        Me.Controls.Add(Me.Lprecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVProductCarrito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVClienteinfo)
        Me.Controls.Add(Me.DGVSucursal)
        Me.Controls.Add(Me.DGVInfoCarrito)
        Me.Controls.Add(Me.Idsucursal)
        Me.Controls.Add(Me.IDcliente)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UsuarioNom)
        Me.Controls.Add(Me.BGoBack)
        Me.Controls.Add(Me.IDdecarrito)
        Me.Name = "Reportedecompra"
        Me.Text = "Reportedecompra"
        CType(Me.DGVInfoCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVClienteinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVProductCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVtarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDdecarrito As Label
    Friend WithEvents BGoBack As Button
    Friend WithEvents UsuarioNom As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IDcliente As Label
    Friend WithEvents Idsucursal As Label
    Friend WithEvents DGVInfoCarrito As DataGridView
    Friend WithEvents DGVSucursal As DataGridView
    Friend WithEvents DGVClienteinfo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVProductCarrito As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Lprecio As Label
    Friend WithEvents Ldesdevent As Label
    Friend WithEvents DGVtarjeta As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
