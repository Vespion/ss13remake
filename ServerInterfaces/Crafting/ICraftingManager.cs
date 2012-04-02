using Lidgren.Network;
using ServerInterfaces.GameObject;
using ServerInterfaces.Network;
using ServerInterfaces.Player;
using SS13_Shared.GO.Crafting;

namespace ServerInterfaces.Crafting
{
    public interface ICraftingManager
    {
        void removeTicketByConnection(NetConnection connection);
        bool isValidRecipe(string compo1, string compo2);
        void HandleNetMessage(NetIncomingMessage msg);
        void HandleCraftRequest(NetIncomingMessage msg);
        void Update();
        CraftingEntry getRecipe(string compo1, string compo2);

        void BeginCrafting(IEntity compo1, IEntity compo2, IEntity source, NetConnection sourceConnection) //Check for components and remove.
            ;

        void Initialize(string craftingListLoc, ISS13Server server);
        void Save();
    }
}