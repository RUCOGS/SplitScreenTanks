using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addscore_y : MonoBehaviour
{

    private int pyscore = 0;
    public Text display;

    // Use this for initialization
    void Start()
    {
        SetDisplay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gf") || other.gameObject.CompareTag("rf") || other.gameObject.CompareTag("bf"))
        {
            pyscore++;
            SetDisplay();
        }
    }

    void SetDisplay()
    {
        if (pyscore == 3)
        {
            //Destroy(gameObject.Find("addscore_r"));
            //destroy addscore_y
            //destroy addscore_b
            //change display to "Green Wins"
            display.text = "Yellow Wins!";

            //end or restart game
        }

        display.text = "Yellow " + pyscore;
    }
}
