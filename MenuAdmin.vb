Imports System.Data.SqlClient
Public Class MenuAdmin
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Dim addemplyee As New ADDEmpleado
    Dim addProduct As New ADDProducto
    Dim addSucursal As New ADDSucursal
    Dim desploquearcuenta As New Desbloquear
    Dim registrohora As New RgistroDeHoras
    Public CveEmpleado2 As Integer
    'Dim cobrar As New Pagarenefectivo
    Dim cashcash As New Cobrar
    Dim inventario As New ReporteProduct
    Dim reporthour As New HorasReport

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

    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        LAdminName.Text = Form1.NombreCompleto
        CveEmpleado2 = Form1.CveEmpleado

    End Sub

    Private Sub BEmpleadoAdmin_Click(sender As Object, e As EventArgs) Handles BEmpleadoAdmin.Click
        addemplyee.Show()
        Me.Hide()
    End Sub

    Private Sub BProductos_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        addProduct.Show()
        Me.Hide()
    End Sub

    Private Sub BSucursalAdmin_Click(sender As Object, e As EventArgs) Handles BSucursalAdmin.Click
        addSucursal.Show()
        Me.Hide()
    End Sub

    Private Sub BDesbloquear_Click(sender As Object, e As EventArgs) Handles BDesbloquear.Click
        desploquearcuenta.Show()
        Me.Hide()
    End Sub

    Private Sub BRegistroHora_Click(sender As Object, e As EventArgs) Handles BRegistroHora.Click

        registrohora.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cobrar.Show()
        'Me.Hide()
        cashcash.Show()
        Me.Hide()
    End Sub

    Private Sub BreporteInventarioAdmin_Click(sender As Object, e As EventArgs) Handles BreporteInventarioAdmin.Click
        inventario.Show()
        Me.Hide()
    End Sub

    Private Sub BrEPORThORARIO_Click(sender As Object, e As EventArgs) Handles BrEPORThORARIO.Click
        reporthour.Show()
        Me.Hide()
    End Sub

    Private Sub Bcerrarsesion_Click(sender As Object, e As EventArgs) Handles Bcerrarsesion.Click
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