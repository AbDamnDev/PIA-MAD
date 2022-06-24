Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports ZXing

Public Class Reportedecompra
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim numa As New Numalet
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public numerocarrito As String
    Public numsucur As String
    Public totalpa As String
    Private indexsucursal As Integer
    Private indexcliente As Integer
    Private indexcarrito As Integer
    Private indexcompracarrito As Integer
    Public paranuma As String
    Public alto As Single

    'data grid con la lista de productos del carrito, otro con la info del carrito, 
    'otro con la info del cliente y usuario, otro con sucursal y domicilio sucursal
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
    Sub traigoSucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerDatosSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idsucursal", SqlDbType.Int)
            Parametro1.Value = Idsucursal.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVSucursal.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub traerCliente()
        Try
            conectar()
            cmd = New SqlCommand("traerDatosCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idCLIENTE", SqlDbType.Int)
            Parametro1.Value = IDcliente.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVClienteinfo.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub traerCarrito()
        Try
            conectar()
            cmd = New SqlCommand("traerListaCarrito", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
            Parametro1.Value = IDdecarrito.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVInfoCarrito.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub traesProductodeCarrito()
        Try
            conectar()
            cmd = New SqlCommand("traerCarritoComprado", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idNUMCarrito", SqlDbType.Int)
            Parametro1.Value = IDdecarrito.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idClienteCarrito", SqlDbType.Int)
            Parametro2.Value = IDcliente.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVProductCarrito.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Reportedecompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDdecarrito.Text = numerocarrito
        UsuarioNom.Text = Form1.NombreCompleto
        Idsucursal.Text = numsucur
        IDcliente.Text = Form1.CveCliente
        Lprecio.Text = totalpa
        Ldesdevent.Text = Carrito.patotalcondesc
        indexcliente = 0
        indexsucursal = 0
        indexcarrito = 0
        indexcompracarrito = 0
        traigoSucursal()
        traerCliente()
        traerCarrito()
        traesProductodeCarrito()
        Dim unvalor As Single
        Dim stringuno As String
        Dim stringdos As String
        Dim stringtres As String

        Dim GENERADOR As BarcodeWriter = New BarcodeWriter
        stringuno = DGVSucursal.Rows(0).Cells("idSuc").Value.ToString
        stringdos = DGVClienteinfo.Rows(0).Cells("idCliente").Value.ToString
        stringtres = DGVInfoCarrito.Rows(0).Cells("idNUMCarrito").Value.ToString
        unvalor = Single.Parse(stringuno)
        Dim dosvalor As Single
        dosvalor = Single.Parse(stringdos)
        Dim tresvalor As Single
        tresvalor = Single.Parse(stringtres)
        alto = Convert.ToSingle(15)
        Dim bm As Bitmap = Nothing
        bm = Codigos.codigo128("A" & unvalor & "B", dosvalor, alto)
        'If Not IsNothing(bm) Then
        '    PictureBox1.Image = bm
        'End If
        GENERADOR.Format = BarcodeFormat.CODE_128
        Dim IMAGEN As Bitmap = New Bitmap(GENERADOR.Write(stringtres), PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = IMAGEN
        If DGVProductCarrito.Rows(0).Cells("tarjeta").ToString <> Nothing Then
            Traertarjeta()
        Else
            DGVtarjeta.Hide()
        End If
    End Sub
    Sub Traertarjeta()
        Try
            conectar()
            cmd = New SqlCommand("traerUnaTarjeta", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idtarjeta", SqlDbType.Int)
            Parametro1.Value = DGVProductCarrito.Rows(0).Cells("tarjeta").Value
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVtarjeta.DataSource = dt
            Else
                MessageBox.Show("No tienes tarjetas")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub pdfEnBlanco()
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Recibo.pdf", FileMode.Create))
            Dim encabezado As New Paragraph("RECIBO", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            Dim FontA As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 14, iTextSharp.text.Font.NORMAL))
            Dim FontB As New Font(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.NORMAL))
            Dim FonC As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 12, iTextSharp.text.Font.NORMAL))
            Dim FontD As New Font(FontFactory.GetFont(FontFactory.COURIER, 12, iTextSharp.text.Font.NORMAL))
            Dim CVacio As PdfPCell = New PdfPCell(New Phrase(""))
            CVacio.Border = 0
            Dim ruta As String = "D:\Documents\LMAD\6\Modelos de administracion de datos\-Material de Clases\PIA\bin\Debug\net5.0-windows\"
            pdfDoc.Open()
            Dim Table1 As PdfPTable = New PdfPTable(4)
            Dim Col1 As PdfPCell
            Dim Col2 As PdfPCell
            Dim Col3 As PdfPCell
            Dim Col4 As PdfPCell
            Dim Col5 As PdfPCell
            Dim Col6 As PdfPCell
            Table1.WidthPercentage = 95
            Dim withs As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}

