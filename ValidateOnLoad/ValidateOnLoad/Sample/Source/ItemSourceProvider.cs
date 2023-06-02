using Syncfusion.Maui.DataForm;

namespace ValidateOnLoad
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "City")
            {
                List<string> city = new List<string>() { "New York", "Los Angeles", "Phoenix", "Los Angeles", "New York", "Denver" };
                return city;
            }

            return new List<string>();
        }
    }
}