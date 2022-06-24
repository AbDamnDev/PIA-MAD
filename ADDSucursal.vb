Imports System.Data.SqlClient
Imports System.IO
Public Class ADDSucursal

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public datosstring As String
    Public iduSUCURSALMOD As String
    Public datosstring2 As String
    Public stringaparte As String
    Public repetido As Boolean
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
    Private Sub ADDSucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Label1.Text = Form1.NombreCompleto
        'LState <-label escondido al lado de estado
        ComboBox2.Items.Clear()
        Dim readfile As New StreamReader("Estados.txt")
        'leer todas las lineas y llenarlas en el combobox
        Do Until readfile.EndOfStream = True
            ComboBox2.Items.Add(readfile.ReadLine)
        Loop
        readfile.Close()
        Traessucursal()
        llenarencargado()
    End Sub

    Private Sub ButtonBye_Click(sender As Object, e As EventArgs) Handles ButtonBye.Click
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
    Sub Registrarsucursal()
        conectar()
        Try
            cmd = New SqlCommand("insertarSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEmpleado", SqlDbType.Int)
            'Preguntarle a Abi si lo que pide es el id del empleado a cargo o del empleado que registro la sucursal
            'Parametro1.Value = Form1.CveEmpleado
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nombreSuc", SqlDbType.VarChar, 40)
            Parametro2.Value = Tnamesucur.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro3.Value = Tcallesucur.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro4.Value = Tnumsucur.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro5.Value = Tcoloniasucur.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro6.Value = Tmunisucur.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro7.Value = ComboBox2.SelectedItem.ToString
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro8.Value = Tcpsucur.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sucursal Ingresada")
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Baddtienda_Click(sender As Object, e As EventArgs) Handles Baddtienda.Click
        Registrarsucursal()
    End Sub

    Private Sub BlimipiaS_Click(sender As Object, e As EventArgs) Handles BlimipiaS.Click
        Tnamesucur.Text = ""
        Tcallesucur.Text = ""
        Tnumsucur.Text = ""
        Tcoloniasucur.Text = ""
        Tmunisucur.Text = ""
        Tcpsucur.Text = ""
        ComboBox2.SelectedIndex = -1

    End Sub
    Sub Traessucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            datosstring = "SELECT
SU.nombreSuc, US.nombre +' ' + US.apellidoPat +' '+ US.apellidoMat AS nombreCompleto,
SU.idSuc, SU.encargadoSuc, DS.calle, DS.numero, DS.colonia, DS.municipio, DS.estado, DS.codigoPostal      
From Sucursal SU
INNER Join DireccionSucursal DS ON SU.direccion =DS.idDirSuc
INNER Join Empleado EM ON SU.encargadoSuc =EM.idEmp
INNER Join Usuario US ON EM.idUsuarioEmp =US.idUser;"
            cmd.CommandText = datosstring
            dt = New DataTable
            da = New SqlDataAdapter(datosstring, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DGVsucursal.DataSource = dt
            Else
                MessageBox.Show("No hay Sucursales")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bshowtienda_Click(sender As Object, e As EventArgs) Handles Bshowtienda.Click
        Traessucursal()
    End Sub

    Private Sub DGVsucursal_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVsucursal.CellContentClick
        Dim Selecionfila As Integer
        Selecionfila = DGVsucursal.CurrentRow.Index
        iduSUCURSALMOD = DGVsucursal.Item("idSuc", DGVsucursal.CurrentRow.Index).Value
        Labelmodsuc.Text = iduSUCURSALMOD
        stringaparte = DGVsucursal.Item("nombreSuc", DGVsucursal.CurrentRow.Index).Value
        traigoSucursal()
    End Sub
    Sub traigoSucursal()
        Try
            conectar()
            cmd = New SqlCommand("traerDatosSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idsucursal", SqlDbType.Int)
            Parametro1.Value = Labelmodsuc.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Tnamesucur.Text = dt.Rows(0).Item(0)
                Tcallesucur.Text = dt.Rows(0).Item(4)
                Tnumsucur.Text = dt.Rows(0).Item(5)
                Tcoloniasucur.Text = dt.Rows(0).Item(6)
                Tmunisucur.Text = dt.Rows(0).Item(7)
                LState.Text = dt.Rows(0).Item(8)
                Dim indicecb As Integer
                indicecb = -1
                indicecb = ComboBox2.FindStringExact(LState.Text)
                If indicecb <> -1 Then
                    ComboBox2.SelectedIndex = indicecb
                End If
                Tcpsucur.Text = dt.Rows(0).Item(9)

            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BCargasucurmasiva_Click(sender As Object, e As EventArgs) Handles BCargasucurmasiva.Click
        Dim cargarsucur As New CargaMasivaSucursal
        cargarsucur.Show()
        Me.Hide()
    End Sub
    Sub validacion()
        Try
            conectar()
            cmd = New SqlCommand("isSucursalRepetida", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nomSuc", SqlDbType.VarChar, 40)
            Parametro2.Value = Tnamesucur.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            dt = New DataTable
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                repetido = True
            Else
                repetido = False
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub Modificarsucursal()
        Try
            conectar()
            cmd = New SqlCommand("modSucursal", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEmpleado", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro0 As SqlParameter = cmd.Parameters.Add("@idsuc", SqlDbType.Int)
            Parametro0.Value = Labelmodsuc.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nombreSuc", SqlDbType.VarChar, 40)
            Parametro2.Value = Tnamesucur.Text
            Dim Parametro9 As SqlParameter = cmd.Parameters.Add("@encargado", SqlDbType.Int)
            Parametro9.Value = LparID.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro3.Value = Tcallesucur.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro4.Value = Tnumsucur.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro5.Value = Tcoloniasucur.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro6.Value = Tmunisucur.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro7.Value = ComboBox2.SelectedItem.ToString
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro8.Value = Tcpsucur.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sucursal Modificada")
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub Bmodtienda_Click(sender As Object, e As EventArgs) Handles Bmodtienda.Click
        idempleadofromname()
        If lmamamia.Text <> stringaparte Then
            validacion()
            If repetido = False Then
                Modificarsucursal()
            End If
        Else
            Modificarsucursal()
        End If
    End Sub

    Sub llenarencargado()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            datosstring2 = "SELECT concat(US.nombre,' ',US.apellidoPat,' ',US.apellidoMat)Nombres 
FROM Empleado EM 
INNER JOIN Usuario US ON EM.idUsuarioEmp =US.idUser; "
            cmd.CommandText = datosstring2
            dt = New DataTable
            da = New SqlDataAdapter(datosstring2, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                CBencargado.DataSource = dt
                CBencargado.DisplayMember = "Nombres"
                CBencargado.SelectedIndex = -1

            Else
                MessageBox.Show("No hay Empleados")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Sub idempleadofromname()
        Try
            conectar()
            cmd = New SqlCommand("getEmpIDbyName", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@NomEmp", SqlDbType.VarChar, 120)
            Parametro1.Value = CBencargado.Text
            dt = New DataTable
            da = New SqlDataAdapter
            da.InsertCommand = cmd
            da.SelectCommand = cmd

            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                LparID.Text = dt.Rows(0).Item(0)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

End Class