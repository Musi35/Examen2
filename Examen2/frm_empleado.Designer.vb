<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empleado))
        Me.lbl_n1 = New System.Windows.Forms.Label()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.lbl_n4 = New System.Windows.Forms.Label()
        Me.lbl_n3 = New System.Windows.Forms.Label()
        Me.lbl_n5 = New System.Windows.Forms.Label()
        Me.lbl_n7 = New System.Windows.Forms.Label()
        Me.txt_idEmp = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_paterno = New System.Windows.Forms.TextBox()
        Me.txt_materno = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_idCuad = New System.Windows.Forms.TextBox()
        Me.btn_agg = New System.Windows.Forms.Button()
        Me.btn_actu = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.mnu_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Cuadrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Colonia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_n6 = New System.Windows.Forms.Label()
        Me.cbo_puesto = New System.Windows.Forms.ComboBox()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.lbl_n9 = New System.Windows.Forms.Label()
        Me.mni_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_n1
        '
        Me.lbl_n1.AutoSize = True
        Me.lbl_n1.Location = New System.Drawing.Point(21, 96)
        Me.lbl_n1.Name = "lbl_n1"
        Me.lbl_n1.Size = New System.Drawing.Size(243, 34)
        Me.lbl_n1.TabIndex = 0
        Me.lbl_n1.Text = "ID de Empleado"
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(21, 162)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(126, 34)
        Me.lbl_n2.TabIndex = 1
        Me.lbl_n2.Text = "Nombre"
        '
        'lbl_n4
        '
        Me.lbl_n4.AutoSize = True
        Me.lbl_n4.Location = New System.Drawing.Point(21, 314)
        Me.lbl_n4.Name = "lbl_n4"
        Me.lbl_n4.Size = New System.Drawing.Size(258, 34)
        Me.lbl_n4.TabIndex = 2
        Me.lbl_n4.Text = "Apellido materno"
        '
        'lbl_n3
        '
        Me.lbl_n3.AutoSize = True
        Me.lbl_n3.Location = New System.Drawing.Point(21, 238)
        Me.lbl_n3.Name = "lbl_n3"
        Me.lbl_n3.Size = New System.Drawing.Size(248, 34)
        Me.lbl_n3.TabIndex = 3
        Me.lbl_n3.Text = "Apellido paterno"
        '
        'lbl_n5
        '
        Me.lbl_n5.AutoSize = True
        Me.lbl_n5.Location = New System.Drawing.Point(620, 104)
        Me.lbl_n5.Name = "lbl_n5"
        Me.lbl_n5.Size = New System.Drawing.Size(134, 34)
        Me.lbl_n5.TabIndex = 4
        Me.lbl_n5.Text = "Teléfono"
        '
        'lbl_n7
        '
        Me.lbl_n7.AutoSize = True
        Me.lbl_n7.Location = New System.Drawing.Point(620, 250)
        Me.lbl_n7.Name = "lbl_n7"
        Me.lbl_n7.Size = New System.Drawing.Size(232, 34)
        Me.lbl_n7.TabIndex = 5
        Me.lbl_n7.Text = "ID de Cuadrilla"
        '
        'txt_idEmp
        '
        Me.txt_idEmp.Location = New System.Drawing.Point(295, 96)
        Me.txt_idEmp.MaxLength = 10
        Me.txt_idEmp.Name = "txt_idEmp"
        Me.txt_idEmp.Size = New System.Drawing.Size(286, 42)
        Me.txt_idEmp.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(295, 165)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(286, 42)
        Me.txt_nombre.TabIndex = 8
        '
        'txt_paterno
        '
        Me.txt_paterno.Location = New System.Drawing.Point(295, 241)
        Me.txt_paterno.MaxLength = 50
        Me.txt_paterno.Name = "txt_paterno"
        Me.txt_paterno.Size = New System.Drawing.Size(286, 42)
        Me.txt_paterno.TabIndex = 9
        '
        'txt_materno
        '
        Me.txt_materno.Location = New System.Drawing.Point(295, 317)
        Me.txt_materno.MaxLength = 50
        Me.txt_materno.Name = "txt_materno"
        Me.txt_materno.Size = New System.Drawing.Size(286, 42)
        Me.txt_materno.TabIndex = 10
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(862, 104)
        Me.txt_telefono.MaxLength = 10
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(286, 42)
        Me.txt_telefono.TabIndex = 11
        '
        'txt_idCuad
        '
        Me.txt_idCuad.Location = New System.Drawing.Point(862, 250)
        Me.txt_idCuad.MaxLength = 10
        Me.txt_idCuad.Name = "txt_idCuad"
        Me.txt_idCuad.Size = New System.Drawing.Size(286, 42)
        Me.txt_idCuad.TabIndex = 12
        '
        'btn_agg
        '
        Me.btn_agg.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agg.Location = New System.Drawing.Point(63, 405)
        Me.btn_agg.Name = "btn_agg"
        Me.btn_agg.Size = New System.Drawing.Size(174, 57)
        Me.btn_agg.TabIndex = 14
        Me.btn_agg.Text = "Agregar"
        Me.btn_agg.UseVisualStyleBackColor = False
        '
        'btn_actu
        '
        Me.btn_actu.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actu.Location = New System.Drawing.Point(327, 405)
        Me.btn_actu.Name = "btn_actu"
        Me.btn_actu.Size = New System.Drawing.Size(174, 57)
        Me.btn_actu.TabIndex = 15
        Me.btn_actu.Text = "Actualizar"
        Me.btn_actu.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Location = New System.Drawing.Point(619, 405)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(174, 57)
        Me.btn_del.TabIndex = 16
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Location = New System.Drawing.Point(923, 405)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(174, 57)
        Me.btn_buscar.TabIndex = 17
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'mnu_menu
        '
        Me.mnu_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.mnu_menu.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_menu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnu_menu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_Empleado, Me.mni_Cuadrilla, Me.mni_Colonia, Me.mni_Actividad, Me.mni_Consulta, Me.mni_Salir})
        Me.mnu_menu.Location = New System.Drawing.Point(0, 0)
        Me.mnu_menu.Name = "mnu_menu"
        Me.mnu_menu.Size = New System.Drawing.Size(1207, 42)
        Me.mnu_menu.TabIndex = 18
        '
        'mni_Empleado
        '
        Me.mni_Empleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Empleado.Name = "mni_Empleado"
        Me.mni_Empleado.Size = New System.Drawing.Size(170, 38)
        Me.mni_Empleado.Text = "Empleado"
        '
        'mni_Cuadrilla
        '
        Me.mni_Cuadrilla.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Cuadrilla.Name = "mni_Cuadrilla"
        Me.mni_Cuadrilla.Size = New System.Drawing.Size(159, 38)
        Me.mni_Cuadrilla.Text = "Cuadrilla"
        '
        'mni_Colonia
        '
        Me.mni_Colonia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Colonia.Name = "mni_Colonia"
        Me.mni_Colonia.Size = New System.Drawing.Size(138, 38)
        Me.mni_Colonia.Text = "Colonia"
        '
        'mni_Actividad
        '
        Me.mni_Actividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Actividad.Name = "mni_Actividad"
        Me.mni_Actividad.Size = New System.Drawing.Size(162, 38)
        Me.mni_Actividad.Text = "Actividad"
        '
        'mni_Consulta
        '
        Me.mni_Consulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Consulta.Name = "mni_Consulta"
        Me.mni_Consulta.Size = New System.Drawing.Size(338, 38)
        Me.mni_Consulta.Text = "Consulta de Cuadrilla"
        '
        'lbl_n6
        '
        Me.lbl_n6.AutoSize = True
        Me.lbl_n6.Location = New System.Drawing.Point(620, 173)
        Me.lbl_n6.Name = "lbl_n6"
        Me.lbl_n6.Size = New System.Drawing.Size(110, 34)
        Me.lbl_n6.TabIndex = 19
        Me.lbl_n6.Text = "Puesto"
        '
        'cbo_puesto
        '
        Me.cbo_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_puesto.FormattingEnabled = True
        Me.cbo_puesto.Items.AddRange(New Object() {"Jefe de Cuadrilla", "Gerente", "Empleado"})
        Me.cbo_puesto.Location = New System.Drawing.Point(862, 170)
        Me.cbo_puesto.Name = "cbo_puesto"
        Me.cbo_puesto.Size = New System.Drawing.Size(286, 42)
        Me.cbo_puesto.TabIndex = 20
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(862, 320)
        Me.txt_contra.MaxLength = 20
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(286, 42)
        Me.txt_contra.TabIndex = 22
        Me.txt_contra.UseSystemPasswordChar = True
        '
        'lbl_n9
        '
        Me.lbl_n9.AutoSize = True
        Me.lbl_n9.Location = New System.Drawing.Point(620, 320)
        Me.lbl_n9.Name = "lbl_n9"
        Me.lbl_n9.Size = New System.Drawing.Size(177, 34)
        Me.lbl_n9.TabIndex = 21
        Me.lbl_n9.Text = "Contraseña"
        '
        'mni_Salir
        '
        Me.mni_Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Salir.Name = "mni_Salir"
        Me.mni_Salir.Size = New System.Drawing.Size(97, 38)
        Me.mni_Salir.Text = "Salir"
        '
        'frm_empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1207, 506)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.lbl_n9)
        Me.Controls.Add(Me.cbo_puesto)
        Me.Controls.Add(Me.lbl_n6)
        Me.Controls.Add(Me.mnu_menu)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_actu)
        Me.Controls.Add(Me.btn_agg)
        Me.Controls.Add(Me.txt_idCuad)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_materno)
        Me.Controls.Add(Me.txt_paterno)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_idEmp)
        Me.Controls.Add(Me.lbl_n7)
        Me.Controls.Add(Me.lbl_n5)
        Me.Controls.Add(Me.lbl_n3)
        Me.Controls.Add(Me.lbl_n4)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.lbl_n1)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_empleado"
        Me.Text = "Empleado"
        Me.mnu_menu.ResumeLayout(False)
        Me.mnu_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_n1 As Label
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents lbl_n4 As Label
    Friend WithEvents lbl_n3 As Label
    Friend WithEvents lbl_n5 As Label
    Friend WithEvents lbl_n7 As Label
    Friend WithEvents txt_idEmp As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_paterno As TextBox
    Friend WithEvents txt_materno As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_idCuad As TextBox
    Friend WithEvents btn_agg As Button
    Friend WithEvents btn_actu As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents mnu_menu As MenuStrip
    Friend WithEvents mni_Empleado As ToolStripMenuItem
    Friend WithEvents mni_Cuadrilla As ToolStripMenuItem
    Friend WithEvents mni_Colonia As ToolStripMenuItem
    Friend WithEvents mni_Actividad As ToolStripMenuItem
    Friend WithEvents lbl_n6 As Label
    Friend WithEvents cbo_puesto As ComboBox
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents lbl_n9 As Label
    Friend WithEvents mni_Consulta As ToolStripMenuItem
    Friend WithEvents mni_Salir As ToolStripMenuItem
End Class
