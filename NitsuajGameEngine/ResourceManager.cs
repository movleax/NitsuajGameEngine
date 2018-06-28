using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitsuajGameEngine
{
    static class ResourceManager
    {
        private static Dictionary<string, SpritePrototype> SpriteTable;

        public static void AddSprite(string SpriteName, SpritePrototype NewSprite)
        {
            if (SpriteTable == null)
                SpriteTable = new Dictionary<string, SpritePrototype>();

            SpriteTable.Add(SpriteName, NewSprite);
        }

        public static Sprite GetSprite(string SpriteName)
        {
            if (SpriteTable == null)
                throw new System.NullReferenceException("There are no Sprites defined!");

            if(!SpriteTable.ContainsKey(SpriteName))
                throw new System.ArgumentException("Sprite does not exist");

            return (Sprite)SpriteTable[SpriteName].CreateCopy();
        }
    }
}
