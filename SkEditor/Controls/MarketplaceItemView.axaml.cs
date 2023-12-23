using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace SkEditor.Controls;
public partial class MarketplaceItemView : UserControl
{
    public static AvaloniaProperty<string> ItemNameProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemName));
    public static AvaloniaProperty<string> ItemVersionProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemVersion));
    public static AvaloniaProperty<string> ItemAuthorProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemAuthor));
    public static AvaloniaProperty<string> ItemImageUrlProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemImageUrl));
    public static AvaloniaProperty<string> ItemShortDescriptionProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemShortDescription));
    public static AvaloniaProperty<string> ItemLongDescriptionProperty = AvaloniaProperty.Register<MarketplaceItemView, string>(nameof(ItemLongDescription));

    public string ItemName
    {
        get => GetValue(ItemNameProperty)?.ToString() ?? "";
        set => SetValue(ItemNameProperty, value);
    }
    public string ItemVersion
    {
        get => GetValue(ItemVersionProperty)?.ToString() ?? "";
        set => SetValue(ItemVersionProperty, value);
    }
    public string ItemAuthor
    {
        get => GetValue(ItemAuthorProperty)?.ToString() ?? "";
        set => SetValue(ItemAuthorProperty, value);
    }
    public string ItemImageUrl
    {
        get => GetValue(ItemImageUrlProperty)?.ToString() ?? "";
        set => SetValue(ItemImageUrlProperty, value);
    }
    public string ItemShortDescription
    {
        get => GetValue(ItemShortDescriptionProperty)?.ToString() ?? "";
        set => SetValue(ItemShortDescriptionProperty, value);
    }

    public string ItemLongDescription
    {
        get => GetValue(ItemLongDescriptionProperty)?.ToString() ?? "";
        set => SetValue(ItemLongDescriptionProperty, value);
    }


    public MarketplaceItemView()
    {
        InitializeComponent();

        DataContext = this;

        RenderOptions.SetBitmapInterpolationMode(IconImage, BitmapInterpolationMode.HighQuality);
    }
}