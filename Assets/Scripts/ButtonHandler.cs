using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public bool ImageExpanded = false;


    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }

    public void SwitchToNextScene()
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log("gedrueckt: Gehe zu Scene "+ SceneIndex);
        SceneManager.LoadScene(sceneBuildIndex: SceneIndex);
    }

    public void SwitchToBackScene()
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        Debug.Log("gedrueckt: Gehe zu Scene " + SceneIndex);
        SceneManager.LoadScene(sceneBuildIndex: SceneIndex);
    }

    public void StartIntroduction()
    {
        Debug.Log("gedrueckt start Introduction, Scene 1");
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void goHome()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void ToggleScanImage()
    {

        if (GameObject.Find("ScanNext").tag.Contains("minimizedScan"))
        {
            GameObject.Find("ScanNext").tag = "expandedScan";
            GameObject.Find("ScanNextImageBig").GetComponent<Image>().enabled = true;

        }
        else
        {
            GameObject.Find("ScanNext").tag = "minimizedScan";
            GameObject.Find("ScanNextImageBig").GetComponent<Image>().enabled = false;
        }

    }

    public void MinimizeScanImage()
    {
       
        GameObject.Find("ScanNext").tag = "minimizedScan";
        GameObject.Find("ScanNextImageBig").GetComponent<Image>().enabled = false;

    }

    public void ShowFinishedPanel(GameObject Panel)
    {
        Panel.SetActive(true);
        GameObject BackButton = GameObject.Find("BackButton");
        Debug.Log(">>>>>>>>>>>>> " + BackButton);
        BackButton.SetActive(false);
    }


}