Imports System.Data.SqlClient
Imports System.IO
Public Class Addcliente
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Private ogDatehere As DateTime
    Public probando As Boolean
    Public registroterminado As Boolean
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


    Private Sub Addcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        Dim readfile As New StreamReader("Estados.txt")
        'leer todas las lineas y llenarlas en el combobox
        Do Until readfile.EndOfStream = True
            ComboBox1.Items.Add(readfile.ReadLine)
        Loop
        readfile.Close()
        ogDatehere = Dateuser.Value
    End Sub

    Sub registerUser()
        Try
            conectar()
            cmd = New SqlCommand("insertarUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50)
            Parametro1.Value = NameClient.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 50)
            Parametro2.Value = LastNameClient.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 50)
            Parametro3.Value = LastNameMclient.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro4.Value = CURPClient.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@fechaNac", SqlDbType.Date)
            Parametro5.Value = Dateuser.Value
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            Parametro6.Value = UserClient.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 20)
            Parametro7.Value = PasswordClient.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@tipoUsuario", SqlDbType.Int)
            Parametro8.Value = 1
            Dim Parametro9 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro9.Value = calleClient.Text
            Dim Parametro10 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro10.Value = numclient.Text
            Dim Parametro11 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro11.Value = coloniaclient.Text
            Dim Parametro12 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro12.Value = municlient.Text
            Dim Parametro13 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro13.Value = ComboBox1.SelectedItem.ToString
            Dim Parametro14 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro14.Value = CPclient.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            probando = True

            desconectar()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Bnope_Click(sender As Object, e As EventArgs) Handles Bnope.Click
        Dim log As New Form1
        log.Show()
        Me.Hide()
    End Sub

    Private Sub Bok_Click(sender As Object, e As EventArgs) Handles Bok.Click
        registerUser()
        If probando = True Then
            clientevaEntrando()
        Else
            MessageBox.Show("No entró el Registro")
        End If
        If registroterminado = True Then
            MessageBox.Show("Registro Completado")
            limpiaventana()
        End If

    End Sub
    Sub clientevaEntrando()
        Try
            conectar()
            cmd = New SqlCommand("insertarCliente", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro0 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro0.Value = CURPClient.Text
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@celular", SqlDbType.Char, 10)
            Parametro1.Value = clientcell.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@correo", SqlDbType.VarChar, 40)
            Parametro2.Value = mailclient.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            registroterminado = True
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub limpiaventana()
        NameClient.Text = ""
        LastNameClient.Text = ""
        LastNameMclient.Text = ""
        CURPClient.Text = ""
        Dateuser.Value = ogDatehere
        UserClient.Text = ""
        PasswordClient.Text = ""
        calleClient.Text = ""
        numclient.Text = ""
        coloniaclient.Text = ""
        municlient.Text = ""
        ComboBox1.SelectedIndex = -1
        CPclient.Text = ""
        clientcell.Text = ""
        mailclient.Text = ""

    End Sub
End Class


