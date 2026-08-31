<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        cmsTexto = New ContextMenuStrip(components)
        mnuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        EdiciónToolStripMenuItem = New ToolStripMenuItem()
        mnuDeshacer = New ToolStripMenuItem()
        mnuRehacer = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuSeleccionarTodo = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColor = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        mnuBuscar = New ToolStripMenuItem()
        mnuContarPalabras = New ToolStripMenuItem()
        mnuContarCaracteres = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        mnuAcercaDe = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsbCortar = New ToolStripButton()
        tsbCopiar = New ToolStripButton()
        tsbPegar = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        tscbFuente = New ToolStripButton()
        tscbTamano = New ToolStripButton()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsPalabras = New ToolStripStatusLabel()
        rtbDocumento = New RichTextBox()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(61, 4)
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, FormatoToolStripMenuItem, HerramientasToolStripMenuItem, AyudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(800, 26)
        mnuPrincipal.TabIndex = 1
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Font = New Font("Arial", 12F)
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(72, 22)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Font = New Font("Arial", 9.75F)
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(169, 22)
        mnuNuevo.Text = "Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Font = New Font("Arial", 9.75F)
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(169, 22)
        mnuAbrir.Text = "Abrir..."
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Font = New Font("Arial", 9.75F)
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(169, 22)
        mnuGuardar.Text = "Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Font = New Font("Arial", 9.75F)
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(169, 22)
        mnuGuardarComo.Text = "Guardar como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Font = New Font("Arial", 9.75F)
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(169, 22)
        mnuSalir.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        EdiciónToolStripMenuItem.Font = New Font("Arial", 12F)
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(73, 22)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Font = New Font("Arial", 9.75F)
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.Size = New Size(174, 22)
        mnuDeshacer.Text = "Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Font = New Font("Arial", 9.75F)
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.Size = New Size(174, 22)
        mnuRehacer.Text = "Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Font = New Font("Arial", 9.75F)
        mnuCortar.Name = "mnuCortar"
        mnuCortar.Size = New Size(174, 22)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Font = New Font("Arial", 9.75F)
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.Size = New Size(174, 22)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Font = New Font("Arial", 9.75F)
        mnuPegar.Name = "mnuPegar"
        mnuPegar.Size = New Size(174, 22)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Font = New Font("Arial", 9.75F)
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.Size = New Size(174, 22)
        mnuSeleccionarTodo.Text = "Seleccionar Todo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColor, mnuAjusteLinea})
        FormatoToolStripMenuItem.Font = New Font("Arial", 12F)
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(79, 22)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Font = New Font("Arial", 9.75F)
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(162, 22)
        mnuFuente.Text = "Fuente"
        ' 
        ' mnuColor
        ' 
        mnuColor.Font = New Font("Arial", 9.75F)
        mnuColor.Name = "mnuColor"
        mnuColor.Size = New Size(162, 22)
        mnuColor.Text = "Color de fuente"
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.Font = New Font("Arial", 9.75F)
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(162, 22)
        mnuAjusteLinea.Text = "Ajuste de linea"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuBuscar, mnuContarPalabras, mnuContarCaracteres})
        HerramientasToolStripMenuItem.Font = New Font("Arial", 12F)
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(114, 22)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' mnuBuscar
        ' 
        mnuBuscar.Font = New Font("Arial", 9.75F)
        mnuBuscar.Name = "mnuBuscar"
        mnuBuscar.Size = New Size(178, 22)
        mnuBuscar.Text = "Buscar"
        ' 
        ' mnuContarPalabras
        ' 
        mnuContarPalabras.Font = New Font("Arial", 9.75F)
        mnuContarPalabras.Name = "mnuContarPalabras"
        mnuContarPalabras.Size = New Size(178, 22)
        mnuContarPalabras.Text = "Contar palabras"
        ' 
        ' mnuContarCaracteres
        ' 
        mnuContarCaracteres.Font = New Font("Arial", 9.75F)
        mnuContarCaracteres.Name = "mnuContarCaracteres"
        mnuContarCaracteres.Size = New Size(178, 22)
        mnuContarCaracteres.Text = "Contar caracteres"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe})
        AyudaToolStripMenuItem.Font = New Font("Arial", 12F)
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(64, 22)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(146, 22)
        mnuAcercaDe.Text = "Acerca de..."
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, ToolStripSeparator1, tsbCortar, tsbCopiar, tsbPegar, ToolStripSeparator2, tsbNegrita, tsbCursiva, tsbSubrayado, ToolStripSeparator3, tscbFuente, tscbTamano})
        tsPrincipal.Location = New Point(0, 26)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(800, 25)
        tsPrincipal.TabIndex = 2
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(23, 22)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(23, 22)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(23, 22)
        tsbGuardar.Text = "Guardar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.Image = CType(resources.GetObject("tsbCortar.Image"), Image)
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(23, 22)
        tsbCortar.Text = "Cortar"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), Image)
        tsbCopiar.ImageTransparentColor = Color.Magenta
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(23, 22)
        tsbCopiar.Text = "Copiar"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), Image)
        tsbPegar.ImageTransparentColor = Color.Magenta
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(23, 22)
        tsbPegar.Text = "Pegar"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 22)
        tsbNegrita.Text = "Negrita"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 22)
        tsbCursiva.Text = "Cursiva"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 22)
        tsbSubrayado.Text = "Subrayado"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' tscbFuente
        ' 
        tscbFuente.DisplayStyle = ToolStripItemDisplayStyle.Image
        tscbFuente.Image = CType(resources.GetObject("tscbFuente.Image"), Image)
        tscbFuente.ImageTransparentColor = Color.Magenta
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(23, 22)
        tscbFuente.Text = "Fuente"
        ' 
        ' tscbTamano
        ' 
        tscbTamano.DisplayStyle = ToolStripItemDisplayStyle.Image
        tscbTamano.Image = CType(resources.GetObject("tscbTamano.Image"), Image)
        tscbTamano.ImageTransparentColor = Color.Magenta
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(23, 22)
        tscbTamano.Text = "Tamaño"
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsPalabras})
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
        stsInferior.TabIndex = 3
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(537, 17)
        stsEstado.Spring = True
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(111, 17)
        stsPosicion.Text = "Linea: 1 Columna: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(74, 17)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsPalabras
        ' 
        stsPalabras.Name = "stsPalabras"
        stsPalabras.Size = New Size(63, 17)
        stsPalabras.Text = "Palabras: 0"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 51)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 377)
        rtbDocumento.TabIndex = 4
        rtbDocumento.Text = ""
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        dlgAbrir.Title = "Abrir documento"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt"
        dlgGuardar.Title = "Guardar documento"
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(rtbDocumento)
        Controls.Add(stsInferior)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TextEdit VB"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdiciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents mnuDeshacer As ToolStripMenuItem
    Friend WithEvents mnuRehacer As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents mnuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem
    Friend WithEvents mnuBuscar As ToolStripMenuItem
    Friend WithEvents mnuContarPalabras As ToolStripMenuItem
    Friend WithEvents mnuContarCaracteres As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tscbFuente As ToolStripButton
    Friend WithEvents tscbTamano As ToolStripButton
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsPalabras As ToolStripStatusLabel

End Class
