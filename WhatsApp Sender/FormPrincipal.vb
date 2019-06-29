Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System.Data.OleDb
Imports System.Text.RegularExpressions



Public Class FormPrincipal
    Dim i As Integer
    Dim intervalo As Integer
    Dim TamañoProgressBar As Integer
    'Variables para llevar la cuenta de numeros de todo tipo
    Dim cuenta As Integer = 1 'Lleva la cuenta de los elementos recorridos arriba del progressbar
    Dim cuentaExitosos As Integer = 0
    Dim cuentaInvalidos As Integer = 0
    Dim cuentaFallidos As Integer = 0
    Dim cuentaReenviadosFallidos As Integer = 0
    Dim aux As Integer
    Dim arrayFallidosExitosos() As String


    Private Sub ButtonEnviarTexto_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        'Contadores
        cuenta = 1 'Lleva la cuenta de los elementos recorridos arriba del progressbar
        cuentaExitosos = 0
        cuentaInvalidos = 0
        cuentaFallidos = 0
        cuentaReenviadosFallidos = 0
        'Botones
        ButtonEnviar.Enabled = False
        ButtonEnviar.Visible = False
        ButtonReenviarFallidos.Visible = False
        'Labels
        LabelStatus.ForeColor = Color.Black
        LabelEnviadosExitosos.Text = "Envíos correctos" 'Reinicia el label
        LabelCuenta.Text = "0/0"
        LabelCuentaReenviadosFallidos.Text = "0"
        LabelCuentaFallidos.Text = "0"
        LabelCuentaSinWhatsapp.Text = "0"
        LabelEnviadosExitosos.Text = "Envíos correctos"
        LabelBotonEnviar.Visible = False
        'Label cabecera Numeros fallidos
        LabelNumerosFallidos.Text = "Numeros fallidos:"
        LabelNumerosFallidos.ForeColor = Color.Black
        'Listbox
        ListBoxReenviadosFallidos.Items.Clear()
        ListBoxExitosos.Items.Clear()
        ListBoxSinWhatsapp.Items.Clear()

        If RadioButtonTextoPlano.Checked Then
            'PROCESO DE ENVIO DE TEXTO PLANO
            If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
                MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")

            Else
                Try
                    ButtonCancelarEnvio.Visible = True
                    ListBoxSinWhatsapp.Items.Clear()
                    ListBoxFallidos.Items.Clear()
                    PictureBoxLoading.Visible = True
                    BackgroundWorkerEnviarTextoPlano.RunWorkerAsync()
                Catch ex As Exception

                End Try
            End If


        Else
            If RadioButtonImagenesYVideo.Checked Then
                'PROCESO DE ENVIO MULTIMEDIA
                If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
                    MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")

                Else
                    Try
                        ButtonCancelarEnvio.Visible = True
                        ListBoxFallidos.Items.Clear()
                        PictureBoxLoading.Visible = True
                        BackgroundWorkerEnviarMultimedia.RunWorkerAsync()
                    Catch ex As Exception

                    End Try
                End If

            Else
                If RadioButtonDocumentos.Checked Then
                    'PROCESO DE ENVIO DOCUMENTOS
                    If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
                        MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")

                    Else
                        'ENVIAR DOCUMENTOS
                        Try
                            ButtonCancelarEnvio.Visible = True
                            ListBoxFallidos.Items.Clear()
                            PictureBoxLoading.Visible = True
                            BackgroundWorkerEnviarDocumentos.RunWorkerAsync()
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If RichTextBox1.Text = "" Then
            ButtonEnviar.Enabled = False
        Else
            ButtonEnviar.Enabled = True
        End If
    End Sub

    Private Sub ButtonFolder_Click(sender As Object, e As EventArgs) Handles ButtonFolder.Click
        importarImagen(OpenFileDialogImagenes, TextBoxRuta)
        If (OpenFileDialogImagenes.ShowDialog() = DialogResult.OK) Then

            TextBoxRuta.Text = OpenFileDialogImagenes.FileName
            Try
                PictureBoxImagenAEnviar.Image = Image.FromFile(OpenFileDialogImagenes.FileName)
            Catch ex As Exception

            End Try

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
        'If TextBoxRuta.Text = "" Then
        '    ButtonEnviarImagen.Enabled = False
        'Else
        '    ButtonEnviarImagen.Enabled = True
        '    ButtonEnviarImagen.BackColor = Color.FromArgb(18, 140, 126)
        'End If
        If TextBoxRuta.Text = "" Then
            ButtonEnviar.Enabled = False
        Else
            ButtonEnviar.Enabled = True
            ButtonEnviarImagen.BackColor = Color.FromArgb(18, 140, 126)
        End If

    End Sub

    Private Sub ButtonEnviarImagen_Click_1(sender As Object, e As EventArgs) Handles ButtonEnviarImagen.Click
        If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")

        Else
            Try
                ListBoxFallidos.Items.Clear()
                PictureBoxLoading.Visible = True
                BackgroundWorkerEnviarMultimedia.RunWorkerAsync()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ButtonEnviarDocumento_Click_1(sender As Object, e As EventArgs) Handles ButtonEnviarDocumento.Click
        If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")

        Else
            'ENVIAR DOCUMENTOS
            Try
                ListBoxFallidos.Items.Clear()
                PictureBoxLoading.Visible = True
                BackgroundWorkerEnviarDocumentos.RunWorkerAsync()
            Catch ex As Exception

            End Try
        End If

    End Sub


    Private Sub RadioButtonTextoPlano_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTextoPlano.CheckedChanged
        If RadioButtonTextoPlano.Checked Then
            Label11.ForeColor = Color.FromArgb(18, 140, 126)
            ButtonEnviar.BackColor = Color.FromArgb(18, 140, 126)
            RichTextBox1.Enabled = True
            GroupBoxTextoPlano.BackColor = Color.FromArgb(236, 229, 200)
            GroupBoxTextoPlano.Visible = True
            GroupBoxImagenesYVideo.Visible = False
            GroupBoxDocumentos.Visible = False
        Else
            GroupBoxTextoPlano.Visible = False
            GroupBoxTextoPlano.Visible = False
            Label11.ForeColor = Color.Gray
            RichTextBox1.Enabled = False
            GroupBoxTextoPlano.BackColor = Color.Gainsboro
            ButtonEnviar.BackColor = Color.Gray
            ListBoxFallidos.Items.Clear()
            RichTextBox1.Clear()
        End If
        'End If


    End Sub

    Private Sub RadioButtonImagenesYVideo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonImagenesYVideo.CheckedChanged

        If RadioButtonImagenesYVideo.Checked = True Then
            Label7.ForeColor = Color.FromArgb(18, 140, 126)
            Label10.ForeColor = Color.Black
            Label16.ForeColor = Color.Black
            CheckBoxPieDeFoto.ForeColor = Color.Black
            CheckBoxPieDeFoto.Enabled = True
            ButtonFolder.Enabled = True
            ButtonFolder.BackColor = Color.FromArgb(18, 140, 126)
            GroupBoxImagenesYVideo.BackColor = Color.FromArgb(236, 229, 200)
            MaskedTextBoxExploradorDeArchivos.Enabled = True
            MaskedTextBoxTiempoCargaImagenVideo.Enabled = True
            GroupBoxImagenesYVideo.Visible = True
            GroupBoxTextoPlano.Visible = False
            GroupBoxDocumentos.Visible = False
        Else
            GroupBoxTextoPlano.Visible = False

            Label7.ForeColor = Color.Gray
            Label10.ForeColor = Color.Gray
            Label16.ForeColor = Color.Gray
            CheckBoxPieDeFoto.ForeColor = Color.Gray
            ButtonFolder.Enabled = False
            CheckBoxPieDeFoto.Enabled = False
            ButtonFolder.BackColor = Color.Gray
            ButtonEnviarImagen.Enabled = False
            ButtonEnviarImagen.BackColor = Color.Gray
            CheckBoxPieDeFoto.Checked = False
            RichTextBoxPieDeFoto.Enabled = False
            GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            MaskedTextBoxExploradorDeArchivos.Enabled = False
            MaskedTextBoxTiempoCargaImagenVideo.Enabled = False
            PictureBoxImagenAEnviar.Image = Nothing
            ListBoxFallidos.Items.Clear()
            TextBoxRuta.Clear()


        End If
        ' End If

    End Sub

    Private Sub RadioButtonDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDocumentos.CheckedChanged
        If RadioButtonDocumentos.Checked = True Then
            Label9.ForeColor = Color.FromArgb(18, 140, 126)
            ButtonFolderDocumento.Enabled = True
            ButtonFolderDocumento.BackColor = Color.FromArgb(18, 140, 126)
            GroupBoxDocumentos.BackColor = Color.FromArgb(236, 229, 200)
            GroupBoxImagenesYVideo.Visible = False
            GroupBoxTextoPlano.Visible = False
            GroupBoxDocumentos.Visible = True
        Else
            GroupBoxDocumentos.Visible = False
            Label9.ForeColor = Color.Gray
            ButtonFolderDocumento.Enabled = False
            ButtonFolderDocumento.BackColor = Color.Gray
            ButtonEnviarDocumento.BackColor = Color.Gray
            GroupBoxDocumentos.BackColor = Color.Gainsboro
            ListBoxFallidos.Items.Clear()
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
        'If TextBoxRutaDocumento.Text = "" Then
        '    ButtonEnviarDocumento.Enabled = False
        'Else
        '    ButtonEnviarDocumento.Enabled = True
        '    ButtonEnviarDocumento.BackColor = Color.FromArgb(18, 140, 126)
        'End If
        If TextBoxRutaDocumento.Text = "" Then
            ButtonEnviar.Enabled = False
        Else
            ButtonEnviar.Enabled = True
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
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormAgregarNumero.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If CheckBoxAgregarTodos.Checked = True Then

            'Recorro cada item y quito el signo +,- y los espacios
            For Each item As DataGridViewCell In DataGridView1.SelectedCells
                    Dim NumeroApi As String = item.Value
                    Dim NumeroApi54 As String = item.Value 'SACAR SI ESTA DE MAS
                    NumeroApi = NumeroApi.Replace("+", "") 'Borra el +
                    NumeroApi = NumeroApi.Replace(" ", "") 'Borra espacios
                    NumeroApi = NumeroApi.Replace("-", "") 'Borra guiones
                Try
                    'If NumeroApi = Nothing Then
                    '    MessageBox.Show("Se omitió una celda vacía")
                    'End If

                    If NumeroApi.First = "5" Then 'Evita que se agregue 5454 (dos veces) la caracteristica 54 a la lista.
                        If ListBox1.Items.Contains(NumeroApi) Then
                            'MessageBox.Show(NumeroApi + " " + "Ya se encuentra en la lista PRIMER IF")
                        Else
                            ListBox1.Items.Add(NumeroApi)

                        End If

                    Else
                        If NumeroApi.First <> "5" Then 'Con NumeroApi.First = "3" o distinto a 5 (O sea para cualquier numero fuera de Santiago o Argentina) entra al IF
                            NumeroApi54 = "54" + NumeroApi
                            If ListBox1.Items.Contains(NumeroApi54) Then
                                'MessageBox.Show(NumeroApi + " " + "Ya se encuentra en la lista SEGUNDO IF")
                            Else
                                ListBox1.Items.Add(NumeroApi54)
                            End If
                        Else

                        End If

                    End If
                Catch ex As Exception
                    'MessageBox.Show("Seleccione una columna que contenga números de teléfonos y no celdas vacías")


                End Try
            Next




        End If









    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub RadioButtonAgregar_CheckedChanged(sender As Object, e As EventArgs)

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

    Private Sub RadioButtonAgregarNumero_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        FormAgregarNumero.ShowDialog()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonCancelarEnvío_Click(sender As Object, e As EventArgs) Handles ButtonCancelarEnvio.Click
        LabelCuenta.Text = "0/0"
        'Cancela el Background Worker
        If BackgroundWorkerEnviarTextoPlano.IsBusy Then
            If BackgroundWorkerEnviarTextoPlano.WorkerSupportsCancellation Then
                If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    BackgroundWorkerEnviarTextoPlano.CancelAsync()
                End If

            End If
        Else
            If BackgroundWorkerEnviarMultimedia.IsBusy Then
                If BackgroundWorkerEnviarMultimedia.WorkerSupportsCancellation Then
                    If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                        BackgroundWorkerEnviarMultimedia.CancelAsync()
                    End If

                End If
            Else
                If BackgroundWorkerEnviarDocumentos.IsBusy Then
                    If BackgroundWorkerEnviarDocumentos.WorkerSupportsCancellation Then
                        If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                            BackgroundWorkerEnviarDocumentos.CancelAsync()
                        End If

                    End If

                End If
            End If

        End If
    End Sub

    'MODULO DE ENVÍO DE TEXTO PLANO************************************************************************************************************************************************
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerEnviarTextoPlano.DoWork
        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.ForeColor = Color.Black
        'Limpiar lista de fallidos y reenviados fallidos
        ListBoxFallidos.Items.Clear()
        ListBoxReenviadosFallidos.Items.Clear()
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"

        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver
            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarTextoPlano.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos


                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerEnviarTextoPlano.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If
                    'GENERAR URL DE API
                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerEnviarTextoPlano.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerEnviarTextoPlano.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)
                                If BackgroundWorkerEnviarTextoPlano.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerEnviarTextoPlano.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ENVIAR DE WHATSAPP WEB
                                        Try
                                            Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                            Dim enviarMensaje As IWebElement
                                            enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/footer/div[1]/div[3]/button")))
                                            'enviarMensaje.Click()
                                            Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                            'MessageBox.Show("No se encontro el boton de enviar")
                                        End Try

                                    End If
                                Catch ex As Exception
                                    ListBoxFallidos.Items.Add(item)
                                    cuentaFallidos = cuentaFallidos + 1
                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception 'Exception de CONTROL VALIDOS E INVALIDOS
                            ListBoxFallidos.Items.Add(item)
                            cuentaFallidos = cuentaFallidos + 1
                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception 'Exception de GENERAR URL DE API
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaFallidos = cuentaFallidos + 1
                        LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                        ListBoxFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub BackgroundWorkerEnviarTextoPlano_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorkerEnviarTextoPlano.ProgressChanged

    End Sub

    Private Sub BackgroundWorkerEnviarTextoPlano_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnviarTextoPlano.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta - 1) + "/" + Convert.ToString(TamañoProgressBar)
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.Visible = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        LabelBotonEnviar.Visible = True
        'HABILITAR BOTON PARA REENVIAR FALLIDOS
        If ListBoxFallidos.Items.Count > 0 Then
            ButtonReenviarFallidos.Enabled = True
            ButtonReenviarFallidos.Visible = True
            ButtonReenviarFallidos.BackColor = Color.Gold
        End If
        PictureBoxLoading.Visible = False

        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Envío finalizado!  Algunos numeros fallaron al enviarse"
                ProgressBar1.Value = TamañoProgressBar
                If MessageBox.Show("Algunos numeros fallaron al enviarse", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                ProgressBar1.Value = TamañoProgressBar
                If MessageBox.Show("Fin del proceso de envío", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
                LabelStatus.Text = "Envío finalizado!"
            End If

            PictureBoxSuccess.Visible = True


        End If
    End Sub

    Private Sub CheckBoxSeleccionar29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSeleccionar29.CheckedChanged
        If CheckBoxSeleccionar29.Checked Then
            CheckBoxSeleccionar31.Enabled = False
            Dim i As Integer = 1
            While i <= 29
                DataGridView1.Columns(i).Visible = False
                i = i + 1
            End While
        Else
            CheckBoxSeleccionar31.Enabled = True
            Dim i As Integer = 1
            While i <= 29
                DataGridView1.Columns(i).Visible = True
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
                    DataGridView1.Columns(i).Visible = False
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
                    DataGridView1.Columns(i).Visible = True
                    i = i + 1
                End While
            Catch ex As Exception
                MessageBox.Show("Intente cargar un archivo sin modificar con 46 campos o modifique su archivo CSV con el formato:" & vbCrLf & "" & vbCrLf & "Nombre,,,,,,,,,,,,,,,,,,,,,,,,,,,,* myContacts,,,Mobile,999 999-9999,,,,,,,,,,," & vbCrLf & "con 46 campos delimitandolos por ','")
            End Try

        End If
    End Sub
    'MODULO DE ENVÍO DE MULTIMEDIA************************************************************************************************************************************************
    Private Sub BackgroundWorkerEnviarMultimedia_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerEnviarMultimedia.DoWork

        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        intervalo = MaskedTextBoxIntervaloEntreChats.Text * 1000 'Convertir lo del Masked textbox a milisegundos
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"

        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver

            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarMultimedia.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos


                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If

                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)
                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ADJUNTAR
                                        Dim adjuntar As IWebElement
                                        Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                        adjuntar = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                                        adjuntar.Click() 'Click en el boton Adjuntar
                                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON FOTOS Y VIDEOS
                                        Try
                                            Dim foto As IWebElement
                                            foto = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[1]/button")))
                                            foto.Click() 'Abre el buscador de archivos
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            Continue For
                                        End Try

                                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If

                                        Try
                                            'EXPLORADOR DE ARCHIVOS
                                            SendKeys.SendWait(TextBoxRuta.Text)
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000)
                                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                                            'Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                                        Catch ex As Exception
                                            'MessageBox.Show("Error al apretar enter en explorador de archivos")
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                        End Try

                                        If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'CONTROLAR SI SE CARGÓ UNA IMAGEN
                                        Try
                                            Dim ProcesarImagenVideo As IWebElement
                                            Dim WaitProcesarImagenVideo As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxTiempoCargaImagenVideo.Text))
                                            ProcesarImagenVideo = WaitProcesarImagenVideo.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div")))
                                            If ProcesarImagenVideo.Displayed Then
                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                                    e.Cancel = True
                                                    Exit For
                                                End If
                                                Try
                                                    If CheckBoxPieDeFoto.Checked Then
                                                        Dim inputPie As IWebElement
                                                        inputPie = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]")))
                                                        inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                                                    End If
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro pie de foto")
                                                End Try
                                                'Pie de foto

                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                                    e.Cancel = True
                                                    Exit For
                                                End If

                                                'BOTON ENVIAR DE WHATSAPP WEB
                                                Try

                                                    Dim enviarMensaje As IWebElement
                                                    enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                                                    'enviarMensaje.Click()
                                                    Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro el boton de enviar")
                                                End Try

                                            End If
                                        Catch ex As Exception
                                            ListBoxFallidos.Items.Add(item)
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            cuenta = cuenta + 1
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            'MessageBox.Show(ex.Message)
                                            Continue For

                                        End Try

                                    End If
                                Catch ex As Exception
                                    ListBoxFallidos.Items.Add(item)
                                    cuentaFallidos = cuentaFallidos + 1
                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception
                            ListBoxFallidos.Items.Add(item)
                            cuentaFallidos = cuentaFallidos + 1
                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaFallidos = cuentaFallidos + 1
                        LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                        ListBoxFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True

    End Sub
    'MODULO DE ENVÍO DE DOCUMENTOS*************************************************************************************************************************************
    Private Sub BackgroundWorkerEnviarDocumentos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerEnviarDocumentos.DoWork
        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        intervalo = MaskedTextBoxIntervaloEntreChats.Text * 1000 'Convertir lo del Masked textbox a milisegundos
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"

        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver

            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarDocumentos.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos


                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If

                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)
                                If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ADJUNTAR
                                        Dim adjuntar As IWebElement
                                        Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                        adjuntar = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                                        adjuntar.Click() 'Click en el boton Adjuntar

                                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON DOCUMENTOS
                                        Dim documento As IWebElement
                                        Try
                                            documento = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[3]/button")))
                                            documento.Click() 'Abre el buscador de archivos
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            Continue For
                                        End Try

                                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If

                                        Try
                                            'EXPLORADOR DE ARCHIVOS
                                            SendKeys.SendWait(TextBoxRutaDocumento.Text)
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000)
                                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                                            'Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                                        Catch ex As Exception
                                            'MessageBox.Show("Error al apretar enter en explorador de archivos")
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                        End Try

                                        If BackgroundWorkerEnviarDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'CONTROLAR SI SE CARGÓ EL DOCUMENTO
                                        Try
                                            Dim ProcesarImagenVideo As IWebElement
                                            Dim WaitProcesarImagenVideo As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxTiempoCargaImagenVideo.Text))
                                            ProcesarImagenVideo = WaitProcesarImagenVideo.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div")))
                                            If ProcesarImagenVideo.Displayed Then
                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                                    e.Cancel = True
                                                    Exit For
                                                End If
                                                Try
                                                    If CheckBoxPieDeFoto.Checked Then
                                                        Dim inputPie As IWebElement
                                                        inputPie = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]")))
                                                        inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                                                    End If
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro pie de foto")
                                                End Try
                                                'Pie de foto

                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                                    e.Cancel = True
                                                    Exit For
                                                End If

                                                'BOTON ENVIAR DE WHATSAPP WEB
                                                Try

                                                    Dim enviarMensaje As IWebElement
                                                    enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                                                    'enviarMensaje.Click()
                                                    Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro el boton de enviar")
                                                End Try

                                            End If
                                        Catch ex As Exception
                                            ListBoxFallidos.Items.Add(item)
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            cuenta = cuenta + 1
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            'MessageBox.Show(ex.Message)
                                            Continue For

                                        End Try

                                    End If
                                Catch ex As Exception
                                    ListBoxFallidos.Items.Add(item)
                                    cuentaFallidos = cuentaFallidos + 1
                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception
                            ListBoxFallidos.Items.Add(item)
                            cuentaFallidos = cuentaFallidos + 1
                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaFallidos = cuentaFallidos + 1
                        LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                        ListBoxFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BackgroundWorkerEnviarMultimedia_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnviarMultimedia.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta - 1) + "/" + Convert.ToString(TamañoProgressBar)
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.Visible = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        LabelBotonEnviar.Visible = True
        LabelCuentaFallidos.Text = ""
        'HABILITAR BOTON PARA REENVIAR FALLIDOS
        If ListBoxFallidos.Items.Count > 0 Then
            ButtonReenviarFallidos.Enabled = True
            ButtonReenviarFallidos.Visible = True
            ButtonReenviarFallidos.BackColor = Color.Gold
        End If
        PictureBoxLoading.Visible = False
        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Envío finalizado!  Algunos numeros fallaron al enviarse"
                ProgressBar1.Value = TamañoProgressBar
                If MessageBox.Show("Algunos numeros fallaron al enviarse", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                ProgressBar1.Value = TamañoProgressBar
                LabelStatus.Text = "Envío finalizado!"
                If MessageBox.Show("Fin del proceso de envío", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            End If

            PictureBoxSuccess.Visible = True


        End If
    End Sub

    Private Sub BackgroundWorkerEnviarDocumentos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnviarDocumentos.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta - 1) + "/" + Convert.ToString(TamañoProgressBar)
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.Visible = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        LabelBotonEnviar.Visible = True
        LabelCuentaFallidos.Text = ""
        'HABILITAR BOTON PARA REENVIAR FALLIDOS
        If ListBoxFallidos.Items.Count > 0 Then
            ButtonReenviarFallidos.Enabled = True
            ButtonReenviarFallidos.Visible = True
            ButtonReenviarFallidos.BackColor = Color.Gold
        End If
        PictureBoxLoading.Visible = False
        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Envío finalizado!  Algunos numeros fallaron al enviarse"
                ProgressBar1.Value = TamañoProgressBar
                If MessageBox.Show("Algunos numeros fallaron al enviarse", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                ProgressBar1.Value = TamañoProgressBar
                LabelStatus.Text = "Envío finalizado!"
                If MessageBox.Show("Fin del proceso de envío", "Envío finalizado!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            End If

            PictureBoxSuccess.Visible = True


        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonReenviarFallidos.Click
        'Contadores
        cuenta = 1 'Lleva la cuenta de los elementos recorridos arriba del progressbar
        cuentaExitosos = 0
        cuentaInvalidos = 0
        cuentaFallidos = 0
        cuentaReenviadosFallidos = 0
        'Listbox
        ListBoxExitosos.Items.Clear()
        ListBoxSinWhatsapp.Items.Clear()
        ListBoxSinWhatsapp.Items.Clear()
        'Boton cancelar envio
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.Visible = False
        ButtonCancelarReenvio.Visible = True
        'Boton Enviar
        ButtonEnviar.Visible = False
        'Boton Renviar fallidos
        ButtonReenviarFallidos.Visible = False
        PictureBoxLoading.Visible = True
        'Label
        LabelCuentaFallidos.Text = ""
        LabelBotonEnviar.Visible = False

        If ListBoxReenviadosFallidos.Items.Count <> 0 Then
            ListBoxFallidos.Items.Clear() 'Limpio fallidos para agregar los reenviados que fallaron en el envio anterior
            For Each item As String In ListBoxReenviadosFallidos.Items
                ListBoxFallidos.Items.Add(item)
            Next
            ListBoxReenviadosFallidos.Items.Clear() 'Limpio el listbox de reenviados fallidos
        End If

        If RadioButtonTextoPlano.Checked Then
            'PROCESO DE ENVIO DE TEXTO PLANO
            If ListBoxFallidos.Items.Count = 0 Then 'Si la lista esta vacia
                ButtonReenviarFallidos.Visible = False
                MessageBox.Show("No hay elementos para reenviar")


            Else

                Try
                    PictureBoxLoading.Visible = True
                    If MessageBox.Show("Debe asegurarse que el teléfono y la sesion de whatsapp no sufran problemas de conexion" & vbCrLf & "" & vbCrLf & "Si sigue experimentando problemas de conexion inicie sesión con 4G", "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                    ButtonReenviarFallidos.Enabled = False
                    ButtonReenviarFallidos.Visible = False
                    BackgroundWorkerFallidosTextoPlano.RunWorkerAsync()
                Catch ex As Exception

                End Try
            End If


        Else
            If RadioButtonImagenesYVideo.Checked Then
                'PROCESO DE ENVIO MULTIMEDIA
                If ListBoxFallidos.Items.Count = 0 Then 'Si la lista esta vacia
                    ButtonReenviarFallidos.Visible = False
                    MessageBox.Show("No hay elementos para reenviar")

                Else
                    Try
                        If MessageBox.Show("Debe asegurarse que el teléfono y la sesion de whatsapp no sufran problemas de conexion" & vbCrLf & "" & vbCrLf & "Si sigue experimentando problemas de conexion inicie sesión con 4G", "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                        End If
                        ButtonReenviarFallidos.Enabled = False
                        ButtonReenviarFallidos.Visible = False
                        BackgroundWorkerFallidosMultimedia.RunWorkerAsync()
                    Catch ex As Exception

                    End Try
                End If

            Else
                If RadioButtonDocumentos.Checked Then
                    'PROCESO DE ENVIO DOCUMENTOS
                    If ListBoxFallidos.Items.Count = 0 Then 'Si la lista esta vacia
                        ButtonReenviarFallidos.Visible = False
                        MessageBox.Show("No hay elementos para reenviar")

                    Else

                        Try
                            If MessageBox.Show("Debe asegurarse que el teléfono y la sesion de whatsapp no sufran problemas de conexion" & vbCrLf & "" & vbCrLf & "Si sigue experimentando problemas de conexion inicie sesión con 4G", "IMPORTANTE!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                            End If
                            ButtonReenviarFallidos.Enabled = False
                            ButtonReenviarFallidos.Visible = False
                            BackgroundWorkerFallidosDocumentos.RunWorkerAsync()
                        Catch ex As Exception

                        End Try
                    End If

                End If
            End If
        End If
    End Sub
    'REENVIO DE FALLIDOS_______________________________________________________________________________________________________________________

    'REENVIO TEXTO PLANO///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub BackgroundWorkerFallidosTextoPlano_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFallidosTextoPlano.DoWork
        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarReenvio.Enabled = True
        ButtonCancelarReenvio.BackColor = Color.Red
        ButtonCancelarEnvio.Enabled = False
        LabelStatus.ForeColor = Color.Red
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"
        'Reinicio de elementos para reenvio
        LabelNumerosFallidos.ForeColor = Color.Red
        LabelNumerosFallidos.Text = "Reenviando"
        'Reiniciar variables
        cuenta = 0
        cuentaExitosos = 0
        cuentaInvalidos = 0
        cuentaFallidos = 0
        cuentaReenviadosFallidos = 0
        'Reiniciar labels
        LabelStatus.Text = "Status"
        LabelCuenta.Text = "0/0"
        LabelCuentaReenviadosFallidos.Text = "0"
        LabelCuentaSinWhatsapp.Text = "0"

        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver

            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerFallidosTextoPlano.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBoxFallidos.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos


                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBoxFallidos.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerFallidosTextoPlano.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If
                    'GENERAR URL DE API
                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerFallidosTextoPlano.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerFallidosTextoPlano.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)

                                If BackgroundWorkerFallidosTextoPlano.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerFallidosTextoPlano.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerFallidosTextoPlano.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ENVIAR DE WHATSAPP WEB
                                        Try
                                            Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                            Dim enviarMensaje As IWebElement
                                            enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/footer/div[1]/div[3]/button")))
                                            'enviarMensaje.Click()
                                            Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                            'MessageBox.Show("No se encontro el boton de enviar")
                                        End Try

                                    End If
                                Catch ex As Exception
                                    ListBoxReenviadosFallidos.Items.Add(item)
                                    cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                    LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception 'Exception de CONTROL VALIDOS E INVALIDOS
                            ListBoxReenviadosFallidos.Items.Add(item)
                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception 'Exception de GENERAR URL DE API
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                        LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                        ListBoxReenviadosFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True
    End Sub

    Private Sub BackgroundWorkerFallidosTextoPlano_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFallidosTextoPlano.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(TamañoProgressBar)
        'Boton Cancelar Reenvio
        ButtonCancelarReenvio.Enabled = False
        ButtonCancelarReenvio.Visible = False
        ButtonCancelarReenvio.BackColor = Color.Gray
        'Boton Reenviar Fallidos
        ButtonReenviarFallidos.Enabled = True
        ButtonReenviarFallidos.Visible = True
        'Label del boton
        LabelBotonEnviar.Visible = True
        'Boton Enviar
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        'PictureBox
        PictureBoxLoading.Visible = False
        'Label cabecera Numeros fallidos
        LabelNumerosFallidos.Text = "Numeros fallidos:"
        LabelNumerosFallidos.ForeColor = Color.Black
        'Label Status
        LabelStatus.Text = "0"

        If e.Cancelled Then
            LabelStatus.Text = "Reenvío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los reenvíos pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxReenviadosFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Reenvío finalizado! Algunos elementos no se reenviaron"
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                LabelStatus.Text = "Reenvío finalizado! Todos fueron reenviados exitosamente"
                ListBoxFallidos.Items.Clear()
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            End If

        End If
    End Sub

    Private Sub CheckBoxAgregarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAgregarTodos.CheckedChanged

    End Sub

    Private Sub BackgroundWorkerFallidosMultimedia_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFallidosMultimedia.DoWork
        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarReenvio.Enabled = True
        ButtonCancelarReenvio.BackColor = Color.Red
        ButtonCancelarEnvio.Enabled = False
        LabelStatus.ForeColor = Color.Red
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        intervalo = MaskedTextBoxIntervaloEntreChats.Text * 1000 'Convertir lo del Masked textbox a milisegundos
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"
        'Reinicio de elementos para reenvio
        LabelNumerosFallidos.ForeColor = Color.Red
        LabelNumerosFallidos.Text = "Reenviando"
        'Reiniciar variables
        cuenta = 0
        cuentaExitosos = 0
        cuentaInvalidos = 0
        cuentaFallidos = 0
        cuentaReenviadosFallidos = 0
        'Reiniciar labels
        LabelStatus.Text = "Status"
        LabelCuenta.Text = "0/0"
        LabelCuentaReenviadosFallidos.Text = "0"
        LabelCuentaSinWhatsapp.Text = "0"
        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver

            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerFallidosMultimedia.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBoxFallidos.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos



                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBoxFallidos.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If

                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)
                                If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ADJUNTAR
                                        Dim adjuntar As IWebElement
                                        Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                        adjuntar = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                                        adjuntar.Click() 'Click en el boton Adjuntar
                                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON FOTOS Y VIDEOS
                                        Try
                                            Dim foto As IWebElement
                                            foto = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[1]/button")))
                                            foto.Click() 'Abre el buscador de archivos
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)

                                            Continue For
                                        End Try

                                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If

                                        Try
                                            'EXPLORADOR DE ARCHIVOS
                                            SendKeys.SendWait(TextBoxRuta.Text)
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000)
                                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                                            'Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                                        Catch ex As Exception
                                            'MessageBox.Show("Error al apretar enter en explorador de archivos")
                                            cuenta = cuenta + 1
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)

                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                        End Try

                                        If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'CONTROLAR SI SE CARGÓ UNA IMAGEN
                                        Try
                                            Dim ProcesarImagenVideo As IWebElement
                                            Dim WaitProcesarImagenVideo As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxTiempoCargaImagenVideo.Text))
                                            ProcesarImagenVideo = WaitProcesarImagenVideo.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div")))
                                            If ProcesarImagenVideo.Displayed Then
                                                If BackgroundWorkerFallidosMultimedia.CancellationPending Then
                                                    e.Cancel = True
                                                    Exit For
                                                End If
                                                Try
                                                    If CheckBoxPieDeFoto.Checked Then
                                                        Dim inputPie As IWebElement
                                                        inputPie = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]")))
                                                        inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                                                    End If
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                                    LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro pie de foto")
                                                End Try
                                                'Pie de foto

                                                If BackgroundWorkerFallidosMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                                    e.Cancel = True
                                                    Exit For
                                                End If
                                                Try
                                                    'BOTON ENVIAR DE WHATSAPP WEB
                                                    Dim enviarMensaje As IWebElement
                                                    enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                                                    'enviarMensaje.Click()
                                                    Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                                    LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro el boton de enviar")
                                                End Try

                                            End If
                                        Catch ex As Exception
                                            ListBoxReenviadosFallidos.Items.Add(item)
                                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                            cuenta = cuenta + 1
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            'MessageBox.Show(ex.Message)
                                            Continue For

                                        End Try

                                    End If
                                Catch ex As Exception
                                    ListBoxReenviadosFallidos.Items.Add(item)
                                    cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                    LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception
                            ListBoxReenviadosFallidos.Items.Add(item)
                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                        LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                        ListBoxReenviadosFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub BackgroundWorkerFallidosMultimedia_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFallidosMultimedia.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(TamañoProgressBar)
        'Boton Cancelar Reenvio
        ButtonCancelarReenvio.Enabled = False
        ButtonCancelarReenvio.Visible = False
        ButtonCancelarReenvio.BackColor = Color.Gray
        'Boton Reenviar Fallidos
        ButtonReenviarFallidos.Enabled = True
        ButtonReenviarFallidos.Visible = True
        'Boton Enviar
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        'Label del boton
        LabelBotonEnviar.Visible = True
        'PictureBox
        PictureBoxLoading.Visible = False
        'Label cabecera Numeros fallidos
        LabelNumerosFallidos.Text = "Numeros fallidos:"
        LabelNumerosFallidos.ForeColor = Color.Black
        'Label Status
        LabelStatus.Text = "0"

        If e.Cancelled Then
            LabelStatus.Text = "Reenvío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los reenvíos pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxReenviadosFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Reenvío finalizado! Algunos elementos no se reenviaron"
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                LabelStatus.Text = "Reenvío finalizado! Todos fueron reenviados exitosamente"
                ListBoxFallidos.Items.Clear()
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            End If


        End If
    End Sub

    Private Sub BackgroundWorkerFallidosDocumentos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerFallidosDocumentos.DoWork
        CheckForIllegalCrossThreadCalls = False 'Se desactiva el checkeo de llamadas ilegales entre los diferentes hilos de ejecucion
        ButtonCancelarReenvio.Enabled = True
        ButtonCancelarReenvio.BackColor = Color.Red
        ButtonCancelarEnvio.Enabled = False
        LabelStatus.ForeColor = Color.Red
        ButtonCancelarEnvio.Enabled = True
        ButtonCancelarEnvio.BackColor = Color.Red
        ProgressBar1.Value = 0 ' Resetea la barra de progreso
        RadioButtonQuitar.Enabled = False
        CheckBoxAgregarTodos.Enabled = False
        ListBox1.Enabled = False
        ButtonLimpiarLista.Enabled = False
        Button2.Enabled = False
        DataGridView1.Enabled = False
        intervalo = MaskedTextBoxIntervaloEntreChats.Text * 1000 'Convertir lo del Masked textbox a milisegundos
        PictureBoxSuccess.Visible = False
        PictureBoxError.Visible = False
        LabelStatus.Text = "Esperando Inicio de sesión en WhatsApp Web"
        'Reinicio de elementos para reenvio
        LabelNumerosFallidos.ForeColor = Color.Red
        LabelNumerosFallidos.Text = "Reenviando"
        'Reiniciar variables
        cuenta = 0
        cuentaExitosos = 0
        cuentaInvalidos = 0
        cuentaFallidos = 0
        cuentaReenviadosFallidos = 0
        'Reiniciar labels
        LabelStatus.Text = "Status"
        LabelCuenta.Text = "0/0"
        LabelCuentaReenviadosFallidos.Text = "0"
        LabelCuentaSinWhatsapp.Text = "0"

        'PROCESO DE ENVÍO////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver

            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API//////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")

            '////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar. No manipular el navegador durante le proceso de envío", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(60))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerFallidosDocumentos.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 1 minuto", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try
                'PROGRESSBAR/////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBoxFallidos.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                TamañoProgressBar = totalContactos


                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR////////////////////
                For Each item As Object In ListBoxFallidos.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    Try
                        If totalContactos > cuenta Then
                            LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(totalContactos)
                        End If
                    Catch ex As Exception

                    End Try
                    If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                        e.Cancel = True
                        Exit For
                    End If

                    Try
                        Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)
                        driver.Navigate().GoToUrl(url)
                        Try
                            Dim send As IWebElement
                            Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                            send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                            send.Click()
                        Catch ex As Exception
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR Y SALIR DE PAGINA OFICIAL DE WHATSAPP AL ENTRAR CON CONTACTOS MAL ESCRITOS 
                        Try
                            Dim PaginaOficial As IWebElement
                            Dim waitPaginaOficial As New WebDriverWait(driver, TimeSpan.FromSeconds(3))
                            PaginaOficial = waitPaginaOficial.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='hide_till_load']/div[1]/div[2]")))
                            If PaginaOficial.Displayed Then
                                ListBoxSinWhatsapp.Items.Add(item)
                                cuentaInvalidos = cuentaInvalidos + 1
                                LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                cuenta = cuenta + 1
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                Continue For
                            End If
                        Catch ex As Exception
                            ' MessageBox.Show(ex.Message)
                            'MessageBox.Show("Pagina oficial")
                        End Try
                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                            e.Cancel = True
                            Exit For
                        End If

                        'CONTROLAR INVALIDOS Y VÁLIDOS
                        Try
                            Dim Interfacewhatsappweb As IWebElement
                            Dim waitInterfacewhatsappweb As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text))
                            Interfacewhatsappweb = waitInterfacewhatsappweb.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]")))
                            If Interfacewhatsappweb.Displayed Then
                                Threading.Thread.Sleep(1000)
                                If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If

                                'PARA NUMEROS INVALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[contains(text(), 'El número de teléfono compartido a través de la dirección URL es inválido')]")).Displayed Then 'Invalido
                                        'Agregar a una lista sin whatsapp
                                        ListBoxSinWhatsapp.Items.Add(item)
                                        cuentaInvalidos = cuentaInvalidos + 1
                                        LabelCuentaSinWhatsapp.Text = Convert.ToString(cuentaInvalidos)
                                        cuenta = cuenta + 1
                                        ProgressBar1.Value = ProgressBar1.Value + 1
                                        Continue For
                                    End If
                                Catch ex As Exception
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show("NUMEOR INVALIDO")
                                End Try
                                If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                                    e.Cancel = True
                                    Exit For
                                End If
                                'PARA NUMEROS VALIDOS
                                Try
                                    If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Parte del chat
                                        Threading.Thread.Sleep(1000)
                                        'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON ADJUNTAR
                                        Dim adjuntar As IWebElement
                                        Dim waitContacto As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperaMaximaDOM.Text))
                                        adjuntar = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                                        adjuntar.Click() 'Click en el boton Adjuntar

                                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'BOTON DOCUMENTOS
                                        Dim documento As IWebElement
                                        Try
                                            documento = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[3]/button")))
                                            documento.Click() 'Abre el buscador de archivos
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                                        Catch ex As Exception
                                            cuenta = cuenta + 1
                                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                            Continue For
                                        End Try

                                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If

                                        Try
                                            'EXPLORADOR DE ARCHIVOS
                                            SendKeys.SendWait(TextBoxRutaDocumento.Text)
                                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000)
                                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                                            'Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                                        Catch ex As Exception
                                            'MessageBox.Show("Error al apretar enter en explorador de archivos")
                                            cuenta = cuenta + 1
                                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            Continue For
                                        End Try

                                        If BackgroundWorkerFallidosDocumentos.CancellationPending Then
                                            e.Cancel = True
                                            Exit For
                                        End If
                                        'CONTROLAR SI SE CARGÓ EL DOCUMENTO
                                        Try
                                            Dim ProcesarImagenVideo As IWebElement
                                            Dim WaitProcesarImagenVideo As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxTiempoCargaImagenVideo.Text))
                                            ProcesarImagenVideo = WaitProcesarImagenVideo.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div")))
                                            If ProcesarImagenVideo.Displayed Then
                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then
                                                    e.Cancel = True
                                                    Exit For
                                                End If
                                                Try
                                                    If CheckBoxPieDeFoto.Checked Then
                                                        Dim inputPie As IWebElement
                                                        inputPie = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]")))
                                                        inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                                                    End If
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro pie de foto")
                                                End Try
                                                'Pie de foto

                                                If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                                    e.Cancel = True
                                                    Exit For
                                                End If

                                                'BOTON ENVIAR DE WHATSAPP WEB
                                                Try

                                                    Dim enviarMensaje As IWebElement
                                                    enviarMensaje = waitContacto.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                                                    'enviarMensaje.Click()
                                                    Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                                                Catch ex As Exception
                                                    cuenta = cuenta + 1
                                                    cuentaFallidos = cuentaFallidos + 1
                                                    LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                                    Continue For
                                                    'MessageBox.Show("No se encontro el boton de enviar")
                                                End Try

                                            End If
                                        Catch ex As Exception
                                            ListBoxFallidos.Items.Add(item)
                                            cuentaFallidos = cuentaFallidos + 1
                                            LabelCuentaFallidos.Text = Convert.ToString(cuentaFallidos)
                                            cuenta = cuenta + 1
                                            ProgressBar1.Value = ProgressBar1.Value + 1
                                            'MessageBox.Show(ex.Message)
                                            Continue For
                                        End Try


                                    End If
                                Catch ex As Exception
                                    ListBoxFallidos.Items.Add(item)
                                    cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                                    LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                                    cuenta = cuenta + 1
                                    ProgressBar1.Value = ProgressBar1.Value + 1
                                    Continue For
                                    'MessageBox.Show(ex.Message)
                                    'MessageBox.Show(" Fallo en numero valido")
                                End Try
                            End If
                        Catch ex As Exception
                            ListBoxFallidos.Items.Add(item)
                            cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                            LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                            cuenta = cuenta + 1
                            ProgressBar1.Value = ProgressBar1.Value + 1
                            Continue For
                        End Try
                        'EXITOSOS
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                        cuenta = cuenta + 1
                        cuentaExitosos = cuentaExitosos + 1
                        LabelEnviadosExitosos.Text = "Se enviaron a " + Convert.ToString(cuentaExitosos) + " " + "contactos"
                        ListBoxExitosos.Items.Add(item)
                    Catch ex As Exception
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        cuenta = cuenta + 1
                        cuentaReenviadosFallidos = cuentaReenviadosFallidos + 1
                        LabelCuentaReenviadosFallidos.Text = Convert.ToString(cuentaReenviadosFallidos)
                        ListBoxReenviadosFallidos.Items.Add(item)
                    End Try
                Next
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'MessageBox.Show("Fallo en try principal del envio de multimedia")
        End Try
        RadioButtonQuitar.Enabled = True
        CheckBoxAgregarTodos.Enabled = True
        ListBox1.Enabled = True
        ButtonLimpiarLista.Enabled = True
        Button2.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub BackgroundWorkerFallidosDocumentos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerFallidosDocumentos.RunWorkerCompleted
        LabelCuenta.Text = Convert.ToString(cuenta) + "/" + Convert.ToString(TamañoProgressBar)
        'Boton Cancelar Reenvio
        ButtonCancelarReenvio.Enabled = False
        ButtonCancelarReenvio.Visible = False
        ButtonCancelarReenvio.BackColor = Color.Gray
        'Boton Reenviar Fallidos
        ButtonReenviarFallidos.Enabled = True
        ButtonReenviarFallidos.Visible = True
        'Boton Enviar
        ButtonEnviar.Enabled = True
        ButtonEnviar.Visible = True
        'Label del boton
        LabelBotonEnviar.Visible = True
        'PictureBox
        PictureBoxLoading.Visible = False
        'Label cabecera Numeros fallidos
        LabelNumerosFallidos.Text = "Numeros fallidos:"
        LabelNumerosFallidos.ForeColor = Color.Black
        'Label Status
        LabelStatus.Text = "0"

        If e.Cancelled Then
            LabelStatus.Text = "Reenvío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los reenvíos pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            If ListBoxReenviadosFallidos.Items.Count > 0 Then
                LabelStatus.Text = "Reenvío finalizado! Algunos elementos no se reenviaron"
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            Else
                LabelStatus.Text = "Reenvío finalizado! Todos fueron reenviados exitosamente"
                ListBoxFallidos.Items.Clear()
                PictureBoxSuccess.Visible = True
                If MessageBox.Show("Reenvío finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                End If
            End If

        End If
    End Sub

    Private Sub ButtonCancelarReenvio_Click(sender As Object, e As EventArgs) Handles ButtonCancelarReenvio.Click
        LabelCuenta.Text = "0/0"
        'Cancela el Background Worker de fallidos
        If BackgroundWorkerFallidosTextoPlano.IsBusy Then
            If BackgroundWorkerFallidosTextoPlano.WorkerSupportsCancellation Then
                If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    BackgroundWorkerFallidosTextoPlano.CancelAsync()
                End If

            End If
        Else
            If BackgroundWorkerFallidosMultimedia.IsBusy Then
                If BackgroundWorkerFallidosMultimedia.WorkerSupportsCancellation Then
                    If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                        BackgroundWorkerFallidosMultimedia.CancelAsync()
                    End If

                End If
            Else
                If BackgroundWorkerFallidosDocumentos.IsBusy Then
                    If BackgroundWorkerFallidosDocumentos.WorkerSupportsCancellation Then
                        If MessageBox.Show("¿Está seguro de cancelar todos los envíos?", "ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                            BackgroundWorkerFallidosDocumentos.CancelAsync()
                        End If

                    End If

                End If
            End If

        End If
    End Sub

    Private Sub ListBoxFallidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFallidos.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class