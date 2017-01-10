using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addscore_r : MonoBehaviour
{

    private int prscore = 0;
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
        if (other.gameObject.CompareTag("gf") || other.gameObject.CompareTag("yf") || other.gameObject.CompareTag("bf"))
        {
            prscore++;
            SetDisplay();
        }
    }

    void SetDisplay()
    {
        if (prscore == 3)
        {
            //Destroy(gameObject.Find("addscore_r"));
            //destroy addscore_y
            //destroy addscore_b
            //change display to "Green Wins"
            display.text = "Red Wins!";

            //end or restart game
        }

        display.text = "Red " + prscore;
    }
}
