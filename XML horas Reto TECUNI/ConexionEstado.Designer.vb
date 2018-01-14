<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConexionEstado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConexionEstado))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelEstado = New System.Windows.Forms.Label()
        Me.pbEstado = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(115, 335)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 89)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.ErrorImage = CType(resources.GetObject("PictureBox3.ErrorImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(115, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(328, 101)
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(115, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(328, 105)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Quicksand Medium", 19.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(368, 690)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 39)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "   Zona 1   "
        '
        'LabelEstado
        '
        Me.LabelEstado.BackColor = System.Drawing.Color.Transparent
        Me.LabelEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelEstado.Font = New System.Drawing.Font("Quicksand Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstado.ForeColor = System.Drawing.Color.White
        Me.LabelEstado.Location = New System.Drawing.Point(536, 124)
        Me.LabelEstado.Name = "LabelEstado"
        Me.LabelEstado.Size = New System.Drawing.Size(487, 145)
        Me.LabelEstado.TabIndex = 35
        Me.LabelEstado.Text = "          Conexión con el PLC realizada con éxito!"
        Me.LabelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbEstado
        '
        Me.pbEstado.BackColor = System.Drawing.Color.Transparent
        Me.pbEstado.BackgroundImage = CType(resources.GetObject("pbEstado.BackgroundImage"), System.Drawing.Image)
        Me.pbEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEstado.ErrorImage = CType(resources.GetObject("pbEstado.ErrorImage"), System.Drawing.Image)
        Me.pbEstado.Location = New System.Drawing.Point(115, 12)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(26, 26)
        Me.pbEstado.TabIndex = 36
        Me.pbEstado.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(161, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(374, 101)
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(719, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 68)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Comprobar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.ErrorImage = CType(resources.GetObject("PictureBox5.ErrorImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 457)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(91, 117)
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.ErrorImage = CType(resources.GetObject("PictureBox6.ErrorImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 334)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(91, 117)
        Me.PictureBox6.TabIndex = 44
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.ErrorImage = CType(resources.GetObject("PictureBox7.ErrorImage"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(-1, 123)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(91, 105)
        Me.PictureBox7.TabIndex = 43
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(-1, 226)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(90, 97)
        Me.PictureBox8.TabIndex = 42
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.ErrorImage = CType(resources.GetObject("PictureBox9.ErrorImage"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(-1, 12)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(91, 105)
        Me.PictureBox9.TabIndex = 41
        Me.PictureBox9.TabStop = False
        '
        'ConexionEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1093, 585)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.LabelEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConexionEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConexionEstado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents LabelEstado As Windows.Forms.Label
    Friend WithEvents pbEstado As Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As Windows.Forms.PictureBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents PictureBox5 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As Windows.Forms.PictureBox
End Class
