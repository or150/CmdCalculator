﻿using CmdCalculator.Interfaces.Tokens;

namespace CmdCalculator.Tokenization
{
    class StringInputReaderFactory : IInputReaderFactory<string, char>
    {
        public IInputReader<char> Create(string input)
        {
            return new StringInputReader(input);
        }
    }
}