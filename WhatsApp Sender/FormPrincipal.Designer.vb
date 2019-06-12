<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxSeleccionar29 = New System.Windows.Forms.CheckBox()
        Me.RadioButtonQuitar = New System.Windows.Forms.RadioButton()
        Me.CheckBoxSeleccionar31 = New System.Windows.Forms.CheckBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.MaskedTextBoxIntervaloEntreChats = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxExploradorDeArchivos = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxTiempoCargaImagenVideo = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBoxError = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSuccess = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxEsperarParteChat = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.ButtonReenviarFallidos = New System.Windows.Forms.Button()
        Me.PictureBoxLoading = New System.Windows.Forms.PictureBox()
        Me.ListBoxFallidos = New System.Windows.Forms.ListBox()
        Me.ListBoxReenviadosFallidos = New System.Windows.Forms.ListBox()
        Me.ButtonCancelarReenvio = New System.Windows.Forms.Button()
        Me.CheckBoxAgregarTodos = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxEsperaMaximaDOM = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialogImagenes = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogDocumentos = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorkerEnviarTextoPlano = New System.ComponentModel.BackgroundWorker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonCancelarEnvio = New System.Windows.Forms.Button()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonTextoPlano = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButtonDocumentos = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButtonImagenesYVideo = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDocumentos = New System.Windows.Forms.GroupBox()
        Me.TextBoxRutaDocumento = New System.Windows.Forms.TextBox()
        Me.ButtonEnviarDocumento = New System.Windows.Forms.Button()
        Me.ButtonFolderDocumento = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxImagenesYVideo = New System.Windows.Forms.GroupBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBoxImagenAEnviar = New System.Windows.Forms.PictureBox()
        Me.ButtonEnviarImagen = New System.Windows.Forms.Button()
        Me.RichTextBoxPieDeFoto = New System.Windows.Forms.RichTextBox()
        Me.CheckBoxPieDeFoto = New System.Windows.Forms.CheckBox()
        Me.TextBoxRuta = New System.Windows.Forms.TextBox()
        Me.ButtonFolder = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxTextoPlano = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButtonEnviarTexto = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonLimpiarLista = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BackgroundWorkerEnviarMultimedia = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerEnviarDocumentos = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerFallidosTextoPlano = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerFallidosMultimedia = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerFallidosDocumentos = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBoxDocumentos.SuspendLayout()
        Me.GroupBoxImagenesYVideo.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxImagenAEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxTextoPlano.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 15000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(961, 0)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 31
        Me.PictureBox12.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox12, "Envía solo texto plano")
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(961, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 30
        Me.PictureBox11.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox11, "Permite enviar Imagenes en .dib, .webp, .jpeg, .svgz, .gif;  .jpg; .ico; .png; .s" &
        "vg; .tif; .xbm; .bmp; .jfif; .pjp; .tiff; .mp4; .m4u; .3gpp; .mov")
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(964, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 29
        Me.PictureBox8.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox8, "Permite enviar Documentos (.docx, .xlsx, .pdf, .ppt etc. y Archivos .exe, .rar, ." &
        "zip etc.)")
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(974, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(154, 537)
        Me.ListBox1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ListBox1, "Lista de destinatarios a los que se enviarán los mensajes")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(52, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Importar contactos"
        Me.ToolTip1.SetToolTip(Me.Button2, "Solo en formato .csv")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 17
        Me.PictureBox10.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox10, resources.GetString("PictureBox10.ToolTip"))
        '
        'CheckBoxSeleccionar29
        '
        Me.CheckBoxSeleccionar29.AutoSize = True
        Me.CheckBoxSeleccionar29.ForeColor = System.Drawing.Color.White
        Me.CheckBoxSeleccionar29.Location = New System.Drawing.Point(36, 49)
        Me.CheckBoxSeleccionar29.Name = "CheckBoxSeleccionar29"
        Me.CheckBoxSeleccionar29.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxSeleccionar29.TabIndex = 33
        Me.CheckBoxSeleccionar29.Text = "Ocultar los primeros 29"
        Me.ToolTip1.SetToolTip(Me.CheckBoxSeleccionar29, "Selecciona para ocultar las primeras 29 0 31 excepto el nombre (Column 0)")
        Me.CheckBoxSeleccionar29.UseVisualStyleBackColor = True
        '
        'RadioButtonQuitar
        '
        Me.RadioButtonQuitar.AutoSize = True
        Me.RadioButtonQuitar.ForeColor = System.Drawing.Color.White
        Me.RadioButtonQuitar.Location = New System.Drawing.Point(36, 91)
        Me.RadioButtonQuitar.Name = "RadioButtonQuitar"
        Me.RadioButtonQuitar.Size = New System.Drawing.Size(115, 17)
        Me.RadioButtonQuitar.TabIndex = 13
        Me.RadioButtonQuitar.TabStop = True
        Me.RadioButtonQuitar.Text = "Quitar destinatarios"
        Me.ToolTip1.SetToolTip(Me.RadioButtonQuitar, "Quita un elemento de la lista de destinatarios")
        Me.RadioButtonQuitar.UseVisualStyleBackColor = True
        '
        'CheckBoxSeleccionar31
        '
        Me.CheckBoxSeleccionar31.AutoSize = True
        Me.CheckBoxSeleccionar31.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.CheckBoxSeleccionar31.ForeColor = System.Drawing.Color.White
        Me.CheckBoxSeleccionar31.Location = New System.Drawing.Point(36, 72)
        Me.CheckBoxSeleccionar31.Name = "CheckBoxSeleccionar31"
        Me.CheckBoxSeleccionar31.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxSeleccionar31.TabIndex = 49
        Me.CheckBoxSeleccionar31.Text = "Ocultar los primeros 31"
        Me.ToolTip1.SetToolTip(Me.CheckBoxSeleccionar31, "Oculta las primeras 31 columnas de la tabla")
        Me.CheckBoxSeleccionar31.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(1119, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Los contactos en esta lista seran los destinatarios de todos los mensajes")
        '
        'MaskedTextBoxIntervaloEntreChats
        '
        Me.MaskedTextBoxIntervaloEntreChats.Location = New System.Drawing.Point(176, 56)
        Me.MaskedTextBoxIntervaloEntreChats.Mask = "999"
        Me.MaskedTextBoxIntervaloEntreChats.Name = "MaskedTextBoxIntervaloEntreChats"
        Me.MaskedTextBoxIntervaloEntreChats.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBoxIntervaloEntreChats.TabIndex = 55
        Me.MaskedTextBoxIntervaloEntreChats.Text = "10"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBoxIntervaloEntreChats, "Tiempo a esperar para entregar un mensaje")
        Me.MaskedTextBoxIntervaloEntreChats.ValidatingType = GetType(Integer)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(10, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Esperar envío al destinatario"
        Me.ToolTip1.SetToolTip(Me.Label14, "Tiempo hasta que el mensaje enviado sea recibido por el destinatario antes que se" &
        " pase al siguiente contacto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ". Para videos o documentos pesados se recomiendan m" &
        "as de 20 segundos")
        '
        'MaskedTextBoxExploradorDeArchivos
        '
        Me.MaskedTextBoxExploradorDeArchivos.Enabled = False
        Me.MaskedTextBoxExploradorDeArchivos.Location = New System.Drawing.Point(146, 80)
        Me.MaskedTextBoxExploradorDeArchivos.Mask = "999"
        Me.MaskedTextBoxExploradorDeArchivos.Name = "MaskedTextBoxExploradorDeArchivos"
        Me.MaskedTextBoxExploradorDeArchivos.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBoxExploradorDeArchivos.TabIndex = 61
        Me.MaskedTextBoxExploradorDeArchivos.Text = "2"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBoxExploradorDeArchivos, "Tiempo a esperar para entregar un mensaje")
        Me.MaskedTextBoxExploradorDeArchivos.ValidatingType = GetType(Integer)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(3, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 13)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Esperar explorador archivos"
        Me.ToolTip1.SetToolTip(Me.Label10, "Tiempo a esperar para enviar")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Gray
        Me.Label16.Location = New System.Drawing.Point(213, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 13)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Esperar procesamiento del archivo"
        Me.ToolTip1.SetToolTip(Me.Label16, "Tiempo para que Whatsapp Web procese el archivo luego de seleccionarlo del explor" &
        "ador de archivos de windows y antes de enviarlo")
        '
        'MaskedTextBoxTiempoCargaImagenVideo
        '
        Me.MaskedTextBoxTiempoCargaImagenVideo.Enabled = False
        Me.MaskedTextBoxTiempoCargaImagenVideo.Location = New System.Drawing.Point(383, 80)
        Me.MaskedTextBoxTiempoCargaImagenVideo.Mask = "999"
        Me.MaskedTextBoxTiempoCargaImagenVideo.Name = "MaskedTextBoxTiempoCargaImagenVideo"
        Me.MaskedTextBoxTiempoCargaImagenVideo.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBoxTiempoCargaImagenVideo.TabIndex = 63
        Me.MaskedTextBoxTiempoCargaImagenVideo.Text = "5"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBoxTiempoCargaImagenVideo, "Tiempo a esperar para entregar un mensaje. Para videos se recomienda como minimo " &
        "10 segundos")
        Me.MaskedTextBoxTiempoCargaImagenVideo.ValidatingType = GetType(Integer)
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(414, 80)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 64
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Los archivos de video tardarán mas tiempo en procesarse dependiendo de la velocid" &
        "ad a internet y el tamaño del archivo")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(177, 80)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 65
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Tiempo de espera hasta que el explorador de archivos de windows esté listo para b" &
        "uscar el archivo")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "Tiempos"
        Me.ToolTip1.SetToolTip(Me.Label17, "Tiempo a esperar para enviar")
        '
        'PictureBoxError
        '
        Me.PictureBoxError.Image = CType(resources.GetObject("PictureBoxError.Image"), System.Drawing.Image)
        Me.PictureBoxError.Location = New System.Drawing.Point(6, 6)
        Me.PictureBoxError.Name = "PictureBoxError"
        Me.PictureBoxError.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxError.TabIndex = 68
        Me.PictureBoxError.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBoxError, "Tiempo de espera hasta que el explorador de archivos de windows esté listo para b" &
        "uscar el archivo")
        Me.PictureBoxError.Visible = False
        '
        'PictureBoxSuccess
        '
        Me.PictureBoxSuccess.Image = CType(resources.GetObject("PictureBoxSuccess.Image"), System.Drawing.Image)
        Me.PictureBoxSuccess.Location = New System.Drawing.Point(6, 6)
        Me.PictureBoxSuccess.Name = "PictureBoxSuccess"
        Me.PictureBoxSuccess.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxSuccess.TabIndex = 68
        Me.PictureBoxSuccess.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBoxSuccess, "Tiempo de espera hasta que el explorador de archivos de windows esté listo para b" &
        "uscar el archivo")
        Me.PictureBoxSuccess.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(10, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 13)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Esperar para abrir un nuevo chat"
        Me.ToolTip1.SetToolTip(Me.Label18, "Tiempo de espera al iniciar un nuevo chat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en whatsapp web")
        '
        'MaskedTextBoxEsperarParteChat
        '
        Me.MaskedTextBoxEsperarParteChat.Location = New System.Drawing.Point(176, 92)
        Me.MaskedTextBoxEsperarParteChat.Mask = "999"
        Me.MaskedTextBoxEsperarParteChat.Name = "MaskedTextBoxEsperarParteChat"
        Me.MaskedTextBoxEsperarParteChat.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBoxEsperarParteChat.TabIndex = 59
        Me.MaskedTextBoxEsperarParteChat.Text = "15"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBoxEsperarParteChat, "Tiempo a esperar para entregar un mensaje")
        Me.MaskedTextBoxEsperarParteChat.ValidatingType = GetType(Integer)
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(206, 56)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 65
        Me.PictureBox14.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox14, "Los archivos de video tardarán mas tiempo en recibirse por el contacto dependiend" &
        "o de la velocidad a internet y el tamaño del archivo.")
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), System.Drawing.Image)
        Me.PictureBox15.Location = New System.Drawing.Point(206, 92)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox15.TabIndex = 66
        Me.PictureBox15.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox15, "Tiempo de espera hasta entrar a la pantalla de WhatsApp web")
        '
        'ButtonReenviarFallidos
        '
        Me.ButtonReenviarFallidos.BackColor = System.Drawing.Color.Gray
        Me.ButtonReenviarFallidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonReenviarFallidos.Enabled = False
        Me.ButtonReenviarFallidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonReenviarFallidos.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReenviarFallidos.Location = New System.Drawing.Point(1011, 97)
        Me.ButtonReenviarFallidos.Name = "ButtonReenviarFallidos"
        Me.ButtonReenviarFallidos.Size = New System.Drawing.Size(115, 35)
        Me.ButtonReenviarFallidos.TabIndex = 69
        Me.ButtonReenviarFallidos.Text = "Reenviar fallidos"
        Me.ToolTip1.SetToolTip(Me.ButtonReenviarFallidos, "Intenta reenviar a los contactos que fallaron. Se mostrarán con rojo en la lista " &
        "los que fallaron 2 veces")
        Me.ButtonReenviarFallidos.UseVisualStyleBackColor = False
        '
        'PictureBoxLoading
        '
        Me.PictureBoxLoading.Image = CType(resources.GetObject("PictureBoxLoading.Image"), System.Drawing.Image)
        Me.PictureBoxLoading.Location = New System.Drawing.Point(6, 6)
        Me.PictureBoxLoading.Name = "PictureBoxLoading"
        Me.PictureBoxLoading.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxLoading.TabIndex = 71
        Me.PictureBoxLoading.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBoxLoading, "Tiempo de espera hasta que el explorador de archivos de windows esté listo para b" &
        "uscar el archivo")
        Me.PictureBoxLoading.Visible = False
        '
        'ListBoxFallidos
        '
        Me.ListBoxFallidos.FormattingEnabled = True
        Me.ListBoxFallidos.Location = New System.Drawing.Point(9, 97)
        Me.ListBoxFallidos.MultiColumn = True
        Me.ListBoxFallidos.Name = "ListBoxFallidos"
        Me.ListBoxFallidos.Size = New System.Drawing.Size(505, 82)
        Me.ListBoxFallidos.TabIndex = 70
        Me.ToolTip1.SetToolTip(Me.ListBoxFallidos, "Los números en esta lista pueden que no tengan whatsapp o fallaron por problemas " &
        "de conexion entre el telefono y la sesion de whatsapp web")
        '
        'ListBoxReenviadosFallidos
        '
        Me.ListBoxReenviadosFallidos.ForeColor = System.Drawing.Color.Red
        Me.ListBoxReenviadosFallidos.FormattingEnabled = True
        Me.ListBoxReenviadosFallidos.Location = New System.Drawing.Point(520, 97)
        Me.ListBoxReenviadosFallidos.MultiColumn = True
        Me.ListBoxReenviadosFallidos.Name = "ListBoxReenviadosFallidos"
        Me.ListBoxReenviadosFallidos.Size = New System.Drawing.Size(487, 82)
        Me.ListBoxReenviadosFallidos.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.ListBoxReenviadosFallidos, "Es probable que los elementos en esta lista no tengan whatsapp")
        '
        'ButtonCancelarReenvio
        '
        Me.ButtonCancelarReenvio.BackColor = System.Drawing.Color.Gray
        Me.ButtonCancelarReenvio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelarReenvio.Enabled = False
        Me.ButtonCancelarReenvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelarReenvio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarReenvio.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelarReenvio.Location = New System.Drawing.Point(1011, 139)
        Me.ButtonCancelarReenvio.Name = "ButtonCancelarReenvio"
        Me.ButtonCancelarReenvio.Size = New System.Drawing.Size(115, 35)
        Me.ButtonCancelarReenvio.TabIndex = 74
        Me.ButtonCancelarReenvio.Text = "Cancelar reenvío"
        Me.ToolTip1.SetToolTip(Me.ButtonCancelarReenvio, "Intenta reenviar a los contactos que fallaron. Se mostrarán con rojo en la lista " &
        "los que fallaron 2 veces")
        Me.ButtonCancelarReenvio.UseVisualStyleBackColor = False
        '
        'CheckBoxAgregarTodos
        '
        Me.CheckBoxAgregarTodos.AutoSize = True
        Me.CheckBoxAgregarTodos.ForeColor = System.Drawing.Color.White
        Me.CheckBoxAgregarTodos.Location = New System.Drawing.Point(36, 68)
        Me.CheckBoxAgregarTodos.Name = "CheckBoxAgregarTodos"
        Me.CheckBoxAgregarTodos.Size = New System.Drawing.Size(134, 17)
        Me.CheckBoxAgregarTodos.TabIndex = 16
        Me.CheckBoxAgregarTodos.Text = "Seleccionar y convertir"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAgregarTodos, "Selecciona y convierte los contactos a numeros válidos para ser enviados a través" &
        " de una API de WhatsApp")
        Me.CheckBoxAgregarTodos.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(10, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(168, 13)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Esperar por elementos clickeables"
        Me.ToolTip1.SetToolTip(Me.Label20, "Tiempo de espera al iniciar un nuevo chat" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " en whatsapp web")
        '
        'MaskedTextBoxEsperaMaximaDOM
        '
        Me.MaskedTextBoxEsperaMaximaDOM.Location = New System.Drawing.Point(176, 127)
        Me.MaskedTextBoxEsperaMaximaDOM.Mask = "999"
        Me.MaskedTextBoxEsperaMaximaDOM.Name = "MaskedTextBoxEsperaMaximaDOM"
        Me.MaskedTextBoxEsperaMaximaDOM.Size = New System.Drawing.Size(25, 20)
        Me.MaskedTextBoxEsperaMaximaDOM.TabIndex = 68
        Me.MaskedTextBoxEsperaMaximaDOM.Text = "15"
        Me.ToolTip1.SetToolTip(Me.MaskedTextBoxEsperaMaximaDOM, "Tiempo a esperar para entregar un mensaje")
        Me.MaskedTextBoxEsperaMaximaDOM.ValidatingType = GetType(Integer)
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(206, 127)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox16.TabIndex = 69
        Me.PictureBox16.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox16, "Tiempo de espera máximo para encontrar los elementos clickeables del DOM")
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(45, 531)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(134, 46)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'OpenFileDialogImagenes
        '
        Me.OpenFileDialogImagenes.FileName = "OpenFileDialog2"
        '
        'OpenFileDialogDocumentos
        '
        Me.OpenFileDialogDocumentos.FileName = "OpenFileDialog2"
        '
        'BackgroundWorkerEnviarTextoPlano
        '
        Me.BackgroundWorkerEnviarTextoPlano.WorkerReportsProgress = True
        Me.BackgroundWorkerEnviarTextoPlano.WorkerSupportsCancellation = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBoxDocumentos)
        Me.TabPage2.Controls.Add(Me.GroupBoxImagenesYVideo)
        Me.TabPage2.Controls.Add(Me.GroupBoxTextoPlano)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1134, 609)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PANEL"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.ButtonCancelarReenvio)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.ListBoxReenviadosFallidos)
        Me.GroupBox3.Controls.Add(Me.PictureBoxLoading)
        Me.GroupBox3.Controls.Add(Me.ListBoxFallidos)
        Me.GroupBox3.Controls.Add(Me.ButtonReenviarFallidos)
        Me.GroupBox3.Controls.Add(Me.PictureBoxSuccess)
        Me.GroupBox3.Controls.Add(Me.PictureBoxError)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ButtonCancelarEnvio)
        Me.GroupBox3.Controls.Add(Me.LabelStatus)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 430)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1134, 182)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(700, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "Reenvíos fallidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(206, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Numeros sin Whatsapp"
        '
        'ButtonCancelarEnvio
        '
        Me.ButtonCancelarEnvio.BackColor = System.Drawing.Color.Gray
        Me.ButtonCancelarEnvio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelarEnvio.Enabled = False
        Me.ButtonCancelarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelarEnvio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelarEnvio.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelarEnvio.Location = New System.Drawing.Point(1011, 29)
        Me.ButtonCancelarEnvio.Name = "ButtonCancelarEnvio"
        Me.ButtonCancelarEnvio.Size = New System.Drawing.Size(115, 35)
        Me.ButtonCancelarEnvio.TabIndex = 34
        Me.ButtonCancelarEnvio.Text = "Cancelar Envíos"
        Me.ButtonCancelarEnvio.UseVisualStyleBackColor = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.BackColor = System.Drawing.Color.Transparent
        Me.LabelStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.ForeColor = System.Drawing.Color.Black
        Me.LabelStatus.Location = New System.Drawing.Point(32, 12)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(48, 14)
        Me.LabelStatus.TabIndex = 36
        Me.LabelStatus.Text = "Status"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 29)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ProgressBar1.Size = New System.Drawing.Size(1004, 35)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 35
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.RadioButtonTextoPlano)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.RadioButtonDocumentos)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.RadioButtonImagenesYVideo)
        Me.GroupBox5.Location = New System.Drawing.Point(3, -10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(141, 434)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(34, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "TEXTO PLANO"
        '
        'RadioButtonTextoPlano
        '
        Me.RadioButtonTextoPlano.AutoSize = True
        Me.RadioButtonTextoPlano.Location = New System.Drawing.Point(17, 22)
        Me.RadioButtonTextoPlano.Name = "RadioButtonTextoPlano"
        Me.RadioButtonTextoPlano.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonTextoPlano.TabIndex = 7
        Me.RadioButtonTextoPlano.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MULTIMEDIA"
        '
        'RadioButtonDocumentos
        '
        Me.RadioButtonDocumentos.AutoSize = True
        Me.RadioButtonDocumentos.Location = New System.Drawing.Point(17, 339)
        Me.RadioButtonDocumentos.Name = "RadioButtonDocumentos"
        Me.RadioButtonDocumentos.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonDocumentos.TabIndex = 22
        Me.RadioButtonDocumentos.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(34, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "DOCUMENTOS"
        '
        'RadioButtonImagenesYVideo
        '
        Me.RadioButtonImagenesYVideo.AutoSize = True
        Me.RadioButtonImagenesYVideo.Location = New System.Drawing.Point(17, 131)
        Me.RadioButtonImagenesYVideo.Name = "RadioButtonImagenesYVideo"
        Me.RadioButtonImagenesYVideo.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonImagenesYVideo.TabIndex = 11
        Me.RadioButtonImagenesYVideo.UseVisualStyleBackColor = True
        '
        'GroupBoxDocumentos
        '
        Me.GroupBoxDocumentos.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxDocumentos.Controls.Add(Me.PictureBox8)
        Me.GroupBoxDocumentos.Controls.Add(Me.TextBoxRutaDocumento)
        Me.GroupBoxDocumentos.Controls.Add(Me.ButtonEnviarDocumento)
        Me.GroupBoxDocumentos.Controls.Add(Me.ButtonFolderDocumento)
        Me.GroupBoxDocumentos.Controls.Add(Me.Label9)
        Me.GroupBoxDocumentos.Location = New System.Drawing.Point(150, 323)
        Me.GroupBoxDocumentos.Name = "GroupBoxDocumentos"
        Me.GroupBoxDocumentos.Size = New System.Drawing.Size(984, 101)
        Me.GroupBoxDocumentos.TabIndex = 13
        Me.GroupBoxDocumentos.TabStop = False
        '
        'TextBoxRutaDocumento
        '
        Me.TextBoxRutaDocumento.Location = New System.Drawing.Point(6, 40)
        Me.TextBoxRutaDocumento.Name = "TextBoxRutaDocumento"
        Me.TextBoxRutaDocumento.ReadOnly = True
        Me.TextBoxRutaDocumento.Size = New System.Drawing.Size(796, 20)
        Me.TextBoxRutaDocumento.TabIndex = 28
        '
        'ButtonEnviarDocumento
        '
        Me.ButtonEnviarDocumento.BackColor = System.Drawing.Color.Gray
        Me.ButtonEnviarDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnviarDocumento.Enabled = False
        Me.ButtonEnviarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnviarDocumento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviarDocumento.ForeColor = System.Drawing.Color.White
        Me.ButtonEnviarDocumento.Location = New System.Drawing.Point(849, 20)
        Me.ButtonEnviarDocumento.Name = "ButtonEnviarDocumento"
        Me.ButtonEnviarDocumento.Size = New System.Drawing.Size(115, 59)
        Me.ButtonEnviarDocumento.TabIndex = 27
        Me.ButtonEnviarDocumento.Text = "Enviar"
        Me.ButtonEnviarDocumento.UseVisualStyleBackColor = False
        '
        'ButtonFolderDocumento
        '
        Me.ButtonFolderDocumento.BackColor = System.Drawing.Color.Gray
        Me.ButtonFolderDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFolderDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFolderDocumento.ForeColor = System.Drawing.Color.White
        Me.ButtonFolderDocumento.Location = New System.Drawing.Point(808, 37)
        Me.ButtonFolderDocumento.Name = "ButtonFolderDocumento"
        Me.ButtonFolderDocumento.Size = New System.Drawing.Size(35, 25)
        Me.ButtonFolderDocumento.TabIndex = 26
        Me.ButtonFolderDocumento.Text = "..."
        Me.ButtonFolderDocumento.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(6, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 18)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Seleccionar documentos"
        '
        'GroupBoxImagenesYVideo
        '
        Me.GroupBoxImagenesYVideo.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.PictureBox13)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.Label17)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.PictureBox5)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.PictureBox4)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.MaskedTextBoxTiempoCargaImagenVideo)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.Label16)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.MaskedTextBoxExploradorDeArchivos)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.Label10)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.Label6)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.PictureBoxImagenAEnviar)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.PictureBox11)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.ButtonEnviarImagen)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.RichTextBoxPieDeFoto)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.CheckBoxPieDeFoto)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.TextBoxRuta)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.ButtonFolder)
        Me.GroupBoxImagenesYVideo.Controls.Add(Me.Label7)
        Me.GroupBoxImagenesYVideo.Location = New System.Drawing.Point(150, 114)
        Me.GroupBoxImagenesYVideo.Name = "GroupBoxImagenesYVideo"
        Me.GroupBoxImagenesYVideo.Size = New System.Drawing.Size(984, 203)
        Me.GroupBoxImagenesYVideo.TabIndex = 12
        Me.GroupBoxImagenesYVideo.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(59, 49)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 67
        Me.PictureBox13.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(609, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Vista Previa"
        '
        'PictureBoxImagenAEnviar
        '
        Me.PictureBoxImagenAEnviar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxImagenAEnviar.Location = New System.Drawing.Point(450, 23)
        Me.PictureBoxImagenAEnviar.Name = "PictureBoxImagenAEnviar"
        Me.PictureBoxImagenAEnviar.Size = New System.Drawing.Size(393, 173)
        Me.PictureBoxImagenAEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagenAEnviar.TabIndex = 31
        Me.PictureBoxImagenAEnviar.TabStop = False
        '
        'ButtonEnviarImagen
        '
        Me.ButtonEnviarImagen.BackColor = System.Drawing.Color.Gray
        Me.ButtonEnviarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnviarImagen.Enabled = False
        Me.ButtonEnviarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnviarImagen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviarImagen.ForeColor = System.Drawing.Color.White
        Me.ButtonEnviarImagen.Location = New System.Drawing.Point(852, 63)
        Me.ButtonEnviarImagen.Name = "ButtonEnviarImagen"
        Me.ButtonEnviarImagen.Size = New System.Drawing.Size(115, 59)
        Me.ButtonEnviarImagen.TabIndex = 22
        Me.ButtonEnviarImagen.Text = "Enviar"
        Me.ButtonEnviarImagen.UseVisualStyleBackColor = False
        '
        'RichTextBoxPieDeFoto
        '
        Me.RichTextBoxPieDeFoto.Enabled = False
        Me.RichTextBoxPieDeFoto.Location = New System.Drawing.Point(6, 139)
        Me.RichTextBoxPieDeFoto.MaxLength = 900
        Me.RichTextBoxPieDeFoto.Multiline = False
        Me.RichTextBoxPieDeFoto.Name = "RichTextBoxPieDeFoto"
        Me.RichTextBoxPieDeFoto.Size = New System.Drawing.Size(425, 57)
        Me.RichTextBoxPieDeFoto.TabIndex = 21
        Me.RichTextBoxPieDeFoto.Text = ""
        '
        'CheckBoxPieDeFoto
        '
        Me.CheckBoxPieDeFoto.AutoSize = True
        Me.CheckBoxPieDeFoto.Enabled = False
        Me.CheckBoxPieDeFoto.ForeColor = System.Drawing.Color.Gray
        Me.CheckBoxPieDeFoto.Location = New System.Drawing.Point(156, 116)
        Me.CheckBoxPieDeFoto.Name = "CheckBoxPieDeFoto"
        Me.CheckBoxPieDeFoto.Size = New System.Drawing.Size(107, 17)
        Me.CheckBoxPieDeFoto.TabIndex = 20
        Me.CheckBoxPieDeFoto.Text = "Incluir pie de foto"
        Me.CheckBoxPieDeFoto.UseVisualStyleBackColor = True
        '
        'TextBoxRuta
        '
        Me.TextBoxRuta.Location = New System.Drawing.Point(6, 23)
        Me.TextBoxRuta.Name = "TextBoxRuta"
        Me.TextBoxRuta.ReadOnly = True
        Me.TextBoxRuta.Size = New System.Drawing.Size(381, 20)
        Me.TextBoxRuta.TabIndex = 19
        '
        'ButtonFolder
        '
        Me.ButtonFolder.BackColor = System.Drawing.Color.Gray
        Me.ButtonFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFolder.Enabled = False
        Me.ButtonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFolder.ForeColor = System.Drawing.Color.White
        Me.ButtonFolder.Location = New System.Drawing.Point(393, 20)
        Me.ButtonFolder.Name = "ButtonFolder"
        Me.ButtonFolder.Size = New System.Drawing.Size(35, 25)
        Me.ButtonFolder.TabIndex = 18
        Me.ButtonFolder.Text = "..."
        Me.ButtonFolder.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(6, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Seleccionar Archivo"
        '
        'GroupBoxTextoPlano
        '
        Me.GroupBoxTextoPlano.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBoxTextoPlano.Controls.Add(Me.PictureBox12)
        Me.GroupBoxTextoPlano.Controls.Add(Me.Label11)
        Me.GroupBoxTextoPlano.Controls.Add(Me.RichTextBox1)
        Me.GroupBoxTextoPlano.Controls.Add(Me.ButtonEnviarTexto)
        Me.GroupBoxTextoPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxTextoPlano.Location = New System.Drawing.Point(150, 6)
        Me.GroupBoxTextoPlano.Name = "GroupBoxTextoPlano"
        Me.GroupBoxTextoPlano.Size = New System.Drawing.Size(984, 102)
        Me.GroupBoxTextoPlano.TabIndex = 6
        Me.GroupBoxTextoPlano.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(6, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Escriba su mensaje"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 23)
        Me.RichTextBox1.MaxLength = 1000
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(840, 59)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ButtonEnviarTexto
        '
        Me.ButtonEnviarTexto.BackColor = System.Drawing.Color.Gray
        Me.ButtonEnviarTexto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnviarTexto.Enabled = False
        Me.ButtonEnviarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEnviarTexto.ForeColor = System.Drawing.Color.White
        Me.ButtonEnviarTexto.Location = New System.Drawing.Point(852, 23)
        Me.ButtonEnviarTexto.Name = "ButtonEnviarTexto"
        Me.ButtonEnviarTexto.Size = New System.Drawing.Size(115, 59)
        Me.ButtonEnviarTexto.TabIndex = 3
        Me.ButtonEnviarTexto.Text = "Enviar"
        Me.ButtonEnviarTexto.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ButtonLimpiarLista)
        Me.TabPage1.Controls.Add(Me.PictureBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1134, 609)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CONTACTOS"
        '
        'ButtonLimpiarLista
        '
        Me.ButtonLimpiarLista.BackColor = System.Drawing.Color.White
        Me.ButtonLimpiarLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLimpiarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarLista.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiarLista.Location = New System.Drawing.Point(974, 566)
        Me.ButtonLimpiarLista.Name = "ButtonLimpiarLista"
        Me.ButtonLimpiarLista.Size = New System.Drawing.Size(154, 40)
        Me.ButtonLimpiarLista.TabIndex = 15
        Me.ButtonLimpiarLista.Text = "Borrar todo"
        Me.ButtonLimpiarLista.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 629)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PictureBox3)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.PictureBox16)
        Me.GroupBox7.Controls.Add(Me.MaskedTextBoxIntervaloEntreChats)
        Me.GroupBox7.Controls.Add(Me.MaskedTextBoxEsperaMaximaDOM)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.PictureBox15)
        Me.GroupBox7.Controls.Add(Me.MaskedTextBoxEsperarParteChat)
        Me.GroupBox7.Controls.Add(Me.PictureBox14)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 331)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(233, 174)
        Me.GroupBox7.TabIndex = 72
        Me.GroupBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(39, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 15)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Tiempos generales"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.RadioButtonQuitar)
        Me.GroupBox6.Controls.Add(Me.CheckBoxAgregarTodos)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(233, 112)
        Me.GroupBox6.TabIndex = 71
        Me.GroupBox6.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(36, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Añadir contactos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox9)
        Me.GroupBox4.Controls.Add(Me.CheckBoxSeleccionar29)
        Me.GroupBox4.Controls.Add(Me.CheckBoxSeleccionar31)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 95)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(6, 8)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 32
        Me.PictureBox9.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(36, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 15)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Mostrar/Ocultar columnas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 580)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "WhatsApp Sender"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27, Me.Column28, Me.Column29, Me.Column30, Me.Column31, Me.Column32, Me.Column33, Me.Column34, Me.Column35, Me.Column36, Me.Column37, Me.Column38, Me.Column39, Me.Column40, Me.Column41, Me.Column42, Me.Column43, Me.Column44, Me.Column45, Me.Column46, Me.Column47, Me.Column48, Me.Column49, Me.Column50})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(251, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.DataGridView1.Size = New System.Drawing.Size(714, 600)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column14
        '
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column15
        '
        Me.Column15.HeaderText = "Column15"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column16
        '
        Me.Column16.HeaderText = "Column16"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column17
        '
        Me.Column17.HeaderText = "Column17"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column18
        '
        Me.Column18.HeaderText = "Column18"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column19
        '
        Me.Column19.HeaderText = "Column19"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column20
        '
        Me.Column20.HeaderText = "Column20"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column21
        '
        Me.Column21.HeaderText = "Column21"
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column22
        '
        Me.Column22.HeaderText = "Column22"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column23
        '
        Me.Column23.HeaderText = "Column23"
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column24
        '
        Me.Column24.HeaderText = "Column24"
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column25
        '
        Me.Column25.HeaderText = "Column25"
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column26
        '
        Me.Column26.HeaderText = "Column26"
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column27
        '
        Me.Column27.HeaderText = "Column27"
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        Me.Column27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column28
        '
        Me.Column28.HeaderText = "Column28"
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column29
        '
        Me.Column29.HeaderText = "Column29"
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column30
        '
        Me.Column30.HeaderText = "Column30"
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column31
        '
        Me.Column31.HeaderText = "Column31"
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column32
        '
        Me.Column32.HeaderText = "Column32"
        Me.Column32.Name = "Column32"
        Me.Column32.ReadOnly = True
        Me.Column32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column33
        '
        Me.Column33.HeaderText = "Column33"
        Me.Column33.Name = "Column33"
        Me.Column33.ReadOnly = True
        Me.Column33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column34
        '
        Me.Column34.HeaderText = "Column34"
        Me.Column34.Name = "Column34"
        Me.Column34.ReadOnly = True
        Me.Column34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column35
        '
        Me.Column35.HeaderText = "Column35"
        Me.Column35.Name = "Column35"
        Me.Column35.ReadOnly = True
        Me.Column35.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column36
        '
        Me.Column36.HeaderText = "Column36"
        Me.Column36.Name = "Column36"
        Me.Column36.ReadOnly = True
        Me.Column36.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column37
        '
        Me.Column37.HeaderText = "Column37"
        Me.Column37.Name = "Column37"
        Me.Column37.ReadOnly = True
        Me.Column37.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column38
        '
        Me.Column38.HeaderText = "Column38"
        Me.Column38.Name = "Column38"
        Me.Column38.ReadOnly = True
        Me.Column38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column39
        '
        Me.Column39.HeaderText = "Column39"
        Me.Column39.Name = "Column39"
        Me.Column39.ReadOnly = True
        Me.Column39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column40
        '
        Me.Column40.HeaderText = "Column40"
        Me.Column40.Name = "Column40"
        Me.Column40.ReadOnly = True
        Me.Column40.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column41
        '
        Me.Column41.HeaderText = "Column41"
        Me.Column41.Name = "Column41"
        Me.Column41.ReadOnly = True
        Me.Column41.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column42
        '
        Me.Column42.HeaderText = "Column42"
        Me.Column42.Name = "Column42"
        Me.Column42.ReadOnly = True
        Me.Column42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column43
        '
        Me.Column43.HeaderText = "Column43"
        Me.Column43.Name = "Column43"
        Me.Column43.ReadOnly = True
        Me.Column43.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column44
        '
        Me.Column44.HeaderText = "Column44"
        Me.Column44.Name = "Column44"
        Me.Column44.ReadOnly = True
        Me.Column44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column45
        '
        Me.Column45.HeaderText = "Column45"
        Me.Column45.Name = "Column45"
        Me.Column45.ReadOnly = True
        Me.Column45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column46
        '
        Me.Column46.HeaderText = "Column46"
        Me.Column46.Name = "Column46"
        Me.Column46.ReadOnly = True
        Me.Column46.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column47
        '
        Me.Column47.HeaderText = "Column47"
        Me.Column47.Name = "Column47"
        Me.Column47.ReadOnly = True
        Me.Column47.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column48
        '
        Me.Column48.HeaderText = "Column48"
        Me.Column48.Name = "Column48"
        Me.Column48.ReadOnly = True
        Me.Column48.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column49
        '
        Me.Column49.HeaderText = "Column49"
        Me.Column49.Name = "Column49"
        Me.Column49.ReadOnly = True
        Me.Column49.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column50
        '
        Me.Column50.HeaderText = "Column50"
        Me.Column50.Name = "Column50"
        Me.Column50.ReadOnly = True
        Me.Column50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(971, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de destinatarios"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1142, 635)
        Me.TabControl1.TabIndex = 1
        '
        'BackgroundWorkerEnviarMultimedia
        '
        Me.BackgroundWorkerEnviarMultimedia.WorkerReportsProgress = True
        Me.BackgroundWorkerEnviarMultimedia.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerEnviarDocumentos
        '
        Me.BackgroundWorkerEnviarDocumentos.WorkerReportsProgress = True
        Me.BackgroundWorkerEnviarDocumentos.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerFallidosTextoPlano
        '
        Me.BackgroundWorkerFallidosTextoPlano.WorkerReportsProgress = True
        Me.BackgroundWorkerFallidosTextoPlano.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerFallidosMultimedia
        '
        Me.BackgroundWorkerFallidosMultimedia.WorkerReportsProgress = True
        Me.BackgroundWorkerFallidosMultimedia.WorkerSupportsCancellation = True
        '
        'BackgroundWorkerFallidosDocumentos
        '
        Me.BackgroundWorkerFallidosDocumentos.WorkerReportsProgress = True
        Me.BackgroundWorkerFallidosDocumentos.WorkerSupportsCancellation = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1142, 635)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormPrincipal"
        Me.Text = "WhatsApp Sender"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBoxDocumentos.ResumeLayout(False)
        Me.GroupBoxDocumentos.PerformLayout()
        Me.GroupBoxImagenesYVideo.ResumeLayout(False)
        Me.GroupBoxImagenesYVideo.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxImagenAEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxTextoPlano.ResumeLayout(False)
        Me.GroupBoxTextoPlano.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialogImagenes As OpenFileDialog
    Friend WithEvents OpenFileDialogDocumentos As OpenFileDialog
    Friend WithEvents BackgroundWorkerEnviarTextoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCancelarEnvio As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonTextoPlano As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButtonDocumentos As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButtonImagenesYVideo As RadioButton
    Friend WithEvents GroupBoxDocumentos As GroupBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBoxRutaDocumento As TextBox
    Friend WithEvents ButtonEnviarDocumento As Button
    Friend WithEvents ButtonFolderDocumento As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBoxImagenesYVideo As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBoxImagenAEnviar As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents ButtonEnviarImagen As Button
    Friend WithEvents RichTextBoxPieDeFoto As RichTextBox
    Friend WithEvents CheckBoxPieDeFoto As CheckBox
    Friend WithEvents TextBoxRuta As TextBox
    Friend WithEvents ButtonFolder As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents GroupBoxTextoPlano As GroupBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ButtonEnviarTexto As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ButtonLimpiarLista As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxAgregarTodos As CheckBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents CheckBoxSeleccionar31 As CheckBox
    Friend WithEvents RadioButtonQuitar As RadioButton
    Friend WithEvents CheckBoxSeleccionar29 As CheckBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents Column33 As DataGridViewTextBoxColumn
    Friend WithEvents Column34 As DataGridViewTextBoxColumn
    Friend WithEvents Column35 As DataGridViewTextBoxColumn
    Friend WithEvents Column36 As DataGridViewTextBoxColumn
    Friend WithEvents Column37 As DataGridViewTextBoxColumn
    Friend WithEvents Column38 As DataGridViewTextBoxColumn
    Friend WithEvents Column39 As DataGridViewTextBoxColumn
    Friend WithEvents Column40 As DataGridViewTextBoxColumn
    Friend WithEvents Column41 As DataGridViewTextBoxColumn
    Friend WithEvents Column42 As DataGridViewTextBoxColumn
    Friend WithEvents Column43 As DataGridViewTextBoxColumn
    Friend WithEvents Column44 As DataGridViewTextBoxColumn
    Friend WithEvents Column45 As DataGridViewTextBoxColumn
    Friend WithEvents Column46 As DataGridViewTextBoxColumn
    Friend WithEvents Column47 As DataGridViewTextBoxColumn
    Friend WithEvents Column48 As DataGridViewTextBoxColumn
    Friend WithEvents Column49 As DataGridViewTextBoxColumn
    Friend WithEvents Column50 As DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MaskedTextBoxIntervaloEntreChats As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BackgroundWorkerEnviarMultimedia As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerEnviarDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents MaskedTextBoxExploradorDeArchivos As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MaskedTextBoxTiempoCargaImagenVideo As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBoxSuccess As PictureBox
    Friend WithEvents PictureBoxError As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents MaskedTextBoxEsperarParteChat As MaskedTextBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents ButtonReenviarFallidos As Button
    Friend WithEvents BackgroundWorkerFallidosTextoPlano As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerFallidosMultimedia As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerFallidosDocumentos As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBoxFallidos As ListBox
    Friend WithEvents PictureBoxLoading As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ListBoxReenviadosFallidos As ListBox
    Friend WithEvents ButtonCancelarReenvio As Button
    Friend WithEvents MaskedTextBoxEsperaMaximaDOM As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
