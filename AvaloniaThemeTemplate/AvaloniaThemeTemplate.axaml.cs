using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace AvaloniaThemeTemplate;

public class AvaloniaThemeTemplate : Styles
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AvaloniaThemeTemplate"/> class.
    /// </summary>
    /// <param name="sp">The parent's service provider.</param>
    public AvaloniaThemeTemplate(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}