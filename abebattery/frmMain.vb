'AbeBattery for Windows
'Autor: Alberto González Catalán
'License: GPL

Imports Microsoft.WindowsAPICodePack
Imports Microsoft.WindowsAPICodePack.Taskbar
Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Imports System.Xml
Imports System
Imports System.Management

Public Class frmMain
    Dim initnotifi
    Dim Green As Drawing.Icon = New Icon(Application.StartupPath & "\g_ba.ico")
    Dim Ambar As Drawing.Icon = New Icon(Application.StartupPath & "\a_ba.ico")
    Dim Red As Drawing.Icon = New Icon(Application.StartupPath & "\r_ba.ico")
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

       
        Dim BatteryStatus As PowerStatus = SystemInformation.PowerStatus
        Dim Battery_LifeRemaining = TimeSpan.FromSeconds(BatteryStatus.BatteryLifeRemaining)
        TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal)
        TaskbarManager.Instance.SetProgressValue(BatteryStatus.BatteryLifePercent * 100, 100)
        TaskbarManager.Instance.TabbedThumbnail.SetThumbnailClip(Me.Handle, New Rectangle(GroupBox1.Location, GroupBox1.Size))
        ProgressBar1.Value = BatteryStatus.BatteryLifePercent * 100

        If BatteryStatus.PowerLineStatus = PowerLineStatus.Offline Then

            If Battery_LifeRemaining.Hours <> 0 Then

                Label2.Text = Estado_1 & " " & Battery_LifeRemaining.Hours & " h " & Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"
                Me.Text = Battery_LifeRemaining.Hours & " h " & Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"
                Tray.Text = Estado_1 & " " & Battery_LifeRemaining.Hours & " h " & Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"
                Tray.BalloonTipText = Estado_1 & " " & Battery_LifeRemaining.Hours & " h " & Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"

            Else

                Label2.Text = Estado_1 & " " & Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"
                Me.Text = Battery_LifeRemaining.Minutes & " m " & "(" & BatteryStatus.BatteryLifePercent * 100 & "%" & ")"

            End If

            Select Case BatteryStatus.BatteryChargeStatus

                Case BatteryChargeStatus.High
                    initnotifi = 0
                    Tray.Icon = Green

                Case BatteryChargeStatus.Low
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Paused)
                    Tray.Icon = Ambar
                    If Notifi1 = True Then
                        If initnotifi = 0 Then
                            Notificar.Enabled = True
                        Else
                            Notificar.Enabled = False
                        End If

                    Else
                        Notificar.Enabled = False
                    End If

                Case BatteryChargeStatus.Critical
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
                    Tray.Icon = Red
                    If Notifi1 = True Then
                        If initnotifi = 0 Then
                            Notificar.Enabled = True
                        Else
                            Notificar.Enabled = False
                        End If

                    Else
                        Notificar.Enabled = False
                    End If

                Case BatteryChargeStatus.NoSystemBattery
                    TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error)
                    Label2.Text = Estado_2
                    Me.Text = Estado_2

            End Select

        ElseIf BatteryStatus.PowerLineStatus = PowerLineStatus.Online And BatteryStatus.BatteryChargeStatus = BatteryChargeStatus.Charging Then

            Label2.Text = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_4
            Me.Text = BatteryStatus.BatteryLifePercent * 100 & Estado_4
            Tray.BalloonTipText = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_4
            Tray.Text = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_4
            Tray.Icon = Green

        ElseIf BatteryStatus.PowerLineStatus = PowerLineStatus.Online Then

            Label2.Text = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_5
            Me.Text = BatteryStatus.BatteryLifePercent * 100 & Estado_5
            Tray.BalloonTipText = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_5
            Tray.Text = Estado_3 & " " & BatteryStatus.BatteryLifePercent * 100 & Estado_5
            Tray.Icon = Green

        End If

        

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If minimizarCerrarV Then
            
            e.Cancel = True
            Me.Visible = False
            Tray.Visible = True
            minimizarCerrarV = False
        Else
            Tray.Visible = False
            Tray = Nothing
            menucontext = Nothing
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        

        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()


        Doc.Load(Application.StartupPath & "\configuration.xml")

        ListaNodos = Doc.SelectNodes("/config/option")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        If Lista.Item(5) = 1 Then
            Dim language = System.Globalization.CultureInfo.CurrentCulture.ToString
            If language.StartsWith("es") Then
                nIdioma = 0
            Else
                nIdioma = 1
            End If
        Else
            If Lista.Item(0) = 0 Then
                nIdioma = 0
            ElseIf Lista.Item(0) = 1 Then
                nIdioma = 1
            End If
            
        End If

        If Lista.Item(1) = 1 Then
            minimizarIcono = True
        Else
            minimizarIcono = False
        End If

        If Lista.Item(2) = 1 Then
            Notifi1 = True
        Else
            Notifi1 = False
        End If

        If Lista.Item(3) = 1 Then
            Notifi2 = True
        Else
            Notifi2 = False
        End If

        Select Case Lista.Item(4)
            Case Lista.Item(4) = 0
                nTiempo = 2000
            Case Lista.Item(4) = 1
                nTiempo = 5000
            Case Lista.Item(4) = 2
                nTiempo = 10000
            Case Lista.Item(4) = 3
                nTiempo = 120000
            Case Lista.Item(4) = 4
                nTiempo = 300000
        End Select

        CargarIdioma_frmMain(nIdioma)
        CargarIdioma_frmAbout(nIdioma)
        CargarIdioma_frmNotes(nIdioma)
        CargarIdioma_frmOptions(nIdioma)

        menucontext.Items(0).Text = Estado_6
        menucontext.Items(2).Text = Estado_7

        If Lista.Item(6) = 1 Then
            minimizarCerrarV = True
        Else
            minimizarCerrarV = False
        End If

        Dim sRegKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim Keys As RegistryKey = CurrentUser.CreateSubKey(sRegKey, RegistryKeyPermissionCheck.ReadWriteSubTree)
        Keys.OpenSubKey(sRegKey, True)
        If Keys.GetValue(Application.ProductName.ToString, "").ToString <> "" Then
            iniciarWin = True
        Else
            iniciarWin = False

        End If

        If iniciarWin = False And Lista.Item(7) = 1 Then
            start_Up(True)
        Else
            start_Up(True)
        End If

        Me.WindowState = FormWindowState.Minimized


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub



    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_CLOSE As Integer = &HF060

        Select Case m.Msg
            Case WM_SYSCOMMAND
                If m.WParam.ToInt32 = SC_CLOSE Then
                    minimizarCerrarV = True
                End If
        End Select

        MyBase.WndProc(m)
    End Sub
    Private Function start_Up(ByVal bCrear As Boolean) As String

        Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim subClave As String = Application.ProductName.ToString
        Dim msg As String = ""

        Try

            Dim Registro As RegistryKey = CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)

            With Registro
                .OpenSubKey(CLAVE, True)

                Select Case bCrear

                    Case True
                        .SetValue(subClave, _
                                  Application.ExecutablePath.ToString)
                        Return "Ok"

                    Case False
                        If .GetValue(subClave, "").ToString <> "" Then
                            .DeleteValue(subClave)
                        End If
                End Select
            End With

        Catch ex As Exception
            msg = ex.Message.ToString
        End Try

        Return msg
    End Function

   

    Private Sub frmMain_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If minimizarIcono = True Then
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                Tray.Visible = True
            End If
        End If
    End Sub

    

    Private Sub Tray_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Tray.MouseDoubleClick
        If minimizarCerrarV = True Then
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.Show()

        ElseIf minimizarIcono = True Then

            Me.Visible = True
            Me.Show()
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

  


    Private Sub MostrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MostrarToolStripMenuItem.Click

        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Notificar_Tick(sender As System.Object, e As System.EventArgs) Handles Notificar.Tick
        Tray.ShowBalloonTip(nTiempo)
        initnotifi = 1
        Notificar.Enabled = False
    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        frmOptions.ShowDialog()
        CargarIdioma_frmMain(nIdioma)
        CargarIdioma_frmAbout(nIdioma)
        CargarIdioma_frmNotes(nIdioma)
        CargarIdioma_frmOptions(nIdioma)
        menucontext.Items(0).Text = Estado_6
        menucontext.Items(2).Text = Estado_7
        If iniciarWin Then
            start_Up(True)
        Else
            start_Up(False)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        End
    End Sub

    Public Enum TempFormat
        Fahrenheit
        Celsius
        Kelvin
        Raw
    End Enum
   
    

End Class
