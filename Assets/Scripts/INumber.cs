public interface INumber
{
	public string Number { get; set; }
	public string Letters { get; set; }
	public int Digits { get; set; }
	public string Region { get; set; }
	public int Rang { get; set; }
	public string Info { get;  set; }

	void Join();
	void Separate();
	void AddData(int rang, string info);
	void ClearData();
}