﻿using Takenet.Text.Metadata;

namespace Takenet.Text.Types
{
    /// <summary>
    /// Represents an integer number token type.
    /// </summary>
    [TokenType(ShortName = "Integer")]
    public class IntegerTokenType : ValueTokenTypeBase<int>
    {
        public IntegerTokenType(string name, bool isContextual, bool isOptional, bool invertParsing)
            : base(name, isContextual, isOptional, invertParsing)
        {
        }
    }
}