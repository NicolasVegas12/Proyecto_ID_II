Imports LogicaNegocios
Imports Entidades
Imports System.Data
Public Class FrmBiblioteca
    Private Sub BtnBuscarAlumnoxCodigo_Click(sender As Object, e As EventArgs) Handles BtnBuscarAlumnoPre.Click
        Dim objA As String
        Dim AlumnosLN As New AlumnosLN
        objA = TxtCodigoPre.Text


        If TxtCodigoPre.Text <> "" Then
            If AlumnosLN.ObtenerAlumnoLN(objA).Rows.Count > 0 Then
                TxtNombrePre.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(3)
                TxtCicloPre.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(1)
                TxtCarreraPre.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(2)
                TxtEstadoPre.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(4)
                TxtCodigoPre.Enabled = False
                BtnBuscarAlumnoPre.Enabled = False
                BtnPrestar.Enabled = True
            Else
                MsgBox("Codigo Equivocado")
                TxtCodigoPre.Text = ""
            End If

        Else
            MsgBox("No se ha ingresado un codigo de alumno")
        End If
    End Sub

    Private Sub BtnBuscarAlumnoDev_Click(sender As Object, e As EventArgs) Handles BtnBuscarAlumnoDev.Click
        Dim objA As String
        Dim AlumnosLN As New AlumnosLN
        objA = TxtCodigoDev.Text
        TxtNombreDev.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(0)
        TxtCicloDev.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(1)
        TxtCarreraDev.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(2)
        TxtEstadoDev.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(3)
    End Sub

    Private Sub BtnBuscarAlumnoPer_Click(sender As Object, e As EventArgs) Handles BtnBuscarAlumnoPer.Click
        Dim objA As String
        Dim AlumnosLN As New AlumnosLN
        objA = TxtCodigoDev.Text
        TxtNombrePer.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(0)
        TxtCicloPer.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(1)
        TxtCarreraPer.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(2)
        TxtEstadoPer.Text = AlumnosLN.ObtenerAlumnoLN(objA).Rows(0).Item(3)
    End Sub

    Private Sub BtnAgregarLibro_Click(sender As Object, e As EventArgs) Handles BtnAgregarLibro.Click
        Dim LibroLN As New LibroLN
        Dim objL As New Libro
        objL.Titulo = TxtTituloAgre.Text
        objL.IdEditorial = CboEditorialAgre.SelectedValue
        objL.IdAutor = CboAutorAgre.SelectedValue
        objL.IdArea = CboAreaAgre.SelectedValue
        objL.IdIdioma = CboIdiomaAgre.SelectedValue
        objL.Stock = TxtStockAgre.Text
        objL.FechaEdicion = TxtEdicionAgre.Text

        LibroLN.agregarLibro(objL)

    End Sub

    Private Sub FrmBiblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LibroLN As New LibroLN
        Dim dtL As New DataTable
        Dim EditorialLN As New EditorialLN
        Dim dtE As New DataTable
        Dim AutorLN As New AutorLN
        Dim dtA As New DataTable
        Dim AreaLN As New AreaLN
        Dim dtAr As New DataTable
        Dim IdiomaLN As New IdiomaLN
        Dim dtI As New DataTable
        BtnPrestar.Enabled = False


        dtL = LibroLN.ListarLibroLN()
        dtE = EditorialLN.LlenarEditorialLN()
        dtA = AutorLN.LlenarAutorLN()
        dtAr = AreaLN.LlenarAreaLN()
        dtI = IdiomaLN.LlenarIdiomaLN()


        'Llenado de datos editar
        CboCodigoEdit.DisplayMember = "Titulo"
        CboCodigoEdit.ValueMember = "IdLibro"
        CboCodigoEdit.DataSource = dtL


        CboEditorialEdit.DisplayMember = "Nombre"
        CboEditorialEdit.ValueMember = "IdEditorial"
        CboEditorialEdit.DataSource = dtE


        CboAutorEdit.DisplayMember = "Nombre"
        CboAutorEdit.ValueMember = "IdAutor"
        CboAutorEdit.DataSource = dtA


        CboAreaEdit.DisplayMember = "Descripcion"
        CboAreaEdit.ValueMember = "IdArea"
        CboAreaEdit.DataSource = dtAr


        CboIdiomaEdit.DisplayMember = "Nombre"
        CboIdiomaEdit.ValueMember = "IdIdioma"
        CboIdiomaEdit.DataSource = dtI

        TxtEdicionEdit.Text = LibroLN.ListarLibroLN().Rows(0).Item(2)
        'Llenado de datos - Pestaña agregar
        CboEditorialAgre.DisplayMember = "Nombre"
        CboEditorialAgre.ValueMember = "IdEditorial"
        CboEditorialAgre.DataSource = dtE

        CboAutorAgre.DisplayMember = "Nombre"
        CboAutorAgre.ValueMember = "IdAutor"
        CboAutorAgre.DataSource = dtA

        CboAreaAgre.DisplayMember = "Descripcion"
        CboAreaAgre.ValueMember = "IdArea"
        CboAreaAgre.DataSource = dtAr

        CboIdiomaAgre.DisplayMember = "Nombre"
        CboIdiomaAgre.ValueMember = "IdIdioma"
        CboIdiomaAgre.DataSource = dtI

        'Llenado de datos - Pestaña Prestamo
        CboEditorial.DisplayMember = "Nombre"
        CboEditorial.ValueMember = "IdEditorial"
        CboEditorial.DataSource = dtE
        CboEditorial.SelectedValue = 0

        CboAutor.DisplayMember = "Nombre"
        CboAutor.ValueMember = "IdAutor"
        CboAutor.DataSource = dtA
        CboAutor.SelectedValue = 0

        CboArea.DisplayMember = "Descripcion"
        CboArea.ValueMember = "IdArea"
        CboArea.DataSource = dtAr
        CboArea.SelectedValue = 0

        CboIdioma.DisplayMember = "Nombre"
        CboIdioma.ValueMember = "IdIdioma"
        CboIdioma.DataSource = dtI
        CboIdioma.SelectedValue = 0

        ListBoxLibros.Items.Clear()



    End Sub

    Private Sub CboCodigoEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCodigoEdit.SelectedIndexChanged
        Dim objLN As New LibroLN
        Dim objL As New Libro
        objL = objLN.SeleccionarLibro(CboCodigoEdit.SelectedValue)
        TxtTituloEdit.Text = CboCodigoEdit.SelectedValue
        CboEditorialEdit.SelectedIndex = CboCodigoEdit.SelectedIndex
        CboAutorEdit.SelectedValue = objL.IdAutor
        CboAreaEdit.SelectedValue = objL.IdArea
        CboIdiomaEdit.SelectedValue = objL.IdIdioma
        TxtEdicionEdit.Text = objL.FechaEdicion
    End Sub

    Private Sub CboEditorialAgre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEditorialAgre.SelectedIndexChanged

    End Sub

    Private Sub CboEditorialEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEditorialEdit.SelectedIndexChanged

    End Sub

    Private Sub TabAgregarLibro_Click(sender As Object, e As EventArgs) Handles TabAgregarLibro.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnAgreLibro.Click
        Dim libroLN As New LibroLN
        Dim objL As New Libro
        objL.IdLibro = CboCodigoEdit.Text
        objL.Titulo = TxtTituloEdit.Text
        objL.IdEditorial = CboCodigoEdit.SelectedValue
        objL.IdAutor = CboAutorEdit.SelectedValue
        objL.IdArea = CboAreaEdit.SelectedValue
        objL.FechaEdicion = TxtEdicionEdit.Text
        libroLN.EditarLibro(objL)
        MsgBox("Libro Editado")
    End Sub

    Private Sub BtnAplicarFiltros_Click(sender As Object, e As EventArgs) Handles BtnAplicarFiltros.Click
        Dim libroLN As New LibroLN
        Dim objL As New Libro
        Dim dtLibros As New DataTable

        objL.IdEditorial = CboEditorial.SelectedValue
        objL.IdIdioma = CboIdioma.SelectedValue
        objL.IdAutor = CboAutor.SelectedValue
        objL.IdArea = CboArea.SelectedValue

        dtLibros = libroLN.FiltrosLibros(objL)

        ListBoxLibros.Items.Clear()

        If (dtLibros.Rows.Count > 0) Then
            For i As Integer = 0 To dtLibros.Rows.Count - 1
                ListBoxLibros.Items.Add(dtLibros.Rows(i).Item(1) + "-" + dtLibros.Rows(i).Item(0))
            Next


        Else
            MsgBox("No se encontraron libros compatibles")
        End If


    End Sub

    Private Sub ListBoxLibros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLibros.SelectedIndexChanged

    End Sub

    Private Sub BtnPrestar_Click(sender As Object, e As EventArgs) Handles BtnPrestar.Click
        MsgBox(ListBoxLibros.CheckedItems.Count)
    End Sub
End Class