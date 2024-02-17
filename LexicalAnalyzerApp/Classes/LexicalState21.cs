namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState21 : LexicalStateBase
    {
        #region constructors
        public LexicalState21(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'h')
            {
                _lexicalAnalyzer.changeState(new LexicalState22(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'g') || (symbol >= 'i' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}