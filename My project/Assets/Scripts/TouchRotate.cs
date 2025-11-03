using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youWin) // youWin a bool variable from another class
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
