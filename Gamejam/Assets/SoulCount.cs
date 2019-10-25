using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoulCount : MonoBehaviour
{
    float fillAmount = 0.975f / 5f;
    public int souls = 0;
    Image image;

    // Debug add and remove souls.
    private void Update()
    {
        //if (Input.GetKeyDown("f"))
        //    AddSoul();
        //if (Input.GetKeyDown("g"))
        //    RemoveSoul();
    }
    

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void AddSoul()
    {
        souls++;
        image.fillAmount += fillAmount;
    }

    public void RemoveSoul()
    {
        souls--;
        image.fillAmount -= fillAmount;
    }
}
