using Newtonsoft.Json;
using System.Threading;
using System.Web.Services;
using System.Xml;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    // Used to save the fibonacci numbers already calculated for faster execution
    private decimal[] fibonaccis = new decimal[101];

    /// <summary>
    /// Constructor for a <c>Service</c>
    /// </summary>
    public Service() {
        // Initializing fibonaccis array values with 0
        for (int i = 0; i < fibonaccis.Length; i++)
        {
            fibonaccis[i] = 0;
        }
    }

    /// <summary>
    /// Function used to call doFibonacci after 2 seconds.
    /// </summary>
    /// <param name="n">The number we want the fibonacci of</param>
    /// <returns>fibonacci(n)</returns>
    [WebMethod]
    public decimal Fibonacci(int n)
    {
        Thread.Sleep(2000);
        return doFibonacci(n);
    }

    /// <summary>
    /// Recursive method. Gives the fibonacci of a number.
    /// If negative or bigger than 100, the function will return 0.
    /// </summary>
    /// <param name="n">The number we want the fibonacci of</param>
    /// <returns>fibonacci(n)</returns>
    private decimal doFibonacci(int n)
    {
        if (n < 1 || n > 100)
            return 0;
        else
        {
            if (n < 3)
                return 1;
            else
            {
                fibonaccis[n] = (fibonaccis[n - 1] != 0 ? fibonaccis[n - 1] : doFibonacci(n - 1)) + (fibonaccis[n - 2] != 0 ? fibonaccis[n - 2] : doFibonacci(n - 2));
                return fibonaccis[n];
            }
        }
    }

    /// <summary>
    /// Convert a XML string in a JSON string.
    /// </summary>
    /// <param name="xml">The XML string to convert</param>
    /// <returns>The JSON string</returns>
    [WebMethod]
    public string XmlToJson(string xml)
    {
        Thread.Sleep(1000);
        try
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            return JsonConvert.SerializeXmlNode(doc);
        }
        catch
        {
            return "Bad Xml format";
        }
    }
}