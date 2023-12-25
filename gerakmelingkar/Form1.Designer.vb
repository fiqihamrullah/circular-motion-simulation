<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblPerSentripental = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblW = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtRadius = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnStartAnimation = New System.Windows.Forms.Button
        Me.txtFrekuensi = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPeriode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.pbAnimation = New System.Windows.Forms.PictureBox
        Me.dgvdat = New System.Windows.Forms.DataGridView
        Me.colwaktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSudut = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblV = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Honeydew
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 547)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lblV)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.lblPerSentripental)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.lblW)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(12, 254)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(276, 283)
        Me.Panel4.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(208, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "rad/s2"
        '
        'lblPerSentripental
        '
        Me.lblPerSentripental.AutoSize = True
        Me.lblPerSentripental.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerSentripental.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPerSentripental.Location = New System.Drawing.Point(165, 129)
        Me.lblPerSentripental.Name = "lblPerSentripental"
        Me.lblPerSentripental.Size = New System.Drawing.Size(18, 22)
        Me.lblPerSentripental.TabIndex = 1
        Me.lblPerSentripental.Text = "0"
        Me.lblPerSentripental.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "rad/s"
        '
        'lblW
        '
        Me.lblW.AutoSize = True
        Me.lblW.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblW.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblW.Location = New System.Drawing.Point(167, 71)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(18, 22)
        Me.lblW.TabIndex = 1
        Me.lblW.Text = "0"
        Me.lblW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(11, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Percepatan Sentripental (w/s2) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(11, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kecepatan Sudut (w) :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtRadius)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnStartAnimation)
        Me.Panel3.Controls.Add(Me.txtFrekuensi)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtPeriode)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(13, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 232)
        Me.Panel3.TabIndex = 0
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(167, 117)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(90, 20)
        Me.txtRadius.TabIndex = 8
        Me.txtRadius.Text = "120"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Radius"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(9, 187)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(247, 36)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "<< Reset >>"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStartAnimation
        '
        Me.btnStartAnimation.Location = New System.Drawing.Point(9, 144)
        Me.btnStartAnimation.Name = "btnStartAnimation"
        Me.btnStartAnimation.Size = New System.Drawing.Size(248, 37)
        Me.btnStartAnimation.TabIndex = 5
        Me.btnStartAnimation.Text = "<< Start >>"
        Me.btnStartAnimation.UseVisualStyleBackColor = True
        '
        'txtFrekuensi
        '
        Me.txtFrekuensi.Location = New System.Drawing.Point(168, 76)
        Me.txtFrekuensi.Name = "txtFrekuensi"
        Me.txtFrekuensi.Size = New System.Drawing.Size(89, 20)
        Me.txtFrekuensi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Frekuensi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "---------- Atau ----------"
        '
        'txtPeriode
        '
        Me.txtPeriode.Location = New System.Drawing.Point(170, 4)
        Me.txtPeriode.Name = "txtPeriode"
        Me.txtPeriode.Size = New System.Drawing.Size(88, 20)
        Me.txtPeriode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.pbAnimation)
        Me.Panel2.Location = New System.Drawing.Point(314, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(612, 373)
        Me.Panel2.TabIndex = 1
        '
        'pbAnimation
        '
        Me.pbAnimation.BackColor = System.Drawing.Color.Black
        Me.pbAnimation.Location = New System.Drawing.Point(3, 3)
        Me.pbAnimation.Name = "pbAnimation"
        Me.pbAnimation.Size = New System.Drawing.Size(606, 367)
        Me.pbAnimation.TabIndex = 0
        Me.pbAnimation.TabStop = False
        '
        'dgvdat
        '
        Me.dgvdat.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.dgvdat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvdat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colwaktu, Me.colSudut, Me.colX, Me.colY})
        Me.dgvdat.Location = New System.Drawing.Point(315, 380)
        Me.dgvdat.Name = "dgvdat"
        Me.dgvdat.Size = New System.Drawing.Size(611, 168)
        Me.dgvdat.TabIndex = 2
        '
        'colwaktu
        '
        Me.colwaktu.HeaderText = "t(sekon)"
        Me.colwaktu.Name = "colwaktu"
        '
        'colSudut
        '
        Me.colSudut.HeaderText = "Sudut"
        Me.colSudut.Name = "colSudut"
        '
        'colX
        '
        Me.colX.HeaderText = "X"
        Me.colX.Name = "colX"
        '
        'colY
        '
        Me.colY.HeaderText = "Y"
        Me.colY.Name = "colY"
        '
        'Timer1
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "m/s"
        '
        'lblV
        '
        Me.lblV.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblV.Location = New System.Drawing.Point(143, 185)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(42, 22)
        Me.lblV.TabIndex = 4
        Me.lblV.Text = "0"
        Me.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(9, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Kecepatan (v) :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 550)
        Me.Controls.Add(Me.dgvdat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi Gerak Melingkar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvdat As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnStartAnimation As System.Windows.Forms.Button
    Friend WithEvents txtFrekuensi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPeriode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbAnimation As System.Windows.Forms.PictureBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblW As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPerSentripental As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents colwaktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSudut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
