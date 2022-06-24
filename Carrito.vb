Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Public Class Carrito
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public DTListaCarrito2 = New DataTable
    Public Tomaproducto As String
    Private tomarstock As String
    Public iindex As Integer
    Public iindexdos As Integer
    Public padescuentos As Single
    Public patotal As Single
    Public patotalcondesc As Single
    Public cantidad As Integer
    Public Tomatudinero As String
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
    Private Sub Carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DTListaCarrito2 = SHOPIN.DTListaCarrito.Copy()
        DGVMISHOOPIN.DataSource = DTListaCarrito2
        Cliente.Text = Form1.NombreCompleto
        LSUCURSAL.Text = DTListaCarrito2.Rows(0).Item(6)

        lasumatoriageneral()
    End Sub

    Private Sub Bmevoy_Click(sender As Object, e As EventArgs) Handles Bmevoy.Click
        Dim ShopShop As New SHOPIN
        ShopShop.Show()
        Me.Hide()
    End Sub

    Private Sub DGVMISHOOPIN_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMISHOOPIN.CellContentClick
        Dim Selecionfilas As Integer
        Selecionfilas = DGVMISHOOPIN.CurrentRow.Index
        If Selecionfilas <> -1 Then
            Tomaproducto = DGVMISHOOPIN.Item("CantidadAComprar", DGVMISHOOPIN.CurrentRow.Index).Value
            tomarstock = DGVMISHOOPIN.Item("StockDisponible", DGVMISHOOPIN.CurrentRow.Index).Value
            LPSTOCK.Text = tomarstock
            BMENOS.Enabled = True
            BMAS.Enabled = True
            Tcanti.Enabled = True
            Bmodificar.Enabled = True
            Bquitar.Enabled = True
            Tcanti.Text = Tomaproducto
        Else
            limpieza()
        End If
    End Sub

    Private Sub BMENOS_Click(sender As Object, e As EventArgs) Handles BMENOS.Click
        Dim deltxtbox As String
        deltxtbox = Tcanti.Text
        Dim CantidadActual As Integer
        CantidadActual = Integer.Parse(deltxtbox)
        If CantidadActual - 1 > 0 Then
            CantidadActual = CantidadActual - 1
            Tcanti.Text = CantidadActual.ToString
        End If
    End Sub

    Private Sub BMAS_Click(sender As Object, e As EventArgs) Handles BMAS.Click
        Dim deltextbox As String
        deltextbox = Tcanti.Text
        Dim CantidadActual As Integer
        CantidadActual = Integer.Parse(deltextbox)
        Dim stockmax As Integer
        stockmax = Integer.Parse(LPSTOCK.Text)
        If CantidadActual + 1 <= stockmax Then
            CantidadActual = CantidadActual + 1
            Tcanti.Text = CantidadActual.ToString
        End If
    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click
        'DTListaCarrito2
        'DGVMISHOOPIN.Item("CantidadAComprar", DGVMISHOOPIN.CurrentRow.Index).Value = Tcanti.Text
        For Each row As DataRow In DTListaCarrito2.Rows
            If row.Item("IDProduct") = DGVMISHOOPIN.Item("IDProduct", DGVMISHOOPIN.CurrentRow.Index).Value Then
                row.Item("CantidadAComprar") = Tcanti.Text
            End If
        Next
        DGVMISHOOPIN.DataSource = DTListaCarrito2
        DGVMISHOOPIN.ClearSelection()
        limpieza()
        lasumatoriageneral()
    End Sub
    Sub limpieza()
        Tcanti.Text = ""
        BMENOS.Enabled = False
        BMAS.Enabled = False
        Tcanti.Enabled = False
        Bmodificar.Enabled = False
        Bquitar.Enabled = False
    End Sub

    Private Sub Bquitar_Click(sender As Object, e As EventArgs) Handles Bquitar.Click
        iindexdos = byebye()
        If iindexdos <> -1 Then
            DTListaCarrito2.Rows(iindexdos).Delete()
            DGVMISHOOPIN.DataSource = DTListaCarrito2
            DGVMISHOOPIN.ClearSelection()
            limpieza()
            lasumatoriageneral()
        End If
    End Sub
    Private Function byebye() As Integer
        For Each row As DataRow In DTListaCarrito2.Rows
            If row.Item("IDProduct") = DGVMISHOOPIN.Item("IDProduct", DGVMISHOOPIN.CurrentRow.Index).Value Then
                row.Item("CantidadAComprar") = Tcanti.Text
                iindex = DTListaCarrito2.Rows.IndexOf(row)
                Return iindex
                'int index = dt.Rows.IndexOf(row);
            End If
        Next
        Return -1
    End Function
    Sub traertarjetas()
        Try
            conectar()
            cmd = New SqlCommand("traerTarjetas", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@cliente", SqlDbType.Int)
            Parametro1.Value = Form1.CveCliente

            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVtarjetass.DataSource = dt
            Else
                MessageBox.Show("No tienes tarjetas")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub CBtarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles CBtarjeta.CheckedChanged
        metododetarjeta()
    End Sub

    Private Sub Bcomprar_Click(sender As Object, e As EventArgs) Handles Bcomprar.Click
        crearcarrito()
        If LNumCarrito.Text <> Nothing Then
            LlenarLista()
            PDFCarrito()
            finalizarcarrito()
            Limpiartodo()
            abrirReporte()
        End If
    End Sub
    Sub abrirReporte()
        Dim reportescompras As New Reportedecompra
        reportescompras.numerocarrito = LNumCarrito.Text
        reportescompras.totalpa = patotalcondesc
        reportescompras.numsucur = LSUCURSAL.Text
        reportescompras.Show()
        Me.Close()

    End Sub
    Sub finalizarcarrito()
        Try
            conectar()
            cmd = New SqlCommand("insertarFinCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
            Parametro1.Value = LNumCarrito.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idClienteCarrito", SqlDbType.Int)
            Parametro2.Value = Form1.CveCliente
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@totalCarrito", SqlDbType.Float)
            Parametro3.Value = totalfinal.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@pagado", SqlDbType.Bit)
            If CBefectivo.Checked = True Then
                Parametro4.Value = 0
            End If
            If CBtarjeta.Checked = True Then
                Parametro4.Value = 1
            End If
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@metPag", SqlDbType.Bit)
            If CBtarjeta.Checked = True Then
                Parametro5.Value = 1

            End If
            If CBefectivo.Checked = True Then
                Parametro5.Value = 0
            End If
            '
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@tarjeta", SqlDbType.Int)
            If Parametro5.Value = 1 Then
                Parametro6.Value = LtarjetaS.Text
            Else
                Parametro6.Value = DBNull.Value
            End If

            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@tipEnvio", SqlDbType.Bit)
            If CBtucasa.Checked = True Then
                Parametro7.Value = 1
            End If
            If CBentienda.Checked = True Then
                Parametro7.Value = 0
            End If
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
            MessageBox.Show("Compra Realizada con exito")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub Limpiartodo()
        Try
            'LNumCarrito <-Label del id del carrito
            DTListaCarrito2 = Nothing
            DGVMISHOOPIN.DataSource = DTListaCarrito2
            CBefectivo.Checked = False
            CBtarjeta.Checked = False
            CBentienda.Checked = False
            CBtucasa.Checked = False
            totalfinal.Text = ""
            LApagar.Text = ""
            Labeldisc.Text = ""
            LtarjetaS.Text = ""
            DGVtarjetass.DataSource = Nothing
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub LlenarLista()
        Try
            For Each row As DataGridViewRow In DGVMISHOOPIN.Rows
                If row.IsNewRow = True Then
                    DGVMISHOOPIN.Rows.Remove(row)
                Else
                    conectar()
                    cmd = New SqlCommand("insertarProdList", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
                    Parametro1.Value = LNumCarrito.Text
                    Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@PROD", SqlDbType.Int)
                    Parametro2.Value = row.Cells("IDProduct").Value.ToString
                    Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@idSucursal", SqlDbType.Int)
                    Parametro3.Value = row.Cells("NumSucursal").Value.ToString
                    Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@cantProd", SqlDbType.Int)
                    Parametro4.Value = row.Cells("CantidadAComprar").Value.ToString

                    da.InsertCommand = cmd
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()
                    desconectar()
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub crearcarrito()
        Try
            conectar()
            cmd = New SqlCommand("crearCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idCliente", SqlDbType.Int)
            Parametro1.Value = Form1.CveCliente
            cmd.Parameters.Add("@carritoID", SqlDbType.Int)
            cmd.Parameters("@carritoID").Direction = ParameterDirection.Output
            'cmd.Parameters.Add("@DateCreated", SqlDbType.DateTime, 20);
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            LNumCarrito.Text = cmd.Parameters("@carritoID").Value.ToString
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub CBefectivo_CheckedChanged(sender As Object, e As EventArgs) Handles CBefectivo.CheckedChanged
        metododetarjeta()
    End Sub
    Sub metododetarjeta()
        If CBtarjeta.Checked = True Then
            CBefectivo.Checked = False
            traertarjetas()
        Else
            If CBefectivo.Checked = True Then
                CBtarjeta.Checked = False
                DGVtarjetass.DataSource = Nothing
            End If
        End If
    End Sub
    Sub metodoenvio()
        If CBentienda.Checked = True Then
            CBtucasa.Checked = False
        Else
            If CBtucasa.Checked = True Then
                CBentienda.Checked = False
            End If
        End If
    End Sub

    Private Sub CBtucasa_CheckedChanged(sender As Object, e As EventArgs) Handles CBtucasa.CheckedChanged
        metodoenvio()
    End Sub

    Private Sub CBentienda_CheckedChanged(sender As Object, e As EventArgs) Handles CBentienda.CheckedChanged
        metodoenvio()
    End Sub
    Sub lasumatoriageneral()
        'Dim sum As Integer = Convert.ToInt32(dt.Compute("SUM(Salary)", String.Empty))
        Dim Quantity As Integer
        Dim pricetag As Single
        Dim dicount As Single
        For Each row As DataRow In DTListaCarrito2.Rows
            Quantity = Integer.Parse(row.Item("CantidadAComprar"))
            pricetag = Single.Parse(row.Item("Precio"))
            dicount = Single.Parse(row.Item("Descuento"))
            patotal = patotal + (Quantity * pricetag)
            padescuentos = padescuentos + (Quantity * dicount)
        Next
        Labeldisc.Text = padescuentos
        LApagar.Text = patotal
        patotalcondesc = patotal - padescuentos
        totalfinal.Text = patotalcondesc
    End Sub

    Private Sub DGVtarjetass_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVtarjetass.CellContentClick
        Try
            Dim SelecionfilaSs As Integer
            SelecionfilaSs = DGVtarjetass.CurrentRow.Index
            If SelecionfilaSs <> -1 Then
                Tomatudinero = DGVtarjetass.Item("idMetPag", DGVtarjetass.CurrentRow.Index).Value
                LtarjetaS.Text = Tomatudinero
                MessageBox.Show("Tarjeta Seleccionada")
            End If

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub PDFCarrito()
        'DGVMISHOOPIN
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Carrito.pdf", FileMode.Create))
            Dim encabezado As New Paragraph("CARRITO", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            Dim FontA As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 14, iTextSharp.text.Font.NORMAL))
            Dim FontB As New Font(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.NORMAL))
            Dim FonC As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 12, iTextSharp.text.Font.NORMAL))
            Dim FontD As New Font(FontFactory.GetFont(FontFactory.COURIER, 12, iTextSharp.text.Font.NORMAL))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0
            Dim ruta As String = "D:\Documents\LMAD\6\Modelos de administracion de datos\-Material de Clases\PIA\bin\Debug\net5.0-windows\"
            pdfDoc.Open()
            Dim Table1 As PdfPTable = New PdfPTable(3)
            Dim Col1 As PdfPCell
            Dim Col2 As PdfPCell
            Dim Col3 As PdfPCell
            Dim Col4 As PdfPCell
            Dim Col5 As PdfPCell
            Dim Col6 As PdfPCell

            Table1.WidthPercentage = 95
            Dim withs As Single() = New Single() {5.0F, 5.0F, 5.0F}
