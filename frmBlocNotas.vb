Imports System.IO
Imports System.Drawing
Public Class frmBlocNotas

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False
    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbDocumento.WordWrap = True

        documentoModificado = False
        rutaActual = String.Empty

        Me.Text = "TextEdit VB - [Nuevo documento]"

    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        stsEstado.Text = "Modificado"
        ActualizarContadores()
    End Sub

    Private Sub NuevoDocumento()

        If documentoModificado AndAlso rtbDocumento.TextLength > 0 Then

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "El documento contiene cambios sin guardar." & vbCrLf &
                "¿Desea descartarlos y crear un documento nuevo?",
                "TextEdit VB",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.No Then
                Exit Sub
            End If

        End If

        rtbDocumento.Clear()

        rutaActual = String.Empty
        documentoModificado = False

        Me.Text = "TextEdit VB - [Nuevo documento]"
        stsEstado.Text = "Listo"

    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub AbrirDocumento()

        If documentoModificado AndAlso rtbDocumento.TextLength > 0 Then

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "Hay cambios sin guardar." & vbCrLf &
                "¿Desea descartarlos y abrir otro documento?",
                "TextEdit VB",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.No Then
                Exit Sub
            End If

        End If

        If dlgAbrir.ShowDialog() = DialogResult.OK Then

            Try

                rtbDocumento.LoadFile(
                    dlgAbrir.FileName,
                    RichTextBoxStreamType.PlainText
                )

                rutaActual = dlgAbrir.FileName
                documentoModificado = False

                Me.Text = "TextEdit VB - [" &
                          Path.GetFileName(rutaActual) & "]"

                stsEstado.Text = "Archivo abierto"

            Catch ex As Exception

                MessageBox.Show(
                    "No se pudo abrir el archivo." & vbCrLf & ex.Message,
                    "TextEdit VB",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub GuardarDocumento(forzarGuardarComo As Boolean)

        Try

            If String.IsNullOrEmpty(rutaActual) OrElse forzarGuardarComo Then

                If dlgGuardar.ShowDialog() = DialogResult.OK Then
                    rutaActual = dlgGuardar.FileName
                Else
                    Exit Sub
                End If

            End If

            rtbDocumento.SaveFile(
                rutaActual,
                RichTextBoxStreamType.PlainText
            )

            documentoModificado = False

            Me.Text = "TextEdit VB - [" &
                      Path.GetFileName(rutaActual) & "]"

            stsEstado.Text = "Guardado correctamente"

        Catch ex As Exception

            MessageBox.Show(
                "No se pudo guardar el archivo." & vbCrLf & ex.Message,
                "TextEdit VB",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        GuardarDocumento(True)
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub frmBlocNotas_FormClosing(
    sender As Object,
    e As FormClosingEventArgs
) Handles MyBase.FormClosing

        If documentoModificado AndAlso rtbDocumento.TextLength > 0 Then

            Dim respuesta As DialogResult

            respuesta = MessageBox.Show(
                "El documento ha sido modificado." & vbCrLf &
                "¿Desea guardar los cambios?",
                "TextEdit VB",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            )

            If respuesta = DialogResult.Cancel Then

                e.Cancel = True

            ElseIf respuesta = DialogResult.Yes Then

                GuardarDocumento(False)

            End If

        End If

    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles mnuSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs) Handles mnuDeshacer.Click
        If rtbDocumento.CanUndo Then
            rtbDocumento.Undo()
        End If
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs) Handles mnuRehacer.Click
        If rtbDocumento.CanRedo Then
            rtbDocumento.Redo()
        End If
    End Sub

    ' ============================================================
    ' PUNTO 9 y 10 — Formato de fuente y color de texto
    ' ============================================================
    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click, tscbFuente.Click, tscbTamano.Click
        If rtbDocumento.SelectionFont IsNot Nothing Then
            dlgFuente.Font = rtbDocumento.SelectionFont
        End If

        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub mnuColor_Click(sender As Object, e As EventArgs) Handles mnuColor.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs) Handles mnuAjusteLinea.Click
        mnuAjusteLinea.Checked = Not mnuAjusteLinea.Checked
        rtbDocumento.WordWrap = mnuAjusteLinea.Checked
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub

        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If

        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    ' ============================================================
    ' PUNTO 8 — Buscar texto
    ' ============================================================
    Private Sub mnuBuscar_Click(sender As Object, e As EventArgs) Handles mnuBuscar.Click
        tstxtBuscar.Focus()
    End Sub

    Private Sub tsbBuscar_Click(sender As Object, e As EventArgs) Handles tsbBuscar.Click
        BuscarTexto()
    End Sub

    Private Sub tstxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles tstxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarTexto()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BuscarTexto()
        Dim textoBuscado As String = tstxtBuscar.Text

        If String.IsNullOrEmpty(textoBuscado) Then
            MessageBox.Show("Escriba una palabra o frase para buscar.", "TextEdit VB",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim indiceInicio As Integer = rtbDocumento.SelectionStart + rtbDocumento.SelectionLength
        Dim indiceEncontrado As Integer = rtbDocumento.Find(textoBuscado, indiceInicio, RichTextBoxFinds.None)

        If indiceEncontrado = -1 Then
            indiceEncontrado = rtbDocumento.Find(textoBuscado, 0, RichTextBoxFinds.None)
        End If

        If indiceEncontrado = -1 Then
            MessageBox.Show("No se encontró: """ & textoBuscado & """", "TextEdit VB",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            rtbDocumento.Focus()
            rtbDocumento.SelectionStart = indiceEncontrado
            rtbDocumento.SelectionLength = textoBuscado.Length
            rtbDocumento.ScrollToCaret()
        End If
    End Sub

    ' ============================================================
    ' PUNTO 11 — Contador de caracteres y palabras
    ' ============================================================
    Private Sub ActualizarContadores()
        stsCaracteres.Text = "Caracteres: " & rtbDocumento.TextLength

        Dim palabras() As String = rtbDocumento.Text.Split(New Char() {" "c, vbCr, vbLf, vbTab},
                                                              StringSplitOptions.RemoveEmptyEntries)
        stsPalabras.Text = "Palabras: " & palabras.Length
    End Sub

    Private Sub mnuContarPalabras_Click(sender As Object, e As EventArgs) Handles mnuContarPalabras.Click
        Dim palabras() As String = rtbDocumento.Text.Split(New Char() {" "c, vbCr, vbLf, vbTab},
                                                              StringSplitOptions.RemoveEmptyEntries)
        MessageBox.Show("El documento tiene " & palabras.Length & " palabra(s).", "Contar palabras",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuContarCaracteres_Click(sender As Object, e As EventArgs) Handles mnuContarCaracteres.Click
        MessageBox.Show("El documento tiene " & rtbDocumento.TextLength & " carácter(es).", "Contar caracteres",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ============================================================
    ' PUNTO 12 — Barra de estado: línea y columna actual
    ' ============================================================
    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = "Línea: " & linea & "   Columna: " & columna
    End Sub

    ' ============================================================
    ' Menú Ayuda
    ' ============================================================
    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Autores" & vbCrLf &
                         "Royman Leeroy Martinez Herrera " & vbCrLf &
                         "Albert Jered Sobalvarro Chavarria",
                         "UNIVERSIDAD NACIONAL DE INGENIERÍA C.SANDINO", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class