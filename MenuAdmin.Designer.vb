<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdmin))
        Me.LAdminName = New System.Windows.Forms.Label()
        Me.Templeadoreg = New System.Windows.Forms.ToolStripMenuItem()
        Me.Templeadomodificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Templeadoeliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BEmpleadoAdmin = New System.Windows.Forms.Button()
        Me.BDesbloquear = New System.Windows.Forms.Button()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.BRegistroHora = New System.Windows.Forms.Button()
        Me.BSucursalAdmin = New System.Windows.Forms.Button()
        Me.BreporteInventarioAdmin = New System.Windows.Forms.Button()
        Me.BrEPORThORARIO = New System.Windows.Forms.Button()
        Me.DGVmenuadmin = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bcerrarsesion = New System.Windows.Forms.Button()
        CType(Me.DGVmenuadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LAdminName
        '
        Me.LAdminName.AutoSize = True
        Me.LAdminName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LAdminName.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LAdminName.Location = New System.Drawing.Point(12, 9)
        Me.LAdminName.Name = "LAdminName"
        Me.LAdminName.Size = New System.Drawing.Size(61, 24)
        Me.LAdminName.TabIndex = 0
        Me.LAdminName.Text = "Label1"
        '
        'Templeadoreg
        '
        Me.Templeadoreg.Name = "Templeadoreg"
        Me.Templeadoreg.Size = New System.Drawing.Size(156, 26)
        Me.Templeadoreg.Text = "Registro"
        '
        'Templeadomodificar
        '
        Me.Templeadomodificar.Name = "Templeadomodificar"
        Me.Templeadomodificar.Size = New System.Drawing.Size(156, 26)
        Me.Templeadomodificar.Text = "Modificar"
        '
        'Templeadoeliminar
        '
        Me.Templeadoeliminar.Name = "Templeadoeliminar"
        Me.Templeadoeliminar.Size = New System.Drawing.Size(156, 26)
        Me.Templeadoeliminar.Text = "Eliminar"
        '
        'BEmpleadoAdmin
        '
        Me.BEmpleadoAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BEmpleadoAdmin.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BEmpleadoAdmin.Location = New System.Drawing.Point(13, 70)
        Me.BEmpleadoAdmin.Name = "BEmpleadoAdmin"
        Me.BEmpleadoAdmin.Size = New System.Drawing.Size(161, 43)
        Me.BEmpleadoAdmin.TabIndex = 1
        Me.BEmpleadoAdmin.Text = "Empleado"
        Me.BEmpleadoAdmin.UseVisualStyleBackColor = False
        '
        'BDesbloquear
        '
        Me.BDesbloquear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BDesbloquear.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BDesbloquear.Location = New System.Drawing.Point(13, 119)
        Me.BDesbloquear.Name = "BDesbloquear"
        Me.BDesbloquear.Size = New System.Drawing.Size(161, 57)
        Me.BDesbloquear.TabIndex = 2
        Me.BDesbloquear.Text = "Desbloquear Cuenta"
        Me.BDesbloquear.UseVisualStyleBackColor = False
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BProductos.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BProductos.Location = New System.Drawing.Point(13, 182)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(161, 43)
        Me.BProductos.TabIndex = 3
        Me.BProductos.Text = "Productos"
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'BRegistroHora
        '
        Me.BRegistroHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BRegistroHora.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BRegistroHora.Location = New System.Drawing.Point(13, 231)
        Me.BRegistroHora.Name = "BRegistroHora"
        Me.BRegistroHora.Size = New System.Drawing.Size(161, 43)
        Me.BRegistroHora.TabIndex = 5
        Me.BRegistroHora.Text = "Registro de Horas"
        Me.BRegistroHora.UseVisualStyleBackColor = False
        '
        'BSucursalAdmin
        '
        Me.BSucursalAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BSucursalAdmin.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BSucursalAdmin.Location = New System.Drawing.Point(13, 280)
        Me.BSucursalAdmin.Name = "BSucursalAdmin"
        Me.BSucursalAdmin.Size = New System.Drawing.Size(161, 43)
        Me.BSucursalAdmin.TabIndex = 6
        Me.BSucursalAdmin.Text = "Sucursal"
        Me.BSucursalAdmin.UseVisualStyleBackColor = False
        '
        'BreporteInventarioAdmin
        '
        Me.BreporteInventarioAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BreporteInventarioAdmin.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BreporteInventarioAdmin.Location = New System.Drawing.Point(12, 329)
        Me.BreporteInventarioAdmin.Name = "BreporteInventarioAdmin"
        Me.BreporteInventarioAdmin.Size = New System.Drawing.Size(161, 59)
        Me.BreporteInventarioAdmin.TabIndex = 7
        Me.BreporteInventarioAdmin.Text = "Reporte de Inventario"
        Me.BreporteInventarioAdmin.UseVisualStyleBackColor = False
        '
        'BrEPORThORARIO
        '
        Me.BrEPORThORARIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BrEPORThORARIO.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BrEPORThORARIO.Location = New System.Drawing.Point(13, 394)
        Me.BrEPORThORARIO.Name = "BrEPORThORARIO"
        Me.BrEPORThORARIO.Size = New System.Drawing.Size(161, 59)
        Me.BrEPORThORARIO.TabIndex = 8
        Me.BrEPORThORARIO.Text = "Reporte de Horario"
        Me.BrEPORThORARIO.UseVisualStyleBackColor = False
        '
        'DGVmenuadmin
        '
        Me.DGVmenuadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVmenuadmin.Location = New System.Drawing.Point(298, 70)
        Me.DGVmenuadmin.Name = "DGVmenuadmin"
        Me.DGVmenuadmin.RowHeadersWidth = 51
        Me.DGVmenuadmin.RowTemplate.Height = 29
        Me.DGVmenuadmin.Size = New System.Drawing.Size(429, 383)
        Me.DGVmenuadmin.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(13, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bcerrarsesion
        '
        Me.Bcerrarsesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bcerrarsesion.Location = New System.Drawing.Point(588, 12)
        Me.Bcerrarsesion.Name = "Bcerrarsesion"
        Me.Bcerrarsesion.Size = New System.Drawing.Size(110, 43)
        Me.Bcerrarsesion.TabIndex = 11
        Me.Bcerrarsesion.Text = "Cerrar Sesión"
        Me.Bcerrarsesion.UseVisualStyleBackColor = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(739, 514)
        Me.Controls.Add(Me.Bcerrarsesion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVmenuadmin)
        Me.Controls.Add(Me.BrEPORThORARIO)
        Me.Controls.Add(Me.BreporteInventarioAdmin)
        Me.Controls.Add(Me.BSucursalAdmin)
        Me.Controls.Add(Me.BRegistroHora)
        Me.Controls.Add(Me.BProductos)
        Me.Controls.Add(Me.BDesbloquear)
        Me.Controls.Add(Me.BEmpleadoAdmin)
        Me.Controls.Add(Me.LAdminName)
        Me.Name = "MenuAdmin"
        Me.Text = "MenuAdmin"
        CType(Me.DGVmenuadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LAdminName As Label
    Friend WithEvents TSMDesbloquear As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents Templeadoreg As ToolStripMenuItem
    Friend WithEvents Templeadomodificar As ToolStripMenuItem
    Friend WithEvents Templeadoeliminar As ToolStripMenuItem
    Friend WithEvents BEmpleadoAdmin As Button
    Friend WithEvents BDesbloquear As Button
    Friend WithEvents BProductos As Button
    Friend WithEvents BRegistroHora As Button
    Friend WithEvents BSucursalAdmin As Button
    Friend WithEvents BreporteInventarioAdmin As Button
    Friend WithEvents BrEPORThORARIO As Button
    Friend WithEvents DGVmenuadmin As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Bcerrarsesion As Button
End Class
