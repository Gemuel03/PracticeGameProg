using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) //itong parameter is to ensure na hindi lahat ng nata-touch na object is considered na agad as a collision, for example sa ground - madedetect agad na collision kase may rigidbody din when in fact ang gusto mo lang naman na collision is through obstacles
    {
        if (collisionInfo.collider.tag == "Obstacle") //itong .tag is para kahit gaano kadaming obstacles is para yung tag nalang nila icchange mo and macoconsider na sila as obstacles, bali same functionalities na sila lahat which is for collision
        {
            //movement.enabled = false;
        }
    }
    
}
