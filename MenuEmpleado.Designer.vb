<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuEmpleado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bproduct = New System.Windows.Forms.Button()
        Me.BHourReg = New System.Windows.Forms.Button()
        Me.BSucursalemp = New System.Windows.Forms.Button()
        Me.bInvent = New System.Windows.Forms.Button()
        Me.BreportHours = New System.Windows.Forms.Button()
        Me.DGVmenuempleado = New System.Windows.Forms.DataGridView()
        Me.BdesUsuario = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bclosesesion = New System.Windows.Forms.Button()
        CType(Me.DGVmenuempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Bproduct
        '
        Me.Bproduct.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Bproduct.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Bproduct.Location = New System.Drawing.Point(13, 52)
        Me.Bproduct.Name = "Bproduct"
        Me.Bproduct.Size = New System.Drawing.Size(165, 34)
        Me.Bproduct.TabIndex = 1
        Me.Bproduct.Text = "Productos"
        Me.Bproduct.UseVisualStyleBackColor = False
        '
        'BHourReg
        '
        Me.BHourReg.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BHourReg.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BHourReg.Location = New System.Drawing.Point(13, 92)
        Me.BHourReg.Name = "BHourReg"
        Me.BHourReg.Size = New System.Drawing.Size(164, 34)
        Me.BHourReg.TabIndex = 3
        Me.BHourReg.Text = "Registro de Horas"
        Me.BHourReg.UseVisualStyleBackColor = False
        '
        'BSucursalemp
        '
        Me.BSucursalemp.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BSucursalemp.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BSucursalemp.Location = New System.Drawing.Point(14, 132)
        Me.BSucursalemp.Name = "BSucursalemp"
        Me.BSucursalemp.Size = New System.Drawing.Size(164, 34)
        Me.BSucursalemp.TabIndex = 4
        Me.BSucursalemp.Text = "Sucursal"
        Me.BSucursalemp.UseVisualStyleBackColor = False
        '
        'bInvent
        '
        Me.bInvent.BackColor = System.Drawing.Color.LightSeaGreen
        Me.bInvent.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bInvent.Location = New System.Drawing.Point(14, 172)
        Me.bInvent.Name = "bInvent"
        Me.bInvent.Size = New System.Drawing.Size(164, 57)
        Me.bInvent.TabIndex = 5
        Me.bInvent.Text = "Reporte de Inventario"
        Me.bInvent.UseVisualStyleBackColor = False
        '
        'BreportHours
        '
        Me.BreportHours.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BreportHours.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BreportHours.Location = New System.Drawing.Point(14, 235)
        Me.BreportHours.Name = "BreportHours"
        Me.BreportHours.Size = New System.Drawing.Size(164, 57)
        Me.BreportHours.TabIndex = 6
        Me.BreportHours.Text = "Reporte de Horario"
        Me.BreportHours.UseVisualStyleBackColor = False
        '
        'DGVmenuempleado
        '
        Me.DGVmenuempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVmenuempleado.Location = New System.Drawing.Point(368, 52)
        Me.DGVmenuempleado.Name = "DGVmenuempleado"
        Me.DGVmenuempleado.RowHeadersWidth = 51
        Me.DGVmenuempleado.RowTemplate.Height = 29
        Me.DGVmenuempleado.Size = New System.Drawing.Size(420, 304)
        Me.DGVmenuempleado.TabIndex = 7
        '
        'BdesUsuario
        '
        Me.BdesUsuario.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BdesUsuario.Font = New System.Drawing.Font("Segoe UI Emoji", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BdesUsuario.Location = New System.Drawing.Point(14, 298)
        Me.BdesUsuario.Name = "BdesUsuario"
        Me.BdesUsuario.Size = New System.Drawing.Size(164, 58)
        Me.BdesUsuario.TabIndex = 8
        Me.BdesUsuario.Text = "Desbloquear Usuario"
        Me.BdesUsuario.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(14, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Bclosesesion
        '
        Me.Bclosesesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bclosesesion.Location = New System.Drawing.Point(621, 386)
        Me.Bclosesesion.Name = "Bclosesesion"
        Me.Bclosesesion.Size = New System.Drawing.Size(108, 48)
        Me.Bclosesesion.TabIndex = 10
        Me.Bclosesesion.Text = "Cerrar Sesión"
        Me.Bclosesesion.UseVisualStyleBackColor = False
        '
        'MenuEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 462)
        Me.Controls.Add(Me.Bclosesesion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BdesUsuario)
        Me.Controls.Add(Me.DGVmenuempleado)
        Me.Controls.Add(Me.BreportHours)
        Me.Controls.Add(Me.bInvent)
        Me.Controls.Add(Me.BSucursalemp)
        Me.Controls.Add(Me.BHourReg)
        Me.Controls.Add(Me.Bproduct)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuEmpleado"
        Me.Text = "MenuEmpleado"
        CType(Me.DGVmenuempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bproduct As Button
    Friend WithEvents BHourReg As Button
    Friend WithEvents BSucursalemp As Button
    Friend WithEvents bInvent As Button
    Friend WithEvents BreportHours As Button
    Friend WithEvents DGVmenuempleado As DataGridView
    Friend WithEvents BdesUsuario As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bclosesesion As Button
End Class
