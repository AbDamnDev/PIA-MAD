Imports System.Data.SqlClient
Imports System.IO
Public Class paracliente
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public serepiteUser As Boolean
    Public serepiteCliente As Boolean
    Public opcionesparte1 As Integer
    Public opcionesparte2 As Integer
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
    Sub traerIDusuariodesdeIdCliente()
        Try
            conectar()
            cmd = New SqlCommand("obtenerIDUSuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idCLIENTE", SqlDbType.Int)
            Parametro1.Value = LIDClient.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                IDperoUser.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub paracliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBESTADO.Items.Clear()
        Dim readfile As New StreamReader("Estados.txt")
        'leer todas las lineas y llenarlas en el combobox
        Do Until readfile.EndOfStream = True
            CBESTADO.Items.Add(readfile.ReadLine)
        Loop
        readfile.Close()
        LIDClient.Text = Form1.CveCliente
        Usern.Text = Form1.IDUser
        Lusus.Text = Form1.IDUser
        CBESTADO.SelectedIndex = -1
        traerIDusuariodesdeIdCliente()
    End Sub
    Sub traerdatosparteCLIENTE()
        Try
            conectar()
            cmd = New SqlCommand("traerDatosCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idCLIENTE", SqlDbType.Int)
            Parametro1.Value = LIDClient.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                TCelular.Text = dt.Rows(0).Item(1)
                LLCelular.Text = dt.Rows(0).Item(1)
                TCorreo.Text = dt.Rows(0).Item(2)
                LLmail.Text = dt.Rows(0).Item(2)
                TCURP.Text = dt.Rows(0).Item(4)
                Lcurpcurp.Text = dt.Rows(0).Item(4)
                LBorn.Text = dt.Rows(0).Item(5)
                DateTimePicker1.Value = dt.Rows(0).Item(5)
                TNOMBRE.Text = dt.Rows(0).Item(7)
                TAPELLIDOP.Text = dt.Rows(0).Item(8)
                TAPELLIDOM.Text = dt.Rows(0).Item(9)
                TCalle.Text = dt.Rows(0).Item(10)
                Tnumero.Text = dt.Rows(0).Item(11)
                Tcolonia.Text = dt.Rows(0).Item(12)
                TMuni.Text = dt.Rows(0).Item(13)
                Lestado.Text = dt.Rows(0).Item(14)
                Dim indicecb As Integer
                indicecb = -1
                indicecb = CBESTADO.FindStringExact(Lestado.Text)
                If indicecb <> -1 Then
                    CBESTADO.SelectedIndex = indicecb
                End If
                TCP.Text = dt.Rows(0).Item(15)

            End If
            DGVparaver.DataSource = dt

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub versiserepiteUser()
        Try
            conectar()
            cmd = New SqlCommand("isUsuarioRepetido", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro1.Value = TCURP.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar, 20)
            Parametro2.Value = Usern.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                If opcionesparte1 = 1 Then
                    If TCURP.Text = dt.Rows(0).Item(1) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
                If opcionesparte1 = 2 Then
                    If TUsername.Text = dt.Rows(0).Item(2) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
                If opcionesparte1 = 3 Then
                    If TCURP.Text = dt.Rows(0).Item(1) And TUsername.Text = dt.Rows(0).Item(2) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
            Else
                    serepiteUser = False
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub versiserepiteClient()
        Try
            conectar()
            cmd = New SqlCommand("isClienteRepetido", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@celular", SqlDbType.Char, 10)
            Parametro1.Value = TCelular.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@correo", SqlDbType.VarChar, 40)
            Parametro2.Value = TCorreo.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If opcionesparte2 = 1 Then
                    If TCelular.Text = dt.Rows(0).Item(1) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
                If opcionesparte2 = 2 Then
                    If TCorreo.Text = dt.Rows(0).Item(2) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
                If opcionesparte2 = 3 Then
                    If TCelular.Text = dt.Rows(0).Item(1) And TCorreo.Text = dt.Rows(0).Item(2) Then
                        serepiteUser = True
                    Else
                        serepiteUser = False
                    End If
                End If
            Else
                serepiteCliente = False
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub modUser()
        Try
            conectar()
            cmd = New SqlCommand("modUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@iduser", SqlDbType.Int)
            Parametro1.Value = IDperoUser.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50)
            Parametro2.Value = TNOMBRE.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 50)
            Parametro3.Value = TAPELLIDOP.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 50)
            Parametro4.Value = TAPELLIDOM.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro5.Value = TCURP.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@fechaNac", SqlDbType.Date)
            Parametro6.Value = DateTimePicker1.Value
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            Parametro7.Value = TUsername.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 20)
            Parametro8.Value = Tnewpass.Text
            Dim Parametro9 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro9.Value = TCalle.Text
            Dim Parametro10 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro10.Value = Tnumero.Text
            Dim Parametro11 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro11.Value = Tcolonia.Text
            Dim Parametro12 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro12.Value = TMuni.Text
            Dim Parametro13 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro13.Value = CBESTADO.SelectedItem.ToString
            Dim Parametro14 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro14.Value = TCP.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub modCliente()
        Try
            conectar()
            cmd = New SqlCommand("modCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idcliente", SqlDbType.Int)
            Parametro1.Value = LIDClient.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@celular", SqlDbType.Char, 10)
            Parametro2.Value = TCelular.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@correo", SqlDbType.VarChar, 40)
            Parametro3.Value = TCorreo.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub bCancelar_Click(sender As Object, e As EventArgs) Handles bCancelar.Click
        Dim mimenu As New MenuCliente
        mimenu.Show()
        Me.Hide()
    End Sub

    Private Sub TBring_Click(sender As Object, e As EventArgs) Handles TBring.Click
        traerdatosparteCLIENTE()
        TUsername.Text = Usern.Text
        Tnewpass.Text = Form1.power
        Bmodificar.Enabled = True
    End Sub

    Private Sub Bmodificar_Click(sender As Object, e As EventArgs) Handles Bmodificar.Click

        If Lcurpcurp.Text <> TCURP.Text And Lusus.Text = TUsername.Text Then
            opcionesparte1 = 1
        End If
        If Lcurpcurp.Text = TCURP.Text And Lusus.Text <> TUsername.Text Then
            opcionesparte1 = 2
        End If
        If Lcurpcurp.Text <> TCURP.Text And Lusus.Text <> TUsername.Text Then
            opcionesparte1 = 3
        End If
        If Lcurpcurp.Text <> TCURP.Text Or Lusus.Text <> TUsername.Text Then
            versiserepiteUser()
            If serepiteUser = False Then
                modUser()
            End If
        Else
            modUser()
        End If
        If LLCelular.Text <> TCelular.Text Or LLmail.Text = TCorreo.Text Then
            opcionesparte2 = 1
        End If
        If LLCelular.Text = TCelular.Text Or LLmail.Text <> TCorreo.Text Then
            opcionesparte2 = 2
        End If
        If LLCelular.Text <> TCelular.Text Or LLmail.Text <> TCorreo.Text Then
            opcionesparte2 = 3
        End If

        If LLCelular.Text <> TCelular.Text Or LLmail.Text <> TCorreo.Text Then
            versiserepiteClient()
            If serepiteCliente = False Then
                modCliente()
            End If
        Else
            modCliente()
        End If
    End Sub
End Class