using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public GameObject cardPrefab;
    public int width;
    public int high;

    public Material withe;
    public Material black;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create()
    {
        int cont = 0;
        for (int i=0; i<width; i++)
            for(int x=0; x<high; x++)
            {
                GameObject cardTemp = Instantiate(cardPrefab, new Vector3(x, 0, i), Quaternion.identity);

                cardTemp.GetComponent<Card>().numCard = cont;
            }
    }
}
