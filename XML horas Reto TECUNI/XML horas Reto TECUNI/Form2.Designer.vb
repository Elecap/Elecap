<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombrePerfil = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbIntervalosNubososLluviaEscasa = New System.Windows.Forms.CheckBox()
        Me.cbMuyNubosoLluviaEscasa = New System.Windows.Forms.CheckBox()
        Me.cbNubosoLluviaEscasa = New System.Windows.Forms.CheckBox()
        Me.cbCubiertoLluviaEscasa = New System.Windows.Forms.CheckBox()
        Me.cbCubierto = New System.Windows.Forms.CheckBox()
        Me.cbPocoNuboso = New System.Windows.Forms.CheckBox()
        Me.cbIntervalosNubosos = New System.Windows.Forms.CheckBox()
        Me.cbNuboso = New System.Windows.Forms.CheckBox()
        Me.cbDespejado = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCuartoMenguante = New System.Windows.Forms.CheckBox()
        Me.rbLunaLlena = New System.Windows.Forms.CheckBox()
        Me.rbCuartoCreciente = New System.Windows.Forms.CheckBox()
        Me.rbLunaNueva = New System.Windows.Forms.CheckBox()
        Me.cbTipoDia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.comboCurvas = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del perfil: "
        '
        'tbNombrePerfil
        '
        Me.tbNombrePerfil.Location = New System.Drawing.Point(111, 14)
        Me.tbNombrePerfil.Name = "tbNombrePerfil"
        Me.tbNombrePerfil.Size = New System.Drawing.Size(254, 20)
        Me.tbNombrePerfil.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbIntervalosNubososLluviaEscasa)
        Me.GroupBox1.Controls.Add(Me.cbMuyNubosoLluviaEscasa)
        Me.GroupBox1.Controls.Add(Me.cbNubosoLluviaEscasa)
        Me.GroupBox1.Controls.Add(Me.cbCubiertoLluviaEscasa)
        Me.GroupBox1.Controls.Add(Me.cbCubierto)
        Me.GroupBox1.Controls.Add(Me.cbPocoNuboso)
        Me.GroupBox1.Controls.Add(Me.cbIntervalosNubosos)
        Me.GroupBox1.Controls.Add(Me.cbNuboso)
        Me.GroupBox1.Controls.Add(Me.cbDespejado)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 226)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cielo"
        '
        'cbIntervalosNubososLluviaEscasa
        '
        Me.cbIntervalosNubososLluviaEscasa.AutoSize = True
        Me.cbIntervalosNubososLluviaEscasa.Location = New System.Drawing.Point(7, 207)
        Me.cbIntervalosNubososLluviaEscasa.Name = "cbIntervalosNubososLluviaEscasa"
        Me.cbIntervalosNubososLluviaEscasa.Size = New System.Drawing.Size(200, 17)
        Me.cbIntervalosNubososLluviaEscasa.TabIndex = 8
        Me.cbIntervalosNubososLluviaEscasa.Text = "Intervalos nubosos con lluvia escasa"
        Me.cbIntervalosNubososLluviaEscasa.UseVisualStyleBackColor = True
        '
        'cbMuyNubosoLluviaEscasa
        '
        Me.cbMuyNubosoLluviaEscasa.AutoSize = True
        Me.cbMuyNubosoLluviaEscasa.Location = New System.Drawing.Point(7, 184)
        Me.cbMuyNubosoLluviaEscasa.Name = "cbMuyNubosoLluviaEscasa"
        Me.cbMuyNubosoLluviaEscasa.Size = New System.Drawing.Size(169, 17)
        Me.cbMuyNubosoLluviaEscasa.TabIndex = 7
        Me.cbMuyNubosoLluviaEscasa.Text = "Muy nuboso con lluvia escasa"
        Me.cbMuyNubosoLluviaEscasa.UseVisualStyleBackColor = True
        '
        'cbNubosoLluviaEscasa
        '
        Me.cbNubosoLluviaEscasa.AutoSize = True
        Me.cbNubosoLluviaEscasa.Location = New System.Drawing.Point(7, 160)
        Me.cbNubosoLluviaEscasa.Name = "cbNubosoLluviaEscasa"
        Me.cbNubosoLluviaEscasa.Size = New System.Drawing.Size(148, 17)
        Me.cbNubosoLluviaEscasa.TabIndex = 6
        Me.cbNubosoLluviaEscasa.Text = "Nuboso con lluvia escasa"
        Me.cbNubosoLluviaEscasa.UseVisualStyleBackColor = True
        '
        'cbCubiertoLluviaEscasa
        '
        Me.cbCubiertoLluviaEscasa.AutoSize = True
        Me.cbCubiertoLluviaEscasa.Location = New System.Drawing.Point(7, 136)
        Me.cbCubiertoLluviaEscasa.Name = "cbCubiertoLluviaEscasa"
        Me.cbCubiertoLluviaEscasa.Size = New System.Drawing.Size(148, 17)
        Me.cbCubiertoLluviaEscasa.TabIndex = 5
        Me.cbCubiertoLluviaEscasa.Text = "Cubierto con luvia escasa"
        Me.cbCubiertoLluviaEscasa.UseVisualStyleBackColor = True
        '
        'cbCubierto
        '
        Me.cbCubierto.AutoSize = True
        Me.cbCubierto.Location = New System.Drawing.Point(7, 112)
        Me.cbCubierto.Name = "cbCubierto"
        Me.cbCubierto.Size = New System.Drawing.Size(65, 17)
        Me.cbCubierto.TabIndex = 4
        Me.cbCubierto.Text = "Cubierto"
        Me.cbCubierto.UseVisualStyleBackColor = True
        '
        'cbPocoNuboso
        '
        Me.cbPocoNuboso.AutoSize = True
        Me.cbPocoNuboso.Location = New System.Drawing.Point(6, 89)
        Me.cbPocoNuboso.Name = "cbPocoNuboso"
        Me.cbPocoNuboso.Size = New System.Drawing.Size(89, 17)
        Me.cbPocoNuboso.TabIndex = 3
        Me.cbPocoNuboso.Text = "Poco nuboso"
        Me.cbPocoNuboso.UseVisualStyleBackColor = True
        '
        'cbIntervalosNubosos
        '
        Me.cbIntervalosNubosos.AutoSize = True
        Me.cbIntervalosNubosos.Location = New System.Drawing.Point(6, 66)
        Me.cbIntervalosNubosos.Name = "cbIntervalosNubosos"
        Me.cbIntervalosNubosos.Size = New System.Drawing.Size(115, 17)
        Me.cbIntervalosNubosos.TabIndex = 2
        Me.cbIntervalosNubosos.Text = "Intervalos nubosos"
        Me.cbIntervalosNubosos.UseVisualStyleBackColor = True
        '
        'cbNuboso
        '
        Me.cbNuboso.AutoSize = True
        Me.cbNuboso.Location = New System.Drawing.Point(7, 43)
        Me.cbNuboso.Name = "cbNuboso"
        Me.cbNuboso.Size = New System.Drawing.Size(63, 17)
        Me.cbNuboso.TabIndex = 1
        Me.cbNuboso.Text = "Nuboso"
        Me.cbNuboso.UseVisualStyleBackColor = True
        '
        'cbDespejado
        '
        Me.cbDespejado.AutoSize = True
        Me.cbDespejado.Location = New System.Drawing.Point(7, 20)
        Me.cbDespejado.Name = "cbDespejado"
        Me.cbDespejado.Size = New System.Drawing.Size(77, 17)
        Me.cbDespejado.TabIndex = 0
        Me.cbDespejado.Text = "Despejado"
        Me.cbDespejado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbCuartoMenguante)
        Me.GroupBox2.Controls.Add(Me.rbLunaLlena)
        Me.GroupBox2.Controls.Add(Me.rbCuartoCreciente)
        Me.GroupBox2.Controls.Add(Me.rbLunaNueva)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 117)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fase lunar: "
        '
        'rbCuartoMenguante
        '
        Me.rbCuartoMenguante.AutoSize = True
        Me.rbCuartoMenguante.Location = New System.Drawing.Point(7, 89)
        Me.rbCuartoMenguante.Name = "rbCuartoMenguante"
        Me.rbCuartoMenguante.Size = New System.Drawing.Size(114, 17)
        Me.rbCuartoMenguante.TabIndex = 8
        Me.rbCuartoMenguante.Text = "Cuarto Menguante"
        Me.rbCuartoMenguante.UseVisualStyleBackColor = True
        '
        'rbLunaLlena
        '
        Me.rbLunaLlena.AutoSize = True
        Me.rbLunaLlena.Location = New System.Drawing.Point(7, 66)
        Me.rbLunaLlena.Name = "rbLunaLlena"
        Me.rbLunaLlena.Size = New System.Drawing.Size(79, 17)
        Me.rbLunaLlena.TabIndex = 7
        Me.rbLunaLlena.Text = "Luna Llena"
        Me.rbLunaLlena.UseVisualStyleBackColor = True
        '
        'rbCuartoCreciente
        '
        Me.rbCuartoCreciente.AutoSize = True
        Me.rbCuartoCreciente.Location = New System.Drawing.Point(7, 43)
        Me.rbCuartoCreciente.Name = "rbCuartoCreciente"
        Me.rbCuartoCreciente.Size = New System.Drawing.Size(105, 17)
        Me.rbCuartoCreciente.TabIndex = 5
        Me.rbCuartoCreciente.Text = "Cuarto Creciente"
        Me.rbCuartoCreciente.UseVisualStyleBackColor = True
        '
        'rbLunaNueva
        '
        Me.rbLunaNueva.AutoSize = True
        Me.rbLunaNueva.Location = New System.Drawing.Point(7, 20)
        Me.rbLunaNueva.Name = "rbLunaNueva"
        Me.rbLunaNueva.Size = New System.Drawing.Size(85, 17)
        Me.rbLunaNueva.TabIndex = 4
        Me.rbLunaNueva.Text = "Luna Nueva"
        Me.rbLunaNueva.UseVisualStyleBackColor = True
        '
        'cbTipoDia
        '
        Me.cbTipoDia.FormattingEnabled = True
        Me.cbTipoDia.Items.AddRange(New Object() {"Tipo1", "Tipo2", "Tpo3", "Tipo4", "Tipo5"})
        Me.cbTipoDia.Location = New System.Drawing.Point(99, 305)
        Me.cbTipoDia.Name = "cbTipoDia"
        Me.cbTipoDia.Size = New System.Drawing.Size(253, 21)
        Me.cbTipoDia.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(19, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Condiciones: "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.comboCurvas)
        Me.GroupBox3.Location = New System.Drawing.Point(240, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 102)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Curva: "
        '
        'comboCurvas
        '
        Me.comboCurvas.FormattingEnabled = True
        Me.comboCurvas.Items.AddRange(New Object() {"Curva1", "Curva2", "Curva3", "Curva4", "Curva5"})
        Me.comboCurvas.Location = New System.Drawing.Point(5, 32)
        Me.comboCurvas.Name = "comboCurvas"
        Me.comboCurvas.Size = New System.Drawing.Size(112, 21)
        Me.comboCurvas.TabIndex = 8
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(376, 244)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(123, 40)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(376, 290)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 40)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(511, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipoDia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbNombrePerfil)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNombrePerfil As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbIntervalosNubososLluviaEscasa As System.Windows.Forms.CheckBox
    Friend WithEvents cbMuyNubosoLluviaEscasa As System.Windows.Forms.CheckBox
    Friend WithEvents cbNubosoLluviaEscasa As System.Windows.Forms.CheckBox
    Friend WithEvents cbCubiertoLluviaEscasa As System.Windows.Forms.CheckBox
    Friend WithEvents cbCubierto As System.Windows.Forms.CheckBox
    Friend WithEvents cbPocoNuboso As System.Windows.Forms.CheckBox
    Friend WithEvents cbIntervalosNubosos As System.Windows.Forms.CheckBox
    Friend WithEvents cbNuboso As System.Windows.Forms.CheckBox
    Friend WithEvents cbDespejado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoDia As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents comboCurvas As System.Windows.Forms.ComboBox
    Friend WithEvents rbCuartoMenguante As System.Windows.Forms.CheckBox
    Friend WithEvents rbLunaLlena As System.Windows.Forms.CheckBox
    Friend WithEvents rbCuartoCreciente As System.Windows.Forms.CheckBox
    Friend WithEvents rbLunaNueva As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
