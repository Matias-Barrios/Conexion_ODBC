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
        Me.dgvDocentes = New System.Windows.Forms.DataGridView()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDocentes
        '
        Me.dgvDocentes.AllowUserToAddRows = False
        Me.dgvDocentes.AllowUserToDeleteRows = False
        Me.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocentes.Location = New System.Drawing.Point(12, 333)
        Me.dgvDocentes.Name = "dgvDocentes"
        Me.dgvDocentes.ReadOnly = True
        Me.dgvDocentes.Size = New System.Drawing.Size(869, 208)
        Me.dgvDocentes.TabIndex = 0
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AllowUserToAddRows = False
        Me.dgvGrupos.AllowUserToDeleteRows = False
        Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrupos.Location = New System.Drawing.Point(12, 34)
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.ReadOnly = True
        Me.dgvGrupos.Size = New System.Drawing.Size(869, 277)
        Me.dgvGrupos.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 561)
        Me.Controls.Add(Me.dgvGrupos)
        Me.Controls.Add(Me.dgvDocentes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDocentes As DataGridView
    Friend WithEvents dgvGrupos As DataGridView
End Class
