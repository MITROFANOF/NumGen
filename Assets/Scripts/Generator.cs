public class Generator
{
	public void Generate(INumberGenerator generator, INumber number)
	{
		generator.GenerateNumber(ref number);
	}
	
}