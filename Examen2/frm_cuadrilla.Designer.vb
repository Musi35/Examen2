<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cuadrilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cuadrilla))
        Me.mnu_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Cuadrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Colonia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_n1 = New System.Windows.Forms.Label()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_agg = New System.Windows.Forms.Button()
        Me.btn_actu = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.mni_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_menu.SuspendLayout()
        Me.SuspendLayout()
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
        Me.mnu_menu.Size = New System.Drawing.Size(1098, 42)
        Me.mnu_menu.TabIndex = 23
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
        Me.mni_Consulta.Size = New System.Drawing.Size(353, 38)
        Me.mni_Consulta.Text = "Consulta de Cuadrillas"
        '
        'lbl_n1
        '
        Me.lbl_n1.AutoSize = True
        Me.lbl_n1.Location = New System.Drawing.Point(232, 95)
        Me.lbl_n1.Name = "lbl_n1"
        Me.lbl_n1.Size = New System.Drawing.Size(232, 34)
        Me.lbl_n1.TabIndex = 24
        Me.lbl_n1.Text = "ID de Cuadrilla"
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(232, 206)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(126, 34)
        Me.lbl_n2.TabIndex = 25
        Me.lbl_n2.Text = "Nombre"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(497, 95)
        Me.txt_id.MaxLength = 10
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(239, 42)
        Me.txt_id.TabIndex = 26
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(497, 206)
        Me.txt_nombre.MaxLength = 50
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(239, 42)
        Me.txt_nombre.TabIndex = 27
        '
        'btn_agg
        '
        Me.btn_agg.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_agg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agg.Location = New System.Drawing.Point(100, 283)
        Me.btn_agg.Name = "btn_agg"
        Me.btn_agg.Size = New System.Drawing.Size(174, 57)
        Me.btn_agg.TabIndex = 19
        Me.btn_agg.Text = "Agregar"
        Me.btn_agg.UseVisualStyleBackColor = False
        '
        'btn_actu
        '
        Me.btn_actu.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_actu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actu.Location = New System.Drawing.Point(313, 283)
        Me.btn_actu.Name = "btn_actu"
        Me.btn_actu.Size = New System.Drawing.Size(174, 57)
        Me.btn_actu.TabIndex = 20
        Me.btn_actu.Text = "Actualizar"
        Me.btn_actu.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Location = New System.Drawing.Point(537, 283)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(174, 57)
        Me.btn_del.TabIndex = 21
        Me.btn_del.Text = "Eliminar"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Location = New System.Drawing.Point(752, 283)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(174, 57)
        Me.btn_buscar.TabIndex = 22
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'mni_Salir
        '
        Me.mni_Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Salir.Name = "mni_Salir"
        Me.mni_Salir.Size = New System.Drawing.Size(97, 38)
        Me.mni_Salir.Text = "Salir"
        '
        'frm_cuadrilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 367)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.lbl_n1)
        Me.Controls.Add(Me.mnu_menu)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_actu)
        Me.Controls.Add(Me.btn_agg)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_cuadrilla"
        Me.Text = "Cuadrilla"
        Me.mnu_menu.ResumeLayout(False)
        Me.mnu_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_menu As MenuStrip
    Friend WithEvents mni_Empleado As ToolStripMenuItem
    Friend WithEvents mni_Cuadrilla As ToolStripMenuItem
    Friend WithEvents mni_Colonia As ToolStripMenuItem
    Friend WithEvents mni_Actividad As ToolStripMenuItem
    Friend WithEvents lbl_n1 As Label
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_agg As Button
    Friend WithEvents btn_actu As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_buscar As Button
    Friend WithEvents mni_Consulta As ToolStripMenuItem
    Friend WithEvents mni_Salir As ToolStripMenuItem
End Class
