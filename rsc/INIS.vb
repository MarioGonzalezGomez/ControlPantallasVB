Imports System.Diagnostics
Imports System.IO
Module INIS

    Public Config_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\Config.ini")
    Public fichero_Config_ini As New MadMilkman.Ini.IniFile

    'Public LOCALIZACION_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\LOCALIZACION.ini")
    'Public fichero_LOCALIZACION_ini As New MadMilkman.Ini.IniFile

    'Public PRESENTADORES_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\PRESENTADORES.ini")
    'Public fichero_PRESENTADORES_ini As New MadMilkman.Ini.IniFile

    'Public JUGADORES_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\JUGADORES.ini")
    'Public fichero_JUGADORES_ini As New MadMilkman.Ini.IniFile

    'Public CRAWL_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\CRAWL.ini")
    'Public fichero_CRAWL_ini As New MadMilkman.Ini.IniFile

    'Public FALDONES_ini As New clsFicheroIni(My.Computer.FileSystem.CurrentDirectory & "\INI\FALDONES.ini")
    'Public fichero_FALDONES_ini As New MadMilkman.Ini.IniFile

    Public Sub CrearCarpetasINI()

        Try
            Directory.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\INI\")
            If Not File.Exists(My.Computer.FileSystem.CurrentDirectory & "\INI\Config.ini") Then My.Computer.FileSystem.CopyFile("", My.Computer.FileSystem.CurrentDirectory & "\INI\Config.ini", FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

        Catch ex As Exception

            MsgBox("ERROR")

        End Try

    End Sub

    Public Sub LeerINI()

        Try

            database = Config_ini.Leer("IPF", "DATABASE")
            servidor = Config_ini.Leer("IPF", "SERVIDOR")
            puerto = Config_ini.Leer("IPF", "PUERTO")
            rutaIPFEXE = Config_ini.Leer("IPF", "RUTAEXE")


            rsc = Config_ini.Leer("RSC", "RUTA")

        Catch ex As Exception

        End Try

    End Sub

End Module
