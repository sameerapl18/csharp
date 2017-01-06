using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Theme
/// </summary>
public class Theme
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Theme(string name)
    {
        Name = name;
    }
}