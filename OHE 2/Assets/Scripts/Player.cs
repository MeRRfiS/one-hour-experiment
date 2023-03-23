using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealt = 1000;
    public int health = 300;
    public int numberOfBook = 0;
    public Slider slider; 

    private void Update()
    {
        slider.value = health;

        if (health <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
        if(numberOfBook == 5)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
