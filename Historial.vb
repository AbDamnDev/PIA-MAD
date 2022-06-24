Imports System.Data.SqlClient
Public Class Historial
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public Sub conectar()
        Try
            con.Open()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub desconectar()
        Try
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NAMES.Text = Form1.NombreCompleto
        IDS.Text = Form1.CveCliente
        traesrcarritos()
    End Sub

    Sub traesrcarritos()
        Try
            conectar()
            cmd = New SqlCommand("traerHistorialCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idClienteCarrito", SqlDbType.Int)
            Parametro1.Value = IDS.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVHistory.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BgOgO_Click(sender As Object, e As EventArgs) Handles BgOgO.Click
        Dim menucliente As New MenuCliente
        menucliente.Show()
        Me.Hide()
    End Sub
End Class