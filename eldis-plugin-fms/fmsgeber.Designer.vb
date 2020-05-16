<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmsgeber
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.fms_label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fms_2 = New System.Windows.Forms.Button()
        Me.fms_3 = New System.Windows.Forms.Button()
        Me.fms_6 = New System.Windows.Forms.Button()
        Me.fms_5 = New System.Windows.Forms.Button()
        Me.fms_4 = New System.Windows.Forms.Button()
        Me.fms_9 = New System.Windows.Forms.Button()
        Me.fms_8 = New System.Windows.Forms.Button()
        Me.fms_7 = New System.Windows.Forms.Button()
        Me.fms_color = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fms_1 = New System.Windows.Forms.Button()
        Me.emergency_label = New System.Windows.Forms.PictureBox()
        Me.fms_0 = New System.Windows.Forms.Button()
        Me.emergency = New System.Windows.Forms.Timer(Me.components)
        CType(Me.fms_color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emergency_label, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fms_label
        '
        Me.fms_label.AutoSize = True
        Me.fms_label.BackColor = System.Drawing.Color.LawnGreen
        Me.fms_label.Font = New System.Drawing.Font("Arial", 50.0!, System.Drawing.FontStyle.Bold)
        Me.fms_label.ForeColor = System.Drawing.Color.White
        Me.fms_label.Location = New System.Drawing.Point(107, 102)
        Me.fms_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.fms_label.Name = "fms_label"
        Me.fms_label.Size = New System.Drawing.Size(70, 78)
        Me.fms_label.TabIndex = 5
        Me.fms_label.Text = "1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fms_2
        '
        Me.fms_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_2.Location = New System.Drawing.Point(115, 405)
        Me.fms_2.Name = "fms_2"
        Me.fms_2.Size = New System.Drawing.Size(53, 37)
        Me.fms_2.TabIndex = 9
        Me.fms_2.Text = "2"
        Me.fms_2.UseVisualStyleBackColor = True
        '
        'fms_3
        '
        Me.fms_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_3.Location = New System.Drawing.Point(179, 405)
        Me.fms_3.Name = "fms_3"
        Me.fms_3.Size = New System.Drawing.Size(53, 37)
        Me.fms_3.TabIndex = 10
        Me.fms_3.Text = "3"
        Me.fms_3.UseVisualStyleBackColor = True
        '
        'fms_6
        '
        Me.fms_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_6.Location = New System.Drawing.Point(179, 449)
        Me.fms_6.Name = "fms_6"
        Me.fms_6.Size = New System.Drawing.Size(53, 37)
        Me.fms_6.TabIndex = 13
        Me.fms_6.Text = "6"
        Me.fms_6.UseVisualStyleBackColor = True
        '
        'fms_5
        '
        Me.fms_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_5.Location = New System.Drawing.Point(115, 449)
        Me.fms_5.Name = "fms_5"
        Me.fms_5.Size = New System.Drawing.Size(53, 37)
        Me.fms_5.TabIndex = 12
        Me.fms_5.Text = "5"
        Me.fms_5.UseVisualStyleBackColor = True
        '
        'fms_4
        '
        Me.fms_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_4.Location = New System.Drawing.Point(51, 449)
        Me.fms_4.Name = "fms_4"
        Me.fms_4.Size = New System.Drawing.Size(53, 37)
        Me.fms_4.TabIndex = 11
        Me.fms_4.Text = "4"
        Me.fms_4.UseVisualStyleBackColor = True
        '
        'fms_9
        '
        Me.fms_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_9.Location = New System.Drawing.Point(179, 495)
        Me.fms_9.Name = "fms_9"
        Me.fms_9.Size = New System.Drawing.Size(53, 37)
        Me.fms_9.TabIndex = 16
        Me.fms_9.Text = "9"
        Me.fms_9.UseVisualStyleBackColor = True
        '
        'fms_8
        '
        Me.fms_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_8.Location = New System.Drawing.Point(115, 495)
        Me.fms_8.Name = "fms_8"
        Me.fms_8.Size = New System.Drawing.Size(53, 37)
        Me.fms_8.TabIndex = 15
        Me.fms_8.Text = "8"
        Me.fms_8.UseVisualStyleBackColor = True
        '
        'fms_7
        '
        Me.fms_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_7.Location = New System.Drawing.Point(51, 495)
        Me.fms_7.Name = "fms_7"
        Me.fms_7.Size = New System.Drawing.Size(53, 37)
        Me.fms_7.TabIndex = 14
        Me.fms_7.Text = "7"
        Me.fms_7.UseVisualStyleBackColor = True
        '
        'fms_color
        '
        Me.fms_color.BackColor = System.Drawing.Color.LawnGreen
        Me.fms_color.Location = New System.Drawing.Point(61, 90)
        Me.fms_color.Margin = New System.Windows.Forms.Padding(2)
        Me.fms_color.Name = "fms_color"
        Me.fms_color.Size = New System.Drawing.Size(163, 99)
        Me.fms_color.TabIndex = 4
        Me.fms_color.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eldis_plugin_fms.My.Resources.Resources.fms
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 934)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'fms_1
        '
        Me.fms_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_1.Location = New System.Drawing.Point(51, 405)
        Me.fms_1.Name = "fms_1"
        Me.fms_1.Size = New System.Drawing.Size(53, 37)
        Me.fms_1.TabIndex = 8
        Me.fms_1.Text = "1"
        Me.fms_1.UseVisualStyleBackColor = True
        '
        'emergency_label
        '
        Me.emergency_label.BackColor = System.Drawing.Color.Red
        Me.emergency_label.Location = New System.Drawing.Point(60, 50)
        Me.emergency_label.Name = "emergency_label"
        Me.emergency_label.Size = New System.Drawing.Size(92, 23)
        Me.emergency_label.TabIndex = 17
        Me.emergency_label.TabStop = False
        '
        'fms_0
        '
        Me.fms_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.fms_0.Location = New System.Drawing.Point(116, 544)
        Me.fms_0.Name = "fms_0"
        Me.fms_0.Size = New System.Drawing.Size(53, 37)
        Me.fms_0.TabIndex = 18
        Me.fms_0.Text = "0"
        Me.fms_0.UseVisualStyleBackColor = True
        '
        'emergency
        '
        '
        'fmsgeber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 922)
        Me.Controls.Add(Me.fms_0)
        Me.Controls.Add(Me.emergency_label)
        Me.Controls.Add(Me.fms_9)
        Me.Controls.Add(Me.fms_8)
        Me.Controls.Add(Me.fms_7)
        Me.Controls.Add(Me.fms_6)
        Me.Controls.Add(Me.fms_5)
        Me.Controls.Add(Me.fms_4)
        Me.Controls.Add(Me.fms_3)
        Me.Controls.Add(Me.fms_2)
        Me.Controls.Add(Me.fms_1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fms_label)
        Me.Controls.Add(Me.fms_color)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fmsgeber"
        Me.Text = "FMS"
        CType(Me.fms_color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emergency_label, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fms_label As Label
    Friend WithEvents fms_color As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents fms_2 As Button
    Friend WithEvents fms_3 As Button
    Friend WithEvents fms_6 As Button
    Friend WithEvents fms_5 As Button
    Friend WithEvents fms_4 As Button
    Friend WithEvents fms_9 As Button
    Friend WithEvents fms_8 As Button
    Friend WithEvents fms_7 As Button
    Friend WithEvents fms_1 As Button
    Friend WithEvents emergency_label As PictureBox
    Friend WithEvents fms_0 As Button
    Friend WithEvents emergency As Timer
End Class
