using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;


public class CameraSwitcher : MonoBehaviour
{

    public CinemachineCamera camMain;
    public CinemachineCamera camClose;
    public CinemachineCamera camTop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            SetCamera(camTop);
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            SetCamera(camClose);
        }

        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            SetCamera(camMain);
        }
    }

    public void SetCamera(CinemachineCamera cam)
    {
        camMain.Priority = 0;
        camClose.Priority = 0;
        camTop.Priority = 0;

        cam.Priority = 10;
    }
}
