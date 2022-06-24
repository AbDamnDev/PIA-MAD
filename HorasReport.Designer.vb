<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HorasReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HorasReport))
        Me.tuidid = New System.Windows.Forms.Label()
        Me.hamanahamana = New System.Windows.Forms.Label()
        Me.DGVHORARIO = New System.Windows.Forms.DataGridView()
        Me.Mevoy = New System.Windows.Forms.Button()
        Me.OKIDOKY = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TFullname = New System.Windows.Forms.TextBox()
        Me.Bfull = New System.Windows.Forms.Button()
        Me.Horario = New System.Windows.Forms.Button()
        Me.Bsumsum = New System.Windows.Forms.Button()
        Me.ID2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lhours = New System.Windows.Forms.Label()
        CType(Me.DGVHORARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tuidid
        '
        Me.tuidid.AutoSize = True
        Me.tuidid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tuidid.Location = New System.Drawing.Point(13, 55)
        Me.tuidid.Name = "tuidid"
        Me.tuidid.Size = New System.Drawing.Size(24, 20)
        Me.tuidid.TabIndex = 0
        Me.tuidid.Text = "ID"
        Me.tuidid.Visible = False
        '
        'hamanahamana
        '
        Me.hamanahamana.AutoSize = True
        Me.hamanahamana.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.hamanahamana.Location = New System.Drawing.Point(13, 13)
        Me.hamanahamana.Name = "hamanahamana"
        Me.hamanahamana.Size = New System.Drawing.Size(64, 20)
        Me.hamanahamana.TabIndex = 1
        Me.hamanahamana.Text = "Nombre"
        '
        'DGVHORARIO
        '
        Me.DGVHORARIO.AllowUserToAddRows = False
        Me.DGVHORARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHORARIO.Location = New System.Drawing.Point(13, 120)
        Me.DGVHORARIO.Name = "DGVHORARIO"
        Me.DGVHORARIO.RowHeadersWidth = 51
        Me.DGVHORARIO.RowTemplate.Height = 29
        Me.DGVHORARIO.Size = New System.Drawing.Size(449, 188)
        Me.DGVHORARIO.TabIndex = 2
        '
        'Mevoy
        '
        Me.Mevoy.Location = New System.Drawing.Point(644, 387)
        Me.Mevoy.Name = "Mevoy"
        Me.Mevoy.Size = New System.Drawing.Size(94, 29)
        Me.Mevoy.TabIndex = 4
        Me.Mevoy.Text = "Cancel"
        Me.Mevoy.UseVisualStyleBackColor = True
        '
        'OKIDOKY
        '
        Me.OKIDOKY.Enabled = False
        Me.OKIDOKY.Location = New System.Drawing.Point(533, 387)
        Me.OKIDOKY.Name = "OKIDOKY"
        Me.OKIDOKY.Size = New System.Drawing.Size(105, 29)
        Me.OKIDOKY.TabIndex = 5
        Me.OKIDOKY.Text = "Generar PDF"
        Me.OKIDOKY.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(438, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre Completo de Empleado a Obtener:"
        '
        'TFullname
        '
        Me.TFullname.Location = New System.Drawing.Point(438, 40)
        Me.TFullname.Name = "TFullname"
        Me.TFullname.Size = New System.Drawing.Size(300, 27)
        Me.TFullname.TabIndex = 7
        '
        'Bfull
        '
        Me.Bfull.Location = New System.Drawing.Point(438, 74)
        Me.Bfull.Name = "Bfull"
        Me.Bfull.Size = New System.Drawing.Size(94, 29)
        Me.Bfull.TabIndex = 8
        Me.Bfull.Text = "OK"
        Me.Bfull.UseVisualStyleBackColor = True
        '
        'Horario
        '
        Me.Horario.Enabled = False
        Me.Horario.Location = New System.Drawing.Point(13, 326)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(197, 29)
        Me.Horario.TabIndex = 9
        Me.Horario.Text = "Horario"
        Me.Horario.UseVisualStyleBackColor = True
        '
        'Bsumsum
        '
        Me.Bsumsum.Enabled = False
        Me.Bsumsum.Location = New System.Drawing.Point(13, 374)
        Me.Bsumsum.Name = "Bsumsum"
        Me.Bsumsum.Size = New System.Drawing.Size(197, 29)
        Me.Bsumsum.TabIndex = 10
        Me.Bsumsum.Text = "Obtener horas trabajadas"
        Me.Bsumsum.UseVisualStyleBackColor = True
        '
        'ID2
        '
        Me.ID2.AutoSize = True
        Me.ID2.Location = New System.Drawing.Point(587, 74)
        Me.ID2.Name = "ID2"
        Me.ID2.Size = New System.Drawing.Size(53, 20)
        Me.ID2.TabIndex = 11
        Me.ID2.Text = "Label2"
        Me.ID2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(484, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Horas trabajadas en Total:"
        Me.Label2.Visible = False
        '
        'Lhours
        '
        Me.Lhours.AutoSize = True
        Me.Lhours.Location = New System.Drawing.Point(484, 157)
        Me.Lhours.Name = "Lhours"
        Me.Lhours.Size = New System.Drawing.Size(0, 20)
        Me.Lhours.TabIndex = 13
        '
        'HorasReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(756, 429)
        Me.Controls.Add(Me.Lhours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID2)
        Me.Controls.Add(Me.Bsumsum)
        Me.Controls.Add(Me.Horario)
        Me.Controls.Add(Me.Bfull)
        Me.Controls.Add(Me.TFullname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OKIDOKY)
        Me.Controls.Add(Me.Mevoy)
        Me.Controls.Add(Me.DGVHORARIO)
        Me.Controls.Add(Me.hamanahamana)
        Me.Controls.Add(Me.tuidid)
        Me.Name = "HorasReport"
        Me.Text = "HorasReport"
        CType(Me.DGVHORARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tuidid As Label
    Friend WithEvents hamanahamana As Label
    Friend WithEvents DGVHORARIO As DataGridView
    Friend WithEvents Mevoy As Button
    Friend WithEvents OKIDOKY As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TFullname As TextBox
    Friend WithEvents Bfull As Button
    Friend WithEvents Horario As Button
    Friend WithEvents Bsumsum As Button
    Friend WithEvents ID2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lhours As Label
End Class
