Imports System.Data.SqlClient

Public Class Form1
    Private intento As Integer
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public CveTipoUsuario As Integer
    Public adelante As Integer
    Public IDUser As String
    Public power As String
    Public CveCliente As Integer
    Public CveEmpleado As Integer
    Public NombreCompleto As String
    Public CURP As String
    Public RFC As String
    Dim adminmenu As New MenuAdmin
    Dim menuCliente As New MenuCliente
    Dim menuEmpleado As New MenuEmpleado


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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        queestenlimpioslostxt()
        intento = 0
        adelante = 0
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub
    Sub queestenlimpioslostxt()
        TLogUser.Text = ""
        TLogPass.Text = ""
    End Sub
    Private Sub BAceptLog_Click(sender As Object, e As EventArgs) Handles BAceptLog.Click
        If intento < 3 Then

            Inicio(TLogUser.Text, TLogPass.Text)

        End If

        If intento = 3 Then
            Bloquear(TLogUser.Text)
            MessageBox.Show("Usuario bloqueado")
            intento = 0
        End If

    End Sub

    Public Sub Inicio(ByVal user As String, ByVal pass As String)


        conectar()
        Try
            cmd = New SqlCommand("loginGeneral", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            parametro1.Value = user
            Dim parametro2 As SqlParameter = cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 20)
            parametro2.Value = pass
            'Dim parametro3 As SqlParameter = cmd.Parameters.Add("@tipousuario", SqlDbType.Int)
            'parametro3.Value = 0
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            'CveTipoUsuario = parametro3.Value
            da.Fill(dt)
            'CveTipoUsuario = parametro3.Value
            If dt.Rows.Count > 0 Then
                CveTipoUsuario = dt.Rows(0).Item(0)
                'MessageBox.Show("Usuario Encontrado")
                adelante = 1

                If CveTipoUsuario = 1 Then
                    CveCliente = dt.Rows(0).Item(1)
                    NombreCompleto = dt.Rows(0).Item(2)
                    CURP = dt.Rows(0).Item(3)
                    menuCliente.Show()
                    Me.Hide()
                ElseIf CveTipoUsuario = 2 Then
                    CveEmpleado = dt.Rows(0).Item(1)
                    NombreCompleto = dt.Rows(0).Item(2)
                    RFC = dt.Rows(0).Item(3)
                    menuEmpleado.Show()
                    Me.Hide()
                ElseIf CveTipoUsuario = 3 Then
                    CveEmpleado = dt.Rows(0).Item(1)
                    NombreCompleto = dt.Rows(0).Item(2)
                    RFC = dt.Rows(0).Item(3)
                    adminmenu.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Usuario no encontrado o bloqueado")
                intento = intento + 1
            End If

            cmd.ExecuteNonQuery()
            IDUser = user
            power = pass
            desconectar()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Public Sub Bloquear(ByVal useragain As String)
        conectar()
        Try

            cmd = New SqlCommand("bloquearUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 25)
            Parametro1.Value = useragain
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BForgot_Click(sender As Object, e As EventArgs) Handles BForgot.Click
        Dim remember As New Remember
        remember.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim añadircliente As New Addcliente
        añadircliente.Show()
        Me.Hide()
    End Sub
End Class
