<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.forcastImageBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.lblDay2 = New System.Windows.Forms.Label()
        Me.forcastImageBox2 = New System.Windows.Forms.PictureBox()
        Me.lblDescription3 = New System.Windows.Forms.Label()
        Me.lblDay3 = New System.Windows.Forms.Label()
        Me.forcastImageBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.forcastImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forcastImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forcastImageBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'forcastImageBox1
        '
        Me.forcastImageBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox1.Location = New System.Drawing.Point(181, 81)
        Me.forcastImageBox1.Name = "forcastImageBox1"
        Me.forcastImageBox1.Size = New System.Drawing.Size(130, 121)
        Me.forcastImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox1.TabIndex = 1
        Me.forcastImageBox1.TabStop = False
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(178, 45)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day "
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(284, 228)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(82, 13)
        Me.lblTemp.TabIndex = 3
        Me.lblTemp.Text = "Brief description"
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Location = New System.Drawing.Point(488, 228)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(80, 13)
        Me.lblDescription2.TabIndex = 7
        Me.lblDescription2.Text = "lblBriefDescrip2"
        '
        'lblDay2
        '
        Me.lblDay2.AutoSize = True
        Me.lblDay2.Location = New System.Drawing.Point(382, 45)
        Me.lblDay2.Name = "lblDay2"
        Me.lblDay2.Size = New System.Drawing.Size(29, 13)
        Me.lblDay2.TabIndex = 6
        Me.lblDay2.Text = "Day "
        '
        'forcastImageBox2
        '
        Me.forcastImageBox2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox2.Location = New System.Drawing.Point(385, 81)
        Me.forcastImageBox2.Name = "forcastImageBox2"
        Me.forcastImageBox2.Size = New System.Drawing.Size(130, 121)
        Me.forcastImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox2.TabIndex = 5
        Me.forcastImageBox2.TabStop = False
        '
        'lblDescription3
        '
        Me.lblDescription3.AutoSize = True
        Me.lblDescription3.Location = New System.Drawing.Point(693, 228)
        Me.lblDescription3.Name = "lblDescription3"
        Me.lblDescription3.Size = New System.Drawing.Size(80, 13)
        Me.lblDescription3.TabIndex = 10
        Me.lblDescription3.Text = "lblBfiefDescrip3"
        '
        'lblDay3
        '
        Me.lblDay3.AutoSize = True
        Me.lblDay3.Location = New System.Drawing.Point(587, 45)
        Me.lblDay3.Name = "lblDay3"
        Me.lblDay3.Size = New System.Drawing.Size(29, 13)
        Me.lblDay3.TabIndex = 9
        Me.lblDay3.Text = "Day "
        '
        'forcastImageBox3
        '
        Me.forcastImageBox3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.forcastImageBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.forcastImageBox3.Location = New System.Drawing.Point(590, 81)
        Me.forcastImageBox3.Name = "forcastImageBox3"
        Me.forcastImageBox3.Size = New System.Drawing.Size(130, 121)
        Me.forcastImageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.forcastImageBox3.TabIndex = 8
        Me.forcastImageBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 492)
        Me.Controls.Add(Me.lblDescription3)
        Me.Controls.Add(Me.lblDay3)
        Me.Controls.Add(Me.forcastImageBox3)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.lblDay2)
        Me.Controls.Add(Me.forcastImageBox2)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.forcastImageBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.forcastImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forcastImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forcastImageBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents forcastImageBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents lblDescription2 As System.Windows.Forms.Label
    Friend WithEvents lblDay2 As System.Windows.Forms.Label
    Friend WithEvents forcastImageBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription3 As System.Windows.Forms.Label
    Friend WithEvents lblDay3 As System.Windows.Forms.Label
    Friend WithEvents forcastImageBox3 As System.Windows.Forms.PictureBox

End Class