#Region "Encabezado"
            Dim ImagenURL As String = ruta + "Diseño1.bmp"
            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(ImagenURL)
            imagenBMP.ScaleToFit(110.0F, 140.0F)
            imagenBMP.SpacingBefore = 20.0F
            imagenBMP.SpacingAfter = 10.0F
            imagenBMP.SetAbsolutePosition(40, 780)
            pdfDoc.Add(imagenBMP)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Recibo", FontA))

            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("Numero de Pedido:", FontA))
            Col3.Border = 0
            Table1.AddCell(Col3)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Cliente: " + DGVClienteinfo.Rows(0).Cells("nombreCompleto").Value.ToString, FontB))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase(DGVInfoCarrito.Rows(0).Cells("idNUMCarrito").Value.ToString, FontB))
            Col3.Border = 0
            Table1.AddCell(Col3)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Domicilio: " + DGVClienteinfo.Rows(0).Cells("DireccionCompleta").Value.ToString, FontB))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("Fecha de Compra: " + DGVProductCarrito.Rows(0).Cells("fechaCompra").Value.ToString, FontB))
            Col3.Border = 0
            Table1.AddCell(Col3)

            pdfDoc.Add(Table1)

#End Region
            pdfDoc.Add(New Paragraph(" "))
#Region "MidSection"
            Dim Table2 As PdfPTable = New PdfPTable(4)
            Dim withs2 As Single() = New Single() {2.0F, 3.0F, 8.0F, 2.0F}
            Table2.WidthPercentage = 95
            Table2.SetWidths(withs2)
            Table2.AddCell(CVacio)
            Table2.AddCell(CVacio)
            Table2.AddCell(CVacio)
            Table2.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Sucursal:", FonC))
            Col2.Border = 0
            Table2.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase(DGVSucursal.Rows(0).Cells("nombreSuc").Value.ToString, FonC))
            Col3.Border = 0
            Table2.AddCell(Col3)
            Col4 = New PdfPCell(New Phrase(DGVSucursal.Rows(0).Cells("calle").Value.ToString + ", " + DGVSucursal.Rows(0).Cells("numero").Value.ToString + ", " + DGVSucursal.Rows(0).Cells("colonia").Value.ToString + ", " + DGVSucursal.Rows(0).Cells("municipio").Value.ToString + ", " + DGVSucursal.Rows(0).Cells("estado").Value.ToString + ", " + DGVSucursal.Rows(0).Cells("codigoPostal").Value.ToString, FonC))
            Col4.Border = 0
            Table2.AddCell(Col4)
            Table2.AddCell(CVacio)
            pdfDoc.Add(Table2)
#End Region
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
#Region "TipodePago"
            Dim stringparatarjeta As String
            stringparatarjeta = DGVProductCarrito.Rows(0).Cells("tarjeta").Value.ToString
            If stringparatarjeta <> Nothing Then
                Dim numtar As String
                numtar = DGVtarjeta.Rows(0).Cells("numTarjeta").Value
                Dim result As String
                result = numtar.Substring(numtar.Length - 4)
                Dim aterisco As String
                aterisco = "************"
                Dim nuevonum As String
                nuevonum = aterisco + result
                pdfDoc.Add(New Paragraph("Pagado ", FonC))
                pdfDoc.Add(New Phrase("Con tarjeta terminada en: " + nuevonum, FonC))
            Else
                pdfDoc.Add(New Paragraph("Por Pagar", FonC))
            End If
            If DGVProductCarrito.Rows(0).Cells("tipEnvio").Value = True Then
                pdfDoc.Add(New Paragraph("Envio a Domicilio", FonC))
            Else
                pdfDoc.Add(New Paragraph("Recoger en Tienda", FonC))
            End If
