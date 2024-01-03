using System.Collections.Generic;

namespace BlazorBook.NET;

internal class TOCItem
{
    public string Title { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;

    public List<TOCItem> SubTOCItems { get; set; } = new List<TOCItem>();
}
