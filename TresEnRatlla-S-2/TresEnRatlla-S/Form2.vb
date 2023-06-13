Imports AxMSWinsockLib

Public Class Form2
    Dim torn As Boolean = False
    'Comprovar si els bottons han sigut pulsats
    Dim a1 As Boolean = False
    Dim a2 As Boolean = False
    Dim a3 As Boolean = False
    Dim a4 As Boolean = False
    Dim a5 As Boolean = False
    Dim a6 As Boolean = False
    Dim a7 As Boolean = False
    Dim a8 As Boolean = False
    Dim a9 As Boolean = False

    Dim b1 As Boolean = False
    Dim b2 As Boolean = False
    Dim b3 As Boolean = False
    Dim b4 As Boolean = False
    Dim b5 As Boolean = False
    Dim b6 As Boolean = False
    Dim b7 As Boolean = False
    Dim b8 As Boolean = False
    Dim b9 As Boolean = False

    Dim tornServidor As String = ""


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = Form1.AxWinsock1.LocalIP
        TextBox2.Text = Form1.AxWinsock1.LocalPort
        AxWinsock2.RemoteHost = Form1.AxWinsock1.LocalIP
        AxWinsock2.RemotePort = Form1.AxWinsock1.LocalPort
        AxWinsock2.Connect()
        Timer1.Enabled = True
    End Sub

    Private Sub AxWinsock2_ConnectEvent(sender As Object, e As EventArgs) Handles AxWinsock2.ConnectEvent
        MsgBox("S'ha connectat amb el servidor")
    End Sub

    Public Sub guanyador()
        If (a1 = True And a2 = True And a3 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a4 = True And a5 = True And a6 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a7 = True And a8 = True And a9 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a1 = True And a4 = True And a7 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a2 = True And a5 = True And a8 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a3 = True And a6 = True And a9 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a1 = True And a5 = True And a9 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a3 = True And a5 = True And a7 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()
        ElseIf (a4 = True And a5 = True And a6 = True) Then
            MsgBox("Guanya Client !!")
            AxWinsock2.SendData("Guanya Client !!")
            reset()

        End If
    End Sub

    'Reinicia el joc
    Public Sub reset()
        a1 = False
        a2 = False
        a3 = False
        a4 = False
        a5 = False
        a6 = False
        a7 = False
        a8 = False
        a9 = False

        b1 = False
        b2 = False
        b3 = False
        b4 = False
        b5 = False
        b6 = False
        b7 = False
        b8 = False
        b9 = False


        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True

        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button10.Text = ""

        Label2.Text = 30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Label6.Text - 1
        If Label6.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("S'ha acabat el temps")
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            Button10.Enabled = False
        End If
    End Sub

    'accions

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If torn = True Then
                Button2.Text = "O"
                AxWinsock2.SendData("1cli")
                Me.BackColor = Color.White
                Button2.Enabled = False
                a1 = True
                b1 = True
                Timer1.Enabled = False
                torn = False
            End If
            guanyador()
        Catch ex As Exception
            MsgBox("No es el teu torn")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If torn = True Then
                Button3.Text = "O"
                AxWinsock2.SendData("2cli")
                Me.BackColor = Color.White
                Button3.Enabled = False
                a2 = True
                b2 = True
                Timer1.Enabled = False
                torn = False
            End If
            guanyador()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If torn = True Then
            Button4.Text = "O"
            AxWinsock2.SendData("3cli")
            Me.BackColor = Color.White
            Button4.Enabled = False
            a3 = True
            b3 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If torn = True Then
            Button5.Text = "O"
            AxWinsock2.SendData("4cli")
            Me.BackColor = Color.White
            Button5.Enabled = False
            a4 = True
            b4 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If torn = True Then
            Button6.Text = "O"
            AxWinsock2.SendData("5cli")
            Me.BackColor = Color.White
            Button6.Enabled = False
            a5 = True
            b5 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If torn = True Then
            Button7.Text = "O"
            AxWinsock2.SendData("6cli")
            Me.BackColor = Color.White
            Button7.Enabled = False
            a6 = True
            b6 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If torn = True Then
            Button8.Text = "O"
            AxWinsock2.SendData("7cli")
            Me.BackColor = Color.White
            Button8.Enabled = False
            a7 = True
            b7 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If torn = True Then
            Button9.Text = "O"
            AxWinsock2.SendData("8cli")
            Me.BackColor = Color.White
            Button9.Enabled = False
            a8 = True
            b8 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If torn = True Then
            Button10.Text = "O"
            AxWinsock2.SendData("9cli")
            Me.BackColor = Color.White
            Button10.Enabled = False
            a9 = True
            b9 = True
            Timer1.Enabled = False
            torn = False
        End If
        guanyador()
    End Sub

    'Rebudes
    Private Sub AxWinsock2_DataArrival(sender As Object, e As DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock2.DataArrival
        Try
            AxWinsock2.GetData(tornServidor)
            If tornServidor = "1ser" Then
                Me.BackColor = Color.Green
                Button2.Text = "X"
                Button2.Enabled = False
                b1 = True
                torn = True
                Timer1.Enabled = True

            ElseIf tornServidor = "2ser" Then
                Button3.Text = "X"
                Button3.Enabled = False
                Me.BackColor = Color.Green
                b2 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "3ser" Then
                Button4.Text = "X"
                Me.BackColor = Color.Green
                Button4.Enabled = False
                b3 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "4ser" Then
                Button5.Text = "X"
                Button5.Enabled = False
                Me.BackColor = Color.Green
                b4 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "5ser" Then
                Button6.Text = "X"
                Button6.Enabled = False
                Me.BackColor = Color.Green
                b5 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "6ser" Then
                Button7.Text = "X"
                Button7.Enabled = False
                Me.BackColor = Color.Green
                b6 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "7ser" Then
                Button8.Text = "X"
                Button8.Enabled = False
                Me.BackColor = Color.Green
                b7 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "8ser" Then
                Button9.Text = "X"
                Button9.Enabled = False
                Me.BackColor = Color.Green
                b8 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornServidor = "9ser" Then
                Button10.Text = "X"
                Button10.Enabled = False
                Me.BackColor = Color.Green
                b9 = True
                torn = False
                Timer1.Enabled = True

            End If

        Catch ex As Exception

        End Try

    End Sub


End Class