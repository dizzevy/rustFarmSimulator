using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScrapManager : MonoBehaviour
{
    public static int scrap;
    public static int total_scrap;
    public TMP_Text sScore;
    public TMP_Text InvSScore;

    private void Start()
    {
        scrap = PlayerPrefs.GetInt("Scrap");
        total_scrap = PlayerPrefs.GetInt("Total_scrap");
    }

    private void Update()
    {
        sScore.text = ": " + scrap;
        InvSScore.text = ": " + scrap;
    }
}
