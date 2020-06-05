Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable()> _
Public Class zuResult

    Public z0Date As New Date
    Public z1Time As New TimeSpan
    Public z2Cards As Integer = 0
    Public z3KeysMin As Integer = 0
    Public z4Errors As Integer = 0

    Public ReadOnly Property z0Date_ToString() As String
        Get
            Return z0Date.Day & "." & _
                   z0Date.Month & "  " & _
                   z0Date.Hour.ToString("00") & ":" & _
                   z0Date.Minute.ToString("00")
        End Get
    End Property
    Public ReadOnly Property z1Time_ToString() As String
        Get
            Return z1Time.Minutes.ToString("00") & ":" & _
                   z1Time.Seconds.ToString("00")
        End Get
    End Property

    Public Sub CopyTo(ByRef aDest As zuResult)

        With aDest
            .z0Date = z0Date
            .z1Time = z1Time
            .z2Cards = z2Cards
            .z3KeysMin = z3KeysMin
            .z4Errors = z4Errors
        End With

    End Sub

    Public Shared Function zOpenFile(ByVal aFilePath As String) As zuResult()

        Dim aData As zuResult()

        Try
            Using stream1 As Stream = File.Open(aFilePath, FileMode.Open)
                Dim binaryFormater1 As New BinaryFormatter
                aData = binaryFormater1.Deserialize(stream1)
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

        Return aData

    End Function
    Public Shared Function zSaveToFile(ByVal aFilePath As String, ByVal aData As zuResult()) As Boolean

        Try
            Using stream1 As Stream = File.Open(aFilePath, FileMode.Create)
                Dim binaryFormater1 As New BinaryFormatter
                binaryFormater1.Serialize(stream1, aData)
            End Using
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

End Class
