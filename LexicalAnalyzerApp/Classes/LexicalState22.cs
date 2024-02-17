namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState22 : LexicalStateBase
    {
        #region constructors
        public LexicalState22(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'i')
            {
                _lexicalAnalyzer.changeState(new LexicalState23(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'h') || (symbol >= 'j' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}