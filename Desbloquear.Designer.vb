<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desbloquear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desbloquear))
        Me.nomusuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tusuariobloqueado = New System.Windows.Forms.TextBox()
        Me.dgvk = New System.Windows.Forms.DataGridView()
        Me.butonbyebye = New System.Windows.Forms.Button()
        Me.Bunblock = New System.Windows.Forms.Button()
        Me.Showclientblock = New System.Windows.Forms.Button()
        Me.Showemplyeblock = New System.Windows.Forms.Button()
        CType(Me.dgvk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nomusuario
        '
        Me.nomusuario.AutoSize = True
        Me.nomusuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nomusuario.Location = New System.Drawing.Point(12, 22)
        Me.nomusuario.Name = "nomusuario"
        Me.nomusuario.Size = New System.Drawing.Size(53, 20)
        Me.nomusuario.TabIndex = 0
        Me.nomusuario.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario a desbloquear:"
        '
        'Tusuariobloqueado
        '
        Me.Tusuariobloqueado.Location = New System.Drawing.Point(41, 136)
        Me.Tusuariobloqueado.Name = "Tusuariobloqueado"
        Me.Tusuariobloqueado.Size = New System.Drawing.Size(237, 27)
        Me.Tusuariobloqueado.TabIndex = 2
        '
        'dgvk
        '
        Me.dgvk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvk.Location = New System.Drawing.Point(41, 221)
        Me.dgvk.Name = "dgvk"
        Me.dgvk.RowHeadersWidth = 51
        Me.dgvk.RowTemplate.Height = 29
        Me.dgvk.Size = New System.Drawing.Size(747, 188)
        Me.dgvk.TabIndex = 3
        '
        'butonbyebye
        '
        Me.butonbyebye.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butonbyebye.Location = New System.Drawing.Point(668, 31)
        Me.butonbyebye.Name = "butonbyebye"
        Me.butonbyebye.Size = New System.Drawing.Size(120, 45)
        Me.butonbyebye.TabIndex = 4
        Me.butonbyebye.Text = "Cancelar"
        Me.butonbyebye.UseVisualStyleBackColor = False
        '
        'Bunblock
        '
        Me.Bunblock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bunblock.Location = New System.Drawing.Point(173, 169)
        Me.Bunblock.Name = "Bunblock"
        Me.Bunblock.Size = New System.Drawing.Size(115, 29)
        Me.Bunblock.TabIndex = 5
        Me.Bunblock.Text = "Desbloquear"
        Me.Bunblock.UseVisualStyleBackColor = False
        '
        'Showclientblock
        '
        Me.Showclientblock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Showclientblock.Location = New System.Drawing.Point(668, 162)
        Me.Showclientblock.Name = "Showclientblock"
        Me.Showclientblock.Size = New System.Drawing.Size(120, 53)
        Me.Showclientblock.TabIndex = 6
        Me.Showclientblock.Text = "Clientes Bloqueados"
        Me.Showclientblock.UseVisualStyleBackColor = False
        '
        'Showemplyeblock
        '
        Me.Showemplyeblock.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Showemplyeblock.Location = New System.Drawing.Point(668, 96)
        Me.Showemplyeblock.Name = "Showemplyeblock"
        Me.Showemplyeblock.Size = New System.Drawing.Size(120, 58)
        Me.Showemplyeblock.TabIndex = 7
        Me.Showemplyeblock.Text = "Empleados Bloqueados"
        Me.Showemplyeblock.UseVisualStyleBackColor = False
        '
        'Desbloquear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Showemplyeblock)
        Me.Controls.Add(Me.Showclientblock)
        Me.Controls.Add(Me.Bunblock)
        Me.Controls.Add(Me.butonbyebye)
        Me.Controls.Add(Me.dgvk)
        Me.Controls.Add(Me.Tusuariobloqueado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nomusuario)
        Me.Name = "Desbloquear"
        Me.Text = "Desbloquear"
        CType(Me.dgvk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nomusuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tusuariobloqueado As TextBox
    Friend WithEvents dgvk As DataGridView
    Friend WithEvents butonbyebye As Button
    Friend WithEvents Bunblock As Button
    Friend WithEvents Showclientblock As Button
    Friend WithEvents Showemplyeblock As Button
End Class
