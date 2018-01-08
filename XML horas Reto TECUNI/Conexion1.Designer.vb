<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conexion1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conexion1))
        Me.pbEstado = New System.Windows.Forms.PictureBox()
        Me.pbEstadoTexto = New System.Windows.Forms.Label()
        Me.puertoIP = New nsoftware.IPWorks.Ipport(Me.components)
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEstado
        '
        Me.pbEstado.BackColor = System.Drawing.Color.Transparent
        Me.pbEstado.BackgroundImage = CType(resources.GetObject("pbEstado.BackgroundImage"), System.Drawing.Image)
        Me.pbEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEstado.ErrorImage = CType(resources.GetObject("pbEstado.ErrorImage"), System.Drawing.Image)
        Me.pbEstado.Location = New System.Drawing.Point(12, 2)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(26, 26)
        Me.pbEstado.TabIndex = 8
        Me.pbEstado.TabStop = False
        '
        'pbEstadoTexto
        '
        Me.pbEstadoTexto.AutoSize = True
        Me.pbEstadoTexto.BackColor = System.Drawing.Color.Transparent
        Me.pbEstadoTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbEstadoTexto.Font = New System.Drawing.Font("Quicksand Light", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbEstadoTexto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbEstadoTexto.Location = New System.Drawing.Point(54, 0)
        Me.pbEstadoTexto.Name = "pbEstadoTexto"
        Me.pbEstadoTexto.Size = New System.Drawing.Size(115, 28)
        Me.pbEstadoTexto.TabIndex = 9
        Me.pbEstadoTexto.Text = "Conectado"
        '
        'puertoIP
        '
        Me.puertoIP.About = "IP*Works! 2016 [Build 6446]"
        '
        'Conexion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 112)
        Me.Controls.Add(Me.pbEstadoTexto)
        Me.Controls.Add(Me.pbEstado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(800, 550)
        Me.Name = "Conexion1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Conexion1"
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbEstado As Windows.Forms.PictureBox
    Friend WithEvents pbEstadoTexto As Windows.Forms.Label
    Friend WithEvents puertoIP As nsoftware.IPWorks.Ipport
End Class
