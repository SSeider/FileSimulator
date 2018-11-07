<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(12, 207)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(325, 23)
        Me.button2.TabIndex = 23
        Me.button2.Text = "Start"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 165)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(139, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Dauer der Erstellung (in ms):"
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(12, 181)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(325, 20)
        Me.textBox5.TabIndex = 21
        Me.textBox5.Text = "2500"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 126)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(214, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Dateierweiterung nach Erstellung (z.B. ""tif""):"
        '
        'textBox4
        '
        Me.textBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileSimulator2.My.MySettings.Default, "fileext2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.textBox4.Location = New System.Drawing.Point(12, 142)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(325, 20)
        Me.textBox4.TabIndex = 19
        Me.textBox4.Text = Global.FileSimulator2.My.MySettings.Default.fileext2
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(227, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Dateierweiterung während Erstellung (z.B. tif_):"
        '
        'textBox3
        '
        Me.textBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileSimulator2.My.MySettings.Default, "fileext1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.textBox3.Location = New System.Drawing.Point(12, 103)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(325, 20)
        Me.textBox3.TabIndex = 17
        Me.textBox3.Text = Global.FileSimulator2.My.MySettings.Default.fileext1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(118, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Dateiname (z.B. ""test""):"
        '
        'textBox2
        '
        Me.textBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileSimulator2.My.MySettings.Default, "filename", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.textBox2.Location = New System.Drawing.Point(12, 64)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(325, 20)
        Me.textBox2.TabIndex = 15
        Me.textBox2.Text = Global.FileSimulator2.My.MySettings.Default.filename
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(343, 23)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(32, 23)
        Me.button1.TabIndex = 14
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(200, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Pfad in dem die Datei erstellt werden soll:"
        '
        'textBox1
        '
        Me.textBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.FileSimulator2.My.MySettings.Default, "filepath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.textBox1.Location = New System.Drawing.Point(12, 25)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(325, 20)
        Me.textBox1.TabIndex = 12
        Me.textBox1.Text = Global.FileSimulator2.My.MySettings.Default.filepath
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 252)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.MaximumSize = New System.Drawing.Size(410, 291)
        Me.MinimumSize = New System.Drawing.Size(410, 291)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileSimulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents label5 As Label
    Private WithEvents textBox5 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents textBox4 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents button1 As Button
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
