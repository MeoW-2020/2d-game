using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite hatfFullHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue playerCurrentValue;

    // Start is called before the first frame update
    void Start()
    {
        InitHearts();
    }

    public void InitHearts()
    {
        for (int i = 0; i < heartContainers.initialValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }

    public void UpdateHearts()
    {
        float tempHealth = playerCurrentValue.RuntimeValue / 2;
        for(int i = 0; i < heartContainers.initialValue; i++)
        {
            if(i <= tempHealth-1)
            {
                hearts[i].sprite = fullHeart;
            }
            else if(i >= tempHealth)
            {
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                hearts[i].sprite = hatfFullHeart;
            }
        }
    }
}
