using System;

[Serializable]
public class InputEntry {
    public string EmployeeName;
    public string Age;
    public string EmployeeId;

    public InputEntry (string name, string age ,string id) {
        EmployeeName = name;
        Age = age;
        EmployeeId = id;

    }
}



