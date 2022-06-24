Imports System.Data.SqlClient
Public Class ADDProducto
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public nomSucur As String
    Public selectedEmployee As String
    Public selectedSucurs As String
    Public selectedSucurs2 As String
    Public resultIndex As Integer
    Public selecprod As String
    Public versipasa As Boolean
    Public alo As String
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

    Private Sub ADDProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.NombreCompleto
        versipasa = False
        'Llenar el combobox de las sucursales para ver cuales tenemos disponibles      
        nombreSucursal2()
        nombreSucursal()

    End Sub
    Sub nombreSucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            nomSucur = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = nomSucur
            dt = New DataTable
            da = New SqlDataAdapter(nomSucur, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            CBsucursal.DataSource = dt
            CBsucursal.DisplayMember = "nombreSuc"
            CBsucursal.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Sub nombreSucursal2()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            nomSucur = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = nomSucur
            dt = New DataTable
            da = New SqlDataAdapter(nomSucur, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            CBShowPS.DataSource = dt
            CBShowPS.DisplayMember = "nombreSuc"
            CBShowPS.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bcancel_Click(sender As Object, e As EventArgs) Handles Bcancel.Click
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

    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click
        Dim unindiceagain As Integer
        unindiceagain = CBsucursal.SelectedIndex
        If unindiceagain <> -1 Then
            registrarProducto()
        End If

    End Sub
    Sub registrarProducto()
        Try
            conectar()
            cmd = New SqlCommand("insertarProducto", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEmpleado", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idSucursal", SqlDbType.Int)
            Parametro2.Value = SecretLabel.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@nombreProd", SqlDbType.VarChar, 40)
            Parametro3.Value = TX.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@descProd", SqlDbType.VarChar, 250)
            Parametro4.Value = TDescProduct.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@priceProd", SqlDbType.Float)
            Parametro5.Value = TPriceProduct.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@descuentoProd", SqlDbType.Float)
            Parametro6.Value = TMinusProduct.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@nombreCategoria", SqlDbType.VarChar, 40)
            Parametro7.Value = TCatProduct.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@Stock", SqlDbType.Int)
            Parametro8.Value = TStockP.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se Registro el producto")
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BCleanp_Click(sender As Object, e As EventArgs) Handles BCleanp.Click
        TX.Text = ""
        TDescProduct.Text = ""
        TPriceProduct.Text = ""
        TMinusProduct.Text = ""
        TCatProduct.Text = ""
        TStockP.Text = ""
        SucursalLBP.Text = ""
        CBsucursal.SelectedIndex = -1
    End Sub
    Sub buscarIDsucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = selectedSucurs
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                SecretLabel.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub CBsucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBsucursal.SelectedIndexChanged
        Dim unindice As Integer
        unindice = CBsucursal.SelectedIndex
        If unindice <> -1 Then
            selectedSucurs = CBsucursal.Text
            buscarIDsucursal()
        End If

    End Sub

    Private Sub CBShowPS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBShowPS.SelectedIndexChanged
        Dim dosindice As Integer
        dosindice = CBShowPS.SelectedIndex
        If dosindice <> -1 Then
            selectedSucurs2 = CBShowPS.Text
            buscarIDsucursal2()
            'TraerProductos()
        End If
    End Sub
    Sub buscarIDsucursal2()
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = selectedSucurs2
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                SecretLabel2.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub buscarIDsucursal2(Label2 As Label)
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = selectedSucurs2
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label2.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Sub TraerProductos()
        Try
            conectar()
            cmd = New SqlCommand("traerProductosSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idSuc", SqlDbType.Int)
            Parametro1.Value = SecretLabel2.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVProducto.DataSource = dt
            Else
                MessageBox.Show("Esta sucursal no tiene productos disponibles")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bshow_Click(sender As Object, e As EventArgs) Handles Bshow.Click
        Dim dosindice As Integer
        dosindice = CBShowPS.SelectedIndex
        If dosindice <> -1 Then
            TraerProductos()
        End If
    End Sub

    Private Sub DGVProducto_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducto.CellContentClick
        Dim Selecionfila As Integer
        'Dim seleccion2 As Integer
        Selecionfila = DGVProducto.CurrentRow.Index
        selecprod = DGVProducto.Item("id_codProducto", DGVProducto.CurrentRow.Index).Value
        Lidp.Text = selecprod
        selecprod = DGVProducto.Item("idSucursalProd", DGVProducto.CurrentRow.Index).Value
        Lidsp.Text = selecprod
        alo = DGVProducto.Item("nombreProd", DGVProducto.CurrentRow.Index).Value
        traerunproductodesucursal()
    End Sub
    Sub traerunproductodesucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerProductoSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idSuc", SqlDbType.Int)
            Parametro1.Value = Lidsp.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idProd", SqlDbType.Int)
            Parametro2.Value = Lidp.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ' TBnom.Text = dt.Rows(0).Item(3)
                TX.Text = dt.Rows(0).Item(1)
                TDescProduct.Text = dt.Rows(0).Item(2)
                TPriceProduct.Text = dt.Rows(0).Item(3)
                TMinusProduct.Text = dt.Rows(0).Item(4)
                TCatProduct.Text = dt.Rows(0).Item(5)
                TStockP.Text = dt.Rows(0).Item(6)
                SucursalLBP.Text = dt.Rows(0).Item(8)
                Dim indicecb As Integer
                indicecb = -1
                indicecb = CBsucursal.FindStringExact(SucursalLBP.Text)
                If indicecb <> -1 Then
                    CBsucursal.SelectedIndex = indicecb
                End If
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub validarproducto()
        Try
            conectar()
            cmd = New SqlCommand("isProductoRepetido", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@nomProd", SqlDbType.VarChar, 40)
            Parametro3.Value = TX.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                versipasa = False
            Else
                versipasa = True
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub BMassCP_Click(sender As Object, e As EventArgs) Handles BMassCP.Click
        Dim cargamassprod As New CargaMasivaProductos
        cargamassprod.Show()
        Me.Hide()

    End Sub
    Sub modificarelproducto()
        Try
            conectar()
            cmd = New SqlCommand("modProd", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro0 As SqlParameter = cmd.Parameters.Add("@idprod", SqlDbType.Int)
            Parametro0.Value = Lidp.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@nombreProd", SqlDbType.VarChar, 40)
            Parametro3.Value = TX.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@nombreCategoria", SqlDbType.VarChar, 40)
            Parametro7.Value = TCatProduct.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@priceProd", SqlDbType.Float)
            Parametro5.Value = TPriceProduct.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@descProd", SqlDbType.VarChar, 250)
            Parametro4.Value = TDescProduct.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@descuentoProd", SqlDbType.Float)
            Parametro6.Value = TMinusProduct.Text
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Bmod_Click(sender As Object, e As EventArgs) Handles Bmod.Click
        'solo si cambias el nombre del producto entonces entras a la validacion, de lo contrario no
        validarproducto()
        If CBsucursal.SelectedIndex <> -1 Then
            buscarIDsucursal2(lnew)
            If lnew.Text <> alo Then
                modificarproductoanuevasucursal()
                modificarelproducto()
            Else
                modificarelproducto()
                modificarelstock()
            End If
        End If
    End Sub
    Sub modificarproductoanuevasucursal()
        Try
            conectar()
            cmd = New SqlCommand("stockToNewSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro0 As SqlParameter = cmd.Parameters.Add("@idprod", SqlDbType.Int)
            Parametro0.Value = Lidp.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idsuc", SqlDbType.Int)
            Parametro2.Value = lnew.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@stock", SqlDbType.Int)
            Parametro8.Value = TStockP.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub modificarelstock()
        Try
            conectar()
            cmd = New SqlCommand("updateStock", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro0 As SqlParameter = cmd.Parameters.Add("@idprod", SqlDbType.Int)
            Parametro0.Value = Lidp.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idsuc", SqlDbType.Int)
            Parametro2.Value = SecretLabel.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@stock", SqlDbType.Int)
            Parametro8.Value = TStockP.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se modificó el producto")
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Class