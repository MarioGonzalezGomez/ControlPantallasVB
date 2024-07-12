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
        Dim dir As IO.DirectoryInfo = New IO.DirectoryInfo(Carpetas.SelectedPath)

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

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

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

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

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

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        Try

            While objLISTPLAYLIST2.SelectedItems.Count > 0

                objLISTPLAYLIST2.Items.Remove(objLISTPLAYLIST2.SelectedItems(0))


            End While

            'secciones_JUGADORES = objLISTPLAYLIST.Items.Count

            'ActualizaJugadores()

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

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        CargaPantallas()
        objLISTPLAYLIST.Items.Clear()
        cargaPLAYLIST()


    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        CargaPantallas()

    End Sub

    Private Sub cmbEDICION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEDICION.SelectedIndexChanged

        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Pic3.Image = Nothing

        If cmbEDICION.SelectedIndex <> -1 Then
            objLISTPLAYLIST.Items.Clear()
            cargaPLAYLIST()
            CargaRecursos()

        End If

    End Sub

    Private Sub CargaRecursos()

        lstObjectEDICION_IZQ.Items.Clear()
        lstObjectEDICION_CENTRO.Items.Clear()
        lstObjectEDICION_DCHA.Items.Clear()


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

                lstObjectEDICION_IZQ.AddObject(elem)
                lstObjectEDICION_CENTRO.AddObject(elem)
                lstObjectEDICION_DCHA.AddObject(elem)

            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Sub lstObjectEDICION_IZQ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObjectEDICION_IZQ.SelectedIndexChanged

        If lstObjectEDICION_IZQ.SelectedIndex = -1 Then Exit Sub

        Dim elem_izq As Elementos = lstObjectEDICION_IZQ.SelectedObject
        Dim filePath As String = elem_izq.Ruta
        Dim fileExtension As String = Path.GetExtension(filePath).ToLower()

        ' Ruta de las imágenes de recurso
        Dim resourcePath As String = Path.Combine(Application.StartupPath, "images")
        Dim videoResource As String = Path.Combine(resourcePath, "video.png")

        Try
            Select Case fileExtension
            ' Extensiones típicas de archivos de imagen
                Case ".jpg", ".jpeg", ".png", ".bmp", ".gif"
                    Pic1.SizeMode = PictureBoxSizeMode.Zoom
                    Pic1.Image = Image.FromFile(filePath)

            ' Extensiones típicas de archivos de video
                Case ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv"
                    Pic1.SizeMode = PictureBoxSizeMode.Zoom
                    Pic1.Image = Image.FromFile(videoResource)

                    ' Caso por defecto para extensiones no reconocidas
                Case Else
                    MessageBox.Show("Tipo de archivo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Pic1.Image = Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub lstObjectEDICION_CENTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObjectEDICION_CENTRO.SelectedIndexChanged

        If lstObjectEDICION_CENTRO.SelectedIndex = -1 Then Exit Sub

        Dim elem_centro As Elementos = lstObjectEDICION_CENTRO.SelectedObject
        Dim filePath As String = elem_centro.Ruta
        Dim fileExtension As String = Path.GetExtension(filePath).ToLower()

        ' Ruta de las imágenes de recurso
        Dim resourcePath As String = Path.Combine(Application.StartupPath, "images")
        Dim videoResource As String = Path.Combine(resourcePath, "video.png")

        Try
            Select Case fileExtension
            ' Extensiones típicas de archivos de imagen
                Case ".jpg", ".jpeg", ".png", ".bmp", ".gif"
                    Pic2.SizeMode = PictureBoxSizeMode.Zoom
                    Pic2.Image = Image.FromFile(filePath)

            ' Extensiones típicas de archivos de video
                Case ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv"
                    Pic2.SizeMode = PictureBoxSizeMode.Zoom
                    Pic2.Image = Image.FromFile(videoResource)

                    ' Caso por defecto para extensiones no reconocidas
                Case Else
                    MessageBox.Show("Tipo de archivo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Pic2.Image = Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub lstObjectEDICION_DCHA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstObjectEDICION_DCHA.SelectedIndexChanged

        If lstObjectEDICION_DCHA.SelectedIndex = -1 Then Exit Sub

        Dim elem_dcha As Elementos = lstObjectEDICION_DCHA.SelectedObject
        Dim filePath As String = elem_dcha.Ruta
        Dim fileExtension As String = Path.GetExtension(filePath).ToLower()

        ' Ruta de las imágenes de recurso
        Dim resourcePath As String = Path.Combine(Application.StartupPath, "images")
        Dim videoResource As String = Path.Combine(resourcePath, "video.png")

        Try
            Select Case fileExtension
            ' Extensiones típicas de archivos de imagen
                Case ".jpg", ".jpeg", ".png", ".bmp", ".gif"
                    Pic3.SizeMode = PictureBoxSizeMode.Zoom
                    Pic3.Image = Image.FromFile(filePath)

            ' Extensiones típicas de archivos de video
                Case ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv"
                    Pic3.SizeMode = PictureBoxSizeMode.Zoom
                    Pic3.Image = Image.FromFile(videoResource)

                    ' Caso por defecto para extensiones no reconocidas
                Case Else
                    MessageBox.Show("Tipo de archivo no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Pic3.Image = Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub img1_Click(sender As Object, e As EventArgs) Handles img1.Click

        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada IMG Types|*.jpg;*.jpeg;*.png"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New FileInfo(Buscador.FileName)

            Dim elem_izq As New Elementos
            elem_izq.Ruta = info.FullName
            elem_izq.Nombre = info.Name
            elem_izq.Carpeta = info.Directory.ToString
            elem_izq.Extension = info.Extension
            elem_izq.Imagen = info.FullName
            elem_izq.Descripcion = elem_izq.Nombre

            Pic1.SizeMode = PictureBoxSizeMode.Zoom
            Pic1.Image = Image.FromFile(elem_izq.Imagen)

            img1.BackColor = Color.PaleGreen
            mov1.BackColor = Color.WhiteSmoke
            live1.BackColor = Color.WhiteSmoke
            txt1.BackColor = Color.WhiteSmoke
            nada1.BackColor = Color.WhiteSmoke

            lstObjectEDICION_IZQ.AddObject(elem_izq)


        End If

    End Sub
    Private Sub mov1_Click(sender As Object, e As EventArgs) Handles mov1.Click

        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada MOV Types|*.mov;*.mkv;*.wmv;*.mp4;*.avi"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New FileInfo(Buscador.FileName)

            Dim elem As New Elementos
            elem.Ruta = info.FullName
            elem.Nombre = info.Name
            elem.Carpeta = info.Directory.ToString
            elem.Extension = info.Extension
            elem.Imagen = info.FullName
            elem.Descripcion = elem.Nombre

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\video.png")
            Pic1.SizeMode = PictureBoxSizeMode.Zoom
            Pic1.Image = Image.FromFile(imagePath)

            img1.BackColor = Color.WhiteSmoke
            mov1.BackColor = Color.PaleGreen
            live1.BackColor = Color.WhiteSmoke
            txt1.BackColor = Color.WhiteSmoke
            nada1.BackColor = Color.WhiteSmoke

        End If

    End Sub
    Private Sub live1_Click(sender As Object, e As EventArgs) Handles live1.Click
        Dim imagePath As String = Path.Combine(Application.StartupPath, "images\directo.png")
        Pic1.SizeMode = PictureBoxSizeMode.Zoom
        Pic1.Image = Image.FromFile(imagePath)
    End Sub
    Private Sub txt1_Click(sender As Object, e As EventArgs) Handles txt1.Click
        If txtTitulo1.Text <> "" Or txtSubtitulo1.Text <> "" Or txtCuerpo1.Text <> "" Then
            ' Logica de escribir el texto en su fichero correspondiente
            ' Logica para poner un elemento en lstObjectEDICION_IZQ o quitar la condición del salvaPlaylist

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\texto.png")
            Pic1.SizeMode = PictureBoxSizeMode.Zoom
            Pic1.Image = Image.FromFile(imagePath)
        Else
            ' Mostrar un mensaje de error si no hay ningún texto escrito
            MessageBox.Show("Debe rellenar al menos uno de los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub nada1_Click(sender As Object, e As EventArgs) Handles nada1.Click
        Pic1.Image = Nothing
    End Sub

    Private Sub img2_Click(sender As Object, e As EventArgs) Handles img2.Click

        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada IMG Types|*.jpg;*.jpeg;*.png"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New FileInfo(Buscador.FileName)

            Dim elem_centro As New Elementos
            elem_centro.Ruta = info.FullName
            elem_centro.Nombre = info.Name
            elem_centro.Carpeta = info.Directory.ToString
            elem_centro.Extension = info.Extension
            elem_centro.Imagen = info.FullName
            elem_centro.Descripcion = elem_centro.Nombre

            Pic2.SizeMode = PictureBoxSizeMode.Zoom
            Pic2.Image = Image.FromFile(elem_centro.Imagen)

            img2.BackColor = Color.PaleGreen
            mov2.BackColor = Color.WhiteSmoke
            live2.BackColor = Color.WhiteSmoke
            txt2.BackColor = Color.WhiteSmoke
            nada2.BackColor = Color.WhiteSmoke

            lstObjectEDICION_CENTRO.AddObject(elem_centro)

        End If

    End Sub
    Private Sub mov2_Click(sender As Object, e As EventArgs) Handles mov2.Click

        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada MOV Types|*.mov;*.mkv;*.wmv;*.mp4;*.avi"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New FileInfo(Buscador.FileName)

            Dim elem As New Elementos
            elem.Ruta = info.FullName
            elem.Nombre = info.Name
            elem.Carpeta = info.Directory.ToString
            elem.Extension = info.Extension
            elem.Imagen = info.FullName
            elem.Descripcion = elem.Nombre

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\video.png")
            Pic2.SizeMode = PictureBoxSizeMode.Zoom
            Pic2.Image = Image.FromFile(imagePath)

            img2.BackColor = Color.WhiteSmoke
            mov2.BackColor = Color.PaleGreen
            live2.BackColor = Color.WhiteSmoke
            txt2.BackColor = Color.WhiteSmoke
            nada2.BackColor = Color.WhiteSmoke

        End If

    End Sub
    Private Sub live2_Click(sender As Object, e As EventArgs) Handles live2.Click
        Dim imagePath As String = Path.Combine(Application.StartupPath, "images\directo.png")
        Pic2.SizeMode = PictureBoxSizeMode.Zoom
        Pic2.Image = Image.FromFile(imagePath)
    End Sub
    Private Sub txt2_Click(sender As Object, e As EventArgs) Handles txt2.Click
        If txtTitulo2.Text <> "" Or txtSubtitulo2.Text <> "" Or txtCuerpo2.Text <> "" Then
            ' Logica de escribir el texto en su fichero correspondiente

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\texto.png")
            Pic2.SizeMode = PictureBoxSizeMode.Zoom
            Pic2.Image = Image.FromFile(imagePath)
        Else
            ' Mostrar un mensaje de error si no hay ningún texto escrito
            MessageBox.Show("Debe rellenar al menos uno de los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub nada2_Click(sender As Object, e As EventArgs) Handles nada2.Click
        Pic2.Image = Nothing
    End Sub

    Private Sub img3_Click(sender As Object, e As EventArgs) Handles img3.Click

        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada IMG Types|*.jpg;*.jpeg;*.png"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New System.IO.FileInfo(Buscador.FileName)

            Dim elem_dcha As New Elementos
            elem_dcha.Ruta = info.FullName
            elem_dcha.Nombre = info.Name
            elem_dcha.Carpeta = info.Directory.ToString
            elem_dcha.Extension = info.Extension
            elem_dcha.Imagen = info.FullName
            elem_dcha.Descripcion = elem_dcha.Nombre

            Pic3.SizeMode = PictureBoxSizeMode.Zoom
            Pic3.Image = Image.FromFile(elem_dcha.Imagen)

            img3.BackColor = Color.PaleGreen
            mov3.BackColor = Color.WhiteSmoke
            live3.BackColor = Color.WhiteSmoke
            txt3.BackColor = Color.WhiteSmoke
            nada3.BackColor = Color.WhiteSmoke

            lstObjectEDICION_DCHA.AddObject(elem_dcha)

        End If

    End Sub
    Private Sub mov3_Click(sender As Object, e As EventArgs) Handles mov3.Click
        Buscador.InitialDirectory = rsc & cmbEDICION.Text
        Buscador.Filter = "Olimpiada MOV Types|*.mov;*.mkv;*.wmv;*.mp4;*.avi"

        If Buscador.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim info As New System.IO.FileInfo(Buscador.FileName)

            Dim elem As New Elementos
            elem.Ruta = info.FullName
            elem.Nombre = info.Name
            elem.Carpeta = info.Directory.ToString
            elem.Extension = info.Extension
            elem.Imagen = info.FullName
            elem.Descripcion = elem.Nombre

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\video.png")
            Pic3.SizeMode = PictureBoxSizeMode.Zoom
            Pic3.Image = Image.FromFile(imagePath)

            img3.BackColor = Color.WhiteSmoke
            mov3.BackColor = Color.PaleGreen
            live3.BackColor = Color.WhiteSmoke
            txt3.BackColor = Color.WhiteSmoke
            nada3.BackColor = Color.WhiteSmoke

        End If
    End Sub
    Private Sub live3_Click(sender As Object, e As EventArgs) Handles live3.Click
        Dim imagePath As String = Path.Combine(Application.StartupPath, "images\directo.png")
        Pic3.SizeMode = PictureBoxSizeMode.Zoom
        Pic3.Image = Image.FromFile(imagePath)
    End Sub
    Private Sub txt3_Click(sender As Object, e As EventArgs) Handles txt3.Click
        If txtTitulo3.Text <> "" Or txtSubtitulo3.Text <> "" Or txtCuerpo3.Text <> "" Then
            ' Logica de escribir el texto en su fichero correspondiente

            Dim imagePath As String = Path.Combine(Application.StartupPath, "images\texto.png")
            Pic3.SizeMode = PictureBoxSizeMode.Zoom
            Pic3.Image = Image.FromFile(imagePath)
        Else
            ' Mostrar un mensaje de error si no hay ningún texto escrito
            MessageBox.Show("Debe rellenar al menos uno de los campos de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub nada3_Click(sender As Object, e As EventArgs) Handles nada3.Click
        Pic3.Image = Nothing
    End Sub


    Private Sub objLISTPLAYLIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles objLISTPLAYLIST.SelectedIndexChanged

    End Sub

    Private Sub btnPlaylist_Click(sender As Object, e As EventArgs) Handles btnPlaylist.Click

        salvaPLAYLIST()
        cargaPLAYLIST()

    End Sub
    Public Sub salvaPLAYLIST()

        Dim tema As IO.DirectoryInfo = cmbEDICION.SelectedItem

        If lstObjectEDICION_IZQ.SelectedObject Is Nothing Or lstObjectEDICION_CENTRO.SelectedObject Is Nothing Or lstObjectEDICION_DCHA.SelectedObject Is Nothing Then

            MsgBox("No has seleccionado un elemento")
            Return

        End If

        Dim elemento_izq As Elementos = lstObjectEDICION_IZQ.SelectedObject
        Dim elemento_centro As Elementos = lstObjectEDICION_CENTRO.SelectedObject
        Dim elemento_dcha As Elementos = lstObjectEDICION_DCHA.SelectedObject

        Dim ini As clsFicheroIni = New clsFicheroIni(rsc & tema.Name & "\" & tema.Name & ".emision")

        'If IO.File.Exists(rsc & tema.Name & "\" & tema.Name & ".emision") Then IO.File.Delete(rsc & tema.Name & "\" & tema.Name & ".emision")

        ini.Escribir("Propiedades", "Nombre", tema.Name)

        linea_emisión = objLISTPLAYLIST.Items.Count

        linea_emisión = linea_emisión + 1

        ini.Escribir("Linea " & linea_emisión, "ElementoIZQ", elemento_izq.Nombre)
        ini.Escribir("Linea " & linea_emisión, "ElementoCENTRO", elemento_centro.Nombre)
        ini.Escribir("Linea " & linea_emisión, "ElementoDCHA", elemento_dcha.Nombre)


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
