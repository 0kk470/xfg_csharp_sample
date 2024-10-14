using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using ZhanGuoWuxia.CSharpModSupport;
using ZhanGuoWuxia.Lua;

namespace xfg_csharp_sample
{
    public class SamplePatcher : Patcher
    {
        private Harmony _harmonyInstance;

        public override void Initialize()
        {
            _harmonyInstance = new Harmony("com.xfg.csharp_sample");
            _harmonyInstance.PatchAll();
        }

        public override void UnInitialize()
        {
            if (_harmonyInstance != null)
                _harmonyInstance.UnpatchAll();
        }

        //这个补丁会在每次调用LuaBridge.AddItemToPlayer前执行，用于修改增加的道具数量
        [HarmonyPatch(typeof(LuaBridge), nameof(LuaBridge.AddItemToPlayer))]
        public void AddItemToPlayer_Prefix(string itemId, ref int count, string affixFormula = null)
        {
            //扣道具的情况不处理
            if (count <= 0)
                return;

            count += 999;
        }
    }
}
