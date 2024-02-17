namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState17 : LexicalStateBase
    {
        #region constructors
        public LexicalState17(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'f')
            {
                _lexicalAnalyzer.changeState(new LexicalState18(_lexicalAnalyzer));
                return;
            }

            if (symbol == 'n')
            {
                _lexicalAnalyzer.changeState(new LexicalState19(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'e') || (symbol >= 'g' && symbol <= 'm') || (symbol >= 'o' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}