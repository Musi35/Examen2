<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_consulta))
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_n1 = New System.Windows.Forms.Label()
        Me.dgv_tabla = New System.Windows.Forms.DataGridView()
        Me.mnu_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Cuadrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Colonia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Consulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Salir = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv_tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.btn_buscar.Location = New System.Drawing.Point(700, 80)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(141, 63)
        Me.btn_buscar.TabIndex = 0
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(467, 94)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(170, 42)
        Me.txt_id.TabIndex = 1
        '
        'lbl_n1
        '
        Me.lbl_n1.AutoSize = True
        Me.lbl_n1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lbl_n1.Location = New System.Drawing.Point(292, 94)
        Me.lbl_n1.Name = "lbl_n1"
        Me.lbl_n1.Size = New System.Drawing.Size(111, 34)
        Me.lbl_n1.TabIndex = 2
        Me.lbl_n1.Text = "Buscar"
        '
        'dgv_tabla
        '
        Me.dgv_tabla.AllowUserToAddRows = False
        Me.dgv_tabla.AllowUserToDeleteRows = False
        Me.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabla.Location = New System.Drawing.Point(286, 179)
        Me.dgv_tabla.Name = "dgv_tabla"
        Me.dgv_tabla.ReadOnly = True
        Me.dgv_tabla.RowHeadersWidth = 62
        Me.dgv_tabla.RowTemplate.Height = 28
        Me.dgv_tabla.Size = New System.Drawing.Size(555, 191)
        Me.dgv_tabla.TabIndex = 3
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
        Me.mnu_menu.Size = New System.Drawing.Size(1099, 42)
        Me.mnu_menu.TabIndex = 29
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
        'mni_Salir
        '
        Me.mni_Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Salir.Name = "mni_Salir"
        Me.mni_Salir.Size = New System.Drawing.Size(97, 38)
        Me.mni_Salir.Text = "Salir"
        '
        'frm_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1099, 474)
        Me.Controls.Add(Me.mnu_menu)
        Me.Controls.Add(Me.dgv_tabla)
        Me.Controls.Add(Me.lbl_n1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_buscar)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_consulta"
        Me.Text = "Consulta de Cuadrillas"
        CType(Me.dgv_tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_menu.ResumeLayout(False)
        Me.mnu_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_n1 As Label
    Friend WithEvents dgv_tabla As DataGridView
    Friend WithEvents mnu_menu As MenuStrip
    Friend WithEvents mni_Empleado As ToolStripMenuItem
    Friend WithEvents mni_Cuadrilla As ToolStripMenuItem
    Friend WithEvents mni_Colonia As ToolStripMenuItem
    Friend WithEvents mni_Actividad As ToolStripMenuItem
    Friend WithEvents mni_Consulta As ToolStripMenuItem
    Friend WithEvents mni_Salir As ToolStripMenuItem
End Class
