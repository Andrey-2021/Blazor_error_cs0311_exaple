namespace BlazorApp1.My;

public class Country:BaseIHaveUrls<Country, CoutryUrl>, IHaveUrls<CoutryUrl, Country>
{
	public int Id { get; set; }
	public string Name { get; set; }
}
