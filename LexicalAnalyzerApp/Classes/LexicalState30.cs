﻿namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState30 : LexicalStateBase
    {
        #region constructors
        public LexicalState30(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'n')
            {
                _lexicalAnalyzer.changeState(new LexicalState31(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'm') || (symbol >= 'o' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}