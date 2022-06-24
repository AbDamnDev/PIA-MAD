Imports System.Data.SqlClient
Public Class ADDTARJETAS
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public entra As Boolean
    Private trjetid As String
    Public numTARJETA As String
    Public idTarjet As String
    Public veoveo As Boolean
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
    Private Sub ADDTARJETAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form1.CveCliente
    End Sub

    Private Sub BDontWanttobehere_Click(sender As Object, e As EventArgs) Handles BDontWanttobehere.Click
        Dim menucliente As New MenuCliente
        menucliente.Show()
        Me.Hide()
    End Sub
    Sub agregatarjeta()
        Try
            conectar()
            cmd = New SqlCommand("insertarTarjeta", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@cliente", SqlDbType.Int)
            Parametro1.Value = Form1.CveCliente
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@numTarjeta", SqlDbType.Char, 16)
            Parametro2.Value = Tnumtarjeta.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@expdate", SqlDbType.Char, 4)
            Parametro3.Value = Texpiration.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@cvvtarjeta", SqlDbType.Char, 3)
            Parametro4.Value = Tcvv.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tarjeta Agregada")
            entra = True
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BAddTarjeta_Click(sender As Object, e As EventArgs) Handles BAddTarjeta.Click
        agregatarjeta()
        If entra = True Then
            Limpieza()
        End If
    End Sub

    Sub Limpieza()
        Tnumtarjeta.Text = ""
        Texpiration.Text = ""
        Tcvv.Text = ""
        entra = False
    End Sub

    Private Sub BShowTarjetas_Click(sender As Object, e As EventArgs) Handles BShowTarjetas.Click
        traertarjetas()
    End Sub

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
                DGVTarjetas.DataSource = dt
            Else
                MessageBox.Show("No tienes tarjetas")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub DGVTarjetas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTarjetas.CellContentClick
        Dim Selecionfila As Integer
        Selecionfila = DGVTarjetas.CurrentRow.Index
        numTARJETA = DGVTarjetas.Item("numTarjeta", DGVTarjetas.CurrentRow.Index).Value
        Lnumt.Text = numTARJETA
        idTarjet = DGVTarjetas.Item("idMetPag", DGVTarjetas.CurrentRow.Index).Value
        Lidmetpag.Text = idTarjet
        traigoTARJETA()

    End Sub
    Sub traigoTARJETA()
        Try
            conectar()
            cmd = New SqlCommand("traerUnaTarjeta", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idtarjeta", SqlDbType.Int)
            Parametro1.Value = Lidmetpag.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ' TBnom.Text = dt.Rows(0).Item(3)
                Tnumtarjeta.Text = dt.Rows(0).Item(0)
                Texpiration.Text = dt.Rows(0).Item(1)
                Tcvv.Text = dt.Rows(0).Item(2)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub Validartarjeta()
        Try
            conectar()
            cmd = New SqlCommand("isTarjetaRepetida", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@Tarjeta", SqlDbType.Char, 16)
            Parametro1.Value = Tnumtarjeta.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                veoveo = True
            Else
                veoveo = False
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub modificartarjeta()
        Try
            conectar()
            cmd = New SqlCommand("modTarjeta", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idtarjeta", SqlDbType.Int)
            Parametro1.Value = Lidmetpag.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@numTarjeta", SqlDbType.Char, 16)
            Parametro2.Value = Tnumtarjeta.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@expdate", SqlDbType.Char, 4)
            Parametro3.Value = Texpiration.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@cvvtarjeta", SqlDbType.Char, 3)
            Parametro4.Value = Tcvv.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tarjeta Modificada")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bmodify_Click(sender As Object, e As EventArgs) Handles Bmodify.Click
        If Lnumt.Text <> Tnumtarjeta.Text Then
            Validartarjeta()
            If veoveo = False Then
                modificartarjeta()
            End If
        Else
            modificartarjeta()
        End If
    End Sub
End Class