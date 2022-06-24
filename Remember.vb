Imports System.Data.SqlClient
Public Class Remember
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable

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

    Private Sub Remember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub BRemember_Click(sender As Object, e As EventArgs) Handles BRemember.Click
        Contraseña(RememberCurp.Text)
    End Sub

    Public Sub Contraseña(ByVal lecurp As String)
        conectar()
        Try
            cmd = New SqlCommand("recordarContrasena", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim parametro1 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.VarChar, 20)
            parametro1.Value = lecurp
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DTGRemember.DataSource = dt
            Else
                MessageBox.Show("CURP no encontrado")
            End If

            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BReturntoLog_Click(sender As Object, e As EventArgs) Handles BReturntoLog.Click
        Dim log As New Form1
        log.Show()
        Me.Hide()
    End Sub
End Class