<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHOPIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SHOPIN))
        Me.CBsuscursalshopin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bgoback = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBcategory = New System.Windows.Forms.ComboBox()
        Me.DGVProducttoshop = New System.Windows.Forms.DataGridView()
        Me.BSearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sucursallabel = New System.Windows.Forms.Label()
        Me.Bagregando = New System.Windows.Forms.Button()
        Me.Bquitale = New System.Windows.Forms.Button()
        Me.TCantidad = New System.Windows.Forms.TextBox()
        Me.Bagregaacarrito = New System.Windows.Forms.Button()
        Me.LStock = New System.Windows.Forms.Label()
        Me.BCarro = New System.Windows.Forms.Button()
        CType(Me.DGVProducttoshop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBsuscursalshopin
        '
        Me.CBsuscursalshopin.FormattingEnabled = True
        Me.CBsuscursalshopin.Location = New System.Drawing.Point(12, 50)
        Me.CBsuscursalshopin.Name = "CBsuscursalshopin"
        Me.CBsuscursalshopin.Size = New System.Drawing.Size(151, 28)
        Me.CBsuscursalshopin.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sucursales:"
        '
        'Bgoback
        '
        Me.Bgoback.BackColor = System.Drawing.Color.Plum
        Me.Bgoback.Location = New System.Drawing.Point(694, 409)
        Me.Bgoback.Name = "Bgoback"
        Me.Bgoback.Size = New System.Drawing.Size(94, 29)
        Me.Bgoback.TabIndex = 2
        Me.Bgoback.Text = "Cancelar"
        Me.Bgoback.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(289, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categoría:"
        '
        'CBcategory
        '
        Me.CBcategory.FormattingEnabled = True
        Me.CBcategory.Location = New System.Drawing.Point(289, 50)
        Me.CBcategory.Name = "CBcategory"
        Me.CBcategory.Size = New System.Drawing.Size(151, 28)
        Me.CBcategory.TabIndex = 5
        '
        'DGVProducttoshop
        '
        Me.DGVProducttoshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProducttoshop.Location = New System.Drawing.Point(12, 167)
        Me.DGVProducttoshop.Name = "DGVProducttoshop"
        Me.DGVProducttoshop.RowHeadersWidth = 51
        Me.DGVProducttoshop.RowTemplate.Height = 29
        Me.DGVProducttoshop.Size = New System.Drawing.Size(448, 188)
        Me.DGVProducttoshop.TabIndex = 6
        '
        'BSearch
        '
        Me.BSearch.BackColor = System.Drawing.Color.Plum
        Me.BSearch.Location = New System.Drawing.Point(12, 104)
        Me.BSearch.Name = "BSearch"
        Me.BSearch.Size = New System.Drawing.Size(94, 29)
        Me.BSearch.TabIndex = 7
        Me.BSearch.Text = "Buscar"
        Me.BSearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(473, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'sucursallabel
        '
        Me.sucursallabel.AutoSize = True
        Me.sucursallabel.Location = New System.Drawing.Point(483, 50)
        Me.sucursallabel.Name = "sucursallabel"
        Me.sucursallabel.Size = New System.Drawing.Size(53, 20)
        Me.sucursallabel.TabIndex = 9
        Me.sucursallabel.Text = "Label4"
        Me.sucursallabel.Visible = False
        '
        'Bagregando
        '
        Me.Bagregando.Enabled = False
        Me.Bagregando.Location = New System.Drawing.Point(631, 252)
        Me.Bagregando.Name = "Bagregando"
        Me.Bagregando.Size = New System.Drawing.Size(38, 30)
        Me.Bagregando.TabIndex = 10
        Me.Bagregando.Text = "+"
        Me.Bagregando.UseVisualStyleBackColor = True
        '
        'Bquitale
        '
        Me.Bquitale.Enabled = False
        Me.Bquitale.Location = New System.Drawing.Point(483, 251)
        Me.Bquitale.Name = "Bquitale"
        Me.Bquitale.Size = New System.Drawing.Size(38, 33)
        Me.Bquitale.TabIndex = 11
        Me.Bquitale.Text = "-"
        Me.Bquitale.UseVisualStyleBackColor = True
        '
        'TCantidad
        '
        Me.TCantidad.Enabled = False
        Me.TCantidad.Location = New System.Drawing.Point(527, 254)
        Me.TCantidad.Name = "TCantidad"
        Me.TCantidad.Size = New System.Drawing.Size(98, 27)
        Me.TCantidad.TabIndex = 12
        '
        'Bagregaacarrito
        '
        Me.Bagregaacarrito.Enabled = False
        Me.Bagregaacarrito.Location = New System.Drawing.Point(483, 290)
        Me.Bagregaacarrito.Name = "Bagregaacarrito"
        Me.Bagregaacarrito.Size = New System.Drawing.Size(186, 29)
        Me.Bagregaacarrito.TabIndex = 13
        Me.Bagregaacarrito.Text = "Agregar Al Carrito"
        Me.Bagregaacarrito.UseVisualStyleBackColor = True
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Location = New System.Drawing.Point(483, 91)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(53, 20)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Label4"
        Me.LStock.Visible = False
        '
        'BCarro
        '
        Me.BCarro.Location = New System.Drawing.Point(694, 367)
        Me.BCarro.Name = "BCarro"
        Me.BCarro.Size = New System.Drawing.Size(94, 29)
        Me.BCarro.TabIndex = 15
        Me.BCarro.Text = "Mi Carrito"
        Me.BCarro.UseVisualStyleBackColor = True
        '
        'SHOPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BCarro)
        Me.Controls.Add(Me.LStock)
        Me.Controls.Add(Me.Bagregaacarrito)
        Me.Controls.Add(Me.TCantidad)
        Me.Controls.Add(Me.Bquitale)
        Me.Controls.Add(Me.Bagregando)
        Me.Controls.Add(Me.sucursallabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BSearch)
        Me.Controls.Add(Me.DGVProducttoshop)
        Me.Controls.Add(Me.CBcategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bgoback)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBsuscursalshopin)
        Me.Name = "SHOPIN"
        Me.Text = "SHOPIN"
        CType(Me.DGVProducttoshop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBsuscursalshopin As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Bgoback As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CBcategory As ComboBox
    Friend WithEvents DGVProducttoshop As DataGridView
    Friend WithEvents BSearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents sucursallabel As Label
    Friend WithEvents Bagregando As Button
    Friend WithEvents Bquitale As Button
    Friend WithEvents TCantidad As TextBox
    Friend WithEvents Bagregaacarrito As Button
    Friend WithEvents LStock As Label
    Friend WithEvents BCarro As Button
End Class
