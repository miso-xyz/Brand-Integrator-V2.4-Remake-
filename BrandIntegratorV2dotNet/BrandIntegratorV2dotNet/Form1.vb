Public Class Form1
    Dim web_name_s As Boolean
    Dim web_host_s As Boolean
    Dim s_link As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(TreeView1.SelectedNode.Text)
        loadpage(False)
    End Sub
    Function loadpage(Optional ByVal OnlyLink As Boolean = False)
        Dim website_ As String = TreeView1.SelectedNode.Text
        Dim invalid_n As Boolean = False
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
            Case "Klinform.net"
                website_ = "http://www.klinform.net/anmeldung.php?username=" & TextBox1.Text
            Case "000webhost.com"
                website_ = "https://www.000webhost.com/752926.html"
            Case "Wixsite.com"
                website_ = "https://wixstats.com/?a=26429&c=2380&s1="
            Case "Tripod.com"
                website_ = "https://registration.lycos.com/register.php?m_CBURL=http%3A%2F%2Fwww.tripod.lycos.com%2Fbin%2Fmembership%2Fgateway%3Fr%3Dhttp%253A%252F%252Fwww.tripod.lycos.com%252F&m_DL_USA_Tripod_Free=1&m_PR=26&m_VIEW=iframe&m_U=" & TextBox1.Text
            Case "Altervista.org"
                website_ = "https://en.altervista.org/registration.php?action=form"
            Case "shortlinknet.com"
                website_ = "https://shortlinknet.com/api?api=e68b049a370caf73b28a4cdd5e2e10864b3cb1d7&url=" & l_url.TextBox1.Text & "&alias=" & TextBox1.Text & "&format=text"
            Case "payshorturl.com"
                website_ = "http://payshorturl.com/api?api=c8387887110f4b97b6e36ff3c14b7b1ca9d7f480&url=" & l_url.TextBox1.Text & "&alias=" & TextBox1.Text & "&format=text"
            Case "pinkhindi.com"
                website_ = "https://clk.sh/api?api=ad61e569c1870df0aabd5b524e55b9a92387e115&url=" & l_url.TextBox1.Text & "&alias=" & TextBox1.Text & "&format=text"
            Case "tmearn.com"
                website_ = "https://tmearn.com/api?api=7178145758b3557adae7b834114096f33bda79f3&url=" & l_url.TextBox1.Text & "&alias=" & TextBox1.Text & "&format=text"
            Case "soft24.net"
                website_ = "https://soft24.net/api.php?url=" & l_url.TextBox1.Text & "&custom=" & TextBox1.Text
            Case "informe.com"
                website_ = "http://forums.informe.com/GetFreePortal.html"
            Case "3xforum.ro"
                website_ = "http://www.3xforum.ro/inscriere.php"
            Case "myforum.ro"
                website_ = "http://myforum.ro/inregistrare?subdomain=" & TextBox1.Text
            Case Else
                If OnlyLink = True Then
                    TextBox2.Text = "Invalid Node! (Cannot select a whole category)"
                Else
                    MessageBox.Show("Invalid Node! (Cannot select a whole category)!", "Brand Integrator V2", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TreeView1.SelectedNode = Nothing
                End If
                website_ = Nothing
                invalid_n = True
                Return False
        End Select
        If TextBox2.Text = "Name of page is empty!" = False Then
            TextBox2.Text = website_
        End If
        Return True
    End Function
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            web_name_s = False
        Else
            web_name_s = True
        End If
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Select Case TreeView1.SelectedNode.Text
            Case "URL Shorteners", "shortlinknet.com", "payshorturl.com", "pinkhindi.com", "tmearn.com", "soft24.net"
                s_link = True
                If CheckBox1.Checked = False Then
                    Enabled = False
                    l_url.Show()
                End If
                Button2.Show()
            Case Else
                Button2.Hide()
                s_link = False
        End Select
        If TreeView1.SelectedNode.Text IsNot Nothing Then
            web_host_s = True
        End If
        'loadpage(True)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub e_xit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e_xit.Click
        Process.Start("https://github.com/miso-xyz/Brand-Integrator-V2.4-Remake-/")
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Process.Start("https://sinister.ly/User-hacxx")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Process.Start("https://sinister.ly/User-miso")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Enabled = False
        l_url.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = web_host_s & vbCrLf & web_name_s & vbCrLf & l_url.TextBox1.Text
        If s_link = True Then
            If web_host_s = True Then
                If web_name_s = True Then
                    If l_url.TextBox1.Text = "" Then
                        Button1.Enabled = False
                        TextBox2.Text = "Long URL not set!"
                    End If
                Else
                    Button1.Enabled = False
                    TextBox2.Text = "Name of page is empty!"
                End If
            Else
                Button1.Enabled = False
                TextBox2.Text = "Nothing selected!"
            End If
        Else
            If web_host_s = True Then
                If web_name_s = True Then
                Else
                    Button1.Enabled = False
                    TextBox2.Text = "Name of page is empty!"
                End If
            Else
                Button1.Enabled = False
                TextBox2.Text = "Nothing selected!"
            End If
        End If
        If TreeView1.SelectedNode IsNot Nothing Then
            loadpage(True)
        End If
    End Sub
End Class
