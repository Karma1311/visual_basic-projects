Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComposicioTableAdapter.Fill(Me.DataSet1.Composicio)
        Me.ElementTableAdapter.Fill(Me.DataSet1.Element)
        Me.FormulaTableAdapter.Fill(Me.DataSet1.Formula)

        Try
            EleCom.DataSource = DataSet1.Element(0)
            forCom.DataSource = DataSet1.Formula(0)

        Catch ex As Exception

        End Try

    End Sub

    'Afegir Formmules
    Private Sub Forms(sender As Object, e As EventArgs) Handles Form.Click
        Try
            If cText1.Text <> "" Then
                Me.FormulaTableAdapter.Insert(cText1.Text, nomText1.Text, DateTimePicker1.Value, CheckBox1.Checked)
                Me.FormulaTableAdapter.Fill(DataSet1.Formula)
                DataGridView2.Update()
                MsgBox("Formula inserida amb exit")


                resetCamps()


            End If
        Catch ex As Exception
            MsgBox("Aquesta formula ja existeix")
            cText1.Text = ""
            nomText1.Text = ""
        End Try
    End Sub

    'Afegir Elements
    Private Sub Elems(sender As Object, e As EventArgs)

    End Sub
    Sub resetCamps()
        cText1.Text = ""
        nomText1.Text = ""
        DateTimePicker1.Value = Date.Today
        CheckBox1.Checked = False

        codiText2.Text = ""
        nomText2.Text = ""

        gText.Text = ""

        TextBox1.Text = ""
        TextBox4.Text = ""
        DateTimePicker3.Value = Date.Today
        CheckBox2.Checked = False

    End Sub

    'Afegir Composicions
    Private Sub Comps(sender As Object, e As EventArgs) Handles Compos.Click
        Try
            If gText.Text = "" Then
                Exit Sub
            Else
                Me.ComposicioTableAdapter.Insert(forCom.SelectedValue, EleCom.SelectedValue, gText.Text)
                Me.ComposicioTableAdapter.Fill(Me.DataSet1.Composicio)
                MsgBox("Composicio inserida correctament")
                resetCamps()
            End If
        Catch ex As Exception
            MsgBox("Ja esta Inserida")
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim ds As New DataSet()
        Dim dt As New DataTable()


        dt.Columns.Add("Formula", GetType(String))
        dt.Columns.Add("Element", GetType(String))
        dt.Columns.Add("Grams", GetType(Double))
        ds.Tables.Add(dt)

        Dim cmd As String = "SELECT Formula.nom As Formula, Element.nom As Element, Composicio.grams As Grams FROM Composicio INNER JOIN Formula ON Composicio.codiFormula = Formula.codiFormula INNER JOIN Element ON Composicio.codiElement = Element.codiElement)"
        Using con As New SqlConnection("Data Source=RENATO\SQLEXPRESS;Initial Catalog=Formules;Integrated Security=True")
            Dim adpt As New SqlDataAdapter(cmd, con)
            adpt.Fill(dt)

        End Using

        DataGridView4.DataSource = dt
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView2.DataSource = Me.FormulaTableAdapter.GetDataByDate(DateTimePicker2.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView2.DataSource = Me.FormulaTableAdapter.GetDataBy11
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView2.DataSource = Me.FormulaTableAdapter.GetDataBy1
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form As Integer
        form = ComboBox3.SelectedValue
        Me.FormulaTableAdapter.DeleteQuery(form)
        Me.FormulaTableAdapter.Fill(Me.DataSet1.Formula)


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim codielem As Integer = ComboBox4.SelectedValue
        Dim nomelem As String = TextBox4.Text
        Try
            Me.ElementTableAdapter.UpdateQuery(nomelem, codielem, codielem)
            Me.ElementTableAdapter.Fill(DataSet1.Element)
            MsgBox("Modificat amb exit")
            resetCamps()
        Catch ex As Exception
            MsgBox("Modifiqui el nom sisplau")
            resetCamps()
        End Try

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim codiform As Integer = ComboBox5.SelectedValue
        Dim nomform As String = TextBox1.Text
        Dim datanova As Date = DateTimePicker3.Value
        Dim actius As Boolean = CheckBox2.Checked
        Try
            Me.FormulaTableAdapter.UpdateQuery(nomform, datanova, actius, codiform)
            Me.FormulaTableAdapter.Fill(DataSet1.Formula)
            MsgBox("Modificat amb exit")
            resetCamps()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Dim ds As New DataSet()
        Dim dt As New DataTable()

        Try
            dt.Columns.Add("Formula", GetType(String))
            dt.Columns.Add("Element", GetType(String))
            dt.Columns.Add("Grams", GetType(Double))
            ' ds.Tables.Add(dt)

            Dim cmd As String = "SELECT Formula.nom As Formula, Element.nom As Element, Composicio.grams As Grams FROM Composicio INNER JOIN Formula ON Composicio.codiFormula = Formula.codiFormula INNER JOIN Element ON Composicio.codiElement = Element.codiElement WHERE (Element.codiElement =" + ComboBox1.SelectedValue.ToString + ")"
            Using con As New SqlConnection("Data Source=RENATO\SQLEXPRESS;Initial Catalog=Formules;Integrated Security=True")
                Dim adpt As New SqlDataAdapter(cmd, con)
                adpt.Fill(dt)

            End Using

            DataGridView4.DataSource = dt
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.ElementTableAdapter.Insert(codiText2.Text, nomText2.Text)
            Me.ElementTableAdapter.Fill(DataSet1.Element)

            resetCamps()
            MsgBox("Element inserit amb exit")

        Catch ex As Exception
            MsgBox("Aquest element ja existeix")
        End Try

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub
End Class
