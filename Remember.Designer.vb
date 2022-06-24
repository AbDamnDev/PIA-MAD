<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remember))
        Me.RememberCurp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTGRemember = New System.Windows.Forms.DataGridView()
        Me.BRemember = New System.Windows.Forms.Button()
        Me.BReturntoLog = New System.Windows.Forms.Button()
        CType(Me.DTGRemember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RememberCurp
        '
        Me.RememberCurp.BackColor = System.Drawing.Color.Maroon
        Me.RememberCurp.ForeColor = System.Drawing.Color.White
        Me.RememberCurp.Location = New System.Drawing.Point(12, 81)
        Me.RememberCurp.Name = "RememberCurp"
        Me.RememberCurp.Size = New System.Drawing.Size(305, 27)
        Me.RememberCurp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese su CURP:"
        '
        'DTGRemember
        '
        Me.DTGRemember.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DTGRemember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRemember.Location = New System.Drawing.Point(12, 129)
        Me.DTGRemember.Name = "DTGRemember"
        Me.DTGRemember.RowHeadersWidth = 51
        Me.DTGRemember.RowTemplate.Height = 29
        Me.DTGRemember.Size = New System.Drawing.Size(497, 109)
        Me.DTGRemember.TabIndex = 2
        '
        'BRemember
        '
        Me.BRemember.BackColor = System.Drawing.Color.Maroon
        Me.BRemember.ForeColor = System.Drawing.Color.White
        Me.BRemember.Location = New System.Drawing.Point(415, 79)
        Me.BRemember.Name = "BRemember"
        Me.BRemember.Size = New System.Drawing.Size(94, 29)
        Me.BRemember.TabIndex = 3
        Me.BRemember.Text = "Aceptar"
        Me.BRemember.UseVisualStyleBackColor = False
        '
        'BReturntoLog
        '
        Me.BReturntoLog.BackColor = System.Drawing.Color.Maroon
        Me.BReturntoLog.ForeColor = System.Drawing.Color.White
        Me.BReturntoLog.Location = New System.Drawing.Point(191, 254)
        Me.BReturntoLog.Name = "BReturntoLog"
        Me.BReturntoLog.Size = New System.Drawing.Size(94, 29)
        Me.BReturntoLog.TabIndex = 4
        Me.BReturntoLog.Text = "Volver"
        Me.BReturntoLog.UseVisualStyleBackColor = False
        '
        'Remember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(521, 307)
        Me.Controls.Add(Me.BReturntoLog)
        Me.Controls.Add(Me.BRemember)
        Me.Controls.Add(Me.DTGRemember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RememberCurp)
        Me.Name = "Remember"
        Me.Text = "Recuerde su contraseña"
        CType(Me.DTGRemember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RememberCurp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTGRemember As DataGridView
    Friend WithEvents BRemember As Button
    Friend WithEvents BReturntoLog As Button
End Class
