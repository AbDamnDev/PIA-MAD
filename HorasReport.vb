Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Public Class HorasReport
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
    Private Sub HorasReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tuidid.Text = Form1.CveEmpleado
        hamanahamana.Text = Form1.NombreCompleto

    End Sub
    Sub Tengohorario()
        Try
            conectar()
            cmd = New SqlCommand("TraerUltimosHorarios", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = ID2.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            DGVHORARIO.DataSource = dt
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub EmpleadoID()
        Try
            conectar()
            cmd = New SqlCommand("getEmpIDbyName", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@NomEmp", SqlDbType.VarChar, 120)
            Parametro1.Value = TFullname.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            ID2.Text = dt.Rows(0).Item(0)
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Mevoy_Click(sender As Object, e As EventArgs) Handles Mevoy.Click
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

    Private Sub Bfull_Click(sender As Object, e As EventArgs) Handles Bfull.Click
        EmpleadoID()
        Horario.Enabled = True
    End Sub

    Private Sub Horario_Click(sender As Object, e As EventArgs) Handles Horario.Click
        Tengohorario()
        Bsumsum.Enabled = True
    End Sub

    Sub sumatoria()
        Try
            conectar()
            cmd = New SqlCommand("reporteDeHorasTrabajadas", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim horitas As Integer
            Dim horatotal As Integer
            horatotal = 0
            horitas = 0
            For Each row As DataGridViewRow In DGVHORARIO.Rows
                horitas = Integer.Parse(row.Cells("horTrab").Value)
                horatotal = horatotal + horitas
            Next
            Label2.Visible = True
            Lhours.Text = horatotal
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bsumsum_Click(sender As Object, e As EventArgs) Handles Bsumsum.Click
        sumatoria()
        OKIDOKY.Enabled = True
    End Sub

    Private Sub OKIDOKY_Click(sender As Object, e As EventArgs) Handles OKIDOKY.Click
        reportehoras()
    End Sub
    Sub reportehoras()
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream("Reportedehoras.pdf", FileMode.Create))
            Dim encabezado As New Paragraph("Horario", New Font(Font.Name = "Tahoma", 20, Font.Bold))
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
            Col2 = New PdfPCell(New Phrase("Reporte de Horario", FontA))

            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase("Empleado:", FontA))
            Col3.Border = 0
            Table1.AddCell(Col3)

            Table1.AddCell(CVacio)
            Col2 = New PdfPCell(New Phrase("Generado por: " + tuidid.Text + " " + hamanahamana.Text, FontB))
            Col2.Border = 0
            Table1.AddCell(Col2)
            Table1.AddCell(CVacio)
            Col3 = New PdfPCell(New Phrase(ID2.Text + " " + TFullname.Text, FontB))
            Col3.Border = 0
            Table1.AddCell(Col3)

            pdfDoc.Add(Table1)
#End Region
#Region "cuerpo"
            Dim Table3 As PdfPTable = New PdfPTable(3)
            Dim withs3 As Single() = New Single() {5.0F, 5.0F, 5.0F}
            Table3.WidthPercentage = 95
            Table3.SetWidths(withs3)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Table3.AddCell(CVacio)
            Col1 = New PdfPCell(New Phrase("Entrada:", FonC))
            Col1.Border = 0
            Table3.AddCell(Col1)
            Col2 = New PdfPCell(New Phrase("Salida:", FonC))
            Col2.Border = 0
            Table3.AddCell(Col2)
            Col3 = New PdfPCell(New Phrase("Horas:", FonC))
            Col3.Border = 0
            Table3.AddCell(Col3)
            For Each row As DataGridViewRow In DGVHORARIO.Rows
                Col1 = New PdfPCell(New Phrase(row.Cells("fechEnt").Value.ToString, FontD))
                Col1.Border = 0
                Table3.AddCell(Col1)
                Col2 = New PdfPCell(New Phrase(row.Cells("fechSal").Value.ToString, FontD))
                Col2.Border = 0
                Table3.AddCell(Col2)
                Col3 = New PdfPCell(New Phrase(row.Cells("horTrab").Value.ToString, FontD))
                Col3.Border = 0
                Table3.AddCell(Col3)
            Next
            pdfDoc.Add(Table3)
#End Region
#Region "final"
            'Lhours.Text
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph(" "))
            pdfDoc.Add(New Paragraph("Total de Horas Trabajadas:  " + Lhours.Text, FonC))
            pdfDoc.Close()
            MessageBox.Show("Se generó el Reporte")
#End Region
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
End Class