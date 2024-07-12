Public Class Elementos

    Public Imagen As String
    Public Nombre As String
    Public Extension As String
    Public Carpeta As String
    Public Tipo As String
    Public Ruta As String
    Public Descripcion As String
    Public Descripcion2 As String

    Public scale As String
    Public positionX As String
    Public positionZ As String

    Public Overrides Function ToString() As String

        Return Descripcion & Descripcion2

    End Function

End Class
