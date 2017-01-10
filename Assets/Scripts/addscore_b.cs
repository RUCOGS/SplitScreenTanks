using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addscore_b : MonoBehaviour
{

    private int pbscore = 0;
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
        if (other.gameObject.CompareTag("gf") || other.gameObject.CompareTag("rf") || other.gameObject.CompareTag("yf"))
        {
            pbscore++;
            SetDisplay();
        }
    }

    void SetDisplay()
    {
        if (pbscore == 3)
        {
            //Destroy(gameObject.Find("addscore_r"));
            //destroy addscore_y
            //destroy addscore_b
            //change display to "Green Wins"
            display.text = "Blue Wins!";

            //end or restart game
        }

        display.text = "Blue " + pbscore;
    }
}
