using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour {

	[System.Serializable]
	public class Level
	{
		public string LevelText;
		public int UnLocked;
		public bool IsInteractable= false;
	}

	public GameObject levelButton;
	public Transform Spacer;
	public List<Level> LevelList;

	public int TotalScore;

	void Start () 
	{
		//DeleteAll ();
		FillList ();
		TotalScore = PlayerPrefs.GetInt ("totalscore");

		PlayerPrefs.SetInt ("Level2", 0);
		PlayerPrefs.SetInt ("Level3", 0);
		PlayerPrefs.SetInt ("Level4", 0);
		PlayerPrefs.SetInt ("Level5", 0);
		PlayerPrefs.SetInt ("Level6", 0);
		PlayerPrefs.SetInt ("Level7", 0);
		PlayerPrefs.SetInt ("Level8", 0);

	}

	void FillList()
	{


		foreach (var level in LevelList) {
			GameObject newbutton = Instantiate (levelButton) as GameObject;
			LevelButton button = newbutton.GetComponent<LevelButton> ();
			button.LevelText.text = level.LevelText;

			if (PlayerPrefs.GetInt ("Level" + button.LevelText.text ) == 9) {
				level.UnLocked = 1;
				level.IsInteractable = true;
			}

			button.unlocked = level.UnLocked;
			button.GetComponent<Button> ().interactable = level.IsInteractable;
			button.GetComponent<Button> ().onClick.AddListener(() => loadLevels("Level" + button.LevelText.text));

			//PlayerPrefs.SetInt ("Level" + button.LevelText.text, TotalScore);
		
			newbutton.transform.SetParent (Spacer);

		}
		//SaveAll ();
	}

	void SaveAll()
	{

/*		if (PlayerPrefs.HasKey ("Level 1")) 
		{
			return;
		}

		else*/

			GameObject[] allButtons = GameObject.FindGameObjectsWithTag ("LevelButton");
			foreach (GameObject buttons in allButtons)
			{
				LevelButton button = buttons.GetComponent<LevelButton> ();
				PlayerPrefs.SetInt ("Level" + button.LevelText.text, button.unlocked);
			
			}
	}

	void DeleteAll()
	{
		PlayerPrefs.DeleteAll ();
	}

	void loadLevels(string value)
	{
		Application.LoadLevel (value);
	}

}
