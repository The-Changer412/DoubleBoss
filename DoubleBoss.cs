using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace DoubleBoss
{
	public class DoubleBoss : Mod
	{

	}

	public class ModifyNPCS : GlobalNPC
	{
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            //check if npc is boss
            if (npc.boss)
            {
                //count how many bosses are alive at the moment
                int counter = 0;
                for (int i = 0; i < Main.npc.Length; i++)
                {
                    if (Main.npc[i].type == npc.type)
                    {
                        counter++;
                    }
                }

                //if there is only one of that boss, then spawn it in
                if (counter == 1)
                {
                    NPC.NewNPC(npc.GetSource_FromThis(), (int)npc.position.X, (int)npc.position.Y, npc.type);
                    counter++;
                }
            }
            base.OnSpawn(npc, source);
        }
    }
}