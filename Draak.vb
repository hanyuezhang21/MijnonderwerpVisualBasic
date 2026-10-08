
Module Module1

    Class Draak
        Public strName As String
        Public strOrigin As String
        Public strGender As String
        Public intAge As Integer
        Public strClassification As String
        Public Sub New(strName As String, strOrigin As String, strGender As String, intAge As Integer, strClassification As String)
            Me.strName = strName
            Me.strOrigin = strOrigin
            Me.strGender = strGender
            Me.intAge = intAge
            Me.strClassification = strClassification
        End Sub
        Public Sub ToonGegevens()
            Console.WriteLine("Name: " & strName)
            Console.WriteLine("Origin: " & strOrigin)
            Console.WriteLine("Gender: " & strGender)
            Console.WriteLine("Age: " & intAge)
            Console.WriteLine("Classification: " & strClassification)
            Console.WriteLine()
        End Sub
    End Class
    Sub Main()
        Dim draak1 As New Draak("Viserion", "Game of Thrones", "Male", 6, "Dragon, Wight")
        Dim draak2 As New Draak("Rhaegal", "Game of Thrones", "Male", 7, "Dragon")
        Dim draak3 As New Draak("Drogon", "Game of Thrones", "Male", 7, "Dragon")
        draak1.ToonGegevens()
        draak2.ToonGegevens()
        draak3.ToonGegevens()
        Console.ReadLine()
    End Sub

End Module