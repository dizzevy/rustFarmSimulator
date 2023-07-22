using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data.SqlTypes;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class clickBarel : MonoBehaviour
{

    public void BarrelButtonClick()
    {
        ScrapManager.scrap++;
        ScrapManager.total_scrap++;
        PlayerPrefs.SetInt("Scrap", ScrapManager.scrap);
        PlayerPrefs.SetInt("Total_scrap", ScrapManager.total_scrap);
    }

}
