using UnityEngine;

public class ChestDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //play chest static
        print("static");
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //play chestopen and hold last frame
        print("open");

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        //play chest close
        print("close");
        //play chest static
    }
}
