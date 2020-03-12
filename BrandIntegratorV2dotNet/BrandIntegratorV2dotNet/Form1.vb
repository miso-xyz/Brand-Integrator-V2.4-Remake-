Public Class Form1
    Dim web_name_s As Boolean
    Dim web_host_s As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(TreeView1.SelectedNode.Text)
        Dim website_ As String = TreeView1.SelectedNode.Text
        Select Case website_
            Case "Blogspot.com"
                website_ = "https://www.blogger.com/create-blog.g?defaultSubdomain=" & TextBox1.Text
            Case "Wordpress.com"
                website_ = "https://wordpress.com/start?aff=13056&new=" & TextBox1.Text
            Case "BlogSky.com"
                website_ = "http://www.blogsky.com/signup"
            Case "Blogs.sapo.pt"
                website_ = "https://blogs.sapo.pt/create"
            Case "Weebly.com"
                website_ = "https://www.weebly.com/features/start-a-blog?lang=en"
            Case "Altervista.org"
                website_ = "https://en.altervista.org/registration.php?action=form&atype=blog"
            Case "Livejournal.com"
                website_ = "https://www.livejournal.com/create.bml/?user=" & TextBox1.Text
            Case "Supersite.fr", "4yu.fr"
                website_ = "http://www.supersite.fr/myred/register.php?do=register2&domainname=" & TextBox1.Text & "&ext=" & website_
            Case "Max.st", "3gp.fr", "Gtx.fr", "Ici.st", "Site.cx", "User.fr", "Zxr.fr"
                website_ = "http://www.max.st/myred/register.php?do=register2&domainname=" & TextBox1.Text & "&ext=" & website_
            Case "R5t.com"
                website_ = "http://r5t.com/register.php?do=register2&domainname=" & TextBox1.Text & "&ext=r5t.com"
            Case "Arab.ir", "Denmark.ir", "Egypt.ir", "Icq.ir", "Ir.ae", "Ire.ir", "Ireland.ir", "Irq.ir", "Irr.ir", "Jpg.ir", "Ksa.ir", "Kuwait.ir", "London.ir", "Paltalk.ir", "Spain.ir", "Sweden.ir", "Tokyo.ir"
                website_ = "http://ir.ae/myred/register.php?do=register2&domainname=" & TextBox1.Text & "&ext=" & website_
            Case "Sx.de (Adult)"
                website_ = "http://www.sx.de/gratiserotikdomains/register.php?do=register2&domainname=" & TextBox1.Text & "&ext=sx.de"
            Case Else
                MessageBox.Show("Node is not valid!", "Brand Integrator V2", MessageBoxButtons.OK, MessageBoxIcon.Error)
                website_ = Nothing
                TreeView1.SelectedNode = Nothing
        End Select
        Process.Start(website_)
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            web_name_s = False
        Else
            web_name_s = True
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "" Then
            web_host_s = False
        Else
            web_host_s = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If web_host_s = True And web_name_s = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("App made by miso" & vbCrLf & "Original post by hacxx" & vbCrLf & "Released on sinister.ly (<3)" & vbCrLf & vbCrLf & "See hacxx's original post?", "Brand Integrator V2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Process.Start("https://sinister.ly/Thread-Brand-Integrator-v2-4-Register-and-spread-your-brand-for-free")
        Else
            MsgBox(":c", MsgBoxStyle.OkOnly, "Brand Integrator V2")
        End If
    End Sub
End Class
