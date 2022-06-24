Imports System.Data.SqlClient
Imports System.IO
Public Class ADDEmpleado
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QUJFAL4\SQLEXPRESS;Initial Catalog=ProyectoMAD;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter = New SqlDataAdapter
    Dim dt As DataTable = New DataTable
    Public prueba1 As Boolean
    Private ogDate As DateTime
    Public idusuarioaModify As String
    Public stringparadata As String
    Public Sucurnom As String
    Public sucursalelegida As String
    Public optionpart1 As Integer
    Public optionpart2 As Integer
    Public Userrepetido As Boolean
    Public Emplrepetido As Boolean
    'Dim adminmen As New MenuAdmin
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

    Private Sub ADDEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
        'con.Open()
        conectar()
        ComboBox1.Items.Clear()
        Dim readfile As New StreamReader("Estados.txt")
        'leer todas las lineas y llenarlas en el combobox
        Do Until readfile.EndOfStream = True
            ComboBox1.Items.Add(readfile.ReadLine)
        Loop
        readfile.Close()
        prueba1 = False
        ogDate = DateTimePicker1.Value
        TraerEmpleados()
        nombreSucursal()
    End Sub

    Private Sub ButtonGoback_Click(sender As Object, e As EventArgs) Handles ButtonGoback.Click
        Dim adminmen As New MenuAdmin
        adminmen.Show()
        Me.Hide()

    End Sub
    Sub registrarEmpleado()
        conectar()
        Try
            conectar()
            cmd = New SqlCommand("insertarUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50)
            Parametro1.Value = TBnom.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 50)
            Parametro2.Value = TBLastnamep.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 50)
            Parametro3.Value = TBLastnameM.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro4.Value = TBcurp.Text
            'No olvidar cambiar el textbox por un datetimepicker
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@fechaNac", SqlDbType.Date)
            Parametro5.Value = DateTimePicker1.Value
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            Parametro6.Value = TBuser.Text
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 20)
            Parametro7.Value = TBcontrasena.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@tipoUsuario", SqlDbType.Int)
            'poner que el checkbox haga lo de valor igual a 2 o 3
            If CBAdmin.Checked = True Then
                Parametro8.Value = 3
            End If
            If CBEmpleado.Checked = True Then
                Parametro8.Value = 2
            End If
            Dim Parametro9 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro9.Value = TBcalle.Text
            Dim Parametro10 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro10.Value = TBnum.Text
            Dim Parametro11 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro11.Value = TBcolonia.Text
            Dim Parametro12 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro12.Value = TBmuni.Text
            Dim Parametro13 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro13.Value = ComboBox1.SelectedItem.ToString
            Dim Parametro14 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro14.Value = TBcp.Text

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            prueba1 = True


            desconectar()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub BAddEmployee_Click(sender As Object, e As EventArgs) Handles BAddEmployee.Click
        Dim unosindice As Integer
        Dim anotherindice As Integer
        unosindice = CBNSE.SelectedIndex
        anotherindice = ComboBox1.SelectedIndex
        If unosindice <> -1 And anotherindice <> -1 Then

            registrarEmpleado()
            If prueba1 = True Then
                registrarempladoparte2()

            Else
                MessageBox.Show("No entro")
            End If
        Else
            MessageBox.Show("Porfavor llene todos los campos")
        End If
    End Sub

    Private Sub registrarempladoparte2()
        Try
            conectar()

            cmd = New SqlCommand("insertarEmpleado", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@admin", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro2.Value = TBcurp.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.Char, 13)
            Parametro3.Value = TBrfc.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@sucursal", SqlDbType.Int)
            'Falta ingresar la sucursal
            Parametro4.Value = Labeltoremember.Text
            'Falta ingresar la sucursal

            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            MessageBox.Show("Si entro")
            desconectar()
            'Funcion para limpiar la pantalla

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
            Parametro1.Value = sucursalelegida
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Labeltoremember.Text = dt.Rows(0).Item(0)
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TBnom.Text = ""
        TBLastnamep.Text = ""
        TBLastnameM.Text = ""
        TBcurp.Text = ""
        TBrfc.Text = ""
        TBuser.Text = ""
        TBcontrasena.Text = ""
        TBcalle.Text = ""
        TBnum.Text = ""
        TBcolonia.Text = ""
        TBmuni.Text = ""
        TBcp.Text = ""
        Label19.Text = ""
        ComboBox1.SelectedIndex = -1
        CBNSE.SelectedIndex = -1
        CBAdmin.Checked = False
        CBEmpleado.Checked = False
        DateTimePicker1.Value = ogDate
    End Sub

    Private Sub BShowemploy_Click(sender As Object, e As EventArgs) Handles BShowemploy.Click
        TraerEmpleados()
    End Sub

    Sub TraerEmpleados()
        Try
            conectar()

            cmd = New SqlCommand(vbNull, con)
            cmd.CommandText = "SELECT
EM.idEmp,
US.nombre +' ' + US.apellidoPat +' '+ US.apellidoMat AS nombreCompleto,
EM.RFC,
EM.isAdmin,
US.CURP
FROM Empleado EM
INNER JOIN Usuario US ON EM.idUsuarioEmp=US.idUser 
WHERE EM.bloqueado=0;"
            stringparadata = "SELECT
EM.idEmp,
US.nombre +' ' + US.apellidoPat +' '+ US.apellidoMat AS nombreCompleto,
EM.RFC,
EM.isAdmin,
US.CURP
FROM Empleado EM
INNER JOIN Usuario US ON EM.idUsuarioEmp=US.idUser 
WHERE EM.bloqueado=0;"
            dt = New DataTable
            da = New SqlDataAdapter(stringparadata, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                DTGregemp.DataSource = dt
            Else
                MessageBox.Show("No hay Empleados")
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub DTGregemp_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DTGregemp.CellContentClick
        Dim Selecionfila As Integer

        Selecionfila = DTGregemp.CurrentRow.Index
        If Selecionfila <> -1 Then
            idusuarioaModify = DTGregemp.Item("idEmp", DTGregemp.CurrentRow.Index).Value
            Lempleadomod.Text = idusuarioaModify
            traerEmpleado()
            idusuario()
        End If

    End Sub
    Sub traerEmpleado()
        Try
            Dim versiesadmin As Integer
            conectar()
            cmd = New SqlCommand("traerDatosEmpleado", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro1.Value = Lempleadomod.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                'dt.Rows(0).Item(0)
                LparaId.Text = dt.Rows(0).Item(0)
                TBrfc.Text = dt.Rows(0).Item(1)
                Lparaunrfc.Text = dt.Rows(0).Item(1)
                versiesadmin = dt.Rows(0).Item(10)
                If versiesadmin = 3 Then
                    CBAdmin.Checked = True
                    CBEmpleado.Checked = False
                Else
                    CBAdmin.Checked = False
                    CBEmpleado.Checked = True
                End If
                TBnom.Text = dt.Rows(0).Item(3)
                TBLastnamep.Text = dt.Rows(0).Item(4)
                TBLastnameM.Text = dt.Rows(0).Item(5)
                TBcurp.Text = dt.Rows(0).Item(6)
                Lforcurp.Text = dt.Rows(0).Item(6)
                TBuser.Text = dt.Rows(0).Item(7)
                Lnombreusuario.Text = dt.Rows(0).Item(7)
                TBcontrasena.Text = dt.Rows(0).Item(8)
                DateTimePicker1.Value = dt.Rows(0).Item(9)
                TBcalle.Text = dt.Rows(0).Item(11)
                TBnum.Text = dt.Rows(0).Item(12)
                TBcolonia.Text = dt.Rows(0).Item(13)
                TBmuni.Text = dt.Rows(0).Item(14)
                Label19.Text = dt.Rows(0).Item(15)
                Dim indicecb As Integer
                indicecb = -1
                indicecb = ComboBox1.FindStringExact(Label19.Text)
                If indicecb <> -1 Then
                    ComboBox1.SelectedIndex = indicecb
                End If
                TBcp.Text = dt.Rows(0).Item(16)
                Lagrimas.Text = dt.Rows(0).Item(17)
                Dim indiceparaelquenosasustoporquepensamosqueyahabiavalidoquesonuestrabasededatos As Integer
                indiceparaelquenosasustoporquepensamosqueyahabiavalidoquesonuestrabasededatos = -1
                indiceparaelquenosasustoporquepensamosqueyahabiavalidoquesonuestrabasededatos = CBNSE.FindStringExact(Lagrimas.Text)
                If indiceparaelquenosasustoporquepensamosqueyahabiavalidoquesonuestrabasededatos <> -1 Then
                    CBNSE.SelectedIndex = indiceparaelquenosasustoporquepensamosqueyahabiavalidoquesonuestrabasededatos
                End If

            Else
                MessageBox.Show("No hay Empleados")
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub nombreSucursal()
        Try
            conectar()
            cmd = New SqlCommand(vbNull, con)
            Sucurnom = "SELECT
nombreSuc
FROM Sucursal;"
            cmd.CommandText = Sucurnom
            dt = New DataTable
            da = New SqlDataAdapter(Sucurnom, con)
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            CBNSE.DataSource = dt
            CBNSE.DisplayMember = "nombreSuc"
            CBNSE.SelectedIndex = -1
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

    Private Sub CBNSE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNSE.SelectedIndexChanged
        Dim unindice As Integer
        unindice = CBNSE.SelectedIndex
        If unindice <> -1 Then
            sucursalelegida = CBNSE.Text
            buscarIDsucursal()
        End If
    End Sub

    Private Sub BModifyEmployee_Click(sender As Object, e As EventArgs) Handles BModifyEmployee.Click
        If Lforcurp.Text <> TBcurp.Text And Lnombreusuario.Text = TBuser.Text Then
            optionpart1 = 1
        End If
        If Lforcurp.Text = TBcurp.Text And Lnombreusuario.Text <> TBuser.Text Then
            optionpart1 = 2
        End If
        If Lforcurp.Text <> TBcurp.Text And Lnombreusuario.Text <> TBuser.Text Then
            optionpart1 = 3
        End If
        If Lforcurp.Text <> TBcurp.Text Or Lnombreusuario.Text <> TBuser.Text Then
            versiUserserepite()
            If Userrepetido = False Then
                ModifyUser()
            End If
        Else
            ModifyUser()

        End If
        If Lparaunrfc.Text <> TBrfc.Text Then
            VersiserepiteEmpleado()
            If Emplrepetido = False Then
                ModifyEmpleado()
            End If
        Else
            ModifyEmpleado()
        End If
    End Sub
    Sub idusuario()
        Try
            conectar()
            cmd = New SqlCommand("obtenerIDUSuarioparaEmpleado", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@idEMPLEADO", SqlDbType.Int)
            Parametro1.Value = LparaId.Text
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ELidUser.Text = dt.Rows(0).Item(0)
            End If
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub versiUserserepite()
        Try
            conectar()
            cmd = New SqlCommand("isUsuarioRepetido", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro1.Value = TBcurp.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar, 20)
            Parametro2.Value = Form1.IDUser
            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                If optionpart1 = 1 Then
                    If TBcurp.Text = dt.Rows(0).Item(1) Then
                        Userrepetido = True
                    Else
                        Userrepetido = False
                    End If
                End If
                If optionpart1 = 2 Then
                    If Form1.IDUser = dt.Rows(0).Item(2) Then
                        Userrepetido = True
                    Else
                        Userrepetido = False
                    End If
                End If
                If optionpart1 = 3 Then
                    If TBcurp.Text = dt.Rows(0).Item(1) And Form1.IDUser = dt.Rows(0).Item(2) Then
                        Userrepetido = True
                    Else
                        Userrepetido = False
                    End If
                End If
            Else
                Userrepetido = False
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub VersiserepiteEmpleado()
        Try
            conectar()
            cmd = New SqlCommand("isEmpleadoRepetido", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@rfc", SqlDbType.Char, 13)
            Parametro1.Value = TBrfc.Text

            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Emplrepetido = True
            Else
                Emplrepetido = False
            End If

            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub ModifyUser()
        Try
            conectar()
            cmd = New SqlCommand("modUsuario", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@iduser", SqlDbType.Int)
            Parametro1.Value = ELidUser.Text
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50)
            Parametro2.Value = TBnom.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@apellidoPat", SqlDbType.VarChar, 50)
            Parametro3.Value = TBLastnamep.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@apellidoMat", SqlDbType.VarChar, 50)
            Parametro4.Value = TBLastnameM.Text
            Dim Parametro5 As SqlParameter = cmd.Parameters.Add("@CURP", SqlDbType.Char, 18)
            Parametro5.Value = TBcurp.Text
            Dim Parametro6 As SqlParameter = cmd.Parameters.Add("@fechaNac", SqlDbType.Date)
            Parametro6.Value = DateTimePicker1.Value
            Dim Parametro7 As SqlParameter = cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 20)
            Parametro7.Value = TBuser.Text
            Dim Parametro8 As SqlParameter = cmd.Parameters.Add("@contrasena", SqlDbType.VarChar, 20)
            Parametro8.Value = TBcontrasena.Text
            Dim Parametro9 As SqlParameter = cmd.Parameters.Add("@calle", SqlDbType.VarChar, 30)
            Parametro9.Value = TBcalle.Text
            Dim Parametro10 As SqlParameter = cmd.Parameters.Add("@numero", SqlDbType.Int)
            Parametro10.Value = TBnum.Text
            Dim Parametro11 As SqlParameter = cmd.Parameters.Add("@colonia", SqlDbType.VarChar, 40)
            Parametro11.Value = TBcolonia.Text
            Dim Parametro12 As SqlParameter = cmd.Parameters.Add("@municipio", SqlDbType.VarChar, 30)
            Parametro12.Value = TBmuni.Text
            Dim Parametro13 As SqlParameter = cmd.Parameters.Add("@estado", SqlDbType.VarChar, 30)
            Parametro13.Value = ComboBox1.SelectedItem.ToString
            Dim Parametro14 As SqlParameter = cmd.Parameters.Add("@codigoPostal", SqlDbType.Char, 5)
            Parametro14.Value = TBcp.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub
    Sub ModifyEmpleado()
        Try
            conectar()
            cmd = New SqlCommand("modEmp", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim Parametro1 As SqlParameter = cmd.Parameters.Add("@admin", SqlDbType.Int)
            Parametro1.Value = Form1.CveEmpleado
            Dim Parametro2 As SqlParameter = cmd.Parameters.Add("@idemp", SqlDbType.Int)
            Parametro2.Value = LparaId.Text
            Dim Parametro3 As SqlParameter = cmd.Parameters.Add("@RFC", SqlDbType.Char, 13)
            Parametro3.Value = TBrfc.Text
            Dim Parametro4 As SqlParameter = cmd.Parameters.Add("@sucursal", SqlDbType.Int)
            Parametro4.Value = Labeltoremember.Text
            da.InsertCommand = cmd
            da.SelectCommand = cmd
            cmd.ExecuteNonQuery()
            desconectar()
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString, MsgBoxStyle.Critical, "Informacion")
        End Try
    End Sub

End Class