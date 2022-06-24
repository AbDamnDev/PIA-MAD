Imports System.Data.SqlClient
Public Class Desbloquear
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Private stringparaempleado As String

    Public Sub conectar()
        Try
            con.Open()
            'MessageBox.Show("Conectado")
        Catch ex As Exception
            'MessageBox.Show("Error al conectar")
        End Try
    End Sub
    Public Sub desconectar()
        Try
            con.Close()
            'MessageBox.Show("Desconectado")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Desbloquear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomusuario.Text = Form1.NombreCompleto
        If Form1.CveTipoUsuario = 2 Then
            Showemplyeblock.Visible = False
        End If
    End Sub

    Private Sub butonbyebye_Click(sender As Object, e As EventArgs) Handles butonbyebye.Click
        If Form1.CveTipoUsuario = 2 Then
            Dim empleadomenu As New MenuEmpleado
            empleadomenu.Show()
            Me.Hide()
        End If
        If Form1.CveTipoUsuario = 3 Then
            Dim adminmen As New MenuAdmin
            adminmen.Show()
            Me.Hide()
        End If
    End Sub
    Sub paradesbloquear()
        Try
            conectar()
            cmd = New SqlCommand("desbloquearUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@admin", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            Parametro2.Value = Tusuariobloqueado.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Usuario Desbloqueado")

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bunblock_Click(sender As Object, e As EventArgs) Handles Bunblock.Click
        paradesbloquear()
        limpiarpantalla()
    End Sub
    Sub limpiarpantalla()
        Tusuariobloqueado.Text = ""
        dgvk.DataSource = Nothing
    End Sub

    Private Sub Showemplyeblock_Click(sender As Object, e As EventArgs) Handles Showemplyeblock.Click
        cargarempleadobloqueado()
    End Sub

    Private Sub Showclientblock_Click(sender As Object, e As EventArgs) Handles Showclientblock.Click
        cargarclientebloqueado()
    End Sub
    Sub cargarempleadobloqueado()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            stringparaempleado = "SELECT 
US.nombre+' '+US.apellidoMat +' '+US.apellidoPat AS NombreCompleto,
US.usuario,
EM.RFC
FROM Empleado EM
INNER JOIN Usuario US ON EM.idUsuarioEmp=US.idUser
WHERE EM.bloqueado=1;"
            cmd.CommandText = stringparaempleado
            dt = New DataTable
            da = New SqlDataAdapter(stringparaempleado, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgvk.DataSource = dt
            Else
                MessageBox.Show("No hay Empleados Bloqueados")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try

    End Sub
    Sub cargarclientebloqueado()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            stringparaempleado = "SELECT 
US.nombre+' '+US.apellidoMat +' '+US.apellidoPat AS NombreCompleto,
US.usuario,
US.CURP,
CL.correo
FROM Cliente CL
INNER JOIN Usuario US ON CL.idUsuario=US.idUser
WHERE CL.bloqueado=1;"
            cmd.CommandText = stringparaempleado
            dt = New DataTable
            da = New SqlDataAdapter(stringparaempleado, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dgvk.DataSource = dt
            Else
                MessageBox.Show("No hay Clientes Bloqueados")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try

    End Sub
End Class