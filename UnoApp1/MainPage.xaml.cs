namespace UnoApp1
{
    public class MyDataType
    {
        public string Text { get; set; } = "Hello, world!";
        public void Switch_Toggled(object sender, RoutedEventArgs e)
        {
            (sender as ToggleSwitch).Header = "Switch toggled!";
        }
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MyDataType MyContent { get; set; } = new MyDataType();
    }
}
