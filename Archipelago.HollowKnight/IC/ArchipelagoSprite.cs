﻿using ItemChanger;
using ItemChanger.Internal;

namespace Archipelago.HollowKnight.IC
{
    public class ArchipelagoSprite : EmbeddedSprite
    {
        public override SpriteManager SpriteManager => Archipelago.Instance.spriteManager;
    }
}
