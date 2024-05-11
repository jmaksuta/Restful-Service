using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

    [OperationContract]
    string GetData(int value);

    //[OperationContract]
    //CompositeType GetDataUsingDataContract(CompositeType composite);

    [OperationContract]
    CompositeType GetDataUsingDataContract(CompositeType composite);

    // TODO: Add your service operations here
    [OperationContract]
    [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "GET", RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json, UriTemplate = "/HelloWorld")]
    string helloWorld();

    [OperationContract]
    [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "GET", RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetWithParams?param1={Param1}&param2={Param2}")]
    string GetWithParams(string Param1, string Param2);

    [OperationContract]
    [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json,
    ResponseFormat = WebMessageFormat.Json, UriTemplate = "/SaveObject")]
    CustomObject SaveObject(CustomObject ObjectParam);
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
    bool boolValue = true;
    string stringValue = "Hello ";

    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}
