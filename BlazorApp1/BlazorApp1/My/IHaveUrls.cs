namespace BlazorApp1.My;

public interface IHaveUrls<TUrlTable, TEntity>
	where TUrlTable : BaseForUrl<TEntity>, new()
	where TEntity : class, new()
{
	public List<TUrlTable>? Urls { get; set; } //навигационное свойство
}
