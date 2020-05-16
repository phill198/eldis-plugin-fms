Imports MySql.Data.MySqlClient
Public Class selectveh
    Private Sub LadeDeinFahrzeug()
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        stringCmd = "SELECT * FROM sis_vehicles"

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
            ComboBox1.Items.Add(myReader.GetString(1))
        End While
        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CurrentVehInit(ComboBox1.SelectedItem)
        fmsgeber.Show()
        Me.Hide()
    End Sub

    Private Sub selectveh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configModule.InitMySQL("mysql-mariadb-20-104.zap-hosting.com", " zap349503-3", "FNSS08s8MYNqig2k", "zap349503-3")
        LadeDeinFahrzeug()
    End Sub
End Class