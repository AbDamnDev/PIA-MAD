Imports System.Data.SqlClient
Public Class MenuCliente
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Dim history As New Historial
    Dim compras As New SHOPIN
    Dim tarjeta As New ADDTARJETAS
    Dim micuenta As New paracliente

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

    Private Sub MenuCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        LNomUser.Text = Form1.NombreCompleto
    End Sub

    Private Sub MenuStripCliente_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStripCliente.ItemClicked


    End Sub

    Private Sub BPayMethod_Click(sender As Object, e As EventArgs) Handles BPayMethod.Click

        tarjeta.Show()
        Me.Hide()
    End Sub

    Private Sub Bshoppin_Click(sender As Object, e As EventArgs) Handles Bshoppin.Click

        compras.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        history.Show()
        Me.Hide()
    End Sub

    Private Sub BMyaccount_Click(sender As Object, e As EventArgs) Handles BMyaccount.Click
        'mydata.Show()
        micuenta.Show()
        'Me.Hide()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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