#Region "Encabezado"
            Dim ImagenURL As String = ruta + "Diseño2.bmp"
            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(ImagenURL)
            imagenBMP.ScaleToFit(110.0F, 140.0F)
            imagenBMP.SpacingBefore = 20.0F
            imagenBMP.SpacingAfter = 10.0F
            imagenBMP.SetAbsolutePosition(40, 780)
            pdfDoc.Add(imagenBMP)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Carrito", FontA))

            Col2.Border = 0
            Table1.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("ID de Sucursal: " + LSUCURSAL.Text, FontB))

            Col3.Border = 0
            Table1.AddCell(Col3)
            Table1.AddCell(CVacio)

            pdfDoc.Add(Table1)
#End Region
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
#Region "ProductosdeCarrito"
            Dim Table3 As PdfPTable = New PdfPTable(5)
            Dim withs3 As Single() = New Single() {3.0F, 3.0F, 3.0F, 3.0F, 3.0F}
            Table3.WidthPercentage = 95
            Table3.SetWidths(withs3)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)

            Col1 = New PdfPCell(New Phrase("ID de Producto", FonC))
            Col1.Border = 0
            Table3.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("Nombre", FonC))
            Col2.Border = 0
            Table3.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("Precio", FonC))
            Col3.Border = 0
            Table3.AddCell(Col3)
            Col4 = New PdfPCell(New Phrase("Descuento", FonC))
            Col4.Border = 0
            Table3.AddCell(Col4)
            Col5 = New PdfPCell(New Phrase("Cantidad a Comprar", FonC))
            Col5.Border = 0
            Table3.AddCell(Col5)

            For Each row As DataGridViewRow In DGVMISHOOPIN.Rows
                Col1 = New PdfPCell(New Phrase(row.Cells("IDProduct").Value.ToString, FontD))
                Col1.Border = 0
                Table3.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(row.Cells("Nombre").Value.ToString, FontD))
                Col2.Border = 0
                Table3.AddCell(Col2)
                Col3 = New PdfPCell(New Phrase(row.Cells("Precio").Value.ToString, FontD))
                Col3.Border = 0
                Table3.AddCell(Col3)
                Col4 = New PdfPCell(New Phrase(row.Cells("Descuento").Value.ToString, FontD))
                Col4.Border = 0
                Table3.AddCell(Col4)
                Col5 = New PdfPCell(New Phrase(row.Cells("CantidadAComprar").Value.ToString, FontD))
                Col5.Border = 0
                Table3.AddCell(Col5)
            Next
            pdfDoc.Add(Table3)
#End Region
            pdfDoc.Close()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Class