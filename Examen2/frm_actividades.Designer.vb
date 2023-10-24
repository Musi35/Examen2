<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_actividades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_actividades))
        Me.txt_idCuad = New System.Windows.Forms.TextBox()
        Me.lbl_n5 = New System.Windows.Forms.Label()
        Me.lbl_n1 = New System.Windows.Forms.Label()
        Me.mnu_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Cuadrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Colonia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_n3 = New System.Windows.Forms.Label()
        Me.txt_idAct = New System.Windows.Forms.TextBox()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.txt_fot = New System.Windows.Forms.TextBox()
        Me.txt_idCol = New System.Windows.Forms.TextBox()
        Me.lbl_n4 = New System.Windows.Forms.Label()
        Me.rtb_detalle = New System.Windows.Forms.RichTextBox()
        Me.btn_img = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_actu = New System.Windows.Forms.Button()
        Me.btn_agg = New System.Windows.Forms.Button()
        Me.pcb_foto = New System.Windows.Forms.PictureBox()
        Me.mni_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_menu.SuspendLayout()
        CType(Me.pcb_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_idCuad
        '
        Me.txt_idCuad.Location = New System.Drawing.Point(329, 181)
        Me.txt_idCuad.MaxLength = 5
        Me.txt_idCuad.Name = "txt_idCuad"
        Me.txt_idCuad.Size = New System.Drawing.Size(239, 42)
        Me.txt_idCuad.TabIndex = 36
        '
        'lbl_n5
        '
        Me.lbl_n5.AutoSize = True
        Me.lbl_n5.Location = New System.Drawing.Point(601, 115)
        Me.lbl_n5.Name = "lbl_n5"
        Me.lbl_n5.Size = New System.Drawing.Size(117, 34)
        Me.lbl_n5.TabIndex = 34
        Me.lbl_n5.Text = "Detalle"
        '
        'lbl_n1
        '
        Me.lbl_n1.AutoSize = True
        Me.lbl_n1.Location = New System.Drawing.Point(22, 112)
        Me.lbl_n1.Name = "lbl_n1"
        Me.lbl_n1.Size = New System.Drawing.Size(233, 34)
        Me.lbl_n1.TabIndex = 33
        Me.lbl_n1.Text = "ID de actividad"
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
        Me.mnu_menu.Size = New System.Drawing.Size(1227, 42)
        Me.mnu_menu.TabIndex = 32
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
        Me.mni_Consulta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Consulta.Name = "mni_Consulta"
        Me.mni_Consulta.Size = New System.Drawing.Size(353, 38)
        Me.mni_Consulta.Text = "Consulta de Cuadrillas"
        '
        'lbl_n3
        '
        Me.lbl_n3.AutoSize = True
        Me.lbl_n3.Location = New System.Drawing.Point(23, 255)
        Me.lbl_n3.Name = "lbl_n3"
        Me.lbl_n3.Size = New System.Drawing.Size(75, 34)
        Me.lbl_n3.TabIndex = 37
        Me.lbl_n3.Text = "Foto"
        '
        'txt_idAct
        '
        Me.txt_idAct.Location = New System.Drawing.Point(329, 112)
        Me.txt_idAct.MaxLength = 10
        Me.txt_idAct.Name = "txt_idAct"
        Me.txt_idAct.Size = New System.Drawing.Size(240, 42)
        Me.txt_idAct.TabIndex = 35
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(23, 189)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(227, 34)
        Me.lbl_n2.TabIndex = 38
        Me.lbl_n2.Text = "ID de cuadrilla"
        '
        'txt_fot
        '
        Me.txt_fot.Enabled = False
        Me.txt_fot.Location = New System.Drawing.Point(330, 255)
        Me.txt_fot.Name = "txt_fot"
        Me.txt_fot.Size = New System.Drawing.Size(239, 42)
        Me.txt_fot.TabIndex = 51
        '
        'txt_idCol
        '
        Me.txt_idCol.Location = New System.Drawing.Point(329, 322)
        Me.txt_idCol.MaxLength = 10
        Me.txt_idCol.Name = "txt_idCol"
        Me.txt_idCol.Size = New System.Drawing.Size(239, 42)
        Me.txt_idCol.TabIndex = 38
        '
        'lbl_n4
        '
        Me.lbl_n4.AutoSize = True
        Me.lbl_n4.Location = New System.Drawing.Point(22, 322)
        Me.lbl_n4.Name = "lbl_n4"
        Me.lbl_n4.Size = New System.Drawing.Size(162, 34)
        Me.lbl_n4.TabIndex = 41
        Me.lbl_n4.Text = "ID colonia"
        '
        'rtb_detalle
        '
        Me.rtb_detalle.Location = New System.Drawing.Point(753, 112)
        Me.rtb_detalle.MaxLength = 500
        Me.rtb_detalle.Name = "rtb_detalle"
        Me.rtb_detalle.Size = New System.Drawing.Size(446, 180)
        Me.rtb_detalle.TabIndex = 39
        Me.rtb_detalle.Text = ""
        '
        'btn_img
        '
        Me.btn_img.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_img.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_img.Location = New System.Drawing.Point(587, 255)
        Me.btn_img.Name = "btn_img"
        Me.btn_img.Size = New System.Drawing.Size(61, 42)
        Me.btn_img.TabIndex = 37
        Me.btn_img.Text = "..."
        Me.btn_img.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Location = New System.Drawing.Point(706, 416)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(174, 57)
        Me.btn_buscar.TabIndex = 48
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Location = New System.Drawing.Point(474, 416)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(174, 57)
        Me.btn_del.TabIndex = 47
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_actu
        '
        Me.btn_actu.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actu.Location = New System.Drawing.Point(259, 416)
        Me.btn_actu.Name = "btn_actu"
        Me.btn_actu.Size = New System.Drawing.Size(174, 57)
        Me.btn_actu.TabIndex = 46
        Me.btn_actu.Text = "Actualizar"
        Me.btn_actu.UseVisualStyleBackColor = False
        '
        'btn_agg
        '
        Me.btn_agg.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agg.Location = New System.Drawing.Point(29, 416)
        Me.btn_agg.Name = "btn_agg"
        Me.btn_agg.Size = New System.Drawing.Size(174, 57)
        Me.btn_agg.TabIndex = 45
        Me.btn_agg.Text = "Agregar"
        Me.btn_agg.UseVisualStyleBackColor = False
        '
        'pcb_foto
        '
        Me.pcb_foto.Location = New System.Drawing.Point(963, 322)
        Me.pcb_foto.Name = "pcb_foto"
        Me.pcb_foto.Size = New System.Drawing.Size(196, 170)
        Me.pcb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb_foto.TabIndex = 49
        Me.pcb_foto.TabStop = False
        '
        'mni_Salir
        '
        Me.mni_Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Salir.Name = "mni_Salir"
        Me.mni_Salir.Size = New System.Drawing.Size(97, 38)
        Me.mni_Salir.Text = "Salir"
        '
        'frm_actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1227, 534)
        Me.Controls.Add(Me.pcb_foto)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_actu)
        Me.Controls.Add(Me.btn_agg)
        Me.Controls.Add(Me.btn_img)
        Me.Controls.Add(Me.rtb_detalle)
        Me.Controls.Add(Me.txt_idCol)
        Me.Controls.Add(Me.lbl_n4)
        Me.Controls.Add(Me.txt_fot)
        Me.Controls.Add(Me.txt_idAct)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.lbl_n3)
        Me.Controls.Add(Me.txt_idCuad)
        Me.Controls.Add(Me.lbl_n5)
        Me.Controls.Add(Me.lbl_n1)
        Me.Controls.Add(Me.mnu_menu)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_actividades"
        Me.Text = "Actividades"
        Me.mnu_menu.ResumeLayout(False)
        Me.mnu_menu.PerformLayout()
        CType(Me.pcb_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_idCuad As TextBox
    Friend WithEvents lbl_n5 As Label
    Friend WithEvents lbl_n1 As Label
    Friend WithEvents mnu_menu As MenuStrip
    Friend WithEvents mni_Empleado As ToolStripMenuItem
    Friend WithEvents mni_Cuadrilla As ToolStripMenuItem
    Friend WithEvents mni_Colonia As ToolStripMenuItem
    Friend WithEvents mni_Actividad As ToolStripMenuItem
    Friend WithEvents lbl_n3 As Label
    Friend WithEvents txt_idAct As TextBox
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents txt_fot As TextBox
    Friend WithEvents txt_idCol As TextBox
    Friend WithEvents lbl_n4 As Label
    Friend WithEvents rtb_detalle As RichTextBox
    Friend WithEvents btn_img As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_actu As Button
    Friend WithEvents btn_agg As Button
    Friend WithEvents pcb_foto As PictureBox
    Friend WithEvents mni_Consulta As ToolStripMenuItem
    Friend WithEvents mni_Salir As ToolStripMenuItem
End Class
