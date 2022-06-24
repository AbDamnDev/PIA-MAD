<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADDTARJETAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADDTARJETAS))
        Me.DGVTarjetas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BDontWanttobehere = New System.Windows.Forms.Button()
        Me.BShowTarjetas = New System.Windows.Forms.Button()
        Me.BAddTarjeta = New System.Windows.Forms.Button()
        Me.Tnumtarjeta = New System.Windows.Forms.TextBox()
        Me.Tcvv = New System.Windows.Forms.TextBox()
        Me.Texpiration = New System.Windows.Forms.TextBox()
        Me.LMETPG = New System.Windows.Forms.Label()
        Me.Lnumt = New System.Windows.Forms.Label()
        Me.Lidmetpag = New System.Windows.Forms.Label()
        Me.Bmodify = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGVTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTarjetas
        '
        Me.DGVTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTarjetas.Location = New System.Drawing.Point(12, 250)
        Me.DGVTarjetas.Name = "DGVTarjetas"
        Me.DGVTarjetas.RowHeadersWidth = 51
        Me.DGVTarjetas.RowTemplate.Height = 29
        Me.DGVTarjetas.Size = New System.Drawing.Size(611, 188)
        Me.DGVTarjetas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número de Tarjeta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Expiración:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(317, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CVV:"
        Me.Label3.Visible = False
        '
        'BDontWanttobehere
        '
        Me.BDontWanttobehere.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BDontWanttobehere.Location = New System.Drawing.Point(671, 393)
        Me.BDontWanttobehere.Name = "BDontWanttobehere"
        Me.BDontWanttobehere.Size = New System.Drawing.Size(94, 29)
        Me.BDontWanttobehere.TabIndex = 4
        Me.BDontWanttobehere.Text = "Cancelar"
        Me.BDontWanttobehere.UseVisualStyleBackColor = False
        '
        'BShowTarjetas
        '
        Me.BShowTarjetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BShowTarjetas.Location = New System.Drawing.Point(671, 322)
        Me.BShowTarjetas.Name = "BShowTarjetas"
        Me.BShowTarjetas.Size = New System.Drawing.Size(94, 29)
        Me.BShowTarjetas.TabIndex = 5
        Me.BShowTarjetas.Text = "Mostrar"
        Me.BShowTarjetas.UseVisualStyleBackColor = False
        '
        'BAddTarjeta
        '
        Me.BAddTarjeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BAddTarjeta.Location = New System.Drawing.Point(671, 287)
        Me.BAddTarjeta.Name = "BAddTarjeta"
        Me.BAddTarjeta.Size = New System.Drawing.Size(94, 29)
        Me.BAddTarjeta.TabIndex = 6
        Me.BAddTarjeta.Text = "Agregar"
        Me.BAddTarjeta.UseVisualStyleBackColor = False
        '
        'Tnumtarjeta
        '
        Me.Tnumtarjeta.Location = New System.Drawing.Point(23, 54)
        Me.Tnumtarjeta.Name = "Tnumtarjeta"
        Me.Tnumtarjeta.Size = New System.Drawing.Size(213, 27)
        Me.Tnumtarjeta.TabIndex = 7
        '
        'Tcvv
        '
        Me.Tcvv.Location = New System.Drawing.Point(23, 186)
        Me.Tcvv.Name = "Tcvv"
        Me.Tcvv.Size = New System.Drawing.Size(213, 27)
        Me.Tcvv.TabIndex = 8
        '
        'Texpiration
        '
        Me.Texpiration.Location = New System.Drawing.Point(23, 123)
        Me.Texpiration.Name = "Texpiration"
        Me.Texpiration.Size = New System.Drawing.Size(213, 27)
        Me.Texpiration.TabIndex = 9
        '
        'LMETPG
        '
        Me.LMETPG.AutoSize = True
        Me.LMETPG.Location = New System.Drawing.Point(479, 54)
        Me.LMETPG.Name = "LMETPG"
        Me.LMETPG.Size = New System.Drawing.Size(53, 20)
        Me.LMETPG.TabIndex = 10
        Me.LMETPG.Text = "Label4"
        Me.LMETPG.Visible = False
        '
        'Lnumt
        '
        Me.Lnumt.AutoSize = True
        Me.Lnumt.Location = New System.Drawing.Point(364, 78)
        Me.Lnumt.Name = "Lnumt"
        Me.Lnumt.Size = New System.Drawing.Size(81, 20)
        Me.Lnumt.TabIndex = 11
        Me.Lnumt.Text = "numtarjeta"
        Me.Lnumt.Visible = False
        '
        'Lidmetpag
        '
        Me.Lidmetpag.AutoSize = True
        Me.Lidmetpag.Location = New System.Drawing.Point(377, 123)
        Me.Lidmetpag.Name = "Lidmetpag"
        Me.Lidmetpag.Size = New System.Drawing.Size(53, 20)
        Me.Lidmetpag.TabIndex = 12
        Me.Lidmetpag.Text = "Label4"
        Me.Lidmetpag.Visible = False
        '
        'Bmodify
        '
        Me.Bmodify.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Bmodify.Location = New System.Drawing.Point(671, 357)
        Me.Bmodify.Name = "Bmodify"
        Me.Bmodify.Size = New System.Drawing.Size(94, 29)
        Me.Bmodify.TabIndex = 13
        Me.Bmodify.Text = "Modificar"
        Me.Bmodify.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(23, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "CVV:"
        '
        'ADDTARJETAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Bmodify)
        Me.Controls.Add(Me.Lidmetpag)
        Me.Controls.Add(Me.Lnumt)
        Me.Controls.Add(Me.LMETPG)
        Me.Controls.Add(Me.Texpiration)
        Me.Controls.Add(Me.Tcvv)
        Me.Controls.Add(Me.Tnumtarjeta)
        Me.Controls.Add(Me.BAddTarjeta)
        Me.Controls.Add(Me.BShowTarjetas)
        Me.Controls.Add(Me.BDontWanttobehere)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVTarjetas)
        Me.Name = "ADDTARJETAS"
        Me.Text = "ADDTARJETAS"
        CType(Me.DGVTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVTarjetas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BDontWanttobehere As Button
    Friend WithEvents BShowTarjetas As Button
    Friend WithEvents BAddTarjeta As Button
    Friend WithEvents Tnumtarjeta As TextBox
    Friend WithEvents Tcvv As TextBox
    Friend WithEvents Texpiration As TextBox
    Friend WithEvents LMETPG As Label
    Friend WithEvents Lnumt As Label
    Friend WithEvents Lidmetpag As Label
    Friend WithEvents Bmodify As Button
    Friend WithEvents Label4 As Label
End Class
