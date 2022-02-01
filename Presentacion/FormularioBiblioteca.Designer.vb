<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBiblioteca
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
        Me.TabBiblioteca = New System.Windows.Forms.TabControl()
        Me.TabAgregarLibro = New System.Windows.Forms.TabPage()
        Me.TxtEdicionAgre = New System.Windows.Forms.TextBox()
        Me.TxtCodigoAgre = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.BtnAgregarLibro = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtStockAgre = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtTituloAgre = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.CboIdiomaAgre = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CboAreaAgre = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CboAutorAgre = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CboEditorialAgre = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabEditarLibro = New System.Windows.Forms.TabPage()
        Me.TxtEdicionEdit = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.CboCodigoEdit = New System.Windows.Forms.ComboBox()
        Me.btnAgreLibro = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TxtTituloEdit = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CboIdiomaEdit = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.CboAreaEdit = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.CboAutorEdit = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.CboEditorialEdit = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TabPrestamoLibro = New System.Windows.Forms.TabPage()
        Me.BtnBuscarAlumnoPre = New System.Windows.Forms.Button()
        Me.BtnPrestar = New System.Windows.Forms.Button()
        Me.ListBoxLibros = New System.Windows.Forms.CheckedListBox()
        Me.TxtEstadoPre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtCarreraPre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCicloPre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnAplicarFiltros = New System.Windows.Forms.Button()
        Me.CboIdioma = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboArea = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboAutor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboEditorial = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombrePre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoPre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabDevolucionLibro = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnBuscarAlumnoDev = New System.Windows.Forms.Button()
        Me.TxtEstadoDev = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCarreraDev = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCicloDev = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNombreDev = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtCodigoDev = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.TabPerdidaLibro = New System.Windows.Forms.TabPage()
        Me.BtnBuscarAlumnoPer = New System.Windows.Forms.Button()
        Me.TxtEstadoPer = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtCarreraPer = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtCicloPer = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtNombrePer = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtCodigoPer = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.TabBiblioteca.SuspendLayout()
        Me.TabAgregarLibro.SuspendLayout()
        Me.TabEditarLibro.SuspendLayout()
        Me.TabPrestamoLibro.SuspendLayout()
        Me.TabDevolucionLibro.SuspendLayout()
        Me.TabPerdidaLibro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabBiblioteca
        '
        Me.TabBiblioteca.Controls.Add(Me.TabAgregarLibro)
        Me.TabBiblioteca.Controls.Add(Me.TabEditarLibro)
        Me.TabBiblioteca.Controls.Add(Me.TabPrestamoLibro)
        Me.TabBiblioteca.Controls.Add(Me.TabDevolucionLibro)
        Me.TabBiblioteca.Controls.Add(Me.TabPerdidaLibro)
        Me.TabBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabBiblioteca.Location = New System.Drawing.Point(0, 0)
        Me.TabBiblioteca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabBiblioteca.Name = "TabBiblioteca"
        Me.TabBiblioteca.SelectedIndex = 0
        Me.TabBiblioteca.Size = New System.Drawing.Size(915, 566)
        Me.TabBiblioteca.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabBiblioteca.TabIndex = 2
        '
        'TabAgregarLibro
        '
        Me.TabAgregarLibro.Controls.Add(Me.TxtEdicionAgre)
        Me.TabAgregarLibro.Controls.Add(Me.TxtCodigoAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label48)
        Me.TabAgregarLibro.Controls.Add(Me.BtnAgregarLibro)
        Me.TabAgregarLibro.Controls.Add(Me.Label34)
        Me.TabAgregarLibro.Controls.Add(Me.TxtStockAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label35)
        Me.TabAgregarLibro.Controls.Add(Me.TxtTituloAgre)
        Me.TabAgregarLibro.Controls.Add(Me.LblTitulo)
        Me.TabAgregarLibro.Controls.Add(Me.CboIdiomaAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label36)
        Me.TabAgregarLibro.Controls.Add(Me.CboAreaAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label37)
        Me.TabAgregarLibro.Controls.Add(Me.CboAutorAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label38)
        Me.TabAgregarLibro.Controls.Add(Me.CboEditorialAgre)
        Me.TabAgregarLibro.Controls.Add(Me.Label39)
        Me.TabAgregarLibro.Location = New System.Drawing.Point(4, 25)
        Me.TabAgregarLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabAgregarLibro.Name = "TabAgregarLibro"
        Me.TabAgregarLibro.Size = New System.Drawing.Size(907, 537)
        Me.TabAgregarLibro.TabIndex = 3
        Me.TabAgregarLibro.Text = "Agregar Libro"
        Me.TabAgregarLibro.UseVisualStyleBackColor = True
        '
        'TxtEdicionAgre
        '
        Me.TxtEdicionAgre.Location = New System.Drawing.Point(225, 298)
        Me.TxtEdicionAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEdicionAgre.Name = "TxtEdicionAgre"
        Me.TxtEdicionAgre.Size = New System.Drawing.Size(160, 22)
        Me.TxtEdicionAgre.TabIndex = 48
        '
        'TxtCodigoAgre
        '
        Me.TxtCodigoAgre.Location = New System.Drawing.Point(165, 62)
        Me.TxtCodigoAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoAgre.Name = "TxtCodigoAgre"
        Me.TxtCodigoAgre.Size = New System.Drawing.Size(115, 22)
        Me.TxtCodigoAgre.TabIndex = 47
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(104, 65)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(52, 17)
        Me.Label48.TabIndex = 46
        Me.Label48.Text = "Código"
        '
        'BtnAgregarLibro
        '
        Me.BtnAgregarLibro.Location = New System.Drawing.Point(361, 370)
        Me.BtnAgregarLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgregarLibro.Name = "BtnAgregarLibro"
        Me.BtnAgregarLibro.Size = New System.Drawing.Size(140, 28)
        Me.BtnAgregarLibro.TabIndex = 45
        Me.BtnAgregarLibro.Text = "Agregar Libro"
        Me.BtnAgregarLibro.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(161, 302)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 17)
        Me.Label34.TabIndex = 43
        Me.Label34.Text = "Edición"
        '
        'TxtStockAgre
        '
        Me.TxtStockAgre.Location = New System.Drawing.Point(523, 298)
        Me.TxtStockAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtStockAgre.Name = "TxtStockAgre"
        Me.TxtStockAgre.Size = New System.Drawing.Size(160, 22)
        Me.TxtStockAgre.TabIndex = 42
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(468, 302)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(43, 17)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "Stock"
        '
        'TxtTituloAgre
        '
        Me.TxtTituloAgre.Location = New System.Drawing.Point(373, 62)
        Me.TxtTituloAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTituloAgre.Name = "TxtTituloAgre"
        Me.TxtTituloAgre.Size = New System.Drawing.Size(359, 22)
        Me.TxtTituloAgre.TabIndex = 40
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Location = New System.Drawing.Point(319, 65)
        Me.LblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(43, 17)
        Me.LblTitulo.TabIndex = 39
        Me.LblTitulo.Text = "Título"
        '
        'CboIdiomaAgre
        '
        Me.CboIdiomaAgre.FormattingEnabled = True
        Me.CboIdiomaAgre.Items.AddRange(New Object() {"1"})
        Me.CboIdiomaAgre.Location = New System.Drawing.Point(523, 240)
        Me.CboIdiomaAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdiomaAgre.Name = "CboIdiomaAgre"
        Me.CboIdiomaAgre.Size = New System.Drawing.Size(160, 24)
        Me.CboIdiomaAgre.TabIndex = 38
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(464, 244)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 17)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "Idioma"
        '
        'CboAreaAgre
        '
        Me.CboAreaAgre.FormattingEnabled = True
        Me.CboAreaAgre.Items.AddRange(New Object() {"1"})
        Me.CboAreaAgre.Location = New System.Drawing.Point(225, 240)
        Me.CboAreaAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAreaAgre.Name = "CboAreaAgre"
        Me.CboAreaAgre.Size = New System.Drawing.Size(160, 24)
        Me.CboAreaAgre.TabIndex = 36
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(179, 244)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(38, 17)
        Me.Label37.TabIndex = 35
        Me.Label37.Text = "Area"
        '
        'CboAutorAgre
        '
        Me.CboAutorAgre.FormattingEnabled = True
        Me.CboAutorAgre.Items.AddRange(New Object() {"1"})
        Me.CboAutorAgre.Location = New System.Drawing.Point(500, 153)
        Me.CboAutorAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAutorAgre.Name = "CboAutorAgre"
        Me.CboAutorAgre.Size = New System.Drawing.Size(232, 24)
        Me.CboAutorAgre.TabIndex = 34
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(449, 156)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 17)
        Me.Label38.TabIndex = 33
        Me.Label38.Text = "Autor"
        '
        'CboEditorialAgre
        '
        Me.CboEditorialAgre.FormattingEnabled = True
        Me.CboEditorialAgre.Items.AddRange(New Object() {"1"})
        Me.CboEditorialAgre.Location = New System.Drawing.Point(165, 153)
        Me.CboEditorialAgre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboEditorialAgre.Name = "CboEditorialAgre"
        Me.CboEditorialAgre.Size = New System.Drawing.Size(237, 24)
        Me.CboEditorialAgre.TabIndex = 32
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(99, 156)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(59, 17)
        Me.Label39.TabIndex = 31
        Me.Label39.Text = "Editorial"
        '
        'TabEditarLibro
        '
        Me.TabEditarLibro.Controls.Add(Me.TxtEdicionEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label47)
        Me.TabEditarLibro.Controls.Add(Me.CboCodigoEdit)
        Me.TabEditarLibro.Controls.Add(Me.btnAgreLibro)
        Me.TabEditarLibro.Controls.Add(Me.Label40)
        Me.TabEditarLibro.Controls.Add(Me.TxtTituloEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label42)
        Me.TabEditarLibro.Controls.Add(Me.CboIdiomaEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label43)
        Me.TabEditarLibro.Controls.Add(Me.CboAreaEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label44)
        Me.TabEditarLibro.Controls.Add(Me.CboAutorEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label45)
        Me.TabEditarLibro.Controls.Add(Me.CboEditorialEdit)
        Me.TabEditarLibro.Controls.Add(Me.Label46)
        Me.TabEditarLibro.Location = New System.Drawing.Point(4, 25)
        Me.TabEditarLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabEditarLibro.Name = "TabEditarLibro"
        Me.TabEditarLibro.Size = New System.Drawing.Size(907, 537)
        Me.TabEditarLibro.TabIndex = 4
        Me.TabEditarLibro.Text = "Editar Libro"
        Me.TabEditarLibro.UseVisualStyleBackColor = True
        '
        'TxtEdicionEdit
        '
        Me.TxtEdicionEdit.Location = New System.Drawing.Point(347, 311)
        Me.TxtEdicionEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEdicionEdit.Name = "TxtEdicionEdit"
        Me.TxtEdicionEdit.Size = New System.Drawing.Size(237, 22)
        Me.TxtEdicionEdit.TabIndex = 63
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(103, 116)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(52, 17)
        Me.Label47.TabIndex = 62
        Me.Label47.Text = "Código"
        '
        'CboCodigoEdit
        '
        Me.CboCodigoEdit.FormattingEnabled = True
        Me.CboCodigoEdit.Items.AddRange(New Object() {"2272 - GAAAA", "ab12 - programacion 1"})
        Me.CboCodigoEdit.Location = New System.Drawing.Point(179, 57)
        Me.CboCodigoEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboCodigoEdit.Name = "CboCodigoEdit"
        Me.CboCodigoEdit.Size = New System.Drawing.Size(567, 24)
        Me.CboCodigoEdit.TabIndex = 61
        '
        'btnAgreLibro
        '
        Me.btnAgreLibro.Location = New System.Drawing.Point(375, 417)
        Me.btnAgreLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgreLibro.Name = "btnAgreLibro"
        Me.btnAgreLibro.Size = New System.Drawing.Size(140, 28)
        Me.btnAgreLibro.TabIndex = 60
        Me.btnAgreLibro.Text = "Editar Libro"
        Me.btnAgreLibro.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(283, 315)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(54, 17)
        Me.Label40.TabIndex = 58
        Me.Label40.Text = "Edición"
        '
        'TxtTituloEdit
        '
        Me.TxtTituloEdit.Enabled = False
        Me.TxtTituloEdit.Location = New System.Drawing.Point(179, 116)
        Me.TxtTituloEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTituloEdit.Name = "TxtTituloEdit"
        Me.TxtTituloEdit.Size = New System.Drawing.Size(142, 22)
        Me.TxtTituloEdit.TabIndex = 55
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(112, 60)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(43, 17)
        Me.Label42.TabIndex = 54
        Me.Label42.Text = "Título"
        '
        'CboIdiomaEdit
        '
        Me.CboIdiomaEdit.FormattingEnabled = True
        Me.CboIdiomaEdit.Location = New System.Drawing.Point(513, 244)
        Me.CboIdiomaEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdiomaEdit.Name = "CboIdiomaEdit"
        Me.CboIdiomaEdit.Size = New System.Drawing.Size(232, 24)
        Me.CboIdiomaEdit.TabIndex = 53
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(455, 247)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(49, 17)
        Me.Label43.TabIndex = 52
        Me.Label43.Text = "Idioma"
        '
        'CboAreaEdit
        '
        Me.CboAreaEdit.FormattingEnabled = True
        Me.CboAreaEdit.Location = New System.Drawing.Point(179, 244)
        Me.CboAreaEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAreaEdit.Name = "CboAreaEdit"
        Me.CboAreaEdit.Size = New System.Drawing.Size(237, 24)
        Me.CboAreaEdit.TabIndex = 51
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(132, 247)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(38, 17)
        Me.Label44.TabIndex = 50
        Me.Label44.Text = "Area"
        '
        'CboAutorEdit
        '
        Me.CboAutorEdit.FormattingEnabled = True
        Me.CboAutorEdit.Location = New System.Drawing.Point(513, 174)
        Me.CboAutorEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAutorEdit.Name = "CboAutorEdit"
        Me.CboAutorEdit.Size = New System.Drawing.Size(232, 24)
        Me.CboAutorEdit.TabIndex = 49
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(463, 177)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(42, 17)
        Me.Label45.TabIndex = 48
        Me.Label45.Text = "Autor"
        '
        'CboEditorialEdit
        '
        Me.CboEditorialEdit.FormattingEnabled = True
        Me.CboEditorialEdit.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CboEditorialEdit.Location = New System.Drawing.Point(179, 174)
        Me.CboEditorialEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboEditorialEdit.Name = "CboEditorialEdit"
        Me.CboEditorialEdit.Size = New System.Drawing.Size(237, 24)
        Me.CboEditorialEdit.TabIndex = 47
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(112, 177)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(59, 17)
        Me.Label46.TabIndex = 46
        Me.Label46.Text = "Editorial"
        '
        'TabPrestamoLibro
        '
        Me.TabPrestamoLibro.Controls.Add(Me.BtnBuscarAlumnoPre)
        Me.TabPrestamoLibro.Controls.Add(Me.BtnPrestar)
        Me.TabPrestamoLibro.Controls.Add(Me.ListBoxLibros)
        Me.TabPrestamoLibro.Controls.Add(Me.TxtEstadoPre)
        Me.TabPrestamoLibro.Controls.Add(Me.Label13)
        Me.TabPrestamoLibro.Controls.Add(Me.TxtCarreraPre)
        Me.TabPrestamoLibro.Controls.Add(Me.Label12)
        Me.TabPrestamoLibro.Controls.Add(Me.TxtCicloPre)
        Me.TabPrestamoLibro.Controls.Add(Me.Label11)
        Me.TabPrestamoLibro.Controls.Add(Me.BtnAplicarFiltros)
        Me.TabPrestamoLibro.Controls.Add(Me.CboIdioma)
        Me.TabPrestamoLibro.Controls.Add(Me.Label8)
        Me.TabPrestamoLibro.Controls.Add(Me.CboArea)
        Me.TabPrestamoLibro.Controls.Add(Me.Label7)
        Me.TabPrestamoLibro.Controls.Add(Me.CboAutor)
        Me.TabPrestamoLibro.Controls.Add(Me.Label6)
        Me.TabPrestamoLibro.Controls.Add(Me.CboEditorial)
        Me.TabPrestamoLibro.Controls.Add(Me.Label5)
        Me.TabPrestamoLibro.Controls.Add(Me.Label4)
        Me.TabPrestamoLibro.Controls.Add(Me.Label3)
        Me.TabPrestamoLibro.Controls.Add(Me.TxtNombrePre)
        Me.TabPrestamoLibro.Controls.Add(Me.Label2)
        Me.TabPrestamoLibro.Controls.Add(Me.TxtCodigoPre)
        Me.TabPrestamoLibro.Controls.Add(Me.Label1)
        Me.TabPrestamoLibro.Location = New System.Drawing.Point(4, 25)
        Me.TabPrestamoLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPrestamoLibro.Name = "TabPrestamoLibro"
        Me.TabPrestamoLibro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPrestamoLibro.Size = New System.Drawing.Size(907, 537)
        Me.TabPrestamoLibro.TabIndex = 0
        Me.TabPrestamoLibro.Text = "Préstamo"
        Me.TabPrestamoLibro.UseVisualStyleBackColor = True
        '
        'BtnBuscarAlumnoPre
        '
        Me.BtnBuscarAlumnoPre.Location = New System.Drawing.Point(317, 48)
        Me.BtnBuscarAlumnoPre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBuscarAlumnoPre.Name = "BtnBuscarAlumnoPre"
        Me.BtnBuscarAlumnoPre.Size = New System.Drawing.Size(77, 28)
        Me.BtnBuscarAlumnoPre.TabIndex = 32
        Me.BtnBuscarAlumnoPre.Text = "Buscar"
        Me.BtnBuscarAlumnoPre.UseVisualStyleBackColor = True
        '
        'BtnPrestar
        '
        Me.BtnPrestar.Location = New System.Drawing.Point(396, 480)
        Me.BtnPrestar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPrestar.Name = "BtnPrestar"
        Me.BtnPrestar.Size = New System.Drawing.Size(100, 28)
        Me.BtnPrestar.TabIndex = 30
        Me.BtnPrestar.Text = "Jaja prestar"
        Me.BtnPrestar.UseVisualStyleBackColor = True
        '
        'ListBoxLibros
        '
        Me.ListBoxLibros.FormattingEnabled = True
        Me.ListBoxLibros.Items.AddRange(New Object() {"Gaaa", "1", "2", "3"})
        Me.ListBoxLibros.Location = New System.Drawing.Point(109, 348)
        Me.ListBoxLibros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxLibros.Name = "ListBoxLibros"
        Me.ListBoxLibros.Size = New System.Drawing.Size(644, 106)
        Me.ListBoxLibros.TabIndex = 28
        '
        'TxtEstadoPre
        '
        Me.TxtEstadoPre.Enabled = False
        Me.TxtEstadoPre.Location = New System.Drawing.Point(680, 96)
        Me.TxtEstadoPre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEstadoPre.Name = "TxtEstadoPre"
        Me.TxtEstadoPre.ReadOnly = True
        Me.TxtEstadoPre.Size = New System.Drawing.Size(159, 22)
        Me.TxtEstadoPre.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(619, 100)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 17)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Estado"
        '
        'TxtCarreraPre
        '
        Me.TxtCarreraPre.Enabled = False
        Me.TxtCarreraPre.Location = New System.Drawing.Point(623, 50)
        Me.TxtCarreraPre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCarreraPre.Name = "TxtCarreraPre"
        Me.TxtCarreraPre.ReadOnly = True
        Me.TxtCarreraPre.Size = New System.Drawing.Size(216, 22)
        Me.TxtCarreraPre.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(560, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Carrera"
        '
        'TxtCicloPre
        '
        Me.TxtCicloPre.Enabled = False
        Me.TxtCicloPre.Location = New System.Drawing.Point(472, 50)
        Me.TxtCicloPre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCicloPre.Name = "TxtCicloPre"
        Me.TxtCicloPre.ReadOnly = True
        Me.TxtCicloPre.Size = New System.Drawing.Size(57, 22)
        Me.TxtCicloPre.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(424, 54)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Ciclo"
        '
        'BtnAplicarFiltros
        '
        Me.BtnAplicarFiltros.Location = New System.Drawing.Point(348, 290)
        Me.BtnAplicarFiltros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAplicarFiltros.Name = "BtnAplicarFiltros"
        Me.BtnAplicarFiltros.Size = New System.Drawing.Size(187, 28)
        Me.BtnAplicarFiltros.TabIndex = 16
        Me.BtnAplicarFiltros.Text = "Aplicar Filtros"
        Me.BtnAplicarFiltros.UseVisualStyleBackColor = True
        '
        'CboIdioma
        '
        Me.CboIdioma.FormattingEnabled = True
        Me.CboIdioma.Location = New System.Drawing.Point(543, 241)
        Me.CboIdioma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdioma.Name = "CboIdioma"
        Me.CboIdioma.Size = New System.Drawing.Size(160, 24)
        Me.CboIdioma.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(493, 245)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Idioma"
        '
        'CboArea
        '
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Location = New System.Drawing.Point(245, 241)
        Me.CboArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(160, 24)
        Me.CboArea.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 245)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Area"
        '
        'CboAutor
        '
        Me.CboAutor.FormattingEnabled = True
        Me.CboAutor.Location = New System.Drawing.Point(543, 187)
        Me.CboAutor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboAutor.Name = "CboAutor"
        Me.CboAutor.Size = New System.Drawing.Size(160, 24)
        Me.CboAutor.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(492, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Autor"
        '
        'CboEditorial
        '
        Me.CboEditorial.FormattingEnabled = True
        Me.CboEditorial.Location = New System.Drawing.Point(245, 187)
        Me.CboEditorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboEditorial.Name = "CboEditorial"
        Me.CboEditorial.Size = New System.Drawing.Size(160, 24)
        Me.CboEditorial.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Editorial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtros:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Libros"
        '
        'TxtNombrePre
        '
        Me.TxtNombrePre.Enabled = False
        Me.TxtNombrePre.Location = New System.Drawing.Point(136, 96)
        Me.TxtNombrePre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombrePre.Name = "TxtNombrePre"
        Me.TxtNombrePre.ReadOnly = True
        Me.TxtNombrePre.Size = New System.Drawing.Size(436, 22)
        Me.TxtNombrePre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alumno"
        '
        'TxtCodigoPre
        '
        Me.TxtCodigoPre.Location = New System.Drawing.Point(136, 50)
        Me.TxtCodigoPre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoPre.Name = "TxtCodigoPre"
        Me.TxtCodigoPre.Size = New System.Drawing.Size(164, 22)
        Me.TxtCodigoPre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'TabDevolucionLibro
        '
        Me.TabDevolucionLibro.Controls.Add(Me.Button3)
        Me.TabDevolucionLibro.Controls.Add(Me.BtnBuscarAlumnoDev)
        Me.TabDevolucionLibro.Controls.Add(Me.TxtEstadoDev)
        Me.TabDevolucionLibro.Controls.Add(Me.Label9)
        Me.TabDevolucionLibro.Controls.Add(Me.TxtCarreraDev)
        Me.TabDevolucionLibro.Controls.Add(Me.Label10)
        Me.TabDevolucionLibro.Controls.Add(Me.TxtCicloDev)
        Me.TabDevolucionLibro.Controls.Add(Me.Label14)
        Me.TabDevolucionLibro.Controls.Add(Me.TxtNombreDev)
        Me.TabDevolucionLibro.Controls.Add(Me.Label15)
        Me.TabDevolucionLibro.Controls.Add(Me.TxtCodigoDev)
        Me.TabDevolucionLibro.Controls.Add(Me.Label16)
        Me.TabDevolucionLibro.Controls.Add(Me.Button2)
        Me.TabDevolucionLibro.Controls.Add(Me.CheckedListBox3)
        Me.TabDevolucionLibro.Location = New System.Drawing.Point(4, 25)
        Me.TabDevolucionLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabDevolucionLibro.Name = "TabDevolucionLibro"
        Me.TabDevolucionLibro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabDevolucionLibro.Size = New System.Drawing.Size(907, 537)
        Me.TabDevolucionLibro.TabIndex = 1
        Me.TabDevolucionLibro.Text = "Devolución"
        Me.TabDevolucionLibro.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(396, 398)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 28)
        Me.Button3.TabIndex = 76
        Me.Button3.Text = "Jaja prestado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnBuscarAlumnoDev
        '
        Me.BtnBuscarAlumnoDev.Location = New System.Drawing.Point(327, 49)
        Me.BtnBuscarAlumnoDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBuscarAlumnoDev.Name = "BtnBuscarAlumnoDev"
        Me.BtnBuscarAlumnoDev.Size = New System.Drawing.Size(77, 28)
        Me.BtnBuscarAlumnoDev.TabIndex = 75
        Me.BtnBuscarAlumnoDev.Text = "Buscar"
        Me.BtnBuscarAlumnoDev.UseVisualStyleBackColor = True
        '
        'TxtEstadoDev
        '
        Me.TxtEstadoDev.Enabled = False
        Me.TxtEstadoDev.Location = New System.Drawing.Point(689, 97)
        Me.TxtEstadoDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEstadoDev.Name = "TxtEstadoDev"
        Me.TxtEstadoDev.ReadOnly = True
        Me.TxtEstadoDev.Size = New System.Drawing.Size(159, 22)
        Me.TxtEstadoDev.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(628, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Estado"
        '
        'TxtCarreraDev
        '
        Me.TxtCarreraDev.Enabled = False
        Me.TxtCarreraDev.Location = New System.Drawing.Point(632, 52)
        Me.TxtCarreraDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCarreraDev.Name = "TxtCarreraDev"
        Me.TxtCarreraDev.ReadOnly = True
        Me.TxtCarreraDev.Size = New System.Drawing.Size(216, 22)
        Me.TxtCarreraDev.TabIndex = 72
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(569, 55)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Carrera"
        '
        'TxtCicloDev
        '
        Me.TxtCicloDev.Enabled = False
        Me.TxtCicloDev.Location = New System.Drawing.Point(481, 52)
        Me.TxtCicloDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCicloDev.Name = "TxtCicloDev"
        Me.TxtCicloDev.ReadOnly = True
        Me.TxtCicloDev.Size = New System.Drawing.Size(57, 22)
        Me.TxtCicloDev.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(433, 55)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 17)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Ciclo"
        '
        'TxtNombreDev
        '
        Me.TxtNombreDev.Enabled = False
        Me.TxtNombreDev.Location = New System.Drawing.Point(145, 97)
        Me.TxtNombreDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombreDev.Name = "TxtNombreDev"
        Me.TxtNombreDev.ReadOnly = True
        Me.TxtNombreDev.Size = New System.Drawing.Size(436, 22)
        Me.TxtNombreDev.TabIndex = 68
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(64, 101)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Alumno"
        '
        'TxtCodigoDev
        '
        Me.TxtCodigoDev.Location = New System.Drawing.Point(145, 52)
        Me.TxtCodigoDev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoDev.Name = "TxtCodigoDev"
        Me.TxtCodigoDev.Size = New System.Drawing.Size(164, 22)
        Me.TxtCodigoDev.TabIndex = 66
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(64, 55)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Código"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 530)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 28)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Jaja devolver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Items.AddRange(New Object() {"Gaaa", "1", "2", "3"})
        Me.CheckedListBox3.Location = New System.Drawing.Point(128, 235)
        Me.CheckedListBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(644, 106)
        Me.CheckedListBox3.TabIndex = 41
        '
        'TabPerdidaLibro
        '
        Me.TabPerdidaLibro.Controls.Add(Me.BtnBuscarAlumnoPer)
        Me.TabPerdidaLibro.Controls.Add(Me.TxtEstadoPer)
        Me.TabPerdidaLibro.Controls.Add(Me.Label29)
        Me.TabPerdidaLibro.Controls.Add(Me.TxtCarreraPer)
        Me.TabPerdidaLibro.Controls.Add(Me.Label30)
        Me.TabPerdidaLibro.Controls.Add(Me.TxtCicloPer)
        Me.TabPerdidaLibro.Controls.Add(Me.Label31)
        Me.TabPerdidaLibro.Controls.Add(Me.TxtNombrePer)
        Me.TabPerdidaLibro.Controls.Add(Me.Label32)
        Me.TabPerdidaLibro.Controls.Add(Me.TxtCodigoPer)
        Me.TabPerdidaLibro.Controls.Add(Me.Label33)
        Me.TabPerdidaLibro.Controls.Add(Me.Button7)
        Me.TabPerdidaLibro.Controls.Add(Me.CheckedListBox2)
        Me.TabPerdidaLibro.Location = New System.Drawing.Point(4, 25)
        Me.TabPerdidaLibro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPerdidaLibro.Name = "TabPerdidaLibro"
        Me.TabPerdidaLibro.Size = New System.Drawing.Size(907, 537)
        Me.TabPerdidaLibro.TabIndex = 2
        Me.TabPerdidaLibro.Text = "Pérdida"
        Me.TabPerdidaLibro.UseVisualStyleBackColor = True
        '
        'BtnBuscarAlumnoPer
        '
        Me.BtnBuscarAlumnoPer.Location = New System.Drawing.Point(320, 46)
        Me.BtnBuscarAlumnoPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBuscarAlumnoPer.Name = "BtnBuscarAlumnoPer"
        Me.BtnBuscarAlumnoPer.Size = New System.Drawing.Size(77, 28)
        Me.BtnBuscarAlumnoPer.TabIndex = 99
        Me.BtnBuscarAlumnoPer.Text = "Buscar"
        Me.BtnBuscarAlumnoPer.UseVisualStyleBackColor = True
        '
        'TxtEstadoPer
        '
        Me.TxtEstadoPer.Enabled = False
        Me.TxtEstadoPer.Location = New System.Drawing.Point(683, 94)
        Me.TxtEstadoPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtEstadoPer.Name = "TxtEstadoPer"
        Me.TxtEstadoPer.ReadOnly = True
        Me.TxtEstadoPer.Size = New System.Drawing.Size(159, 22)
        Me.TxtEstadoPer.TabIndex = 98
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(621, 97)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 17)
        Me.Label29.TabIndex = 97
        Me.Label29.Text = "Estado"
        '
        'TxtCarreraPer
        '
        Me.TxtCarreraPer.Enabled = False
        Me.TxtCarreraPer.Location = New System.Drawing.Point(625, 48)
        Me.TxtCarreraPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCarreraPer.Name = "TxtCarreraPer"
        Me.TxtCarreraPer.ReadOnly = True
        Me.TxtCarreraPer.Size = New System.Drawing.Size(216, 22)
        Me.TxtCarreraPer.TabIndex = 96
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(563, 52)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 17)
        Me.Label30.TabIndex = 95
        Me.Label30.Text = "Carrera"
        '
        'TxtCicloPer
        '
        Me.TxtCicloPer.Enabled = False
        Me.TxtCicloPer.Location = New System.Drawing.Point(475, 48)
        Me.TxtCicloPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCicloPer.Name = "TxtCicloPer"
        Me.TxtCicloPer.ReadOnly = True
        Me.TxtCicloPer.Size = New System.Drawing.Size(57, 22)
        Me.TxtCicloPer.TabIndex = 94
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(427, 52)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 17)
        Me.Label31.TabIndex = 93
        Me.Label31.Text = "Ciclo"
        '
        'TxtNombrePer
        '
        Me.TxtNombrePer.Enabled = False
        Me.TxtNombrePer.Location = New System.Drawing.Point(139, 94)
        Me.TxtNombrePer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombrePer.Name = "TxtNombrePer"
        Me.TxtNombrePer.ReadOnly = True
        Me.TxtNombrePer.Size = New System.Drawing.Size(436, 22)
        Me.TxtNombrePer.TabIndex = 92
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(57, 97)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(55, 17)
        Me.Label32.TabIndex = 91
        Me.Label32.Text = "Alumno"
        '
        'TxtCodigoPer
        '
        Me.TxtCodigoPer.Location = New System.Drawing.Point(139, 48)
        Me.TxtCodigoPer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoPer.Name = "TxtCodigoPer"
        Me.TxtCodigoPer.Size = New System.Drawing.Size(164, 22)
        Me.TxtCodigoPer.TabIndex = 90
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(57, 52)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 17)
        Me.Label33.TabIndex = 89
        Me.Label33.Text = "Código"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(389, 382)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(144, 28)
        Me.Button7.TabIndex = 66
        Me.Button7.Text = "Jaja perdido"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Gaaa", "1", "2", "3"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(139, 220)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(644, 106)
        Me.CheckedListBox2.TabIndex = 65
        '
        'FrmBiblioteca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 566)
        Me.Controls.Add(Me.TabBiblioteca)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmBiblioteca"
        Me.Text = "FormularioBiblioteca"
        Me.TabBiblioteca.ResumeLayout(False)
        Me.TabAgregarLibro.ResumeLayout(False)
        Me.TabAgregarLibro.PerformLayout()
        Me.TabEditarLibro.ResumeLayout(False)
        Me.TabEditarLibro.PerformLayout()
        Me.TabPrestamoLibro.ResumeLayout(False)
        Me.TabPrestamoLibro.PerformLayout()
        Me.TabDevolucionLibro.ResumeLayout(False)
        Me.TabDevolucionLibro.PerformLayout()
        Me.TabPerdidaLibro.ResumeLayout(False)
        Me.TabPerdidaLibro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabBiblioteca As Windows.Forms.TabControl
    Friend WithEvents TabPrestamoLibro As Windows.Forms.TabPage
    Friend WithEvents BtnPrestar As Windows.Forms.Button
    Friend WithEvents ListBoxLibros As Windows.Forms.CheckedListBox
    Friend WithEvents TxtEstadoPre As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents TxtCarreraPre As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents TxtCicloPre As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents BtnAplicarFiltros As Windows.Forms.Button
    Friend WithEvents CboIdioma As Windows.Forms.ComboBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents CboArea As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents CboAutor As Windows.Forms.ComboBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents CboEditorial As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents TxtNombrePre As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TxtCodigoPre As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TabDevolucionLibro As Windows.Forms.TabPage
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents CheckedListBox3 As Windows.Forms.CheckedListBox
    Friend WithEvents TabPerdidaLibro As Windows.Forms.TabPage
    Friend WithEvents TabAgregarLibro As Windows.Forms.TabPage
    Friend WithEvents BtnAgregarLibro As Windows.Forms.Button
    Friend WithEvents Label34 As Windows.Forms.Label
    Friend WithEvents TxtStockAgre As Windows.Forms.TextBox
    Friend WithEvents Label35 As Windows.Forms.Label
    Friend WithEvents TxtTituloAgre As Windows.Forms.TextBox
    Friend WithEvents LblTitulo As Windows.Forms.Label
    Friend WithEvents CboIdiomaAgre As Windows.Forms.ComboBox
    Friend WithEvents Label36 As Windows.Forms.Label
    Friend WithEvents CboAreaAgre As Windows.Forms.ComboBox
    Friend WithEvents Label37 As Windows.Forms.Label
    Friend WithEvents CboAutorAgre As Windows.Forms.ComboBox
    Friend WithEvents Label38 As Windows.Forms.Label
    Friend WithEvents CboEditorialAgre As Windows.Forms.ComboBox
    Friend WithEvents Label39 As Windows.Forms.Label
    Friend WithEvents BtnBuscarAlumnoPre As Windows.Forms.Button
    Friend WithEvents Button7 As Windows.Forms.Button
    Friend WithEvents CheckedListBox2 As Windows.Forms.CheckedListBox
    Friend WithEvents TabEditarLibro As Windows.Forms.TabPage
    Friend WithEvents btnAgreLibro As Windows.Forms.Button
    Friend WithEvents Label40 As Windows.Forms.Label
    Friend WithEvents TxtTituloEdit As Windows.Forms.TextBox
    Friend WithEvents Label42 As Windows.Forms.Label
    Friend WithEvents CboIdiomaEdit As Windows.Forms.ComboBox
    Friend WithEvents Label43 As Windows.Forms.Label
    Friend WithEvents CboAreaEdit As Windows.Forms.ComboBox
    Friend WithEvents Label44 As Windows.Forms.Label
    Friend WithEvents CboAutorEdit As Windows.Forms.ComboBox
    Friend WithEvents Label45 As Windows.Forms.Label
    Friend WithEvents CboEditorialEdit As Windows.Forms.ComboBox
    Friend WithEvents Label46 As Windows.Forms.Label
    Friend WithEvents Label47 As Windows.Forms.Label
    Friend WithEvents CboCodigoEdit As Windows.Forms.ComboBox
    Friend WithEvents TxtCodigoAgre As Windows.Forms.TextBox
    Friend WithEvents Label48 As Windows.Forms.Label
    Friend WithEvents BtnBuscarAlumnoDev As Windows.Forms.Button
    Friend WithEvents TxtEstadoDev As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtCarreraDev As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtCicloDev As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents TxtNombreDev As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents TxtCodigoDev As Windows.Forms.TextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents BtnBuscarAlumnoPer As Windows.Forms.Button
    Friend WithEvents TxtEstadoPer As Windows.Forms.TextBox
    Friend WithEvents Label29 As Windows.Forms.Label
    Friend WithEvents TxtCarreraPer As Windows.Forms.TextBox
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents TxtCicloPer As Windows.Forms.TextBox
    Friend WithEvents Label31 As Windows.Forms.Label
    Friend WithEvents TxtNombrePer As Windows.Forms.TextBox
    Friend WithEvents Label32 As Windows.Forms.Label
    Friend WithEvents TxtCodigoPer As Windows.Forms.TextBox
    Friend WithEvents Label33 As Windows.Forms.Label
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents TxtEdicionAgre As Windows.Forms.TextBox
    Friend WithEvents TxtEdicionEdit As Windows.Forms.TextBox
End Class
