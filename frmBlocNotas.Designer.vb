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
        ToolStripSeparator4 = New ToolStripSeparator()
        tstxtBuscar = New ToolStripTextBox()
        tsbBuscar = New ToolStripButton()
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
        ToolStripMenuItem1 = New ToolStripMenuItem()
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmsTexto
        ' 
        cmsTexto.ImageScalingSize = New Size(24, 24)
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(61, 4)
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.ImageScalingSize = New Size(24, 24)
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdiciónToolStripMenuItem, FormatoToolStripMenuItem, HerramientasToolStripMenuItem, AyudaToolStripMenuItem, ToolStripMenuItem1})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Padding = New Padding(9, 3, 0, 3)
        mnuPrincipal.Size = New Size(1143, 37)
        mnuPrincipal.TabIndex = 1
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Font = New Font("Arial", 12.0F)
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(106, 31)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Font = New Font("Arial", 9.75F)
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(257, 34)
        mnuNuevo.Text = "Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Font = New Font("Arial", 9.75F)
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(257, 34)
        mnuAbrir.Text = "Abrir..."
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Font = New Font("Arial", 9.75F)
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(257, 34)
        mnuGuardar.Text = "Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Font = New Font("Arial", 9.75F)
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(257, 34)
        mnuGuardarComo.Text = "Guardar como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Font = New Font("Arial", 9.75F)
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(257, 34)
        mnuSalir.Text = "Salir"
        ' 
        ' EdiciónToolStripMenuItem
        ' 
        EdiciónToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        EdiciónToolStripMenuItem.Font = New Font("Arial", 12.0F)
        EdiciónToolStripMenuItem.Name = "EdiciónToolStripMenuItem"
        EdiciónToolStripMenuItem.Size = New Size(107, 31)
        EdiciónToolStripMenuItem.Text = "Edición"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Font = New Font("Arial", 9.75F)
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.Size = New Size(263, 34)
        mnuDeshacer.Text = "Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Font = New Font("Arial", 9.75F)
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.Size = New Size(263, 34)
        mnuRehacer.Text = "Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Font = New Font("Arial", 9.75F)
        mnuCortar.Name = "mnuCortar"
        mnuCortar.Size = New Size(263, 34)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Font = New Font("Arial", 9.75F)
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.Size = New Size(263, 34)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Font = New Font("Arial", 9.75F)
        mnuPegar.Name = "mnuPegar"
        mnuPegar.Size = New Size(263, 34)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Font = New Font("Arial", 9.75F)
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.Size = New Size(263, 34)
        mnuSeleccionarTodo.Text = "Seleccionar Todo"
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColor, mnuAjusteLinea})
        FormatoToolStripMenuItem.Font = New Font("Arial", 12.0F)
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(117, 31)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Font = New Font("Arial", 9.75F)
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(247, 34)
        mnuFuente.Text = "Fuente"
        ' 
        ' mnuColor
        ' 
        mnuColor.Font = New Font("Arial", 9.75F)
        mnuColor.Name = "mnuColor"
        mnuColor.Size = New Size(247, 34)
        mnuColor.Text = "Color de fuente"
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.Font = New Font("Arial", 9.75F)
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(247, 34)
        mnuAjusteLinea.Text = "Ajuste de linea"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuBuscar, mnuContarPalabras, mnuContarCaracteres})
        HerramientasToolStripMenuItem.Font = New Font("Arial", 12.0F)
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(171, 31)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' mnuBuscar
        ' 
        mnuBuscar.Font = New Font("Arial", 9.75F)
        mnuBuscar.Name = "mnuBuscar"
        mnuBuscar.Size = New Size(271, 34)
        mnuBuscar.Text = "Buscar"
        ' 
        ' mnuContarPalabras
        ' 
        mnuContarPalabras.Font = New Font("Arial", 9.75F)
        mnuContarPalabras.Name = "mnuContarPalabras"
        mnuContarPalabras.Size = New Size(271, 34)
        mnuContarPalabras.Text = "Contar palabras"
        ' 
        ' mnuContarCaracteres
        ' 
        mnuContarCaracteres.Font = New Font("Arial", 9.75F)
        mnuContarCaracteres.Name = "mnuContarCaracteres"
        mnuContarCaracteres.Size = New Size(271, 34)
        mnuContarCaracteres.Text = "Contar caracteres"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe})
        AyudaToolStripMenuItem.Font = New Font("Arial", 12.0F)
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(96, 31)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(220, 34)
        mnuAcercaDe.Text = "Acerca de..."
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.ImageScalingSize = New Size(24, 24)
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, ToolStripSeparator1, tsbCortar, tsbCopiar, tsbPegar, ToolStripSeparator2, tsbNegrita, tsbCursiva, tsbSubrayado, ToolStripSeparator3, tscbFuente, tscbTamano, ToolStripSeparator4, tstxtBuscar, tsbBuscar})
        tsPrincipal.Location = New Point(0, 37)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Padding = New Padding(0, 0, 3, 0)
        tsPrincipal.Size = New Size(1143, 33)
        tsPrincipal.TabIndex = 2
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(34, 28)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(34, 28)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(34, 28)
        tsbGuardar.Text = "Guardar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 33)
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.Image = CType(resources.GetObject("tsbCortar.Image"), Image)
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(34, 28)
        tsbCortar.Text = "Cortar"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), Image)
        tsbCopiar.ImageTransparentColor = Color.Magenta
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(34, 28)
        tsbCopiar.Text = "Copiar"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), Image)
        tsbPegar.ImageTransparentColor = Color.Magenta
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(34, 28)
        tsbPegar.Text = "Pegar"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 33)
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(34, 28)
        tsbNegrita.Text = "Negrita"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(34, 28)
        tsbCursiva.Text = "Cursiva"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(34, 28)
        tsbSubrayado.Text = "Subrayado"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 33)
        ' 
        ' tscbFuente
        ' 
        tscbFuente.DisplayStyle = ToolStripItemDisplayStyle.Image
        tscbFuente.Image = CType(resources.GetObject("tscbFuente.Image"), Image)
        tscbFuente.ImageTransparentColor = Color.Magenta
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(34, 28)
        tscbFuente.Text = "Fuente"
        ' 
        ' tscbTamano
        ' 
        tscbTamano.DisplayStyle = ToolStripItemDisplayStyle.Image
        tscbTamano.Image = CType(resources.GetObject("tscbTamano.Image"), Image)
        tscbTamano.ImageTransparentColor = Color.Magenta
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(34, 28)
        tscbTamano.Text = "Tamaño"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 33)
        ' 
        ' tstxtBuscar
        ' 
        tstxtBuscar.Name = "tstxtBuscar"
        tstxtBuscar.Size = New Size(150, 33)
        tstxtBuscar.ToolTipText = "Escriba el texto a buscar y presione Enter"
        ' 
        ' tsbBuscar
        ' 
        tsbBuscar.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbBuscar.Name = "tsbBuscar"
        tsbBuscar.Size = New Size(60, 28)
        tsbBuscar.Text = "Buscar"
        ' 
        ' stsInferior
        ' 
        stsInferior.ImageScalingSize = New Size(24, 24)
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsPalabras})
        stsInferior.Location = New Point(0, 718)
        stsInferior.Name = "stsInferior"
        stsInferior.Padding = New Padding(1, 0, 20, 0)
        stsInferior.Size = New Size(1143, 32)
        stsInferior.TabIndex = 3
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(748, 25)
        stsEstado.Spring = True
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(166, 25)
        stsPosicion.Text = "Linea: 1 Columna: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(112, 25)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsPalabras
        ' 
        stsPalabras.Name = "stsPalabras"
        stsPalabras.Size = New Size(96, 25)
        stsPalabras.Text = "Palabras: 0"
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        rtbDocumento.Location = New Point(0, 70)
        rtbDocumento.Margin = New Padding(4, 5, 4, 5)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(1143, 648)
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
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(182, 31)
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(rtbDocumento)
        Controls.Add(stsInferior)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(848, 629)
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
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tstxtBuscar As ToolStripTextBox
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsPalabras As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem

End Class