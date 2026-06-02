static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idString = id != null ? $"[{id}] - " : "";
        string departmentString = department != null ? $" - {department.ToUpper()}" : " - OWNER";
        return idString + name + departmentString;
    }
}
