<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RgistroDeHoras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RgistroDeHoras))
        Me.Idempleado = New System.Windows.Forms.Label()
        Me.Bgoback = New System.Windows.Forms.Button()
        Me.Baceptar = New System.Windows.Forms.Button()
        Me.DGVhours = New System.Windows.Forms.DataGridView()
        Me.Nomnom = New System.Windows.Forms.Label()
        Me.Bout = New System.Windows.Forms.Button()
        CType(Me.DGVhours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Idempleado
        '
        Me.Idempleado.AutoSize = True
        Me.Idempleado.BackColor = System.Drawing.Color.Transparent
        Me.Idempleado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Idempleado.Location = New System.Drawing.Point(13, 33)
        Me.Idempleado.Name = "Idempleado"
        Me.Idempleado.Size = New System.Drawing.Size(109, 25)
        Me.Idempleado.TabIndex = 0
        Me.Idempleado.Text = "ID empleao"
        '
        'Bgoback
        '
        Me.Bgoback.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bgoback.Location = New System.Drawing.Point(418, 369)
        Me.Bgoback.Name = "Bgoback"
        Me.Bgoback.Size = New System.Drawing.Size(94, 29)
        Me.Bgoback.TabIndex = 1
        Me.Bgoback.Text = "Cancelar"
        Me.Bgoback.UseVisualStyleBackColor = False
        '
        'Baceptar
        '
        Me.Baceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Baceptar.Location = New System.Drawing.Point(218, 369)
        Me.Baceptar.Name = "Baceptar"
        Me.Baceptar.Size = New System.Drawing.Size(94, 29)
        Me.Baceptar.TabIndex = 2
        Me.Baceptar.Text = "Entrada"
        Me.Baceptar.UseVisualStyleBackColor = False
        '
        'DGVhours
        '
        Me.DGVhours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVhours.Location = New System.Drawing.Point(13, 94)
        Me.DGVhours.Name = "DGVhours"
        Me.DGVhours.RowHeadersWidth = 51
        Me.DGVhours.RowTemplate.Height = 29
        Me.DGVhours.Size = New System.Drawing.Size(462, 180)
        Me.DGVhours.TabIndex = 3
        '
        'Nomnom
        '
        Me.Nomnom.AutoSize = True
        Me.Nomnom.BackColor = System.Drawing.Color.Transparent
        Me.Nomnom.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nomnom.Location = New System.Drawing.Point(55, 33)
        Me.Nomnom.Name = "Nomnom"
        Me.Nomnom.Size = New System.Drawing.Size(67, 25)
        Me.Nomnom.TabIndex = 4
        Me.Nomnom.Text = "Label1"
        '
        'Bout
        '
        Me.Bout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bout.Location = New System.Drawing.Point(318, 369)
        Me.Bout.Name = "Bout"
        Me.Bout.Size = New System.Drawing.Size(94, 29)
        Me.Bout.TabIndex = 5
        Me.Bout.Text = "Salida"
        Me.Bout.UseVisualStyleBackColor = False
        '
        'RgistroDeHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 409)
        Me.Controls.Add(Me.Bout)
        Me.Controls.Add(Me.Nomnom)
        Me.Controls.Add(Me.DGVhours)
        Me.Controls.Add(Me.Baceptar)
        Me.Controls.Add(Me.Bgoback)
        Me.Controls.Add(Me.Idempleado)
        Me.Name = "RgistroDeHoras"
        Me.Text = "RgistroDeHoras"
        CType(Me.DGVhours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Idempleado As Label
    Friend WithEvents Bgoback As Button
    Friend WithEvents Baceptar As Button
    Friend WithEvents DGVhours As DataGridView
    Friend WithEvents Nomnom As Label
    Friend WithEvents Bout As Button
End Class
