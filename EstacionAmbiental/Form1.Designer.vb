<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        lblEstado = New Label()
        Label2 = New Label()
        btnConectar = New Button()
        cboPuertos = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        GroupBox6 = New GroupBox()
        lblHumedad = New Label()
        GroupBox5 = New GroupBox()
        lblTemperatura = New Label()
        GroupBox3 = New GroupBox()
        btnSalir = New Button()
        btnLimpiar = New Button()
        btnCapturar = New Button()
        GroupBox4 = New GroupBox()
        lblFechaHora = New Label()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        RefrescarToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblEstado)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(btnConectar)
        GroupBox1.Controls.Add(cboPuertos)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 26)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(540, 85)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Conectividad"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(430, 32)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(104, 20)
        lblEstado.TabIndex = 4
        lblEstado.Text = "Desconectado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(366, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 3
        Label2.Text = "Estado:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnConectar
        ' 
        btnConectar.Location = New Point(276, 31)
        btnConectar.Name = "btnConectar"
        btnConectar.Size = New Size(84, 24)
        btnConectar.TabIndex = 2
        btnConectar.Text = "Conectar"
        btnConectar.UseVisualStyleBackColor = True
        ' 
        ' cboPuertos
        ' 
        cboPuertos.DropDownStyle = ComboBoxStyle.DropDownList
        cboPuertos.FormattingEnabled = True
        cboPuertos.Location = New Point(129, 32)
        cboPuertos.Name = "cboPuertos"
        cboPuertos.Size = New Size(141, 23)
        cboPuertos.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 0
        Label1.Text = "🔱 Puerto COM:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox6)
        GroupBox2.Controls.Add(GroupBox5)
        GroupBox2.Location = New Point(12, 119)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(360, 175)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "📶 Lecturas del Sensor"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(lblHumedad)
        GroupBox6.Location = New Point(183, 22)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(171, 147)
        GroupBox6.TabIndex = 1
        GroupBox6.TabStop = False
        GroupBox6.Text = "💧 Humedad"
        ' 
        ' lblHumedad
        ' 
        lblHumedad.AutoSize = True
        lblHumedad.FlatStyle = FlatStyle.Popup
        lblHumedad.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHumedad.Location = New Point(23, 45)
        lblHumedad.Name = "lblHumedad"
        lblHumedad.Size = New Size(142, 65)
        lblHumedad.TabIndex = 0
        lblHumedad.Text = "68 %"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(lblTemperatura)
        GroupBox5.Location = New Point(6, 22)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(171, 147)
        GroupBox5.TabIndex = 0
        GroupBox5.TabStop = False
        GroupBox5.Text = "🌡 Temperatura"
        ' 
        ' lblTemperatura
        ' 
        lblTemperatura.AutoSize = True
        lblTemperatura.FlatStyle = FlatStyle.Popup
        lblTemperatura.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTemperatura.Location = New Point(6, 45)
        lblTemperatura.Name = "lblTemperatura"
        lblTemperatura.Size = New Size(148, 65)
        lblTemperatura.TabIndex = 0
        lblTemperatura.Text = "26 °C"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnSalir)
        GroupBox3.Controls.Add(btnLimpiar)
        GroupBox3.Controls.Add(btnCapturar)
        GroupBox3.Location = New Point(378, 119)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(174, 254)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "⚙ Controles"
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(6, 148)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(162, 52)
        btnSalir.TabIndex = 2
        btnSalir.Text = "🚪 Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLimpiar.Location = New Point(6, 90)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(162, 52)
        btnLimpiar.TabIndex = 1
        btnLimpiar.Text = ChrW(55358) & ChrW(56825) & " Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnCapturar
        ' 
        btnCapturar.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCapturar.Location = New Point(6, 32)
        btnCapturar.Name = "btnCapturar"
        btnCapturar.Size = New Size(162, 52)
        btnCapturar.TabIndex = 0
        btnCapturar.Text = "📑 Capturar Datos"
        btnCapturar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblFechaHora)
        GroupBox4.Location = New Point(12, 300)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(360, 73)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "🕒 Fecha y Hora de Lectura"
        ' 
        ' lblFechaHora
        ' 
        lblFechaHora.FlatStyle = FlatStyle.System
        lblFechaHora.Location = New Point(12, 33)
        lblFechaHora.Name = "lblFechaHora"
        lblFechaHora.Size = New Size(342, 23)
        lblFechaHora.TabIndex = 0
        lblFechaHora.Text = "Fecha & Hora"
        lblFechaHora.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ArchivoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(564, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(12, 20)
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RefrescarToolStripMenuItem})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(60, 20)
        ArchivoToolStripMenuItem.Text = "Archivo"
        ' 
        ' RefrescarToolStripMenuItem
        ' 
        RefrescarToolStripMenuItem.Name = "RefrescarToolStripMenuItem"
        RefrescarToolStripMenuItem.Size = New Size(180, 22)
        RefrescarToolStripMenuItem.Text = "Refrescar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 382)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "Estación Ambiental DHT11"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPuertos As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConectar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents lblHumedad As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCapturar As Button
    Friend WithEvents lblFechaHora As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefrescarToolStripMenuItem As ToolStripMenuItem

End Class
