using UnityEngine;

public class BreakableScript : MonoBehaviour
{
    public void Break()
    {
        Destroy(gameObject);
        Debug.Log("broke");
    }
    
    
}
