Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Threading

Public Class Form1

    'CODED BY : X-SLAYER
    'DEVELOPED BY : aura
    Dim a As Integer = 0
    Dim b As Integer = 0
    Dim c As Integer = 0
    Public Sub New()

        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(LinkLabel2.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://www.youtube.com/c/XSLAYER404")
    End Sub

    Public Sub GETproxy()
        Try
            LvProxy.Items.Clear()
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(("https://free-proxy-list.net")), HttpWebRequest)

            request.Proxy = Nothing
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36"
            request.CookieContainer = New CookieContainer
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim str2 As String = reader.ReadToEnd
            Dim sayac As Integer = 0
            reader.Close()
            For Each I As Match In New Regex("<tr><td>(.*?)<\/td><td>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td class='hx'>(.*?)<\/td><td class='hm'>(.*?)<\/td><\/tr>").Matches(str2)
                Dim itm As New ListViewItem
                proxieslist.Items.Add(I.Groups(1).Value & ":" & I.Groups(2).Value)
                itm.Text = I.Groups(1).Value
                itm.SubItems.Add(I.Groups(2).Value)
                itm.SubItems.Add(I.Groups(3).Value)
                itm.SubItems.Add(I.Groups(4).Value)
                itm.SubItems.Add(I.Groups(5).Value)
                itm.SubItems.Add(I.Groups(6).Value)
                itm.SubItems.Add(I.Groups(7).Value)
                itm.SubItems.Add(I.Groups(8).Value)
                If IM.Images.ContainsKey(I.Groups(3).Value.ToLower + ".png") = True Then
                    itm.ImageIndex = IM.Images.IndexOfKey(I.Groups(3).Value.ToLower + (".png"))
                Else
                    itm.ImageIndex = IM.Images.IndexOfKey("0.Jpeg")
                End If
                LvProxy.Items.Add(itm)
                sayac = sayac + 1
            Next

            MsgBox(sayac & " Proxy Grabbed from https://free-proxy-list.net", MsgBoxStyle.Information)
            btnGrab.Enabled = True
            bsave.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
            btnGrab.Enabled = True
            bsave.Enabled = True
        End Try

    End Sub

    Public Sub GETproxy2()
        Try
            LvProxy.Items.Clear()
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(("https://www.sslproxies.org")), HttpWebRequest)

            request.Proxy = Nothing
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36"
            request.CookieContainer = New CookieContainer
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim str2 As String = reader.ReadToEnd
            Dim sayac As Integer = 0
            reader.Close()
            For Each I As Match In New Regex("<tr><td>(.*?)<\/td><td>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td class='hx'>(.*?)<\/td><td class='hm'>(.*?)<\/td><\/tr>").Matches(str2)
                Dim itm As New ListViewItem
                proxieslist.Items.Add(I.Groups(1).Value & ":" & I.Groups(2).Value)
                itm.Text = I.Groups(1).Value
                itm.SubItems.Add(I.Groups(2).Value)
                itm.SubItems.Add(I.Groups(3).Value)
                itm.SubItems.Add(I.Groups(4).Value)
                itm.SubItems.Add(I.Groups(5).Value)
                itm.SubItems.Add(I.Groups(6).Value)
                itm.SubItems.Add(I.Groups(7).Value)
                itm.SubItems.Add(I.Groups(8).Value)
                If IM.Images.ContainsKey(I.Groups(3).Value.ToLower + ".png") = True Then
                    itm.ImageIndex = IM.Images.IndexOfKey(I.Groups(3).Value.ToLower + (".png"))
                Else
                    itm.ImageIndex = IM.Images.IndexOfKey("0.Jpeg")
                End If
                LvProxy.Items.Add(itm)
                sayac = sayac + 1
            Next




            MsgBox(sayac & " Proxy Grabbed from https://www.sslproxies.org", MsgBoxStyle.Information)
            btnGrab.Enabled = True
            bsave.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
            btnGrab.Enabled = True
            bsave.Enabled = True
        End Try

    End Sub

    Public Sub GETproxy3()
        Try
            LvProxy.Items.Clear()
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(("https://www.us-proxy.org")), HttpWebRequest)

            request.Proxy = Nothing
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36"
            request.CookieContainer = New CookieContainer
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream)
            Dim str2 As String = reader.ReadToEnd
            Dim sayac As Integer = 0
            reader.Close()
            For Each I As Match In New Regex("<tr><td>(.*?)<\/td><td>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td>(.*?)<\/td><td class='hm'>(.*?)<\/td><td class='hx'>(.*?)<\/td><td class='hm'>(.*?)<\/td><\/tr>").Matches(str2)
                Dim itm As New ListViewItem
                proxieslist.Items.Add(I.Groups(1).Value & ":" & I.Groups(2).Value)
                itm.Text = I.Groups(1).Value
                itm.SubItems.Add(I.Groups(2).Value)
                itm.SubItems.Add(I.Groups(3).Value)
                itm.SubItems.Add(I.Groups(4).Value)
                itm.SubItems.Add(I.Groups(5).Value)
                itm.SubItems.Add(I.Groups(6).Value)
                itm.SubItems.Add(I.Groups(7).Value)
                itm.SubItems.Add(I.Groups(8).Value)
                If IM.Images.ContainsKey(I.Groups(3).Value.ToLower + ".png") = True Then
                    itm.ImageIndex = IM.Images.IndexOfKey(I.Groups(3).Value.ToLower + (".png"))
                Else
                    itm.ImageIndex = IM.Images.IndexOfKey("0.Jpeg")
                End If
                LvProxy.Items.Add(itm)
                sayac = sayac + 1
            Next

            MsgBox(sayac & " Proxy Grabbed from https://www.us-proxy.org", MsgBoxStyle.Information)
            btnGrab.Enabled = True
            bsave.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
            btnGrab.Enabled = True
            bsave.Enabled = True
        End Try

    End Sub
    Private Sub btnGrab_Click(sender As Object, e As EventArgs) Handles btnGrab.Click
        proxieslist.Items.Clear()
        LvProxy.Items.Clear()

        btnGrab.Enabled = False
        bsave.Enabled = False
        Dim IHEB As New Thread(AddressOf GETproxy) : IHEB.Start()
        Dim IHEB2 As New Thread(AddressOf GETproxy2) : IHEB2.Start()
        Dim IHEB3 As New Thread(AddressOf GETproxy3) : IHEB3.Start()

    End Sub

    Private Sub bsave_Click(sender As Object, e As EventArgs) Handles bsave.Click
        Try
            If LvProxy.Items.Count = Nothing Then
                Exit Sub
            End If
            Dim ID As New SaveFileDialog
            ID.Title = "Proxy"
            ID.Filter = "TXT Files (*.txt)|*.txt"
            ID.FileName = "Proxy"
            If ID.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim I As New StreamWriter(ID.FileName)
                For Each SLAYER As ListViewItem In LvProxy.Items
                    I.WriteLine(SLAYER.Text & ":" & SLAYER.SubItems(1).Text)
                Next
                I.Close()
                MsgBox("Proxy : " & LvProxy.Items.Count & vbCrLf & "Local : " & ID.FileName, MsgBoxStyle.Information, "Information")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proxieslist.Items.Clear()
        MsgBox("Developed by aura", MsgBoxStyle.Information)
    End Sub

    Private Sub advanced_btn_Click(sender As Object, e As EventArgs) Handles advanced_btn.Click
        If advanced_btn.Text = "Show Advanced" Then
            proxieslist.Visible = False
            advanced_btn.Text = "Hide Advanced"

        Else
            proxieslist.Visible = True
            advanced_btn.Text = "Show Advanced"

        End If
    End Sub
End Class
