<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenControl))
        Me.cmbEDICION = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.objLISTPLAYLIST = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.cmbFONDOS = New System.Windows.Forms.ComboBox()
        Me.lstObjectEDICION = New BrightIdeasSoftware.ObjectListView()
        Me.objImagen1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.brnReload = New System.Windows.Forms.Button()
        Me.btnPlaylist = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.live = New System.Windows.Forms.Button()
        Me.PanelTextos = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuerpo = New System.Windows.Forms.RichTextBox()
        Me.posy = New System.Windows.Forms.NumericUpDown()
        Me.escala = New System.Windows.Forms.NumericUpDown()
        Me.txtSubtitulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.posx = New System.Windows.Forms.NumericUpDown()
        Me.PicElemento = New System.Windows.Forms.PictureBox()
        Me.PicFondo = New System.Windows.Forms.PictureBox()
        Me.objLISTPLAYLIST2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.cmbEmision = New System.Windows.Forms.ComboBox()
        Me.Buscador = New System.Windows.Forms.OpenFileDialog()
        Me.Carpetas = New System.Windows.Forms.FolderBrowserDialog()
        Me.PicElementPlayer = New System.Windows.Forms.PictureBox()
        Me.PicFondoPlayer = New System.Windows.Forms.PictureBox()
        Me.oblLISTPLAYER = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDownPlayer = New System.Windows.Forms.Button()
        Me.btnUpPlayer = New System.Windows.Forms.Button()
        Me.btnBorrarPlayer = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.lstObjectEDICION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTextos.SuspendLayout()
        CType(Me.posy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.escala, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.posx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicElemento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PicElementPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFondoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbEDICION
        '
        Me.cmbEDICION.FormattingEnabled = True
        Me.cmbEDICION.Location = New System.Drawing.Point(17, 17)
        Me.cmbEDICION.Name = "cmbEDICION"
        Me.cmbEDICION.Size = New System.Drawing.Size(187, 21)
        Me.cmbEDICION.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1387, 552)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.objLISTPLAYLIST)
        Me.TabPage1.Controls.Add(Me.btnDown)
        Me.TabPage1.Controls.Add(Me.btnUp)
        Me.TabPage1.Controls.Add(Me.cmbFONDOS)
        Me.TabPage1.Controls.Add(Me.lstObjectEDICION)
        Me.TabPage1.Controls.Add(Me.brnReload)
        Me.TabPage1.Controls.Add(Me.btnPlaylist)
        Me.TabPage1.Controls.Add(Me.btnBorrar)
        Me.TabPage1.Controls.Add(Me.live)
        Me.TabPage1.Controls.Add(Me.PanelTextos)
        Me.TabPage1.Controls.Add(Me.PicElemento)
        Me.TabPage1.Controls.Add(Me.PicFondo)
        Me.TabPage1.Controls.Add(Me.cmbEDICION)
        Me.TabPage1.Controls.Add(Me.objLISTPLAYLIST2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1379, 526)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "EDICIÓN   "
        Me.TabPage1.ToolTipText = "EDICIÓN"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(339, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 134
        Me.Label19.Text = "FONDO"
        '
        'objLISTPLAYLIST
        '
        Me.objLISTPLAYLIST.BackColor = System.Drawing.Color.LightGray
        Me.objLISTPLAYLIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader15})
        Me.objLISTPLAYLIST.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objLISTPLAYLIST.ForeColor = System.Drawing.Color.Gray
        Me.objLISTPLAYLIST.FullRowSelect = True
        Me.objLISTPLAYLIST.GridLines = True
        Me.objLISTPLAYLIST.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.objLISTPLAYLIST.HideSelection = False
        Me.objLISTPLAYLIST.Location = New System.Drawing.Point(693, 73)
        Me.objLISTPLAYLIST.Name = "objLISTPLAYLIST"
        Me.objLISTPLAYLIST.Size = New System.Drawing.Size(467, 438)
        Me.objLISTPLAYLIST.TabIndex = 133
        Me.objLISTPLAYLIST.UseCompatibleStateImageBehavior = False
        Me.objLISTPLAYLIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "INDEX"
        Me.ColumnHeader9.Width = 54
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "IMAGEN"
        Me.ColumnHeader10.Width = 115
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "FONDO"
        Me.ColumnHeader11.Width = 115
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "VIDEO 1"
        Me.ColumnHeader12.Width = 115
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "VIDEO 2"
        Me.ColumnHeader15.Width = 80
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnDown.BackgroundImage = CType(resources.GetObject("btnDown.BackgroundImage"), System.Drawing.Image)
        Me.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.ForeColor = System.Drawing.Color.Transparent
        Me.btnDown.Location = New System.Drawing.Point(1163, 258)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(20, 33)
        Me.btnDown.TabIndex = 126
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnUp.BackgroundImage = CType(resources.GetObject("btnUp.BackgroundImage"), System.Drawing.Image)
        Me.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.ForeColor = System.Drawing.Color.Transparent
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUp.Location = New System.Drawing.Point(1163, 217)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(20, 33)
        Me.btnUp.TabIndex = 125
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'cmbFONDOS
        '
        Me.cmbFONDOS.FormattingEnabled = True
        Me.cmbFONDOS.Location = New System.Drawing.Point(342, 240)
        Me.cmbFONDOS.Name = "cmbFONDOS"
        Me.cmbFONDOS.Size = New System.Drawing.Size(171, 21)
        Me.cmbFONDOS.TabIndex = 132
        '
        'lstObjectEDICION
        '
        Me.lstObjectEDICION.AllColumns.Add(Me.objImagen1)
        Me.lstObjectEDICION.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.objImagen1})
        Me.lstObjectEDICION.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstObjectEDICION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstObjectEDICION.FullRowSelect = True
        Me.lstObjectEDICION.GridLines = True
        Me.lstObjectEDICION.HideSelection = False
        Me.lstObjectEDICION.Location = New System.Drawing.Point(17, 73)
        Me.lstObjectEDICION.MultiSelect = False
        Me.lstObjectEDICION.Name = "lstObjectEDICION"
        Me.lstObjectEDICION.ShowGroups = False
        Me.lstObjectEDICION.Size = New System.Drawing.Size(284, 438)
        Me.lstObjectEDICION.TabIndex = 129
        Me.lstObjectEDICION.UseCompatibleStateImageBehavior = False
        Me.lstObjectEDICION.UseHotItem = True
        Me.lstObjectEDICION.UseTranslucentHotItem = True
        Me.lstObjectEDICION.UseTranslucentSelection = True
        Me.lstObjectEDICION.View = System.Windows.Forms.View.Details
        '
        'objImagen1
        '
        Me.objImagen1.AspectName = "Nombre"
        Me.objImagen1.CellPadding = Nothing
        Me.objImagen1.FillsFreeSpace = True
        Me.objImagen1.Text = "IZQ"
        Me.objImagen1.Width = 107
        Me.objImagen1.WordWrap = True
        '
        'brnReload
        '
        Me.brnReload.Location = New System.Drawing.Point(210, 17)
        Me.brnReload.Name = "brnReload"
        Me.brnReload.Size = New System.Drawing.Size(91, 21)
        Me.brnReload.TabIndex = 128
        Me.brnReload.Text = "RELOAD"
        Me.brnReload.UseVisualStyleBackColor = True
        '
        'btnPlaylist
        '
        Me.btnPlaylist.Location = New System.Drawing.Point(544, 240)
        Me.btnPlaylist.Name = "btnPlaylist"
        Me.btnPlaylist.Size = New System.Drawing.Size(129, 54)
        Me.btnPlaylist.TabIndex = 2
        Me.btnPlaylist.Text = "A PLAYLIST"
        Me.btnPlaylist.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnBorrar.BackgroundImage = CType(resources.GetObject("btnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBorrar.Location = New System.Drawing.Point(1163, 73)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(24, 33)
        Me.btnBorrar.TabIndex = 127
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'live
        '
        Me.live.Location = New System.Drawing.Point(342, 277)
        Me.live.Name = "live"
        Me.live.Size = New System.Drawing.Size(51, 27)
        Me.live.TabIndex = 105
        Me.live.Text = "LIVE"
        Me.live.UseVisualStyleBackColor = True
        '
        'PanelTextos
        '
        Me.PanelTextos.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelTextos.Controls.Add(Me.Label10)
        Me.PanelTextos.Controls.Add(Me.Label9)
        Me.PanelTextos.Controls.Add(Me.Label7)
        Me.PanelTextos.Controls.Add(Me.txtCuerpo)
        Me.PanelTextos.Controls.Add(Me.posy)
        Me.PanelTextos.Controls.Add(Me.escala)
        Me.PanelTextos.Controls.Add(Me.txtSubtitulo)
        Me.PanelTextos.Controls.Add(Me.Label8)
        Me.PanelTextos.Controls.Add(Me.txtTitulo)
        Me.PanelTextos.Controls.Add(Me.posx)
        Me.PanelTextos.Location = New System.Drawing.Point(342, 310)
        Me.PanelTextos.Name = "PanelTextos"
        Me.PanelTextos.Size = New System.Drawing.Size(296, 201)
        Me.PanelTextos.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "TEXTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "ESCALA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "POS Y"
        '
        'txtCuerpo
        '
        Me.txtCuerpo.BackColor = System.Drawing.Color.White
        Me.txtCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuerpo.Location = New System.Drawing.Point(6, 85)
        Me.txtCuerpo.Multiline = False
        Me.txtCuerpo.Name = "txtCuerpo"
        Me.txtCuerpo.Size = New System.Drawing.Size(264, 58)
        Me.txtCuerpo.TabIndex = 93
        Me.txtCuerpo.Text = ""
        '
        'posy
        '
        Me.posy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posy.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.posy.Location = New System.Drawing.Point(202, 164)
        Me.posy.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.posy.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.posy.Name = "posy"
        Me.posy.Size = New System.Drawing.Size(70, 29)
        Me.posy.TabIndex = 96
        '
        'escala
        '
        Me.escala.DecimalPlaces = 2
        Me.escala.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.escala.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.escala.Location = New System.Drawing.Point(12, 164)
        Me.escala.Name = "escala"
        Me.escala.Size = New System.Drawing.Size(70, 29)
        Me.escala.TabIndex = 94
        Me.escala.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtSubtitulo
        '
        Me.txtSubtitulo.BackColor = System.Drawing.Color.White
        Me.txtSubtitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtitulo.Location = New System.Drawing.Point(7, 57)
        Me.txtSubtitulo.Name = "txtSubtitulo"
        Me.txtSubtitulo.Size = New System.Drawing.Size(263, 26)
        Me.txtSubtitulo.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(127, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "POS X"
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.White
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(7, 29)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(263, 26)
        Me.txtTitulo.TabIndex = 90
        '
        'posx
        '
        Me.posx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.posx.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.posx.Location = New System.Drawing.Point(129, 164)
        Me.posx.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.posx.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.posx.Name = "posx"
        Me.posx.Size = New System.Drawing.Size(70, 29)
        Me.posx.TabIndex = 95
        '
        'PicElemento
        '
        Me.PicElemento.Location = New System.Drawing.Point(372, 98)
        Me.PicElemento.Name = "PicElemento"
        Me.PicElemento.Size = New System.Drawing.Size(127, 84)
        Me.PicElemento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicElemento.TabIndex = 2
        Me.PicElemento.TabStop = False
        '
        'PicFondo
        '
        Me.PicFondo.Location = New System.Drawing.Point(342, 73)
        Me.PicFondo.Name = "PicFondo"
        Me.PicFondo.Size = New System.Drawing.Size(333, 141)
        Me.PicFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFondo.TabIndex = 1
        Me.PicFondo.TabStop = False
        '
        'objLISTPLAYLIST2
        '
        Me.objLISTPLAYLIST2.BackColor = System.Drawing.Color.LightGray
        Me.objLISTPLAYLIST2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader14, Me.ColumnHeader13})
        Me.objLISTPLAYLIST2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objLISTPLAYLIST2.ForeColor = System.Drawing.Color.Gray
        Me.objLISTPLAYLIST2.FullRowSelect = True
        Me.objLISTPLAYLIST2.GridLines = True
        Me.objLISTPLAYLIST2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.objLISTPLAYLIST2.HideSelection = False
        Me.objLISTPLAYLIST2.Location = New System.Drawing.Point(777, 444)
        Me.objLISTPLAYLIST2.Name = "objLISTPLAYLIST2"
        Me.objLISTPLAYLIST2.Size = New System.Drawing.Size(383, 67)
        Me.objLISTPLAYLIST2.TabIndex = 124
        Me.objLISTPLAYLIST2.UseCompatibleStateImageBehavior = False
        Me.objLISTPLAYLIST2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "INDEX"
        Me.ColumnHeader4.Width = 49
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "P1"
        Me.ColumnHeader6.Width = 97
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "P2"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "P3"
        Me.ColumnHeader14.Width = 87
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "LOGO"
        Me.ColumnHeader13.Width = 80
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.btnDownPlayer)
        Me.TabPage2.Controls.Add(Me.btnUpPlayer)
        Me.TabPage2.Controls.Add(Me.btnBorrarPlayer)
        Me.TabPage2.Controls.Add(Me.oblLISTPLAYER)
        Me.TabPage2.Controls.Add(Me.PicElementPlayer)
        Me.TabPage2.Controls.Add(Me.PicFondoPlayer)
        Me.TabPage2.Controls.Add(Me.Button22)
        Me.TabPage2.Controls.Add(Me.Button21)
        Me.TabPage2.Controls.Add(Me.Button17)
        Me.TabPage2.Controls.Add(Me.Button18)
        Me.TabPage2.Controls.Add(Me.Button19)
        Me.TabPage2.Controls.Add(Me.cmbEmision)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1379, 526)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PLAYER"
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(201, 28)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(91, 21)
        Me.Button22.TabIndex = 133
        Me.Button22.Text = "RELOAD"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(310, 18)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(82, 43)
        Me.Button21.TabIndex = 132
        Me.Button21.Text = "X"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button17.BackgroundImage = CType(resources.GetObject("Button17.BackgroundImage"), System.Drawing.Image)
        Me.Button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button17.Location = New System.Drawing.Point(1279, 155)
        Me.Button17.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(26, 39)
        Me.Button17.TabIndex = 131
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button18.BackgroundImage = CType(resources.GetObject("Button18.BackgroundImage"), System.Drawing.Image)
        Me.Button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.Color.Transparent
        Me.Button18.Location = New System.Drawing.Point(1279, 288)
        Me.Button18.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(26, 48)
        Me.Button18.TabIndex = 130
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.ForeColor = System.Drawing.Color.Transparent
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button19.Location = New System.Drawing.Point(1279, 223)
        Me.Button19.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(26, 48)
        Me.Button19.TabIndex = 129
        Me.Button19.UseVisualStyleBackColor = False
        '
        'cmbEmision
        '
        Me.cmbEmision.BackColor = System.Drawing.Color.White
        Me.cmbEmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmision.FormattingEnabled = True
        Me.cmbEmision.Location = New System.Drawing.Point(18, 24)
        Me.cmbEmision.Name = "cmbEmision"
        Me.cmbEmision.Size = New System.Drawing.Size(177, 28)
        Me.cmbEmision.TabIndex = 2
        '
        'PicElementPlayer
        '
        Me.PicElementPlayer.Location = New System.Drawing.Point(750, 92)
        Me.PicElementPlayer.Name = "PicElementPlayer"
        Me.PicElementPlayer.Size = New System.Drawing.Size(127, 84)
        Me.PicElementPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicElementPlayer.TabIndex = 135
        Me.PicElementPlayer.TabStop = False
        '
        'PicFondoPlayer
        '
        Me.PicFondoPlayer.Location = New System.Drawing.Point(720, 67)
        Me.PicFondoPlayer.Name = "PicFondoPlayer"
        Me.PicFondoPlayer.Size = New System.Drawing.Size(333, 141)
        Me.PicFondoPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFondoPlayer.TabIndex = 134
        Me.PicFondoPlayer.TabStop = False
        '
        'oblLISTPLAYER
        '
        Me.oblLISTPLAYER.BackColor = System.Drawing.Color.LightGray
        Me.oblLISTPLAYER.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.oblLISTPLAYER.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oblLISTPLAYER.ForeColor = System.Drawing.Color.Gray
        Me.oblLISTPLAYER.FullRowSelect = True
        Me.oblLISTPLAYER.GridLines = True
        Me.oblLISTPLAYER.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.oblLISTPLAYER.HideSelection = False
        Me.oblLISTPLAYER.Location = New System.Drawing.Point(18, 67)
        Me.oblLISTPLAYER.Name = "oblLISTPLAYER"
        Me.oblLISTPLAYER.Size = New System.Drawing.Size(696, 438)
        Me.oblLISTPLAYER.TabIndex = 136
        Me.oblLISTPLAYER.UseCompatibleStateImageBehavior = False
        Me.oblLISTPLAYER.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "INDEX"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IMAGEN"
        Me.ColumnHeader2.Width = 148
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FONDO"
        Me.ColumnHeader3.Width = 164
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "VIDEO 1"
        Me.ColumnHeader7.Width = 152
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "VIDEO 2"
        Me.ColumnHeader8.Width = 294
        '
        'btnDownPlayer
        '
        Me.btnDownPlayer.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnDownPlayer.BackgroundImage = CType(resources.GetObject("btnDownPlayer.BackgroundImage"), System.Drawing.Image)
        Me.btnDownPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownPlayer.ForeColor = System.Drawing.Color.Transparent
        Me.btnDownPlayer.Location = New System.Drawing.Point(720, 406)
        Me.btnDownPlayer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDownPlayer.Name = "btnDownPlayer"
        Me.btnDownPlayer.Size = New System.Drawing.Size(20, 33)
        Me.btnDownPlayer.TabIndex = 138
        Me.btnDownPlayer.UseVisualStyleBackColor = False
        '
        'btnUpPlayer
        '
        Me.btnUpPlayer.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnUpPlayer.BackgroundImage = CType(resources.GetObject("btnUpPlayer.BackgroundImage"), System.Drawing.Image)
        Me.btnUpPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpPlayer.ForeColor = System.Drawing.Color.Transparent
        Me.btnUpPlayer.Image = CType(resources.GetObject("btnUpPlayer.Image"), System.Drawing.Image)
        Me.btnUpPlayer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnUpPlayer.Location = New System.Drawing.Point(720, 365)
        Me.btnUpPlayer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpPlayer.Name = "btnUpPlayer"
        Me.btnUpPlayer.Size = New System.Drawing.Size(20, 33)
        Me.btnUpPlayer.TabIndex = 137
        Me.btnUpPlayer.UseVisualStyleBackColor = False
        '
        'btnBorrarPlayer
        '
        Me.btnBorrarPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnBorrarPlayer.BackgroundImage = CType(resources.GetObject("btnBorrarPlayer.BackgroundImage"), System.Drawing.Image)
        Me.btnBorrarPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBorrarPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarPlayer.Image = CType(resources.GetObject("btnBorrarPlayer.Image"), System.Drawing.Image)
        Me.btnBorrarPlayer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBorrarPlayer.Location = New System.Drawing.Point(720, 247)
        Me.btnBorrarPlayer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBorrarPlayer.Name = "btnBorrarPlayer"
        Me.btnBorrarPlayer.Size = New System.Drawing.Size(24, 33)
        Me.btnBorrarPlayer.TabIndex = 139
        Me.btnBorrarPlayer.UseVisualStyleBackColor = False
        '
        'ScreenControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1219, 579)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScreenControl"
        Me.Text = "ScreenControl"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.lstObjectEDICION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTextos.ResumeLayout(False)
        Me.PanelTextos.PerformLayout()
        CType(Me.posy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.escala, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.posx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicElemento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PicElementPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFondoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbEDICION As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PicElemento As PictureBox
    Friend WithEvents PicFondo As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbEmision As ComboBox
    Friend WithEvents PanelTextos As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCuerpo As RichTextBox
    Friend WithEvents posy As NumericUpDown
    Friend WithEvents escala As NumericUpDown
    Friend WithEvents txtSubtitulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents posx As NumericUpDown
    Friend WithEvents live As Button
    Friend WithEvents Buscador As OpenFileDialog
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents objLISTPLAYLIST2 As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents btnPlaylist As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents brnReload As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Carpetas As FolderBrowserDialog
    Friend WithEvents Button22 As Button
    Friend WithEvents lstObjectEDICION As BrightIdeasSoftware.ObjectListView
    Friend WithEvents objImagen1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents cmbFONDOS As ComboBox
    Friend WithEvents objLISTPLAYLIST As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents Label19 As Label
    Friend WithEvents PicElementPlayer As PictureBox
    Friend WithEvents PicFondoPlayer As PictureBox
    Friend WithEvents oblLISTPLAYER As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btnDownPlayer As Button
    Friend WithEvents btnUpPlayer As Button
    Friend WithEvents btnBorrarPlayer As Button
End Class
