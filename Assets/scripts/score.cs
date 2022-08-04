using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public static int Pincount;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        Pincount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Pincount.ToString();
    }
}
