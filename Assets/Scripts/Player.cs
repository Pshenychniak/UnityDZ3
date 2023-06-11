using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _loseText;
    [SerializeField] private TMP_Text _winText;

    private void OnCollisionStay(Collision other)
       {
           if (other.gameObject.CompareTag("Finish"))
           {
               
               _loseText.gameObject.SetActive(true);
           } 
           if (other.gameObject.CompareTag("Respawn"))
           {
               
               _winText.gameObject.SetActive(true);
           } 
       }
}
