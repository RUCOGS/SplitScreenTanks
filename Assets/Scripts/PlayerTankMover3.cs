using UnityEngine;

public class PlayerTankMover3 : MonoBehaviour
{
    //public int PlayerNum = 1;
    public float Speed = 12f;
    public float TurnSpeed = 180f;

    private string MovementAxisName;
    private string TurnAxisName;
    private Rigidbody RBody;
    private float MovementInputVal;
    private float TurnInputVal;
    private Vector3 startloc;
    private int deathcd = 0;
    private bool flagStolen = false;
    private bool holdingFlag = false;

    private void Awake()
    {
        RBody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        RBody.isKinematic = false;

        MovementInputVal = 0f;
        TurnInputVal = 0f;
    }

    private void OnDisable()
    {
        RBody.isKinematic = true;
    }

    private void Start()
    {
        MovementAxisName = "3LVert";
        TurnAxisName = "3LHorz";
    }

    private void FixedUpdate()
    {
        Move();
        Turn();
    }

    private void Update()
    {
        MovementInputVal = Input.GetAxis(MovementAxisName);
        TurnInputVal = Input.GetAxis(TurnAxisName);

        if (!transform.GetChild(0).gameObject.activeSelf)
        {
            deathcd += 1;
            if (deathcd >= 900)
            {
                deathcd = 0;
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(0).position = startloc;
            }
        }

        //taken enemy flag?

        //my flag stolen?
        //green? red? yellow? blue?
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rf") || other.gameObject.CompareTag("yf") || other.gameObject.CompareTag("bf"))
        {
            if (holdingFlag == false)
            {
                holdingFlag = true;
            }
        }
    }

    private void Move()
    {
        Vector3 movement = transform.forward * MovementInputVal * Speed * Time.deltaTime;

        RBody.MovePosition(RBody.position + movement);
    }

    private void Turn()
    {
        float turn = TurnInputVal * TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        RBody.MoveRotation(RBody.rotation * turnRotation);
    }
}