Public Class Register
    Dim Rpx As Microsoft.Win32.RegistryKey
    Dim Rk As Microsoft.Win32.Registry
    'Dim CurWin As Microsoft.Win32.RegistryKey
    Dim Sn As String
    Dim SoftCode As String = "100C234M601R920D"
    '& Asc(D) & Asc(R) & Asc(M) & Asc(C)
    Dim WinCur As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion"
    Dim AukCur As String = "HKEY_LOCAL_MACHINE\SOFTWARE\AukSoftware's\Database\Drmc"
    'Dim nLoad As New Form
    Dim One As Boolean

    Private Sub Register_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        AukSoft.Hide()
        AukSoft.Close()

    End Sub
    Private Sub Register_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated


        'rpx.

    End Sub
    Private Sub Nload()
        If One = True Then
            Logo.Show()
            Logo.Activate()
        Else
            Form1.Show()
            Form1.Activate()

        End If
        Me.Close()

    End Sub
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rpx = Rk.LocalMachine
        'Login.Close()
    
        ml = "Software\AukSoftware's\Database\Drmc"
        Rpx.CreateSubKey(ml)

        'Rpx.OpenSubKey(ml, False)
        'CurWin = Rk.LocalMachine
        'ml2 = "SOFTWARE\Microsoft\Windows\CurrentVersion"
        'CurWin.OpenSubKey(ml2, False)
        CrEr(True)
        Sn = Rk.GetValue(AukCur, "Category", "")
        m = Rk.GetValue(AukCur, "ShowView", "")
        If m = "two" Or m = "" Then
            Rk.SetValue(AukCur, "ShowView", "one")
            One = False

        Else
            Rk.SetValue(AukCur, "ShowView", "two")
            One = True
        End If


        'MsgBox(Rpx.ToString)
        If Sn = "DrmcInstalling" Then
            'Rk.SetValue(AukCur, "CodePersonalInstalling", xo(xo(Me.TextBox2.Text)))

            'Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Me.TextBox2.Text))
            'Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
            Sn = (((Rk.GetValue(AukCur, "CodePersonalInstalling", ""))))
            If Sn.ToLower = "***drmccodebyauksoftfreewares***" Then
                If (Now.Year < 2006) And (Now.Month < 12) And (Now.Day < 20) Then
                    MsgBox("Please Set Current Date Time In Your Computer to Collect Information Correctly....", MsgBoxStyle.Critical)
                    End
                End If
                sq = xo_back(Rk.GetValue(WinCur, "Windows_x86_" & SoftCode, ""))
                If UCase(sq) <> UCase(Sn) Then
                    SetEr()
                    CrEr(True)

                End If
                gp = xo_back(Rk.GetValue(AukCur, "SoftInstallDate", 0))

                cg = DateDiff(DateInterval.Month, gp, Microsoft.VisualBasic.Now.Date)
                'MsgBox(cg)
                If Val(cg) < 10 Or Val(cg) < 0 Then
                    Nload()
                Else
                    SetEr()
                    MsgBox("There are Serious Problem... Error 232..System Error Contact With Auk(0171-1334201,0193-500863)...", MsgBoxStyle.Critical)
                    End
                End If
            ElseIf Sn.ToLower = "***drmccodebyauksoftfreewares***confrim" Then
                Nload()
            Else
                SetEr()
                MsgBox("Code Is Wrong ,Contact With Auk(0171-1334201)...", MsgBoxStyle.Critical)
                End

            End If
        ElseIf Sn = "TestEditon" Then
            If (Now.Year < 2006) And (Now.Month < 12) And (Now.Day < 20) Then
                MsgBox("Please Set Current Date Time In Your Computer to Collect Information Correctly....", MsgBoxStyle.Critical)
                End
            End If
            m1 = Rk.GetValue(AukCur, "InsDate", "")
            m2 = xo(Rk.GetValue(WinCur, "Windows _Plus++" & SoftCode, ""))
            m3 = xo_back(Rk.GetValue(WinCur, "Windows _G++" & SoftCode, ""))
            LD = Rk.GetValue(WinCur, "Windows _Lndpas" & SoftCode, "")
            If (m1 = m2) And m1 = "" Then
                SetEr()
                CrEr(True)
            End If
            If m1 <> m2 Then
                SetEr()
                'CrEr()
                MsgBox("You are just trying to change dates... Software is Corrupt for this PC...Contact with auk...(0171-1334201)", MsgBoxStyle.Critical)
                End
            End If
            If LD <> "" Then
                mn = DateDiff(DateInterval.Day, Now.Date, LD)

                If Val(mn) < 0 Then
                    SetEr()
                    CrEr(True)
                    End
                End If
            End If
            Rk.SetValue(WinCur, "Windows _Lndpas" & SoftCode, Now.Date)

            mn = DateDiff(DateInterval.Day, m3, Now.Date)
            'MsgBox(mn)
            If Val(mn) > 30 Or Val(mn) < 0 Then
                MsgBox("Your FreeTime Is Over buy Soft Key From Auk(0171-1334201,0193-500863)", MsgBoxStyle.Critical)
                If Val(mn) < 0 Then
                    SetEr()
                End If
                Me.Show()
            Else
                Nload()
            End If

        ElseIf Sn = "PersonalInstalling" Then

            m1 = Rk.GetValue(AukCur, "CodePersonalInstalling", "")
            m2 = Rk.GetValue(WinCur, "Windows_x86_" & SoftCode, "")
            m2 = AukF.ConTOAsc(xo(m2), "*", 21323)


            'insdate = (((Rpx.GetValue("CodePersonalInstalling"))))
            'po = (((CurWin.GetValue("Windows_x86_" & SoftCode))))
            'MsgBox(po, , insdate)
            If m1 = m2 Then
                'Me.Show()
                'nLoad.Show()
                'Me.Close()
                Nload()

            Else
                MsgBox("Code Is Wrong ,Contact With Auk(0171-1334201,0193-500863)...", MsgBoxStyle.Critical)
                End

            End If
        Else
            Sn = "***drmccodebyauksoftfreewares***"
            If Sn.ToLower = "***drmccodebyauksoftfreewares***" Or Sn.ToLower = "***drmccodebyauksoftfreewares***confrim" Then
                MsgBox("Registry Successfully for only Dhaka Residential Model College.....", MsgBoxStyle.Information)

                Rk.SetValue(AukCur, "CodePersonalInstalling", Sn.ToUpper)
                Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Sn.ToUpper))
                Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
                Rk.SetValue(AukCur, "Category", "DrmcInstalling")

                Nload()
            Else
                MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
                Exit Sub
            End If

        End If
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim Aukf2 As New AukFunC
        Dim T1, T2, T3, T4, T5 As String

        If Me.ComboBox1.Text = "PersonalInstalling" Then
            T1 = Aukf2.ConTOAsc(Now.Date, "+", Now.Hour, False)
            T2 = Aukf2.ConTOAsc(xo(xo(T1)), "*", Now.Hour, True)
            T3 = (Aukf2.ConTOAsc(Aukf2.ConTOAsc((xo(T1)), "+", Now.Hour, True), "+", Now.Hour, True))
            T4 = (Aukf2.ConTOAsc(Aukf2.ConTOAsc((xo(T1)), "+", Now.Hour, True), "+", Now.Month * Now.Hour * Now.Year + Val(Aukf2.ConTOAsc(Now.Date, "", "", True)), True))
            T5 = AukF.ConTOAsc("ALIM UL KARIM", "*", 21, True) & "-" & AukF.ConTOAsc("DrmcDatabase", "*", 21, True) & "-" & T4 & "-" & T1 & "-" & T2 & "-" & T3 & "-" & AukF.ConTOAsc(Me.TextBox1.Text, "*", Len(Me.TextBox1.Text) * 3, True)
            'MsgBox(T5)
            If T5 = UCase(Me.TextBox2.Text) Then
                Rk.SetValue(AukCur, "CodePersonalInstalling", AukF.ConTOAsc(xo(AukF.ConTOAsc(T5, "*", 234)), "*", 21323))
                Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, AukF.ConTOAsc(T5, "*", 234))

                MsgBox("Registry Successfully.....", MsgBoxStyle.Information)
                Nload()

            Else
                MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
                Exit Sub

            End If
            Rk.SetValue(AukCur, "Category", "PersonalInstalling")
        ElseIf Me.ComboBox1.Text = "DrmcInstalling" Then
            'MsgBox("in")
            Sn = Me.TextBox2.Text
            If Sn.ToLower = "***drmccodebyauksoftfreewares***" Or Sn.ToLower = "***drmccodebyauksoftfreewares***confrim" Then
                MsgBox("Registry Successfully for only Dhaka Residential Model College.....", MsgBoxStyle.Information)

                Rk.SetValue(AukCur, "CodePersonalInstalling", Sn.ToUpper)
                Rk.SetValue(WinCur, "Windows_x86_" & SoftCode, xo(Sn.ToUpper))
                Rk.SetValue(AukCur, "SoftInstallDate", xo(Now.Date))
                Rk.SetValue(AukCur, "Category", "DrmcInstalling")

                Nload()
            Else
                MsgBox("Error In Code Contact with auk(0193500863,01711-334201)", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Rk.SetValue(AukCur, "Category", "DrmcInstalling")
        Else
            Rk.SetValue(AukCur, "Category", "TestEditon")
            Rk.SetValue(AukCur, "InsDate", xo(AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234)))
            Rk.SetValue(WinCur, "Windows _Plus++" & SoftCode, AukF.ConTOAsc(Now.Date.ToLongDateString, "*", 234))
            Rk.SetValue(WinCur, "Windows _G++" & SoftCode, xo(Now.Date))

            'Rk.SetValue(AukCur, "SoftInfo", (Now.Date))
            'Rk.SetValue(AukCur, "PlK", 0)
            'Rk.SetValue(WinCur, "Windows" & SoftCode, (xo(0)))
            MsgBox("TestEdition you can you only 30 days.....", MsgBoxStyle.Information)
           Nload()
        End If
    

    End Sub
    Public Sub SetEr()
        Rk.SetValue(WinCur, SoftCode, AukF.ConTOAsc("Error", "*", 242323432))
    End Sub
    Public Function CrEr(ByVal DoJob As Boolean) As Boolean
        w = AukF.ConTOAsc("Error", "*", 242323432)
        xwq = Rk.GetValue(WinCur, SoftCode, "")
        If xwq = w Then
            CrEr = True
        Else
            CrEr = False
        End If
        If DoJob = True Then
            If CrEr = True Then
                MsgBox("You Have Some thing Change in Registry Soft is Destroyed...", MsgBoxStyle.Critical)
                End
            End If
        End If
    End Function
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
       
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AukSoft.Show()
        AukSoft.Activate()

    End Sub
End Class