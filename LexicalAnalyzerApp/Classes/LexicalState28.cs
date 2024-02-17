namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState28 : LexicalStateBase
    {
        #region constructors
        public LexicalState28(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'u')
            {
                _lexicalAnalyzer.changeState(new LexicalState29(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 't') || (symbol >= 'v' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}