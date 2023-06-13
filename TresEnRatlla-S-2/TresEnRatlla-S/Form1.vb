
Imports AxMSWinsockLib
Public Class Form1

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

    Dim tornClient As String = ""

    'Conexions
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AxWinsock1.LocalPort = 8888
            Label1.Text = AxWinsock1.LocalIP
            Label4.Text = AxWinsock1.LocalPort
            AxWinsock1.Listen()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AxWinsock1_ConnectionRequest(sender As Object, e As DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        AxWinsock1.Close()
        AxWinsock1.Accept(e.requestID)

    End Sub

    'Servidor
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If torn = False Then
                Button2.Text = "X"
                AxWinsock1.SendData("1ser")
                Me.BackColor = Color.White
                Button2.Enabled = False
                Timer1.Enabled = False
                a1 = True
                b1 = True
                torn = True
            End If
            guanyador()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If torn = False Then
                Button3.Text = "X"
                AxWinsock1.SendData("2ser")
                Me.BackColor = Color.White
                Button3.Enabled = False
                Timer1.Enabled = False
                a2 = True
                b2 = True
            End If
            guanyador()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If torn = False Then
            Button4.Text = "X"
            AxWinsock1.SendData("3ser")
            Me.BackColor = Color.White
            Button4.Enabled = False
            Timer1.Enabled = False
            a3 = True
            b3 = True
        End If
        guanyador()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If torn = False Then
            Button5.Text = "X"
            AxWinsock1.SendData("4ser")
            Me.BackColor = Color.White
            Button5.Enabled = False
            Timer1.Enabled = False
            a4 = True
            b4 = True
        End If
        guanyador()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If torn = False Then
            Button6.Text = "X"
            AxWinsock1.SendData("5ser")
            Me.BackColor = Color.White
            Button6.Enabled = False
            Timer1.Enabled = False
            a5 = True
            b5 = True
        End If
        guanyador()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If torn = False Then
            Button7.Text = "X"
            AxWinsock1.SendData("6ser")
            Me.BackColor = Color.White
            Button7.Enabled = False
            Timer1.Enabled = False
            a6 = True
            b6 = True
        End If
        guanyador()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If torn = False Then
            Button8.Text = "X"
            AxWinsock1.SendData("7ser")
            Me.BackColor = Color.White
            Button8.Enabled = False
            Timer1.Enabled = False
            a7 = True
            b7 = True
        End If
        guanyador()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If torn = False Then
            Button9.Text = "X"
            AxWinsock1.SendData("8ser")
            Me.BackColor = Color.White
            Button9.Enabled = False
            Timer1.Enabled = False
            a8 = True
            b8 = True
        End If
        guanyador()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If torn = False Then
            Button10.Text = "X"
            AxWinsock1.SendData("9ser")
            Me.BackColor = Color.White
            Button10.Enabled = False
            Timer1.Enabled = False
            a9 = True
            b9 = True
        End If
        guanyador()
    End Sub

    'Repercusions al Client
    Private Sub AxWinsock1_DataArrival(sender As Object, e As DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival

        Try
            AxWinsock1.GetData(tornClient)
            If tornClient = "1cli" Then
                Me.BackColor = Color.Green
                Button2.Text = "O"
                Button2.Enabled = False
                b1 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "2cli" Then
                Button2.Text = "O"
                Button3.Enabled = False
                Me.BackColor = Color.Green
                b2 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "3cli" Then
                Button2.Text = "O"
                Button4.Enabled = False
                Me.BackColor = Color.Green
                b3 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "4cli" Then
                Button2.Text = "O"
                Button5.Enabled = False
                Me.BackColor = Color.Green
                b4 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "5cli" Then
                Button2.Text = "O"
                Button6.Enabled = False
                Me.BackColor = Color.Green
                b5 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "6cli" Then
                Button2.Text = "O"
                Button7.Enabled = False
                Me.BackColor = Color.Green
                b6 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "7cli" Then
                Button2.Text = "O"
                Button8.Enabled = False
                Me.BackColor = Color.Green
                b7 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "8cli" Then
                Button2.Text = "O"
                Button9.Enabled = False
                Me.BackColor = Color.Green
                b8 = True
                torn = False
                Timer1.Enabled = True

            ElseIf tornClient = "9cli" Then
                Button2.Text = "O"
                Button10.Enabled = False
                Me.BackColor = Color.Green
                b9 = True
                torn = False
                Timer1.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Temporitzador
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

    'Comprovacio de si ha de guanyar el servidor
    Public Sub guanyador()
        If (a1 = True And a2 = True And a3 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a4 = True And a5 = True And a6 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a7 = True And a8 = True And a9 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a1 = True And a4 = True And a7 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a2 = True And a5 = True And a8 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a3 = True And a6 = True And a9 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a1 = True And a5 = True And a9 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a3 = True And a5 = True And a7 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
            reset()
        ElseIf (a4 = True And a5 = True And a6 = True) Then
            MsgBox("Guanya Servidor !!")
            AxWinsock1.SendData("Guanya Servidor !!")
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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("Pulsi connectar per començar el joc")
        Form2.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        reset()
    End Sub



End Class
