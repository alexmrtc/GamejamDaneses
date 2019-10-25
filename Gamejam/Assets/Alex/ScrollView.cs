using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollView : MonoBehaviour
{
    public GameObject character;
    public Material material;
    public bool moving;
    public float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            material.SetTextureOffset() + offsetX;
        }
    }
}
