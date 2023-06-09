using UnityEngine;

public class ChestDetect : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("isOpen", true);

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("isOpen", false);
    }
}
