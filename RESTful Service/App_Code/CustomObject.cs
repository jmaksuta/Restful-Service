using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for CustomObject
/// </summary>
[DataContract]
public class CustomObject
{
    private int _id_PK;
    private string _name;
    private string _description;
    private DateTime _LC_DATETIME;

    [DataMember(Name = "id_pk", IsRequired = true, EmitDefaultValue = true, Order = 0)]
    public int id_PK
    {
        get
        {
            return _id_PK;
        }
        set
        {
            this._id_PK = value;
        }
    }

    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true, Order = 1)]
    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            this._name = value;
        }
    }

    [DataMember(Name = "description", IsRequired = false, EmitDefaultValue = false, Order = 2)]
    public string description
    {
        get
        {
            return _description;
        }
        set
        {
            this._description = value;
        }
    }

    [DataMember(Name = "lc_datetime", IsRequired = false, EmitDefaultValue = false, Order = 3)]
    public String LC_DATETIME
    {
        get
        {
            return _LC_DATETIME.ToString();
        }
        set
        {
            this._LC_DATETIME = DateTime.Parse(value);
        }
    }

    public CustomObject()
    {
        this.id_PK = 0;
        this.name = "";
        this.description = "";
        this.LC_DATETIME = "";
    }
}
