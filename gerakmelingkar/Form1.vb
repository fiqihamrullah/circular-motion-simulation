Imports System.Drawing.Drawing2D
Public Class Form1
    Dim radius As Integer
    Dim radobjek As Integer
    Dim curdegree As Integer
    Dim widthhalf As Integer, heighthalf As Integer
    Dim x As Integer, y As Integer
    Public Function GetX(ByVal deg As Double) As Double
        Return (radius * Math.Cos((Math.PI / 180) * deg))
    End Function
    Public Function GetY(ByVal deg As Double) As Double
        Return (radius * Math.Sin((Math.PI / 180) * deg))
    End Function
    Public Function CountKecepatanSentripental(ByVal w As Double) As Double
        Return Math.Pow(w, 2) * radius
    End Function
    Private Sub colorCircle(ByVal g As Graphics, ByVal x As Single, ByVal y As Single, ByVal width As Integer, ByVal height As Integer, ByVal c As Color)
        Dim gp As GraphicsPath
        Dim pgb As PathGradientBrush
        gp = New GraphicsPath()
        gp.AddEllipse(x, y, width, height)

        pgb = New PathGradientBrush(gp)
        pgb.CenterPoint = New PointF(x + (width / 2), y + (height / 2))
        pgb.CenterColor = Color.White
        pgb.SurroundColors = New Color() {c}

        pgb.SetBlendTriangularShape(0.5F, 1.0F)
        pgb.FocusScales = New PointF(0.0F, 0.0F)

        g.FillPath(pgb, gp)


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radius = 120
        radobjek = 40
        curdegree = 0
        x = GetX(curdegree)
        y = GetY(curdegree)
        widthhalf = pbAnimation.Width / 2
        heighthalf = pbAnimation.Height / 2

    End Sub

    Private Sub pbAnimation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbAnimation.Click

    End Sub
    Private Sub AnimateCircleMotion(ByVal T As Double)
        Dim mininterval As Double = 1000 * T
        Dim stepinterval As Double = mininterval / 50
        Dim stepdegree As Double
        Dim i As Integer
        Dim maxdegree As Integer = 360
        stepdegree = maxdegree / 40
        curdegree = 0

        Dim t_sekon As Double = 0
        While (t_sekon <= mininterval)
            curdegree = (360 / mininterval) * t_sekon
            x = GetX(360 - curdegree)
            y = GetY(360 - curdegree)
            addData(t_sekon / 1000.0F, x, y, curdegree)
            t_sekon += stepinterval
            pbAnimation.Invalidate()
            Application.DoEvents()
            System.Threading.Thread.Sleep(stepinterval)
        End While

        'While (curdegree < 360)
        '    For i = 1 To stepdegree
        '        curdegree += 1
        '        x = GetX(curdegree)
        '        y = GetY(curdegree)

        '        If (curdegree Mod 15 = 0) Then
        '            addData(0, x, y, curdegree)
        '        End If
        '    Next i
        '    pbAnimation.Invalidate()
        '    Application.DoEvents()
        '    System.Threading.Thread.Sleep(stepinterval)
        'End While
    End Sub
    Private Sub pbAnimation_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbAnimation.Paint
        Dim g As Graphics = e.Graphics
        Dim rbesar As Integer
        rbesar = radius - (radobjek / 2)
        Dim xpusat As Integer, ypusat As Integer
        Dim deg As Integer
        xpusat = widthhalf - 5
        ypusat = heighthalf - 5
        g.DrawEllipse(Pens.Aqua, widthhalf - rbesar, heighthalf - rbesar, rbesar * 2, rbesar * 2)
        g.DrawEllipse(Pens.Aqua, xpusat, ypusat, 10, 10)
        'For deg = 0 To 360 Step 40
   

        ' g.DrawLine(New Pen(Color.Aqua), widthhalf + x - 1, heighthalf + y - 1, widthhalf + x, heighthalf + y)

        colorCircle(g, (widthhalf + x) - (radobjek \ 2), (heighthalf + y) - (radobjek \ 2), radobjek, radobjek, Color.Crimson)
        g.DrawLine(Pens.Gold, xpusat + 5, ypusat + 5, widthhalf + x, heighthalf + y)
        'Next deg
    End Sub 
    Private Sub btnStartAnimation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartAnimation.Click
        Dim frek As Double
        Dim i As Integer
        Dim v As Double
        If (txtPeriode.Text <> "") Then
            frek = Double.Parse(txtFrekuensi.Text)
            radius = Integer.Parse(txtRadius.Text)
            lblW.Text = Math.Round(countW(frek), 2).ToString()
            lblPerSentripental.Text = Math.Round(CountKecepatanSentripental(countW(frek)), 2).ToString()
            lblV.Text = Math.Round(countW(frek) * radius, 2)
            If frek >= 1 Then
                For i = 0 To frek - 1
                    AnimateCircleMotion(Double.Parse(txtPeriode.Text))
                Next i
            Else
                AnimateCircleMotion(Double.Parse(txtPeriode.Text))
            End If

        Else
            MessageBox.Show("Periode Masih Kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Timer1.Interval = 1000 \ 10
        'Timer1.Enabled = True
    End Sub
    Private Sub addData(ByVal t As Double, ByVal x As Double, ByVal y As Double, ByVal degree As Integer)
        Dim obj(4) As Object
        obj(0) = t
        obj(1) = degree
        obj(2) = x.ToString()
        obj(3) = y.ToString
        dgvdat.Rows.Add(obj)

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' curdegree += 36
        ' pbAnimation.Invalidate()
    End Sub
    Private Function countW(ByVal frekuensi As Double) As Double
        Return 2 * Math.PI * frekuensi
    End Function
    Private Sub txtPeriode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPeriode.TextChanged
        Dim nilai As Double = 0
        Dim frekuensi As Double
        If (txtPeriode.Text <> "") Then
            nilai = Double.Parse(txtPeriode.Text)
            frekuensi = 1.0 / nilai
            txtFrekuensi.Text = frekuensi.ToString()
        End If
    End Sub

    Private Sub txtFrekuensi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFrekuensi.TextChanged
        Dim nilai As Double = 0
        Dim periode As Double
        If (txtFrekuensi.Text <> "") Then
            nilai = Double.Parse(txtFrekuensi.Text)
            periode = 1.0 / nilai
            txtPeriode.Text = periode.ToString()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        dgvdat.Rows.Clear()
    End Sub
End Class
