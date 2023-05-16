namespace BlazorApp1.My;

public class BaseIHaveUrls<TEntity, TEntityUrl>
	where TEntity : class, new()
	where TEntityUrl : BaseForUrl<TEntity>, new()
{

	public List<TEntityUrl>? Urls { get; set; }
}
