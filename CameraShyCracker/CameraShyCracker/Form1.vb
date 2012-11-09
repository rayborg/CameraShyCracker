'CameraShyCracker
'Copyright 2012, Raymond C. Borges Hink
'This program is copyright under GNU GENERAL PUBLIC LICENSE Version 3
'
'	This program is free software: you can redistribute it and/or modify
'	it under the terms of the GNU General Public License as published by
'	the Free Software Foundation, either version 3 of the License, or
'	(at your option) any later version.
'
'	This program is distributed in the hope that it will be useful,
'	but WITHOUT ANY WARRANTY; without even the implied warranty of
'	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'	GNU General Public License for more details.
'
'	You should have received a copy of the GNU General Public License
'	along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
'		~~~End of Copying permission statement~~~



Option Explicit On
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form1

    'declaration to enter user32.dll removing invalid entry point error
    Declare Sub mouse_event Lib "user32.dll" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)

    'constant for this code
    Private Const BM_CLICK = &HF5

    'some other helpful constants (optional)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1

    'START ESC KEY HOOK 
    Private Const user32 As String = "user32.dll"
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    ' This delegate is used to tell windows which sub we want it to call
    ' when a key is pressed.
    Private proc As LowLevelKeyboardProcDelegate = AddressOf HookCallback
    Private hookID As IntPtr
    ' Just for the demo:
    Private count As Integer = 0

    Private Delegate Function LowLevelKeyboardProcDelegate( _
     ByVal nCode As Integer, ByVal wParam As IntPtr, _
     ByVal lParam As IntPtr) As IntPtr

    ' Creates the hook.
    <DllImport("user32")> _
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProcDelegate, _
     ByVal hMod As IntPtr, ByVal dwThreadId As Integer) As IntPtr
    End Function

    ' Removes the hook.
    <DllImport("user32.dll")> _
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ' The hooks work in a cycle, it is our duty to call the next one after we have been notified.
    <DllImport("user32.dll")> _
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, _
     ByVal lParam As IntPtr) As IntPtr
    End Function

    ' Gets a module handle for our process.
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        hookID = SetHook(proc)
    End Sub

    ' You really want to be sure this is called. Abnormal program termination will leave it open
    ' I think that using a SafeHandle for the hook handle might work.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        UnhookWindowsHookEx(hookID)
    End Sub

    Private Function SetHook(ByVal proc As LowLevelKeyboardProcDelegate) As IntPtr
        Using curProcess As Process = Process.GetCurrentProcess()
            Using curModule As ProcessModule = curProcess.MainModule
                Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Function

    ' Called when a key is pressed.
    Private Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso (wParam.ToInt32 = WM_KEYDOWN) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            If vkCode = Keys.Escape Then
                Environment.Exit(0)
                count += 1
                Me.Text = count.ToString
            End If
        End If
        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function
    'FINISHED ESC KEY HOOK 

    Private Sub wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub
    Sub Do_LMouseClick()
        Call mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Call mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub
    Sub Do_RMouseClick()
        Call mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
        Call mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not wordListFileTextBox.Text = "Enter wordlist here with path/filename" Then
            If File.Exists(wordListFileTextBox.Text) Then
                Dim LoadxLoc As Integer
                Dim LoadyLoc As Integer
                Dim PassxLoc As Integer
                Dim PassyLoc As Integer
                Dim EncxLoc As Integer
                Dim EncyLoc As Integer
                Dim delay As Integer
                Dim password As String
                Dim counter As Integer
                Dim charCheck As Integer
                Dim words() As String = IO.File.ReadAllLines(wordListFileTextBox.Text)

                password = ""
                ProgressBar1.Maximum = words.Length
                If TextBox2.Text.Length > 0 Then
                    counter = Integer.Parse(TextBox2.Text)
                    ProgressBar1.Value = counter
                Else
                    counter = 0
                    ProgressBar1.Value = 0
                End If

                If LoadXBox.Text.Length > 0 Then
                    LoadxLoc = Integer.Parse(LoadXBox.Text)
                Else
                    LoadxLoc = 0
                End If

                If LoadYBox.Text.Length > 0 Then
                    LoadyLoc = Integer.Parse(LoadYBox.Text)
                Else
                    LoadyLoc = 0
                End If

                If PassXBox.Text.Length > 0 Then
                    PassxLoc = Integer.Parse(PassXBox.Text)
                Else
                    PassxLoc = 0
                End If

                If PassYBox.Text.Length > 0 Then
                    PassyLoc = Integer.Parse(PassYBox.Text)
                Else
                    PassyLoc = 0
                End If

                If EncTextXBox.Text.Length > 0 Then
                    EncxLoc = Integer.Parse(EncTextXBox.Text)
                Else
                    EncxLoc = 0
                End If

                If EncTextYBox.Text.Length > 0 Then
                    EncyLoc = Integer.Parse(EncTextYBox.Text)
                Else
                    EncyLoc = 0
                End If

                If DelayBox.Text.Length > 0 Then
                    delay = Integer.Parse(DelayBox.Text)
                Else
                    delay = 500
                End If


                Dim passwordNotFound As Boolean = True

                'Loop to check password and resulting text
                'Checks all characters of result text to determine if they are ANSI below 127
                While (passwordNotFound) And (counter < words.Length)

                    charCheck = 0 'Reset character check to zero

                    'Move to password textbox to try next password
                    Cursor.Position = New Point(PassxLoc, PassyLoc)
                    Do_LMouseClick() 'click in text box
                    wait(delay) 'wait
                    SendKeys.Send("^a")
                    wait(delay) 'wait
                    password = words(counter)
                    TextBox1.Text = password
                    TextBox2.Text = counter

                    Try
                        SendKeys.Send(password) 'insert new password from wordlist
                    Catch
                    End Try

                    'Move cursor to load new image
                    Cursor.Position = New Point(LoadxLoc, LoadyLoc)
                    Do_LMouseClick() 'click load image button
                    wait(delay) 'wait for dialog to open

                    SendKeys.SendWait("~") 'press ok button to select the same image

                    'Move cursor to text result
                    Cursor.Position = New Point(EncxLoc, EncyLoc)
                    Do_RMouseClick() 'click in text box
                    'select some text
                    wait(delay)
                    SendKeys.SendWait("{Down 6}")
                    SendKeys.SendWait("~")
                    SendKeys.SendWait("^{c}")
                    
                    'START hidden message checking
                    'Convert copied text to char array then check each for normal ASCII 
                    Dim arr() As Char = Clipboard.GetText.ToCharArray()

                    For i = 0 To arr.Length - 1
                        If AscW(arr(i)) < 127 Then
                            charCheck += 1
                        End If
                    Next

                    If charCheck = arr.Length And arr.Length > 10 Then
                        passwordNotFound = False
                        MessageBox.Show("Password found: " & words(counter), "Important Message")
                    End If
                    'END hidden message check

                    counter += 1
                    ProgressBar1.Value += 1
                End While

                If passwordNotFound = True Then
                    MessageBox.Show("Password not found!", "Important Message")
                End If

            Else
                MessageBox.Show("Wordlist file does not exist.", "Important Message")
            End If
        Else
            MessageBox.Show("Please enter wordlist to use!", "Important Message")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Environment.Exit(0)
    End Sub
    Private Sub LoadXBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadXBox.TextChanged
        Try
            Integer.Parse(LoadXBox.Text)
        Catch ex As Exception
            LoadXBox.Text = ""
        End Try
    End Sub

    Private Sub LoadYBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadYBox.TextChanged
        Try
            Integer.Parse(LoadYBox.Text)
        Catch ex As Exception
            LoadYBox.Text = ""
        End Try
    End Sub

    Private Sub EncTextXBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncTextXBox.TextChanged
        Try
            Integer.Parse(EncTextXBox.Text)
        Catch ex As Exception
            EncTextXBox.Text = ""
        End Try
    End Sub

    Private Sub EncTextYBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncTextYBox.TextChanged
        Try
            Integer.Parse(EncTextYBox.Text)
        Catch ex As Exception
            EncTextYBox.Text = ""
        End Try
    End Sub

    Private Sub PassXBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassXBox.TextChanged
        Try
            Integer.Parse(PassXBox.Text)
        Catch ex As Exception
            PassXBox.Text = ""
        End Try
    End Sub

    Private Sub PassYBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassYBox.TextChanged
        Try
            Integer.Parse(PassYBox.Text)
        Catch ex As Exception
            PassYBox.Text = ""
        End Try
    End Sub

    Private Sub PassTestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PassTestButton.Click
        If PassXBox.Text.Length > 0 And PassYBox.Text.Length > 0 Then
            Cursor.Position = New Point(PassXBox.Text, PassYBox.Text)
            Do_LMouseClick() 'click in text box
        End If
    End Sub

    Private Sub LoadTestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTestButton.Click
        If LoadXBox.Text.Length > 0 And LoadYBox.Text.Length > 0 Then
            Cursor.Position = New Point(LoadXBox.Text, LoadYBox.Text)
            Do_LMouseClick() 'click in text box
        End If
    End Sub

    Private Sub EncTestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncTestButton.Click
        If EncTextXBox.Text.Length > 0 And EncTextYBox.Text.Length > 0 Then
            Cursor.Position = New Point(EncTextXBox.Text, EncTextYBox.Text)
            Do_LMouseClick() 'click in text box
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Integer.Parse(TextBox2.Text)
        Catch ex As Exception
            TextBox2.Text = ""
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("CameraShyCracker, Copyright 2012, Raymond C. Borges Hink." & " This program comes with ABSOLUTELY NO WARRANTY." & " This is free software, and you are welcome to redistribute it under certain conditions; see COPYING for details.", "License Agreement")
    End Sub
End Class
