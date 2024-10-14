using HarmonyLib;
using ZhanGuoWuxia.Backend.Logics;
using ZhanGuoWuxia.Backend.RuntimeData;
using ZhanGuoWuxia.CSharpModSupport;
using ZhanGuoWuxia.Lua;

namespace xfg_csharp_sample
{
    public class SamplePatcher : Patcher
    {
        private Harmony m_PatchInstance;

        public override void Initialize()
        {
            m_PatchInstance = new Harmony("com.xfg.csharp_sample");
            m_PatchInstance.PatchAll();
        }

        public override void UnInitialize()
        {
            if (m_PatchInstance != null)
                m_PatchInstance.UnpatchAll();
        }



        [HarmonyPatch(typeof(MenpaiLogic), nameof(MenpaiLogic.AddItem))]
        public class ItemPatcher
        {
            //这个补丁会在每次玩家获得道具时修改道具数量为999
            static void Prefix(MenpaiInstance menpai, ICreator creator, string itemId, ref uint count, string affixFormula = null)
            {
                if (menpai == null)
                    return;

                if (!LuaBridge.IsPlayerMenpai(menpai))
                    return;

                count = 999;
            }
        }
    }
}
