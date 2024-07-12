Imports System.Text

Public Class clsFicheroIni
    Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer

    Private _PathFichero As String 'Nombre del fichero con la ruta completa
    Private _fichero As String 'Nombre del fichero con la ruta completa
    Private _path As String 'Path al fichero

    Public ReadOnly Property Path() As String
        Get
            Return _path
        End Get
    End Property
    Public ReadOnly Property Fichero() As String
        Get
            Return _fichero
        End Get
    End Property

    Public Sub Escribir(ByRef Seccion As String, ByRef Clave As String, ByVal Valor As String)
        If Valor.StartsWith(" ") OrElse Valor.EndsWith(" ") OrElse Valor.StartsWith("""") Then Valor = """" & Valor & """"

        If Valor.Contains(vbCr) Then Valor = Valor.Replace(vbCr, Chr(1))
        If Valor.Contains(vbLf) Then Valor = Valor.Replace(vbLf, Chr(2))

        WritePrivateProfileString(Seccion, Clave, Valor, Me._PathFichero)
    End Sub
    Public Function Leer(ByRef Seccion As String, ByRef Clave As String) As String
        Return Leer(Seccion, Clave, Nothing)
    End Function
    Public Function Leer(ByRef Seccion As String, ByRef Clave As String, ByRef Defecto As Object) As String
        Dim temp As StringBuilder = New StringBuilder(2048)
        Dim i As Integer = 0

        i = GetPrivateProfileString(Seccion, Clave, "", temp, 2048, Me._PathFichero)
        Dim ret As String = temp.ToString

        If ret.Contains(Chr(1)) Then ret = ret.Replace(Chr(1), vbCr)
        If ret.Contains(Chr(2)) Then ret = ret.Replace(Chr(2), vbLf)

        If ret = "" AndAlso Not Defecto Is Nothing Then
            Escribir(Seccion, Clave, Defecto.ToString)
            Return Defecto.ToString
        End If

        Return ret

    End Function
    Public Sub New(ByRef sRutaCompleta As String) 'Consutructor pasándole la ruta completa
        Dim info As New System.IO.FileInfo(sRutaCompleta)

        'Se separa la ruta completa en su path y su fichero
        Me._fichero = info.Name
        Me._path = info.DirectoryName
        Me._path &= IIf(Not Me._path.EndsWith("\"), "\", "")

        Me._PathFichero = Me._path & Me._fichero

        Try : IO.Directory.CreateDirectory(Me._path) : Catch : End Try
    End Sub

End Class
