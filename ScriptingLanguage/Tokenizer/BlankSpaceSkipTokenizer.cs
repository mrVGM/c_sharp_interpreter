﻿using System;
using System.Collections.Generic;

namespace ScriptingLaunguage.Tokenizer
{
    public class BlankSpaceSkipTokenizer : ITokenizer
    {
        public IEnumerable<IndexedToken> Tokenize(IEnumerable<IndexedToken> script)
        {
            foreach (var token in script) 
            {
                if (token.Name == Environment.NewLine || token.Name == " " || token.Name == "\t")
                {
                    continue;
                }
                yield return token;
            }
        }
    }
}