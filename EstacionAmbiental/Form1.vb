Imports System.IO.Ports
Public Class Form1
    Dim Arduino As New SerialPort
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblTemperatura.Click

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            If Arduino.IsOpen = False Then
                If cboPuertos.SelectedIndex = -1 Then
                    MessageBox.Show("Seleccione un puerto COM.")
                    Exit Sub
                End If

                Arduino.PortName = cboPuertos.Text
                Arduino.BaudRate = 9600
                Arduino.ReadTimeout = 3000

                Arduino.Open()

                btnConectar.Text = "Desconectar"
                lblEstado.Text = "Conectado"
                lblEstado.ForeColor = Color.Green
                cboPuertos.Enabled = False
            Else

                Arduino.Close()

                btnConectar.Text = "Conectar"
                lblEstado.Text = "Desconectado"
                lblEstado.ForeColor = Color.Red
                cboPuertos.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo establecer la conexión." & vbCrLf & ex.Message,
                            "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPuertos.Items.Clear()
        For Each puerto As String In SerialPort.GetPortNames()
            cboPuertos.Items.Add(puerto)
        Next

        If cboPuertos.Items.Count > 0 Then
            cboPuertos.SelectedIndex = 0
        Else
            MessageBox.Show("No se encontraron puertos COM disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
        If Arduino.IsOpen = False Then
            MessageBox.Show("Primero debe conectar el Arduino.")
            Exit Sub
        End If

        Try
            'Limpia la información pendiente del puerto serial
            Arduino.DiscardInBuffer()

            Arduino.WriteLine("LEER")

            Dim respuesta As String
            respuesta = Arduino.ReadLine().Trim() 'DATOS:26.00,68.00

            If respuesta.StartsWith("DATOS:") Then
                respuesta = respuesta.Substring(6) 'cadena = cadena[6:] en Python

                Dim datos() As String
                datos = respuesta.Split(","c)

                If datos.Length = 2 Then
                    lblTemperatura.Text = datos(0) & " °C"
                    lblHumedad.Text = datos(1) & " %"

                    lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                End If
            ElseIf respuesta = "ERROR" Then
                MessageBox.Show("No se pudo  obtener información del sensor.")
            Else
                MessageBox.Show("Respuesta desconocida: " & respuesta)
            End If
        Catch ex As TimeoutException
            MessageBox.Show("Arduino no respondió a la solicitud.")
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lblTemperatura.Text = "-- °C"
        lblHumedad.Text = "-- %"
        lblFechaHora.Text = "--/--/---- --:--:--"
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If Arduino.IsOpen Then
            Arduino.Close()
        End If

        Application.Exit()
    End Sub

    Private Sub RefrescarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefrescarToolStripMenuItem.Click
        cboPuertos.Items.Clear()

        For Each puerto As String In SerialPort.GetPortNames()
            cboPuertos.Items.Add(puerto)
        Next

        If cboPuertos.Items.Count > 0 Then
            cboPuertos.SelectedIndex = 0
        Else
            MessageBox.Show("No se encontraron puertos COM disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Arduino.IsOpen Then
            Arduino.Close()
        End If
    End Sub
End Class
