namespace MauiApp2;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public Color FrameBackgroundColor { get; } = Colors.Azure;
}