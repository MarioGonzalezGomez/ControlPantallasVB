Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic
Imports OpenCvSharp

Public Class ScreenControl
    Public secciones_PLAYLIST As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().  ' Llamada necesaria para el diseñador.

        objImagen1.ImageGetter = AddressOf ImagenSumario_getter

    End Sub

    Private Sub cmbEmision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmision.SelectedIndexChanged

        cargaPLAYLIST_PLAYER()
        'DataEmision.Rows.Clear()

        'Dim mensaje As String = ""

        'Dim num_linea As Integer = 0

        'Carpetas.SelectedPath = "\\" & IP_IPF & "\r\Recursos Pantallas\" & Tarjeta.Persona & "\" & DateTime.Now.ToString("dd_MM_yyyy") & "\" & cmbEmision.SelectedItem & "\"

        'Dim dir As IO.DirectoryInfo = New IO.DirectoryInfo(Carpetas.SelectedPath)

        'For Each fichero As IO.FileInfo In dir.GetFiles("*.emision", SearchOption.AllDirectories)

        '    Dim fichero_inix As MadMilkman.Ini.IniFile = New MadMilkman.Ini.IniFile
        '    fichero_inix.Load(fichero.FullName)
        '    Dim ini As New clsFicheroIni(fichero.FullName)

        '    For Each corchete In fichero_inix.Sections

        '        Dim elemento As New Elementos

        '        If num_linea = 0 Then
        '            elemento.Tipo = ini.Leer("Propiedades", "Elemento")
        '            elemento.Nombre = ini.Leer("Propiedades", "Nombre")
        '            elemento.Ruta = ini.Leer("Propiedades", "Ruta")
        '            elemento.Extension = ini.Leer("Propiedades", "Extension")

        '            If fichero_inix.Sections("Propiedades").Keys("Cristal").Value = "SI" Then
        '                labCristal.Visible = True
        '            Else
        '                labCristal.Visible = False
        '            End If

        '            DataEmision.Rows.Add(elemento.Nombre, elemento.Extension, elemento.Tipo, elemento.Ruta)

        '        Else

        '            elemento.Tipo = ini.Leer("Linea " & num_linea, "Elemento")
        '            elemento.Ruta = ini.Leer("Linea " & num_linea, "Ruta")
        '            elemento.Extension = ini.Leer("Linea " & num_linea, "Extension")
        '            'elemento.Descripcion = fichero_inix.Sections("Linea " & num_linea).Keys("Texto1").Value
        '            elemento.Descripcion = ini.Leer("Linea " & num_linea, "Texto1")
        '            elemento.Descripcion2 = ini.Leer("Linea " & num_linea, "Texto2")

        '            DataEmision.Rows.Add("", elemento.Extension, elemento.Tipo, elemento.Ruta, fichero_inix.Sections("Linea " & num_linea).Keys("Escala").Value, fichero_inix.Sections("Linea " & num_linea).Keys("PosX").Value, fichero_inix.Sections("Linea " & num_linea).Keys("PosZ").Value, elemento.Descripcion, elemento.Descripcion2)

        '        End If

        '        num_linea = num_linea + 1

        '    Next

        '    num_linea = 0

        'Next

        'DataEmision.Focus()

        cargaPLAYLIST_PLAYER()


    End Sub




    Private Function ImagenSumario_getter(model As Object) As Image

        Dim elem As Elementos = model

        Try
            'Return ImageList1.Images(elem.Nombre)
            Dim p As Image = Image.FromFile(elem.Ruta)
            Return p.GetThumbnailImage(150, 150 * 9 / 16, Nothing, 0)
        Catch ex As Exception
            Return Nothing
        End Try

        Return Nothing

    End Function

    Private Sub ScreenControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfiguracionInicial()
        cmbEDICION.SelectedItem = 0
        cargaPLAYLIST()

    End Sub

    Private Sub ConfiguracionInicial()

        CrearCarpetasINI()
        LeerINI()
        CargaPantallas()
        ConectaIPF()


    End Sub

    Public Sub CargaPantallas()
        'Carpetas.SelectedPath = "\\" & IP_IPF & "\r\Recursos Pantallas\" & Tarjeta.Persona & "\" & DateTime.Now.ToString("dd_MM_yyyy") & "\"

        Carpetas.SelectedPath = rsc
        Dim dir As DirectoryInfo = New DirectoryInfo(Carpetas.SelectedPath)

        cmbEDICION.DataSource = dir.GetDirectories
        cmbEmision.DataSource = dir.GetDirectories

    End Sub
    Public Sub ConectaIPF()

        EquipoIPF1.AutoConexion = True

        EquipoIPF1.Servidor = servidor

        EquipoIPF1.Encoder = "utf-8"
        EquipoIPF1.Puerto = 5123
        EquipoIPF1.Conectar()

    End Sub


    Private Sub ScreenControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Process.Start("taskkill", "/F /IM ipf.exe /T")

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        Try

            While objLISTPLAYLIST2.SelectedItems.Count > 0

                objLISTPLAYLIST2.Items.Remove(objLISTPLAYLIST2.SelectedItems(0))


            End While

            'secciones_JUGADORES = objLISTPLAYLIST.Items.Count

            'ActualizaJugadores()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnBorrarPlayer_Click(sender As Object, e As EventArgs) Handles btnBorrarPlayer.Click
        Try

            While oblLISTPLAYER.SelectedItems.Count > 0

                oblLISTPLAYER.Items.Remove(oblLISTPLAYER.SelectedItems(0))


            End While

            'secciones_JUGADORES = objLISTPLAYLIST.Items.Count

            'ActualizaJugadores()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click

        Try
            Dim item As ListViewItem = objLISTPLAYLIST2.SelectedItems(0)

            If item.Index = 0 Then
                Return
            End If

            Dim pos As Integer = item.Index - 1

            objLISTPLAYLIST2.Items.RemoveAt(item.Index)

            objLISTPLAYLIST2.Items.Insert(pos, item)

            objLISTPLAYLIST2.Focus()
            objLISTPLAYLIST2.Items(pos).Selected = True

            'ActualizaJugadores()

            objLISTPLAYLIST2.Items(pos).Selected = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnUpPlayer_Click(sender As Object, e As EventArgs) Handles btnUpPlayer.Click
        Try
            Dim item As ListViewItem = oblLISTPLAYER.SelectedItems(0)

            If item.Index = 0 Then
                Return
            End If

            Dim pos As Integer = item.Index - 1

            oblLISTPLAYER.Items.RemoveAt(item.Index)

            oblLISTPLAYER.Items.Insert(pos, item)

            oblLISTPLAYER.Focus()
            oblLISTPLAYER.Items(pos).Selected = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        Try
            Dim item As ListViewItem = objLISTPLAYLIST2.SelectedItems(0)

            If item.Index = (objLISTPLAYLIST2.Items.Count - 1) Then
                Return
            End If

            Dim pos As Integer = item.Index + 1

            objLISTPLAYLIST2.Items.RemoveAt(item.Index)

            objLISTPLAYLIST2.Items.Insert(pos, item)

            objLISTPLAYLIST2.Focus()
            objLISTPLAYLIST2.Items(pos).Selected = True

            'ActualizaJugadores()

            objLISTPLAYLIST2.Items(pos).Selected = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDownPlayer_Click(sender As Object, e As EventArgs) Handles btnDownPlayer.Click
        Try
            Dim item As ListViewItem = oblLISTPLAYER.SelectedItems(0)

            If item.Index = (oblLISTPLAYER.Items.Count - 1) Then
                Return
            End If

            Dim pos As Integer = item.Index + 1

            oblLISTPLAYER.Items.RemoveAt(item.Index)

            oblLISTPLAYER.Items.Insert(pos, item)

            oblLISTPLAYER.Focus()
            oblLISTPLAYER.Items(pos).Selected = True

        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargaPLAYLIST_PLAYER()


        oblLISTPLAYER.Items.Clear()
        'CARGA SUMARIO
        Dim num_linea As Integer = 0
        Dim tema As IO.DirectoryInfo = TryCast(cmbEmision.SelectedItem, IO.DirectoryInfo)

        If tema IsNot Nothing Then
            ' Limpiar la lista de playlist
            'objLISTPLAYLIST.Clear()

            Dim mensaje As String = ""

            ' Crear una nueva instancia de FolderBrowserDialog si no existe
            If Carpetas Is Nothing Then
                Carpetas = New FolderBrowserDialog()
            End If

            ' Establecer la ruta seleccionada
            Carpetas.SelectedPath = rsc & tema.Name

            ' Verificar si la carpeta existe antes de continuar
            If IO.Directory.Exists(Carpetas.SelectedPath) Then
                ' Aquí puedes agregar el código para trabajar con las carpetas seleccionadas
            Else
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona un ítem válido en el combo box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim dir As IO.DirectoryInfo = New IO.DirectoryInfo(Carpetas.SelectedPath)

        For Each fichero As IO.FileInfo In dir.GetFiles("*.emision", SearchOption.AllDirectories)

            Dim fichero_inix As MadMilkman.Ini.IniFile = New MadMilkman.Ini.IniFile
            fichero_inix.Load(fichero.FullName)
            Dim ini As New clsFicheroIni(fichero.FullName)

            For num_linea = 0 To fichero_inix.Sections.Count - 1

                'Dim elemento As New Elementos

                If num_linea = 0 Then
                    '    Try
                    'Dim result(5) As String
                    'Dim item As ListViewItem

                    'For i = 0 To fichero_inix.Sections.Count - 1

                    '    result(0) = ini.Leer("Linea " & i & "", "INDEX")
                    '    result(1) = ini.Leer("Linea " & i & "", "NOMBRE")
                    '    result(2) = ini.Leer("Linea " & i & "", "CARGO")
                    '    result(3) = ini.Leer("Linea " & i & "", "SUBTEXTO")
                    '    result(4) = ini.Leer("Linea " & i & "", "EQUIPO")

                    '    item = New ListViewItem(result)

                    '    objLISTPLAYLIST.Items.Insert(i, item)

                    'Next

                    '        Catch ex As Exception

                    '        End Try

                Else

                    Dim result(5) As String
                    Dim item As ListViewItem

                    result(0) = num_linea
                    result(1) = ini.Leer("Linea " & num_linea & "", "ElementoIZQ")
                    result(2) = ini.Leer("Linea " & num_linea & "", "ElementoCENTRO")
                    result(3) = ini.Leer("Linea " & num_linea & "", "ElementoDCHA")
                    result(4) = ini.Leer("Linea " & num_linea & "", "ElementoIZQ")
                    result(5) = num_linea

                    item = New ListViewItem(result)

                    oblLISTPLAYER.Items.Insert(num_linea - 1, item)

                End If

                'num_linea = num_linea + 1

            Next

            num_linea = 0

        Next

        'DataEmision.Focus()



    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles brnReload.Click

        CargaPantallas()
        objLISTPLAYLIST.Items.Clear()
        cargaPLAYLIST()


    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        CargaPantallas()

    End Sub

    Private Sub cmbEDICION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEDICION.SelectedIndexChanged

        PicFondo.Image = Nothing
        PicElemento.Image = Nothing

        If cmbEDICION.SelectedIndex <> -1 Then
            objLISTPLAYLIST.Items.Clear()
            cargaPLAYLIST()
            CargaRecursos()

        End If

    End Sub

    Private Sub CargaRecursos()

        lstObjectEDICION.Items.Clear()

        Dim dire As IO.DirectoryInfo = New IO.DirectoryInfo(rsc & cmbEDICION.SelectedItem.ToString & "\")

        Try
            For Each fichero As IO.FileInfo In dire.GetFiles()

                If Not {".jpg", ".png", ".mov", ".mp4", ".wmv", ".colas", ".directo", ".texto"}.Contains(fichero.Extension.ToLower) Then Continue For
                Dim elem As New Elementos
                elem.Ruta = fichero.FullName
                elem.Nombre = fichero.Name.Substring(0, fichero.Name.Length - fichero.Extension.Length)
                elem.Carpeta = fichero.Directory.ToString
                elem.Extension = fichero.Extension.ToLower
                elem.Tipo = ""
                elem.scale = "1.0"
                elem.positionX = "0"
                elem.positionZ = "0"
                elem.Descripcion = elem.Nombre
                elem.Descripcion2 = ""

                Select Case elem.Extension.ToLower
                    Case ".directo", ".colas"
                        Dim ini As New clsFicheroIni(dire.FullName & "\INI\" & elem.Nombre & ".ini")
                        elem.Descripcion = ini.Leer("Propiedades", "Texto1", elem.Nombre)
                    Case ".texto"
                        Dim ini As New clsFicheroIni(dire.FullName & "\INI\" & elem.Nombre & ".ini")
                        elem.Descripcion = ini.Leer("Propiedades", "Texto1", elem.Nombre)
                        elem.Descripcion2 = ini.Leer("Propiedades", "Texto2", elem.Descripcion2)
                End Select

                Dim Subcadena As String = elem.Nombre

                lstObjectEDICION.AddObject(elem)

            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Sub lstObjectEDICION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObjectEDICION.SelectedIndexChanged

        If lstObjectEDICION.SelectedIndex = -1 Then Exit Sub

        Dim elem_izq As Elementos = lstObjectEDICION.SelectedObject
        Dim filePath As String = elem_izq.Ruta
        Dim fileExtension As String = Path.GetExtension(filePath).ToLower()

        ' Ruta de las imágenes de recurso
        Dim resourcePath As String = Path.Combine(Application.StartupPath, "images")
        Dim videoResource As String = Path.Combine(resourcePath, "video.png")

        Try
            Select Case fileExtension
            ' Extensiones típicas de archivos de imagen
                Case ".jpg", ".jpeg", ".png", ".bmp", ".gif"
                    PicFondo.SizeMode = PictureBoxSizeMode.Zoom
                    PicFondo.Image = Image.FromFile(filePath)

            ' Extensiones típicas de archivos de video
                Case ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv"
                    PicFondo.SizeMode = PictureBoxSizeMode.Zoom
                    PicFondo.Image = Image.FromFile(videoResource)

                    ' Caso por defecto para extensiones no reconocidas
                Case Else
                    MessageBox.Show("Tipo de archivo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PicFondo.Image = Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub live_Click(sender As Object, e As EventArgs) Handles live.Click
        Dim imagePath As String = Path.Combine(Application.StartupPath, "images\directo.png")
        PicFondo.SizeMode = PictureBoxSizeMode.Zoom
        PicFondo.Image = Image.FromFile(imagePath)

        If txtTitulo.Text <> "" Or txtSubtitulo.Text <> "" Or txtCuerpo.Text <> "" Then
            ' Logica de escribir el texto en su fichero correspondiente
            ' Logica para poner un elemento en lstObjectEDICION o quitar la condición del salvaPlaylist

        Else
            ' Mostrar un mensaje de error si no hay ningún texto escrito
            ' MessageBox.Show("Debe rellenar al menos uno de los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click

        salvaPLAYLIST()
        cargaPLAYLIST()

    End Sub
    Public Sub salvaPLAYLIST()

        Dim tema As IO.DirectoryInfo = cmbEDICION.SelectedItem

        If lstObjectEDICION.SelectedObject Is Nothing Then

            MsgBox("No has seleccionado un elemento")
            Return

        End If

        Dim elemento_izq As Elementos = lstObjectEDICION.SelectedObject

        Dim ini As clsFicheroIni = New clsFicheroIni(rsc & tema.Name & "\" & tema.Name & ".emision")

        'If IO.File.Exists(rsc & tema.Name & "\" & tema.Name & ".emision") Then IO.File.Delete(rsc & tema.Name & "\" & tema.Name & ".emision")

        ini.Escribir("Propiedades", "Nombre", tema.Name)

        linea_emisión = objLISTPLAYLIST.Items.Count

        linea_emisión = linea_emisión + 1

        ini.Escribir("Linea " & linea_emisión, "ElementoIZQ", elemento_izq.Nombre)


    End Sub
    Public Sub cargaPLAYLIST()


        objLISTPLAYLIST.Items.Clear()
        'CARGA SUMARIO
        Dim num_linea As Integer = 0
        Dim tema As IO.DirectoryInfo = TryCast(cmbEDICION.SelectedItem, IO.DirectoryInfo)

        If tema IsNot Nothing Then
            ' Limpiar la lista de playlist
            'objLISTPLAYLIST.Clear()

            Dim mensaje As String = ""

            ' Crear una nueva instancia de FolderBrowserDialog si no existe
            If Carpetas Is Nothing Then
                Carpetas = New FolderBrowserDialog()
            End If

            ' Establecer la ruta seleccionada
            Carpetas.SelectedPath = rsc & tema.Name

            ' Verificar si la carpeta existe antes de continuar
            If IO.Directory.Exists(Carpetas.SelectedPath) Then
                ' Aquí puedes agregar el código para trabajar con las carpetas seleccionadas
            Else
                MessageBox.Show("La ruta especificada no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Selecciona un ítem válido en el combo box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim dir As IO.DirectoryInfo = New DirectoryInfo(Carpetas.SelectedPath)

        For Each fichero As IO.FileInfo In dir.GetFiles("*.emision", SearchOption.AllDirectories)

            Dim fichero_inix As MadMilkman.Ini.IniFile = New MadMilkman.Ini.IniFile
            fichero_inix.Load(fichero.FullName)
            Dim ini As New clsFicheroIni(fichero.FullName)

            For num_linea = 0 To fichero_inix.Sections.Count - 1

                'Dim elemento As New Elementos

                If num_linea = 0 Then
                    '    Try
                    'Dim result(5) As String
                    'Dim item As ListViewItem

                    'For i = 0 To fichero_inix.Sections.Count - 1

                    '    result(0) = ini.Leer("Linea " & i & "", "INDEX")
                    '    result(1) = ini.Leer("Linea " & i & "", "NOMBRE")
                    '    result(2) = ini.Leer("Linea " & i & "", "CARGO")
                    '    result(3) = ini.Leer("Linea " & i & "", "SUBTEXTO")
                    '    result(4) = ini.Leer("Linea " & i & "", "EQUIPO")

                    '    item = New ListViewItem(result)

                    '    objLISTPLAYLIST.Items.Insert(i, item)

                    'Next

                    '        Catch ex As Exception

                    '        End Try

                Else

                    Dim result(5) As String
                    Dim item As ListViewItem

                    result(0) = num_linea
                    result(1) = ini.Leer("Linea " & num_linea & "", "ElementoIZQ")
                    result(2) = ini.Leer("Linea " & num_linea & "", "ElementoCENTRO")
                    result(3) = ini.Leer("Linea " & num_linea & "", "ElementoDCHA")
                    result(4) = ini.Leer("Linea " & num_linea & "", "ElementoIZQ")
                    result(5) = num_linea

                    item = New ListViewItem(result)

                    objLISTPLAYLIST.Items.Insert(num_linea - 1, item)

                End If

                'num_linea = num_linea + 1

            Next

            num_linea = 0

        Next

        'DataEmision.Focus()



    End Sub

End Class
