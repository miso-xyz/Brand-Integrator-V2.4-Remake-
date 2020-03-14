Public Class l_url

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Hide()
        Form1.Enabled = True
        Form1.TopMost = True
        Form1.TopMost = False
        Form1.CheckBox1.Checked = True
    End Sub

    Private Sub l_url_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Apply Long URL?", "Brand Integrator V2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
            Hide()
            Form1.Enabled = True
            Form1.TopMost = True
            Form1.TopMost = False
            Form1.CheckBox1.Checked = True
        Else
            Form1.TreeView1.SelectedNode = Nothing
            Form1.CheckBox1.Checked = False
        End If
        Form1.Timer1.Start()
        Form1.TreeView1.Update()
    End Sub
End Class