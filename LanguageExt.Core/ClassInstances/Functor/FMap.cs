﻿using System;
using LanguageExt.TypeClasses;
using static LanguageExt.Prelude;
using System.Collections.Generic;

namespace LanguageExt.ClassInstances
{
    public struct FMap<K, A, B> : 
        Functor<Map<K, A>, Map<K, B>, A, B>
    {
        public static readonly FMap<K, A, B> Inst = default(FMap<K, A, B>);

        public Map<K, B> Map(Map<K, A> ma, Func<A, B> f) =>
            ma.Map(f);
    }
}
