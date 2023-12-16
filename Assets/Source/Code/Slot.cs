using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
   public void Des()
   {
      GameObject explosion = Instantiate(GameManager.Instance.particleVFXs[Random.Range(0,GameManager.Instance.particleVFXs.Count)], transform.position, transform.rotation);
      Destroy(explosion, .75f);
      GameManager.Instance.GetCurLevel().listPlayer.Remove(this);
      Destroy(gameObject);
   }
}
