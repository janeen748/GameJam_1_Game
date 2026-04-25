using UnityEngine;



public class PressurePlate : MonoBehaviour
{
    public GameObject door;
    public float pressDepth = 0.1f;
    private Vector3 startPos;
    private int objectsOnTop = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player")|| (other.CompareTag("MoveableObj")))
        {
            objectsOnTop++;
                UpdateState();

            Debug.Log("Player");

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player" )|| (other.CompareTag("MoveableObj")) )
        {
            objectsOnTop--;
            UpdateState();

            
        }
    }

    void UpdateState()
    {
        if(objectsOnTop > 0)
        {
            transform.position = startPos - new Vector3(0, pressDepth, 0);

            
            door.GetComponent<Animator>().SetBool("DoorPressed", true);
        }
        else
        {
            transform.position = startPos;
            
            door.GetComponent<Animator>().SetBool("DoorPressed", false);
        }
    }
}
