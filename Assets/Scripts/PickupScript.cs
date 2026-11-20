using UnityEngine;
using UnityEngine.Animations;



public class PickupScript : MonoBehaviour
{
    public ParentConstraint pc;
    
    
    public void PickUp()
    {
        Debug.Log("Picked up");
        pc.constraintActive = true;
        
    }
}
