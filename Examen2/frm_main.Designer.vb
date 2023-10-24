<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.lbl_tit = New System.Windows.Forms.Label()
        Me.mnu_menu = New System.Windows.Forms.MenuStrip()
        Me.mni_Empleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Cuadrilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Colonia = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Actividad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Consultas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mni_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_tit
        '
        Me.lbl_tit.AutoSize = True
        Me.lbl_tit.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.lbl_tit.Location = New System.Drawing.Point(340, 265)
        Me.lbl_tit.Name = "lbl_tit"
        Me.lbl_tit.Size = New System.Drawing.Size(324, 59)
        Me.lbl_tit.TabIndex = 0
        Me.lbl_tit.Text = "Bienvenido"
        '
        'mnu_menu
        '
        Me.mnu_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.mnu_menu.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_menu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnu_menu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mni_Empleado, Me.mni_Cuadrilla, Me.mni_Colonia, Me.mni_Actividad, Me.mni_Consultas, Me.mni_Salir})
        Me.mnu_menu.Location = New System.Drawing.Point(0, 0)
        Me.mnu_menu.Name = "mnu_menu"
        Me.mnu_menu.Size = New System.Drawing.Size(1096, 42)
        Me.mnu_menu.TabIndex = 3
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
        'mni_Consultas
        '
        Me.mni_Consultas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Consultas.Name = "mni_Consultas"
        Me.mni_Consultas.Size = New System.Drawing.Size(353, 38)
        Me.mni_Consultas.Text = "Consulta de Cuadrillas"
        '
        'mni_Salir
        '
        Me.mni_Salir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.mni_Salir.Name = "mni_Salir"
        Me.mni_Salir.Size = New System.Drawing.Size(97, 38)
        Me.mni_Salir.Text = "Salir"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1096, 602)
        Me.Controls.Add(Me.mnu_menu)
        Me.Controls.Add(Me.lbl_tit)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_menu
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_main"
        Me.Text = "Bienvenido"
        Me.mnu_menu.ResumeLayout(False)
        Me.mnu_menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tit As Label
    Friend WithEvents mnu_menu As MenuStrip
    Friend WithEvents mni_Empleado As ToolStripMenuItem
    Friend WithEvents mni_Cuadrilla As ToolStripMenuItem
    Friend WithEvents mni_Colonia As ToolStripMenuItem
    Friend WithEvents mni_Actividad As ToolStripMenuItem
    Friend WithEvents mni_Consultas As ToolStripMenuItem
    Friend WithEvents mni_Salir As ToolStripMenuItem
End Class
