Imports System.Data.SqlTypes
Imports MySql.Data.MySqlClient
Public Class fmsgeber
    Dim stringConn As String
    Dim stringCmd As String
    Dim myConn As MySqlConnection
    Dim myCmd As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim READER As MySqlDataReader
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub LadeDeinFahrzeug()
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        stringCmd = "SELECT * FROM sis_vehicles where name='" & Veh & "'"

        'Frame your connection string here.
        stringConn = (“server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")

        'Get your connection here.
        myConn = New MySqlConnection(stringConn)

        'Get a command by using your connection and query.
        myCmd = New MySqlCommand(stringCmd, myConn)

        'Open the connection.
        myConn.Open()

        'create a reader to store the datum which will be returned from the DB
        Dim myReader As MySqlDataReader

        'Execute your query using .ExecuteReader()
        myReader = myCmd.ExecuteReader()

        'Reset your List box here.

        While (myReader.Read())
            'Add the items from db one by one into the list box.
            fms_label.Text = myReader.GetString(3)
        End While
        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()

    End Sub
    Private Sub fmsgeber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LadeDeinFahrzeug()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LadeDeinFahrzeug()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        selectveh.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles fms_1.Click
        fmsModule.SetStatus(1, "Frei auf Status")
    End Sub

    Private Sub fms_2_Click(sender As Object, e As EventArgs) Handles fms_2.Click
        fmsModule.SetStatus(2, "Frei auf Wache")
    End Sub

    Private Sub fms_3_Click(sender As Object, e As EventArgs) Handles fms_3.Click
        fmsModule.SetStatus(3, "Einsatz übernommen")
    End Sub

    Private Sub fms_4_Click(sender As Object, e As EventArgs) Handles fms_4.Click
        fmsModule.SetStatus(4, "An Einsatzstelle eingetroffen")
    End Sub

    Private Sub fms_5_Click(sender As Object, e As EventArgs) Handles fms_5.Click
        fmsModule.SetStatus(5, "Sprechwunsch")
    End Sub

    Private Sub fms_6_Click(sender As Object, e As EventArgs) Handles fms_6.Click
        fmsModule.SetStatus(6, "Nicht Einsatzbereit")
    End Sub

    Private Sub fms_7_Click(sender As Object, e As EventArgs) Handles fms_7.Click
        fmsModule.SetStatus(7, "Patient aufgenommen")
    End Sub

    Private Sub fms_8_Click(sender As Object, e As EventArgs) Handles fms_8.Click
        fmsModule.SetStatus(8, "Am Transportziel")
    End Sub

    Private Sub fms_9_Click(sender As Object, e As EventArgs) Handles fms_9.Click
        fmsModule.SetStatus(9, "Notarzt aufgenommen")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles fms_0.Click
        fmsModule.SetStatus(0, "NOTRUF!")
        fms_label.ForeColor = Color.Red
    End Sub

    Private Sub emergency_Tick(sender As Object, e As EventArgs) Handles emergency.Tick

    End Sub
End Class