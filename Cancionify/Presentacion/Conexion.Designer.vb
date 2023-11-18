<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conexion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conexion))
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.lblConectar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(28, 386)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(75, 23)
        Me.btnRuta.TabIndex = 1
        Me.btnRuta.Text = "RUTA"
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(28, 415)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.Text = "CONECTAR"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(109, 387)
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(306, 23)
        Me.txtRuta.TabIndex = 3
        '
        'ofdRuta
        '
        Me.ofdRuta.FileName = "ofdRuta"
        '
        'lblConectar
        '
        Me.lblConectar.AutoSize = True
        Me.lblConectar.Location = New System.Drawing.Point(109, 419)
        Me.lblConectar.Name = "lblConectar"
        Me.lblConectar.Size = New System.Drawing.Size(0, 15)
        Me.lblConectar.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 69)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "MARÍA VICTORIA ALCÁZAR CLEMENTE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLARA SACEDÓN ORTEGA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo BC1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Conexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = Global.Cancionify.My.Resources.Resources.PORTADA
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblConectar)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnRuta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Conexion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONEXION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRuta As Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents odfRuta As OpenFileDialog
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents lblConectar As Label
    Friend WithEvents Label1 As Label
End Class
