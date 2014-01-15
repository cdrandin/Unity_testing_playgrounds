using UnityEngine;
using System.Collections;

public class delegate_test : MonoBehaviour {
	
	delegate void PowerUpsDelegate();
	PowerUpsDelegate powerUps;
	private Color init_color = Color.gray;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.Space))
		{
			powerUps += PowerUp;
			powerUps += TurnRed;
			
			powerUps -= PowerDown;
			powerUps -= TurnGray;
		}
		else
		{
			powerUps -= PowerUp;
			powerUps -= TurnRed;
			
			powerUps += PowerDown;
			powerUps += TurnGray;
		}
		
		if(powerUps != null)
			powerUps();
	}
	void PowerUp ()
	{
		
			//print("Powering up!!!");
		
	}
	void TurnRed ()
	{
		renderer.material.color = Color.red;
	}
	
	void PowerDown ()
	{
		
			//print("Powering down!!!");
		
	}
	
	void TurnGray ()
	{
		renderer.material.color = init_color;
	}
}
