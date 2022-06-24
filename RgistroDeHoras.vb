Imports System.Data.SqlClient
Imports Sytem.DateTime.Day
Imports System
Public Class RgistroDeHoras
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public nomSucur As String
    Dim currentTime As System.DateTime = System.DateTime.Now
    Public fecha As String

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

    Private Sub RgistroDeHoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idempleado.Text = Form1.CveEmpleado
        Nomnom.Text = Form1.NombreCompleto
        horarioalgo()
        fecha = currentTime.Date

    End Sub

    Sub horarioalgo()
        Try
            conectar()
            cmd = New SqlCommand("TraerUltimosHorarios", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            da.InsertCommand = cmd
            dt = New DataTable
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVhours.DataSource = dt
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Bgoback_Click(sender As Object, e As EventArgs) Handles Bgoback.Click
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

    Private Sub Baceptar_Click(sender As Object, e As EventArgs) Handles Baceptar.Click

        registrahora()
    End Sub

    Sub registrahora()
        Try
            conectar()
            cmd = New SqlCommand("insertarHorarioEmp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            da.InsertCommand = cmd
            dt = New DataTable
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Inicio de Horario Registrado")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub salida()
        Try
            conectar()
            cmd = New SqlCommand("insertarHorarioEmpSalida", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            da.InsertCommand = cmd
            dt = New DataTable
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Fin de Horario Registrado")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Bout_Click(sender As Object, e As EventArgs) Handles Bout.Click
        salida()
    End Sub
End Class