#End Region

            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Recibo: "))
            pdfDoc.Add(New Paragraph(" "))
#Region "Precios"
            Dim Table3 As PdfPTable = New PdfPTable(4)
            Dim withs3 As Single() = New Single() {3.75F, 3.75F, 3.75F, 3.75F}
            Table3.WidthPercentage = 95
            Table3.SetWidths(withs3)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Col1 = New PdfPCell(New Phrase("Producto", FonC))
            Col1.Border = 0
            Table3.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("Cantidad", FonC))
            Col2.Border = 0
            Table3.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("Precio Individual", FonC))
            Col3.Border = 0
            Table3.AddCell(Col3)
            Col4 = New PdfPCell(New Phrase("Descuento Individual", FonC))
            Col4.Border = 0
            Table3.AddCell(Col4)
            For Each row As DataGridViewRow In DGVInfoCarrito.Rows
                Col1 = New PdfPCell(New Phrase(row.Cells("nombreProd").Value.ToString, FontD))
                Col1.Border = 0
                Table3.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(row.Cells("cantProdList").Value.ToString, FontD))
                Col2.Border = 0
                Table3.AddCell(Col2)
                Col3 = New PdfPCell(New Phrase(row.Cells("priceProd").Value.ToString, FontD))
                Col3.Border = 0
                Table3.AddCell(Col3)
                Col4 = New PdfPCell(New Phrase(row.Cells("descuentoProd").Value.ToString, FontD))
                Col4.Border = 0
                Table3.AddCell(Col4)
            Next
            pdfDoc.Add(Table3)
#End Region
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Precio Total:  $" + Lprecio.Text, FonC))
            numa = New Numalet
            numa.MascaraSalidaDecimal = "00/100 M.N."
            numa.SeparadorDecimalSalida = "pesos"
            numa.ApocoparUnoParteEntera = True
            paranuma = numa.ToCustomCardinal(totalpa)
            pdfDoc.Add(New Paragraph(paranuma, FonC))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Telefono: 8119646719", FontD))
#Region "cod"
            pdfDoc.Add(New Paragraph(" "))
            Dim urlimagen As String = ruta + "Code.bmp"
            Dim bmpImagen As iTextSharp.text.Image
            bmpImagen = iTextSharp.text.Image.GetInstance(urlimagen)
            bmpImagen.ScaleToFit(110.0F, 140.0F)
            bmpImagen.SpacingBefore = 20.0F
            bmpImagen.SpacingAfter = 10.0F
            'bmpImagen.SetAbsolutePosition(40, 780)
            pdfDoc.Add(bmpImagen)
            pdfDoc.Add(New Paragraph(" "))
#End Region

            pdfDoc.Close()
            MessageBox.Show("Se generó el recibo")
            '" Fecha de Compra: " + DGVProductCarrito.Rows(0).Cells("fechaCompra").Value.ToString
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub BGoBack_Click(sender As Object, e As EventArgs) Handles BGoBack.Click
        Dim nuevomenu As New MenuCliente
        nuevomenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        guardarelcodigo()
        pdfEnBlanco()
    End Sub
    Sub guardarelcodigo()
        Dim imagen As Bitmap
        Dim guardar As SaveFileDialog = New SaveFileDialog()
        guardar.Filter = "Bitmap|*.bmp|jpeg|*.jpg|GIF|*.gif|PNG|*.png"
        If guardar.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            imagen = PictureBox1.Image
            imagen.Save(guardar.FileName)
        End If
    End Sub
End Class