public class UkrainianNumber : Number
{
	public override void Join()
	{
		FullNumber = Region + Digits.ToString("D4") + Letters;
	}

	public override void Separate()
	{
		Letters = FullNumber.Substring(6, 2);
		Digits = int.Parse(FullNumber.Substring(2, 4));
		Region = FullNumber.Substring(0, 2);
	}
}