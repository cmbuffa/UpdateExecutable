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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.cmdiniciar = New System.Windows.Forms.Button()
        Me.lblprogreso = New System.Windows.Forms.Label()
        Me.cmdactualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 101)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(268, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'cmdiniciar
        '
        Me.cmdiniciar.Enabled = False
        Me.cmdiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdiniciar.Image = Global.updatewincaja.My.Resources.Resources.wincaja
        Me.cmdiniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdiniciar.Location = New System.Drawing.Point(195, 130)
        Me.cmdiniciar.Name = "cmdiniciar"
        Me.cmdiniciar.Size = New System.Drawing.Size(87, 75)
        Me.cmdiniciar.TabIndex = 2
        Me.cmdiniciar.Text = "Iniciar WinConta"
        Me.cmdiniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdiniciar.UseVisualStyleBackColor = True
        '
        'lblprogreso
        '
        Me.lblprogreso.AutoSize = True
        Me.lblprogreso.Location = New System.Drawing.Point(9, 85)
        Me.lblprogreso.Name = "lblprogreso"
        Me.lblprogreso.Size = New System.Drawing.Size(49, 13)
        Me.lblprogreso.TabIndex = 8
        Me.lblprogreso.Text = "Progreso"
        '
        'cmdactualizar
        '
        Me.cmdactualizar.Enabled = False
        Me.cmdactualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdactualizar.Image = CType(resources.GetObject("cmdactualizar.Image"), System.Drawing.Image)
        Me.cmdactualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdactualizar.Location = New System.Drawing.Point(14, 130)
        Me.cmdactualizar.Name = "cmdactualizar"
        Me.cmdactualizar.Size = New System.Drawing.Size(87, 75)
        Me.cmdactualizar.TabIndex = 9
        Me.cmdactualizar.Text = "Actualizar Sistema"
        Me.cmdactualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdactualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 76)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 211)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdactualizar)
        Me.Controls.Add(Me.lblprogreso)
        Me.Controls.Add(Me.cmdiniciar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update +WinConta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdiniciar As System.Windows.Forms.Button
    Friend WithEvents lblprogreso As System.Windows.Forms.Label
    Friend WithEvents cmdactualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
