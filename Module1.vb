Imports System.IO
Imports System.Collections
Module Module1

    Sub Main()

        Dim objReader As New StreamReader("c:\test.txt")
        Dim ruta As String = "C:\test2.txt"
        'Dim objWriter As New StreamWriter("c:\test.txt")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim clave As String = "1020"
        Dim adicion As Integer = 20

        Do




            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                Dim temp As String = sLine.Substring(7, 9)
                If temp.Substring(0, 4).Contains(clave) Then
                    Dim inicio As String = sLine.Substring(0, 7)
                    Dim cifraString As String = temp.Substring(4)
                    Dim suma = adicion + Convert.ToInt64(cifraString)
                    sLine = inicio + clave + suma.ToString("D5")
                End If

                File.AppendAllText(ruta, sLine + Environment.NewLine)
                arrText.Add(sLine)
            End If
        Loop Until sLine Is Nothing
        objReader.Close()

        For Each sLine In arrText
            Console.WriteLine(sLine)
        Next
        System.Diagnostics.Process.Start("C:\test2.txt")
        Console.ReadLine()
    End Sub

End Module
