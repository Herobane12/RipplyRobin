using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject camObject1;
    public GameObject Button;
    public GameObject title;
   public MoveCamera moveCamera;

    bool cam = true;

    void Start()
    {

    }

    public void StartGame()
    {
        moveCamera.MovingCamera();
        moveCamera.isActive = true;
        camObject1.SetActive(cam);
        Button.SetActive(false);
        title.SetActive(false);
    }   





}
