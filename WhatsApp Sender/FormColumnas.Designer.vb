<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormColumnas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormColumnas))
        Me.CheckBoxSeleccionar29 = New System.Windows.Forms.CheckBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxSeleccionar31 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxSeleccionar29
        '
        Me.CheckBoxSeleccionar29.AutoSize = True
        Me.CheckBoxSeleccionar29.Location = New System.Drawing.Point(12, 12)
        Me.CheckBoxSeleccionar29.Name = "CheckBoxSeleccionar29"
        Me.CheckBoxSeleccionar29.Size = New System.Drawing.Size(133, 17)
        Me.CheckBoxSeleccionar29.TabIndex = 2
        Me.CheckBoxSeleccionar29.Text = "Ocultar los primeros 29"
        Me.CheckBoxSeleccionar29.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(411, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 23
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Selecciona para ocultar las primeras 29 0 31 excepto el nombre (Column 0)")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Válido cuando se tienen mas de 31 campos (columnas)")
        '
        'CheckBoxSeleccionar31
        '
        Me.CheckBoxSeleccionar31.AutoSize = True
        Me.CheckBoxSeleccionar31.Location = New System.Drawing.Point(12, 35)
        Me.CheckBoxSeleccionar31.Name = "CheckBoxSeleccionar31"
        Me.CheckBoxSeleccionar31.Size = New System.Drawing.Size(332, 17)
        Me.CheckBoxSeleccionar31.TabIndex = 47
        Me.CheckBoxSeleccionar31.Text = "Ocultar los primeros 31 (Para archivos CSV sin modificar campos)"
        Me.CheckBoxSeleccionar31.UseVisualStyleBackColor = True
        '
        'FormColumnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(431, 91)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBoxSeleccionar31)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.CheckBoxSeleccionar29)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormColumnas"
        Me.Text = "Ocultar columnas"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxSeleccionar29 As CheckBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CheckBoxSeleccionar31 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
