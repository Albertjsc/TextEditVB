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


End Class
