using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {


	public void playbtn(string play) 
	{
		SceneManager.LoadScene (play);

	}
	public void shopbtn(string shop) 
	{
		SceneManager.LoadScene (shop);

	}
	public void optionsbtn(string options) 
	{
		SceneManager.LoadScene (options);

	}
	public void menubtn(string menu) 
	{
		SceneManager.LoadScene (menu);

	}
	public void exitbtn() 
	{
		Application.Quit ();

	}
}
