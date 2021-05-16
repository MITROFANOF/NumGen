public abstract class Number
{
	public string FullNumber { get; protected set; }
	public string Letters { get; set; }
	public int Digits { get; set; }
	public string Region { get; set; }
	public int Rang { get; private set; }
	public string Info { get;  private set; }

	public abstract void Join();
	public abstract void Separate();

	public void SetData(int rang, string info)
	{
		Rang = rang;
		Info = info;
	} 
	
	public void AddData(int rang, string info)
	{
		Rang += rang;
		Info += info;
	}

	public void ClearData()
	{
		Rang = 0;
		Info = "";
	}
}