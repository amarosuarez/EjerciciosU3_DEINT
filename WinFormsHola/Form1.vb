Imports System.Numerics
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Security.Cryptography
Imports BibliotecaDeClases

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = tbNombre.Text
        Dim apellidos As String = tbApellido.Text
        Dim dia As String = tbDia.Text
        Dim mes As String = tbMes.Text
        Dim año As String = tbAño.Text
        Dim correct As Boolean = False

        If nombre = "" Or apellidos = "" Or dia = "" Or mes = "" Or año = "" Then
            MessageBox.Show("Por favor, rellena todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim iDay As Integer = Integer.Parse(dia)
            Dim iMonth As Integer = Integer.Parse(mes)
            Dim iYear As Integer = Integer.Parse(año)

            Select Case mes
                Case 1, 3, 5, 7, 8, 10, 12
                    If iDay > 0 And iDay <= 31 Then

                        correct = True

                    End If
                Case 4, 6, 9, 11
                    If iDay > 0 And iDay < 31 Then
                        correct = True
                    End If
                Case 2
                    If DateTime.IsLeapYear(iYear) Then
                        If iDay > 0 And iDay <= 29 Then
                            correct = True
                        End If
                    Else
                        If iDay > 0 And iDay < 29 Then
                            correct = True
                        End If
                    End If

            End Select

        End If

        If correct Then
            Dim cumple As DateTime

            Dim fecha As String = dia + "/" + mes + "/" + año

            cumple = DateTime.Parse(fecha)

            Dim persona As New Persona(nombre, apellidos, cumple)
            Dim Msg, Style, Title, Help, Ctxt, Response

            Msg = "Naciste el " + persona.FechaNac.ToLongDateString

            ' Define message.
            Style = vbDefaultButton2    ' Define buttons.
            Title = "Hola, " + persona.Nombre + " " + persona.Apellido    ' Define title.
            Help = "DEMO.HLP"    ' Define Help file.
            Ctxt = 1000    ' Define topic context. 
            ' Display message.
            Response = MsgBox(Msg, Style, Title)

            ' Opcionalmente, puedes manejar la respuesta del usuario
            If Response = vbYes Then
                ' Código para continuar
            Else
                ' Código si se selecciona "No"
            End If
        Else
            MessageBox.Show("Por favor, comprueba los campos y la fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub TextBoxDia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDia.KeyPress, tbMes.KeyPress, tbAño.KeyPress
        ' Solo permite números y la tecla de retroceso (Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Cancela la tecla si no es un número
        End If
    End Sub

End Class
