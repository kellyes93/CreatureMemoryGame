using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Material cardColor;
    public int numCard = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print (numCard.ToString ());
    }

    public void PutColor(Material color_)
    {
        GetComponent<MeshRenderer>().material = color_;
        cardColor = color_;
    }
}
