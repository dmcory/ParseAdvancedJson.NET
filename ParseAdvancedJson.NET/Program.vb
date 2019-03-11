Imports System
Imports Newtonsoft.Json

Module Program
    Sub Main(args As String())
        Dim json = "{
    'name':'Dark Mystical Cory', 
    'age':29, 
    'city':'México',
    'food': {
                'breakfast': ['Eggs and ham', 'Hotcakes'],
                'lunch': ['Tacos', 'Pizza'],
                'dinner': ['Salad', 'Cereal']
            },
    'colors': {
        'love': ['black', 'yellow', 'blue'],
        'hate': ['pink', 'white', 'red']
    }
 }"
        Dim p = JsonConvert.DeserializeObject(Of Person)(json)
        Console.WriteLine($"Name: {p.name}")
        Console.WriteLine($"Age: {p.age}")
        Console.WriteLine($"City: {p.city}")
        Console.WriteLine("List of breakfast:")
        For Each food In p.food.breakfast
            Console.WriteLine(food)
        Next
        Console.WriteLine("List of lunch:")
        For Each food In p.food.lunch
            Console.WriteLine(food)
        Next
        Console.WriteLine("List of dinner:")
        For Each food In p.food.dinner
            Console.WriteLine(food)
        Next
        Console.WriteLine("List of favorite colors:")
        For Each color In p.colors.love
            Console.WriteLine(color)
        Next
        Console.WriteLine("List of colors that I do not like:")
        For Each color In p.colors.love
            Console.WriteLine(color)
        Next
        Console.ReadKey()
    End Sub

    Public Class Person
        Public Property name As String
        Public Property age As String
        Public Property city As String
        Public Property food As food_categories
        Public Property colors As color_categories
    End Class

    Public Class food_categories
        Public Property breakfast As List(Of String)
        Public Property lunch As List(Of String)
        Public Property dinner As List(Of String)
    End Class

    Public Class color_categories
        Public Property love As List(Of String)
        Public Property hate As List(Of String)
    End Class
End Module
