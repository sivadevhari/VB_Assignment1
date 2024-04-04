Imports System

Public Class Employee
    Private _name As String
    Private _id As Integer
    Private _department As String

    Public Sub New(name As String, id As Integer, department As String)
        _name = name
        _id = id
        _department = department
    End Sub

    Public Function DisplayDetails()
        Console.WriteLine("Name: " & _name)
        Console.WriteLine("ID: " & _id)
        Console.WriteLine("Department: " & _department)
    End Function
End Class

Module Program
    Sub Main(args As String())

        Dim emp1 As New Employee("Sivadev Hariprasad", 1001, "IT")
        Dim emp2 As New Employee("Shefin Sajimon", 1002, "IT")

        Console.WriteLine("Employee 1 Details:")
        emp1.DisplayDetails()
        Console.WriteLine()

        Console.WriteLine("Employee 2 Details:")
        emp2.DisplayDetails()

        Console.ReadLine()
    End Sub
End Module