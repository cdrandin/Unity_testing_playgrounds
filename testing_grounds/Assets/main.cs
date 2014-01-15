using UnityEngine;
using System.Collections;
//delegate int NumberChanger(int n);

public class EventTest
{
	private int value;
	
	public delegate void NumManipulationHandler();
	
	public event NumManipulationHandler ChangeNum;
	
	protected virtual void OnNumChanged()
	{
		if (ChangeNum != null)
		{
			ChangeNum();
		}
		else
		{
			Debug.Log(string.Format("Event fired!: {0}", value));
		}
	}
	
	public EventTest(int n)
	{
		SetValue(n);
	}
	
	public void SetValue(int n)
	{
		if(value != n)
		{
			value = n;
			OnNumChanged();
		}
	}
}
	
public class main : MonoBehaviour 
{
	/*
	static int num = 10;
	public static int AddNum(int p)
	{
		num += p;
		return num;
	}
	
	public static int MultNum(int q)
	{
		num *= q;
		return num;
	}
	
	public static int getNum()
	{
		return num;
	}
	
	// Use this for initialization
	void Start () 
	{
		//create delegate instances
		NumberChanger nc;
         NumberChanger nc1 = new NumberChanger(AddNum);
         NumberChanger nc2 = new NumberChanger(MultNum);
		
		nc = nc2;
		nc += nc1;
		nc(5);
		
		Debug.Log(string.Format("Value of Num: {0}", getNum()));
	}
	*/
	
	
	void Start ()
	{
		
		EventTest e = new EventTest(5);
		e.SetValue(7);
		e.SetValue(11);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
