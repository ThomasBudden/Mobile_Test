using UnityEngine;

public class CubeFallingScript : MonoBehaviour
{
    private Gyroscope gyro;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 down = gyro.attitude.eulerAngles;
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 0));
        Debug.Log("x" + down.x);
        Debug.Log("y" + down.y);
        Debug.Log("z" + down.z);

    }
}
