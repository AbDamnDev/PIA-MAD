<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaMasivaSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaMasivaSucursal))
        Me.DataCrgasucur = New System.Windows.Forms.DataGridView()
        Me.Bload = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lcveempleado = New System.Windows.Forms.Label()
        CType(Me.DataCrgasucur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataCrgasucur
        '
        Me.DataCrgasucur.AllowUserToAddRows = False
        Me.DataCrgasucur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCrgasucur.Location = New System.Drawing.Point(12, 135)
        Me.DataCrgasucur.Name = "DataCrgasucur"
        Me.DataCrgasucur.RowHeadersWidth = 51
        Me.DataCrgasucur.RowTemplate.Height = 29
        Me.DataCrgasucur.Size = New System.Drawing.Size(471, 188)
        Me.DataCrgasucur.TabIndex = 0
        '
        'Bload
        '
        Me.Bload.BackColor = System.Drawing.Color.Plum
        Me.Bload.Location = New System.Drawing.Point(389, 52)
        Me.Bload.Name = "Bload"
        Me.Bload.Size = New System.Drawing.Size(94, 29)
        Me.Bload.TabIndex = 1
        Me.Bload.Text = "Agregar"
        Me.Bload.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.Plum
        Me.BSalir.Location = New System.Drawing.Point(389, 100)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(94, 29)
        Me.BSalir.TabIndex = 2
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Carga Masiva de Sucursales"
        '
        'Lcveempleado
        '
        Me.Lcveempleado.AutoSize = True
        Me.Lcveempleado.Location = New System.Drawing.Point(89, 100)
        Me.Lcveempleado.Name = "Lcveempleado"
        Me.Lcveempleado.Size = New System.Drawing.Size(53, 20)
        Me.Lcveempleado.TabIndex = 4
        Me.Lcveempleado.Text = "Label2"
        Me.Lcveempleado.Visible = False
        '
        'CargaMasivaSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(525, 341)
        Me.Controls.Add(Me.Lcveempleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.Bload)
        Me.Controls.Add(Me.DataCrgasucur)
        Me.Name = "CargaMasivaSucursal"
        Me.Text = "CargaMasivaSucursal"
        CType(Me.DataCrgasucur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataCrgasucur As DataGridView
    Friend WithEvents Bload As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Lcveempleado As Label
End Class
