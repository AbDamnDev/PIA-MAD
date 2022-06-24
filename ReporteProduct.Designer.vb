<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteProduct))
        Me.Idcve = New System.Windows.Forms.Label()
        Me.Bvolver = New System.Windows.Forms.Button()
        Me.Bgenerar = New System.Windows.Forms.Button()
        Me.LNAMENAME = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Csucursal = New System.Windows.Forms.ComboBox()
        Me.DGVpinv = New System.Windows.Forms.DataGridView()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.LSucurID = New System.Windows.Forms.Label()
        CType(Me.DGVpinv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Idcve
        '
        Me.Idcve.AutoSize = True
        Me.Idcve.BackColor = System.Drawing.Color.Transparent
        Me.Idcve.Location = New System.Drawing.Point(13, 13)
        Me.Idcve.Name = "Idcve"
        Me.Idcve.Size = New System.Drawing.Size(24, 20)
        Me.Idcve.TabIndex = 0
        Me.Idcve.Text = "ID"
        Me.Idcve.Visible = False
        '
        'Bvolver
        '
        Me.Bvolver.Location = New System.Drawing.Point(694, 390)
        Me.Bvolver.Name = "Bvolver"
        Me.Bvolver.Size = New System.Drawing.Size(94, 48)
        Me.Bvolver.TabIndex = 1
        Me.Bvolver.Text = "Cancelar"
        Me.Bvolver.UseVisualStyleBackColor = True
        '
        'Bgenerar
        '
        Me.Bgenerar.Enabled = False
        Me.Bgenerar.Location = New System.Drawing.Point(594, 390)
        Me.Bgenerar.Name = "Bgenerar"
        Me.Bgenerar.Size = New System.Drawing.Size(94, 48)
        Me.Bgenerar.TabIndex = 2
        Me.Bgenerar.Text = "Generar PDF"
        Me.Bgenerar.UseVisualStyleBackColor = True
        '
        'LNAMENAME
        '
        Me.LNAMENAME.AutoSize = True
        Me.LNAMENAME.BackColor = System.Drawing.Color.Transparent
        Me.LNAMENAME.Location = New System.Drawing.Point(44, 13)
        Me.LNAMENAME.Name = "LNAMENAME"
        Me.LNAMENAME.Size = New System.Drawing.Size(70, 20)
        Me.LNAMENAME.TabIndex = 3
        Me.LNAMENAME.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sucursal"
        '
        'Csucursal
        '
        Me.Csucursal.FormattingEnabled = True
        Me.Csucursal.Location = New System.Drawing.Point(13, 85)
        Me.Csucursal.Name = "Csucursal"
        Me.Csucursal.Size = New System.Drawing.Size(151, 28)
        Me.Csucursal.TabIndex = 5
        '
        'DGVpinv
        '
        Me.DGVpinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpinv.Location = New System.Drawing.Point(13, 165)
        Me.DGVpinv.Name = "DGVpinv"
        Me.DGVpinv.RowHeadersWidth = 51
        Me.DGVpinv.RowTemplate.Height = 29
        Me.DGVpinv.Size = New System.Drawing.Size(775, 188)
        Me.DGVpinv.TabIndex = 6
        '
        'BSearch
        '
        Me.BSearch.Enabled = False
        Me.BSearch.Location = New System.Drawing.Point(12, 119)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(94, 29)
        Me.BSearch.TabIndex = 7
        Me.BSearch.Text = "Buscar"
        Me.BSearch.UseVisualStyleBackColor = True
        '
        'LSucurID
        '
        Me.LSucurID.AutoSize = True
        Me.LSucurID.Location = New System.Drawing.Point(187, 87)
        Me.LSucurID.Name = "LSucurID"
        Me.LSucurID.Size = New System.Drawing.Size(53, 20)
        Me.LSucurID.TabIndex = 8
        Me.LSucurID.Text = "Label2"
        Me.LSucurID.Visible = False
        '
        'ReporteProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LSucurID)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.DGVpinv)
        Me.Controls.Add(Me.Csucursal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LNAMENAME)
        Me.Controls.Add(Me.Bgenerar)
        Me.Controls.Add(Me.Bvolver)
        Me.Controls.Add(Me.Idcve)
        Me.Name = "ReporteProduct"
        Me.Text = "ReporteProduct"
        CType(Me.DGVpinv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Idcve As Label
    Friend WithEvents Bvolver As Button
    Friend WithEvents Bgenerar As Button
    Friend WithEvents LNAMENAME As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Csucursal As ComboBox
    Friend WithEvents DGVpinv As DataGridView
    Friend WithEvents BSearch As Button
    Friend WithEvents LSucurID As Label
End Class
