<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cobrar))
        Me.idcve = New System.Windows.Forms.Label()
        Me.nomempl = New System.Windows.Forms.Label()
        Me.Bbye = New System.Windows.Forms.Button()
        Me.Bmoney = New System.Windows.Forms.Button()
        Me.Bload = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BDECODE = New System.Windows.Forms.Button()
        Me.LCarritoCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TclientID = New System.Windows.Forms.TextBox()
        Me.DGVclients = New System.Windows.Forms.DataGridView()
        Me.Bclientdata = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVclients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idcve
        '
        Me.idcve.AutoSize = True
        Me.idcve.BackColor = System.Drawing.Color.Transparent
        Me.idcve.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.idcve.Location = New System.Drawing.Point(13, 13)
        Me.idcve.Name = "idcve"
        Me.idcve.Size = New System.Drawing.Size(59, 23)
        Me.idcve.TabIndex = 0
        Me.idcve.Text = "Label1"
        '
        'nomempl
        '
        Me.nomempl.AutoSize = True
        Me.nomempl.BackColor = System.Drawing.Color.Transparent
        Me.nomempl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nomempl.Location = New System.Drawing.Point(13, 37)
        Me.nomempl.Name = "nomempl"
        Me.nomempl.Size = New System.Drawing.Size(63, 25)
        Me.nomempl.TabIndex = 1
        Me.nomempl.Text = "Label1"
        '
        'Bbye
        '
        Me.Bbye.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bbye.Location = New System.Drawing.Point(694, 409)
        Me.Bbye.Name = "Bbye"
        Me.Bbye.Size = New System.Drawing.Size(94, 29)
        Me.Bbye.TabIndex = 2
        Me.Bbye.Text = "Cancelar"
        Me.Bbye.UseVisualStyleBackColor = False
        '
        'Bmoney
        '
        Me.Bmoney.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bmoney.Location = New System.Drawing.Point(694, 374)
        Me.Bmoney.Name = "Bmoney"
        Me.Bmoney.Size = New System.Drawing.Size(94, 29)
        Me.Bmoney.TabIndex = 3
        Me.Bmoney.Text = "Cobrar"
        Me.Bmoney.UseVisualStyleBackColor = False
        '
        'Bload
        '
        Me.Bload.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bload.Location = New System.Drawing.Point(694, 339)
        Me.Bload.Name = "Bload"
        Me.Bload.Size = New System.Drawing.Size(94, 29)
        Me.Bload.TabIndex = 4
        Me.Bload.Text = "Cargar"
        Me.Bload.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(556, 188)
        Me.DataGridView1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(32, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BDECODE
        '
        Me.BDECODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BDECODE.Enabled = False
        Me.BDECODE.Location = New System.Drawing.Point(694, 304)
        Me.BDECODE.Name = "BDECODE"
        Me.BDECODE.Size = New System.Drawing.Size(94, 29)
        Me.BDECODE.TabIndex = 7
        Me.BDECODE.Text = "Procesar"
        Me.BDECODE.UseVisualStyleBackColor = False
        '
        'LCarritoCode
        '
        Me.LCarritoCode.AutoSize = True
        Me.LCarritoCode.BackColor = System.Drawing.Color.Transparent
        Me.LCarritoCode.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.LCarritoCode.Location = New System.Drawing.Point(309, 9)
        Me.LCarritoCode.Name = "LCarritoCode"
        Me.LCarritoCode.Size = New System.Drawing.Size(59, 23)
        Me.LCarritoCode.TabIndex = 8
        Me.LCarritoCode.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(503, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID de Cliente:"
        '
        'TclientID
        '
        Me.TclientID.Location = New System.Drawing.Point(649, 25)
        Me.TclientID.Name = "TclientID"
        Me.TclientID.Size = New System.Drawing.Size(125, 27)
        Me.TclientID.TabIndex = 10
        '
        'DGVclients
        '
        Me.DGVclients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVclients.Location = New System.Drawing.Point(432, 93)
        Me.DGVclients.Name = "DGVclients"
        Me.DGVclients.RowHeadersWidth = 51
        Me.DGVclients.RowTemplate.Height = 29
        Me.DGVclients.Size = New System.Drawing.Size(342, 96)
        Me.DGVclients.TabIndex = 11
        '
        'Bclientdata
        '
        Me.Bclientdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bclientdata.Location = New System.Drawing.Point(692, 58)
        Me.Bclientdata.Name = "Bclientdata"
        Me.Bclientdata.Size = New System.Drawing.Size(82, 29)
        Me.Bclientdata.TabIndex = 12
        Me.Bclientdata.Text = "Cargar"
        Me.Bclientdata.UseVisualStyleBackColor = False
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bclientdata)
        Me.Controls.Add(Me.DGVclients)
        Me.Controls.Add(Me.TclientID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LCarritoCode)
        Me.Controls.Add(Me.BDECODE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Bload)
        Me.Controls.Add(Me.Bmoney)
        Me.Controls.Add(Me.Bbye)
        Me.Controls.Add(Me.nomempl)
        Me.Controls.Add(Me.idcve)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVclients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idcve As Label
    Friend WithEvents nomempl As Label
    Friend WithEvents Bbye As Button
    Friend WithEvents Bmoney As Button
    Friend WithEvents Bload As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BDECODE As Button
    Friend WithEvents LCarritoCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TclientID As TextBox
    Friend WithEvents DGVclients As DataGridView
    Friend WithEvents Bclientdata As Button
End Class
