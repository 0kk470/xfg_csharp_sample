using System;
using System.Collections.Generic;
using System.Text;
using ZhanGuoWuxia.CSharpModSupport;
using ZhanGuoWuxia.InputCore;
using ZhanGuoWuxia.UI;
using ZhanGuoWuxia.UI.DevelopTool;

namespace xfg_csharp_sample
{
    public class SamplePlugin : Plugin
    {
        void Update()
        {
            if(GameInput.GetKeyDown(UnityEngine.KeyCode.F1))
            {
                UIManager.Instance.Show<UIConsole>();
            }
        }
    }
}
