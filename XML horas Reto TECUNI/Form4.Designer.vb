<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pbEstado = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbTip = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(328, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(346, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 45)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(616, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 36)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'pbEstado
        '
        Me.pbEstado.BackColor = System.Drawing.Color.Transparent
        Me.pbEstado.BackgroundImage = CType(resources.GetObject("pbEstado.BackgroundImage"), System.Drawing.Image)
        Me.pbEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEstado.ErrorImage = CType(resources.GetObject("pbEstado.ErrorImage"), System.Drawing.Image)
        Me.pbEstado.Location = New System.Drawing.Point(12, 12)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(26, 26)
        Me.pbEstado.TabIndex = 7
        Me.pbEstado.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(177, 301)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(328, 45)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'pbTip
        '
        Me.pbTip.BackColor = System.Drawing.Color.Transparent
        Me.pbTip.BackgroundImage = CType(resources.GetObject("pbTip.BackgroundImage"), System.Drawing.Image)
        Me.pbTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbTip.Location = New System.Drawing.Point(0, -1)
        Me.pbTip.Name = "pbTip"
        Me.pbTip.Size = New System.Drawing.Size(668, 409)
        Me.pbTip.TabIndex = 9
        Me.pbTip.TabStop = False
        Me.pbTip.Visible = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.BackgroundImage = CType(resources.GetObject("btnOk.BackgroundImage"), System.Drawing.Image)
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(299, 119)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 50)
        Me.btnOk.TabIndex = 10
        Me.btnOk.UseVisualStyleBackColor = False
        Me.btnOk.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 409)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pbEstado)
        Me.Controls.Add(Me.pbTip)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents pbEstado As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents pbTip As Windows.Forms.PictureBox
    Friend WithEvents btnOk As Windows.Forms.Button
End Class
