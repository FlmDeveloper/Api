namespace FlmApiClient
{
    public class RoutedItem
    {
        public int Id { get; }
        public string Route { get; set; }
        public string DisplayText { get; set; }

        private static int _counter = 0;

        public RoutedItem(string route, string displayText)
        {
            Id = ++_counter;
            Route = route;
            DisplayText = displayText;
        }
    }
}
