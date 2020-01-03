using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
	public void SetText(string text)
	{
		Text txt = transform.Find("Text").GetComponent<Text>();
		txt.text = text;
	}

    //Von 2 in 1
    public void SwitchScene1()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    //von 1 in 2
    public void SwitchScene2()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }


}
