static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string nameAndDepartment = $"{name} - " + (department ?? "OWNER").ToUpper();
        return (id != null) ? $"[{id}] - {nameAndDepartment}" : nameAndDepartment;
    }
}
