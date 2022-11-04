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
            if (npc.boss)
            {
                int counter = 0;
                for (int i = 0; i < Main.npc.Length; i++)
                {
                    if (Main.npc[i].type == npc.type)
                    {
                        counter++;
                    }
                }

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