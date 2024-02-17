namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState37 : LexicalStateBase
    {
        #region constructors
        public LexicalState37(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'o')
            {
                _lexicalAnalyzer.changeState(new LexicalState38(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'n') || (symbol >= 'p' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}