using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject camObject1, camObject2;
    bool cam = true;
    bool cam2 = false;

    public bool isActive;
    public GameObject Button;

    void Start()
    {
        bool cam = true;
        bool cam2 = false;
    }

    public void Activate()
    {
        Button.SetActive(true);
        isActive = true;
    }

    public void DeActivate()
    {
        Button.SetActive(false);
        isActive = false;
    }


    void SwapCamera()
    {
        
        
            bool cam = false;
            bool cam2 = true;
        
    }

    private void Update()
    {
        camObject1.SetActive(cam);
        camObject2.SetActive(cam2);
    }
}
