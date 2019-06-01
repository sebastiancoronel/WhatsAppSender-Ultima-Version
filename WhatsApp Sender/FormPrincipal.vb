Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System.Data.OleDb
Imports System.Text.RegularExpressions



Public Class FormPrincipal
    Dim i As Integer
    Dim intervalo As Integer


    'Delegate Sub RichtextboxMensaje(ByVal mensaje As String)

    Private Sub ButtonEnviarTexto_Click(sender As Object, e As EventArgs) Handles ButtonEnviarTexto.Click
        Try
            BackgroundWorkerEnviarTextoPlano.RunWorkerAsync() 'Inicia el trabajo en segundo plano
        Catch ex As Exception

        End Try
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
            'Label7.ForeColor = Color.Gray
            'CheckBoxPieDeFoto.ForeColor = Color.Gray
            'ButtonFolder.Enabled = False
            'CheckBoxPieDeFoto.Enabled = False
            'ButtonFolder.BackColor = Color.Gray
            'ButtonEnviarImagen.Enabled = False
            'ButtonEnviarImagen.BackColor = Color.Gray
            'CheckBoxPieDeFoto.Checked = False
            'RichTextBoxPieDeFoto.Enabled = False
            'GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            'TextBoxRuta.Clear()
            'RadioButtonImagenesYVideo.Checked = False
        Else
            Try
                BackgroundWorkerEnviarMultimedia.RunWorkerAsync()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ButtonEnviarDocumento_Click_1(sender As Object, e As EventArgs) Handles ButtonEnviarDocumento.Click
        If ListBox1.Items.Count = 0 Then 'Si la lista esta vacia
            MessageBox.Show("La lista de destinatrios se encuentra vacía. Agregue destinatarios para comenzar a enviar mensajes")
            'Label7.ForeColor = Color.Gray
            'CheckBoxPieDeFoto.ForeColor = Color.Gray
            'ButtonFolder.Enabled = False
            'CheckBoxPieDeFoto.Enabled = False
            'ButtonFolder.BackColor = Color.Gray
            'ButtonEnviarImagen.Enabled = False
            'ButtonEnviarImagen.BackColor = Color.Gray
            'CheckBoxPieDeFoto.Checked = False
            'RichTextBoxPieDeFoto.Enabled = False
            'GroupBoxImagenesYVideo.BackColor = Color.Gainsboro
            'TextBoxRuta.Clear()
            'RadioButtonDocumentos.Checked = False
        Else
            'ENVIAR DOCUMENTOS
            Try
                BackgroundWorkerEnviarDocumentos.RunWorkerAsync()
            Catch ex As Exception

            End Try
        End If

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
        Else
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

        'PROCESO DE ENVÍO DE TEXTO PLANO////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

            'CONSTRUIR URL PARA API/////////////////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")
            '//////////////////////////////////////////////////////////////////////////////////////////////////////

            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If

            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar.", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarTextoPlano.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 2 minutos", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If

                End Try
                'PROGRESSBAR//////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR/////////////////////////////////////////////////////////////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    If BackgroundWorkerEnviarTextoPlano.CancellationPending Then 'Si cancelo salgo del bucle FOR
                        e.Cancel = True
                        Exit For
                    End If
                    Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                    driver.Navigate().GoToUrl(url)
                    Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                    Dim send As IWebElement
                    send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))

                    If BackgroundWorkerEnviarTextoPlano.CancellationPending Then 'Si cancelo salgo del bucle FOR
                        e.Cancel = True
                        Exit For
                    End If
                    'AQUÍ YA INICIA EL CHAT///////////////////////////////////////////////////////////////////////////////////////////////
                    send.Click() 'Iniciar chat
                    'CONTROLO INEXISTENTES///////////////////////////////////////////////////////////////////////////////////////////////

                    'Threading.Thread.Sleep(5000) 'Espera un tiempo al apretar send de la api para preguntar si encontro la parte del chat o es un inexistente (Tratar de reemplazarlo por un WaitHelper)
                    Try
                        Dim waitParteChat As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)) 'Espera solo 15 segundos la parte de chat
                        Dim parteChat As IWebElement
                        parteChat = waitParteChat.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/div[1]")))
                    Catch ex As Exception

                    End Try

                    Try
                        If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Si encuentra la parte de Chat
                            Dim enviarMensaje As IWebElement
                            enviarMensaje = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/footer/div[1]/div[3]/button")))
                            'enviarMensaje.Click()
                            Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000) 'Transforma el tiempo de espera entre chats del maskedtextbox a milisegundos
                        End If
                    Catch ex As Exception
                        ListViewFallidos.Items.Add(item)
                    End Try
                    If BackgroundWorkerEnviarTextoPlano.CancellationPending Then 'Si cancelo salgo del bucle FOR
                        e.Cancel = True
                        Exit For
                    End If
                    'MOSTRAR PROGRESO///////////////////////////////////////////////////////////////////////////////////////
                    Try
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                    Catch ex As Exception

                    End Try
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////
                Next
            Else
            End If
        End If
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
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            LabelStatus.Text = "Envío finalizado!"
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

        'PROCESO DE ENVÍO MULTIMEDIA////////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver
            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API/////////////////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")
            '//////////////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

            End If

            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarMultimedia.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 2 minutos", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try

                'PROGRESSBAR//////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR///////////////////////////////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                        e.Cancel = True
                        Exit For
                    End If
                    Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                    driver.Navigate().GoToUrl(url) 'Abre la url generada con la MISMA SESION!!!!
                    'EXPLICIT WAITS: 'Con esto no sería necesario usar los Threading Sleep-------------------------------------------------------------------------------
                    Dim send As IWebElement
                    Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                    send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                    '----------------------------------------------------------------------------------------------------------------------------------------------------
                    'INICIA EL CHAT
                    send.Click() 'Iniciar chat
                    'CONTROLO INEXISTENTES///////////////////////////////////////////////////////////////////////////////////////////////
                    'Threading.Thread.Sleep(10000) 'Espera un tiempo al apretar send de la api para preguntar si encontro la parte del chat o es un inexistente (Tratar de reemplazarlo por un WaitHelper)
                    Try
                        Dim waitParteChat As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)) 'Espera solo 15 segundos la parte de chat
                        Dim parteChat As IWebElement
                        parteChat = waitParteChat.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/div[1]")))
                    Catch ex As Exception

                    End Try
                    Try 'Intenta encontrar si es un chat o si el contacto no es disponible para whatsapp
                        If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Si encuentra la parte de Chat
                            'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                            If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                e.Cancel = True
                                Exit For
                            End If
                            'BOTON ADJUNTAR
                            Dim adjuntar As IWebElement
                            adjuntar = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                            adjuntar.Click() 'Click en el boton Adjuntar
                            'BOTON FOTOS Y VIDEOS
                            Dim foto As IWebElement
                            foto = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[1]/button")))
                            foto.Click() 'Abre el buscador de archivos
                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                            'EXPLORADOR DE ARCHIVOS
                            SendKeys.SendWait(TextBoxRuta.Text)
                            Threading.Thread.Sleep(2000)
                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                            Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                            '///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                            'Pie de foto
                            If CheckBoxPieDeFoto.Checked Then
                                Dim inputPie As IWebElement
                                inputPie = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/span/div/div[2]/div/div[3]/div[1]/div[2]")))
                                inputPie.SendKeys(RichTextBoxPieDeFoto.Text)
                            End If
                            If BackgroundWorkerEnviarMultimedia.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                e.Cancel = True
                                Exit For
                            End If
                            'BOTON ENVIAR DE WHATSAPP WEB
                            Dim enviarMensaje As IWebElement
                            enviarMensaje = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                            'enviarMensaje.Click()
                            Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                        End If
                    Catch ex As Exception
                        ListViewFallidos.Items.Add(item)
                        ' MessageBox.Show("Fallo en try que controla inexistentes")
                        'MessageBox.Show(ex.Message)
                    End Try
                    'MOSTRAR PROGRESO///////////////////////////////////////////////////////////////////////////////////////
                    Try
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                    Catch ex As Exception
                        'MessageBox.Show(ex.Message)
                        'MessageBox.Show("Fallo en try del progressbar")
                    End Try
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////
                Next
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
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

        'PROCESO DE ENVÍO DE DOCUMENTOS//////////////////////////////////////////////////////////////////////////////
        Try
            Dim driver As IWebDriver
            driver = New ChromeDriver
            driver.Manage().Window.Maximize()
            'CONSTRUIR URL PARA API/////////////////////////////////////////////////////////////////////////////////
            Dim a As String = "https://wa.me/"
            Dim encabezado As String = "?text="
            Dim mensaje As String = RichTextBox1.Text
            driver.Navigate().GoToUrl("https://web.whatsapp.com/")
            '//////////////////////////////////////////////////////////////////////////////////////////////////////
            If MessageBox.Show("1° PASO: ESCANEAR CODIGO QR " & vbCrLf & "" & vbCrLf & "2° PASO: PRESIONE ACEPTAR PARA CONTINUAR", "IMPORTANTE!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then

            End If

            If MessageBox.Show("Si ya inició sesión en WhtasApp web haga click en Aceptar para comenzar a enviar", "ATENCIÓN!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                Dim whatsappWebListo As IWebElement
                Dim EsperarSesion As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                Try
                    whatsappWebListo = EsperarSesion.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[4]/div/div/div[2]/h1")))
                Catch ex As Exception
                    BackgroundWorkerEnviarMultimedia.CancelAsync()
                    If MessageBox.Show("Se detuvo el envío de mensajes despues de 2 minutos", "No se inició sesión en whatsapp web", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
                    End If
                End Try

                'PROGRESSBAR//////////////////////////////////////////////////////////////////////////////////////////////////////
                Dim totalContactos As Integer = ListBox1.Items.Count 'Guardo el total de items de la lista en una variable
                ProgressBar1.Maximum = totalContactos
                '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                'FOR EACH PARA IR GENERARANDO URL PARA ENVIAR A NUMEROS SIN AGENDAR///////////////////////////////////////////////
                For Each item As Object In ListBox1.Items 'Recorre la lista y envia a los destinatarios en la lista que coinciden con los contactos almacenados
                    LabelStatus.Text = "Enviando mensaje a " + Convert.ToString(item)
                    If BackgroundWorkerEnviarDocumentos.CancellationPending Then 'Si cancelo salgo del bucle FOR
                        e.Cancel = True
                        Exit For
                    End If
                    Dim url As String = a + item + encabezado + mensaje 'Crea la Url de la api
                    driver.Navigate().GoToUrl(url) 'Abre la url generada con la MISMA SESION!!!!
                    Dim send As IWebElement
                    Dim wait As New WebDriverWait(driver, TimeSpan.FromSeconds(120))
                    send = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='action-button']")))
                    send.Click() 'Iniciar chat
                    'INICIA PROCESO DE CHAT///////////////////////////////////////////////////////////////////////////////////////////////

                    'CONTROLO INEXISTENTES///////////////////////////////////////////////////////////////////////////////////////////////
                    'Threading.Thread.Sleep(10000) 'Espera un tiempo al apretar send de la api para preguntar si encontro la parte del chat o es un inexistente (Tratar de reemplazarlo por un WaitHelper)
                    Try
                        Dim waitParteChat As New WebDriverWait(driver, TimeSpan.FromSeconds(MaskedTextBoxEsperarParteChat.Text)) 'Espera solo 15 segundos la parte de chat
                        Dim parteChat As IWebElement
                        parteChat = waitParteChat.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/div[1]")))
                    Catch ex As Exception

                    End Try
                    Try 'Intenta encontrar si es un chat o si el contacto no es disponible para whatsapp
                        If driver.FindElement(By.XPath("//*[@id='main']/div[1]")).Displayed Then 'Si encuentra la parte de Chat
                            'PROCESO PARA ADJUNTAR ARCHIVOS//////////////////////////////////////////////////////////////////////////////
                            If BackgroundWorkerEnviarDocumentos.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                e.Cancel = True
                                Exit For
                            End If
                            'BOTON ADJUNTAR
                            Dim adjuntar As IWebElement
                            adjuntar = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]")))
                            adjuntar.Click() 'Click en el boton Adjuntar
                            'BOTON DOCUMENTOS
                            Dim documento As IWebElement
                            documento = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='main']/header/div[3]/div/div[2]/span/div/div/ul/li[3]/button")))
                            documento.Click() 'Abre el buscador de archivos
                            Threading.Thread.Sleep(MaskedTextBoxExploradorDeArchivos.Text * 1000) 'Esperar lo que se establece en el MaskedTextbox del panel
                            'EXPLORADOR DE ARCHIVOS
                            SendKeys.SendWait(TextBoxRutaDocumento.Text)
                            Threading.Thread.Sleep(2000)
                            SendKeys.SendWait("{Enter}") ' Click en Aceptar del explorador
                            Threading.Thread.Sleep(MaskedTextBoxTiempoCargaImagenVideo.Text * 1000) 'Espera que se carguen todas las fotos 'PROBAR DE ESPERAR MAS TIEMPO PARA CARGAR VIDEOS
                            '///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                            If BackgroundWorkerEnviarDocumentos.CancellationPending Then 'Si cancelo salgo del bucle FOR
                                e.Cancel = True
                                Exit For
                            End If
                            'BOTON ENVIAR DE WHATSAPP WEB
                            Dim enviarMensaje As IWebElement
                            enviarMensaje = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind:="//*[@id='app']/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/span[2]/div/div")))
                            'enviarMensaje.Click()
                            Threading.Thread.Sleep(MaskedTextBoxIntervaloEntreChats.Text * 1000)
                        End If
                    Catch ex As Exception
                        ListViewFallidos.Items.Add(item)
                        ' MessageBox.Show("Fallo en try que controla inexistentes")
                        'MessageBox.Show(ex.Message)
                    End Try
                    'MOSTRAR PROGRESO///////////////////////////////////////////////////////////////////////////////////////
                    Try
                        ProgressBar1.Value = ProgressBar1.Value + 1 'Se va incrementando llenando la barra de progreso
                    Catch ex As Exception
                        'MessageBox.Show(ex.Message)
                        'MessageBox.Show("Fallo en try del progressbar")
                    End Try
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////
                Next
            End If

        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
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
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            LabelStatus.Text = "Envío finalizado!"
            PictureBoxSuccess.Visible = True
            'If MessageBox.Show("El proceso de envío ha finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            'End If

        End If
    End Sub

    Private Sub BackgroundWorkerEnviarDocumentos_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerEnviarDocumentos.RunWorkerCompleted
        ButtonCancelarEnvio.Enabled = False
        ButtonCancelarEnvio.BackColor = Color.Gray
        If e.Cancelled Then
            LabelStatus.Text = "Envío cancelado!"
            ProgressBar1.Value = 0
            PictureBoxError.Visible = True
            If MessageBox.Show("Se cancelaron todos los envios pendientes", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            End If
        Else
            LabelStatus.Text = "Envío finalizado!"
            PictureBoxSuccess.Visible = True
            'If MessageBox.Show("El proceso de envío ha finalizado", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) = DialogResult.OK Then
            'End If

        End If
    End Sub
End Class