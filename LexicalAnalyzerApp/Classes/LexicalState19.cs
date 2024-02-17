namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState19 : LexicalStateBase
    {
        #region constructors
        public LexicalState19(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 't')
            {
                _lexicalAnalyzer.changeState(new LexicalState20(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 's') || (symbol >= 'u' && symbol <= 'z')  || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }


            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}