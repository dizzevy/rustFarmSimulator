using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryMenu : MonoBehaviour
{
    public bool invMenu;
    public GameObject invGameMenu;

    public void Resume()
    {
        invGameMenu.SetActive(false);
        Time.timeScale = 1.0f;
        invMenu = false;
    }

    public void toInv()
    {
        invGameMenu.SetActive(true);
        Time.timeScale = 0f;
        invMenu = true;
    }
}
