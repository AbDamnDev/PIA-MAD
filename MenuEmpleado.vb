Imports System.Data.SqlClient
Public Class MenuEmpleado

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

    Private Sub MenuEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Label1.Text = Form1.NombreCompleto
    End Sub

    Private Sub Bproduct_Click(sender As Object, e As EventArgs) Handles Bproduct.Click
        Dim addProduc As New ADDProducto
        addProduc.Show()
        Me.Close()
    End Sub

    Private Sub BSucursalemp_Click(sender As Object, e As EventArgs) Handles BSucursalemp.Click
        Dim addSucursa As New ADDSucursal
        addSucursa.Show()
        Me.Close()
    End Sub

    Private Sub BdesUsuario_Click(sender As Object, e As EventArgs) Handles BdesUsuario.Click
        Dim desbloquearCuenta As New Desbloquear
        desbloquearCuenta.Show()
        Me.Hide()
    End Sub

    Private Sub BHourReg_Click(sender As Object, e As EventArgs) Handles BHourReg.Click
        Dim regis As New RgistroDeHoras
        regis.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim lecobrar As New Pagarenefectivo
        'lecobrar.Show()
        'Me.Hide()
        Dim mascash As New Cobrar
        mascash.Show()
        Me.Hide()
    End Sub

    Private Sub bInvent_Click(sender As Object, e As EventArgs) Handles bInvent.Click
        Dim masinventario As New ReporteProduct
        masinventario.Show()
        Me.Hide()
    End Sub

    Private Sub BreportHours_Click(sender As Object, e As EventArgs) Handles BreportHours.Click
        Dim mashora As New HorasReport
        mashora.Show()
        Me.Hide()
    End Sub

    Private Sub Bclosesesion_Click(sender As Object, e As EventArgs) Handles Bclosesesion.Click
        Form1.CveTipoUsuario = 0
        Form1.adelante = 0
        Form1.IDUser = ""
        Form1.power = ""
        Form1.CveCliente = 0
        Form1.CveEmpleado = 0
        Form1.NombreCompleto = ""
        Form1.CURP = ""
        Form1.RFC = ""
        Form1.TLogPass.Text = ""
        Form1.TLogUser.Text = ""
        Form1.Show()
        Me.Close()
    End Sub
End Class