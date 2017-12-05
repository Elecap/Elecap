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
        Me.GroupBox1.Location = New System.Drawing.Point(304, 156)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(571, 249)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones del cielo"
        '
        'lvCielo
        '
        Me.lvCielo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCielo.FormattingEnabled = True
        Me.lvCielo.ItemHeight = 16
        Me.lvCielo.Location = New System.Drawing.Point(4, 19)
        Me.lvCielo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvCielo.Name = "lvCielo"
        Me.lvCielo.Size = New System.Drawing.Size(563, 226)
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
        Me.GroupBox2.Location = New System.Drawing.Point(907, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(365, 245)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fase lunar"
        '
        'tbCurva
        '
        Me.tbCurva.Location = New System.Drawing.Point(55, 160)
        Me.tbCurva.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCurva.Name = "tbCurva"
        Me.tbCurva.Size = New System.Drawing.Size(232, 22)
        Me.tbCurva.TabIndex = 8
        '
        'cbCM
        '
        Me.cbCM.AutoSize = True
        Me.cbCM.Enabled = False
        Me.cbCM.Location = New System.Drawing.Point(55, 132)
        Me.cbCM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCM.Name = "cbCM"
        Me.cbCM.Size = New System.Drawing.Size(147, 21)
        Me.cbCM.TabIndex = 3
        Me.cbCM.Text = "Cuarto menguante"
        Me.cbCM.UseVisualStyleBackColor = True
        '
        'cbLL
        '
        Me.cbLL.AutoSize = True
        Me.cbLL.Enabled = False
        Me.cbLL.Location = New System.Drawing.Point(55, 102)
        Me.cbLL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbLL.Name = "cbLL"
        Me.cbLL.Size = New System.Drawing.Size(99, 21)
        Me.cbLL.TabIndex = 2
        Me.cbLL.Text = "Lluna llena"
        Me.cbLL.UseVisualStyleBackColor = True
        '
        'cbCC
        '
        Me.cbCC.AutoSize = True
        Me.cbCC.Enabled = False
        Me.cbCC.Location = New System.Drawing.Point(55, 73)
        Me.cbCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(134, 21)
        Me.cbCC.TabIndex = 1
        Me.cbCC.Text = "Cuarto creciente"
        Me.cbCC.UseVisualStyleBackColor = True
        '
        'cbLN
        '
        Me.cbLN.AutoSize = True
        Me.cbLN.Enabled = False
        Me.cbLN.Location = New System.Drawing.Point(55, 43)
        Me.cbLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbLN.Name = "cbLN"
        Me.cbLN.Size = New System.Drawing.Size(108, 21)
        Me.cbLN.TabIndex = 0
        Me.cbLN.Text = "Lluna nueva"
        Me.cbLN.UseVisualStyleBackColor = True
        '
        'lvOtrasCondiciones
        '
        Me.lvOtrasCondiciones.Location = New System.Drawing.Point(308, 436)
        Me.lvOtrasCondiciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvOtrasCondiciones.Name = "lvOtrasCondiciones"
        Me.lvOtrasCondiciones.Size = New System.Drawing.Size(963, 194)
        Me.lvOtrasCondiciones.TabIndex = 17
        Me.lvOtrasCondiciones.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1136, 668)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 46)
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
        Me.PanelIzq.Location = New System.Drawing.Point(0, 119)
        Me.PanelIzq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelIzq.Name = "PanelIzq"
        Me.PanelIzq.Size = New System.Drawing.Size(261, 601)
        Me.PanelIzq.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(173, 535)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 58)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(4, 352)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 53)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cbPerfiles)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(228, 331)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Perfiles"
        '
        'cbPerfiles
        '
        Me.cbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPerfiles.FormattingEnabled = True
        Me.cbPerfiles.Location = New System.Drawing.Point(9, 23)
        Me.cbPerfiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPerfiles.Name = "cbPerfiles"
        Me.cbPerfiles.Size = New System.Drawing.Size(209, 24)
        Me.cbPerfiles.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvOtrasCondiciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelIzq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area de Perfiles"
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
End Class
