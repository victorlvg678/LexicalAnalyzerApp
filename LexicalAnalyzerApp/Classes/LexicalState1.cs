namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState1 : LexicalStateBase
    {
        #region constructors
        public LexicalState1(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                _lexicalAnalyzer.changeState(new LexicalState1(_lexicalAnalyzer));
                return;
            }

            if (symbol == '.')
            { 
                _lexicalAnalyzer.changeState(new LexicalState2(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}