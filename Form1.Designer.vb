<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TLogUser = New System.Windows.Forms.TextBox()
        Me.TLogPass = New System.Windows.Forms.TextBox()
        Me.BAceptLog = New System.Windows.Forms.Button()
        Me.BCancelLog = New System.Windows.Forms.Button()
        Me.BForgot = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(172, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bienvenido"
        '
        'TLogUser
        '
        Me.TLogUser.Location = New System.Drawing.Point(172, 112)
        Me.TLogUser.Name = "TLogUser"
        Me.TLogUser.Size = New System.Drawing.Size(185, 27)
        Me.TLogUser.TabIndex = 4
        '
        'TLogPass
        '
        Me.TLogPass.Location = New System.Drawing.Point(172, 196)
        Me.TLogPass.Name = "TLogPass"
        Me.TLogPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TLogPass.Size = New System.Drawing.Size(185, 27)
        Me.TLogPass.TabIndex = 5
        '
        'BAceptLog
        '
        Me.BAceptLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAceptLog.Location = New System.Drawing.Point(114, 312)
        Me.BAceptLog.Name = "BAceptLog"
        Me.BAceptLog.Size = New System.Drawing.Size(94, 29)
        Me.BAceptLog.TabIndex = 6
        Me.BAceptLog.Text = "Accept"
        Me.BAceptLog.UseVisualStyleBackColor = False
        '
        'BCancelLog
        '
        Me.BCancelLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelLog.Location = New System.Drawing.Point(282, 312)
        Me.BCancelLog.Name = "BCancelLog"
        Me.BCancelLog.Size = New System.Drawing.Size(94, 29)
        Me.BCancelLog.TabIndex = 7
        Me.BCancelLog.Text = "Cancel"
        Me.BCancelLog.UseVisualStyleBackColor = False
        '
        'BForgot
        '
        Me.BForgot.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BForgot.Location = New System.Drawing.Point(151, 370)
        Me.BForgot.Name = "BForgot"
        Me.BForgot.Size = New System.Drawing.Size(215, 29)
        Me.BForgot.TabIndex = 8
        Me.BForgot.Text = "¿Olvidaste tu contraseña?"
        Me.BForgot.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(151, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "¿Cliente Nuevo? Click Aquí"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(551, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BForgot)
        Me.Controls.Add(Me.BCancelLog)
        Me.Controls.Add(Me.BAceptLog)
        Me.Controls.Add(Me.TLogPass)
        Me.Controls.Add(Me.TLogUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TLogUser As TextBox
    Friend WithEvents TLogPass As TextBox
    Friend WithEvents BAceptLog As Button
    Friend WithEvents BCancelLog As Button
    Friend WithEvents BForgot As Button
    Friend WithEvents Button1 As Button
End Class
