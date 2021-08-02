using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreanTransrateScript : MonoBehaviour
{
    [SerializeField] Transform m_someObject = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 screenPosition = Input.mousePosition;
            var worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            Debug.Log(worldPosition.ToString());
            worldPosition.z = 0;
            m_someObject.position = worldPosition;
        }
    }
}
