using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addscore_g : MonoBehaviour
{

    private int pgscore = 0;
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
        if (other.gameObject.CompareTag("rf") || other.gameObject.CompareTag("yf") || other.gameObject.CompareTag("bf"))
        {
            pgscore++;
            SetDisplay();
        }
    }

    void SetDisplay()
    {
        if(pgscore == 3)
        {
            //Destroy(gameObject.Find("addscore_r"));
            //destroy addscore_y
            //destroy addscore_b
            //change display to "Green Wins"
            display.text = "Green Wins!";

            //end or restart game
        }
        display.text = "Green " + pgscore;
    }
}
