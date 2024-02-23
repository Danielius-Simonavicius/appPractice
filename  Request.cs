namespace appPractice;

public class Request
{
    public String Type { get; set; }
    public String URL { get; set; }
    public String Host { get; set; }



    public Request(String type, String URL, String Host)
    {

    }

    public static Request GetRequest(String request)
    {
        if (String.IsNullOrEmpty(request))
        {
            return null;
        }
        String[] tokens = request.Split(' ');
        return new Request("", "", "");
    }
}
