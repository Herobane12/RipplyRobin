using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject camObject1;
    public GameObject Button;
   public MoveCamera moveCamera;

    bool cam = true;

    void Start()
    {

    }

    public void StartGame()
    {
        moveCamera.MovingCamera();
        //Button.SetActive(false);
        moveCamera.isActive = true;
        camObject1.SetActive(cam);
    }   





}
