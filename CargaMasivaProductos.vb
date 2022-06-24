Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CargaMasivaProductos
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public nomSucurmass As String
    Public Sucursaldehoy As String
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
    Private Sub CargaMasivaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarproductodelexcel()
        nombreSucursal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim regresoaproduct As New ADDProducto
        regresoaproduct.Show()
        Me.Hide()
    End Sub
    Sub cargarproductodelexcel()
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
"Data Source=D:\Documents\LMAD\6\Modelos de administracion de datos\-Material de Clases\PIA\bin\Debug\net5.0-windows\Excel\CargarProductos.xlsx;Extended Properties= 'Excel 12.0 Xml;HDR=Yes;IMEX=1'")
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM [Hoja1$]", conn)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DGVprodmass.DataSource = dt
            con.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")

        End Try
    End Sub
    Sub nombreSucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            nomSucurmass = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = nomSucurmass
            dt = New DataTable
            da = New SqlDataAdapter(nomSucurmass, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            cbSucursalm.DataSource = dt
            cbSucursalm.DisplayMember = "nombreSuc"
            cbSucursalm.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub cbSucursalm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSucursalm.SelectedIndexChanged
        Dim unindice As Integer
        unindice = cbSucursalm.SelectedIndex
        If unindice <> -1 Then
            Sucursaldehoy = cbSucursalm.Text
            buscarelIDsucursal()
        End If
    End Sub
    Sub buscarelIDsucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = Sucursaldehoy
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                LSucur.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Badelante_Click(sender As Object, e As EventArgs) Handles Badelante.Click
        Dim unindiceagain As Integer
        unindiceagain = cbSucursalm.SelectedIndex
        If unindiceagain <> -1 Then
            CargarMassiveProducts()
        End If

    End Sub
    Sub CargarMassiveProducts()
        Try
            For Each row As DataGridViewRow In DGVprodmass.Rows
                If row.IsNewRow = True Then
                    DGVprodmass.Rows.Remove(row)
                Else
                    conectar()
                    cmd = New SqlCommand("insertarProducto", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEmpleado", SqlDbType.Int)
                    Parametro1.Value = Form1.CveEmpleado
                    Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idSucursal", SqlDbType.Int)
                    Parametro2.Value = LSucur.Text
                    Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@nombreProd", SqlDbType.VarChar, 40)
                    Parametro3.Value = row.Cells("Nombre").Value.ToString
                    Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@descProd", SqlDbType.VarChar, 250)
                    Parametro4.Value = row.Cells("Descripcion").Value.ToString
                    Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@priceProd", SqlDbType.Float)
                    Parametro5.Value = row.Cells("Precio").Value.ToString
                    Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@descuentoProd", SqlDbType.Float)
                    Parametro6.Value = row.Cells("Descuento").Value.ToString
                    Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@nombreCategoria", SqlDbType.VarChar, 40)
                    Parametro7.Value = row.Cells("Categoria").Value.ToString
                    Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@Stock", SqlDbType.Int)
                    Parametro8.Value = row.Cells("Stock").Value.ToString

                    da.InsertCommand = cmd
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()
                    desconectar()
                End If
            Next
            MessageBox.Show("Productos Cargados")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub


End Class