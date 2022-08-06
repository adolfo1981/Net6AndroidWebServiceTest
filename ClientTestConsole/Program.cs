// See https://aka.ms/new-console-template for more information
using ServiceReference1;

//Console.WriteLine("Hello, World!");

try
{
    var soapClient = new WebServiceSoapClient(WebServiceSoapClient.EndpointConfiguration.WebServiceSoap);
    //Sync test
    //var helloResponse = soapClient.HelloWorld();
    //Async test
    var helloResponse = await soapClient.HelloWorldAsync();
    Console.WriteLine($"SoapClient HelloWorldAsync Response: {helloResponse.Body.HelloWorldResult}");
}
catch (System.Exception ex)
{
    throw;
}
