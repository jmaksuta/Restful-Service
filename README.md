# Restful-Service
A RESTful web service in C# using WCF

This project demonstrates a basic RESTful service written in C# using the WCF (Windows Communication Foundation).
The project uses the classic .NET framework (v4.0), not the newer .NET Core framework.
It demonstrates two web methods one using a simple data type and the second using a complex object data type.
This also uses the RAW request/response body type as opposed to binary/form/other body types, and JSON encoding as opposed to XML.
Although, it is easy to switch to XML, by changing the method attribute options.
The dependencies for encoding are the .NET Framework libraries `System.Runtime.Serialization` for JSON, and `System.Xml.Serialization` for XML.
Tim implement using XML you would add the dependency, change the request/response body Type attribute options for the Service Contracts and
the attributes of the complex objects would change.

The Attributes for the objects are as follows:
JSON
```
[DataContract]
class ClassName {

   [DataMember(Name = "property_name", IsRequired = true/false, EmitDefaultValue = true/false, Order = integer)]
  public object PropertyName {
  ...
  }
}
```
