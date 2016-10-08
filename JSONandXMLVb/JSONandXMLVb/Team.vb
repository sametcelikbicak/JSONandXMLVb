Public Class Team
    Public Function GetTeamMembers() As Member()
        Dim teamMembers As Member() = New Member() {
            New Member() With {.Id = 1, .Name = "Samet", .Salary = 10000, .Position = "Software Specialist"},
            New Member() With {.Id = 2, .Name = "Kubilay", .Salary = 10000, .Position = "Software Specialist"},
            New Member() With {.Id = 3, .Name = "Erkan", .Salary = 10000, .Position = "Software Specialist"}}

        Return teamMembers
    End Function
End Class
