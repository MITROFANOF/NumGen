public class RussianNumber : Number
{
	public override void Join()
	{
		FullNumber = Letters.Insert(1, Digits.ToString("D3")) + Region;
	}

	public override void Separate()
	{
		Letters = FullNumber[0].ToString() + FullNumber[4] + FullNumber[5];
		Digits = int.Parse(FullNumber.Substring(1, 3));
		Region = FullNumber.Substring(6, FullNumber.Length - 6);
	}
}