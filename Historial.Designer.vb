<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historial))
        Me.BgOgO = New System.Windows.Forms.Button()
        Me.DGVHistory = New System.Windows.Forms.DataGridView()
        Me.NAMES = New System.Windows.Forms.Label()
        Me.IDS = New System.Windows.Forms.Label()
        CType(Me.DGVHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BgOgO
        '
        Me.BgOgO.Location = New System.Drawing.Point(663, 358)
        Me.BgOgO.Name = "BgOgO"
        Me.BgOgO.Size = New System.Drawing.Size(94, 29)
        Me.BgOgO.TabIndex = 0
        Me.BgOgO.Text = "Cancel"
        Me.BgOgO.UseVisualStyleBackColor = True
        '
        'DGVHistory
        '
        Me.DGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHistory.Location = New System.Drawing.Point(24, 110)
        Me.DGVHistory.Name = "DGVHistory"
        Me.DGVHistory.RowHeadersWidth = 51
        Me.DGVHistory.RowTemplate.Height = 29
        Me.DGVHistory.Size = New System.Drawing.Size(733, 225)
        Me.DGVHistory.TabIndex = 1
        '
        'NAMES
        '
        Me.NAMES.AutoSize = True
        Me.NAMES.BackColor = System.Drawing.Color.Transparent
        Me.NAMES.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NAMES.Location = New System.Drawing.Point(24, 41)
        Me.NAMES.Name = "NAMES"
        Me.NAMES.Size = New System.Drawing.Size(84, 31)
        Me.NAMES.TabIndex = 2
        Me.NAMES.Text = "Label1"
        '
        'IDS
        '
        Me.IDS.AutoSize = True
        Me.IDS.Location = New System.Drawing.Point(572, 70)
        Me.IDS.Name = "IDS"
        Me.IDS.Size = New System.Drawing.Size(53, 20)
        Me.IDS.TabIndex = 3
        Me.IDS.Text = "Label2"
        Me.IDS.Visible = False
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(775, 400)
        Me.Controls.Add(Me.IDS)
        Me.Controls.Add(Me.NAMES)
        Me.Controls.Add(Me.DGVHistory)
        Me.Controls.Add(Me.BgOgO)
        Me.Name = "Historial"
        Me.Text = "Historial"
        CType(Me.DGVHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BgOgO As Button
    Friend WithEvents DGVHistory As DataGridView
    Friend WithEvents NAMES As Label
    Friend WithEvents IDS As Label
End Class
