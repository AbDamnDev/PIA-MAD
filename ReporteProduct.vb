Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Public Class ReporteProduct

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public sucur As String
    Public sucursalDEHOY As String
    Public codigos As String
    Public nombres As String
    Public descrip As String
    Public precios As String
    Public decuento As String
    Public categoria As String
    Public stock As String
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

    Private Sub ReporteProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Idcve.Text = Form1.CveEmpleado
        LNAMENAME.Text = Form1.NombreCompleto
        nombreSucursal()
    End Sub

    Private Sub Bvolver_Click(sender As Object, e As EventArgs) Handles Bvolver.Click
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

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        Dim unosindice As Integer
        unosindice = Csucursal.SelectedIndex
        If unosindice <> -1 Then
            BuscarProductos()
            Bgenerar.Enabled = True
        Else
            MessageBox.Show("No entro")
        End If
    End Sub
    Sub nombreSucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            sucur = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = sucur
            dt = New DataTable
            da = New SqlDataAdapter(sucur, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            Csucursal.DataSource = dt
            Csucursal.DisplayMember = "nombreSuc"
            Csucursal.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub BuscarProductos()
        Try
            conectar()
            cmd = New SqlCommand("traerProductosReporte", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idSuc", SqlDbType.Int)
            Parametro1.Value = LSucurID.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVpinv.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Csucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Csucursal.SelectedIndexChanged
        Dim unindice As Integer
        unindice = Csucursal.SelectedIndex
        If unindice <> -1 Then
            sucursalDEHOY = Csucursal.Text
            buscarIDsucursal()
            BSearch.Enabled = True
        End If
    End Sub
    Sub buscarIDsucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerIDSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar, 40)
            Parametro1.Value = sucursalDEHOY
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                LSucurID.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bgenerar_Click(sender As Object, e As EventArgs) Handles Bgenerar.Click
        reportePDF()
    End Sub
    Sub reportePDF()
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Inventario.pdf", FileMode.Create))
            Dim encabezado As New Paragraph("Inventario", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            Dim FontA As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 14, iTextSharp.text.Font.NORMAL))
            Dim FontB As New Font(FontFactory.GetFont(FontFactory.COURIER, 14, iTextSharp.text.Font.NORMAL))
            Dim FonC As New Font(FontFactory.GetFont(FontFactory.COURIER_BOLD, 10, iTextSharp.text.Font.NORMAL))
            Dim FontD As New Font(FontFactory.GetFont(FontFactory.COURIER, 10, iTextSharp.text.Font.NORMAL))
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
            Dim Col7 As PdfPCell


            Table1.WidthPercentage = 95
            Dim withs As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
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
            Col2 = New PdfPCell(New Phrase("Inventario", FontA))

            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("Reporte Generado por:", FontA))
            Col3.Border = 0
            Table1.AddCell(Col3)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Sucursal: " + Csucursal.Text, FontB))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase(Idcve.Text + " " + LNAMENAME.Text, FontB))
            Col3.Border = 0
            Table1.AddCell(Col3)

            pdfDoc.Add(Table1)
#End Region
#Region "Inventario"
            Dim Table3 As PdfPTable = New PdfPTable(7)
            Dim withs3 As Single() = New Single() {2.114F, 2.114F, 2.316F, 2.114F, 2.114F, 2.114F, 2.114F}
            Table3.WidthPercentage = 95
            Table3.SetWidths(withs3)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)

            Col1 = New PdfPCell(New Phrase("ID", FonC))
            Col1.Border = 0
            Table3.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("Producto", FonC))
            Col2.Border = 0
            Table3.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("Descripcion", FonC))
            Col3.Border = 0
            Table3.AddCell(Col3)
            Col4 = New PdfPCell(New Phrase("Precio", FonC))
            Col4.Border = 0
            Table3.AddCell(Col4)
            Col5 = New PdfPCell(New Phrase("Descuento", FonC))
            Col5.Border = 0
            Table3.AddCell(Col5)
            Col6 = New PdfPCell(New Phrase("Categoria", FonC))
            Col6.Border = 0
            Table3.AddCell(Col6)
            Col7 = New PdfPCell(New Phrase("Stock", FonC))
            Col7.Border = 0
            Table3.AddCell(Col7)
            For Each row As DataGridViewRow In DGVpinv.Rows
                codigos = row.Cells("id_codProducto").Value
                nombres = row.Cells("nombreProd").Value
                descrip = row.Cells("descProd").Value
                precios = row.Cells("priceProd").Value
                decuento = row.Cells("descuentoProd").Value
                categoria = row.Cells("nombreCategoria").Value
                stock = row.Cells("stockProdSuc").Value
                Col1 = New PdfPCell(New Phrase(codigos, FontD))
                Col1.Border = 0
                Table3.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(nombres, FontD))
                Col2.Border = 0
                Table3.AddCell(Col2)
                Col3 = New PdfPCell(New Phrase(descrip, FontD))
                Col3.Border = 0
                Table3.AddCell(Col3)
                Col4 = New PdfPCell(New Phrase(precios, FontD))
                Col4.Border = 0
                Table3.AddCell(Col4)
                Col5 = New PdfPCell(New Phrase(decuento, FontD))
                Col5.Border = 0
                Table3.AddCell(Col5)
                Col6 = New PdfPCell(New Phrase(categoria, FontD))
                Col6.Border = 0
                Table3.AddCell(Col6)
                Col7 = New PdfPCell(New Phrase(stock, FontD))
                Col7.Border = 0
                Table3.AddCell(Col7)
            Next
            pdfDoc.Add(Table3)
#End Region

            pdfDoc.Close()
            MessageBox.Show("Se generó el Reporte del Inventario")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Class