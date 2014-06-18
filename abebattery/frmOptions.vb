Imports System.Xml

Public Class frmOptions

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()

        Doc.Load(Application.StartupPath & "\configuration.xml")

        ListaNodos = Doc.SelectNodes("/config/option")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        selectorIdioma.SelectedIndex = Lista.Item(0)
        If Lista.Item(1) = 1 Then
            minimizarIcon.Checked = True
            'minimizarCerrar.Enabled = False
        ElseIf Lista.Item(1) = 0 Then
            minimizarIcon.Checked = False
        End If

        If Lista.Item(2) = 1 Then
            checkNotifi1.Checked = True
        ElseIf Lista.Item(2) = 0 Then
            checkNotifi1.Checked = False
        End If

        If Lista.Item(3) = 1 Then
            checkNotifi2.Checked = True
        ElseIf Lista.Item(3) = 0 Then
            checkNotifi2.Checked = False
        End If
        selectorTime.SelectedIndex = Lista.Item(4)

        If Lista.Item(5) = 1 Then
            selectorIdioma.Enabled = False
            checkStart.Checked = True
        Else
            selectorIdioma.Enabled = True
            checkStart.Checked = False
        End If

        If Lista.Item(6) = 1 Then
            minimizarCerrar.Checked = True
        ElseIf Lista.Item(6) = 0 Then
            minimizarCerrar.Checked = False
        End If


        If Lista.Item(7) = 1 Then
            CheckBox1.Checked = True

        Else
            CheckBox1.Checked = False
        End If
    End Sub
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Doc As New XmlDocument, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()

        Lista.Add(selectorIdioma.SelectedIndex)
        nIdioma = selectorIdioma.SelectedIndex
        If minimizarIcon.Checked = True Then
            Lista.Add("1")
            minimizarIcono = True
        Else
            Lista.Add("0")
            minimizarIcono = False
        End If

        If checkNotifi1.Checked = True Then
            Lista.Add("1")
            Notifi1 = True
        Else
            Lista.Add("0")
            Notifi1 = False
        End If

        If checkNotifi2.Checked = True Then
            Lista.Add("1")
            Notifi2 = True
        Else
            Lista.Add("0")
            Notifi2 = False
        End If

        Lista.Add(selectorTime.SelectedIndex)

        If checkStart.Checked = True Then
            Lista.Add("1")
        Else
            Lista.Add("0")
        End If

        If minimizarCerrar.Checked = True Then
            Lista.Add("1")
            minimizarCerrarV = True
        Else
            Lista.Add("0")
            minimizarCerrarV = False
        End If

        If CheckBox1.Checked = True Then
            Lista.Add("1")
            iniciarWin = True
        Else
            Lista.Add("0")
            iniciarWin = False
        End If

        Nodo = Doc.CreateElement("config")

        Doc.AppendChild(Nodo)

        For Each Elemento As String In Lista
            Nodo = Doc.CreateElement("option")
            Nodo.InnerText = Elemento
            Doc.DocumentElement.AppendChild(Nodo)
        Next

        Doc.Save(Application.StartupPath & "\configuration.xml")
        Me.Close()
    End Sub

    
   



    Private Sub checkStart_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles checkStart.CheckedChanged
        If checkStart.Checked = True Then
            selectorIdioma.Enabled = False
        Else
            selectorIdioma.Enabled = True
        End If
    End Sub

    Private Sub minimizarCerrar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles minimizarCerrar.CheckedChanged
        ' If minimizarCerrar.Checked = True Then
        'minimizarIcon.Enabled = False
        'Else
        'minimizarIcon.Enabled = True
        'End If
    End Sub

    Private Sub minimizarIcon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles minimizarIcon.CheckedChanged
        ' If minimizarIcon.Checked = True Then
        'minimizarCerrar.Enabled = False
        ' Else
        'minimizarCerrar.Enabled = True
        ' End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class