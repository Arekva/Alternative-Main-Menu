using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AlternativeMainMenus
{
    class Time
    {
        public static void WaitSecond(Single WaitTime, Action callback)
        {
            IEnumerator<WaitForSeconds> Waiter()
            {
                yield return new WaitForSeconds(WaitTime);
                callback();
            }

            HighLogic.fetch.StartCoroutine(Waiter());
        }
    }
}
