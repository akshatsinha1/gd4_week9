using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animator anim;
    [SerializeField] Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(transform.position, player.position) < 3)
        {
            anim.SetTrigger("OpenDoor");
            anim.SetBool("isDoorClosed", !anim.GetBool("isDoorClosed"));
        }
    }
}
