Imports System.Data.SqlClient
Public Class SHOPIN
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public Sucurname As String
    Public categoryproduct As String
    Public sselected As String
    Public categoria As String
    Public tomarstock As String
    Private Manipularmasmenos As Integer
    Public DTListaCarrito As DataTable
    Dim lecar As New Carrito
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

    Private Sub Bgoback_Click(sender As Object, e As EventArgs) Handles Bgoback.Click
        Dim menucliente As New MenuCliente
        menucliente.Show()
        Me.Hide()
    End Sub

    Private Sub SHOPIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nombreSucursal()
        CategoríaProducto()
    End Sub
    Sub nombreSucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            Sucurname = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = Sucurname
            dt = New DataTable
            da = New SqlDataAdapter(Sucurname, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            CBsuscursalshopin.DataSource = dt
            CBsuscursalshopin.DisplayMember = "nombreSuc"
            CBsuscursalshopin.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Sub CategoríaProducto()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            categoryproduct = "SELECT
nombreCategoria
FROM Producto
GROUP BY nombreCategoria;"
            cmd.CommandText = categoryproduct
            dt = New DataTable
            da = New SqlDataAdapter(categoryproduct, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            CBcategory.DataSource = dt
            CBcategory.DisplayMember = "nombreCategoria"
            CBcategory.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub acomprar()
        Try
            conectar()
            cmd = New SqlCommand("traerProductosParaComprar", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idSuc", SqlDbType.Int)
            Parametro1.Value = sucursallabel.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@categoria", SqlDbType.VarChar, 40)
            Parametro2.Value = categoria
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVProducttoshop.DataSource = dt
            Else
                MessageBox.Show("Productos no disponibles")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub buscarIDsucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = sselected
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                sucursallabel.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        Dim unindiceagain As Integer
        Dim dosindice As Integer
        dosindice = CBcategory.SelectedIndex
        If dosindice <> -1 Then
            categoria = CBcategory.Text
        End If
        unindiceagain = CBsuscursalshopin.SelectedIndex
        If unindiceagain <> -1 Then
            acomprar()
        End If
    End Sub

    Private Sub CBsuscursalshopin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBsuscursalshopin.SelectedIndexChanged
        Dim unindice As Integer
        unindice = CBsuscursalshopin.SelectedIndex
        If unindice <> -1 Then
            sselected = CBsuscursalshopin.Text
            buscarIDsucursal()
        End If
    End Sub

    Private Sub DGVProducttoshop_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducttoshop.CellContentClick
        Dim Selecionfila As Integer
        Selecionfila = DGVProducttoshop.CurrentRow.Index

        If Selecionfila <> -1 Then
            tomarstock = DGVProducttoshop.Item("stockProdSuc", DGVProducttoshop.CurrentRow.Index).Value
            LStock.Text = tomarstock
            Bagregando.Enabled = True
            TCantidad.Enabled = True
            Bquitale.Enabled = True
            Bagregaacarrito.Enabled = True
            TCantidad.Text = 1
        Else
            limpio()
        End If
    End Sub
    Sub limpio()
        TCantidad.Text = ""
        Bagregando.Enabled = False
        TCantidad.Enabled = False
        Bquitale.Enabled = False
        Bagregaacarrito.Enabled = False
    End Sub
    Private Sub Bagregando_Click(sender As Object, e As EventArgs) Handles Bagregando.Click
        Dim deltextbox As String
        deltextbox = TCantidad.Text
        Dim CantidadActual As Integer
        CantidadActual = Integer.Parse(deltextbox)
        Dim stockmax As Integer
        stockmax = Integer.Parse(LStock.Text)
        If CantidadActual + 1 <= stockmax Then
            CantidadActual = CantidadActual + 1
            TCantidad.Text = CantidadActual.ToString
        End If

    End Sub

    Private Sub Bquitale_Click(sender As Object, e As EventArgs) Handles Bquitale.Click
        Dim deltxtbox As String
        deltxtbox = TCantidad.Text
        Dim CantidadActual As Integer
        CantidadActual = Integer.Parse(deltxtbox)
        If CantidadActual - 1 > 0 Then
            CantidadActual = CantidadActual - 1
            TCantidad.Text = CantidadActual.ToString
        End If
    End Sub
    Public Sub DatadelistaCarritoTable()
        DTListaCarrito = New DataTable

        DTListaCarrito.Columns.Add("IDProduct", Type.GetType("System.String"))
        DTListaCarrito.Columns.Add("Nombre", Type.GetType("System.String"))

        DTListaCarrito.Columns.Add("Precio", Type.GetType("System.String"))
        DTListaCarrito.Columns.Add("Descuento", Type.GetType("System.String"))
        DTListaCarrito.Columns.Add("CantidadAComprar", Type.GetType("System.String"))
        DTListaCarrito.Columns.Add("StockDisponible", Type.GetType("System.String"))
        DTListaCarrito.Columns.Add("NumSucursal", Type.GetType("System.String"))
        'And Then add row Like
        'DataGridView1.DataSource = DTListaCarrito
        'DataGridView1.DataBind()
    End Sub

    Private Sub Bagregaacarrito_Click(sender As Object, e As EventArgs) Handles Bagregaacarrito.Click
        Dim Selecionfila As Integer
        Selecionfila = DGVProducttoshop.CurrentRow.Index
        If Selecionfila <> -1 Then
            If DTListaCarrito Is Nothing Then
                DatadelistaCarritoTable()
                agregaracarrito()

            Else
                'COMPROBAR QUE UN MISMO PRODUCTO NO SE INSERTE DOS O MAS VECES
                Dim versiesigual As Boolean
                versiesigual = validarquenorepita()
                If versiesigual = True Then
                    MessageBox.Show("No puedes agregar el mismo producto dos veces, modifica la cantidad del producto que quieres en el menú: MI CARRITO")
                Else
                    agregaracarrito()
                End If

            End If
        End If
    End Sub

    Sub agregaracarrito()

        Dim dr As DataRow = DTListaCarrito.NewRow
        dr("IDProduct") = DGVProducttoshop.Item("id_codProducto", DGVProducttoshop.CurrentRow.Index).Value
        dr("Nombre") = DGVProducttoshop.Item("nombreProd", DGVProducttoshop.CurrentRow.Index).Value

        dr("Precio") = DGVProducttoshop.Item("priceProd", DGVProducttoshop.CurrentRow.Index).Value
        dr("Descuento") = DGVProducttoshop.Item("descuentoProd", DGVProducttoshop.CurrentRow.Index).Value
        dr("CantidadAComprar") = TCantidad.Text
        dr("StockDisponible") = DGVProducttoshop.Item("stockProdSuc", DGVProducttoshop.CurrentRow.Index).Value
        dr("NumSucursal") = sucursallabel.Text

        DTListaCarrito.Rows.Add(dr)
        DGVProducttoshop.ClearSelection()
        MessageBox.Show("Producto Agregado Al carrito")
        limpio()
    End Sub
    Private Function validarquenorepita() As Boolean
        For Each row As DataRow In DTListaCarrito.Rows
            If row.Item("IDProduct") = DGVProducttoshop.Item("id_codProducto", DGVProducttoshop.CurrentRow.Index).Value Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub BCarro_Click(sender As Object, e As EventArgs) Handles BCarro.Click
        'DTListaCarrito2 = SHOPIN.DTListaCarrito.Copy()
        lecar.DTListaCarrito2 = DTListaCarrito.Copy()
        lecar.Show()
        Me.Hide()
    End Sub
End Class