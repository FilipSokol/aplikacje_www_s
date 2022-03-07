using Microsoft.AspNetCore.Identity;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Role : IdentityRole<int> {
    public Role(string name, RoleValue RoleValue) {

    }
    public RoleValue RoleValue { get; set; }
}
