using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinScript : MonoBehaviour
{
    public GameObject Obstacles, winPanel,levelshow,Clevel;
    bool gamewin;
    public int winCond = 0;
    public LevelManager levelManager;
    public GameObject ballThrower;
     

    // Start is called before the first frame update
    void Start()
    {
        //winPanel = GameObject.Find("Panel"); 
        winPanel.SetActive(false);
        //Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
    }

    // Update is called once per frame
    void Update()
    {

        GameWin();

    }
    public void GameWin()
    {
        gamewin = true;
        int count = 0;
        for (int i = 0; i < Obstacles.transform.childCount; i++)
        {
            if (Obstacles.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                count++;
                //gamewin = false;
                

            }

        }
        if (count > winCond)
            gamewin = false;
        

        if (gamewin == false)
        {
            //Debug.Log(" still left");
            levelshow.SetActive(true);
        }
        else
        {
            //Debug.Log(" you won ??!!!!!");
            ballThrower.SetActive(false);
            
            winPanel.SetActive(true);
            levelshow.SetActive(false);
            Clevel.SetActive(false);
        }
    }

    public void NextLevel()
    {
        StartCoroutine(levelManager.LoadNextLevel());

        //levelManager.LoadNextLevel();
    }


}
