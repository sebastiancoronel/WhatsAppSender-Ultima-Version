Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports System.Data.OleDb
Imports System.Text.RegularExpressions



Public Class FormPrincipal

    'Public nombrePublic As String
    'Public numeroPublic As String



    Private Sub ButtonEnviarTexto_Click(sender As Object, e As EventArgs) Handles ButtonEnviarTexto.Click
        '----------------------------------------------------------'ENVIAR TEXTO PLANO --------------------------------------------
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
            Label11.ForeColor = Color.Gray
            RichTextBox1.Enabled = False
            GroupBoxTextoPlano.BackColor = Color.Gainsboro
            ButtonEnviarTexto.BackColor = Color.Gray
            RichTextBox1.Clear()
            RadioButtonTextoPlano.Checked = False
        Else

            Dim driver As IWebDriver
            driver = New ChromeDriver
            driver.Manage().Window.Maximize()
            'DIMENSION DE VARIABLES PARA GENERAR LA URL-----------------------
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text

            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                'Vacío
            End If

            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar.", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Threading.Thread.Sleep(5000) 'Espera 10 segundos a que se regrese a web whatsapp

                'GENERAR URL PARA ENVIAR A NUMEROS SIN AGENDAR-----------------------------------------------------------------------------------------------------------
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                    driver.Navigate().GoToUrl(url) 'Abre la url generada con la MISMA SESION!!!!
                    Threading.Thread.Sleep(3000) 'Espera 5 segundos a que se abra la URL en la API
                    Dim send As IWebElement = driver.FindElement(By.XPath("//*[@id='action-button']")) 'Encuentra el boton SEND para iniciar el chat
                    Threading.Thread.Sleep(1000)
                    send.Click() 'Iniciar chat
                    Threading.Thread.Sleep(10000) 'Espera 10 segundos a que se abra Web Whatsapp e inicie un chat
                    Dim enviarMensaje As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/footer/div[1]/div[3]/button"))
                    Threading.Thread.Sleep(1000)
                    'enviarMensaje.Click()
                    Threading.Thread.Sleep(5000) ' Espera 5 segundos a que se envíe para luego volver a abrir proxima URL
                Next
                ''-----------------------------------------------------------------------------------------------------------------------------------------------------



                If MessageBox.Show("FINALIZADO", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                End If


            End If

            '    RECORRE POR NOMBRE DE CONTACTO O NUMERO---------------------------------------------------------------------------------------------------------------------
            'Try

            '    For Each item As String In ListBox1.Items
            '        Dim inputContacto As IWebElement = driver.FindElement(By.XPath("//*[@id='side']/div[1]/div/label/input"))
            '        Threading.Thread.Sleep(2000)
            '        inputContacto.SendKeys(item) 'introduce el nombre del contacto del listbox
            '        Threading.Thread.Sleep(1000)
            '        SendKeys.Send("{Enter}")
            '        Dim inputTexto As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/footer/div[1]/div[2]/div/div[2]")) 'Localiza el input del mensaje
            '        inputTexto.SendKeys(RichTextBox1.Text) 'Escribe le mensaje en el campo de mensaje
            '        Threading.Thread.Sleep(1000)
            '        Dim botonEnviar As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/footer/div[1]/div[3]/button"))
            '        Threading.Thread.Sleep(1000)
            '        'botonEnviar.Click()
            '        If botonEnviar Is Nothing Then
            '            MessageBox.Show("Boton No Encontrado")
            '        Else
            '            MessageBox.Show("Boton Encontrado")
            '        End If

            '        Threading.Thread.Sleep(1000)

            '    Next
            '-------------------------------------------------------------------------------------------------------------------------------------------------------------
            'Catch ex As Exception
            '    If RadioButtonSeleccionLibre.Checked = True Then
            '        MessageBox.Show("Hubo un error al enviar, compruebe que los numeros seleccionados puedan recibir mensajes de WhatsApp")
            '    Else

            '        MessageBox.Show("Hubo un error al enviar, compruebe que los nombres seleccionados coincidan con contactos agendados.")
            '    End If

            'End Try

            ''SI EL NUMERO NO EXISTE
            'Try
            '    Dim noexiste As IWebElement = driver.FindElement(By.XPath(""))
            '    Dim botonOK As IWebElement = driver.FindElement(By.XPath(""))
            '    botonOK.Click()
            'Catch ex As Exception

            'End Try
        End If





    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If RichTextBox1.Text = "" Then
            ButtonEnviarTexto.Enabled = False
        Else
            ButtonEnviarTexto.Enabled = True
        End If
    End Sub

    Private Sub ButtonFolder_Click(sender As Object, e As EventArgs) Handles ButtonFolder.Click
        importarImagen(OpenFileDialogImagenes, TextBoxRuta)
        If (OpenFileDialogImagenes.ShowDialog() = DialogResult.OK) Then

            TextBoxRuta.Text = OpenFileDialogImagenes.FileName
        End If

    End Sub


    Private Sub CheckBoxPieDeFoto_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxPieDeFoto.CheckedChanged
        If CheckBoxPieDeFoto.Checked = True Then
            RichTextBoxPieDeFoto.Enabled = True
        Else
            RichTextBoxPieDeFoto.Enabled = False
        End If
    End Sub

    Private Sub TextBoxRuta_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxRuta.TextChanged
        If TextBoxRuta.Text = "" Then
            ButtonEnviarImagen.Enabled = False
        Else
            ButtonEnviarImagen.Enabled = True
            ButtonEnviarImagen.BackColor = Color.FromArgb(18, 140, 126)
        End If
    End Sub

    Private Sub ButtonEnviarImagen_Click_1(sender As Object, e As EventArgs) Handles ButtonEnviarImagen.Click
        If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
            Label7.ForeColor = Color.Gray
            CheckBoxPieDeFoto.ForeColor = Color.Gray
            ButtonFolder.Enabled = False
            CheckBoxPieDeFoto.Enabled = False
            ButtonFolder.BackColor = Color.Gray
            ButtonEnviarImagen.Enabled = False
            ButtonEnviarImagen.BackColor = Color.Gray
            CheckBoxPieDeFoto.Checked = False
            RichTextBoxPieDeFoto.Enabled = False
            GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            TextBoxRuta.Clear()
            RadioButtonImagenesYVideo.Checked = False
        Else
            'ENVIAR IMAGENES
            Try
                Dim driver As IWebDriver
                driver = New ChromeDriver
                driver.Manage().Window.Maximize()
                driver.Navigate().GoToUrl("https://web.whatsapp.com/")
                Threading.Thread.Sleep(2000)



                If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                End If

                If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then


                    'RECORRER EL LISTBOX1 PARA ENVIAR LA IMAGEN POR NOMBRE
                    For Each item As String In ListBox1.Items
                        Dim inputContacto As IWebElement = driver.FindElement(By.XPath("//*[@id='side']/div[1]/div/label/input"))
                        Threading.Thread.Sleep(2000)
                        inputContacto.SendKeys(item) 'introduce el nombre del contacto del listbox
                        Threading.Thread.Sleep(1000)
                        SendKeys.Send("{Enter}")

                        'BOTON ADJUNTAR-------------------------------------------------------------------------------------------------
                        Dim adjuntar As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/header/div[3]/div/div[2]")) 'Encuentra el boton de adjuntar
                        Threading.Thread.Sleep(1000) 'Espera 1 seg
                        adjuntar.Click() 'Click en el boton Adjuntar
                        Threading.Thread.Sleep(1000) 'Esperar 2 segundos

                        'BOTON FOTOS Y VIDEOS-------------------------------------------------------------------------------------------
                        Dim foto As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[1]/button"))
                        foto.Click() 'Abre el buscador de archivos
                        Threading.Thread.Sleep(2000) 'Esperar 2 segundos
                        'EXPLORADOR DE ARCHIVOS-------------------------------------------------------------------------------------------------
                        SendKeys.Send(TextBoxRuta.Text)
                        Threading.Thread.Sleep(1000)
                        SendKeys.Send("{Enter}") ' Click en Aceptar del explorador
                        Threading.Thread.Sleep(5000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                        'Pie de foto
                        If CheckBoxPieDeFoto.Checked Then
                            'Escribir pie de foto
                            Dim inputPie As IWebElement = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]"))
                            Threading.Thread.Sleep(1000)
                            inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                            Threading.Thread.Sleep(1000)
                        End If
                        'BOTON ENVIAR DE WHATSAPP WEB
                        Dim Enviar As IWebElement = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div"))
                        Enviar.Click() 'Envia el mensaje con la imagen (FIN del proceso)
                        Threading.Thread.Sleep(1000)
                    Next

                    If MessageBox.Show("FINALIZADO", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                    End If
                End If

            Catch ex As Exception
                If RadioButtonSeleccionLibre.Checked = True Then
                    MessageBox.Show("Hubo un error al enviar, compruebe que los numeros seleccionados puedan recibir mensajes de WhatsApp")
                Else
                    MessageBox.Show("Hubo un error al enviar, compruebe que los nombres seleccionados coincidan con contactos agendados.")
                End If
            End Try
        End If

    End Sub

    Private Sub ButtonEnviarDocumento_Click_1(sender As Object, e As EventArgs) Handles ButtonEnviarDocumento.Click
        If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
            Label7.ForeColor = Color.Gray
            CheckBoxPieDeFoto.ForeColor = Color.Gray
            ButtonFolder.Enabled = False
            CheckBoxPieDeFoto.Enabled = False
            ButtonFolder.BackColor = Color.Gray
            ButtonEnviarImagen.Enabled = False
            ButtonEnviarImagen.BackColor = Color.Gray
            CheckBoxPieDeFoto.Checked = False
            RichTextBoxPieDeFoto.Enabled = False
            GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            TextBoxRuta.Clear()
            RadioButtonDocumentos.Checked = False
        Else
            'ENVIAR DOCUMENTOS
            Try
                Dim driver As IWebDriver
                driver = New ChromeDriver
                driver.Manage().Window.Maximize()
                driver.Navigate().GoToUrl("https://web.whatsapp.com/")
                Threading.Thread.Sleep(2000)


                If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                End If

                If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                    'RECORRER EL LISTBOX1 PARA ENVIAR LA IMAGEN POR NOMBRE
                    For Each item As String In ListBox1.Items
                        Dim inputContacto As IWebElement = driver.FindElement(By.XPath("//*[@id='side']/div[1]/div/label/input"))
                        Threading.Thread.Sleep(2000)
                        inputContacto.SendKeys(item) 'introduce el nombre del contacto del listbox
                        Threading.Thread.Sleep(1000)
                        SendKeys.Send("{Enter}")

                        'BOTON ADJUNTAR-------------------------------------------------------------------------------------------------
                        Dim adjuntar As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/header/div[3]/div/div[2]")) 'Encuentra el boton de adjuntar
                        Threading.Thread.Sleep(1000) 'Espera 1 seg
                        adjuntar.Click() 'Click en el boton Adjuntar
                        Threading.Thread.Sleep(1000) 'Esperar 2 segundos

                        'BOTON DOCUMENTOS-------------------------------------------------------------------------------------------
                        Dim documento As IWebElement = driver.FindElement(By.XPath("//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[3]/button"))
                        documento.Click() 'Abre el buscador de archivos
                        Threading.Thread.Sleep(3000) 'Esperar 3 segundos
                        'EXPLORADOR DE ARCHIVOS-------------------------------------------------------------------------------------------------
                        SendKeys.Send(TextBoxRutaDocumento.Text)
                        Threading.Thread.Sleep(1000)
                        SendKeys.Send("{Enter}") ' Click en Aceptar del explorador
                        Threading.Thread.Sleep(5000) 'Espera que se carguen todas las fotos
                        'BOTON ENVIAR DE WHATSAPP WEB
                        Dim Enviar As IWebElement = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div"))
                        Enviar.Click()
                        Threading.Thread.Sleep(1000)
                    Next

                    If MessageBox.Show("FINALIZADO", "FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

                    End If

                End If
            Catch ex As Exception
                If RadioButtonSeleccionLibre.Checked = True Then
                    MessageBox.Show("Hubo un error al enviar, compruebe que los numeros seleccionados puedan recibir mensajes de WhatsApp")
                Else
                    MessageBox.Show("Hubo un error al enviar, compruebe que los nombres seleccionados coincidan con contactos agendados.")
                End If
            End Try
        End If

    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButtonTextoPlano_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTextoPlano.CheckedChanged
        'If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
        'MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
        'RadioButtonTextoPlano.Checked = False
        'Else
        If RadioButtonTextoPlano.Checked Then
            Label11.ForeColor = Color.FromArgb(18, 140, 126)
            ButtonEnviarTexto.BackColor = Color.FromArgb(18, 140, 126)
            RichTextBox1.Enabled = True
            GroupBoxTextoPlano.BackColor = Color.FromArgb(236, 229, 200)
        Else

            Label11.ForeColor = Color.Gray
            RichTextBox1.Enabled = False
            GroupBoxTextoPlano.BackColor = Color.Gainsboro
            ButtonEnviarTexto.BackColor = Color.Gray
            RichTextBox1.Clear()
        End If
        'End If


    End Sub

    Private Sub RadioButtonImagenesYVideo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonImagenesYVideo.CheckedChanged
        ' If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
        'MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
        'RadioButtonImagenesYVideo.Checked = False
        ' Else
        If RadioButtonImagenesYVideo.Checked = True Then
            Label7.ForeColor = Color.FromArgb(18, 140, 126)
            CheckBoxPieDeFoto.ForeColor = Color.Black
            CheckBoxPieDeFoto.Enabled = True
            ButtonFolder.Enabled = True
            ButtonFolder.BackColor = Color.FromArgb(18, 140, 126)
            GroupBoxImagenesYVideo.BackColor = Color.FromArgb(236, 229, 200)

        Else
            Label7.ForeColor = Color.Gray
            CheckBoxPieDeFoto.ForeColor = Color.Gray
            ButtonFolder.Enabled = False
            CheckBoxPieDeFoto.Enabled = False
            ButtonFolder.BackColor = Color.Gray
            ButtonEnviarImagen.Enabled = False
            ButtonEnviarImagen.BackColor = Color.Gray
            CheckBoxPieDeFoto.Checked = False
            RichTextBoxPieDeFoto.Enabled = False
            GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            TextBoxRuta.Clear()


        End If
        ' End If

    End Sub

    Private Sub RadioButtonDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDocumentos.CheckedChanged
        'If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
        'MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
        'RadioButtonDocumentos.Checked = False
        'Else
        If RadioButtonDocumentos.Checked = True Then
            Label9.ForeColor = Color.FromArgb(18, 140, 126)
            ButtonFolderDocumento.Enabled = True
            ButtonFolderDocumento.BackColor = Color.FromArgb(18, 140, 126)
            GroupBoxDocumentos.BackColor = Color.FromArgb(236, 229, 200)
        Else
            Label9.ForeColor = Color.Gray
            ButtonFolderDocumento.Enabled = False
            ButtonFolderDocumento.BackColor = Color.Gray
            ButtonEnviarDocumento.BackColor = Color.Gray
            GroupBoxDocumentos.BackColor = Color.Gainsboro
            TextBoxRutaDocumento.Clear()
        End If
        'End If

    End Sub

    Private Sub ButtonFolderDocumento_Click(sender As Object, e As EventArgs) Handles ButtonFolderDocumento.Click
        If (OpenFileDialogDocumentos.ShowDialog() = DialogResult.OK) Then
            TextBoxRutaDocumento.Text = OpenFileDialogDocumentos.FileName
        End If
    End Sub

    Private Sub TextBoxRutaDocumento_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxRutaDocumento.TextChanged
        If TextBoxRutaDocumento.Text = "" Then
            ButtonEnviarDocumento.Enabled = False
        Else
            ButtonEnviarDocumento.Enabled = True
            ButtonEnviarDocumento.BackColor = Color.FromArgb(18, 140, 126)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        ListBox1.Items.Clear()
        importarCSV(OpenFileDialog1, DataGridView1, ",")
        If DataGridView1.Rows.Count <> 0 Then
            DataGridView1.Rows.RemoveAt(0) 'Eliminar la primera fila del csv donde  estan los nombres de las columnas del csv
        End If


        'Si el DataGrid está vacio entonces no se oculta la primera fila del csv que tiene los nombres de los campos del archivo
        'If DataGridView1.Rows.Count <> 0 Then
        '    DataGridView1.Rows(0).Visible = False
        'End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormAgregarNumero.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If CheckBoxAgregarTodos.Checked = True Then
            Try
                'Recorro cada item y quito el signo +,- y los espacios
                For Each item As DataGridViewCell In DataGridView1.SelectedCells
                    Dim NumeroApi As String = item.Value
                    Dim NumeroApi54 As String = item.Value 'SACAR SI ESTA DE MAS
                    NumeroApi = NumeroApi.Replace("+", "") 'Borra el +
                    NumeroApi = NumeroApi.Replace(" ", "") 'Borra espacios
                    NumeroApi = NumeroApi.Replace("-", "") 'Borra guiones

                    If NumeroApi.First = "5" Then 'Evita que se agregue 5454 (dos veces) la caracteristica 54 a la lista.
                        If ListBox1.Items.Contains(NumeroApi) Then
                            MessageBox.Show(NumeroApi + " " + "Ya se encuentra en la lista PRIMER IF")
                        Else
                            ListBox1.Items.Add(NumeroApi)

                        End If

                    Else
                        If NumeroApi.First = "3" Then 'Con NumeroApi.First = "3" entra al IF
                            NumeroApi54 = "54" + NumeroApi
                            If ListBox1.Items.Contains(NumeroApi54) Then
                                MessageBox.Show(NumeroApi + " " + "Ya se encuentra en la lista SEGUNDO IF")
                            Else
                                ListBox1.Items.Add(NumeroApi54)
                            End If
                        End If
                    End If






                Next
            Catch ex As Exception
                MessageBox.Show("Seleccione una columna que contenga números de teléfonos y no celdas vacías")
            End Try



        End If


        If RadioButtonAgregarNombre.Checked Then
            Try
                Dim nombre As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString())
                ListBox1.Items.Add(nombre)
            Catch ex As Exception
                MessageBox.Show("Seleccione solo celdas")
            End Try

        End If

        If RadioButtonSeleccionLibre.Checked Then
            Try
                Dim telefono2 As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString() 'Esto permite seleccionar cualquier celda
                telefono2 = telefono2.Replace("+54", "") 'Quita el +54 del string
                telefono2 = telefono2.Replace("-", "") 'Quita el guion del string
                If telefono2 = "" Then
                    MessageBox.Show("No se pueden agregar elementos vacios")
                Else
                    ListBox1.Items.Add(telefono2)
                End If
            Catch ex As Exception
                MessageBox.Show("Seleccione solo celdas")
            End Try

        End If




    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs)

        'If ComboBoxBusqueda.Text = "Nombre" Then
        '    dv.RowFilter = String.Format("Nombre Like '%{0}%'", TextBoxBuscar.Text)

        'End If



        'If ComboBoxBusqueda.Text = "Telefono" Then
        '    dv.RowFilter = String.Format("Telefono Like '%{0}%'", TextBoxBuscar.Text)
        'End If

        'DataGridView1.Refresh()
        ''Si no hay nada en el TextBox se deshabilita el boton de modificar para no modificar algo no seleccionado
        'If LCase(TextBox_buscar.Text) = Nothing Then
        '    btn_modificar.Enabled = False
        '    btn_limpiar.Enabled = True
        'End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonMostrarOcultar.Click
        FormColumnas.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub RadioButtonAgregar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAgregarNombre.CheckedChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If RadioButtonQuitar.Checked Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ButtonLimpiarLista.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub OpenFileDialogImagenes_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogImagenes.FileOk

    End Sub

    Private Sub RadioButtonAgregarNumero_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSeleccionLibre.CheckedChanged
        If RadioButtonSeleccionLibre.Checked = True Then
            MessageBox.Show("Asegúrese de agregar a la lista solo nombres de contactos agendados o numeros de telefonos que puedan recibir mensajes de WhatsApp.")
        End If
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        FormAgregarNumero.ShowDialog()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class