using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;
using UnityEngine.UI;
// public class ButtonClick : Button
// {
//   public override void OnPointerDown(PointerEventData eventData)
//   {
//     PlayClip("ButtonUp");
//   }
//
//   public override void OnPointerUp(PointerEventData eventData)
//   {
//     PlayClip("ButtonDown");
//   }
//
//   private static void PlayClip(string n)
//   {
//     var clip = Addressables.LoadAssetAsync<AudioClip>(n).WaitForCompletion();
//     AudioSource.PlayClipAtPoint(clip, Vector3.zero);
//   }
// }

public class ButtonClick : MonoBehaviour
{
    private static void PlayClip()
    {
       
    }
}
