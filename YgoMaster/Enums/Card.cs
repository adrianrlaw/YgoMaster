﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YgoMaster
{
    /// <summary>
    /// YgomGame.Card.Content.Frame
    /// </summary>
    enum CardFrame
    {
        Normal,
        Effect,
        Ritual,
        Fusion,
        Oberisk,
        Osiris,
        Ra,
        Magic,
        Trap,
        Token,
        Sync,
        Dsync,
        Xyz,
        Pend,
        PendFx,
        XyzPend,
        SyncPend,
        FusionPend,
        Link
    }

    /// <summary>
    /// YgomGame.Card.Content.Kind
    /// </summary>
    enum CardKind
    {
        Normal,
        Effect,
        Fusion,
        FusionFx,
        Ritual,
        RitualFx,
        Toon,
        Spirit,
        Union,
        Dual,//Gemini
        Token,
        God,
        Dummy,
        Magic,
        Trap,
        Tuner,
        TunerFx,
        Sync,
        SyncFx,
        SyncTuner,
        Dtuner,
        Dsync,
        Xyz,
        XyzFx,
        Flip,
        Pend,
        PendFx,
        SpEffect,
        SpToon,
        SpSpirit,
        SpTuner,
        SpDtuner,
        FlipTuner,
        PendTuner,
        XyzPend,
        PendFlip,
        SyncPend,
        UnionTuner,
        RitualSpirit,
        FusionTuner,
        SpPend,
        FusionPend,
        Link,
        LinkFx,
        PendNTuner,
        PendSpirit
    }

    /// <summary>
    /// YgomGame.Card.Content.Icon
    /// </summary>
    enum CardIcon
    {
        Null,
        Counter,
        Field,
        Equip,
        Continuous,
        QuickPlay,
        Ritual
    }
}
