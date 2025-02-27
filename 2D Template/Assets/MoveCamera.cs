using Unity.VisualScripting;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Rigidbody2D _rb;
    public GameObject camObject1;
    public GameObject gameScene;
    public float speed;

    public bool isActive = false, moved = false;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void MovingCamera()
    {
        moved = true;

        if (moved)
        {
            while (Vector2.Distance(transform.position, gameScene.transform.position) > 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, gameScene.transform.position, speed * Time.deltaTime);

            }
            while (Vector2.Distance(gameScene.transform.position, transform.position) == 0)
            {
                transform.position = gameScene.transform.position;
            }

            moved = false;
        }


        //if (moved == false)
        //{


        //if (camObject1.transform.position.x <= -1.62)
        // {
        //  moved = true;
        //}
        // }



    }

    private void Update()
    {
       

        
        
        
    }
}

