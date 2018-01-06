Imports System.Drawing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvCielo = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbCurva = New System.Windows.Forms.TextBox()
        Me.cbCM = New System.Windows.Forms.CheckBox()
        Me.cbLL = New System.Windows.Forms.CheckBox()
        Me.cbCC = New System.Windows.Forms.CheckBox()
        Me.cbLN = New System.Windows.Forms.CheckBox()
        Me.lvOtrasCondiciones = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelIzq = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbPerfiles = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelIzq.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lvCielo)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 202)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones del cielo"
        '
        'lvCielo
        '
        Me.lvCielo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCielo.FormattingEnabled = True
        Me.lvCielo.Location = New System.Drawing.Point(3, 16)
        Me.lvCielo.Name = "lvCielo"
        Me.lvCielo.Size = New System.Drawing.Size(422, 183)
        Me.lvCielo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tbCurva)
        Me.GroupBox2.Controls.Add(Me.cbCM)
        Me.GroupBox2.Controls.Add(Me.cbLL)
        Me.GroupBox2.Controls.Add(Me.cbCC)
        Me.GroupBox2.Controls.Add(Me.cbLN)
        Me.GroupBox2.Location = New System.Drawing.Point(680, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 199)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fase lunar"
        '
        'tbCurva
        '
        Me.tbCurva.Location = New System.Drawing.Point(41, 130)
        Me.tbCurva.Name = "tbCurva"
        Me.tbCurva.Size = New System.Drawing.Size(175, 20)
        Me.tbCurva.TabIndex = 8
        '
        'cbCM
        '
        Me.cbCM.AutoSize = True
        Me.cbCM.Enabled = False
        Me.cbCM.Location = New System.Drawing.Point(41, 107)
        Me.cbCM.Name = "cbCM"
        Me.cbCM.Size = New System.Drawing.Size(113, 17)
        Me.cbCM.TabIndex = 3
        Me.cbCM.Text = "Cuarto menguante"
        Me.cbCM.UseVisualStyleBackColor = True
        '
        'cbLL
        '
        Me.cbLL.AutoSize = True
        Me.cbLL.Enabled = False
        Me.cbLL.Location = New System.Drawing.Point(41, 83)
        Me.cbLL.Name = "cbLL"
        Me.cbLL.Size = New System.Drawing.Size(77, 17)
        Me.cbLL.TabIndex = 2
        Me.cbLL.Text = "Lluna llena"
        Me.cbLL.UseVisualStyleBackColor = True
        '
        'cbCC
        '
        Me.cbCC.AutoSize = True
        Me.cbCC.Enabled = False
        Me.cbCC.Location = New System.Drawing.Point(41, 59)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(104, 17)
        Me.cbCC.TabIndex = 1
        Me.cbCC.Text = "Cuarto creciente"
        Me.cbCC.UseVisualStyleBackColor = True
        '
        'cbLN
        '
        Me.cbLN.AutoSize = True
        Me.cbLN.Enabled = False
        Me.cbLN.Location = New System.Drawing.Point(41, 35)
        Me.cbLN.Name = "cbLN"
        Me.cbLN.Size = New System.Drawing.Size(85, 17)
        Me.cbLN.TabIndex = 0
        Me.cbLN.Text = "Lluna nueva"
        Me.cbLN.UseVisualStyleBackColor = True
        '
        'lvOtrasCondiciones
        '
        Me.lvOtrasCondiciones.Location = New System.Drawing.Point(231, 354)
        Me.lvOtrasCondiciones.Name = "lvOtrasCondiciones"
        Me.lvOtrasCondiciones.Size = New System.Drawing.Size(723, 158)
        Me.lvOtrasCondiciones.TabIndex = 17
        Me.lvOtrasCondiciones.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(852, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Quicksand Light", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 48)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Area de Perfiles"
        '
        'PanelIzq
        '
        Me.PanelIzq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelIzq.BackColor = System.Drawing.Color.Transparent
        Me.PanelIzq.Controls.Add(Me.Button3)
        Me.PanelIzq.Controls.Add(Me.Button2)
        Me.PanelIzq.Controls.Add(Me.GroupBox4)
        Me.PanelIzq.Location = New System.Drawing.Point(0, 97)
        Me.PanelIzq.Name = "PanelIzq"
        Me.PanelIzq.Size = New System.Drawing.Size(196, 488)
        Me.PanelIzq.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(130, 435)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 47)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 286)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 43)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbPerfiles)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(171, 269)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Perfiles"
        '
        'cbPerfiles
        '
        Me.cbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPerfiles.FormattingEnabled = True
        Me.cbPerfiles.Location = New System.Drawing.Point(7, 19)
        Me.cbPerfiles.Name = "cbPerfiles"
        Me.cbPerfiles.Size = New System.Drawing.Size(158, 21)
        Me.cbPerfiles.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(318, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 48)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(993, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvOtrasCondiciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelIzq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area de Perfiles"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelIzq.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Sub cargarPerfiles()
        Try
            Const fichero As String = "C:\Temp\Perfiles.txt"
            Dim contenidoFichero As New System.IO.StreamReader(fichero)
            Dim arrayRegistrosExistentes = contenidoFichero.ReadToEnd.Split("#")
            For Each registro As String In arrayRegistrosExistentes
                Dim arrayPerfilesExistentes = registro.Split("€")
                Me.cbPerfiles.Items.Add(arrayPerfilesExistentes(0))
            Next
            contenidoFichero.Close()

        Catch ex As Exception

        End Try
    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvCielo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbCurva As System.Windows.Forms.TextBox
    Friend WithEvents cbCM As System.Windows.Forms.CheckBox
    Friend WithEvents cbLL As System.Windows.Forms.CheckBox
    Friend WithEvents cbCC As System.Windows.Forms.CheckBox
    Friend WithEvents cbLN As System.Windows.Forms.CheckBox
    Friend WithEvents lvOtrasCondiciones As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelIzq As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPerfiles As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
