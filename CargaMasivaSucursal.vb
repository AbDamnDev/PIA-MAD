Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class CargaMasivaSucursal
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Private indice As Integer

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
    Private Sub CargaMasivaSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lcveempleado.Text = Form1.CveEmpleado
        'mandar a llamar la funcion
        cargarsucursaldeexcel()
    End Sub

    Private Sub Bload_Click(sender As Object, e As EventArgs) Handles Bload.Click
        CargaMasivaSucursal()
    End Sub
    Sub cargarsucursaldeexcel()
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" &
"Data Source=D:\Documents\LMAD\6\Modelos de administracion de datos\-Material de Clases\PIA\bin\Debug\net5.0-windows\Excel\CargarSucursales.xlsx;Extended Properties= 'Excel 12.0 Xml;HDR=Yes;IMEX=1'")
            'D:\Documents\LMAD\6\Modelos de administracion de datos\-Material de Clases\PIA\bin\Debug\net5.0-windows\Excel
            'C:\Excel
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM [Hoja1$]", conn)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            dt.Clear()
            da.Fill(dt)
            DataCrgasucur.DataSource = dt
            con.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")

        End Try
    End Sub
    Sub CargaMasivaSucursal()
        Try

            For Each row As DataGridViewRow In DataCrgasucur.Rows
                If row.IsNewRow = True Then
                    DataCrgasucur.Rows.Remove(row)
                Else
                    conectar()
                    cmd = New SqlCommand("insertarSucursal", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEmpleado", SqlDbType.Int)
                    Parametro1.Value = Form1.CveEmpleado
                    Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nombreSuc", SqlDbType.VarChar, 40)
                    Parametro2.Value = row.Cells("Nombre").Value.ToString
                    Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
                    Parametro3.Value = row.Cells("Calle").Value.ToString
                    Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
                    Parametro4.Value = row.Cells("Numero").Value.ToString
                    Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
                    Parametro5.Value = row.Cells("Colonia").Value.ToString
                    Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
                    Parametro6.Value = row.Cells("Municipio").Value.ToString
                    Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
                    Parametro7.Value = row.Cells("Estado").Value.ToString
                    Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
                    Parametro8.Value = row.Cells("Codigo Postal").Value.ToString

                    da.InsertCommand = cmd
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()

                    desconectar()
                End If
            Next
            MessageBox.Show("Sucursales Cargadas")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim regresoasucur As New ADDSucursal
        regresoasucur.Show()
        Me.Hide()
    End Sub

End Class