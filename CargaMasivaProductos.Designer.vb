<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaMasivaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaMasivaProductos))
        Me.DGVprodmass = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Badelante = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LSucur = New System.Windows.Forms.Label()
        Me.cbSucursalm = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVprodmass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVprodmass
        '
        Me.DGVprodmass.AllowUserToAddRows = False
        Me.DGVprodmass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVprodmass.Location = New System.Drawing.Point(12, 205)
        Me.DGVprodmass.Name = "DGVprodmass"
        Me.DGVprodmass.RowHeadersWidth = 51
        Me.DGVprodmass.RowTemplate.Height = 29
        Me.DGVprodmass.Size = New System.Drawing.Size(646, 188)
        Me.DGVprodmass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Carga Masiva de Productos"
        '
        'Badelante
        '
        Me.Badelante.BackColor = System.Drawing.Color.Black
        Me.Badelante.ForeColor = System.Drawing.Color.White
        Me.Badelante.Location = New System.Drawing.Point(564, 118)
        Me.Badelante.Name = "Badelante"
        Me.Badelante.Size = New System.Drawing.Size(94, 29)
        Me.Badelante.TabIndex = 2
        Me.Badelante.Text = "Agregar"
        Me.Badelante.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(564, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LSucur
        '
        Me.LSucur.AutoSize = True
        Me.LSucur.Location = New System.Drawing.Point(242, 164)
        Me.LSucur.Name = "LSucur"
        Me.LSucur.Size = New System.Drawing.Size(52, 20)
        Me.LSucur.TabIndex = 4
        Me.LSucur.Text = "LSucur"
        Me.LSucur.Visible = False
        '
        'cbSucursalm
        '
        Me.cbSucursalm.FormattingEnabled = True
        Me.cbSucursalm.Location = New System.Drawing.Point(13, 103)
        Me.cbSucursalm.Name = "cbSucursalm"
        Me.cbSucursalm.Size = New System.Drawing.Size(151, 28)
        Me.cbSucursalm.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sucursal:"
        '
        'CargaMasivaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(678, 408)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbSucursalm)
        Me.Controls.Add(Me.LSucur)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Badelante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVprodmass)
        Me.Name = "CargaMasivaProductos"
        Me.Text = "CargaMasivaProductos"
        CType(Me.DGVprodmass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVprodmass As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Badelante As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LSucur As Label
    Friend WithEvents cbSucursalm As ComboBox
    Friend WithEvents Label2 As Label
End Class
