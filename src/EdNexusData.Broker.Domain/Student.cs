// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

namespace EdNexusData.Broker.Domain;

public class Student
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? StudentNumber { get; set; }
    public string? Grade { get; set; }
    public DateOnly? Birthdate { get; set; }
    public string? Gender { get; set; }
}