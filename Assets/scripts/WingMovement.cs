using UnityEngine;
using UnityEngine.UIElements;

public class ButterflyMovement : MonoBehaviour
{
    public float FlyAmplitude;
    public float FlyFrequency;
    public float FlyAmplitude;
    public float WingAmplitude;
    public float WingFrequency;
    public float speed;
    Vector3 Rotaion;
    Vector3 Position;

    GameObject RearWingR;
    GameObject FrontWingR;
    GameObject RearWingL;
    GameObject RearWingR;


    void Start()
    {
        Position = transform.position;
        RearWingL = GameObject.Find("RearWingL").transform;
        RearWingR = GameObject.Find("RearWingR").transform;
        FrontWingL = GameObject.Find("FrontWingL").transform;
        FrontWingR = GameObject.Find("FrontWingR").transform;

        Direction = new Vector3

    }

    void Update()
    {
        FlyMotion();
        WingMotion();
    }

    void WingMotion()
    {
        Rotation.z = WingAmplitude * Mathf.Sin(2*Mathf.PI*WingFrequency*Time.time);

        RearWingL.transform.eulerAngles = - Rotaion;
        RearWingR.transform.eulerAngles = Rotaion;
        FrontWingL.transform.eulerAngles = - Rotaion;
        FrontWingR.transform.eulerAngles = Rotaion;

    }

    void FlyMotion()
    {
        position.y = FlyAmplitude * Mathf.Sin(2 * Mathf.PI * FlyFrequency * Time.time);
        position += direction * speed * Time.deltaTime;
        transform.position = position;
    }
} 
