Module Variables
    Public linea_emisión As Integer = 0
    Public Imagen As Image

    Public database As String = ""
    Public servidor As String = ""
    Public puerto As String = ""
    Public rutaIPFEXE As String = ""

    Public rsc As String = ""

    Public EquipoIPF1 As New SAMLib.CConector

    Public Sub ConectaIPF()

        EquipoIPF1.AutoConexion = True

        EquipoIPF1.Servidor = servidor

        EquipoIPF1.Encoder = "utf-8"
        EquipoIPF1.Puerto = 5123
        EquipoIPF1.Conectar()

    End Sub
    Public Sub Enviar_Mensaje(ByVal mensaje As String)

        EquipoIPF1.Enviar_Mensaje(mensaje)

    End Sub

    Public Function STRtoIPF(ByVal valor As String) As String

        Dim ret As String = "" & valor
        'Caracteres a sustuir por su código ascii correspondiente

        ret = ret.Replace("\\", Chr(0)) 'lo sustituimos temporalmente.... por si queremos escapar algo en nuestro texto

        ret = ret.Replace("\", "\u005C\u005C")
        ret = ret.Replace(vbCrLf, "\u000A")
        ret = ret.Replace(vbTab, "\u0008")

        ret = ret.Replace("=", "\u003D")
        ret = ret.Replace("&", "\u0026")
        ret = ret.Replace("'", "\u0027")
        ret = ret.Replace("€", "\u20AC")

        ret = ret.Replace(Chr(0), "\\") 'Se restaura caracter de escape

        Return ret

    End Function

End Module


