using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    private GameObject wintText;
    
    public static bool youWin;
    
    void Start()
    {
        wintText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(pictures[0].rotation.z) < 0.01f &&
           Mathf.Abs(pictures[1].rotation.z) < 0.01f &&
           Mathf.Abs(pictures[2].rotation.z) < 0.01f &&
           Mathf.Abs(pictures[3].rotation.z) < 0.01f)
        {
            youWin = true;
            wintText.SetActive(true);
        }
    }
}
