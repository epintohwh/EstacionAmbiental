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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox5 = New GroupBox()
        GroupBox6 = New GroupBox()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox6.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(540, 85)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Conectividad"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(129, 32)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(141, 23)
        ComboBox1.TabIndex = 1
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
        GroupBox2.Location = New Point(12, 105)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(360, 175)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "📶 Lecturas del Sensor"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(Button3)
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Location = New Point(378, 105)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(174, 254)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "⚙ Controles"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(12, 286)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(360, 73)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "🕒 Fecha y Hora de Lectura"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(276, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 24)
        Button1.TabIndex = 2
        Button1.Text = "Conectar"
        Button1.UseVisualStyleBackColor = True
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(430, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 4
        Label3.Text = "Desconectado"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label4)
        GroupBox5.Location = New Point(6, 22)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(171, 147)
        GroupBox5.TabIndex = 0
        GroupBox5.TabStop = False
        GroupBox5.Text = "🌡 Temperatura"
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(Label5)
        GroupBox6.Location = New Point(183, 22)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(171, 147)
        GroupBox6.TabIndex = 1
        GroupBox6.TabStop = False
        GroupBox6.Text = "💧 Humedad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 65)
        Label4.TabIndex = 0
        Label4.Text = "26 °C"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Font = New Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 45)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 65)
        Label5.TabIndex = 0
        Label5.Text = "68 %"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(6, 32)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 52)
        Button2.TabIndex = 0
        Button2.Text = "📑 Capturar Datos"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(6, 90)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 52)
        Button3.TabIndex = 1
        Button3.Text = ChrW(55358) & ChrW(56825) & " Limpiar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(6, 148)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 52)
        Button4.TabIndex = 2
        Button4.Text = "🚪 Salir"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.FlatStyle = FlatStyle.System
        Label6.Location = New Point(12, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(342, 23)
        Label6.TabIndex = 0
        Label6.Text = "Fecha & Hora"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 371)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form1"
        Text = "Estación Ambiental DHT11"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label

End Class
