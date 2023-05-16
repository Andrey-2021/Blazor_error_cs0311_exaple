using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorApp1.My;

public class BaseForUrl<TParent>
	where TParent : class, new()
{
	public int Id { get; set; }
	public string? Url { get; set; }
	public string? UrlTitle { get; set; }

	public int ForeignKey { get; set; }

	[ForeignKey("ForeignKey")]
	public TParent? ForeignEntity { get; set; }
}
