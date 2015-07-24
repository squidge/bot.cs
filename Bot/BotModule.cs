namespace Bot
{
    using Nancy;
    
    public class BotModule : NancyModule
    {
        public BotModule()
        {
            Get["/"] = param => "All your bots are belong to us!";

            Get["/gety"] = param =>
                {
                    // you will do some logic here
                    // ....
                    // and return your response
                    return "PAPER";
                };

            Post["/posty"] = param =>
                {
                    // you will receive some params here
                    // you can read them like this:
                    var key = Request.Form["paramName"].ToString();

                    // you don't need to return anything special so OK is fine.
                    return "OK";
                };
        }
    }
}
