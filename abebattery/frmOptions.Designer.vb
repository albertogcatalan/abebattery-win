<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.minimizarCerrar = New System.Windows.Forms.CheckBox()
        Me.minimizarIcon = New System.Windows.Forms.CheckBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.selectorTime = New System.Windows.Forms.ComboBox()
        Me.labeltime = New System.Windows.Forms.Label()
        Me.checkNotifi2 = New System.Windows.Forms.CheckBox()
        Me.checkNotifi1 = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkStart = New System.Windows.Forms.CheckBox()
        Me.selectorIdioma = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(316, 136)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(308, 110)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "General"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.minimizarCerrar)
        Me.GroupBox2.Controls.Add(Me.minimizarIcon)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 104)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Iniciar con Windows"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'minimizarCerrar
        '
        Me.minimizarCerrar.AutoSize = True
        Me.minimizarCerrar.Location = New System.Drawing.Point(15, 65)
        Me.minimizarCerrar.Name = "minimizarCerrar"
        Me.minimizarCerrar.Size = New System.Drawing.Size(221, 17)
        Me.minimizarCerrar.TabIndex = 2
        Me.minimizarCerrar.Text = "Minimizar el programa al cerrar la ventana"
        Me.minimizarCerrar.UseVisualStyleBackColor = True
        '
        'minimizarIcon
        '
        Me.minimizarIcon.AutoSize = True
        Me.minimizarIcon.Location = New System.Drawing.Point(15, 42)
        Me.minimizarIcon.Name = "minimizarIcon"
        Me.minimizarIcon.Size = New System.Drawing.Size(249, 17)
        Me.minimizarIcon.TabIndex = 1
        Me.minimizarIcon.Text = "Minimizar el programa en la bandeja del sistema"
        Me.minimizarIcon.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(308, 110)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Notificaciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.selectorTime)
        Me.GroupBox3.Controls.Add(Me.labeltime)
        Me.GroupBox3.Controls.Add(Me.checkNotifi2)
        Me.GroupBox3.Controls.Add(Me.checkNotifi1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 104)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'selectorTime
        '
        Me.selectorTime.FormattingEnabled = True
        Me.selectorTime.Items.AddRange(New Object() {"2s", "5s", "10s", "2m", "5m"})
        Me.selectorTime.Location = New System.Drawing.Point(154, 65)
        Me.selectorTime.Name = "selectorTime"
        Me.selectorTime.Size = New System.Drawing.Size(63, 21)
        Me.selectorTime.TabIndex = 3
        '
        'labeltime
        '
        Me.labeltime.AutoSize = True
        Me.labeltime.Location = New System.Drawing.Point(12, 68)
        Me.labeltime.Name = "labeltime"
        Me.labeltime.Size = New System.Drawing.Size(136, 13)
        Me.labeltime.TabIndex = 2
        Me.labeltime.Text = "Duración de la notificación:"
        '
        'checkNotifi2
        '
        Me.checkNotifi2.AutoSize = True
        Me.checkNotifi2.Location = New System.Drawing.Point(15, 42)
        Me.checkNotifi2.Name = "checkNotifi2"
        Me.checkNotifi2.Size = New System.Drawing.Size(212, 17)
        Me.checkNotifi2.TabIndex = 1
        Me.checkNotifi2.Text = "Notificarme cuando la carga sea crítica"
        Me.checkNotifi2.UseVisualStyleBackColor = True
        '
        'checkNotifi1
        '
        Me.checkNotifi1.AutoSize = True
        Me.checkNotifi1.Location = New System.Drawing.Point(15, 19)
        Me.checkNotifi1.Name = "checkNotifi1"
        Me.checkNotifi1.Size = New System.Drawing.Size(202, 17)
        Me.checkNotifi1.TabIndex = 0
        Me.checkNotifi1.Text = "Notificarme cuando la carga sea baja"
        Me.checkNotifi1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(308, 110)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Idioma"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkStart)
        Me.GroupBox1.Controls.Add(Me.selectorIdioma)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'checkStart
        '
        Me.checkStart.AutoSize = True
        Me.checkStart.Location = New System.Drawing.Point(18, 51)
        Me.checkStart.Name = "checkStart"
        Me.checkStart.Size = New System.Drawing.Size(230, 30)
        Me.checkStart.TabIndex = 2
        Me.checkStart.Text = "Detectar automáticamente al inicio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(solo se aplicarán los lenguajes soportados)" & _
            ""
        Me.checkStart.UseVisualStyleBackColor = True
        '
        'selectorIdioma
        '
        Me.selectorIdioma.FormattingEnabled = True
        Me.selectorIdioma.Items.AddRange(New Object() {"Español", "English"})
        Me.selectorIdioma.Location = New System.Drawing.Point(138, 24)
        Me.selectorIdioma.Name = "selectorIdioma"
        Me.selectorIdioma.Size = New System.Drawing.Size(121, 21)
        Me.selectorIdioma.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el lenguaje:"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 194)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents selectorTime As System.Windows.Forms.ComboBox
    Friend WithEvents labeltime As System.Windows.Forms.Label
    Friend WithEvents checkNotifi2 As System.Windows.Forms.CheckBox
    Friend WithEvents checkNotifi1 As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkStart As System.Windows.Forms.CheckBox
    Friend WithEvents selectorIdioma As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents minimizarCerrar As System.Windows.Forms.CheckBox
    Friend WithEvents minimizarIcon As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
