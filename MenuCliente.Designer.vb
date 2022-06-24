<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuCliente))
        Me.MenuStripCliente = New System.Windows.Forms.MenuStrip()
        Me.TSMPPCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGVcliente1 = New System.Windows.Forms.DataGridView()
        Me.LNomUser = New System.Windows.Forms.Label()
        Me.BMyaccount = New System.Windows.Forms.Button()
        Me.BPayMethod = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Bshoppin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStripCliente.SuspendLayout()
        CType(Me.DGVcliente1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStripCliente
        '
        Me.MenuStripCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStripCliente.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMPPCliente})
        Me.MenuStripCliente.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripCliente.Name = "MenuStripCliente"
        Me.MenuStripCliente.Size = New System.Drawing.Size(694, 32)
        Me.MenuStripCliente.TabIndex = 0
        Me.MenuStripCliente.Text = "MenuStrip1"
        '
        'TSMPPCliente
        '
        Me.TSMPPCliente.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TSMPPCliente.Name = "TSMPPCliente"
        Me.TSMPPCliente.Size = New System.Drawing.Size(156, 28)
        Me.TSMPPCliente.Text = "Pantalla Principal"
        '
        'DGVcliente1
        '
        Me.DGVcliente1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVcliente1.Location = New System.Drawing.Point(292, 82)
        Me.DGVcliente1.Name = "DGVcliente1"
        Me.DGVcliente1.RowHeadersWidth = 51
        Me.DGVcliente1.RowTemplate.Height = 29
        Me.DGVcliente1.Size = New System.Drawing.Size(377, 262)
        Me.DGVcliente1.TabIndex = 1
        '
        'LNomUser
        '
        Me.LNomUser.AutoSize = True
        Me.LNomUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LNomUser.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LNomUser.Location = New System.Drawing.Point(12, 32)
        Me.LNomUser.Name = "LNomUser"
        Me.LNomUser.Size = New System.Drawing.Size(61, 24)
        Me.LNomUser.TabIndex = 2
        Me.LNomUser.Text = "Label1"
        '
        'BMyaccount
        '
        Me.BMyaccount.BackColor = System.Drawing.Color.Teal
        Me.BMyaccount.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BMyaccount.ForeColor = System.Drawing.Color.White
        Me.BMyaccount.Location = New System.Drawing.Point(266, 0)
        Me.BMyaccount.Name = "BMyaccount"
        Me.BMyaccount.Size = New System.Drawing.Size(111, 32)
        Me.BMyaccount.TabIndex = 3
        Me.BMyaccount.Text = "Mi Cuenta"
        Me.BMyaccount.UseVisualStyleBackColor = False
        '
        'BPayMethod
        '
        Me.BPayMethod.BackColor = System.Drawing.Color.Teal
        Me.BPayMethod.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BPayMethod.ForeColor = System.Drawing.Color.White
        Me.BPayMethod.Location = New System.Drawing.Point(383, 0)
        Me.BPayMethod.Name = "BPayMethod"
        Me.BPayMethod.Size = New System.Drawing.Size(154, 32)
        Me.BPayMethod.TabIndex = 4
        Me.BPayMethod.Text = "Método de Pago"
        Me.BPayMethod.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Emoji", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(543, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 32)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Mi Historial"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Bshoppin
        '
        Me.Bshoppin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bshoppin.Location = New System.Drawing.Point(25, 229)
        Me.Bshoppin.Name = "Bshoppin"
        Me.Bshoppin.Size = New System.Drawing.Size(117, 60)
        Me.Bshoppin.TabIndex = 7
        Me.Bshoppin.Text = "Ir A Comprar"
        Me.Bshoppin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(25, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 60)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cerrar Sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 380)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bshoppin)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BPayMethod)
        Me.Controls.Add(Me.BMyaccount)
        Me.Controls.Add(Me.LNomUser)
        Me.Controls.Add(Me.DGVcliente1)
        Me.Controls.Add(Me.MenuStripCliente)
        Me.Name = "MenuCliente"
        Me.Text = "MenuCliente"
        Me.MenuStripCliente.ResumeLayout(False)
        Me.MenuStripCliente.PerformLayout()
        CType(Me.DGVcliente1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripCliente As MenuStrip
    Friend WithEvents TSMPPCliente As ToolStripMenuItem
    Friend WithEvents DGVcliente1 As DataGridView
    Friend WithEvents LNomUser As Label
    Friend WithEvents BMyaccount As Button
    Friend WithEvents BPayMethod As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Bshoppin As Button
    Friend WithEvents Button1 As Button
End Class
