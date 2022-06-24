Imports System.Data.SqlClient
'Imports BarcodeLib.BarcodeReader
Imports ZXing

Public Class Cobrar
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public datosmas As String
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
    Private Sub Cobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idcve.Text = Form1.CveEmpleado
        nomempl.Text = Form1.NombreCompleto
    End Sub

    Private Sub Bbye_Click(sender As Object, e As EventArgs) Handles Bbye.Click
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

    Private Sub Bload_Click(sender As Object, e As EventArgs) Handles Bload.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        BDECODE.Enabled = True
    End Sub

    Private Sub BDECODE_Click(sender As Object, e As EventArgs) Handles BDECODE.Click
        Dim Image As New Bitmap(PictureBox1.Image)
        Dim decoder As BarcodeReader = New BarcodeReader
        Dim resultado As String
        resultado = decoder.Decode(PictureBox1.Image).ToString
        LCarritoCode.Text = resultado
        traerlista()
    End Sub

    Private Sub Bmoney_Click(sender As Object, e As EventArgs) Handles Bmoney.Click
        Pagarcarrito()
    End Sub
    Sub traercliente()
        Try
            conectar()
            cmd = New SqlCommand("traerDatosCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idCLIENTE", SqlDbType.Int)
            Parametro1.Value = TclientID.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVclients.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub traerlista()
        Try
            conectar()
            cmd = New SqlCommand("traerListaCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
            Parametro1.Value = LCarritoCode.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub Pagarcarrito()
        Try
            conectar()
            cmd = New SqlCommand("pagarCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
            Parametro1.Value = LCarritoCode.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idClienteCarrito", SqlDbType.Int)
            Parametro2.Value = TclientID.Text
            da = New SqlDataAdapter(cmd)
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Carrito pagado")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bclientdata_Click(sender As Object, e As EventArgs) Handles Bclientdata.Click
        traercliente()
    End Sub
End Class