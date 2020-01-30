using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdviceScript : MonoBehaviour
{
    public GameObject[] Panels = new GameObject[3];
    private int Count = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject Panel in Panels)
        {
            Panel.SetActive(false);
        }
        Panels[Count].SetActive(true);
    }


    public void NextAdvice()
    {
        if(Count == 3)
        {
            //ButtonHandler.SwitchToNextScene();
            int SceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(sceneBuildIndex: SceneIndex);
        } else
        {
            Panels[Count].SetActive(true);
            if (Count != 0)
            {
                Panels[Count - 1].SetActive(false);
            }
            Count++;
        }
        
    }
}
