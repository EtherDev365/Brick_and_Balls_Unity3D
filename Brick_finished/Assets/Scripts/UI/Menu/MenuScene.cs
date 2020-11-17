using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScene : MonoBehaviour
{
    public GameObject[] levels;
    public Image forwardButton;
    public Image backwardButton;
    public Sprite[] buttonSprites;
   
    int levelCount = 0;
    // Start is called before the first frame update

   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ForwardClick()
    {
        levelCount++;

        if (Mathf.Abs( levelCount) < levels.Length)
        {            
            for (int i = 0; i < levels.Length; i++)
            {
                levels[i].SetActive(false);
            }

            levels[levelCount].SetActive(true);
            backwardButton.sprite = buttonSprites[1];
            forwardButton.sprite = buttonSprites[1];
        }

        if (levelCount == levels.Length - 1)
        {
            forwardButton.sprite = buttonSprites[0];
            backwardButton.sprite = buttonSprites[1];
        }       
    }

    public void Backwardclick()
    {
        if (levelCount == 0)
        {
            backwardButton.sprite = buttonSprites[0];
            forwardButton.sprite = buttonSprites[1];
        }
        else if (Mathf.Abs(levelCount) < levels.Length - 1)
        {
            levelCount--;

            for (int i = 0; i < levels.Length; i++)
            {
                levels[i].SetActive(false);
            }
            
            backwardButton.sprite = buttonSprites[1];

            if (levelCount < 0)
            {
                forwardButton.sprite = buttonSprites[0];
                levels[levels.Length + levelCount].SetActive(true);
            }
            else
            {
                forwardButton.sprite = buttonSprites[1];
                levels[levelCount].SetActive(true);
            }
        }
    }
}
