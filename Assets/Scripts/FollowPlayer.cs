using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{ 

    public Transform player;
    //vector is parang float pero kaya niya magstore ng 3 numbers unlike sa float na isa lang
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
