using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeightDisplayer : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Height : " + (int)_playerController.transform.position.y;
    }
}
