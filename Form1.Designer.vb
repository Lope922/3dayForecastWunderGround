<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGetWeather = New System.Windows.Forms.Button()
        Me.forcastImageBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.lblDay2 = New System.Windows.Forms.Label()
        Me.forcastImageBox2 = New System.Windows.Forms.PictureBox()
        Me.lblDescription3 = New System.Windows.Forms.Label()
        Me.lblDay3 = New System.Windows.Forms.Label()
        Me.forcastImageBox3 = New System.Windows.Forms.PictureBox()
        Me.apiBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.txtBoxCityName = New System.Windows.Forms.TextBox()
        Me.comboBoxStates = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.forcastImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forcastImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forcastImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGetWeather
        '
        Me.btnGetWeather.Location = New System.Drawing.Point(51, 146)
        Me.btnGetWeather.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetWeather.Name = "btnGetWeather"
        Me.btnGetWeather.Size = New System.Drawing.Size(143, 63)
        Me.btnGetWeather.TabIndex = 0
        Me.btnGetWeather.Text = "&Get Weather"
        Me.btnGetWeather.UseVisualStyleBackColor = True
        '
        'forcastImageBox1
        '
        Me.forcastImageBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox1.Location = New System.Drawing.Point(93, 362)
        Me.forcastImageBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.forcastImageBox1.Name = "forcastImageBox1"
        Me.forcastImageBox1.Size = New System.Drawing.Size(194, 148)
        Me.forcastImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox1.TabIndex = 1
        Me.forcastImageBox1.TabStop = False
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(89, 318)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(58, 25)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day "
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(230, 543)
        Me.lblTemp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(174, 25)
        Me.lblTemp.TabIndex = 3
        Me.lblTemp.Text = "Brief description"
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription2.Location = New System.Drawing.Point(502, 543)
        Me.lblDescription2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(167, 25)
        Me.lblDescription2.TabIndex = 7
        Me.lblDescription2.Text = "lblBriefDescrip2"
        '
        'lblDay2
        '
        Me.lblDay2.AutoSize = True
        Me.lblDay2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay2.Location = New System.Drawing.Point(361, 318)
        Me.lblDay2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(58, 25)
        Me.lblDay2.TabIndex = 6
        Me.lblDay2.Text = "Day "
        '
        'forcastImageBox2
        '
        Me.forcastImageBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox2.Location = New System.Drawing.Point(365, 362)
        Me.forcastImageBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.forcastImageBox2.Name = "forcastImageBox2"
        Me.forcastImageBox2.Size = New System.Drawing.Size(194, 148)
        Me.forcastImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox2.TabIndex = 5
        Me.forcastImageBox2.TabStop = False
        '
        'lblDescription3
        '
        Me.lblDescription3.AutoSize = True
        Me.lblDescription3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription3.Location = New System.Drawing.Point(776, 543)
        Me.lblDescription3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription3.Name = "lblDescription3"
        Me.lblDescription3.Size = New System.Drawing.Size(165, 25)
        Me.lblDescription3.TabIndex = 10
        Me.lblDescription3.Text = "lblBfiefDescrip3"
        '
        'lblDay3
        '
        Me.lblDay3.AutoSize = True
        Me.lblDay3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay3.Location = New System.Drawing.Point(634, 318)
        Me.lblDay3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(58, 25)
        Me.lblDay3.TabIndex = 9
        Me.lblDay3.Text = "Day "
        '
        'forcastImageBox3
        '
        Me.forcastImageBox3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox3.Location = New System.Drawing.Point(638, 362)
        Me.forcastImageBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.forcastImageBox3.Name = "forcastImageBox3"
        Me.forcastImageBox3.Size = New System.Drawing.Size(194, 148)
        Me.forcastImageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox3.TabIndex = 8
        Me.forcastImageBox3.TabStop = False
        '
        'apiBackgroundWorker
        '
        '
        'txtBoxCityName
        '
        Me.txtBoxCityName.Location = New System.Drawing.Point(16, 15)
        Me.txtBoxCityName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBoxCityName.Name = "txtBoxCityName"
        Me.txtBoxCityName.Size = New System.Drawing.Size(212, 22)
        Me.txtBoxCityName.TabIndex = 11
        Me.txtBoxCityName.Text = "Enter City Name"
        '
        'comboBoxStates
        '
        Me.comboBoxStates.AllowDrop = True
        Me.comboBoxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxStates.FormattingEnabled = True
        Me.comboBoxStates.Items.AddRange(New Object() {"---", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.comboBoxStates.Location = New System.Drawing.Point(85, 85)
        Me.comboBoxStates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboBoxStates.Name = "comboBoxStates"
        Me.comboBoxStates.Size = New System.Drawing.Size(125, 24)
        Me.comboBoxStates.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(36, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 282)
        Me.Panel1.TabIndex = 13
        '
        'Main
        '
        Me.AcceptButton = Me.btnGetWeather
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(981, 628)
        Me.Controls.Add(Me.comboBoxStates)
        Me.Controls.Add(Me.txtBoxCityName)
        Me.Controls.Add(Me.lblDescription3)
        Me.Controls.Add(Me.lblDay3)
        Me.Controls.Add(Me.forcastImageBox3)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.lblDay2)
        Me.Controls.Add(Me.forcastImageBox2)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.forcastImageBox1)
        Me.Controls.Add(Me.btnGetWeather)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.Text = "3 Day Forecast"
        CType(Me.forcastImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forcastImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forcastImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetWeather As System.Windows.Forms.Button
    Friend WithEvents forcastImageBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents lblDescription2 As System.Windows.Forms.Label
    Friend WithEvents lblDay2 As System.Windows.Forms.Label
    Friend WithEvents forcastImageBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription3 As System.Windows.Forms.Label
    Friend WithEvents lblDay3 As System.Windows.Forms.Label
    Friend WithEvents forcastImageBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents apiBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtBoxCityName As System.Windows.Forms.TextBox
    Friend WithEvents comboBoxStates As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As Panel
End Class
