<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_n1 = New System.Windows.Forms.Label()
        Me.lbl_n2 = New System.Windows.Forms.Label()
        Me.lbl_n3 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_contra = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_n1
        '
        Me.lbl_n1.AutoSize = True
        Me.lbl_n1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_n1.Location = New System.Drawing.Point(213, 48)
        Me.lbl_n1.Name = "lbl_n1"
        Me.lbl_n1.Size = New System.Drawing.Size(128, 48)
        Me.lbl_n1.TabIndex = 0
        Me.lbl_n1.Text = "Login"
        '
        'lbl_n2
        '
        Me.lbl_n2.AutoSize = True
        Me.lbl_n2.Location = New System.Drawing.Point(60, 160)
        Me.lbl_n2.Name = "lbl_n2"
        Me.lbl_n2.Size = New System.Drawing.Size(243, 34)
        Me.lbl_n2.TabIndex = 1
        Me.lbl_n2.Text = "ID de Empleado"
        '
        'lbl_n3
        '
        Me.lbl_n3.AutoSize = True
        Me.lbl_n3.Location = New System.Drawing.Point(60, 256)
        Me.lbl_n3.Name = "lbl_n3"
        Me.lbl_n3.Size = New System.Drawing.Size(177, 34)
        Me.lbl_n3.TabIndex = 2
        Me.lbl_n3.Text = "Contraseña"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(309, 160)
        Me.txt_user.MaxLength = 10
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(232, 42)
        Me.txt_user.TabIndex = 3
        '
        'txt_contra
        '
        Me.txt_contra.Location = New System.Drawing.Point(309, 253)
        Me.txt_contra.MaxLength = 20
        Me.txt_contra.Name = "txt_contra"
        Me.txt_contra.Size = New System.Drawing.Size(232, 42)
        Me.txt_contra.TabIndex = 4
        Me.txt_contra.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrar.Location = New System.Drawing.Point(204, 352)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(164, 63)
        Me.btn_entrar.TabIndex = 5
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'btn_ver
        '
        Me.btn_ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_ver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btn_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ver.Location = New System.Drawing.Point(560, 253)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(72, 46)
        Me.btn_ver.TabIndex = 6
        Me.btn_ver.Text = "Ver"
        Me.btn_ver.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 451)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_contra)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_n3)
        Me.Controls.Add(Me.lbl_n2)
        Me.Controls.Add(Me.lbl_n1)
        Me.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_n1 As Label
    Friend WithEvents lbl_n2 As Label
    Friend WithEvents lbl_n3 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_contra As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents btn_ver As Button
End Class
