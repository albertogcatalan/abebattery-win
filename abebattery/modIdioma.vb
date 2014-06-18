Imports System.Xml

Module modIdioma
    Public Sub CargarIdioma_frmMain(ByVal lenguaje As String)
        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()
        Dim ArchivoIdioma As String
        ArchivoIdioma = "\es.xml"

        If lenguaje = 0 Then
            ArchivoIdioma = "\es.xml"
        ElseIf lenguaje = 1 Then
            ArchivoIdioma = "\en.xml"
        End If

        Doc.Load(Application.StartupPath & ArchivoIdioma)

        ListaNodos = Doc.SelectNodes("/languaje/main/texto")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        With frmMain
            .ToolStripButton4.Text = Lista.Item(0)
            .ToolStripButton1.Text = Lista.Item(1)
            .GroupBox1.Text = Lista.Item(2)
        End With

        Estado_1 = Lista.Item(3)
        Estado_2 = Lista.Item(4)
        Estado_3 = Lista.Item(5)
        Estado_4 = Lista.Item(6)
        Estado_5 = Lista.Item(7)
        Estado_6 = Lista.Item(8)
        Estado_7 = Lista.Item(9)

        frmMain.ToolStripButton5.Text = Estado_7




    End Sub

    Public Sub CargarIdioma_frmAbout(ByVal lenguaje As String)
        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()
        Dim ArchivoIdioma As String
        ArchivoIdioma = "\es.xml"

        If lenguaje = 0 Then
            ArchivoIdioma = "\es.xml"
        ElseIf lenguaje = 1 Then
            ArchivoIdioma = "\en.xml"
        End If

        Doc.Load(Application.StartupPath & ArchivoIdioma)

        ListaNodos = Doc.SelectNodes("/languaje/about/texto")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        With frmAbout
            .Text = Lista.Item(0)
            .Label4.Text = Lista.Item(2)
            .LinkLabel1.Text = Lista.Item(3)
            .Button2.Text = Lista.Item(4)
            .Button1.Text = Lista.Item(5)
        End With


    End Sub

    Public Sub CargarIdioma_frmOptions(ByVal lenguaje As String)
        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()
        Dim ArchivoIdioma As String
        ArchivoIdioma = "\es.xml"

        If lenguaje = 0 Then
            ArchivoIdioma = "\es.xml"
        ElseIf lenguaje = 1 Then
            ArchivoIdioma = "\en.xml"
        End If

        Doc.Load(Application.StartupPath & ArchivoIdioma)

        ListaNodos = Doc.SelectNodes("/languaje/options/texto")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        With frmOptions
            .Text = Lista.Item(0)
            .TabPage2.Text = Lista.Item(1)
            .TabPage3.Text = Lista.Item(2)
            .Label1.Text = Lista.Item(3)
            .TabPage2.Text = Lista.Item(4)
            .minimizarIcon.Text = Lista.Item(5)
            .Button2.Text = Lista.Item(6)
            .TabPage1.Text = Lista.Item(7)
            .checkNotifi1.Text = Lista.Item(8)
            .checkNotifi2.Text = Lista.Item(9)
            .labeltime.Text = Lista.Item(10)
            .checkStart.Text = Lista.Item(11)
            .minimizarCerrar.Text = Lista.Item(12)
            .CheckBox1.Text = Lista.Item(13)
        End With
    

    End Sub

    Public Sub CargarIdioma_frmNotes(ByVal lenguaje As String)
        Dim Doc As New XmlDocument, ListaNodos As XmlNodeList, Nodo As XmlNode
        Dim Lista As ArrayList = New ArrayList()
        Dim ArchivoIdioma As String
        ArchivoIdioma = "\es.xml"

        If lenguaje = 0 Then
            ArchivoIdioma = "\es.xml"
        ElseIf lenguaje = 1 Then
            ArchivoIdioma = "\en.xml"
        End If

        Doc.Load(Application.StartupPath & ArchivoIdioma)

        ListaNodos = Doc.SelectNodes("/languaje/notes/texto")

        For Each Nodo In ListaNodos
            Lista.Add(Nodo.ChildNodes.Item(0).InnerText)
        Next

        frmNotes.Text = Lista.Item(0)


    End Sub

    

    

  

    
End Module
