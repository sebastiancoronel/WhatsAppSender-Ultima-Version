Public Class FormColumnas
    Private Sub CheckBoxSeleccionar29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeleccionar29.CheckedChanged

        If CheckBoxSeleccionar29.Checked Then
            CheckBoxSeleccionar31.Enabled = False
            Dim i As Integer = 1
            While i <= 29
                FormPrincipal.DataGridView1.Columns(i).Visible = False
                i = i + 1
            End While
        Else
            CheckBoxSeleccionar31.Enabled = True
            Dim i As Integer = 1
            While i <= 29
                FormPrincipal.DataGridView1.Columns(i).Visible = True
                i = i + 1
            End While
        End If

    End Sub

    Private Sub CheckBoxSeleccionar31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeleccionar31.CheckedChanged

        If CheckBoxSeleccionar31.Checked Then
            CheckBoxSeleccionar29.Enabled = False
            Dim i As Integer = 1
            Try
                While i <= 31
                    FormPrincipal.DataGridView1.Columns(i).Visible = False
                    i = i + 1
                End While
            Catch ex As Exception
                MessageBox.Show("El archivo.csv fue modificado o hay menos de 31 columnas" & vbCrLf & "Ésta opción es válida solo para archivos .csv que no fueron modificados sus campos")
            End Try

        Else
            CheckBoxSeleccionar29.Enabled = True
            Dim i As Integer = 1
            Try
                While i <= 31
                    FormPrincipal.DataGridView1.Columns(i).Visible = True
                    i = i + 1
                End While
            Catch ex As Exception
                MessageBox.Show("Intente cargar un archivo sin modificar con 46 campos o modifique su archivo CSV con el formato:" & vbCrLf & "" & vbCrLf & "Nombre,,,,,,,,,,,,,,,,,,,,,,,,,,,,* myContacts,,,Mobile,999 999-9999,,,,,,,,,,," & vbCrLf & "con 46 campos delimitandolos por ','")
            End Try





        End If
    End Sub
End Class