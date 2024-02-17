namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState33 : LexicalStateBase
    {
        #region constructors
        public LexicalState33(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 's')
            {
                _lexicalAnalyzer.changeState(new LexicalState34(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'r') || (symbol >= 't' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}