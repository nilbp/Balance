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
	public void lvl2(string lvldos) 
	{
		SceneManager.LoadScene (lvldos);

	}
	public void lvl3(string Level3) 
	{
		SceneManager.LoadScene (Level3);

	}
	public void lvl4(string lvlqu) 
	{
		SceneManager.LoadScene (lvlqu);

	}
	public void lvl5(string lvlcin) 
	{
		SceneManager.LoadScene (lvlcin);

	}
	public void lvl6(string lvlsi) 
	{
		SceneManager.LoadScene (lvlsi);

	}
	public void lvl7(string lvlset) 
	{
		SceneManager.LoadScene (lvlset);

	}
	public void lvl8(string lvlvui) 
	{
		SceneManager.LoadScene (lvlvui);

	}
	public void exitbtn() 
	{
		Application.Quit ();

	}
}
