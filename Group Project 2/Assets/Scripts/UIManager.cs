using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;


	void Start ()
    {

        Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();

	}

	void Update ()
    {

		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Debug.Log ("high");
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}

        public void pauseControl()
    {
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePaused();
			}
	}

	public void showPaused()
    {
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(true);
		}
	}

	public void hidePaused()
    {
		foreach(GameObject g in pauseObjects)
        {
			g.SetActive(false);
		}
	}

	public void LoadLevel(string level)
    {
		SceneManager.LoadScene(level);
	}

    public void CloseGame()
    {
        Application.Quit();
    }

}
