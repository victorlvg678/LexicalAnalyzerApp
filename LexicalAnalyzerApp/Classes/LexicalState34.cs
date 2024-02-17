namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState34 : LexicalStateBase
    {
        #region constructors
        public LexicalState34(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'e')
            {
                _lexicalAnalyzer.changeState(new LexicalState35(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'd') || (symbol >= 'f' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}