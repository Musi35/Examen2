Imports System
Imports Npgsql

Public Class Connection
    Public Shared Function ObtenerCadenaConexion() As String
        Dim servidor As String = "localhost"
        Dim usuario As String = "postgres"
        Dim contraseña As String = "a"
        Dim baseDeDatos As String = "Examen2"

        Dim connectionString As String = $"Host={servidor};Username={usuario};Password={contraseña};Database={baseDeDatos}"
        Return connectionString
    End Function
End Class
